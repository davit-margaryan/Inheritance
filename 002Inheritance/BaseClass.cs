﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClass.publicField";

        private string privateField = "BaseClass.privateField";

        protected string protectedField = "BaseClass.protectedField";

        public BaseClass()
        {

        }

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
