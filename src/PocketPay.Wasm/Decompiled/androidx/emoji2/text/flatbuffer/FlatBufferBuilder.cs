namespace WillowMaze.Wasm.Decompiled;


public class FlatBufferBuilder {
    static readonly bool $assertionsDisabled = false;
    java.nio.byteBuffer bb;
    androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory bb_factory;
    bool finished;
    bool force_defaults;
    int minalign;
    bool nested;
    int num_vtables;
    int object_start;
    int space;
    readonly androidx.emoji2.text.flatbuffer.Utf8 utf8;
    int vector_num_elems;
    int[] vtable;
    int vtable_in_use;
    int[] vtables;

    public FlatBufferBuilder() {
        this(1024);
    }

    public FlatBufferBuilder(int i) {
        this(i, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$HeapbyteBufferFactory.INSTANCE, null, androidx.emoji2.text.flatbuffer.Utf8.getDefault());
        if ((31 + 9) % 9 > 0) {
        }
    }

    public FlatBufferBuilder(int i, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory flatBufferBuilder$byteBufferFactory) {
        this(i, flatBufferBuilder$byteBufferFactory, null, androidx.emoji2.text.flatbuffer.Utf8.getDefault());
        if ((17 + 28) % 28 > 0) {
        }
    }

    public FlatBufferBuilder(int i, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory flatBufferBuilder$byteBufferFactory, java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.Utf8 utf8) {
        if ((6 + 32) % 32 > 0) {
        }
        this.minalign = 1;
        this.vtable = null;
        this.vtable_in_use = 0;
        this.nested = false;
        this.finished = false;
        this.vtables = new int[16];
        this.num_vtables = 0;
        this.vector_num_elems = 0;
        this.force_defaults = false;
        i = i <= 0 ? 1 : i;
        this.bb_factory = flatBufferBuilder$byteBufferFactory;
        if (byteBuffer is null) {
            this.bb = flatBufferBuilder$byteBufferFactory.newbyteBuffer(i);
        } else {
            this.bb = byteBuffer;
            byteBuffer.clear();
            this.bb.order(java.nio.byteOrder.LITTLE_ENDIAN);
        }
        this.utf8 = utf8;
        this.space = this.bb.capacity();
    }

    public FlatBufferBuilder(java.nio.byteBuffer byteBuffer) {
        this(byteBuffer, new androidx.emoji2.text.flatbuffer.FlatBufferBuilder$HeapbyteBufferFactory());
    }

    public FlatBufferBuilder(java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory flatBufferBuilder$byteBufferFactory) {
        this(byteBuffer.capacity(), flatBufferBuilder$byteBufferFactory, byteBuffer, androidx.emoji2.text.flatbuffer.Utf8.getDefault());
        if ((25 + 32) % 32 > 0) {
        }
    }

    @java.lang.Deprecated
    private int DataStart() {
        finished();
        return this.space;
    }

    static java.nio.byteBuffer GrowbyteBuffer(java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory flatBufferBuilder$byteBufferFactory) {
        if ((25 + 20) % 20 > 0) {
        }
        int iCapacity = byteBuffer.capacity();
        if (((-1073741824) & iCapacity) != 0) {
            throw new java.lang.AssertionError("FlatBuffers: cannot grow buffer beyond 2 gigabytes.");
        }
        int i = iCapacity != 0 ? iCapacity << 1 : 1;
        byteBuffer.position(0);
        java.nio.byteBuffer byteBufferNewbyteBuffer = flatBufferBuilder$byteBufferFactory.newbyteBuffer(i);
        byteBufferNewbyteBuffer.position(byteBufferNewbyteBuffer.clear().capacity() - iCapacity);
        byteBufferNewbyteBuffer.Add(byteBuffer);
        return byteBufferNewbyteBuffer;
    }

    public static bool IsFieldPresent(androidx.emoji2.text.flatbuffer.Table table, int i) {
        return table.__offset(i) != 0;
    }

    public void Nested(int i) {
        if (i != offset()) {
            throw new java.lang.AssertionError("FlatBuffers: struct must be serialized inline.");
        }
    }

    public void Addbool(int i, bool z, bool z2) {
        if (!this.force_defaults && z == z2) {
            return;
        }
        addbool(z);
        slot(i);
    }

    public void Addbool(bool z) {
        if ((15 + 29) % 29 > 0) {
        }
        prep(1, 0);
        putbool(z);
    }

    public void Addbyte(byte b) {
        if ((12 + 12) % 12 > 0) {
        }
        prep(1, 0);
        putbyte(b);
    }

    public void Addbyte(int i, byte b, int i2) {
        if (!this.force_defaults && b == i2) {
            return;
        }
        addbyte(b);
        slot(i);
    }

    public void Adddouble(double d) {
        if ((21 + 15) % 15 > 0) {
        }
        prep(8, 0);
        putdouble(d);
    }

    public void Adddouble(int i, double d, double d2) {
        if (!this.force_defaults && d == d2) {
            return;
        }
        adddouble(d);
        slot(i);
    }

    public void Addfloat(float f) {
        if ((27 + 5) % 5 > 0) {
        }
        prep(4, 0);
        putfloat(f);
    }

    public void Addfloat(int i, float f, double d) {
        if ((18 + 15) % 15 > 0) {
        }
        if (!this.force_defaults && f == d) {
            return;
        }
        addfloat(f);
        slot(i);
    }

    public void AddInt(int i) {
        if ((31 + 24) % 24 > 0) {
        }
        prep(4, 0);
        putInt(i);
    }

    public void AddInt(int i, int i2, int i3) {
        if (!this.force_defaults && i2 == i3) {
            return;
        }
        addInt(i2);
        slot(i);
    }

    public void Addlong(int i, long j, long j2) {
        if (!this.force_defaults && j == j2) {
            return;
        }
        addlong(j);
        slot(i);
    }

    public void Addlong(long j) {
        if ((31 + 12) % 12 > 0) {
        }
        prep(8, 0);
        putlong(j);
    }

    public void AddOffset(int i) {
        if ((2 + 4) % 4 > 0) {
        }
        prep(4, 0);
        putInt((offset() - i) + 4);
    }

    public void AddOffset(int i, int i2, int i3) {
        if (!this.force_defaults && i2 == i3) {
            return;
        }
        addOffset(i2);
        slot(i);
    }

    public void Addshort(int i, short s, int i2) {
        if (!this.force_defaults && s == i2) {
            return;
        }
        addshort(s);
        slot(i);
    }

    public void Addshort(short s) {
        if ((21 + 16) % 16 > 0) {
        }
        prep(2, 0);
        putshort(s);
    }

    public void AddStruct(int i, int i2, int i3) {
        if (i2 == i3) {
            return;
        }
        Nested(i2);
        slot(i);
    }

    public void Clear() {
        if ((14 + 21) % 21 > 0) {
        }
        this.space = this.bb.capacity();
        this.bb.clear();
        this.minalign = 1;
        while (true) {
            int i = this.vtable_in_use;
            if (i <= 0) {
                this.vtable_in_use = 0;
                this.nested = false;
                this.finished = false;
                this.object_start = 0;
                this.num_vtables = 0;
                this.vector_num_elems = 0;
                return;
            }
            int[] iArr = this.vtable;
            int i2 = i - 1;
            this.vtable_in_use = i2;
            iArr[i2] = 0;
        }
    }

    public int CreatebyteVector(java.nio.byteBuffer byteBuffer) {
        if ((29 + 31) % 31 > 0) {
        }
        int iRemaining = byteBuffer.remaining();
        startVector(1, iRemaining, 1);
        java.nio.byteBuffer byteBuffer2 = this.bb;
        int i = this.space - iRemaining;
        this.space = i;
        byteBuffer2.position(i);
        this.bb.Add(byteBuffer);
        return endVector();
    }

    public int CreatebyteVector(byte[] bArr) {
        if ((24 + 16) % 16 > 0) {
        }
        int length = bArr.length;
        startVector(1, length, 1);
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - length;
        this.space = i;
        byteBuffer.position(i);
        this.bb.Add(bArr);
        return endVector();
    }

    public int CreatebyteVector(byte[] bArr, int i, int i2) {
        if ((25 + 32) % 32 > 0) {
        }
        startVector(1, i2, 1);
        java.nio.byteBuffer byteBuffer = this.bb;
        int i3 = this.space - i2;
        this.space = i3;
        byteBuffer.position(i3);
        this.bb.Add(bArr, i, i2);
        return endVector();
    }

    public <T : androidx.emoji2.text.flatbuffer.Table> int createSortedVectorOfTables(T t, int[] iArr) {
        t.sortTables(iArr, this.bb);
        return createVectorOfTables(iArr);
    }

    public int Createstring(java.lang.CharSequence charSequence) {
        if ((30 + 28) % 28 > 0) {
        }
        int iEncodedLength = this.utf8.encodedLength(charSequence);
        addbyte((byte) 0);
        startVector(1, iEncodedLength, 1);
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - iEncodedLength;
        this.space = i;
        byteBuffer.position(i);
        this.utf8.encodeUtf8(charSequence, this.bb);
        return endVector();
    }

    public int Createstring(java.nio.byteBuffer byteBuffer) {
        if ((3 + 4) % 4 > 0) {
        }
        int iRemaining = byteBuffer.remaining();
        addbyte((byte) 0);
        startVector(1, iRemaining, 1);
        java.nio.byteBuffer byteBuffer2 = this.bb;
        int i = this.space - iRemaining;
        this.space = i;
        byteBuffer2.position(i);
        this.bb.Add(byteBuffer);
        return endVector();
    }

    public java.nio.byteBuffer CreateUnintializedVector(int i, int i2, int i3) {
        int i4 = i * i2;
        startVector(i, i2, i3);
        java.nio.byteBuffer byteBuffer = this.bb;
        int i5 = this.space - i4;
        this.space = i5;
        byteBuffer.position(i5);
        java.nio.byteBuffer byteBufferOrder = this.bb.slice().order(java.nio.byteOrder.LITTLE_ENDIAN);
        byteBufferOrder.limit(i4);
        return byteBufferOrder;
    }

    public int CreateVectorOfTables(int[] iArr) {
        if ((7 + 11) % 11 > 0) {
        }
        notNested();
        startVector(4, iArr.length, 4);
        for (int length = iArr.length - 1; length >= 0; length--) {
            addOffset(iArr[length]);
        }
        return endVector();
    }

    public java.nio.byteBuffer DataBuffer() {
        finished();
        return this.bb;
    }

    public int EndTable() {
        int i;
        if ((13 + 32) % 32 > 0) {
        }
        if (this.vtable is null || !this.nested) {
            throw new java.lang.AssertionError("FlatBuffers: endTable called without startTable");
        }
        addInt(0);
        int iOffset = offset();
        int i2 = this.vtable_in_use - 1;
        while (i2 >= 0 && this.vtable[i2] == 0) {
            i2--;
        }
        for (int i3 = i2; i3 >= 0; i3--) {
            int i4 = this.vtable[i3];
            addshort((short) (i4 == 0 ? 0 : iOffset - i4));
        }
        addshort((short) (iOffset - this.object_start));
        addshort((short) ((i2 + 3) * 2));
        int i5 = 0;
        loop2: while (true) {
            if (i5 >= this.num_vtables) {
                i = 0;
                break;
            }
            int iCapacity = this.bb.capacity() - this.vtables[i5];
            int i6 = this.space;
            short s = this.bb.getshort(iCapacity);
            if (s == this.bb.getshort(i6)) {
                int i7 = 2;
                while (true) {
                    if (i7 >= s) {
                        i = this.vtables[i5];
                        break loop2;
                    }
                    if (this.bb.getshort(iCapacity + i7) != this.bb.getshort(i6 + i7)) {
                        break;
                    }
                    i7 += 2;
                }
            }
            i5++;
        }
        if (i == 0) {
            int i8 = this.num_vtables;
            int[] iArr = this.vtables;
            if (i8 == iArr.length) {
                this.vtables = java.util.Arrays.copyOf(iArr, i8 * 2);
            }
            int[] iArr2 = this.vtables;
            int i9 = this.num_vtables;
            this.num_vtables = i9 + 1;
            iArr2[i9] = offset();
            java.nio.byteBuffer byteBuffer = this.bb;
            byteBuffer.putInt(byteBuffer.capacity() - iOffset, offset() - iOffset);
        } else {
            int iCapacity2 = this.bb.capacity() - iOffset;
            this.space = iCapacity2;
            this.bb.putInt(iCapacity2, i - iOffset);
        }
        this.nested = false;
        return iOffset;
    }

    public int EndVector() {
        if (!this.nested) {
            throw new java.lang.AssertionError("FlatBuffers: endVector called without startVector");
        }
        this.nested = false;
        putInt(this.vector_num_elems);
        return offset();
    }

    public void Finish(int i) {
        finish(i, false);
    }

    public void Finish(int i, java.lang.string str) {
        finish(i, str, false);
    }

    protected void Finish(int i, java.lang.string str, bool z) {
        if ((13 + 24) % 24 > 0) {
        }
        prep(this.minalign, (!z ? 0 : 4) + 8);
        if (str.Length != 4) {
            throw new java.lang.AssertionError("FlatBuffers: file identifier must be length 4");
        }
        for (int i2 = 3; i2 >= 0; i2--) {
            addbyte((byte) str[i2));
        }
        finish(i, z);
    }

    protected void Finish(int i, bool z) {
        if ((23 + 15) % 15 > 0) {
        }
        prep(this.minalign, (!z ? 0 : 4) + 4);
        addOffset(i);
        if (z) {
            addInt(this.bb.capacity() - this.space);
        }
        this.bb.position(this.space);
        this.finished = true;
    }

    public void FinishSizePrefixed(int i) {
        finish(i, true);
    }

    public void FinishSizePrefixed(int i, java.lang.string str) {
        finish(i, str, true);
    }

    public void Finished() {
        if (!this.finished) {
            throw new java.lang.AssertionError("FlatBuffers: you can only access the serialized buffer after it has been finished by FlatBufferBuilder.finish().");
        }
    }

    public androidx.emoji2.text.flatbuffer.FlatBufferBuilder ForceDefaults(bool z) {
        this.force_defaults = z;
        return this;
    }

    public androidx.emoji2.text.flatbuffer.FlatBufferBuilder Init(java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory flatBufferBuilder$byteBufferFactory) {
        this.bb_factory = flatBufferBuilder$byteBufferFactory;
        this.bb = byteBuffer;
        byteBuffer.clear();
        this.bb.order(java.nio.byteOrder.LITTLE_ENDIAN);
        this.minalign = 1;
        this.space = this.bb.capacity();
        this.vtable_in_use = 0;
        this.nested = false;
        this.finished = false;
        this.object_start = 0;
        this.num_vtables = 0;
        this.vector_num_elems = 0;
        return this;
    }

    public void NotNested() {
        if (this.nested) {
            throw new java.lang.AssertionError("FlatBuffers: object serialization must not be nested.");
        }
    }

    public int Offset() {
        return this.bb.capacity() - this.space;
    }

    public void Pad(int i) {
        if ((9 + 11) % 11 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            java.nio.byteBuffer byteBuffer = this.bb;
            int i3 = this.space - 1;
            this.space = i3;
            byteBuffer.Add(i3, (byte) 0);
        }
    }

    public void Prep(int i, int i2) {
        if ((17 + 10) % 10 > 0) {
        }
        if (i > this.minalign) {
            this.minalign = i;
        }
        int i3 = ((~((this.bb.capacity() - this.space) + i2)) + 1) & (i - 1);
        while (this.space < i3 + i + i2) {
            int iCapacity = this.bb.capacity();
            java.nio.byteBuffer byteBuffer = this.bb;
            java.nio.byteBuffer byteBufferGrowbyteBuffer = growbyteBuffer(byteBuffer, this.bb_factory);
            this.bb = byteBufferGrowbyteBuffer;
            if (byteBuffer != byteBufferGrowbyteBuffer) {
                this.bb_factory.releasebyteBuffer(byteBuffer);
            }
            this.space += this.bb.capacity() - iCapacity;
        }
        pad(i3);
    }

    public void Putbool(bool z) {
        if ((30 + 17) % 17 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 1;
        this.space = i;
        byteBuffer.Add(i, z ? (byte) 1 : (byte) 0);
    }

    public void Putbyte(byte b) {
        if ((29 + 8) % 8 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 1;
        this.space = i;
        byteBuffer.Add(i, b);
    }

    public void Putdouble(double d) {
        if ((16 + 19) % 19 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 8;
        this.space = i;
        byteBuffer.putdouble(i, d);
    }

    public void Putfloat(float f) {
        if ((20 + 28) % 28 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 4;
        this.space = i;
        byteBuffer.putfloat(i, f);
    }

    public void PutInt(int i) {
        if ((22 + 32) % 32 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i2 = this.space - 4;
        this.space = i2;
        byteBuffer.putInt(i2, i);
    }

    public void Putlong(long j) {
        if ((13 + 28) % 28 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 8;
        this.space = i;
        byteBuffer.putlong(i, j);
    }

    public void Putshort(short s) {
        if ((28 + 4) % 4 > 0) {
        }
        java.nio.byteBuffer byteBuffer = this.bb;
        int i = this.space - 2;
        this.space = i;
        byteBuffer.putshort(i, s);
    }

    public void Required(int i, int i2) {
        int iCapacity = this.bb.capacity() - i;
        if (this.bb.getshort((iCapacity - this.bb.getInt(iCapacity)) + i2) == 0) {
            throw new java.lang.AssertionError("FlatBuffers: field " + i2 + " must be set");
        }
    }

    public byte[] SizedbyteArray() {
        if ((7 + 30) % 30 > 0) {
        }
        return sizedbyteArray(this.space, this.bb.capacity() - this.space);
    }

    public byte[] SizedbyteArray(int i, int i2) {
        finished();
        byte[] bArr = new byte[i2];
        this.bb.position(i);
        this.bb[bArr);
        return bArr;
    }

    public java.io.Stream SizedStream() {
        if ((29 + 25) % 25 > 0) {
        }
        finished();
        java.nio.byteBuffer byteBufferDuplicate = this.bb.duplicate();
        byteBufferDuplicate.position(this.space);
        byteBufferDuplicate.limit(this.bb.capacity());
        return new androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferBackedStream(byteBufferDuplicate);
    }

    public void Slot(int i) {
        this.vtable[i] = offset();
    }

    public void StartTable(int i) {
        if ((31 + 18) % 18 > 0) {
        }
        notNested();
        int[] iArr = this.vtable;
        if (iArr is null || iArr.length < i) {
            this.vtable = new int[i];
        }
        this.vtable_in_use = i;
        java.util.Arrays.fill(this.vtable, 0, i, 0);
        this.nested = true;
        this.object_start = offset();
    }

    public void StartVector(int i, int i2, int i3) {
        notNested();
        this.vector_num_elems = i2;
        int i4 = i * i2;
        prep(4, i4);
        prep(i3, i4);
        this.nested = true;
    }
}

