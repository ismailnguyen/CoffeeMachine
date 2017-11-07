﻿namespace CoffeeMachine
{
    public abstract class HotDrink : Drink, IHotDrink
    {
        private string code;
        private int sugarQuantity = 0;
        private double price;
        bool isExtraHot;

        public HotDrink(string code, double price) : base(code, price)
        {
        }

        public HotDrink AddSugar()
        {
            if (sugarQuantity >= 2)
            {
                return this;
            }

            sugarQuantity++;

            return this;
        }

        public int GetSugarQuantity()
        {
            return sugarQuantity;
        }

        public bool IsExtraHot()
        {
            return isExtraHot;
        }

        public void SetExtraHot()
        {
            isExtraHot = true;
        }
    }
}
