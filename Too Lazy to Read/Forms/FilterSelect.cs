using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TooLazyToRead.Forms
{
	public partial class FilterSelect : Form
	{
		public List<int>    SelectedFilters { get; private set; }
		public List<Filter> FilterList      { get; private set; }
		public bool         FiltersModified { get; private set; }

		public FilterSelect(List<Filter> filters, List<int> lastSelected)
		{
			FilterList      = filters;
			SelectedFilters = lastSelected;

			InitializeComponent();
		}

		public FilterSelect(List<Filter> filters)
		{
			FilterList      = filters;
			SelectedFilters = new List<int>();

			InitializeComponent();
		}

		private void FilterSelect_Load(object sender, EventArgs e)
		{
			FilterManager.PopulateFilterList(checkedFilterList, FilterList, true);
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			SelectedFilters.Clear();

			for (int i = 0; i < checkedFilterList.Items.Count; i++)
			{
				if (checkedFilterList.GetItemChecked(i))
				{
					SelectedFilters.Add(i);
				}
			}
		}

		private void checkedFilterList_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int count = checkedFilterList.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1);
			buttonOK.Enabled = count > 0;
		}

		private void buttonManage_Click(object sender, EventArgs e)
		{
			using (var window = new FilterManager(FilterList))
			{
				if (window.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				FilterList = window.NewFilters;
				FilterManager.PopulateFilterList(checkedFilterList, FilterList, true);

				FiltersModified  = true;
				checkAll.Checked = false;
				buttonOK.Enabled = false;
			}
		}

		private void checkAll_CheckedChanged(object sender, EventArgs e)
		{
			checkedFilterList.BeginUpdate();

			for (int i = 0; i < checkedFilterList.Items.Count; i++)
			{
				checkedFilterList.SetItemChecked(i, ((CheckBox)sender).Checked);
			}

			checkedFilterList.EndUpdate();
		}
	}
}