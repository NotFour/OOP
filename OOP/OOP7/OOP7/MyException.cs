﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    class MyException : InvalidCastException
    {
        public MyException() { }

        public MyException(string message) : base(message) { }
    }
}
