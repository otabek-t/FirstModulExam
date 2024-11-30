namespace FirstModulExam
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        //1 - funksiya
        public static string TheEndOfText(string text)
        {
            text = text.Substring(text.Length - 4, 4);
            return text;
        }

        

        //2 - funksiya

        public static int OddCounter(List<int> numbers)
        {
            var counter = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;

        }
        
        //3 - funksiya
        public static bool WithEndTrueOrFalse(string text)
        {
            var trueOrFalse = text.EndsWith("g_10");
            return trueOrFalse;
        }

        //4 - funcsiya

        public static bool LengthList(List<string> stringText)
        {
            foreach( var text in stringText)
            {
                if (text.Length > 3)
                {
                    return true;
                }
            }
            return false;

        }
    }

}
