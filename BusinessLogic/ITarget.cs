namespace BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITarget
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
