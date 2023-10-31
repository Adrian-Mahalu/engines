﻿using MHL_Motors.Models.CarModels.CarFactoryModels;

namespace MHL_Motors.DataAccess.Factories.CarFactories.TypeOne
{
    public class HybridCarFactory : DefaultCarFactory
    {
        public override CarObject CreateCar()
        {
            return new HybridCar();
        }
    }
}
