using System.Collections;
using System.ComponentModel;

namespace ChunRiYingV2;

public partial class MainWindow : Form
{
    private static ArrayList images;
    public MainWindow()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        Result.Items.Clear();
        images = ApiRequests.GetImages(searchBox.Text).Result;
        foreach (dynamic image in images)
        {
            Result.Items.Add(image.alt);
        }
    }

    private void Result_MouseDown( object sender, MouseEventArgs e )
    {
        if ( e.Button == MouseButtons.Right )
        {
            //select the item under the mouse pointer
            Result.SelectedIndex = Result.IndexFromPoint( e.Location );
            if ( Result.SelectedIndex != -1)
            {
                contextMenuStrip1.Show(Cursor.Position);   
            }                
        }
    }


    private void 複製圖片連結ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        String url = ((dynamic)images[Result.SelectedIndex]!).url;
        Clipboard.SetText(url.ToString());
    }
}