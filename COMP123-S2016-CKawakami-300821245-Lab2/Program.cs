using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*This is driver class
 * Author:Chinatsu Kawakami
 * Date:May 24th, 2016
 * Date Modified: May 27th, 2016
 * Student Id: 300821245
 * Description: This program calls instance variables from person class 
 * and print SayHello Method and ShowAge Method
 * Version : 0.0.7-added public Age property , methods and constructor. Added instance objects into driver class
 */
namespace COMP123_S2016_CKawakami_300821245_Lab2
{
    /**
     * This class is the "driver" class for our program,Lab2(Assignment)
     * 
     * @class Program
     */
    class Program
    {
        /**
         * the Main Method for our drive class program
         * 
         * @constructor Main
         * @pram {string[]} args
         */
        static void Main(string[] args)
        {
            //create a new instance of the Person class
            Person person1 = new Person();
            Person person2 = new Person("Mark",27);
            Person person3 = new Person("Jean");
            Person person4 = new Person(50);
            Person person5 = new Person();
            person5.Name = "Jake";
            person5.Age = 30;
            Person person6 = new Person();
            person6.Name = "Maria";
            Person person7 = new Person();
            person7.Age = 60;
            Person person8 = new Person("Ashely");
            person8.Age = 19;
            Person person9 = new Person(29);
            person9.Name = "Bob";

            // call the Sayshello and ShowAge method(get)
            person1.SaysHello();
            person1.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person2.SaysHello();
            person2.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person3.SaysHello();
            person3.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person4.SaysHello();
            person4.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            // call the Sayshello and ShowAge method(set)
            person5.SaysHello();
            person5.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person6.SaysHello();
            person6.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person7.SaysHello();
            person7.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            // call the Sayshello and ShowAge method(set & get)
            person8.SaysHello();
            person8.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");

            person9.SaysHello();
            person9.ShowAge();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
        }
    }
}
