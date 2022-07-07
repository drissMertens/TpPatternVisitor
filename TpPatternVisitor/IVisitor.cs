using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPatternVisitor
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
