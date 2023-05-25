using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SmallsOnline.Weather.Lib.Models.NWS;
using SmallsOnline.Weather.Lib.Services.NWS;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace SmallsOnline.Weather.WebApp.Pages;

[SupportedOSPlatform("browser")]
public partial class AreaForecastDiscussion : ComponentBase
{
    [Inject]
    protected INwsService _nwsService { get; set; } = null!;

    [Inject]
    protected NavigationManager _navigationManager { get; set; } = null!;

    [Inject]
    protected ILogger<AreaForecastDiscussion> _logger { get; set; } = null!;

    [Inject]
    protected IJSRuntime _jsRuntime { get; set; } = null!;

    [Parameter]
    public string? OfficeId { get; set; } = "RAH";

    private bool _isLoading = false;
    private GraphCollection<TextProduct>? _textProduct;
    private TextProduct? _textProductEntry;
    private OfficeIds _officeIds = new();
    private IJSObjectReference? _localStorageModule;

    protected override async Task OnInitializedAsync()
    {
        await JSHost.ImportAsync("localStorageModule", "../assets/js/local-storage.js");
    }

    protected override async Task OnParametersSetAsync()
    {
        _isLoading = true;

        if (OfficeId is null)
        {
            _navigationManager.NavigateTo(
                uri: "/afd/RAH",
                forceLoad: false
            );

            return;
        }

        _logger.LogInformation("Attempting to get latest AFD entry from local storage.");

        string? localEntry = GetLocalStorageItem("latestAfdEntry");

        if (localEntry is not null)
        {
            _textProductEntry = JsonSerializer.Deserialize<TextProduct>(localEntry);
            _logger.LogInformation("Loaded latest AFD entry ({AfdId}) from local storage.", _textProductEntry!.Id);

            _isLoading = false;
            return;
        }

        await GetLatestAfdEntry();

        _isLoading = false;
    }

    private async Task GetLatestAfdEntry()
    {
        _textProduct = await _nwsService.GetProductEntriesAsync("AFD", OfficeId!);

        if (_textProduct is not null && _textProduct.Values is not null)
        {
            _textProductEntry = await _nwsService.GetProductEntryAsync(_textProduct.Values.First().Id);
        }

        SetLocalStorageItem("latestAfdEntry", JsonSerializer.Serialize(_textProductEntry));
        _logger.LogInformation("Saved latest AFD entry ({AfdId}) to local storage.", _textProductEntry!.Id);
    }

    private async Task HandleManualRefresh()
    {
        _isLoading = true;

        await GetLatestAfdEntry();

        _isLoading = false;
    }

    [JSImport("setStorageItem", "localStorageModule")]
    internal static partial void SetLocalStorageItem(string key, string value);

    [JSImport("getStorageItem", "localStorageModule")]
    internal static partial string? GetLocalStorageItem(string key);
}