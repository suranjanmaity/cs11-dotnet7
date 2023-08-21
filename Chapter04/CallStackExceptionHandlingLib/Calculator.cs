namespace CallStackExceptionHandlingLib
{
    public class Calculator
    {
            // public so it can be called from outside
        public static void Gamma() 
        {
            Console.WriteLine("In Gamma");
            Delta();
        }
            // private so it can only be called internally
        private static void Delta()
        {
            Console.WriteLine("In Delta");
            File.OpenText("bad file path");
        }
    }
}