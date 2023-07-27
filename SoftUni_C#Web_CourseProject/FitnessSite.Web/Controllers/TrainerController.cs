﻿namespace FitnessSite.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Trainer;
    using Services.Intarfaces;
    using Infastructure.Extensions;
    using static Common.NotificationMessagesConstants;

    [Authorize]
    public class TrainerController : Controller
    {
        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            this.trainerService = trainerService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            try
            {
                List<AllTrainerViewModel> allTrainers = await
                    trainerService.GetAllTrainersAsync();

                return View(allTrainers);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            bool isTrainerExist =
                await trainerService.IsTrainerExesitAsync(id);
            if (!isTrainerExist)
            {
                TempData[WarningMessage] = "This trainer does not exist! Pleace select existing one";
                return RedirectToAction("All");
            }

            try
            {
                DetailsTrainerViewModel trainer = await trainerService.GetTrainerDetailsAsync(id);
                return View(trainer);

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage(string id)
        {
            bool isTrainerExist =
                await trainerService.IsTrainerExesitAsync(id);
            if (!isTrainerExist)
            {
                TempData[WarningMessage] = 
                    "This trainer does not exist! Pleace select existing one";
                return RedirectToAction("All");
            }

            bool isUserHaveTrainer =
                await trainerService.IsUserHaveTrainerAsync(User.GetById());
            if (isUserHaveTrainer)
            {
                TempData[WarningMessage] = 
                    "You allready have trainer. You can have only one";
                return RedirectToAction("All");
            }

            return View(id);
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return this.RedirectToAction("Index", "Home");
        }
    }

}
