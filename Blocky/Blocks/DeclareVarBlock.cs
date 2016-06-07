using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocky.Blocks
{
    public class DeclareVarBlock : Block
    {
        private BlockPanel _panel;

        public DeclareVarBlock() : base(BlockType.DECLAREVAR)
        {
        	_panel = new Blocky.Blocks.Controls.PDeclareVarBlock();
        }

        private void SetVar(string name, Type type, object value)
        {
            Block.VarManager.AddVar(name, new Variable(type, value));
        }

        public override void Execute()
        {
        	//SetVar(_name, _type, _var);
        	base.Execute();
        }

        public override Panel DrawPanel()
        {
            return _panel;
        }
    }
}
