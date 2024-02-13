namespace ClassLibraryCalci
{
    public class Calci
    {

    }
}
namespace ClassLibCalci
{
    public class Calci
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Multi()
        {
            int res;
            res = num1 * num2;
            return res;
        }
        public int Sub()
        {
            int res;
            res = num2 - num1;
            return res;
        }
        public int Div()
        {
            if (num2 != 0)
            {
                int res = num1 / num2;
                return res;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
    }
}
