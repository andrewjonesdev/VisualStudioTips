
using System;
using System.Collections.Generic;

namespace VisualStudioTips
{
    public class CodeSnippets
    {
        // Put the cursor here and type "ctor" and then press the Tab. This will create a constructor for this class.
        
        public CodeSnippets()
        {
            Console.WriteLine();

            try
            {

            }
            catch (ArithmeticException arithmeticException)
            {
                Console.WriteLine(arithmeticException);
                throw;
            }

            try
            {

            }
            finally
            {
                
            }

            for (int countIndex = 0; countIndex < 50; countIndex++)
            {
                
            }

            for (int countDIndex = 50 - 1; countDIndex >= 0; countDIndex--)
            {
                
            }

            var names = new List<string>();
            foreach (var name in names)
            {
                
            }

            while (true)
            {
                do
                {
                    
                } while (true);
            }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        // Now put the cursor here and type "prop" and then press the Tab. This will create an auto-implemented property.
        // Note that the "type" is highlighted. Type in "string" and press the Tab. Now you can type a name for this property.
        // Then press the Tab or Enter to finish editing. 
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private double _age;

        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }




        // Now type "propfull" to create a property with a private field. Press the tab and specify the values accordingly.

        public void Start()
        {
            // Put the cursor here and type "for" and press the Tab. 


            // Do the same with "foreach".


            // Now type "try" to create a try/catch block.


            // Repeat with "tryf" to create a try/finally block.


            // Now create a for loop with "for".


            // Or a for loop that decrements the loop variable using "forr".

        }
    }

    class Example
    {
        public Example()
        {
            
        }
    }
}
