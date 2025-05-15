using System;
using System.Windows.Forms;
using SharpMap;
using SharpMap.Layers;
using SharpMap.Data.Providers;
using System.Drawing;
using Map_Extractor.lib;

namespace Map_Extractor
{
    public partial class Source : Form
    {
        private Shape shape;

        public Source()
        {
            InitializeComponent();
            shape = new Shape(CanvasBox);
        }

        private void LoadShapeButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "地図データ(*.shp) | *.shp; | すべてのファイル(*.) | *.*;" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.PathLabel.Text = ofd.FileName;
                    shape.Load(ofd.FileName);
                }
            }
        }
    }
}
