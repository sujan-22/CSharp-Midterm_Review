using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> myFruits  = new List<Fruit>();
            List<Electronic> myElectronic  = new List<Electronic>();

            Fruit first = new Fruit(20, "Apple", "Red Apple", 10);
            myFruits.Add(first);

            Fruit second = new Fruit(50, "Lemon", "Yellow Lemon", 6);
            myFruits.Add(second);

            Fruit third = new Fruit(51, "Grape", "Green Grape", 8);
            myFruits.Add(third);

            Fruit fourth = new Fruit(96, "Pear", "Brown Pear", 80);
            myFruits.Add(fourth);

            //

            Electronic first1 = new Electronic(30, "IPhone", "IPhone X",30, 10);
            myElectronic.Add(first1);

            Electronic second2 = new Electronic(40, "TV", "85 TV",5,200);
            myElectronic.Add(second2);

            Electronic third3 = new Electronic(80, "Laptop", "Thinkpad",9,50);
            myElectronic.Add(third3);

            Electronic fourth4 = new Electronic(82, "Keyboard", "Keys",2,5);
            myElectronic.Add(fourth4);

            int totalDays = 0;
            foreach(var item in myFruits)
            {
               
                Console.WriteLine(item.ToString());
                totalDays += item.GetTotalDeliveryDays();
            }
            foreach (var item in myElectronic)
            {
                Console.WriteLine(item.ToString());
                totalDays += item.GetTotalDeliveryDays();
            }
            Console.WriteLine($"total days: {totalDays}");
            Console.ReadLine();
        }
    }
}
