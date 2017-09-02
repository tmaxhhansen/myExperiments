using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionAndGenerics
{
    public class Examples
    {
        public void DeclareArray()
        {
            // Array is a fixed-size list. 
            // single dementional array 
            string[] colorOptions = new string[4];


            // Collection initializer
            string[] options1 = new string[4] { "1", "2", "3", "4" };
            // this is equivalent to this...
            string[] options2 = { "1", "2", "3", "4" };

            // Tip - use collection initializer. Avoid to populate an array manually

            // Tip - Take care when referencing elements by index 
            // Tip - Avoid to retrieve elements by index when you need all elements -> iterate through instead

        }
    }
}
