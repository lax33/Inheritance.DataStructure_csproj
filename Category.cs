using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category: IComparable
    {
        readonly string typ;
        //MessageType
        readonly int messagetype;
        readonly MessageType messageType;
        //MessageTopic
        readonly int messagetopic;
        readonly MessageTopic messageTopic;
        public Category(string a, MessageType messageType, MessageTopic messageTopic)
        {
            typ = a;
            messagetype =(int) messageType;
            messagetopic =(int) messageTopic;
            this.messageType = messageType;
            this.messageTopic = messageTopic;
        }        

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            var o =obj as Category;
            if (o == null) return -1;
            {
                if (typ == "A" && o.typ == "A")
                {
                    if (messagetopic == o.messagetopic && messagetype == o.messagetype) return 0;

                    if (messagetopic == o.messagetopic && messagetype > o.messagetype) return 1;

                    if (messagetopic < o.messagetopic && messagetype < o.messagetype) return -1;

                    if (messagetopic < o.messagetopic && messagetype == o.messagetype) return -1;

                    if (messagetopic < o.messagetopic && messagetype > o.messagetype) return 1;

                    if (messagetopic == o.messagetopic && messagetype < o.messagetype) return -1;

                    if (messagetopic > o.messagetopic && messagetype < o.messagetype) return -1;

                    if (messagetopic > o.messagetopic && messagetype == o.messagetype) return 1;                                      
                }
                else
                {
                    if (typ == "A" && o.typ == "B") return -1;
                    if (typ == "B" && o.typ == "A") return 1;
                    if (typ == "B" && o.typ == "B") return 0;
                }
            return -1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Category p = obj as Category;
            if (p == null) return false;
            if (typ == p.typ && messagetype == p.messagetype && messagetopic == p.messagetopic) return true;
            return false;            
        }

        public override int GetHashCode()
        {
            int t;
            if (typ == "A")
            {
                t = 1;
            }
            else
            {
                t = 2;
            }
            return t + messagetopic + messagetype;
        }

        public override string ToString()            
        {
            return $"{typ}.{messageType}.{messageTopic}" ;
        }       

        public static bool operator <=(Category obj1, Category obj2)
        {
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic > obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "B") return true;
            if (obj1.typ == "B" && obj2.typ == "A") return false;
            if (obj1.typ == "B" && obj2.typ == "B") return true;
            return true;
        }
        public static bool operator >=(Category obj1, Category obj2)
        {
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic > obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "B") return false;
            if (obj1.typ == "B" && obj2.typ == "A") return true;
            if (obj1.typ == "B" && obj2.typ == "B") return true;
            return false;
        }
        public static bool operator >(Category obj1, Category obj2)
        {
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic > obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic > obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ =="A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "B") return false;
            if (obj1.typ == "B" && obj2.typ == "A") return true;
            if (obj1.typ == "B" && obj2.typ == "B") return false;
            return false; 
        }
        public static bool operator <(Category obj1, Category obj2)
        {
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic && 
                obj1.messagetype < obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype > obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic < obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return true;            
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic == obj2.messagetopic &&
                obj1.messagetype < obj2.messagetype) return true;
            if (obj1.typ == "A" && obj2.typ == "A" && obj1.messagetopic > obj2.messagetopic &&
                obj1.messagetype == obj2.messagetype) return false;
            if (obj1.typ == "A" && obj2.typ == "B") return true;
            if (obj1.typ == "B" && obj2.typ == "A") return false;
            if (obj1.typ == "B" && obj2.typ == "B") return false;
            return true;
        }
    }
}
