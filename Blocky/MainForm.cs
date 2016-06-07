/*
 * 사용자: philly
 * 날짜: 2016-06-07
 * 시간: 오후 6:22
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Blocky.Blocks;

namespace Blocky
{
	public partial class MainForm : Form
	{
		BlockManager manager;
		public MainForm()
		{
			InitializeComponent();
			EntryBlock entry = new EntryBlock();
			this.Controls.Add(entry.DrawPanel());
			manager = new BlockManager(entry);
			
			BlockManager.CurrentBlockManager = manager;
			DeclareVarBlock block = new DeclareVarBlock();
			entry.Connect(block);
			
			manager.Start();
			while(manager.ExecuteOneTime());
		}
	}
}
