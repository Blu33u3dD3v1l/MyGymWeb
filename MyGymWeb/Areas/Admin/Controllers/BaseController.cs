using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MyGymWeb.Areas.Admin.AdminConstants;

namespace MyGymWeb.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRolleName)]
    public class BaseController : Controller
    {
    }
}
