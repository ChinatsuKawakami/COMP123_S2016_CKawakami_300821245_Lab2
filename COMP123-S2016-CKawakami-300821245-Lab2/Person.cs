using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_CKawakami_300821245_Lab2
{
    /**
     *This class defines a generic Person
     *
     * @class Person
     * @param
     * @field _name{string}, _age{int},
     */
    public class Person
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++
      
        private string _name;
        private int _age;
         //PUBLIC INSTANCE VARIABLES++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a property for our _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
    {

        get{
           return this._name;
        }//close get 

         set{
             this._name = value;
             }//close set

    }//close Name property

    /**
     *<summary>
     *This is public property for our _age field
     * </summary>
     * @property {int} Age
     */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }//close public Age property

   //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /**
     * <summary>
     * This is the default empty constructor for The Person Class
     * </summary>
     * @constructor Person
     * 
     */
public Person()
 {
     
         //this._name = "Tom";
        // this._age = 47;
     this.initialize();
}

/**
 * <summary>
 * This is constructor that takes name as a parameter and passes 
 * It to the _name private instance variable
 * </summary>
 * @constructor Person
 * @param {string} name
 */
public Person(string name)
{
    this.Name = name;
    this.Age = 0;
   // this.initialize();

}

/**
 * <summary>
 * This is the constructor that takes age as a parameter and passes 
 * It to the _age private instance variable
 * </summary>
 * @constructor Person
 * @param {int} age
 */

public Person(int age)
{
    this.Name = "UNKNOWN NAME!!";
    this.Age = age;
 //   this.initialize();
   
}


/**
 * <summary>
 * This is a constructor that takes both name and age as parameter
 * it assigns the locak name value to the name property
 * it assigns the local age value to the age property
 * </summary>
 * 
 */

public Person(string name,int age)
{
    this._name = name;
    this._age = age;
   // this.initialize();
}

/**
 * <summary>
 * This is a constructor with parameter less 
 *
 * </summary>
 * 
 * @private 
 * @method _initialize
 * @return {void}
 */

private void initialize()
{
    this.Name = "UNKNOWN NAME!";
    this.Age = 0;

}

/**
 *<summary>
 *This method outputs the_name value with "says hello!" to console
 *</summary>
 *@method SayHello
 *return {void}
*/
public void SaysHello()
 {
     Console.WriteLine("{0} says hello!", this.Name);
  }
/**
 * <summary>
 *This method outputs the _name value and _age value in the following
 *format: "{0} is {1} years old", this.Name, this.Age
 * </summary>
 * @method ShowAge
 * @return {void}
*/
public void ShowAge()
{
    Console.WriteLine("{0} is {1} years old", this.Name, this.Age);
}
    
    }//close Person Class
 }//close namespace

