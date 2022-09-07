using System;

namespace net.talaatharb.dsa
{
    public class Program{
        public static void Main(string[] args)
        {
            CustomArrayList<int> list = new CustomArrayList<int>();
            for(int i =0; i < 128; i++){
                list.Add(i);
            }

            list.Display();
        }
    }
}