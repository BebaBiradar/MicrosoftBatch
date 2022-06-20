using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    //sort the elemnt accending order
    class ArrayToMethod
    {
        int[] DoSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])//accending order(if(arr[i]<arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }




        static void Main(string[] args)
        {
            int[] a = { 5, 7, 2, 8, 4 };
            ArrayToMethod m = new ArrayToMethod();
            int[] newArray = m.DoSort(a);
            Console.WriteLine(string.Join(" ", newArray));
        }

    }
}

      //sort element in desending order

      /*class ArrayToMethod1
      {
          int[] DoSort(int[] arr)
          {
              for (int i = 0; i < arr.Length; i++)
              {
                  for (int j = 1; j < arr.Length; j++)
                  {
                      if (arr[i] < arr[j])//desending order
                      {
                          int temp = arr[i];
                          arr[i] = arr[j];
                          arr[j] = temp;
                      }
                  }
              }
              return arr;
          }



          static void Main(string[] args)
          {
              int[] a = { 5, 7, 2, 8, 4 };
              ArrayToMethod1 m = new ArrayToMethod1();
              int[] newArray = m.DoSort(a);
              Console.WriteLine(string.Join(" ", newArray));
          }

      }
*/

    


