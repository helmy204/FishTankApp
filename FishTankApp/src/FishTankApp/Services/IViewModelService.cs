using FishTankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTankApp.Services
{
  public  interface IViewModelService
    {
        DashboardViewModel GetDashboardViewModel();
    }
}
