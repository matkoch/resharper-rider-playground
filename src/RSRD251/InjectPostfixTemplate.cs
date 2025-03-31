// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class InjectPostfixTemplate
{
    interface IService
    {
        Task<IActionResult> Process(HttpRequest request);
    }

    class Function
    {
        public async Task<IActionResult> RunAsync(HttpRequest request)
        {
            throw new NotImplementedException();
        }
    }

    class FunctionAttribute(string name) : Attribute;

    class HttpRequest;

    class OkResult : IActionResult;

    interface IActionResult;
}
