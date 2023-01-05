﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Cat
    {


        private string? nickname;
        private int age;
        private string? gender;
        private int energy;
        private double price;
        private double mealQuantity;


        public Cat(){}



        public Cat(string? nickname, int age, string? gender, int energy, double price, double mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }

        public string? Nickname { get; set; }

        public int Age { get; set; }

        public string? Gender { get; set; }

        public int Energy { get; set; }

        public double Price { get; set; }

        public double MealQuantity { get; set; }



        public void Eat()
        {
            Energy++;
            Price++;
            MealQuantity--;
        }


        public void Sleep()
        {
            Energy++;
        }


        public void Play()
        {
            if (Energy == 0)
            {
                Sleep();
            }
            else
            {
                Energy--;
            }

        }


        public override string ToString()
        {
            return $"Nickname:  {Nickname}  \nAge: {Age}  \nGender: {Gender} \nPrice: {Price} \nMealQuantity: {MealQuantity} \nEnergy: {Energy}\n";
        }


    }
}
