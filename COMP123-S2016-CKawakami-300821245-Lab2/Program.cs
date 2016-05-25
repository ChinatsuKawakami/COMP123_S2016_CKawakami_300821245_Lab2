using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*This is driver class
 * Author:Chinatsu Kawakami
 * Date:May 24th, 2016
 * Date Modified: May 25th, 2016
 * Student Id: 300821245
 * Description: This program calls instance variables from person class 
 * and print SayHello Method and ShowAge Method
 * Version : 0.0.6-Updated Person Class
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
            // call the Sayhello and ShowAge method
            person1.SayHello();
            person1.ShowAge();

            person2.SayHello();
            person2.ShowAge();
        }
    }
}
