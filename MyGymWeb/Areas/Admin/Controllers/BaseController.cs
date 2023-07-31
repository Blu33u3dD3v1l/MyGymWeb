﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static MyGymWeb.Web.Extensions.Extensions.AdminConstants;


namespace MyGymWeb.Areas.Admin.Controllers
{

    [Area(AreaName)]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRolleName)]
    public class BaseController : Controller
    {
       
    }
}
