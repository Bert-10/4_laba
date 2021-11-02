using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace WindowsFormsApp1
{
    public class Drinkables
    {
    }
    //сок
    public enum JuicesType { apple, orange };
    public class Juice : Drinkables
    {
        public JuicesType type = JuicesType.apple; 
        public bool Pulp = false; 
    }
    //газировка
    public enum GasType { cola, sprite };
    public class Gas : Drinkables
    {
        public int Count = 0;
        public GasType type = GasType.cola; // тип
    }
    //алкоголь
    public enum AlcoType { vodka, vine };
    public class Alco : Drinkables
    {
        public AlcoType type = AlcoType.vine;
        public int BonesNumber = 0; 

    }

}