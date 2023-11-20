using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

public class BaseTest
{
    public IBrowser Browser;
    public IBrowserContext Context;
    public IPage Page;

    [SetUp]
    public async Task SetUpAsync()
    {
        var playwright = await Playwright.CreateAsync(); // Corrected method call

        var launchOptions = new BrowserTypeLaunchOptions
        {
            Headless = false // This will launch the browser with UI
        };

        Browser = await playwright.Chromium.LaunchAsync(launchOptions);

        // Customize your browser context options here
        var options = new BrowserNewContextOptions
        {
            // Example: Set the viewport size, timezone, etc.
            ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
            TimezoneId = "America/New_York",
        };

        Context = await Browser.NewContextAsync(options);
        Page = await Context.NewPageAsync();
    }

    [TearDown]
    public async Task TearDownAsync()
    {
        await Context.CloseAsync();
        await Browser.CloseAsync();
    }
}