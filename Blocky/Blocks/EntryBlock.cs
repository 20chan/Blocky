/*
 * 사용자: philly
 * 날짜: 2016-06-07
 * 시간: 오후 6:45
 */
using System;

namespace Blocky.Blocks
{
	public class EntryBlock : Block
	{
        private BlockPanel _panel;
        
		public EntryBlock() : base(BlockType.ENTRY)
		{
			_panel = new Blocky.Blocks.Controls.PEntryBlock();
		}
		
		public override void Execute()
		{
			
			base.Execute();
		}
		
		public override System.Windows.Forms.Panel DrawPanel()
		{
			return _panel;
		}
	}
}
