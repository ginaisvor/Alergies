using System;
using System.Collections.Generic;
using System.Text;

namespace Allergies
{
    public enum Allergens { Eggs = 1, Peanuts = 2, Shelfish = 4, Strawberries = 8, Tomatoes = 16, Chocolate = 32, Pollen = 64, Cats = 128 };

    public class Allergies
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public void GetAllergens(int score)
        {
            int indice = score;
            if (score >= 256)
            {
                Console.WriteLine(" {0} is alergic to: {1}", this.name, Enum.GetName(typeof(Allergens), 1));
            }
            else
            {
                Console.Write(this.name + " is alergic to: ");
                while (indice >= 1)
                {
                    int min = 0;
                    int wanted = 0;
                    foreach (int num in Enum.GetValues(typeof(Allergens)))
                    {
                        if (num > min && num <= indice)
                        {
                            wanted = num;
                            min = num;
                        }
                    }
                    Console.Write(Enum.GetName(typeof(Allergens), wanted) + " ");
                    indice -= wanted;

                }
                Console.WriteLine();

            }
        }
    }
}
