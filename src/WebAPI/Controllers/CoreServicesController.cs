using CSB.Core.Services;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoreServicesController : Controller, ICoreServicesController
{
    private readonly IValidationService _validationService;
    private readonly ITextService _textService;

    public CoreServicesController(IValidationService validationService,
                                    ITextService textService)
    {
        _validationService = validationService;
        _textService = textService;
    }

    [HttpPost]
    [Route("validatetckimlikno")]
    public async Task<ServiceResponse> ValidateTCIdentityNumber(string kimlikNo)
    {
        var response = _validationService.ValidateTRIdentityNumber(kimlikNo);
        return response;
    }

    [HttpPost]
    [Route("replacetrcharacters")]
    public async Task<ServiceResponse<string>> ReplaceTRChars(string text)
    {
        var response = _textService.ReplaceTurkishCharacters(text);
        return ServiceResponse<string>.Success(response);
    }
}
