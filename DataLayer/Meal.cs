using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class Meal
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string HowToCook { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<MealIngredient> Ingredients { get; set; }
    }
}