﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeneriscIntro
{
    class MyList<T> //Generic  Class
    {
        T[] items;
        //constructor  CLASS'LA AYNI İSİM
        //bir class newlendiğinde çalışan bloğa constructor deniliyor
        public MyList() //ctor ile yaptık
        {
            items = new T[0];
           
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
   
    }
}
