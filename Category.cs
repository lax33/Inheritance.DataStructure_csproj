using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category: IComparable
    {
        string typ;
        int incoming;
        int outgoing;
        int service;
        public Category(string a, MessageType messageType, MessageTopic messageTopic)
        {
            typ = a;
            incoming =(int)messageTopic;
            outgoing = (int)messageTopic;

        }        

        public int CompareTo(object obj)
        {
            var o =(Category)obj;
           return o.typ.CompareTo(typ);
               // if(incoming.CompareTo(o.incoming)==1)
                    // if(service.CompareTo(o.outgoing)==1) return 1;
            throw new NotImplementedException();
        }
        public static bool operator <=(Category obj1, Category obj2)
        {
            if (obj1.typ.Equals(obj2.typ))
                if (obj1.incoming.Equals(obj2.incoming))
                    if (obj1.outgoing.Equals(obj2.outgoing)) return true;
            return false;
        }
        public static bool operator >=(Category obj1, Category obj2)
        {
            return true;
        }
        public static bool operator >(Category obj1, Category obj2)
        {
            return true;
        }
        public static bool operator <(Category obj1, Category obj2)
        {
            return true;
        }
    }
}
