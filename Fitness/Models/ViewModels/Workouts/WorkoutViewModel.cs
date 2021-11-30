﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models.ViewModels.Workouts
{
    public class WorkoutViewModel
    {
        public int WorkoutId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public StrengthViewModel Strength { get; set; }
        public EnduranceViewModel Endurance { get; set; }
       
    }
}
