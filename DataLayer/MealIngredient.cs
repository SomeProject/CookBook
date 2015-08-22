using System;

namespace DataLayer
{
    public class MealIngredient
    {
        public Guid Id { get; set; }

        public int Count { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual Meal Meal { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}