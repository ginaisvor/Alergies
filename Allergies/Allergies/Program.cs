using System;

namespace Allergies
{
    class Program
    {
        static void Main(string[] args)
        {
            Allergies obj = new Allergies();
            obj.Name = "Gina";
            obj.GetAllergens(9);
        }
    }
}
