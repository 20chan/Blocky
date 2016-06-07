using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Blocky
{
    public abstract class Block
    {
        public static VariablesManager VarManager;
        protected List<Block> _nextBlocks;
        protected BlockType _blockType;
        public Block(BlockType type)
        {
            this._blockType = type;
            this._nextBlocks = new List<Block>();
        }

        public virtual void Execute()
        {
        	foreach(Block b in _nextBlocks)
        	{
        		BlockManager.CurrentBlockManager.AddBlock(b);
        	}
        }

        public abstract Panel DrawPanel();

        public void Connect(Block b)
        {
            if (_nextBlocks.Contains(b))
                return;
            else
                _nextBlocks.Add(b);
        }

        public void Deconnect(Block b)
        {
            if (_nextBlocks.Contains(b))
                _nextBlocks.Remove(b);
            else
                throw new ArgumentNullException("블럭을 삭제하려 했으나 블록이 존재하지 않습니다.");
        }
    }
}
