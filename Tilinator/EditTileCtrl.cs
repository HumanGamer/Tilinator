using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tilinator
{
    public partial class EditTileCtrl : UserControl
    {
        private Tp1File _selectedTp1File;

        public Tp1File SelectedTp1File
        {
            get
            {
                return _selectedTp1File;
            }
            set
            {
                _selectedTp1File = value;
                OnWopChanged();
            }
        }

        public EditTileCtrl()
        {
            InitializeComponent();
        }

        protected void OnWopChanged()
        {
            if (SelectedTp1File == null)
                return;

            nudTileTexture.Value = SelectedTp1File.TileTexture;
            nudTileRotation.Value = SelectedTp1File.TileRotation;
            nudTileSideTexture.Value = SelectedTp1File.TileSideTexture;
            nudTileSideRotation.Value = SelectedTp1File.TileSideRotation;
            nudTileRandom.Value = (decimal) SelectedTp1File.TileRandom;
            nudTileHeight.Value = (decimal) SelectedTp1File.TileHeight;
            nudTileExtrusion.Value = (decimal) SelectedTp1File.TileExtrusion;
            nudTileRounding.Value = SelectedTp1File.TileRounding;
            nudTileEdgeRandom.Value = (decimal) SelectedTp1File.TileEdgeRandom;
            nudTileLogic.Value = SelectedTp1File.TileLogic;
            nudWaterTileTexture.Value = SelectedTp1File.WaterTileTexture;
            nudWaterTileRotation.Value = SelectedTp1File.WaterTileRotation;
            nudWaterTileHeight.Value = (decimal) SelectedTp1File.WaterTileHeight;
            nudWaterTileTurbulence.Value = (decimal) SelectedTp1File.WaterTileTurbulence;
        }

        public Tp1File GetFinalWopFile()
        {
            Tp1File result = new Tp1File();

            result.TileTexture = (int) nudTileTexture.Value;
            result.TileRotation = (int) nudTileRotation.Value;
            result.TileSideTexture = (int) nudTileSideTexture.Value;
            result.TileSideRotation = (int) nudTileSideRotation.Value;
            result.TileRandom = (float) nudTileRandom.Value;
            result.TileHeight = (float) nudTileHeight.Value;
            result.TileExtrusion = (float) nudTileExtrusion.Value;
            result.TileRounding = (int) nudTileRounding.Value;
            result.TileEdgeRandom = (float) nudTileEdgeRandom.Value;
            result.TileLogic = (int) nudTileLogic.Value;
            result.WaterTileTexture = (int) nudWaterTileTexture.Value;
            result.WaterTileRotation = (int) nudWaterTileRotation.Value;
            result.WaterTileHeight = (float) nudWaterTileHeight.Value;
            result.WaterTileTurbulence = (float) nudWaterTileTurbulence.Value;

            return result;
        }

        private void nudTileTexture_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileTexture.Value != SelectedTp1File.TileTexture)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileRotation_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileRotation.Value != SelectedTp1File.TileRotation)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileSideTexture_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileSideTexture.Value != SelectedTp1File.TileSideTexture)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileSideRotation_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileSideRotation.Value != SelectedTp1File.TileSideRotation)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileRandom_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudTileRandom.Value - SelectedTp1File.TileRandom) > 0.01f)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileHeight_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudTileHeight.Value - SelectedTp1File.TileHeight) > 0.01f)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileExtrusion_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudTileExtrusion.Value - SelectedTp1File.TileExtrusion) > 0.01f)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileRounding_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileRounding.Value != SelectedTp1File.TileRounding)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileEdgeRandom_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudTileEdgeRandom.Value - SelectedTp1File.TileEdgeRandom) > 0.01f)
                SelectedTp1File.Dirty = true;
        }

        private void nudTileLogic_ValueChanged(object sender, EventArgs e)
        {
            if (nudTileLogic.Value != SelectedTp1File.TileLogic)
                SelectedTp1File.Dirty = true;
        }

        private void nudWaterTileTexture_ValueChanged(object sender, EventArgs e)
        {
            if (nudWaterTileTexture.Value != SelectedTp1File.WaterTileTexture)
                SelectedTp1File.Dirty = true;
        }

        private void nudWaterTileRotation_ValueChanged(object sender, EventArgs e)
        {
            if (nudWaterTileRotation.Value != SelectedTp1File.WaterTileRotation)
                SelectedTp1File.Dirty = true;
        }

        private void nudWaterTileHeight_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudWaterTileHeight.Value - SelectedTp1File.WaterTileHeight) > 0.01f)
                SelectedTp1File.Dirty = true;
        }

        private void nudWaterTileTurbulence_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)nudWaterTileTurbulence.Value - SelectedTp1File.WaterTileTurbulence) > 0.01f)
                SelectedTp1File.Dirty = true;
        }
    }
}
