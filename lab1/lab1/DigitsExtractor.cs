namespace lab1
{
    public class DigitsExtractor
    {
        public int[] ExctractTreeDigits(int number)
        {
            int[] result = new int[3];
            for(int i =0; i < result.Length; i++)
            {
                result[i] = number % 10;
                number /= 10;
            }

            return result;
        }
    }
}
