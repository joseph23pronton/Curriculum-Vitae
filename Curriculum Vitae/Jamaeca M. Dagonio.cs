using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    public partial class Jamaeca_M : Form
    {
        public Jamaeca_M()
        {
            InitializeComponent();
        }

        private void Jamaeca_M_Load(object sender, EventArgs e)
        {
            // 1. Set the form size smaller than A4 to enable scrollbars
            this.Size = new Size(600, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 2. Create a scrollable panel
            Panel scrollPanel = new Panel();
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.AutoScroll = true;
            this.Controls.Add(scrollPanel);

            // 3. Create the PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Normal; // show image at real size
            pictureBox.BackColor = Color.White;

            try
            {
                // 4. Load the image
                Image img = Image.FromFile(@"C:\CSD - BSIS\PHOTOS\Grey White Modern Graphic Designer Resume.jpg");
                pictureBox.Image = img;
                pictureBox.Size = img.Size;

                // 5. Add the PictureBox to the scrollable panel
                scrollPanel.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image failed to load:\n" + ex.Message);
            }
        }
    }
}
