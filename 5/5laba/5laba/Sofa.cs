﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    partial class Sofa : Furniture
    {
        public int NumPpl { get; set; }
        public Sofa(string name, int price, string color, string size, string material, int numppl) : base(name, price, color, size, material)
        {
            NumPpl = numppl;
        }
        //переопределение виртуального метода в производном классе
        public override void DisplayInfo()
        {
            Console.WriteLine($"Имя {Name}, материал {Material}, цвет {Color}");
        }
    }
}
