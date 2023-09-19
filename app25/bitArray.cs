using System;
using System.Collections;

public class BitArray64 : IEnumerable
{
    private ulong bits;

    public ulong Bits
    {
        get
        {
            return this.bits;
        }
    }

    public BitArray64(ulong input = 0)
    {
        bits = input;
    }

    public bool this[int index]
    {
        get
        {
            if (index < 0 || index >= 64)
            {
                throw new IndexOutOfRangeException();
            }

            return (bits & (1UL << index)) != 0;
        }
        set
        {
            if (index < 0 || index >= 64)
            {
                throw new IndexOutOfRangeException();
            }

            if (value)
                bits |= (1UL << index);
            else
                bits &= ~(1UL << index);
        }
    }

    public override int GetHashCode()
    {
        return bits.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if ((obj == null) || this.GetType() != obj.GetType())
        {
            return false;
        }
        else
        {
            BitArray64 tempObject = (BitArray64)obj;
            return bits == tempObject.Bits;
        }
    }

    public static bool operator ==(BitArray64 objekt1, BitArray64 objekt2)
    {
        return objekt1.Equals(objekt2);
    }

    public static bool operator !=(BitArray64 objekt1, BitArray64 objekt2)
    {
        return !objekt1.Equals(objekt2);
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 64; i++)
        {
            yield return this[i] ? 1 : 0;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        throw new NotImplementedException();
    }
}
