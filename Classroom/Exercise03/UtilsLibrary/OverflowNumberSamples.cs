namespace UtilsLibrary
{
    public class OverflowNumberSamples
    {
        public static uint IncrementValue(uint value)
        {
            checked
            {
                return ++value;
            }
        }

        public static uint DecrementValue(uint value)
        {
            checked
            {
                return --value;
            }
        }
    }
}