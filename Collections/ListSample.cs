using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class ListSample
    {
        public void ListOperations()
        {
            List<string> list = new List<string>();
            //Add elements into the list
            list.Add("take");
            list.Add("it");
            list.Add("policy");
            Console.WriteLine("Displaying list");
            Display(list);
            //Remove elements into the list
            Console.WriteLine("Remove Elements in list");
            list.Remove("policy");
            Display(list);

        }
        //Display elements in the list
        public void Display(List<string> list)
        {
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
