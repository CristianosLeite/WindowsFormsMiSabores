using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsMarterialdesign
{
    public partial class PictureTake : MaterialForm
    {
        public PictureTake()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void PictureTake_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cameracomboBox.Items.Add(filterInfo.Name);
                cameracomboBox.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameracomboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                this.FormClosed += PictureTake_FormClosed;

            }
        }

        private void PictureTake_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is NovoCadastroCliente)
                {
                    NovoCadastroCliente novoCadastroCliente = (NovoCadastroCliente)oForm;
                    novoCadastroCliente.Show();
                    break;
                }
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            camerapictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void PictureTake_Closing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void gravarcamerabtn_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is NovoCadastroCliente)
                {
                    NovoCadastroCliente novoCadastroCliente = (NovoCadastroCliente)oForm;
                    novoCadastroCliente.cadastropictureBox.Image = camerapictureBox.Image;
                    if (videoCaptureDevice.IsRunning == true)
                        videoCaptureDevice.Stop();
                    break;
                }
            }
            Close();
        }
    }   
}
