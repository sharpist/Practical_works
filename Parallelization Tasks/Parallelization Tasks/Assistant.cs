using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Parallelization_Tasks
{
    struct Assistant
    {
        public static void SetResolution(ref int pixelWidth, ref int pixelHeight,
            TextBox textBoxPixelWidth, TextBox textBoxPixelHeight)
        {
            // check for empty
            if (textBoxPixelWidth.Text != String.Empty &&
                textBoxPixelHeight.Text != String.Empty)
            {
                foreach (char c in textBoxPixelWidth.Text)
                {
                    if (!Char.IsNumber(c)) throw new Exception("Incorrect data!");
                }
                foreach (char c2 in textBoxPixelHeight.Text)
                {
                    if (!Char.IsNumber(c2)) throw new Exception("Incorrect data!");
                }
            }
            else { throw new Exception("Incorrect data!"); }

            // check for range
            if (Int32.Parse(textBoxPixelWidth.Text) < 320)
            {
                pixelWidth = 320;
                textBoxPixelWidth.Text = pixelWidth.ToString();
            }
            else if (Int32.Parse(textBoxPixelWidth.Text) > 24000)
            {
                pixelWidth = 24000;
                textBoxPixelWidth.Text = pixelWidth.ToString();
            }

            if (Int32.Parse(textBoxPixelHeight.Text) < 240)
            {
                pixelHeight = 240;
                textBoxPixelHeight.Text = pixelHeight.ToString();
            }
            else if (Int32.Parse(textBoxPixelHeight.Text) > 24000)
            {
                pixelHeight = 24000;
                textBoxPixelHeight.Text = pixelHeight.ToString();
            }

            // check for aspect ratios
            if (Int32.Parse(textBoxPixelWidth.Text) /
                Int32.Parse(textBoxPixelHeight.Text) <= 2.95)
                pixelHeight = Int32.Parse(textBoxPixelHeight.Text);
            else
            {
                pixelHeight = (int)(double.Parse(textBoxPixelWidth.Text) / 2.95);
                textBoxPixelHeight.Text = pixelHeight.ToString();
            }

            if (Int32.Parse(textBoxPixelHeight.Text) /
                Int32.Parse(textBoxPixelWidth.Text) <= 2.95)
                pixelWidth = Int32.Parse(textBoxPixelWidth.Text);
            else
            {
                pixelWidth = (int)(double.Parse(textBoxPixelHeight.Text) / 2.95);
                textBoxPixelWidth.Text = pixelWidth.ToString();
            }
        }

        public static void Save(PictureBox pictureBox, Label labelInfo)
        {
            if (pictureBox.Image != null)
            {
                // создать диалоговое окна "Save as..."
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save picture as...";
                // предупреждение, если указано имя уже существующего файла
                saveDialog.OverwritePrompt = true;
                // предупреждение, если указан несуществующий путь
                saveDialog.CheckPathExists = true;
                // список форматов файла
                saveDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                // откл. кнопку "Справка" в диалоговом окне
                saveDialog.ShowHelp = false;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var bmp = new Bitmap(pictureBox.Width, pictureBox.Height, PixelFormat.Format32bppArgb))
                        {
                            var rect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
                            pictureBox.DrawToBitmap(bmp, rect);

                            bmp.Save(saveDialog.FileName, ImageFormat.Bmp);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image!", "Fault",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    labelInfo.Text = "This image was saved!";
                }
            }
            else labelInfo.Text = "Necessary to build a image!";
        }
    }
}
