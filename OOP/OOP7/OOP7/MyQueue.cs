using System.Collections.Generic;

namespace OOP7
{

    class MyQueue : Queue<PersonnelDepartment>
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;

        public static MyQueue operator +(MyQueue queue, PersonnelDepartment dep)
        {
            queue.Enqueue(dep);
            queue.onCount();
            return queue;
        }

        public static MyQueue operator -(MyQueue queue)
        {
            queue.Dequeue();
            queue.onCount();
            return queue;
        }
    }
}
