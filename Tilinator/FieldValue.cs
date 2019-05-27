using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilinator
{
    public enum TypeEnum
    {
        INVALID,
        BYTE,
        SBYTE,
        SHORT,
        USHORT,
        INT,
        UINT,
        FLOAT,
        DOUBLE,
        LONG,
        ULONG,
        STRING
    }

    public class FieldValue
    {
        public byte BYTE;
        public sbyte SBYTE;
        public short SHORT;
        public ushort USHORT;
        public int INT;
        public uint UINT;
        public float FLOAT;
        public double DOUBLE;
        public long LONG;
        public ulong ULONG;
        public string STRING;
        public TypeEnum type;

        public string STRING_VALUE
        {
            get
            {
                switch (type)
                {
                    case TypeEnum.BYTE:
                        return BYTE.ToString();
                    case TypeEnum.SBYTE:
                        return SBYTE.ToString();
                    case TypeEnum.SHORT:
                        return SHORT.ToString();
                    case TypeEnum.USHORT:
                        return USHORT.ToString();
                    case TypeEnum.INT:
                        return INT.ToString();
                    case TypeEnum.UINT:
                        return UINT.ToString();
                    case TypeEnum.FLOAT:
                        return FLOAT.ToString(CultureInfo.InvariantCulture);
                    case TypeEnum.DOUBLE:
                        return DOUBLE.ToString(CultureInfo.InvariantCulture);
                    case TypeEnum.LONG:
                        return LONG.ToString();
                    case TypeEnum.ULONG:
                        return ULONG.ToString();
                    case TypeEnum.STRING:
                        return STRING;
                    default:
                        return null;
                }
            }
        }

        public FieldValue()
        {
            type = TypeEnum.INVALID;
            BYTE = default(byte);
            SBYTE = default(sbyte);
            SHORT = default(short);
            USHORT = default(ushort);
            INT = default(int);
            UINT = default(uint);
            FLOAT = default(float);
            DOUBLE = default(double);
            LONG = default(long);
            ULONG = default(ulong);
            STRING = default(string);
        }

        public FieldValue(byte b) : this()
        {
            type = TypeEnum.BYTE;
            BYTE = b;
        }

        public FieldValue(sbyte b) : this()
        {
            type = TypeEnum.SBYTE;
            SBYTE = b;
        }

        public FieldValue(short s) : this()
        {
            type = TypeEnum.SHORT;
            SHORT = s;
        }

        public FieldValue(ushort s) : this()
        {
            type = TypeEnum.USHORT;
            USHORT = s;
        }

        public FieldValue(int i) : this()
        {
            type = TypeEnum.INT;
            INT = i;
        }

        public FieldValue(uint i) : this()
        {
            type = TypeEnum.UINT;
            UINT = i;
        }

        public FieldValue(float f) : this()
        {
            type = TypeEnum.FLOAT;
            FLOAT = f;
        }

        public FieldValue(double d) : this()
        {
            type = TypeEnum.DOUBLE;
            DOUBLE = d;
        }

        public FieldValue(long l) : this()
        {
            type = TypeEnum.LONG;
            LONG = l;
        }

        public FieldValue(ulong l) : this()
        {
            type = TypeEnum.ULONG;
            ULONG = l;
        }

        public FieldValue(string s) : this()
        {
            type = TypeEnum.STRING;
            STRING = s;
        }
    }
}
