using System.Numerics;
using System.Reflection;

namespace Dithering
{
    public partial class Form1 : Form
    {
        public struct DitheringParams
        {
            public int Kr;
            public int Kg;
            public int Kb;
            public int K;
        }

        public Func<DirectBitmap, DitheringParams, Bitmap> ditheringFunction { get; set; }
        public DirectBitmap? originalImage { get; set; }
        public Bitmap? processedImage { get; set; }

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                alteredImagePanel,
                new object[] { true }
            );
            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                originalImagePanel,
                new object[] { true }
            );
            ditheringFunction = AverageDithering;
        }

        private void originalImagePanel_Resize(object sender, EventArgs e)
        {
            (sender as Panel)!.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                switch (sender)
                {
                    case RadioButton rb when rb == averageRadioButton:
                        ditheringFunction = AverageDithering;
                        break;
                    case RadioButton rb when rb == errDiffusionRadioButton:
                        ditheringFunction = AverageDitheringWithErrorPropagation;
                        break;
                    case RadioButton rb when rb == orderedRandomRadioButton:
                        ditheringFunction = orderedRandomDithering;
                        break;
                    case RadioButton rb when rb == orderedRelativeRadioButton:
                        ditheringFunction = orderedRelativeDithering;
                        break;
                    case RadioButton rb when rb == popularityRadioButton:
                        ditheringFunction = PopularityAlgoritm;
                        break;
                }
                if (originalImage == null)
                    return;
                processedImage = ditheringFunction(
                    originalImage,
                    new DitheringParams
                    {
                        K = (int)KNumeric.Value,
                        Kb = (int)KbNumeric.Value,
                        Kg = (int)KgNumeric.Value,
                        Kr = (int)kRNumeric.Value,
                    }
                );
                alteredImagePanel.Invalidate();
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog f =
                new() { Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG" };
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileName;
                using (Bitmap bitmap = new Bitmap(path))
                {
                    originalImage = new DirectBitmap(bitmap.Width, bitmap.Height);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            Color pixelColor = bitmap.GetPixel(x, y);
                            originalImage.SetPixel(x, y, pixelColor);
                        }
                    }
                }
                processedImage = ditheringFunction(
                    originalImage,
                    new DitheringParams
                    {
                        K = (int)KNumeric.Value,
                        Kb = (int)KbNumeric.Value,
                        Kg = (int)KgNumeric.Value,
                        Kr = (int)kRNumeric.Value,
                    }
                );
                originalImagePanel.Invalidate();
                alteredImagePanel.Invalidate();
            }
        }

        private void originalImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (originalImage == null)
                return;

            Size panelSize = originalImagePanel.ClientSize;
            float scale = Math.Min(
                (float)panelSize.Width / originalImage.Width,
                (float)panelSize.Height / originalImage.Height
            );

            float scaledWidth = originalImage.Width * scale;
            float scaledHeight = originalImage.Height * scale;
            float offsetX = (panelSize.Width - scaledWidth) / 2;
            float offsetY = (panelSize.Height - scaledHeight) / 2;
            e.Graphics.DrawImage(originalImage.Bitmap, offsetX, offsetY, scaledWidth, scaledHeight);
        }

        private void alteredImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (originalImage == null)
                return;

            Size panelSize = originalImagePanel.ClientSize;
            float scale = Math.Min(
                (float)panelSize.Width / originalImage.Width,
                (float)panelSize.Height / originalImage.Height
            );

            float scaledWidth = originalImage.Width * scale;
            float scaledHeight = originalImage.Height * scale;
            float offsetX = (panelSize.Width - scaledWidth) / 2;
            float offsetY = (panelSize.Height - scaledHeight) / 2;
            e.Graphics.DrawImage(processedImage!, offsetX, offsetY, scaledWidth, scaledHeight);
        }

        private void kRNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage == null)
                return;
            processedImage = ditheringFunction(
                originalImage,
                new DitheringParams
                {
                    K = (int)KNumeric.Value,
                    Kb = (int)KbNumeric.Value,
                    Kg = (int)KgNumeric.Value,
                    Kr = (int)kRNumeric.Value,
                }
            );
            alteredImagePanel.Invalidate();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            averageRadioButton.Checked = true;
            KbNumeric.Value = 2;
            kRNumeric.Value = 2;
            KgNumeric.Value = 2;
            KNumeric.Value = 2;
        }
    }
}
