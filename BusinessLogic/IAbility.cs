using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public interface IAbility
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets/Sets the Level of the ability.
        /// </summary>
        int Level { get; set; }
        /// <summary>
        /// Gets the DamageType.
        /// </summary>
        DamageType DamageType { get; }
        /// <summary>
        /// Gets the Abilities ratio.
        /// </summary>
        double Ratio { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalingStat"></param>
        void CalculateDamage(double scalingStat);
    }
}
