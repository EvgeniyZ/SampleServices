namespace UniversityService.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public sealed class InternalController : Controller
    {
        
    }
}
