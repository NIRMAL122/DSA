using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    public class MyArray
    {
        public int length;
        public Object[] data;
        public MyArray()
        {
            this.length = 0;
            this.data=new Object[1];
        }

        public Object Get(int index)
        {
            //Console.WriteLine(data[index]);
            return data[index];

        }
        public Object[] Push(Object item)
        {
            if (this.data.Length == this.length)
            {
                Object[] temp=new object[this.length];
                Array.Copy(this.data, temp, length);
                this.data = new Object[length + 1];
                Array.Copy(temp, this.data, length);
            }
            this.data[this.length] = item;
            this.length++;
            return this.data;
        }

        public Object Pop()
        {
            Object poped = this.data[this.length - 1];
            this.data[this.length - 1] = null;
            this.length--;
            return poped;
        }

        public Object DeleteAtIndex(int index)
        {
            Object itemToDelete = data[index];
            shiftItems(index);
            return itemToDelete;
        }

        private void shiftItems(int index)
        {
            for(int i=index;i<this.length-1;i++)
            {
                this.data[i] = this.data[i+1];
            }
            this.data[length - 1] = null;
            this.length--;
        }


        public void PrintArr()
        {
            foreach(Object item in this.data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
