using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_CollectionNamespace_Lesson18
{
    internal class StringArrayList
    {
        private ArrayList messages = new ArrayList();


        //Create Indexer(return string) with get and set

        //*** Create Overload Indexer(accept int[](for indexes) and return string[](items)) with get and set

        public string this[int index]
        {
            get
            {
                return (string)messages[index].ToString();
            }
            set
            {
                messages[index] = value;
            }
        }

        public string[] this[int[] indexes]
        {
            get
            {
                //3,4,2
                string[] result = new string[indexes.Length];
                for (int i = 0; i < indexes.Length; i++)
                {
                    result[i] = (string)messages[indexes[i]];
                }
                return result;
            }
        }

        public void Add(string newMessage)
        {
            messages.Add(newMessage);
        }

        //Create AddRange Method : Accept string[]
        public void AddRange(string[] newMessage)
        {
            messages.AddRange(newMessage);
        }

        //Create Insert Method : Accept two paramters(index, string)
        public void Insert(int index, string message)
        {
            messages.Insert(index, message);
        }

        //Create InsertRange Method : Accept two paramters(index, string[])
        public void InsertRange(int index, string[] messages)
        {
            this.messages.InsertRange(index, messages);
        }

        //Create Remove Method : accept the instance to remove
        public void Remove(string message)
        {
            this.messages.Remove(message);
        }

        //Create RemoveAt Method : Accept the index to remove
        public void RemoveAt(int index)
        {
            this.messages.RemoveAt(index);
        }
        //Create RemoveRange Method : accept two aparamters(index, count)
        public void RemoveRange(int fromIndex, int count)
        {
            this.messages.RemoveRange(fromIndex, count);
        }

        //Create GetByIndex Method Or Indexer
        //Create GetAll Method : return string[]
        public string[] GetAll()
        {
            //short way
            //return (string[])messages.Clone();

            string[] stringArray = new string[messages.Count];
            for (int i = 0; i < messages.Count; i++)
            {
                stringArray[i] = (string)messages[i];

            }
            return stringArray;
        }
    }
}
