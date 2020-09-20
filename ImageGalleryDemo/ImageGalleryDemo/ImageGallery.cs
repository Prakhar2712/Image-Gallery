using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using C1.Win.C1Tile;
using C1.C1Pdf;

namespace ImageGalleryDemo
{
    public partial class ImageGallery : Form
    {
        DataFetcher datafetch = new DataFetcher();
        List<ImageItem> imagesList;
        C1PdfDocument imagePdfDocument = new C1PdfDocument();
        int checkedItems = 0;

        public ImageGallery()
        {
            Display();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
        }

        private async void _search_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            imagesList = await
            datafetch.GetImageData(_searchBox.Text);
            AddTiles(imagesList);
            statusStrip1.Visible = false;
        }
        public int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a == b)
                return a;

            // a is greater 
            if (a > b)
                return gcd(a - b, b);
            return gcd(a, b - a);
        }

        private void AddTiles(List<ImageItem> imageList)
        {
            _imageTileControl.Groups[0].Tiles.Clear();
            foreach (var imageitem in imageList)
            {
                Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                Tile tile = new Tile();
                int x, y;
                x = img.Width / 78;
                y = img.Height / 78;

                if (x >= 9 || y >= 9)
                {
                    x = 8;
                    y = 8;

                }
                int Gcd = gcd(x, y);

                if (x / Gcd == 0 || x / Gcd == 1 || y / Gcd == 0 || y / Gcd == 1)
                {
                    tile.VerticalSize = 2;
                    tile.HorizontalSize = 2;
                }
                else
                {
                    tile.VerticalSize = y;
                    tile.HorizontalSize = x;
                }

                _imageTileControl.Groups[0].Tiles.Add(tile);
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
            }
        }


        private void _exportImage_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                imagePdfDocument.Save(saveFile.FileName);

            }

        }
        private void ConvertToPdf(List<Image> images)
        {


            bool firstPage = true;
            foreach (var selectedimg in images)
            {
                RectangleF rect = imagePdfDocument.PageRectangle;

                if (!firstPage)
                {
                    imagePdfDocument.NewPage();
                }
                firstPage = false;

                rect.Inflate(-72, -72);
                imagePdfDocument.DrawImage(selectedimg, rect);

            }

        }

        private void _exportImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportImage.Location.X, _exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new Point(this.Width, 43));
        }

        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }

        private void _imageTileControl_TileChecked_1(object sender, TileEventArgs e)
        {
            checkedItems++;
            _exportImage.Visible = true;
        }

        private void _imageTileControl_TileUnchecked_1(object sender, TileEventArgs e)
        {
            checkedItems--;
            _exportImage.Visible = checkedItems > 0;
        }

        private void _imageTileControl_Paint_1(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }

    }
}

