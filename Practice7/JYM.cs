using System;

namespace JYM
{
    public class Gym<T>
    {
        public T[] data;
        public int count;
        public int capacity;

        public Gym()
        {
            capacity = 4;
            data = new T[capacity];
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void Double()
        {
            capacity = capacity * 2;
            T[] newData = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                Double();
            }
            data[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Индекс не тот");
                }
                return data[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Индекс не тот");
                }
                data[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Индекс не тот");
            }

            for (int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Индекс не тот");
            }

            if (count >= capacity)
            {
                Double();
            }

            data[index] = item;
            count++;
        }
    }
}

