using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	internal class ListViewColumnSort: IComparer
	{
		private int column;
		public static int SortColumn { get; set; }
		public static SortOrder Order { get; set; }
		public ListViewColumnSort()
		{
			column = 0;
		}
		public ListViewColumnSort(int column)
		{
			this.column = column;
		}
		public string FullCompareString(string s)
		{
			string Res = s;
			while (Res.Length < 10) Res = "0" + Res;
			return Res;
		}
		public int Compare(object x, object y)
		{

			string s1 = FullCompareString(((ListViewItem)x).SubItems[column].Text);
			string s2 = FullCompareString(((ListViewItem)y).SubItems[column].Text);
			if (Order == SortOrder.Ascending)
				return String.Compare(s1, s2);
			else
				return String.Compare(s2, s1);
		}
	}
}
