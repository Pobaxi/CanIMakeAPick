using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Abilities.Diana
{
    class Moonfall : AbilityBase
    {
        public Moonfall() : base("Moonfall",DamageType.None, 0.0)
        {
            DamageTable = new Dictionary<int, int>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalingStat"></param>
        public override void CalculateDamage(double scalingStat)
        {
            throw new NotImplementedException();
        }
    }
}
