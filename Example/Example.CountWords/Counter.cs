namespace Example.CountWords
{
    public class Counter
    {
        public int CountWords(string input) => input.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
