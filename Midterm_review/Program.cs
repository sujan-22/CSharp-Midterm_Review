using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();
            List<Electronic> electronics = new List<Electronic>();
            

            String[] parts;

            try
            {
                using (StreamReader sr = new StreamReader("cs.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        parts = line.Split(',');
                        

                        if (parts.Length == 4 ) {
                            int sku = int.Parse(parts[0].Trim());
                            string name = parts[1].Trim();
                            string desc = parts[2].Trim();
                            int quantity = int.Parse(parts[3].Trim());

                            Fruit fruit = new Fruit(sku, name, desc, quantity);
                            fruits.Add(fruit);
                        } else
                        {
                            int sku = int.Parse(parts[0].Trim());
                            string name = parts[1].Trim();
                            string desc = parts[2].Trim();
                            int quantity = int.Parse(parts[3].Trim());
                            int weight = int.Parse(parts[4].Trim());   
                            Electronic electronic = new Electronic(sku, name, desc, quantity, weight);
                            electronics.Add(electronic);
                        }
                    }
                    
                }

                foreach(var  f in fruits)
                {
                    Console.WriteLine(f.ToString());
                }
                foreach (var item in electronics)
                {
                    Console.WriteLine(item.ToString());
                }


                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not read file");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


           

        }
        
    } 
}
