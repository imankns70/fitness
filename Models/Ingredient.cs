﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MealIngredient> Meals { get; set; }
                
    }
}
