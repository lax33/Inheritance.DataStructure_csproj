using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category: IComparable
    {
        public Category(string a, MessageType messageType, MessageTopic messageTopic)
        {

        }
        public int CompareTo(Category a )
        {
            return  a;
        }

    }
}
