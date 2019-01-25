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
        //MessageType
        int messagetype;
       
        //MessageTopic
        int messagetopic;
        
        public Category(string a, MessageType messageType, MessageTopic messageTopic)
        {
            typ = a;
            messagetype = (int)messageType;
            messagetopic = (int)messageTopic;

        }        

        public int CompareTo(object obj)
        {
            var o =(Category)obj;
            if (o != null)
            {
                if (typ.Equals(o.typ))
                {
                    if (messagetopic == o.messagetopic)
                    {
                        if (messagetype == o.messagetype)
                        {
                            return 0;
                        }
                    }
                    else if (messagetopic == o.messagetopic)
                    {
                        if (messagetype > o.messagetype)
                        {
                            return 1;
                        }
                    }
                    if (messagetopic < o.messagetopic)
                    {
                        if (messagetype < o.messagetype)
                        {
                            return -1;
                        }
                    }
                    else if (messagetopic < o.messagetopic)
                    {
                        if (messagetype == o.messagetype)
                        {
                            return -1;
                        }
                    }
                    else if (messagetopic < o.messagetopic)
                    {
                        if (messagetype > o.messagetype)
                        {
                            return 1;
                        }
                    }
                    else if (messagetopic == o.messagetopic)
                    {
                        if (messagetype < o.messagetype)
                        {
                            return 1;
                        }
                    }          
                    
                    else if (messagetopic > o.messagetopic)
                    {
                        if (messagetype < o.messagetype)
                        {
                            return -1;
                        }
                    }
                    else if (messagetopic > o.messagetopic)
                    {
                        if (messagetype == o.messagetype)
                        {
                            return -1;
                        }
                    }
                    if (messagetopic > o.messagetopic)
                    {
                        if (messagetype > o.messagetype)
                        {
                            return 1;
                        }
                    }
                }
                else return -1;
            }
            return -1;
        }
        public static bool operator <=(Category obj1, Category obj2)
        {
            if (obj1.typ.Equals(obj2.typ))
                if (obj1.typ.Equals(obj2.typ))
                    if (obj1.messagetype.Equals(obj2.messagetype)) return true;
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
