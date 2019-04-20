namespace test1.Core.test
{
    public class Test : ITest
    {
        public string CharClear(string str)
        {
            var length = str.Length - 1;
            var resultString = str?.Remove(length, 1);
            return resultString;

        }
    }
}
