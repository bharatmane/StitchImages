using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace ImageStitch
{
   
    public partial class Form1 : Form
    {
        int fullImageWidth = 0;
        int fullImageHeight = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtFolder.Text = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    lstImages.DataSource = files;
                }
            }
        }

        private void btnStitch_Click(object sender, EventArgs e)
        {
            List<int> columns;
            List<int> rows;
            int finalImageHeight = 0;
            int finalImageWidth= 0;
            columns = _GetNumberOfColumns().ToList();
            rows = _GetNumberOfRows().ToList();
            columns.Sort();
            rows.Sort();
            finalImageHeight = _GetFinalImageHeight(rows,columns);
            finalImageWidth = _GetFinalImageWidth(rows, columns);

            string finalImagePath = txtFolder.Text + @"\StitchedImage.jpg";
            Bitmap finalImage = _StitchImages(rows,columns,finalImageHeight,finalImageWidth);
            finalImage.Save(finalImagePath);
            finalImage.Dispose();
            pictureBox1.Image = Image.FromFile(finalImagePath);
        }

        private Bitmap _StitchImages(IEnumerable<int> rows, IEnumerable<int> columns, int finalImageHeight, int finalImageWidth)
        {
            Bitmap finalImage = null;
            try
            {
                finalImage = new Bitmap(finalImageWidth, finalImageHeight);
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Black);
                    int offsetLeft = 0;
                    int offsetTop = 0;
                    foreach (var row in rows)
                    {
                        int maxColumnHeight = 0;
                        offsetLeft = 0;
                        foreach (var column in columns)
                        {
                            string path = txtFolder.Text + @"\" + column.ToString() + "_" + row.ToString() + ".jpg";
                            if (File.Exists(path))
                            {
                                Bitmap image = new Bitmap(path);
                                g.DrawImage(image, new Rectangle(offsetLeft, offsetTop, image.Width, image.Height));
                                offsetLeft += image.Width;
                                maxColumnHeight = Math.Max(maxColumnHeight, image.Height);
                                image.Dispose();
                            }
                        }
                        offsetTop += maxColumnHeight;
                    }
                }
                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();
                throw ex;
            }
            
        }

        private int _GetFinalImageWidth(IEnumerable<int> rows, IEnumerable<int> columns)
        {
            int width = 0;
            foreach (var column in columns)
            {
                int maxRowWidth = 0;
                foreach(var row in rows)
                {
                    string path = txtFolder.Text + @"\" + column.ToString() + "_" + row.ToString() + ".jpg";
                    if (File.Exists(path))
                    {
                        Bitmap image = new Bitmap(path);
                        maxRowWidth = Math.Max(maxRowWidth, image.Width);
                        image.Dispose();
                    }
                }
                width += maxRowWidth;
            }
            return width;
        }

        private int _GetFinalImageHeight(IEnumerable<int> rows, IEnumerable<int> columns)
        {
            int height = 0;
            foreach (var row in rows)
            {
                int maxColumnHeight = 0;
                foreach (var column in columns)
                {
                    string path = txtFolder.Text + @"\" + column.ToString() + "_" + row.ToString() + ".jpg";
                    if (File.Exists(path))
                    {
                        Bitmap image = new Bitmap(path);
                        maxColumnHeight = Math.Max(maxColumnHeight, image.Height);
                        image.Dispose();
                    }
                }
                height += maxColumnHeight;
            }
            return height;
        }

        private IEnumerable<int> _GetNumberOfRows()
        {
            List<int> indexes = new List<int>();
            foreach(var item in lstImages.Items)
            {
                FileInfo fileInfo = new FileInfo(item.ToString());
                if(fileInfo.Name.IndexOf("_") > -1)
                {
                    int startIndex = fileInfo.Name.IndexOf("_") + 1;
                    int length = fileInfo.Name.IndexOf(".") - startIndex;
                    indexes.Add(Convert.ToInt16(fileInfo.Name.Substring(startIndex, length)));
                }
            }
            return indexes.Distinct();
        }

        private IEnumerable<int> _GetNumberOfColumns()
        {
            List<int> indexes = new List<int>();
            foreach (var item in lstImages.Items)
            {
                FileInfo fileInfo = new FileInfo(item.ToString());
                if (fileInfo.Name.IndexOf("_") > -1)
                {
                    int startIndex = 0;
                    int length = fileInfo.Name.IndexOf("_");
                    indexes.Add(Convert.ToInt16(fileInfo.Name.Substring(startIndex, length)));
                }
            }
            return indexes.Distinct();
        }




        //private void CombineImages(MyImage[,] images)
        //{
        //    //change the location to store the final image.



        //    string finalImage = @"E:\Seite\asdsad.png";
        //    int fullWidth = 0;
        //    int fullheight= 0;
        //    for (int i = 0; i < 1; i++)
        //    {
        //        int currentWidth = 0;
        //        int maxHeightCurrentRow = 0;
        //        for (int j = 2; j < 5; j++)
        //        {
        //            currentWidth += images[i, j].Width;
        //            if(maxHeightCurrentRow < images[i, j].Height)
        //            {
        //                maxHeightCurrentRow = images[i, j].Height;
        //            }
        //        }
        //        if(fullWidth < currentWidth)
        //        {
        //            fullWidth = currentWidth;
        //        }
        //        fullheight += maxHeightCurrentRow;
        //    }
        //    //create a bitmap to hold the combined image
        //    System.Drawing.Bitmap finalImage1 = new System.Drawing.Bitmap(fullWidth, fullheight);

        //    //get a graphics object from the image so we can draw on it
        //    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage1))
        //    {
        //        //set background color
        //        g.Clear(System.Drawing.Color.Black);

        //        //go through each image and draw it on the final image
        //        int offset = 0;
        //        for (int j = 2; j < 5; j++)
        //        {
        //            Image img = Image.FromFile(images[0, j].FullName);
        //            g.DrawImage(img,
        //              new System.Drawing.Rectangle(offset, 0, img.Width, img.Height));
        //            offset += img.Width;
        //        }
        //    }

        //    //Bitmap img3 = new Bitmap(fullWidth,fullheight);
        //    //Graphics g = Graphics.FromImage(img3);
        //    //g.Clear(SystemColors.AppWorkspace);
        //    //int locationx = 0;
        //    //int locationy = 0;
        //    //for (int i = 0; i < 1; i++)
        //    //{
        //    //    locationx = 0;
        //    //    for (int j = 0; j < 2; j++)
        //    //    {
        //    //        Image img = Image.FromFile(images[i,j].FullName);
        //    //        g.DrawImage(img, new Point(locationx, locationy));
        //    //        locationx += images[i, j].Width;
        //    //        g.DrawImage(img, new Point(locationx, locationy));
        //    //        img.Dispose();
        //    //    }
        //    //    locationy += 256;
        //    //}

        //    //g.Dispose();
        //    finalImage1.Save(finalImage, System.Drawing.Imaging.ImageFormat.Png);
        //    finalImage1.Dispose();
        //    pictureBox1.Image = Image.FromFile(finalImage);
        //}
    }
}
