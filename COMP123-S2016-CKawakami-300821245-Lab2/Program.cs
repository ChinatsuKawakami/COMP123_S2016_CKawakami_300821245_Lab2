using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*This is driver class
 * Author:Chinatsu Kawakami
 * Date:May 24th, 2016
 * Date Modified: May 24th, 2016
 * Student Id: 300821245
 * Description: This program calls instance variables from person class 
 * and print SayHello Method and ShowAge Method
 * Version : 0.0.4-Updated program
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
            Person person1 = new Person("Tom");
            
            // call the Sayhello and ShowAge method
            person1.SayHello();
            person1.ShowAge();
        }
    }
}
