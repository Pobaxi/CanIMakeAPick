using System;

namespace BusinessLogic.Abilities.Diana
{
    class PaleCascade : AbilityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public PaleCascade() : base("Pale Cascade", DamageType.Magic, 0.2)
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
