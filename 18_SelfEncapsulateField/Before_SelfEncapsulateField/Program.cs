class Range
{
    private int low, high;

    public Range(int low, int high)
    {
        this.low = low;
        this.high = high;
    }

    public bool Includes(int value)
    {
        return value >= low && value <= high;
    }
}
