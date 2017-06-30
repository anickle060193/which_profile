using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhichProfile.Properties;

namespace WhichProfile
{
    public partial class WhichProfileForm : Form
    {
        public WhichProfileForm()
        {
            InitializeComponent();

            ChromeProfilesListView.MouseDoubleClick += ChromeProfilesListView_MouseDoubleClick;

            SaveButton.Click += SaveButton_Click;

            UpdateChromeProfilesListView();
        }

        private void ChromeProfilesListView_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            ListViewItem item = ChromeProfilesListView.GetItemAt( e.X, e.Y );
            if( item != null )
            {
                MessageBox.Show( item.ToString() );
            }
        }

        private void UpdateChromeProfilesListView()
        {
            ChromeProfilesListView.Items.Clear();

            foreach( ChromeProfile profile in Settings.Default.ChromeProfiles )
            {
                ListViewItem item = new ListViewItem( profile.Name );
                item.SubItems.Add( profile.DataDirectory );
                ChromeProfilesListView.Items.Add( item );
            }

            foreach( ColumnHeader column in ChromeProfilesListView.Columns )
            {
                column.Width = -2;
            }
        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            Settings.Default.Save();
        }
    }
}
