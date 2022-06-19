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
/*
using AForge.Video;
using AForge.Video.DirectShow;
*/

namespace WindowsFormsMarterialdesign
{
    public partial class NovoCadastroCliente : MaterialForm
    {

        public NovoCadastroCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        /*
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        */

        private void NovoCadastroCliente_Load(object sender, EventArgs e)
        {
            this.FormClosed += NovoCadastroCliente_FormClosed;
            /*
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                videoCaptureDevice = new VideoCaptureDevice();
            }
            */
        }

        private void NovoCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            foreach(Form oForm in Application.OpenForms)
            {
                if(oForm is MainWindow)
                {
                    MainWindow mainWindow = (MainWindow)oForm;
                    mainWindow.Show();
                    break;
                }
            }

            /*
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
            */
        }


        private void CadastroPictureLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.CheckPathExists = true;
            openFileDialog.Title = "Selecione uma foto";
            openFileDialog.Filter = "JPEG| *.JPEG|PNG| *.png";
            openFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            cadastropictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void CadastroPictureTake_Click(object sender, EventArgs e)
        {
            Hide();
            PictureTake pictureTake = new PictureTake();
            pictureTake.Show();
            /*
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is PictureTake)
                {
                    PictureTake pictureTakeopened = (PictureTake)oForm;
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[pictureTakeopened.cameracomboBox.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                    break;
                }
            }
        }
        
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is PictureTake)
                {
                    PictureTake pictureTakeopened = (PictureTake)oForm;
                    pictureTakeopened.camerapictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
                }
            }
            */
        }

        private void limparcadastrobtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is MainWindow)
                {
                    MainWindow mainWindow = (MainWindow)oForm;
                    mainWindow.Hide();
                    break;
                }
            }
            NovoCadastroCliente novoCadastro = new NovoCadastroCliente();
            novoCadastro.Show();
            
        }
    }
 
}
