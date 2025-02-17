﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string SectionKey { get; set; }
        public string Name { get; set; }       

        public virtual ICollection<UserMeal> Meals { get; set; }
        public virtual ICollection<UserWorkout> UserWorkouts { get; set; }

    }
}
