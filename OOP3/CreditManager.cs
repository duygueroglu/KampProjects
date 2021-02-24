using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        //calculate method is called in all classes, but its content is different. so we are using interface. 
        void Calculate();
    }
}
