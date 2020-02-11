using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ChurchSuiteSharp
{
    public class JsonManager
    {
        public static string EmptyArraysToNull(string resultString)
        {
            //The church suit api is backed by php. Instead of using null the api returns an empty array.
            //A single instance object like Address if left unset will return as '[]'. This might work well
            //in a typeless language in a strongly typed language an object attempting to turn into and
            //array causes parsing errors.
            //To fix this we change all empty arrays to null. This may cause an nre in some cases but
            //dealing with nulls is preferable to trying to implement contextual polymorphism into c#
            //For futher details see: https://github.com/ChurchSuite/churchsuite-api/issues/11
            return resultString.Replace("[]", "null");
        }
    }
}
