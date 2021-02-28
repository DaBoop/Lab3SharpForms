using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    interface IPrototype<T>
    {
        T Clone();

        T DeepCopy();


    }
}
