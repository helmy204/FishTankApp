using FishTankApp.Models;
using FishTankApp.Services;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTankApp.Controllers.Api
{
    public class HistoryDataController : Controller
    {
        private readonly ISensorDataService sensorDataService;

        public HistoryDataController(ISensorDataService sensorDataService)
        {
            this.sensorDataService = sensorDataService;
        }

        public IEnumerable<IntHistoryModel> GetWaterTemperatureHistory()
        {
            return sensorDataService.GetWaterTemperatureFahrenheitHistory();
        }

        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return sensorDataService.GetFishMotionPercentageHistory();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return sensorDataService.GetWaterOpacityPercentageHistory();
        }

        public IEnumerable<IntHistoryModel> GetLightIntensityLumens()
        {
            return sensorDataService.GetWaterTemperatureFahrenheitHistory();
        }
    }
}
