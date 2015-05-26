using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ChampionBase : IChampion
    {
        protected ChampionBase(string name, int abilityPower, int bonusAttackDamage, int baseAttackDamage, int magicPenetration, int armourPenetration)
        {
            Name = name;
            Level = 1;
            
            AbilityPower = abilityPower;
            BaseAttackDamage = baseAttackDamage;
            BonusAttackDamage = bonusAttackDamage;
            MagicPenetration = magicPenetration;
            ArmourPenetration = armourPenetration;
        }
        #region Implementation of IChampion

        /// <summary>
        /// Gets the champions name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets a list of the champions abilities.
        /// </summary>
        public IDictionary<AbilityButtons,IAbility> Abilities { get; internal set; }

        /// <summary>
        /// Gets/Sets the champions ability power stat.
        /// </summary>
        public double AbilityPower { get; set; }

        /// <summary>
        /// Gets/Sets the champions base attack damage.
        /// </summary>
        public double BaseAttackDamage { get; private set; }

        /// <summary>
        /// Gets/Sets the champions bonus attack damage.
        /// </summary>
        public double BonusAttackDamage { get; set; }

        /// <summary>
        /// Gets the total attack damage.
        /// </summary>
        public double TotalAttackDamage
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets/Sets the champions magic penetration stat.
        /// </summary>
        public double MagicPenetration { get; set; }

        /// <summary>
        /// Gets/Sets the champions armour penetration stat.
        /// </summary>
        public double ArmourPenetration { get; set; }

        /// <summary>
        /// Gets/Sets the champions level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets the champions passive ability.
        /// </summary>
        public IPassive Passive
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
