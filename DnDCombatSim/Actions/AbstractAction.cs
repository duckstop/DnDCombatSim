using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.Actions
{
    public abstract class AbstractAction
    {
        public ActionTypes ActionType;

        public abstract void DoAction(Character.Character doer, Character.Character target);
    }
}
