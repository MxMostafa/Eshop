using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers.BaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class IBaseController : ControllerBase
    {
    }
}
