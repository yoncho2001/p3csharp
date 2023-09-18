using System;

public class InvalidRangeException<T> : Exception
{
    public T Start { get;}
    public T End { get;}

    public InvalidRangeException() : base()
    { }

    public InvalidRangeException(string message): base(message)
    { }

    public InvalidRangeException(string message, Exception inner)
    : base(message, inner)
    { }


    public InvalidRangeException(string message, T start, T end) : base(message)
    {
        this.Start = start;
        this.End = end;
    }

    public override string ToString()
    {
        return $"Invalid element. Valid range: [{Start} … {End}]";
    }
}
