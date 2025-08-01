using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet6
{
    internal interface INotify
    {
        string Message { get; }
        void Notify();
    }
}
