using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 4 objects with Person class
            Person person1 = new Person();
            person1.personId = 1;
            person1.firstName = "Ian";
            person1.lastName = "Brooks";
            person1.favoriteColour = "Red";
            person1.age = 30;
            person1.isWorking = true;

            Person person2 = new Person();
            person2.personId = 2;
            person2.firstName = "Gina";
            person2.lastName = "James";
            person2.favoriteColour = "Green";
            person2.age = 18;
            person2.isWorking = false;

            Person person3 = new Person();
            person3.personId = 3;
            person3.firstName = "Mike";
            person3.lastName = "Briscoe";
            person3.favoriteColour = "Blue";
            person3.age = 45;
            person3.isWorking = true;

            Person person4 = new Person();
            person4.personId = 4;
            person4.firstName = "Mary";
            person4.lastName = "Beals";
            person4.favoriteColour = "Yellow";
            person4.age = 28;
            person4.isWorking = true;


            //Display Gina's info with DiplayPersonInfo
            person2.DisplayPersonInfo();


            //Display Mike's info as a list
            person3.ToString();


            //Change Ian fav color to white then print info
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();


            //Diplay Mary age after 10 years
            person4.GetAgeInTenYears();


            //Create 2 relation object
            Relation relation1 = new Relation();
            Relation relation2 = new Relation();


            /*Relation1= Gina and Mary as Sisters
              Relation2= Ian and Mike as Brothers
              and Display both Relationship*/
            relation1.relationshipType = "Sisterhood";
            relation2.relationshipType = "Brotherhood";
            relation1.ShowRelationShip(person2.firstName, person4.firstName);
            relation2.ShowRelationShip(person1.firstName, person3.firstName);


            //Adding all persons to list
            List<Person> personLst = new List<Person>();
            personLst.Add(person1);
            personLst.Add(person2);
            personLst.Add(person3);
            personLst.Add(person4);


            //Display thr Average of age of Person in the list
            float sumAge=0;
            for (int i = 0; i < personLst.Count(); i++)
            {
                sumAge += personLst[i].age;
            }
            float avgAge = sumAge / personLst.Count();
            Console.WriteLine("Average age is: " + avgAge);


            //Display Youngest Person
            int smallestAge = 9999;
            for (int i = 0; i < personLst.Count(); i++)
            {
                if (personLst[i].age <= smallestAge)
                {
                    smallestAge = personLst[i].age;
                }
            }
            for(int i=0; i<personLst.Count(); i++)
            {
                if (personLst[i].age.Equals(smallestAge))
                {
                    Console.WriteLine("The youngest Person is " + personLst[i].firstName);
                }
            }

            //Display Oldest Person
            int biggestAge = 0;
            for(int i=0; i < personLst.Count(); i++)
            {
                if (personLst[i].age > biggestAge)
                {
                    biggestAge = personLst[i].age;
                }
            }
            for (int i = 0; i < personLst.Count(); i++)
            {
                if (personLst[i].age.Equals(biggestAge))
                {
                    Console.WriteLine("The Oldest Person is " + personLst[i].firstName);
                }
            }


            //Name of people whose names start with "M"
            for (int i=0; i< personLst.Count(); i++)
            {
                if (personLst[i].firstName.StartsWith("M"))
                {
                    personLst[i].ToString();
                }
            }

            //Person whose fav colour is Blue
            for(int i=0; i < personLst.Count(); i++)
            {
                if (personLst[i].favoriteColour.Equals("Blue"))
                {
                    personLst[i].ToString();
                }
            }
        }
    }
}