using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Drinkables
    {
        public static Random rnd = new Random();
        public VolumeType Volume = VolumeType.один;
        public virtual String GetInfo()
        {
            string str="",s="";
            switch (Volume)
            {
                case VolumeType.пол:
                    s = " литра";
                    break;
                case VolumeType.один:
                    s = " литр";
                    break;
                case VolumeType.два:
                    s = " литра";
                    break;
            }
            str += "\nОбъём: " + this.Volume + s;
            return str;
        }
        public virtual String GetTYPE()
        {
            string str=""; 

            return str;
        }

    }
    //сок
    public enum JuicesType { яблоко, виноград, апельсин };
    public enum PulpType { есть, нет };
    public enum VolumeType { пол, один, два };
    public class Juice : Drinkables
    {
       // public VolumeType Volume = VolumeType.один;
        public JuicesType type = JuicesType.яблоко; 
        public PulpType Pulp= PulpType.есть;
        public override String GetInfo()
        {
            var str = "Сок";
            str += base.GetInfo();
            str += String.Format("\nФрукт: {0}",this.type);
            str += String.Format("\nМякоть: {0}", this.Pulp);
            return str;
        }
        public static Juice Generate()
        {
            return new Juice
            {
                Volume = (VolumeType)rnd.Next(3),
                Pulp = (PulpType)rnd.Next(2),
                type = (JuicesType)rnd.Next(3),
            };
        }
        public override String GetTYPE()
        {
            var str = "";
            switch (this.type)
            {
                case JuicesType.яблоко:
                    str = "яблоко";
                    break;
                case JuicesType.виноград:
                    str = "виноград";
                    break;
                case JuicesType.апельсин:
                    str = "апельсин";
                    break;
            }
            return str;
        }



    }
    //газировка
    public enum GasType { кола, спрайт,фанта };
    public class Gas : Drinkables
    {
      //  public VolumeType Volume = VolumeType.два;
        public int Count = 0;
        public GasType type = GasType.кола; // тип
        public override String GetInfo()
        {
            var str = "Газировка";
            str += base.GetInfo();
            str += String.Format("\nВид: {0}", this.type);
            str += String.Format("\nКоличество пузырьков: {0}", this.Count);
            return str;
        }
        public static Gas Generate()
        {
            return new Gas
            {
                Volume = (VolumeType)rnd.Next(3), 
                Count = rnd.Next(500, 1500),
                type = (GasType)rnd.Next(3),
            };
        }
        public override String GetTYPE()
        {
            var str = "";
            switch (this.type)
            {
                case GasType.кола:
                    str = "кола";
                    break;
                case GasType.спрайт:
                    str = "спрайт";
                    break;
                case GasType.фанта:
                    str = "фанта";
                    break;
            }
            return str;
        }
    }
    //алкоголь
    public enum AlcoType { водка, вино, пиво };
    public class Alco : Drinkables
    {
     //   public VolumeType Volume = VolumeType.пол;
        public AlcoType type = AlcoType.вино;
        public int Number = 0;
        public override String GetInfo()
        {
            string str = "Алкоголь";
            str += base.GetInfo();
            str += "\nКрепость: "+this.Number+"%";
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }
        public static Alco Generate()
        {
            return new Alco
            {
                Volume = (VolumeType)rnd.Next(3),
                Number = rnd.Next(101),
                type = (AlcoType)rnd.Next(3),
            };
        }
        public override String GetTYPE()
        {
            var str = "";
            switch (this.type)
            {
                case AlcoType.водка:
                    str = "водка";
                    break;
                case AlcoType.вино:
                    str = "вино";
                    break;
                case AlcoType.пиво:
                    str = "пиво";
                    break;
            }
            return str;
        }
    }

}