using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public interface IPassive
    {
        string Name { get; }
        DamageType DamageType { get; }
        int Ratio { get; }
        //Special property?
    }
}
