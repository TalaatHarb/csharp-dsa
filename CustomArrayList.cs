using System;

namespace net.talaatharb.dsa
{
    public class CustomArrayList<T>
    {
        private static int DEFAULT_CAPACITY = 2;
        private T[] arr;
        private int count;

        public CustomArrayList()
        {
            this.arr = new T[DEFAULT_CAPACITY];
            this.count = 0;
        }

        public CustomArrayList(int capacity)
        {
            this.arr = new T[capacity];
            this.count = 0;
        }

        public void Add(T item)
        {
            if (count >= arr.Length)
            {
                // Resize array up to be able to hold the extra data
                T[] temp = new T[arr.Length * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }

            arr[count] = item;
            count++;
        }

        public void Display(){
            Console.Write("[");
            for(int i = 0; i < count - 1; i++){
                Console.Write($"{arr[i]?.ToString()}, ");
            }
            Console.Write($"{arr[count-1]?.ToString()}]");
        }
    }

}