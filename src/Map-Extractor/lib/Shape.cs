using System;
using System.Windows.Forms;
using SharpMap;
using SharpMap.Layers;
using SharpMap.Data.Providers;
using System.Drawing;
using NetTopologySuite;

namespace Map_Extractor.lib
{
    internal class Shape
    {
        private PictureBox CanvasBox;
        private Map map;
        private VectorLayer layer;

        public Shape(PictureBox preview)
        {
            CanvasBox = preview;
        }

        //地図のレンダリング  
        private void Render()
        {
            if (map == null || CanvasBox == null)
            {
                return;
            }
            Bitmap bmp = (Bitmap)map.GetMap();
            CanvasBox.Image = bmp;
        }

        public void Load(string Path)
        {
            Size mapSize = CanvasBox.Size;

            map = new Map(mapSize)
            {
                BackColor = Color.White,
            };

            //レイヤーの作成
            layer = new VectorLayer("Layer")
            {
                DataSource = new ShapeFile(Path, true),
            };

            //オプション  
            layer.Style.Line = new Pen(Color.Red, 1);
            layer.Style.Fill = new SolidBrush(Color.FromArgb(128, Color.Red));

            map.Layers.Clear();
            map.Layers.Add(layer);
            map.ZoomToExtents();

            Render();
        }
    }
}
