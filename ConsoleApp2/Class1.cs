using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public int personId;
        public int age;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            string name = this.firstName + " " + this.lastName;
            Console.WriteLine(this.personId + ": " + name + "'s favorite colour is " + this.favoriteColour);
        }

        public string ChangeFavoriteColour()
        {
            return this.favoriteColour = "White";
        }

        public void GetAgeInTenYears(){
            string name = this.firstName + " " + this.lastName;
            Console.WriteLine(name + "'s age in 10 years is " + (this.age+10));
        }

        public void ToString()
        {
            Console.WriteLine("PersonId: " + this.personId + "\n" +
                "FirstName: " + this.firstName + "\n" +
                "LastName: " + this.lastName + "\n" +
                "FavoriteColour: " + this.favoriteColour + "\n" +
                "Age: " + this.age + "\n" +
                "IsWorking: " + this.isWorking);
        }
    }
}
