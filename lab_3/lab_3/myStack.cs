using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    class myStack
    {
        static Stack<Human> humansStack = new Stack<Human>();

        public static event EventHandler objectCreated;
        public static event EventHandler objectDelete;

        static public void Push(Human human)
        {
            humansStack.Push(human);
            //objectCreated?.Invoke(human,null);
        }

        static public int Count()
        {
            return humansStack.Count();
        }

        public static Stack<Human> humanStack()
        {
            return humansStack;
        }

        public static Human FirstOrDefault(string selected)
        {
            return humansStack.FirstOrDefault(s => s.Name == selected);
        }

        public static Stack<Human> Pop(string selected)
        {
            int k = 0;
            Stack<Human> newStack = new Stack<Human>();
                foreach(Human human in humansStack.ToArray())
                {
                    if (human.Name != selected)
                    {
                        newStack.Push(humansStack.Pop());
                        k++;
                    }
                    else
                    {
                    humansStack.Pop();
                        for (int i = 0; i < k; i++)
                        {
                            humansStack.Push(newStack.Pop());
                        }
                    break;
                    }
                }
                Human.ObjectsCount--;
            objectDelete?.Invoke(selected, null);
                return humansStack;
        }
    }
}
