using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocky
{
    public class VariablesManager
    {
        private Dictionary<string, Variable> _vars;
        
        public void AddVar(string name, Variable var)
        {
            if(_vars.Keys.Contains(name))
            {
                _vars[name] = var;
            }
            else
            {
                _vars.Add(name, var);
            }
        }

        public Variable GetVar(string name)
        {
            if(_vars.Keys.Contains(name))
            {
                return _vars[name];
            }
            else
            {
                throw new ArgumentNullException("변수 이름이 테이블에 존재하지 않습니다.");
            }
        }
    }
}
