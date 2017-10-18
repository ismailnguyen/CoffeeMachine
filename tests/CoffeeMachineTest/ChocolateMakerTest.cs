﻿using CoffeeMachine;
using NFluent;
using NUnit.Framework;

namespace CoffeeMachineTest
{
    public class ChocolateMakerTest
    {
        [TestCase(0.5)]
        [TestCase(0.6)]
        [TestCase(2)]
        public void Should_Make_Chocolate_Without_Sugar_Without_Stick_With_Enough_Money(double insertedMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.Make()).IsEqualTo("H::");
        }

        [TestCase(0, "M:0,50")]
        [TestCase(0.1, "M:0,40")]
        [TestCase(0.4, "M:0,10")]
        public void Should_Make_Chocolate_Without_Sugar_Without_Stick_With_Insufficient_Money(double insertedMoneyAmount, string missingMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.Make()).IsEqualTo(missingMoneyAmount);
        }

        [TestCase(0.5)]
        [TestCase(0.6)]
        [TestCase(2)]
        public void Should_Make_Chocolate_With_Sugar_With_Stick_With_Enough_Money(double insertedMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.MakeWithSugar()).IsEqualTo("H:1:1");
        }

        [TestCase(0, "M:0,50")]
        [TestCase(0.1, "M:0,40")]
        [TestCase(0.4, "M:0,10")]
        public void Should_Make_Chocolate_With_Sugar_With_Stick_With_Insufficient_Money(double insertedMoneyAmount, string missingMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.Make()).IsEqualTo(missingMoneyAmount);
        }

        [TestCase(0.5)]
        [TestCase(0.6)]
        [TestCase(2)]
        public void Should_Make_Chocolate_With_Two_Sugar_With_Stick_With_Enough_Money(double insertedMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.MakeWithSugar(2)).IsEqualTo("H:2:1");
        }

        [TestCase(0, "M:0,50")]
        [TestCase(0.1, "M:0,40")]
        [TestCase(0.4, "M:0,10")]
        public void Should_Make_Chocolate_With_Two_Sugar_With_Stick_With_Insufficient_Money(double insertedMoneyAmount, string missingMoneyAmount)
        {
            var drinkMaker = new ChocolateMaker();

            drinkMaker.InsertMoney(insertedMoneyAmount);

            Check.That(drinkMaker.Make()).IsEqualTo(missingMoneyAmount);
        }
    }
}
