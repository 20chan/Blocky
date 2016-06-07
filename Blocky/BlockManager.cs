using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocky
{
    public class BlockManager
    {
    	public static BlockManager CurrentBlockManager;
    	Block _entryBlock;
    	/// <summary>
    	/// 다음 턴에 실행될 블럭들
    	/// </summary>
        List<Block> _blocks;
        
        public BlockManager(Blocky.Blocks.EntryBlock entry)
        {
        	_blocks = new List<Block>();
        	this._entryBlock = entry;
        }
        
        public void AddBlock(Block block)
        {
            _blocks.Add(block);
        }
        
        public void Start()
        {
        	_entryBlock.Execute();
        }
        
        public bool ExecuteOneTime()
        {
        	Block[] blocks = _blocks.ToArray();
        	_blocks.Clear();
        	foreach(Block b in blocks)
        	{
        		b.Execute();
        	}
        	
        	return (_blocks.Count != 0);
        }
    }
}
