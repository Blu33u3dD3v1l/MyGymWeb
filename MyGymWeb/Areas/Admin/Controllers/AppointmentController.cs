using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;


namespace MyGymWeb.Areas.Admin.Controllers
{
    public class AppointmentController : BaseController
    {


        private readonly IAppointmentService appointmentService;
        

        public AppointmentController(IAppointmentService _appointmentService)
        {
            appointmentService = _appointmentService;
           
        }
        public async Task<IActionResult> All()
        {
            var model = await appointmentService.GetAllAsync();
            return View(model); 
        }

        public async Task<IActionResult> Approve(int id)
        {

            try
            {
               await appointmentService.ApproveAppointmentAsync(id);
               await appointmentService.DeleteAppointmentsAsync(id);

                TempData[SuccessMessage] = "You Successfuly Approved an appointment!";
            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "Not Enough Money!";
            }

            return RedirectToAction("All", "Appointment", "Admin");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await appointmentService.DeleteAppointmentsAsync(id);

            TempData[SuccessMessage] = "You Successfuly rejected an appointment!";

            return RedirectToAction("All", "Appointment", "Admin");
        }

    }
}
