namespace WhatIsNewInCSharp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collection Expressions
            //Old Version
            char[] vowelsOld = { 'a', 'b', 'c' };
            //New Version
            char[] vowelsNew = ['a', 'b', 'c'];
            #endregion

            #region Primary Constructor
            var pOld = new PersonOld("firstname", "lastname");
            var pNew = new PersonNew("firstname", "lastname");
            #endregion
        }
    }

    public class PersonOld
    {
        public PersonOld(string firstName, string lastName)
        {

        }
    }

    public class PersonNew(string FirstName,string LastName0)
    {

    }

}
