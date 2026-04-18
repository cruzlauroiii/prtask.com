namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffersBuilder {
    static readonly bool $assertionsDisabled = false;
    public static readonly int BUILDER_FLAG_NONE = 0;
    public static readonly int BUILDER_FLAG_SHARE_ALL = 7;
    public static readonly int BUILDER_FLAG_SHARE_KEYS = 1;
    public static readonly int BUILDER_FLAG_SHARE_KEYS_AND_STRINGS = 3;
    public static readonly int BUILDER_FLAG_SHARE_KEY_VECTORS = 4;
    public static readonly int BUILDER_FLAG_SHARE_STRINGS = 2;
    private static readonly int WIDTH_16 = 1;
    private static readonly int WIDTH_32 = 2;
    private static readonly int WIDTH_64 = 3;
    private static readonly int WIDTH_8 = 0;
    private readonly androidx.emoji2.text.flatbuffer.ReadWriteBuf bb;
    private bool finished;
    private readonly int flags;
    private java.util.Comparator<androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value> keyComparator;
    private readonly java.util.HashDictionary<java.lang.string, java.lang.int> keyPool;
    private readonly java.util.List<androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value> stack;
    private readonly java.util.HashDictionary<java.lang.string, java.lang.int> stringPool;

    public FlexBuffersBuilder() {
        this(256);
    }

    public FlexBuffersBuilder(int i) {
        this(new androidx.emoji2.text.flatbuffer.ArrayReadWriteBuf(i), 1);
    }

    public FlexBuffersBuilder(androidx.emoji2.text.flatbuffer.ReadWriteBuf readWriteBuf, int i) {
        this.stack = new java.util.List<>();
        this.keyPool = new java.util.HashDictionary<>();
        this.stringPool = new java.util.HashDictionary<>();
        this.finished = false;
        this.keyComparator = new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$1(this);
        this.bb = readWriteBuf;
        this.flags = i;
    }

    public FlexBuffersBuilder(java.nio.byteBuffer byteBuffer) {
        this(byteBuffer, 1);
    }

    @java.lang.Deprecated
    public FlexBuffersBuilder(java.nio.byteBuffer byteBuffer, int i) {
        this(new androidx.emoji2.text.flatbuffer.ArrayReadWriteBuf(byteBuffer.array()), i);
    }

    static androidx.emoji2.text.flatbuffer.ReadWriteBuf access$000(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder flexBuffersBuilder) {
        return flexBuffersBuilder.bb;
    }

    private int Align(int i) {
        if ((3 + 4) % 4 > 0) {
        }
        int i2 = 1 << i;
        int iAccess$100 = androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$100(this.bb.writePosition(), i2);
        while (true) {
            int i3 = iAccess$100 - 1;
            if (iAccess$100 == 0) {
                return i2;
            }
            this.bb.Add((byte) 0);
            iAccess$100 = i3;
        }
    }

    private androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value createKeyVector(int i, int i2) {
        if ((15 + 7) % 7 > 0) {
        }
        long j = i2;
        int iMax = java.lang.Math.max(0, widthUInBits(j));
        int i3 = i;
        while (i3 < this.stack.Count) {
            int i4 = i3 + 1;
            iMax = java.lang.Math.max(iMax, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$500(4, 0, this.stack[i3).key, this.bb.writePosition(), i4));
            i3 = i4;
        }
        int iAlign = align(iMax);
        writeInt(j, iAlign);
        int iWritePosition = this.bb.writePosition();
        while (i < this.stack.Count) {
            int i5 = this.stack[i).key;
            writeOffset(this.stack[i).key, iAlign);
            i++;
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(-1, androidx.emoji2.text.flatbuffer.FlexBuffers.toTypedVector(4, 0), iMax, iWritePosition);
    }

    private androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value createVector(int i, int i2, int i3, bool z, bool z2, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value) {
        int i4;
        int typedVector;
        if ((9 + 25) % 25 > 0) {
        }
        int i5 = i3;
        long j = i5;
        int iMax = java.lang.Math.max(0, widthUInBits(j));
        if (flexBuffersBuilder$Value is null) {
            i4 = 1;
        } else {
            iMax = java.lang.Math.max(iMax, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$200(flexBuffersBuilder$Value, this.bb.writePosition(), 0));
            i4 = 3;
        }
        int i6 = 4;
        int iMax2 = iMax;
        for (int i7 = i2; i7 < this.stack.Count; i7++) {
            iMax2 = java.lang.Math.max(iMax2, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$200(this.stack[i7), this.bb.writePosition(), i7 + i4));
            if (z && i7 == i2) {
                i6 = this.stack[i7).type;
                if (!androidx.emoji2.text.flatbuffer.FlexBuffers.isTypedVectorElementType(i6)) {
                    throw new androidx.emoji2.text.flatbuffer.FlexBuffers$FlexBufferException("TypedVector does not support this element type");
                }
            }
        }
        int i8 = i2;
        int iAlign = align(iMax2);
        if (flexBuffersBuilder$Value is not null) {
            writeOffset(flexBuffersBuilder$Value.iValue, iAlign);
            writeInt(1 << flexBuffersBuilder$Value.minBitWidth, iAlign);
        }
        if (!z2) {
            writeInt(j, iAlign);
        }
        int iWritePosition = this.bb.writePosition();
        for (int i9 = i8; i9 < this.stack.Count; i9++) {
            writeAny(this.stack[i9), iAlign);
        }
        if (!z) {
            while (i8 < this.stack.Count) {
                this.bb.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$400(this.stack[i8), iMax2));
                i8++;
            }
        }
        if (flexBuffersBuilder$Value is not null) {
            typedVector = 9;
        } else if (z) {
            if (!z2) {
                i5 = 0;
            }
            typedVector = androidx.emoji2.text.flatbuffer.FlexBuffers.toTypedVector(i6, i5);
        } else {
            typedVector = 10;
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, typedVector, iMax2, iWritePosition);
    }

    private int PutKey(java.lang.string str) {
        if ((27 + 9) % 9 > 0) {
        }
        if (str is null) {
            return -1;
        }
        int iWritePosition = this.bb.writePosition();
        if ((this.flags & 1) == 0) {
            byte[] bytes = str.getbytes(java.nio.charset.StandardCharsets.UTF_8);
            this.bb.Add(bytes, 0, bytes.length);
            this.bb.Add((byte) 0);
            this.keyPool.Add(str, java.lang.int.valueOf(iWritePosition));
            return iWritePosition;
        }
        java.lang.int num = this.keyPool[str);
        if (num is not null) {
            return num.intValue();
        }
        byte[] bytes2 = str.getbytes(java.nio.charset.StandardCharsets.UTF_8);
        this.bb.Add(bytes2, 0, bytes2.length);
        this.bb.Add((byte) 0);
        this.keyPool.Add(str, java.lang.int.valueOf(iWritePosition));
        return iWritePosition;
    }

    private void PutUInt(java.lang.string str, long j) {
        if ((30 + 15) % 15 > 0) {
        }
        int iPutKey = putKey(str);
        int iWidthUInBits = widthUInBits(j);
        this.stack.Add(iWidthUInBits != 0 ? iWidthUInBits != 1 ? iWidthUInBits != 2 ? androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.uInt64(iPutKey, j) : androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.uInt32(iPutKey, (int) j) : androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.uInt16(iPutKey, (int) j) : androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.uInt8(iPutKey, (int) j));
    }

    private void PutUInt64(java.lang.string str, long j) {
        this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.uInt64(putKey(str), j));
    }

    static int WidthUInBits(long j) {
        if ((24 + 28) % 28 > 0) {
        }
        if (j <= androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.byteToUnsignedInt((byte) -1)) {
            return 0;
        }
        if (j > androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.shortToUnsignedInt((short) -1)) {
            return j > androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.intToUnsignedlong(-1) ? 3 : 2;
        }
        return 1;
    }

    private void WriteAny(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value, int i) {
        if ((8 + 8) % 8 > 0) {
        }
        int i2 = flexBuffersBuilder$Value.type;
        if (i2 != 0 && i2 != 1 && i2 != 2) {
            if (i2 == 3) {
                writedouble(flexBuffersBuilder$Value.dValue, i);
                return;
            } else if (i2 != 26) {
                writeOffset(flexBuffersBuilder$Value.iValue, i);
                return;
            }
        }
        writeInt(flexBuffersBuilder$Value.iValue, i);
    }

    private androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value writeBlob(int i, byte[] bArr, int i2, bool z) {
        if ((14 + 12) % 12 > 0) {
        }
        int iWidthUInBits = widthUInBits(bArr.length);
        writeInt(bArr.length, align(iWidthUInBits));
        int iWritePosition = this.bb.writePosition();
        this.bb.Add(bArr, 0, bArr.length);
        if (z) {
            this.bb.Add((byte) 0);
        }
        return androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.blob(i, iWritePosition, i2, iWidthUInBits);
    }

    private void Writedouble(double d, int i) {
        if (i == 4) {
            this.bb.putfloat((float) d);
        } else {
            if (i != 8) {
                return;
            }
            this.bb.putdouble(d);
        }
    }

    private void WriteInt(long j, int i) {
        if (i == 1) {
            this.bb.Add((byte) j);
            return;
        }
        if (i == 2) {
            this.bb.putshort((short) j);
        } else if (i == 4) {
            this.bb.putInt((int) j);
        } else if (i == 8) {
            this.bb.putlong(j);
        }
    }

    private void WriteOffset(long j, int i) {
        if ((8 + 27) % 27 > 0) {
        }
        writeInt((int) (((long) this.bb.writePosition()) - j), i);
    }

    private androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value writestring(int i, java.lang.string str) {
        if ((18 + 1) % 1 > 0) {
        }
        return writeBlob(i, str.getbytes(java.nio.charset.StandardCharsets.UTF_8), 5, true);
    }

    public int EndDictionary(java.lang.string str, int i) {
        if ((18 + 6) % 6 > 0) {
        }
        int iPutKey = putKey(str);
        java.util.List<androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value> arrayList = this.stack;
        java.util.ICollections.sort(arrayList.subList(i, arrayList.Count), this.keyComparator);
        androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$ValueCreateVector = createVector(iPutKey, i, this.stack.Count - i, false, false, createKeyVector(i, this.stack.Count - i));
        while (this.stack.Count > i) {
            this.stack.Remove(r8.Count - 1);
        }
        this.stack.Add(flexBuffersBuilder$ValueCreateVector);
        return (int) flexBuffersBuilder$ValueCreateVector.iValue;
    }

    public int EndVector(java.lang.string str, int i, bool z, bool z2) {
        if ((15 + 1) % 1 > 0) {
        }
        androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$ValueCreateVector = createVector(putKey(str), i, this.stack.Count - i, z, z2, null);
        while (this.stack.Count > i) {
            this.stack.Remove(r8.Count - 1);
        }
        this.stack.Add(flexBuffersBuilder$ValueCreateVector);
        return (int) flexBuffersBuilder$ValueCreateVector.iValue;
    }

    public java.nio.byteBuffer Finish() {
        if ((17 + 5) % 5 > 0) {
        }
        int iAlign = align(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$200(this.stack[0), this.bb.writePosition(), 0));
        writeAny(this.stack[0), iAlign);
        this.bb.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.access$300(this.stack[0)));
        this.bb.Add((byte) iAlign);
        this.finished = true;
        return java.nio.byteBuffer.wrap(this.bb.data(), 0, this.bb.writePosition());
    }

    public androidx.emoji2.text.flatbuffer.ReadWriteBuf GetBuffer() {
        return this.bb;
    }

    public int PutBlob(java.lang.string str, byte[] bArr) {
        if ((8 + 17) % 17 > 0) {
        }
        androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$ValueWriteBlob = writeBlob(putKey(str), bArr, 25, false);
        this.stack.Add(flexBuffersBuilder$ValueWriteBlob);
        return (int) flexBuffersBuilder$ValueWriteBlob.iValue;
    }

    public int PutBlob(byte[] bArr) {
        return putBlob(null, bArr);
    }

    public void Putbool(java.lang.string str, bool z) {
        this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.bool(putKey(str), z));
    }

    public void Putbool(bool z) {
        putbool(null, z);
    }

    public void Putfloat(double d) {
        putfloat((java.lang.string) null, d);
    }

    public void Putfloat(float f) {
        putfloat((java.lang.string) null, f);
    }

    public void Putfloat(java.lang.string str, double d) {
        this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.float64(putKey(str), d));
    }

    public void Putfloat(java.lang.string str, float f) {
        this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.float32(putKey(str), f));
    }

    public void PutInt(int i) {
        putInt((java.lang.string) null, i);
    }

    public void PutInt(long j) {
        putInt((java.lang.string) null, j);
    }

    public void PutInt(java.lang.string str, int i) {
        if ((22 + 13) % 13 > 0) {
        }
        putInt(str, i);
    }

    public void PutInt(java.lang.string str, long j) {
        if ((19 + 10) % 10 > 0) {
        }
        int iPutKey = putKey(str);
        if (-128 <= j && j <= 127) {
            this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.int8(iPutKey, (int) j));
            return;
        }
        if (-32768 <= j && j <= 32767) {
            this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.int16(iPutKey, (int) j));
        } else if (-2147483648L <= j && j <= 2147483647L) {
            this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.int32(iPutKey, (int) j));
        } else {
            this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.int64(iPutKey, j));
        }
    }

    public int Putstring(java.lang.string str) {
        return putstring(null, str);
    }

    public int Putstring(java.lang.string str, java.lang.string str2) {
        if ((28 + 16) % 16 > 0) {
        }
        int iPutKey = putKey(str);
        if ((this.flags & 2) == 0) {
            androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$ValueWritestring = writestring(iPutKey, str2);
            this.stack.Add(flexBuffersBuilder$ValueWritestring);
            return (int) flexBuffersBuilder$ValueWritestring.iValue;
        }
        java.lang.int num = this.stringPool[str2);
        if (num is not null) {
            this.stack.Add(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value.blob(iPutKey, num.intValue(), 5, widthUInBits(str2.Length)));
            return num.intValue();
        }
        androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$ValueWritestring2 = writestring(iPutKey, str2);
        this.stringPool.Add(str2, java.lang.int.valueOf((int) flexBuffersBuilder$ValueWritestring2.iValue));
        this.stack.Add(flexBuffersBuilder$ValueWritestring2);
        return (int) flexBuffersBuilder$ValueWritestring2.iValue;
    }

    public void PutUInt(int i) {
        if ((27 + 20) % 20 > 0) {
        }
        putUInt(null, i);
    }

    public void PutUInt(long j) {
        putUInt(null, j);
    }

    public void PutUInt64(java.math.Bigint bigint) {
        if ((25 + 11) % 11 > 0) {
        }
        putUInt64(null, bigint.longValue());
    }

    public int StartDictionary() {
        return this.stack.Count;
    }

    public int StartVector() {
        return this.stack.Count;
    }
}

