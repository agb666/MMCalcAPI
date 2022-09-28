namespace MMCalc.Repos
{
    public interface ICalc
    {
        float Add(float val1, float val2);
        float Subtract(float val1, float val2);
        float Multiply(float val1, float val2);
        float Divide(float val1, float val2);
    }

}
