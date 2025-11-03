public class Interval
{
    public int Start { get; set; }
    public int End { get; set; }
    public int Length { get; set; }

    public void CalculateLength()
    {
        Length = End - Start;
    }

    public void CalculateEnd()
    {
        End = Start + Length;
    }
}