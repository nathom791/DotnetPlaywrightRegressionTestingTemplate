using Microsoft.Playwright;

namespace DotnetPlaywrightRegressionTestingTemplate
{
    public class LoginPage
    {
        private readonly IPage _Page;
        private readonly ILocator _userNameInput;
        private readonly ILocator _passwordInput;
        private readonly ILocator _loginButton;

        public LoginPage(IPage Page)
        {
            _Page = Page;
            _userNameInput = Page.Locator("[data-test=\"username\"]");
            _passwordInput = Page.Locator("[data-test=\"password\"]");
            _loginButton = Page.GetByText("Login");
        }

        public async Task LoginAsync(string username, string password)
        {
            await _Page.GotoAsync("https://www.saucedemo.com/");
            await _userNameInput.FillAsync(username);
            await _passwordInput.FillAsync(password);
            await _loginButton.ClickAsync();
        }
    }
}