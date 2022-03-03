using System;
using System.Collections;

namespace CC_CollectionNamespace_Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArrayInts = { 3, 2, 1 };
            myArrayInts = new int[20];
            myArrayInts = new int[5] { 1, 2, 3, 4, 5 };

            #region Simple Array List

            ArrayList firstArrayList = new ArrayList();

            //Add Methods
            firstArrayList.Add(myArrayInts);
            firstArrayList.Add(3);
            firstArrayList.Add("meir");
            firstArrayList.Add(new object());
            firstArrayList.Add(true);
            firstArrayList.Add(new Message(""));

            firstArrayList.AddRange(myArrayInts);//Add many items 
            firstArrayList.Add(myArrayInts);//add single item to array


            //Insert Methods
            //add new item in specific index
            firstArrayList.Insert(2, "im from insert method");
            firstArrayList.InsertRange(4, new string[3] { "1", "2", "3" });
            //replace item in specific index
            firstArrayList[2] = "im from indexer";

            //Remove Methods
            firstArrayList.Remove("meir");
            firstArrayList.RemoveAt(4);
            firstArrayList.RemoveRange(9, 2);


            firstArrayList.Clear();

            #endregion

            #region String Array List

            StringArrayList msgArrLst = new StringArrayList();
            msgArrLst.Add("hello ");
            //msgArrLst.AddRange(new object[] { "from ", "hackeru" });//ERROR!!!
            msgArrLst.AddRange(new string[] { "from ", "hackeru " });

            msgArrLst.Insert(1, "all ");
            msgArrLst.InsertRange(3, new string[] { "lesson ", "18 " });

            msgArrLst.Remove("18 ");
            msgArrLst.RemoveAt(1);
            msgArrLst.RemoveRange(1, 2);

            string[] allValues = msgArrLst.GetAll();

            string singleItem = msgArrLst[0];
            string[] manyItems = msgArrLst[new int[2] { 0, 1 }];

            #endregion

            #region Linked List

            SingleLinkedList singleLinkedList = new SingleLinkedList();
            Message mHead = new Message("im the head!!");
            Message m1 = new Message("MESSAGE 1!");
            Message m2 = new Message("MESSAGE 2!");
            Message m3 = new Message("MESSAGE 3!");
            Message m4 = new Message("MESSAGE 4!");
            Message m5 = new Message("message from insertAfter");

            singleLinkedList.InsertFront(mHead);
            singleLinkedList.InsertLast(m1);
            singleLinkedList.InsertLast(m2);
            singleLinkedList.InsertLast(m3);
            singleLinkedList.InsertFront(m4);
            singleLinkedList.InsertAfter(singleLinkedList.head.next, m5);

            #endregion

            #region Hash Table

            Hashtable ht = new Hashtable();
            Chat c1 = new Chat();
            Chat c2 = new Chat();
            Chat c3 = new Chat();

            ht.Add(c1, new Message[] { m1, m2, m3, m4 });
            //ht.Add(c1, new Message[] {m1,m2,m3,m4 });
            ht.Add(true, new Message[] { m1, m2, m3, m4 });
            ht.Add(4, new Message[] { m1, m2, m3, m4 });

            ht.Remove(c1);

            object firstValues = ht[true];
            if (!ht.ContainsKey(c2))
            {
                ht.Add(c2, new object());
            }

            //Error
            //object[] firstKey = (object[])ht.Keys;
            //firstKey[0] = 123;

            ht.Clear();

            #endregion
        }
    }
}
