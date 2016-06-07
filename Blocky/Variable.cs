using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocky
{
    public struct Variable
    {
        public Variable(Type type, Object var) { VarType = type; VarObject = var; }
        public Type VarType;
        public Object VarObject;
    }
}
