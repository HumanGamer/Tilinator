using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilinator
{
    public class Tp1File
    {
        public delegate void DirtyChanged(bool dirty);

        public event DirtyChanged OnDirtyChanged;

        private bool _dirty;

        /// <summary>
        /// Has this file been modified?
        /// </summary>
        public bool Dirty
        {
            get { return _dirty; }
            set
            {
                _dirty = value;
                if (OnDirtyChanged != null)
                    OnDirtyChanged(_dirty);
            }
        }

        public int TileTexture
        {
            get;
            set;
        }

        public int TileRotation
        {
            get;
            set;
        }

        public int TileSideTexture
        {
            get;
            set;
        }

        public int TileSideRotation
        {
            get;
            set;
        }

        public float TileRandom
        {
            get;
            set;
        }

        public float TileHeight
        {
            get;
            set;
        }

        public float TileExtrusion
        {
            get;
            set;
        }

        public int TileRounding
        {
            get;
            set;
        }

        public float TileEdgeRandom
        {
            get;
            set;
        }

        public int TileLogic
        {
            get;
            set;
        }

        public int WaterTileTexture
        {
            get;
            set;
        }

        public int WaterTileRotation
        {
            get;
            set;
        }

        public float WaterTileHeight
        {
            get;
            set;
        }

        public float WaterTileTurbulence
        {
            get;
            set;
        }

        public Tp1File()
        {
            TileTexture = 0;
            TileRotation = 0;
            TileSideTexture = 0;
            TileSideRotation = 0;
            TileRandom = 0;
            TileHeight = 0;
            TileExtrusion = 0;
            TileRounding = 0;
            TileEdgeRandom = 0;
            TileLogic = 0;
            WaterTileTexture = 0;
            WaterTileRotation = 0;
            WaterTileHeight = 0;
            WaterTileTurbulence = 0;
        }

        public static Tp1File Read(string path)
        {
            Tp1File result = new Tp1File();

            Stream s = File.Open(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(s);

            result.TileTexture = br.ReadInt32();
            result.TileRotation = br.ReadInt32();
            result.TileSideTexture = br.ReadInt32();
            result.TileSideRotation = br.ReadInt32();
            result.TileRandom = br.ReadSingle();
            result.TileHeight = br.ReadSingle();
            result.TileExtrusion = br.ReadSingle();
            result.TileRounding = br.ReadInt32();
            result.TileEdgeRandom = br.ReadSingle();
            result.TileLogic = br.ReadInt32();
            result.WaterTileTexture = br.ReadInt32();
            result.WaterTileRotation = br.ReadInt32();
            result.WaterTileHeight = br.ReadSingle();
            result.WaterTileTurbulence = br.ReadSingle();

            br.Close();

            return result;
        }

        public void Save(string path)
        {
            Stream s = File.Open(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(s);
            
            bw.Write(TileTexture);
            bw.Write(TileRotation);
            bw.Write(TileSideTexture);
            bw.Write(TileSideRotation);
            bw.Write(TileRandom);
            bw.Write(TileHeight);
            bw.Write(TileExtrusion);
            bw.Write(TileRounding);
            bw.Write(TileEdgeRandom);
            bw.Write(TileLogic);
            bw.Write(WaterTileTexture);
            bw.Write(WaterTileRotation);
            bw.Write(WaterTileHeight);
            bw.Write(WaterTileTurbulence);

            bw.Flush();
            bw.Close();
        }
    }
}
