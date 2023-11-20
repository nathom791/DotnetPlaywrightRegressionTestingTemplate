using DotnetPlaywrightRegressionTestingTemplate;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : BaseTest
{
    [Test]
    public async Task SearchTests()
    {
        var loginPage = new LoginPage(Page);
        await loginPage.LoginAsync("standard_user", "secret_sauce");

        await Page.GotoAsync("https://www.saucedemo.com/");

        await Page.Locator("[data-test=\"username\"]").ClickAsync();

        await Page.Locator("[data-test=\"username\"]").FillAsync("standard_user");

        await Page.Locator("[data-test=\"username\"]").PressAsync("Tab");

        await Page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");

        await Page.Locator("[data-test=\"password\"]").PressAsync("Enter");

        await Page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]").ClickAsync();

        await Page.Locator("a").Filter(new() { HasText = "1" }).ClickAsync();

        await Page.Locator("[data-test=\"checkout\"]").ClickAsync();

        await Page.Locator("[data-test=\"firstName\"]").ClickAsync();

        await Page.Locator("[data-test=\"firstName\"]").FillAsync("Ned");

        await Page.Locator("[data-test=\"firstName\"]").PressAsync("Tab");

        await Page.Locator("[data-test=\"lastName\"]").FillAsync("Thompson");

        await Page.Locator("[data-test=\"lastName\"]").PressAsync("Tab");

        await Page.Locator("[data-test=\"postalCode\"]").FillAsync("33919");

        await Page.Locator("[data-test=\"postalCode\"]").PressAsync("Tab");

        await Page.Locator("[data-test=\"cancel\"]").PressAsync("Tab");

        await Page.Locator("[data-test=\"continue\"]").ClickAsync();

        await Page.GetByText("Item total: $29.99").ClickAsync();

        await Page.GetByText("Price Total").ClickAsync();

        await Page.GetByText("Tax: $2.40").ClickAsync();

        await Page.GetByText("Free Pony Express Delivery!").ClickAsync();

        await Page.GetByText("Shipping Information").ClickAsync();

        await Page.GetByText("SauceCard #31337").ClickAsync();

        await Page.GetByText("Payment Information").ClickAsync();
    }
}