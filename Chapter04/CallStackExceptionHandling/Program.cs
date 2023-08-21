using CallStackExceptionHandlingLib;
using static System.Console;
WriteLine("In Main");
Alpha();
void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}
void Beta()
{
    WriteLine("In Beta");
    try
    {
        Calculator.Gamma();
    }
    catch(Exception ex)
    {
        /*
         * Throw the caught exception as if it happened here 
         * this will loose the original call stack
         */
        //throw ex;

        /*
         * rethrow the caught exception and retain its original call stack
         */
        //throw;

        /*
         * throw a new exception with the caught exception nested within it 
         */
        // throw new InvalidOperationException(
        // message:"Calculation had invalid values. See inner exception for why.",
        // innerException:ex);
    }
}