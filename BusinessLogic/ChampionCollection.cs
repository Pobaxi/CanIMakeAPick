using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.Champions;

namespace BusinessLogic
{
    public class ChampionCollection
    {
        private readonly IList<IChampion> _champions;
        
        public ChampionCollection()
        {
            _champions = new List<IChampion> {new Diana()};
        }

        public IEnumerable<IChampion> Champions 
        {
            get { return _champions; }
        }
    }
}
