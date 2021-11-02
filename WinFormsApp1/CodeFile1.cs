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
        public virtual String GetInfo()
        {
            return "Я фрукт";
        }

    }
    //сок
    public enum JuicesType { яблоко, виноград };
    public enum PulpType { есть, нет };
    public class Juice : Drinkables
    {
        public JuicesType type = JuicesType.яблоко; 
        public PulpType Pulp= PulpType.есть;
        public override String GetInfo()
        {
            var str = "Сок";
            str += String.Format("\nФрукт: {0}",this.type);
            str += String.Format("\nМякоть: {0}", this.Pulp);
            return str;
        }
    }
    //газировка
    public enum GasType { кола, спрайт };
    public class Gas : Drinkables
    {
        public int Count = 0;
        public GasType type = GasType.кола; // тип
        public override String GetInfo()
        {
            var str = "Газировка";
            str += String.Format("\nВид: {0}", this.type);
            str += String.Format("\nКоличество пузырьков: {0}", this.Count);
            return str;
        }
    }
    //алкоголь
    public enum AlcoType { водка, вино };
    public class Alco : Drinkables
    {
        public AlcoType type = AlcoType.вино;
        public int Number = 0;
        public override String GetInfo()
        {
            var str = "Алкоголь";
            str += String.Format("\nКрепость: {0}", this.Number);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }
    }

}