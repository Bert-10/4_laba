using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class DrinkablesTests
    {
        //создание объекта типа сок с параметрами Объём: два литра, Фрукт: виноград, Мякоть: нет
        [TestMethod()]
        public void GetInfoTest()
        {
            var Drinkable = new Juice(1, 2, 2);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Сок\n"+"Объём: два литра\n"+"Фрукт: виноград\n"+"Мякоть: нет", s);
        }
        //создание объекта типа сок с параметрами Объём: один литр, Фрукт: виноград, Мякоть: нет
        [TestMethod()]
        public void GetInfoTest1()
        {
            var Drinkable = new Juice(2, 2, 2);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Сок\n" + "Объём: один литр\n" + "Фрукт: виноград\n" + "Мякоть: нет", s);
        }
        //создание объекта типа газировка с параметрами Объём: пол литра, Вид: спрайт , Количество пузырьков: 700
        [TestMethod()]
        public void GetInfoTest2()
        {
            var Drinkable = new Gas(3, 2, 700);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Газировка\n"+"Объём: пол литра\n"+"Вид: спрайт\n"+"Количество пузырьков: 700", s);
        }


        //создание объекта типа газировка с параметрами Объём: один литр, Вид: кола , Количество пузырьков: 1000
        [TestMethod()]
        public void GetInfoTest3()
        {
            var Drinkable = new Gas(2, 1, 1000);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Газировка\n" + "Объём: один литр\n" + "Вид: кола\n" + "Количество пузырьков: 1000", s);
        }
        //создание объекта типа алкоголь с параметрами Объём: один литр, Крепость: 30 %, Тип: водка
        [TestMethod()]
        public void GetInfoTest4()
        {
            var Drinkable = new Alco(2, 2, 30);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Алкоголь\n"+"Объём: один литр\n"+"Крепость: 30%\n"+"Тип: водка", s);
        }
        //создание объекта типа алкоголь с параметрами Объём: два литра, Крепость: 60 %, Тип: пиво
        [TestMethod()]
        public void GetInfoTest5()
        {
            var Drinkable = new Alco(1, 3, 60);
            string s = Drinkable.GetInfo();
            Assert.AreEqual("Алкоголь\n" + "Объём: два литра\n" + "Крепость: 60%\n" + "Тип: пиво", s);
        }

    }
}