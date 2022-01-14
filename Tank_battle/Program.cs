using System;
class Tank
{
    private string TankName;//имя танка
    private int Ammunition_Level;//уровень боекомплекта
    private int Armor_Level;//уровень брони
    private int Maneuverability_Level;//уровень маневренности
    public Tank(string TankName)//конструктор с параметрами
    { int min = 0;
        int max = 100;
        this.TankName = TankName;
        Random random = new Random();
        Ammunition_Level = random.Next(min, max);//рандомное значение от 0 до 100
        Armor_Level = random.Next(min, max);//рандомное значение от 0 до 100
        Maneuverability_Level = random.Next(min, max);//рандомное значение от 0 до 100
    }
    public static Tank operator *(Tank T34, Tank Pantera)//перегрузка оператора *
    {
        if (T34.Ammunition_Level > Pantera.Ammunition_Level && T34.Armor_Level > Pantera.Armor_Level
            || T34.Ammunition_Level > Pantera.Ammunition_Level && T34.Maneuverability_Level > Pantera.Maneuverability_Level
            || T34.Armor_Level > Pantera.Armor_Level && T34.Maneuverability_Level > Pantera.Maneuverability_Level)
        {
            Console.WriteLine("Победил Т34");
            return T34;
        }
        else
        {
            Console.WriteLine("Победила Pantera");
            return Pantera;
        }
    }
    public void Print()
    {
        Console.WriteLine($"Танк "+TankName+"\nБоекомплект-" + Convert.ToInt32(Ammunition_Level)+"%" + " Уровень брони-" 
            + Convert.ToInt32(Armor_Level) + "%"
            + " Уровень маневренности-" + Convert.ToInt32(Maneuverability_Level) + "%");
    }
}
namespace Tank_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] tankT34 = { new Tank("T34_1"), new Tank("T34_2"), new Tank("T34_3"), new Tank("T34_4"), new Tank("T34_5") };
            Tank[] tankPantera= { new Tank("Pantera_1"), new Tank("Pantera_2"), new Tank("Pantera_3"),
                new Tank("Pantera_4"), new Tank("Pantera_5") };
            for(int i=0;i<5;i++)
            {
                tankT34[i].Print();
                tankPantera[i].Print();
                _ = tankT34[i] * tankPantera[i];
                Console.WriteLine(" ");
            }
        }
    }
}
