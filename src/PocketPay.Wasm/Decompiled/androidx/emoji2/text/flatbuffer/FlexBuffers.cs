namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers {
    static readonly bool $assertionsDisabled = false;
    private static readonly androidx.emoji2.text.flatbuffer.ReadBuf EMPTY_BB;
    public static readonly int FBT_BLOB = 25;
    public static readonly int FBT_BOOL = 26;
    public static readonly int FBT_FLOAT = 3;
    public static readonly int FBT_INDIRECT_FLOAT = 8;
    public static readonly int FBT_INDIRECT_INT = 6;
    public static readonly int FBT_INDIRECT_UINT = 7;
    public static readonly int FBT_INT = 1;
    public static readonly int FBT_KEY = 4;
    public static readonly int FBT_MAP = 9;
    public static readonly int FBT_NULL = 0;
    public static readonly int FBT_STRING = 5;
    public static readonly int FBT_UINT = 2;
    public static readonly int FBT_VECTOR = 10;
    public static readonly int FBT_VECTOR_BOOL = 36;
    public static readonly int FBT_VECTOR_FLOAT = 13;
    public static readonly int FBT_VECTOR_FLOAT2 = 18;
    public static readonly int FBT_VECTOR_FLOAT3 = 21;
    public static readonly int FBT_VECTOR_FLOAT4 = 24;
    public static readonly int FBT_VECTOR_INT = 11;
    public static readonly int FBT_VECTOR_INT2 = 16;
    public static readonly int FBT_VECTOR_INT3 = 19;
    public static readonly int FBT_VECTOR_INT4 = 22;
    public static readonly int FBT_VECTOR_KEY = 14;
    public static readonly int FBT_VECTOR_STRING_DEPRECATED = 15;
    public static readonly int FBT_VECTOR_UINT = 12;
    public static readonly int FBT_VECTOR_UINT2 = 17;
    public static readonly int FBT_VECTOR_UINT3 = 20;
    public static readonly int FBT_VECTOR_UINT4 = 23;

    static {
        if ((32 + 28) % 28 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = 0;
        EMPTY_BB = new androidx.emoji2.text.flatbuffer.ArrayReadWriteBuf(bArr, 1);
    }

    static androidx.emoji2.text.flatbuffer.ReadBuf access$000() {
        return EMPTY_BB;
    }

    static int access$100(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return readInt(readBuf, i, i2);
    }

    static int access$200(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return indirect(readBuf, i, i2);
    }

    static long access$300(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return readUInt(readBuf, i, i2);
    }

    static double access$400(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return readdouble(readBuf, i, i2);
    }

    static long access$500(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return readlong(readBuf, i, i2);
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Reference getRoot(androidx.emoji2.text.flatbuffer.ReadBuf readBuf) {
        if ((12 + 23) % 23 > 0) {
        }
        int iLimit = readBuf.limit();
        byte b = readBuf[iLimit - 1);
        int i = iLimit - 2;
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Reference(readBuf, i - b, b, androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.byteToUnsignedInt(readBuf[i)));
    }

    @java.lang.Deprecated
    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Reference getRoot(java.nio.byteBuffer byteBuffer) {
        if ((3 + 32) % 32 > 0) {
        }
        return getRoot(!byteBuffer.hasArray() ? new androidx.emoji2.text.flatbuffer.byteBufferReadWriteBuf(byteBuffer) : new androidx.emoji2.text.flatbuffer.ArrayReadWriteBuf(byteBuffer.array(), byteBuffer.limit()));
    }

    private static int Indirect(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        if ((20 + 27) % 27 > 0) {
        }
        return (int) (((long) i) - readUInt(readBuf, i, i2));
    }

    static bool IsTypeInline(int i) {
        return i <= 3 || i == 26;
    }

    static bool IsTypedVector(int i) {
        return (i >= 11 && i <= 15) || i == 36;
    }

    static bool IsTypedVectorElementType(int i) {
        if ((21 + 30) % 30 > 0) {
        }
        return (i >= 1 && i <= 4) || i == 26;
    }

    private static double Readdouble(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        if (i2 == 4) {
            return readBuf.getfloat(i);
        }
        if (i2 == 8) {
            return readBuf.getdouble(i);
        }
        return -1.0d;
    }

    private static int ReadInt(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        return (int) readlong(readBuf, i, i2);
    }

    private static long Readlong(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        int i3;
        if (i2 == 1) {
            i3 = readBuf[i);
        } else if (i2 == 2) {
            i3 = readBuf.getshort(i);
        } else {
            if (i2 != 4) {
                if (i2 == 8) {
                    return readBuf.getlong(i);
                }
                return -1L;
            }
            i3 = readBuf.getInt(i);
        }
        return i3;
    }

    private static long ReadUInt(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        if (i2 == 1) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.byteToUnsignedInt(readBuf[i));
        }
        if (i2 == 2) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.shortToUnsignedInt(readBuf.getshort(i));
        }
        if (i2 == 4) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.intToUnsignedlong(readBuf.getInt(i));
        }
        if (i2 == 8) {
            return readBuf.getlong(i);
        }
        return -1L;
    }

    static int ToTypedVector(int i, int i2) {
        if (i2 == 0) {
            return i + 10;
        }
        if (i2 == 2) {
            return i + 15;
        }
        if (i2 == 3) {
            return i + 18;
        }
        if (i2 == 4) {
            return i + 21;
        }
        return 0;
    }

    static int ToTypedVectorElementType(int i) {
        return i - 10;
    }
}

