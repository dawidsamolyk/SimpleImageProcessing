using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private FileOpener fileOpener;
        private FileSaver fileSaver;
        private Bitmap originalBitmap;

        public MainForm() {
            fileOpener = null;
            fileSaver = null;
            originalBitmap = null;
            
            InitializeComponent();
        }

        private void openFile_action(object sender, EventArgs e) {
            fileOpener = new FileOpener(openFileDialog, picture);
            fileOpener.openFile();

            copyOpenedImageToBuffer();
        }

        private void copyOpenedImageToBuffer() {
            try {
                originalBitmap = (Bitmap)picture.Image.Clone();
            } catch (NullReferenceException) {
                MessageBox.Show("Image isn't open!");
            }
        }

        private void closeImage_action(object sender, EventArgs e) {
            picture.Image = null;
            originalBitmap = null;
        }

        private void saveFile_action(object sender, EventArgs e) {
            if (picture.Image != null) {
                fileSaver = new FileSaver(saveFileDialog, picture);
                fileSaver.saveFile();
            } else { MessageBox.Show("Image isn't open!"); } 
        }

        private void setImage(Bitmap inBitmap) {
            try {
                picture.Image = inBitmap;
            } catch (SystemException exp) {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void invert_action(object sender, EventArgs e)  {
            undo_action(sender, e);
            if (picture.Image != null) {
                Bitmap bitmap = Effects.getInverted((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); } 
        }

        private void grayscale_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if (picture.Image != null) {
                Bitmap bitmap = Effects.getGrayscale((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); } 
        }

        private void showY_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if (picture.Image != null) {
                Bitmap bitmap = ChannelSelector.getYchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); } 
        }

        private void showU_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if (picture.Image != null) {
                Bitmap bitmap = ChannelSelector.getUchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); }
        }

        private void showV_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if (picture.Image != null) {
                Bitmap bitmap = ChannelSelector.getVchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); }
        }

        private void showR_action(object sender, EventArgs e)  {
            undo_action(sender, e);
            if (picture.Image != null)  {
                Bitmap bitmap = ChannelSelector.getRchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); }
        }

        private void showG_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if(picture.Image != null) {
                Bitmap bitmap = ChannelSelector.getGchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); }
        }

        private void showB_action(object sender, EventArgs e) {
            undo_action(sender, e);
            if(picture.Image != null) {
                Bitmap bitmap = ChannelSelector.getBchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            } else { MessageBox.Show("Image isn't open!"); }
        }

        private void showC_action(object sender, EventArgs e)
        {
            undo_action(sender, e);
            if (picture.Image != null)
            {
                Bitmap bitmap = ChannelSelector.getCchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void showM_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = ChannelSelector.getMchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void showYellow_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = ChannelSelector.getYellowchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void showK_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = ChannelSelector.getKchannelFor((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void blur_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = Convolution.getBlurred((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void gausianBlur_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = Convolution.getGausianBlurred((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void sharpen_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Bitmap bitmap = Convolution.getSharpen((Bitmap)picture.Image);
                setImage(bitmap);
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void customConvolutionFilter3x3_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Custom3x3ConvolutionFilterControl ccfWindow = new Custom3x3ConvolutionFilterControl(picture);
                ccfWindow.Show();
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void customConvolutionFilter5x5_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                Custom5x5ConvolutionFilterControl ccfWindow = new Custom5x5ConvolutionFilterControl(picture);
                ccfWindow.Show();
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void HSLfilter_action(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                HSLfilterControl hslWindow = new HSLfilterControl(picture);
                hslWindow.Show();
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void brightnessHistogram(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                undo_action(sender, e);
                int[] brightnessValues = ChannelSelector.getBrightness((Bitmap)picture.Image);

                BrightnessHistogramWindow histogramWindow = new BrightnessHistogramWindow(brightnessValues, picture, originalBitmap);
                histogramWindow.Show();
            }
            else { MessageBox.Show("Image isn't open!"); }
        }

        private void undo_action(object sender, EventArgs e)
        {
            try {
                picture.Image = (Bitmap)originalBitmap.Clone();
                convolution_box.Text = RGB_box.Text = effects_box.Text = YUV_box.Text = CMYK_box.Text = "Choose";
            } catch (NullReferenceException)  {
                MessageBox.Show("Image isn't open!");
            }
        }
         
        private void RGB_box_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = RGB_box.SelectedItem.ToString();

            if (selected == "Show R") { convolution_box.Text = effects_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; showR_action(sender, e); }
            if (selected == "Show G") { convolution_box.Text = effects_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; showG_action(sender, e); }
            if (selected == "Show B") { convolution_box.Text = effects_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; showB_action(sender, e); }
        }

        private void effects_box_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = effects_box.SelectedItem.ToString();

            if (selected == "Invert") { convolution_box.Text = RGB_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; invert_action(sender, e); }
            if (selected == "Grayscale") { convolution_box.Text = RGB_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; grayscale_action(sender, e); }
        }

        private void YUV_box_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = YUV_box.SelectedItem.ToString();

            if (selected == "Show Y") { convolution_box.Text = RGB_box.Text = effects_box.Text = CMYK_box.Text = "Choose"; showY_action(sender, e); }
            if (selected == "Show U") { convolution_box.Text = RGB_box.Text = effects_box.Text = CMYK_box.Text = "Choose"; showU_action(sender, e); }
            if (selected == "Show V") { convolution_box.Text = RGB_box.Text = effects_box.Text = CMYK_box.Text = "Choose"; showV_action(sender, e); }
        }
        
        private void CMYK_box_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = CMYK_box.SelectedItem.ToString();

            if (selected == "Show C") { convolution_box.Text = RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; showC_action(sender, e); }
            if (selected == "Show M") { convolution_box.Text = RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; showM_action(sender, e); }
            if (selected == "Show Y") { convolution_box.Text = RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; showYellow_action(sender, e); }
            if (selected == "Show K") { convolution_box.Text = RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; showK_action(sender, e); }
        }

        private void Convolution_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = convolution_box.SelectedItem.ToString();

            if (selected == "Blur") { RGB_box.Text = effects_box.Text = YUV_box.Text = CMYK_box.Text = "Choose"; blur_action(sender, e); }
            if (selected == "Gaussian Blur") { RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; gausianBlur_action(sender, e); }
            if (selected == "Sharpen") { RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; sharpen_action(sender, e); }
            if (selected == "Custom 3x3") { RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; customConvolutionFilter3x3_action(sender, e); }
            if (selected == "Custom 5x5") { RGB_box.Text = effects_box.Text = YUV_box.Text = "Choose"; customConvolutionFilter5x5_action(sender, e); }
        }

        private void closeButton_action(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
