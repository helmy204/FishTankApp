using FishTankApp.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTankApp.Services
{
    public class ViewModelService: IViewModelService
    {
        private ISensorDataService sensorDataService;
        private IUrlHelper urlHelper;

        public ViewModelService(ISensorDataService sensorDataService,
            IUrlHelper urlHelper)
        {
            this.sensorDataService = sensorDataService;
            this.urlHelper = urlHelper;
        }

        public DashboardViewModel GetDashboardViewModel()
        {
            return new DashboardViewModel
            {
                WaterTemperatureTile=new SensorTileViewModel
                {
                    Title="Water temperature",
                    Value=sensorDataService.GetWaterTemperatureFahrenheit().Value,
                    ColorCssClass="panel-primary",
                    IconCssClass="fa-sliders",
                    Url=urlHelper.Action("GetWaterTemperatureChart","History")
                },
                FishMotionTile = new SensorTileViewModel
                {
                    Title = "Fish motion",
                    Value = sensorDataService.GetFishMotionPercentage().Value,
                    ColorCssClass = "panel-green",
                    IconCssClass = "fa-car",
                    Url = urlHelper.Action("GetFishMotionPercentageChart", "History")
                },
                WaterOpacityTile = new SensorTileViewModel
                {
                    Title = "Water opacity",
                    Value = sensorDataService.GetWaterOpacityPercentage().Value,
                    ColorCssClass = "panel-yellow",
                    IconCssClass = "fa-adjust",
                    Url = urlHelper.Action("GetWaterOpacityPercentageChart", "History")
                },
                LightIntensityTile = new SensorTileViewModel
                {
                    Title = "Light intensity",
                    Value = sensorDataService.GetLightIntensityLumens().Value,
                    ColorCssClass = "panel-red",
                    IconCssClass = "fa-lightbulb-o",
                    Url = urlHelper.Action("GetLightIntensityLumensChart", "History")
                }
            };
        }
    }
}
