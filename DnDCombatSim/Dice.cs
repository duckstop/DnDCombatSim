using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim
{
    public interface Dice
    {
         int Roll();
    }

    public class D20 : Dice
    {
        public int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 20);
        }
    }

    public class D12 : Dice
    {
        public int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 12);
        }

    }

    public class D10 : Dice
    {
        public int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 10);
        }
    }

    public class D8 : Dice
    {
        public  int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 8);
        }
    }

    public class D6 : Dice
    {
        public  int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 6);
        }
    }

    public class D4 : Dice
    {
        public  int Roll()
        {
            Random ran = new Random();
            return ran.Next(1, 4);
        }
    }

}