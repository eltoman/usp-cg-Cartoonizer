using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using static ImageCartoonEffect.ExtBitmap;

namespace ImageCartoonEffect
{
    public partial class MainForm : Form{
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm(){
            InitializeComponent();

            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Nenhum);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussiano3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussiano5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussiano7x7);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mediano3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mediano5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mediano7x7);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mediano9x9);
            //cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mean3x3);
            //cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mean5x5);
            //cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.LowPass3x3);
            //cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.LowPass5x5);
            //cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Sharpen3x3);

            cmbSmoothingFilter.SelectedIndex = 0;
        }

        private void ApplyFilter(){
            if (previewBitmap == null || cmbSmoothingFilter.SelectedIndex == -1){
                return;
            }
            if (previewBitmap != null){
                SmoothingFilterType filterType = ((SmoothingFilterType)cmbSmoothingFilter.SelectedItem);

                resultBitmap = previewBitmap.CartoonEffectFilter(this,filterType);
            }
        }

        private void FilterValueChangedEventHandler(object sender, EventArgs e){
            ApplyFilter();
            picPreview.Image = resultBitmap;
        }

        private void tsmiOpen_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK) {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap;
                ApplyFilter();
                picPreview.Image = resultBitmap;
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            ApplyFilter();
            picPreview.Image = resultBitmap;
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e) {
            if (resultBitmap != null) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == DialogResult.OK) {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP") {
                        imgFormat = ImageFormat.Bmp;
                    } else if (fileExtension == "JPG") {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        private void validateHTValue(object sender, EventArgs e) {
            if (nudHighThreshold.Value <= nudLowThreshold.Value) {
                nudHighThreshold.Value = nudLowThreshold.Value + 5;
            }
        }

        private void validateLTValue(object sender, EventArgs e) {
            if (nudHighThreshold.Value <= nudLowThreshold.Value) {
                nudLowThreshold.Value = nudHighThreshold.Value - 5;
            }
        }

        //getters and setters

        public Int32 algorithmProgress { set { pbAlgorithm.Value = value; }}

        public uint kernelValue { get { return (uint)nudKernelSize.Value; } }
        public Int32 spatialFactor { get { return (Int32)nudSpatialFactor.Value; } }
        public Int32 colorFactor { get { return (Int32)nudColorFactor.Value; } }
        public Double colorPower { get { return (Double)nudColorPower.Value; } }
        public byte highThreshold { get { return (byte)nudHighThreshold.Value; } }
        public byte lowThreshold { get { return (byte)nudLowThreshold.Value; } }
        public Int32 colorReductionFactor { get { return (Int32)nudColorReductionFactor.Value; } }

    }
}
