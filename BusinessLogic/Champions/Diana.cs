using System.Collections.Generic;
using BusinessLogic.Abilities.Diana;

namespace BusinessLogic.Champions
{
    public class Diana : ChampionBase
    {
        public Diana():base("Diana",0,0,51,0,0)
        {
            Abilities = new List<IAbility> {new CrescentStrike(), new PaleCascade(),new Moonfall(), new LunarRush()};
        }
    }
}
