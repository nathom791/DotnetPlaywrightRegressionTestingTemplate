using Microsoft.Playwright;

namespace DotnetPlaywrightRegressionTestingTemplate
{
    public class BasePage
    {
        private readonly IPage _Page;

        public BasePage(IPage Page)
        {
            _Page = Page;
        }
    }
}