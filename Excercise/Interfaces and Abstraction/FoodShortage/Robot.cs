﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Robot : IIdentifiable
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; }

        public string Model { get; }


    }
}