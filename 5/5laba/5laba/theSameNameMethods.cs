﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    class theSameNameMethods: Tovar,InterfaceMethods
    {
        void InterfaceMethods.boxName()
        {
            Console.WriteLine("----interface----");
        }
        public override void boxName()
        {
            Console.WriteLine("----method from class-----");
        }
    }
}
