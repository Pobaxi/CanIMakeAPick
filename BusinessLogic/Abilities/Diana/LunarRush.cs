using System;

namespace BusinessLogic.Abilities.Diana
{
    /// <summary>
    /// 
    /// </summary>
    public class LunarRush : AbilityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public LunarRush() : base("Lunar Rush",DamageType.Magic, 0.6)
        {

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
