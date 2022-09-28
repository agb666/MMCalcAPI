namespace MMCalc.Repos
{
    public class Calc : ICalc
    {
        public float Add(float val1, float val2)
        {

            float result = val1 + val2;
            return(result);
        }

        public float Divide(float val1, float val2)
        {
            if (val1 != 0 || val1 != 0)
                return (val1 / val2);

            return (0);
        }

        public float Multiply(float val1, float val2)
        {
            return (val1 * val2);
        }

        public float Subtract(float val1, float val2)
        {
            return (val1 - val2);
        }
    }
}
