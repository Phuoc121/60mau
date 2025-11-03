using System;

public class IntervalWindow
{
    public string StartField { get; set; }
    public string EndField { get; set; }
    public string LengthField { get; set; }

    public void StartField_FocusLost()
    {
        calculateLength();
    }

    public void EndField_FocusLost()
    {
        calculateLength();
    }

    public void LengthField_FocusLost()
    {
        calculateEnd();
    }

    public void calculateLength()
    {
        int start = int.Parse(StartField);
        int end = int.Parse(EndField);
        LengthField = (end - start).ToString();
    }

    public void calculateEnd()
    {
        int start = int.Parse(StartField);
        int length = int.Parse(LengthField);
        EndField = (start + length).ToString();
    }
}
