using System;
using validate;


public class GenericList<T> where T : IComparable
{
    private T[] list;
    private int size;

    private void Resize()
    {
        T[] temp = new T[size * 2];

        for (int i = 0; i < list.Length; i++)
        {
            temp[i] = list[i];
        }

        list = temp;
    }

    public GenericList()
    {
        list = new T[4];
        size = 0;
    }

    public GenericList(int size)
    {
        list = new T[size];
        size = 0;
    }

    public void AddElement(T element)
    {
        if (size == list.Length)
        {
            Resize();
        }

        list[size++] = element;
    }

    public T this[int index]
    {

        get => list[index];
        set => list[index] = value;
    }

    public void DeleteByIndex(int index)
    {
        if (index < 0 && index > size)
        {
            throw new ArgumentOutOfRangeException("index is out of boundary");
        }

        for (int i = index + 1; i < size; i++)
        {
            list[i - 1] = list[i];
        }

        list[size - 1] = default(T);
        size--;
    }

    public void InsertIn(int index, T element)
    {
        if (index < 0 && index > size)
        {
            throw new ArgumentOutOfRangeException("index is out of boundary");
        }

        if (size == list.Length)
        {
            Resize();
        }

        for (int i = size; i > index; i--)
        {
            list[i] = list[i - 1];
        }

        list[index] = element;
        size++;
    }

    public void Clear()
    {
        list = new T[2];
        size = 0;
    }

    public int Find(T element)
    {
        for (int i = 0; i < size; i++)
        {
            if (element.Equals(list[i]))
            {
                return i;
            }
        }

        return -1;
    }

    public override string ToString()
    {
        string output = "";

        for (int i = 0; i < list.Length; i++)
        {
            output += list[i].ToString() + ", ";
        }

        return output;
    }

    public T Max()
    {
        T max = list[0];

        for (int i = 1; i < size; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }

        return max;
    }

    public T Min()
    {
        T min = list[0];
        
        for (int i = 1; i < size; i++)
        {
            if (list[i].CompareTo(min) < 0)
            {
                min = list[i];
            }
        }

        return min;
    }
}
