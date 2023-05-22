using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectWork.Forms.Tasks
{
    public partial class Task5 : Form
    {
        private int _scale = 5;
        private string _imgPath = "chart.png";
        private Image _chartImg;        

        public Task5()
        {
            InitializeComponent();
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private bool IsProductionVolumeValid(float x1, float x2) 
        {
            return (x1 + 2 * x2 <= 6) && (2 * x1 + x2 <= 8);
        }

        private bool IsRequestValid(float x1, float x2)
        {
            return (x2 - x1 <= 1) && (x2 <= 2);
        }

        private float TotalZ(float x1, float x2) 
        {
            return IsProductionVolumeValid(x1, x2) && (IsRequestValid(x1, x2))
                ? 3 * x1 + 2 * x2 : -1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            pictureBox1.Visible = false;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Maximum = _scale;
            chart1.ChartAreas[0].AxisY.Maximum = _scale;

            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.Series[0].ChartType = SeriesChartType.Line;       

            //condition 1
            this.chart1.Series[0].Points.AddXY(0,2);        
            for (int i = 0; i < 8; i++)
                this.chart1.Series[0].Points.AddXY(i + 1, 2);

            //condition 2
            this.chart1.Series.Add("s2");
            this.chart1.Series["s2"].BorderWidth = 3;
            this.chart1.Series["s2"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++)
                this.chart1.Series["s2"].Points.AddXY(0,i);

            //condition 3
            this.chart1.Series.Add("s3");
            this.chart1.Series["s3"].BorderWidth = 3;
            this.chart1.Series["s3"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; ++i)
                this.chart1.Series["s3"].Points.AddXY(i, 0);


            //condition 4 x2=1+x1
            this.chart1.Series.Add("s4");
            this.chart1.Series["s4"].BorderWidth = 3;
            this.chart1.Series["s4"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++)
                this.chart1.Series["s4"].Points.AddXY(i, i+1);

            //condition 5 x2=(8-2*x1)
            this.chart1.Series.Add("s5");
            this.chart1.Series["s5"].BorderWidth = 3;
            this.chart1.Series["s5"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++)
                this.chart1.Series["s5"].Points.AddXY(i, 8-2*i);

            //condition 5 x2=0.5(6-x1)
            this.chart1.Series.Add("s6");
            this.chart1.Series["s6"].BorderWidth = 3;
            this.chart1.Series["s6"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++)
                this.chart1.Series["s6"].Points.AddXY(i, 0.5*(6-i));

            this.button1.Enabled = false;
            _chartImg = Image.FromFile(_imgPath);
            button2.Enabled = true;
            button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            pictureBox1.Visible = true;

            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            this.pictureBox1.Image = _chartImg;
            Bitmap bm = (Bitmap)pictureBox1.Image;
            new FillColorClass().FloodFill(ref bm, Color.Green, new Point(150, 250));
            pictureBox1.Image = bm;

            this.button2.Enabled = false;
            button4.Enabled = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var x1 = (float)Convert.ToDouble(textBox1.Text);
            var x2 = (float)Convert.ToDouble(textBox2.Text);

            label3.Text = $"C = {TotalZ(x1, x2)}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            pictureBox1.Visible = true;

            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            this.pictureBox1.Image = _chartImg;
            Bitmap bm = (Bitmap)pictureBox1.Image;
            new FillColorClass().FloodFill(ref bm, Color.Green, new Point(122, 155));
            pictureBox1.Image = bm;

            this.button2.Enabled = false;
            this.button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.chart1.Visible = true;
            this.pictureBox1.Visible = false;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 5;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 5;

            this.chart1.Series.Add("line1");
            this.chart1.Series["line1"].BorderWidth = 3;
            this.chart1.Series["line1"].ChartType = SeriesChartType.Line;
            this.chart1.Series["line1"].Color = Color.Black;
            this.chart1.Series["line1"].Points.AddXY(0, 3);
            this.chart1.Series["line1"].Points.AddXY(2, 0);

            this.chart1.Series.Add("line2");
            this.chart1.Series["line2"].BorderWidth = 3;
            this.chart1.Series["line2"].ChartType = SeriesChartType.Line;
            this.chart1.Series["line2"].Color = Color.Black;
            this.chart1.Series["line2"].Points.AddXY(1, 3);
            this.chart1.Series["line2"].Points.AddXY(3, 0);

            this.chart1.Series.Add("line3");
            this.chart1.Series["line3"].BorderWidth = 3;
            this.chart1.Series["line3"].ChartType = SeriesChartType.Line;
            this.chart1.Series["line3"].Color = Color.Black;
            this.chart1.Series["line3"].Points.AddXY(2, 3);
            this.chart1.Series["line3"].Points.AddXY(4, 0);

            button5.Enabled = false;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }

    public class FillColorClass
    {
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFOHEADER pBitmapInfo, int un, ref IntPtr lplpVoid, int handle, int dw);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int ExtFloodFill(IntPtr hdc, int X, int Y, int crColor, int wFillType);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern IntPtr CreateSolidBrush(int crColor);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int GetPixel(IntPtr hdc, int X, int Y);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int DeleteObject(IntPtr hObject);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int DeleteDC(IntPtr hdc);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int GdiFlush();
        private const int SRCCOPY = 0xCC0020;

        struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
        }

        public void FloodFill(ref Bitmap bm, Color col, Point Pt)
        {
            if (bm == null)
                return;
            IntPtr srcDC = CreateCompatibleDC(IntPtr.Zero);
            IntPtr dstDC = CreateCompatibleDC(IntPtr.Zero);

            BITMAPINFOHEADER dstBMI = new BITMAPINFOHEADER();
            dstBMI.biBitCount = 24;
            dstBMI.biHeight = bm.Height;
            dstBMI.biSize = System.Runtime.InteropServices.Marshal.SizeOf(dstBMI);
            dstBMI.biWidth = bm.Width;
            dstBMI.biPlanes = 1;

            IntPtr dstBits = new IntPtr();
            IntPtr mbmpGetHbitmap = bm.GetHbitmap();
            // Select the bitmap into an HDC
            IntPtr Obmp = SelectObject(srcDC, mbmpGetHbitmap);
            // Create a DIB
            IntPtr dstBMP = CreateDIBSection(dstDC, ref dstBMI, 0, ref dstBits, 0, 0);
            IntPtr Obmp2 = SelectObject(dstDC, dstBMP);
            // Place our bitmap in the DIB
            BitBlt(dstDC, 0, 0, bm.Width, bm.Height, srcDC, 0, 0, SRCCOPY);
            GdiFlush();
            // Create a brush to use to FloodFill
            IntPtr mBrush = CreateSolidBrush(System.Drawing.ColorTranslator.ToOle(col));
            IntPtr hmm = SelectObject(dstDC, mBrush);
            // Fill with color
            ExtFloodFill(dstDC, Pt.X, Pt.Y, GetPixel(dstDC, Pt.X, Pt.Y), 1);
            // Get the bitmap back with the Filled Color
            bm = Bitmap.FromHbitmap(dstBMP);
            // Go berserk clearing memory
            // ExtFloodFill has a bad reputation for gobbling up memory
            // if you dont clean up properly
            DeleteObject(mBrush);
            DeleteObject(SelectObject(dstDC, mBrush));
            DeleteObject(SelectObject(dstDC, dstBMP));
            DeleteObject(SelectObject(srcDC, mbmpGetHbitmap));
            DeleteObject(hmm);
            DeleteObject(dstBits);
            DeleteObject(Obmp2);
            DeleteObject(Obmp);
            DeleteObject(dstBMP);
            DeleteDC(dstDC);
            DeleteDC(srcDC);
            mbmpGetHbitmap = default(IntPtr);
            hmm = default(IntPtr);
            dstBits = default(IntPtr);
            Obmp2 = default(IntPtr);
            Obmp = default(IntPtr);
            dstBMP = default(IntPtr);
            dstDC = default(IntPtr);
            srcDC = default(IntPtr);
            dstBMI = new BITMAPINFOHEADER();
        }

    }
}
