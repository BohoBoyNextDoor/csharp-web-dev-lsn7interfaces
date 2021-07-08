using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IceCreamShop
{
    class Program
    {

        public class FlavorComparer : IComparer<Flavor>
        {
            public int Compare(Flavor x, Flavor y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
        public class ConeComparer : IComparer<Cone>
        {
            public int Compare(Cone x, Cone y)
            {
                if (x.Cost > y.Cost)
                {
                    return 1;
                }
                else if (x.Cost < y.Cost)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
        }
            public class AllergenComparer : IComparer<Flavor>
            {
                public int Compare(Flavor x, Flavor y)
                {
                    if (x.Allergens.Count > y.Allergens.Count)
                    {
                        return 1;
                    }
                    else if (x.Allergens.Count < y.Allergens.Count)
                    {
                        return -1;
                    }
                    else
                        return 0;
                }
            }

        


        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            availableFlavors.Sort(new FlavorComparer());
            foreach (Flavor taste in availableFlavors)
                {
                Console.WriteLine(taste);
                }
            availableCones.Sort(new ConeComparer());
            foreach (Cone price in availableCones)
            {
                Console.WriteLine(price);
            }
            
            //it works, i don't have time to make it pretty, i gotta run to work <3
            availableFlavors.Sort(new AllergenComparer());
            foreach (Flavor taste in availableFlavors)
            {
                Console.WriteLine(taste);
            }
            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}

