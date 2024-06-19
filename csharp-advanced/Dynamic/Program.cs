namespace Dynamic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            object obj = "Mosh";
            // obj.GetHashCode()

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            dynamic excelObject = "Mosh";
            excelObject.Optimize();
            */

            /*
            dynamic name = "Mosh";
            // name = 10;
            name++;
            */

            /*
            dynamic a = 5;
            dynamic b = 10;
            var c = a + b;
            */

            int i = 5;
            dynamic d = i;
            long l = d;

        }
    }
}