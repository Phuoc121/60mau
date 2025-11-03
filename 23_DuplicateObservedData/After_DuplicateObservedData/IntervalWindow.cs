using System;



public class IntervalWindow
{
    public string StartField { get; set; }
    public string EndField { get; set; }
    public string LengthField { get; set; }

    private Interval interval = new Interval();

    public void StartField_FocusLost()
    {
        interval.Start = int.Parse(StartField);
        interval.End = int.Parse(EndField);
        interval.CalculateLength();
        LengthField = interval.Length.ToString();
    }

    public void EndField_FocusLost()
    {
        interval.Start = int.Parse(StartField);
        interval.End = int.Parse(EndField);
        interval.CalculateLength();
        LengthField = interval.Length.ToString();
    }

    public void LengthField_FocusLost()
    {
        interval.Start = int.Parse(StartField);
        interval.Length = int.Parse(LengthField);
        interval.CalculateEnd();
        EndField = interval.End.ToString();
    }
}
