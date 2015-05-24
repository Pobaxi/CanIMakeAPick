using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    interface ITarget
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 
        /// </summary>
        int Armour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int MagicResistance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int HealthPoints { get; set; }
    }
}
