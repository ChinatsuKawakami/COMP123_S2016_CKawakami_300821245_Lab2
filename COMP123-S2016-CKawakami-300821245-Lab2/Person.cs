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
         * This is a property for our _name field
         * 
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
     * This is the default empty constructor for The Person Class
     * 
     * @constructor Person
     * 
     */
public Person(string name)
 {
     if (name == "Tom")
     {
         _name = name;
         _age = 47;
     }
}

//This is my SayHello method 
//method SayHello
//this method has a return type which is void(does not return a value)

public void SayHello()
 {
     Console.WriteLine("{0} says hello", this._name);
  }

//This is my SayHello method 
//method ShowAge
//this method has a return type which is void(does not return a value)

public void ShowAge()
{
    Console.WriteLine("{0} is {1} years old", this._name, this._age);
}
    
    }//close Person Class
 }//close namespace

