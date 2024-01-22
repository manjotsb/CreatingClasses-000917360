using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Relation
    {
        public string relationshipType;

        public void ShowRelationShip(string name1, string name2)
        {
            Console.WriteLine("Relationship between " + name1 + " and " + name2 + " is " + this.relationshipType);
        }
    }
}
