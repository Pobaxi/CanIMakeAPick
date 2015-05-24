using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Abilities
{
    public abstract class AbilityBase : IAbility
    {
        private int _level;
        protected IDictionary<int, int> DamageTable;
        
        protected AbilityBase(string name, DamageType damageType, double ratio)
        {
            Name = name;
            Level = 1;
            DamageType = damageType;

            // checks for doubles on < 0 ?
            if (ratio <= 0)
            {
                throw new ArgumentOutOfRangeException("ratio","ratio has to be positive");
            }
            Ratio = ratio;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets/Sets the Level of the ability.
        /// </summary>
        public int Level
        {
            get { return _level; }
            set
            {
                //value has to be between 1 and 4 including those numbers
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value","Level has to be larger than 1");
                }
                if (value > 4)
                {
                    throw new ArgumentOutOfRangeException("value","Level has to smaller than 4");
                }
                _level = value;
            }
        }

        /// <summary>
        /// Gets the DamageType.
        /// </summary>
        public DamageType DamageType { get; private set; }

        /// <summary>
        /// Gets the Abilities ratio.
        /// </summary>
        public double Ratio { get; private set; }

        /// <summary>
        /// Changes this to a return value that makes sense! probably another class!
        /// </summary>
        protected double CalculateBaseDamage(double scalingStat)
        {
            var baseDamage = DamageTable[Level];
            return baseDamage + (scalingStat*Ratio);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalingStat"></param>
        public abstract void CalculateDamage(double scalingStat);
    }
}
