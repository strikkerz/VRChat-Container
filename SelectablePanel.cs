﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HentaiWare
{
	class SelectablePanel : Panel
	{
		public SelectablePanel()
		{
			this.SetStyle(ControlStyles.Selectable, true);
			this.TabStop = true;
		}
	}
}
