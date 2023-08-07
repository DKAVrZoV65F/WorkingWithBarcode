using BarcodeNet.ImageSharp;
using BarcodeNet.Managment;
using MaterialSkin;
using MaterialSkin.Controls;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Drawing.Imaging;
using Color = System.Drawing.Color;

namespace Barcode_Editor_App
{
	public partial class Form1 : MaterialForm
	{
		public String path = "";
		System.Drawing.Point mousePos;

		/*
		 * Form1 initializes the graphical interface;
		 */
		public Form1()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			rbSummer.Checked = true;
		}

		/*
		 * Increase or reduce image light
		 */
		private void btnExecute_Click(object sender, EventArgs e)
		{
			Bitmap image = new(path);
			double value = 1;
			value = double.Parse(tbIncDecVal.Text);

			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					Color pixelColor = image.GetPixel(x, y);

					int newBrightness = (int)(pixelColor.GetBrightness() * value * 255);

					// Limit range [0, 255]
					newBrightness = Math.Max(0, Math.Min(255, newBrightness));

					Color newColor = Color.FromArgb(pixelColor.A, newBrightness, newBrightness, newBrightness);

					image.SetPixel(x, y, newColor);
				}
			}

			image.Save($"execution\\inc_dec_{Path.GetFileName(path)}.bmp", ImageFormat.Bmp);
			MessageBox.Show("Execute");
		}

		/*
		 * Image processing by barcodes
		 */
		private void btnExecuteLength_Click(object sender, EventArgs e)
		{
			ISImageContainer container = new ISImageContainer(SixLabors.ImageSharp.Image.Load<L8>(path));
			int width = container.Width;
			int height = container.Height;
			BarCodeLineContainer<byte>? barcodeContainer = container.GetBarCode<byte>();

			if (chbSelectionLength.Checked)
			{
				int length_1 = 0;
				int length_2 = 1;
				string phrase = tbRangeText.Text.ToString();
				string[] words = phrase.Split('-');

				length_1 = Int32.Parse(words[0].Trim());
				length_2 = Int32.Parse(words[1].Trim());

				for (int range = length_1; range <= length_2; range++)
				{
					Image<L8> img = barcodeContainer.BarCodes
					.Where(x => x.Childs.Length == range)
					.Select(a => a.Barcode)
					.ToImageL8(width, height, false);
					img.Save($"temp\\Equals_{range}.bmp");
					img.Dispose();

					Image<L8> img1 = barcodeContainer.BarCodes
						.Where(x => x.Childs.Length != range)
						.Select(a => a.Barcode)
						.ToImageL8(width, height, false);
					path = $"temp\\Another_{range}.bmp";
					img1.Save(path);
					img1.Dispose();
				}
			}
			else
			{
				int length = (int)nudLengthBarcode.Value;

				//	Image Processing
				Image<L8> img = barcodeContainer.BarCodes
					.Where(x => x.Barcode.Length == length)
					.Select(a => a.Barcode)
					.ToImageL8(width, height, false);
				img.Save($"execution\\Equals_{length}.bmp");

				Image<L8> img1 = barcodeContainer.BarCodes
					.Where(x => x.Barcode.Length != length)
					.Select(a => a.Barcode)
					.ToImageL8(width, height, false);
				img1.Save($"execution\\Another_{length}.bmp");
				// End image processing

				pbMain.Image = null;
				pbMain.Image = System.Drawing.Image.FromFile($"execution\\Equals_{length}.png");
			}
			MessageBox.Show("Executed!");
		}

		/*
		 * Open image
		 */
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select image";
			openFileDialog.InitialDirectory = @"C:\\Users\\User\\Picture";
			openFileDialog.Filter = "All files (*.*) | *.*| Image PNG (*.png)|*.png| Image JPEG (*.jpeg)|*.jpeg";
			openFileDialog.FilterIndex = 1;
			openFileDialog.ShowDialog();
			if (openFileDialog.FileName == "")
			{
				return;
			}

			path = openFileDialog.FileName;
			pbMain.Image = null;
			pbMain.Image = System.Drawing.Image.FromFile(path);
			btnExecute.Enabled = true;
			btnExecuteLength.Enabled = true;
		}

		private void nudX_ValueChanged(object sender, EventArgs e)
		{
			pbMain.Refresh();
		}

		/*
		 * Image processing by barcodes in red box
		 */
		private void btnExecuteRect_Click(object sender, EventArgs e)
		{
			ISImageContainer container = new ISImageContainer(SixLabors.ImageSharp.Image.Load<L8>(path));
			int width = container.Width;
			int height = container.Height;
			IEnumerable<BarPointValue<byte>> points = Enumerable.Empty<BarPointValue<byte>>();
			BarCodeLineContainer<byte>? barcodeContainer = container.GetBarCode<byte>();

			var range = Enumerable.Range((int)nudX.Value, (int)nudX2.Value).ToArray();
			for (int i = (int)nudY.Value; i <= (int)nudY.Value + (int)nudY2.Value; i++)
			{
				points = points.Concat(range.Select(a => new BarPointValue<byte>(i * width + a, 50)).ToArray());
			}

			Image<L8> img5 = barcodeContainer.BarCodes
			.Select(x => x.Barcode)
			.Append(new BarCodeLine<byte>(points))
			.ToImageL8(width, height, false);
			path = "execution\\Figures_AppendBC.bmp";
			img5.Save(path);
			pbMain.Image = null;
			pbMain.Image = System.Drawing.Image.FromFile(path);
			MessageBox.Show("Complete!");
		}


		private void pictureBox3_Paint(object sender, PaintEventArgs e)
		{
			Pen blkpen = new Pen(Color.FromArgb(255, 0, 155), 1);
			e.Graphics.DrawRectangle(blkpen, (int)nudX.Value, (int)nudY.Value, (int)nudX2.Value, (int)nudY2.Value);
		}

		/*
		 * Clue two image
		 */
		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select image";
			openFileDialog.InitialDirectory = @"C:\\Users\\User\\Picture";
			openFileDialog.Filter = "All files (*.*) | *.*| Image PNG (*.png)|*.png| Image JPEG (*.jpeg)|*.jpeg";
			openFileDialog.FilterIndex = 1;
			openFileDialog.ShowDialog();

			if (openFileDialog.FileName == "")
			{
				return;
			}
			String path2 = openFileDialog.FileName;

			openFileDialog.ShowDialog();

			if (openFileDialog.FileName == "")
			{
				return;
			}
			String path3 = openFileDialog.FileName;
			Bitmap image = new Bitmap(path2);
			Bitmap image_2 = new Bitmap(path3);

			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					Color pixelColor = image.GetPixel(x, y);
					Color pixelColor_2 = image_2.GetPixel(x, y);

					int newBrightness_1 = (int)(pixelColor.GetBrightness() * 255);
					int newBrightness_2 = (int)(pixelColor_2.GetBrightness() * 255);
					int newBrightness = 0;
					// Limit range [0, 255]

					if (rbSummer.Checked)
					{
						newBrightness = (int)newBrightness_1 + newBrightness_2;
						newBrightness = Math.Max(0, Math.Min(255, newBrightness));  //	Summer
					}
					else if (rbMax.Checked)
					{
						newBrightness = Math.Max(newBrightness_1, newBrightness_2); //	MAX
					}
					else
					{
						newBrightness = Math.Min(newBrightness_1, newBrightness_2); //	MIN
					}

					Color newColor = Color.FromArgb(pixelColor.A, newBrightness, newBrightness, newBrightness);
					image.SetPixel(x, y, newColor);
				}
			}

			path = "execution\\Glue_Two_Images_Together.bmp";
			image.Save(path, ImageFormat.Bmp);
			image.Dispose();
			image_2.Dispose();
			pbMain.Image = null;
			pbMain.Image = System.Drawing.Image.FromFile(path);
			MessageBox.Show("Complete!");
		}

		/*
		 * Convert image from RGB to black-white
		 */
		private void btnToGrey_Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(path);
			Bitmap res = new Bitmap(bmp.Width, bmp.Height);

			Color p;
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					p = bmp.GetPixel(x, y);

					int a = p.A;
					int r = p.R;
					int g = p.G;
					int b = p.B;

					int avg = (r + g + b) / 3;
					res.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
				}
			}
			path = "execution\\FromRGBToGrey.bmp";
			res.Save(path, ImageFormat.Bmp);
			res.Dispose();
			bmp.Dispose();

			pbMain.Image = null;
			pbMain.Image = System.Drawing.Image.FromFile(path);
			MessageBox.Show("Complete!");
		}

		/*
		 * Apply inversion to image
		 */
		private void btnInversion_Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(path);
			Bitmap res = new Bitmap(bmp.Width, bmp.Height);

			Color p;
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					p = bmp.GetPixel(x, y);

					int r = p.R;
					int g = p.G;
					int b = p.B;

					res.SetPixel(x, y, Color.FromArgb(255 - r, 255 - g, 255 - b));
				}
			}
			path = "execution\\Inversion_.bmp";
			res.Save(path, ImageFormat.Bmp);
			res.Dispose();
			bmp.Dispose();
			pbMain.Image = null;
			pbMain.Image = System.Drawing.Image.FromFile(path);
			MessageBox.Show("Complete!");
		}

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{
			mousePos = e.Location;
		}

		private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				int dx = e.X - mousePos.X;
				int dy = e.Y - mousePos.Y;
				pbMain.Location = new System.Drawing.Point(pbMain.Left + dx, pbMain.Top + dy);
			}
		}

		private void chbSelectionLength_CheckedChanged(object sender, EventArgs e)
		{
			if (chbSelectionLength.Checked)
			{
				tbRangeText.Visible = true;
				nudLengthBarcode.Visible = false;
			}
			else
			{
				tbRangeText.Visible = false;
				nudLengthBarcode.Visible = true;
			}
		}

		private void rbSummer_Click(object sender, EventArgs e)
		{
			rbSummer.Checked = true;
			rbMax.Checked = false;
			rbMin.Checked = false;
		}

		private void rbMax_Click(object sender, EventArgs e)
		{
			rbSummer.Checked = false;
			rbMax.Checked = true;
			rbMin.Checked = false;
		}

		private void rbMin_Click(object sender, EventArgs e)
		{
			rbSummer.Checked = false;
			rbMax.Checked = false;
			rbMin.Checked = true;
		}
	}
}