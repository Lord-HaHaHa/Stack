using System;
using System.Collections.Generic;

namespace Stack
{
    public partial class MainWindow
    {
        public class Stack
        {
            // Attribute
            private int _MaxLength;
            private List<int> StackElements;

            // Eigenschaften
            public int MaxLength
            {
                get => _MaxLength;
                set
                {
                    if(value >= 0)
                    {
                        _MaxLength = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(value)} cant be lower than 0.");
                }
            }
            
            // Konstruktor
            public Stack()
            {
                StackElements = new List<int>();
                MaxLength = 1;
            }

            // Methoden
            public void Push(int value)
            {
                if (StackElements.Count < MaxLength)
                    StackElements.Insert(0,value);
                else
                    throw new ArgumentException("stack is allredy full");
            }
            public int Pop()
            {
                int value;
                if (GetFillStatus() > 0)
                {
                    value = StackElements[0];
                    StackElements.RemoveAt(0);
                    return value;
                }
                throw new ArgumentException("stack is allredy empty");
            }
            public int GetFillStatus() => StackElements.Count;

        }
    }
}
