using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// TODO: Implement replacement tester in window

namespace TooLazyToRead.Forms
{
	public partial class FilterManager : Form
	{
		private List<Filter> filtersOld;

		public List<Filter> NewFilters { get; }

		public FilterManager(List<Filter> filters)
		{
			filtersOld = filters;
			NewFilters = filtersOld.Clone();
			InitializeComponent();
		}

		private void FilterManager_Load(object sender, EventArgs e)
		{
			PopulateFilterList(checkedFilterList, NewFilters);
			groupProperties.Enabled = false;
			int enabled = NewFilters.Count(f => f.Enabled);

			checkEnableAll.Checked = enabled == NewFilters.Count;
		}

		public static void PopulateFilterList(CheckedListBox list, List<Filter> filters, bool setFalse = false)
		{
			list.BeginUpdate();

			int index = list.SelectedIndex;

			if (list.Items.Count > 0)
			{
				list.Items.Clear();
			}

			for (int i = 0; i < filters.Count; i++)
			{
				list.Items.Add(filters[i].Name);
				if (!setFalse)
				{
					list.SetItemChecked(i, filters[i].Enabled);
				}
			}

			if (index >= 0 && index < list.Items.Count)
			{
				list.SelectedIndex = index;
			}

			list.EndUpdate();
		}

		private void ApplySettings()
		{
			for (int i = 0; i < checkedFilterList.Items.Count; i++)
			{
				NewFilters[i].Enabled = checkedFilterList.GetItemChecked(i);
			}

			filtersOld = new List<Filter>(NewFilters);
		}

		private void SaveFilterSettings(int index)
		{
			if (index < 0)
			{
				return;
			}

			if (textName.Text.Length < 1)
			{
				MessageBox.Show("You must specify a name for your filter!",
					"Error saving filter.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				textName.Select();
				return;
			}

			NewFilters[index].Name = textName.Text;
			NewFilters[index].Enabled = checkedFilterList.GetItemChecked(index);
			NewFilters[index].Description = textDescription.Text;

			if (radioPlain.Checked)
			{
				NewFilters[index].Type = FilterType.Plain;
			}
			else if (radioWildcard.Checked)
			{
				NewFilters[index].Type = FilterType.Wildcard;
				// This will tell the class to re-generate wildcard -> regex
				// cache at next run.
				NewFilters[index].CachedRegex = false;
			}
			else if (radioRegex.Checked)
			{
				NewFilters[index].Type = FilterType.Regex;
			}

			NewFilters[index].CaseSensitive = checkCaseSensitive.Checked;

			NewFilters[index].MatchText = textMatch.Text;
			NewFilters[index].ReplaceText = textReplace.Text;
			NewFilters[index].EscapeReplace = checkEscapeReplace.Checked;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			SaveFilterSettings(checkedFilterList.SelectedIndex);
			ApplySettings();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			SaveFilterSettings(checkedFilterList.SelectedIndex);
			PopulateFilterList(checkedFilterList, NewFilters);
		}

		private void buttonAddFilter_Click(object sender, EventArgs e)
		{
			checkedFilterList.Items.Add("New Filter");
			Filter f = new Filter
			{
				Name = "New Filter",
				Enabled = true,
				Type = FilterType.Plain
			};

			NewFilters.Add(f);
		}

		private void buttonRemoveFilter_Click(object sender, EventArgs e)
		{
			checkedFilterList.BeginUpdate();

			int index = checkedFilterList.SelectedIndex;

			checkedFilterList.Items.RemoveAt(index);
			NewFilters.RemoveAt(index);

			if (checkedFilterList.Items.Count > 0)
			{
				if (index == checkedFilterList.Items.Count)
				{
					checkedFilterList.SelectedIndex = --index;
				}
				else
				{
					checkedFilterList.SelectedIndex = index;
				}
			}

			checkedFilterList.EndUpdate();
		}

		private void Swap(int from, int to)
		{
			try
			{
				Filter a = NewFilters[to];
				NewFilters[to] = NewFilters[from];
				NewFilters[from] = a;
				checkedFilterList.SelectedIndex = to;
			}
			catch (Exception ex)
			{
				MessageBox.Show("The following error occurred while trying to sort:\n\n"
				                + ex.Message
				                + "\n\nPlease report the bug.", "Sort Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonFilterUp_Click(object sender, EventArgs e)
		{
			Swap(checkedFilterList.SelectedIndex, checkedFilterList.SelectedIndex - 1);
			PopulateFilterList(checkedFilterList, NewFilters);
		}

		private void buttonFilterDown_Click(object sender, EventArgs e)
		{
			Swap(checkedFilterList.SelectedIndex, checkedFilterList.SelectedIndex + 1);
			PopulateFilterList(checkedFilterList, NewFilters);
		}

		private void checkEnableAll_CheckedChanged(object sender, EventArgs e)
		{
			checkedFilterList.BeginUpdate();

			for (int i = 0; i < checkedFilterList.Items.Count; i++)
			{
				checkedFilterList.SetItemChecked(i, ((CheckBox)sender).Checked);
				NewFilters[i].Enabled = checkedFilterList.GetItemChecked(i);
			}

			checkedFilterList.EndUpdate();
		}

		private void listFilters_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonFilterUp.Enabled = checkedFilterList.SelectedIndex > 0;
			buttonFilterDown.Enabled = checkedFilterList.SelectedIndex < checkedFilterList.Items.Count - 1;

			if (checkedFilterList.SelectedIndex >= 0)
			{
				int index = checkedFilterList.SelectedIndex;

				textName.Text = NewFilters[index].Name;
				checkedFilterList.SetItemChecked(index, NewFilters[index].Enabled);
				textDescription.Text = NewFilters[index].Description;

				switch (NewFilters[index].Type)
				{
					case FilterType.Plain:
						radioPlain.Checked = true;
						break;

					case FilterType.Wildcard:
						radioWildcard.Checked = true;
						break;

					case FilterType.Regex:
						radioRegex.Checked = true;
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				checkCaseSensitive.Checked = NewFilters[index].CaseSensitive;

				textMatch.Text = NewFilters[index].MatchText;
				textReplace.Text = NewFilters[index].ReplaceText;
				checkEscapeReplace.Checked = NewFilters[index].EscapeReplace;

				groupProperties.Enabled = true;
				buttonApply.Enabled = true;

				buttonRemoveFilter.Enabled = true;
				checkEscapeReplace.Enabled = radioRegex.Checked;
			}
			else
			{
				textName.Text = "";
				textDescription.Text = "";
				radioPlain.Checked = false;
				radioWildcard.Checked = false;
				radioRegex.Checked = false;

				checkCaseSensitive.Checked = false;

				textMatch.Text = "";
				textReplace.Text = "";

				groupProperties.Enabled = false;
				buttonApply.Enabled = false;

				buttonRemoveFilter.Enabled = false;
			}
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to restore the default filters?"
			                                      + "\nThis can only be undone by clicking Cancel or Close on the Filter Manager."
			                                      + "\n\nSelecting No will cancel.",
				"Are you sure?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result != DialogResult.Yes)
			{
				return;
			}

			Enabled = false;
			NewFilters.Clear();
			NewFilters.AddRange(Program.DefaultFilters);
			PopulateFilterList(checkedFilterList, NewFilters);
			Enabled = true;

			MessageBox.Show("Default filters have been successfully restored. These changes will not take effect until you click OK or Apply on the filter manager.",
				"Restored default filters", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void checkedFilterList_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			try
			{
				NewFilters[e.Index].Enabled = e.NewValue == CheckState.Checked;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while changing the state of the filter.\n\n"
				                + ex.Message, "Filter Manager Error", MessageBoxButtons.OK);
			}
		}

		private void radioRegex_CheckedChanged(object sender, EventArgs e)
		{
			checkEscapeReplace.Enabled = radioRegex.Checked;
		}
	}
}