using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    interface IChampion
    {
        /// <summary>
        /// Gets the champions name.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets a list of the champions abilities.
        /// </summary>
        IList<IAbility> Abilities { get; }
        /// <summary>
        /// Gets/Sets the champions ability power stat.
        /// </summary>
        double AbilityPower { get; set; }
        /// <summary>
        /// Gets/Sets the champions base attack damage.
        /// </summary>
        double BaseAttackDamage { get;}
        /// <summary>
        /// Gets/Sets the champions bonus attack damage.
        /// </summary>
        double BonusAttackDamage { get; set; }
        /// <summary>
        /// Gets the total attack damage.
        /// </summary>
        double TotalAttackDamage { get; }
        /// <summary>
        /// Gets/Sets the champions magic penetration stat.
        /// </summary>
        double MagicPenetration { get; set; }
        /// <summary>
        /// Gets/Sets the champions armour penetration stat.
        /// </summary>
        double ArmourPenetration { get; set; }
        /// <summary>
        /// Gets/Sets the champions level.
        /// </summary>
        int Level { get; set; }
        /// <summary>
        /// Gets the champions passive ability.
        /// </summary>
        IPassive Passive { get; }
    }
}
