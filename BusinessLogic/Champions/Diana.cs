using System.Collections.Generic;
using BusinessLogic.Abilities.Diana;

namespace BusinessLogic.Champions
{
    public class Diana : ChampionBase
    {

        public Diana():base("Diana",0,0,51,0,0)
        {
            Abilities = new Dictionary<AbilityButtons,IAbility>
                            {
                                { AbilityButtons.Q,new CrescentStrike() },
                                { AbilityButtons.W,new PaleCascade() },
                                { AbilityButtons.E, new Moonfall() },
                                { AbilityButtons.R, new LunarRush() }
                            };

        }
    }
}
