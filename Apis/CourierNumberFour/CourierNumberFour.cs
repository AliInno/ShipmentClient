﻿using ShipmentCourierInterface;
using System;

namespace CourierNumberFour
{
    public class CourierNumberFourApi
    {
        public void CreateShipmentInfo()
        {
            Console.WriteLine("Hello from CreateShipmentInfo => Courier number four");
        }
        public void CreateShipmentInstructions()
        {
            Console.WriteLine("Hello from CreateShipmentInstructions => Courier number four");
        }
        public void GetShimpmentWayBill()
        {
            Console.WriteLine("Hello from GetShimpmentWayBill => Courier number four");
        }
        public void RegisterNumberToGetWayBill()
        {
            Console.WriteLine("Hello from RegisterNumberToGetWayBill => Courier number four");
        }
        public void GetTrackingDetails()
        {
            Console.WriteLine("Hello from GetTrackingDetails => Courier number four");
            Console.WriteLine("========================================================");
        }
    }

    public class CourierNumberFourApiWrapper : IShipmentCourier
    {
        private readonly CourierNumberFourApi _courierApi;

        public CourierNumberFourApiWrapper() => _courierApi = new CourierNumberFourApi();

        public void CreateShipment()
        {
            _courierApi.CreateShipmentInfo();
            _courierApi.CreateShipmentInstructions();
            _courierApi.GetShimpmentWayBill();
        }

        public void TrackShipment()
        {
            _courierApi.RegisterNumberToGetWayBill();
            _courierApi.GetTrackingDetails();
        }
    }
}
