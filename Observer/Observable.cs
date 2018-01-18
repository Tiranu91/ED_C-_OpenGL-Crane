using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenGLBasicsCS
{
    interface Observable
    {
        void register(Observer o);
        void notify();
    }
}
