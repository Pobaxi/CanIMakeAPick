using System.Collections.Generic;

namespace BusinessLogic.Abilities.Diana
{
    public class CrescentStrike : AbilityBase
    {
        public CrescentStrike() : base("Crescent Strike", DamageType.Magic,0.7)
        {
            DamageTable = new Dictionary<int, int> {{1, 60}, {2, 95}, {3, 130}, {4, 165}, {5, 200}};
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalingStat"></param>
        public override void CalculateDamage(double scalingStat)
        {
            var baseValue = CalculateBaseDamage(scalingStat);
            // add additional damages as you see fit!
        }
    }
}
