using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class DynamicArray
    {
        public int[] arr;
        int LastIndexItem;
        public DynamicArray(int size)
        {
            arr = new int[size];
            LastIndexItem = -1;
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new Exception("error!!");
                }
                else
                    return arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                    throw new Exception("error!!");
                else
                    arr[index] = value;
            }
        }
        public void ExpandStorage()
        {
            int[] arr2 = new int[arr.Length * 2];
            Array.Copy(arr, arr2, arr.Length);
            arr = arr2;
        }
        public void Add(int value)
        {
            if (LastIndexItem == arr.Length - 1)
            {
                ExpandStorage();
            }
            LastIndexItem++;
            arr[LastIndexItem] = value;
        }
        public void Print()
        {
            for (int i = 0; i <= LastIndexItem; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int find(int key)
        {
            for (int i = 0; i <= LastIndexItem; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }
        public int Length()
        {
            return LastIndexItem + 1;
        }
        public int StorageLength()
        {
            return arr.Length;
        }
    }
}
