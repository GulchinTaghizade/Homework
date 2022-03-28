using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Car  //a)Car Classi yarat.Brand,Model,Color,MaxSpeed-fieldlari yaratmali.
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;


        public virtual string Info()   //b)Info adli Method yazmali.Return all Information.
        {
            return $"Info about Car: {Brand}  {Model}  {Color}  {MaxSpeed} ";
        }

        public Car()  //c)Bosh Constructor yaratmali "Car Created" - yazdirmali.
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand, string model)  //d)2 parametr  qebul eden Constructor yazmali.Brand,Model- burada Set olmali.
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model, string color, int maxSpeed):this(brand,model) //e)4 paramatrli constructor  yazmali,Brand Model,Color,MaxSpeed - fieldlari set etmeli.2 parametr qebul eden contructoru chagirsin.
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }


 

    }
}
