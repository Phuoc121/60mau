class Currency
{
    public string Code { get; }

    public Currency(string code)
    {
        Code = code;
    }

    // So sánh theo giá trị
    public override bool Equals(object obj)
    {
        if (obj is Currency other)
        {
            return Code == other.Code;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Code.GetHashCode();
    }
}


