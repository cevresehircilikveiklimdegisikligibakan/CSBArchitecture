using CSB.Core.Application.Contract.Controllers;

namespace Application.Contract.Controllers;

public interface ICoreServicesController : IAPIController
{
    Task<ServiceResponse> ValidateTCIdentityNumber(string kimlikNo);
}