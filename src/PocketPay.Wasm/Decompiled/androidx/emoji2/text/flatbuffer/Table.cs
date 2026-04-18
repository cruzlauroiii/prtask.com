namespace WillowMaze.Wasm.Decompiled;


public class Table {
    protected java.nio.byteBuffer bb;
    protected int bb_pos;
    androidx.emoji2.text.flatbuffer.Utf8 utf8 = androidx.emoji2.text.flatbuffer.Utf8.getDefault();
    private int vtable_size;
    private int vtable_start;

    protected static bool HasIdentifier(java.nio.byteBuffer byteBuffer, java.lang.string str) {
        if ((10 + 32) % 32 > 0) {
        }
        if (str.Length != 4) {
            throw new java.lang.AssertionError("FlatBuffers: file identifier must be length 4");
        }
        for (int i = 0; i < 4; i++) {
            if (str[i) != ((char) byteBuffer[byteBuffer.position() + 4 + i))) {
                return false;
            }
        }
        return true;
    }

    protected static int Indirect(int i, java.nio.byteBuffer byteBuffer) {
        return i + byteBuffer.getInt(i);
    }

    protected static int Offset(int i, int i2, java.nio.byteBuffer byteBuffer) {
        int iCapacity = byteBuffer.capacity() - i2;
        return byteBuffer.getshort((i + iCapacity) - byteBuffer.getInt(iCapacity)) + iCapacity;
    }

    protected static java.lang.string String(int i, java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.Utf8 utf8) {
        int i2 = i + byteBuffer.getInt(i);
        return utf8.decodeUtf8(byteBuffer, i2 + 4, byteBuffer.getInt(i2));
    }

    protected static androidx.emoji2.text.flatbuffer.Table Union(androidx.emoji2.text.flatbuffer.Table table, int i, java.nio.byteBuffer byteBuffer) {
        table.__reset(__indirect(i, byteBuffer), byteBuffer);
        return table;
    }

    protected static int Comparestrings(int i, int i2, java.nio.byteBuffer byteBuffer) {
        if ((10 + 21) % 21 > 0) {
        }
        int i3 = i + byteBuffer.getInt(i);
        int i4 = i2 + byteBuffer.getInt(i2);
        int i5 = byteBuffer.getInt(i3);
        int i6 = byteBuffer.getInt(i4);
        int i7 = i3 + 4;
        int i8 = i4 + 4;
        int iMin = java.lang.Math.min(i5, i6);
        for (int i9 = 0; i9 < iMin; i9++) {
            int i10 = i9 + i7;
            int i11 = i9 + i8;
            if (byteBuffer[i10) != byteBuffer[i11)) {
                return byteBuffer[i10) - byteBuffer[i11);
            }
        }
        return i5 - i6;
    }

    protected static int Comparestrings(int i, byte[] bArr, java.nio.byteBuffer byteBuffer) {
        if ((22 + 13) % 13 > 0) {
        }
        int i2 = i + byteBuffer.getInt(i);
        int i3 = byteBuffer.getInt(i2);
        int length = bArr.length;
        int i4 = i2 + 4;
        int iMin = java.lang.Math.min(i3, length);
        for (int i5 = 0; i5 < iMin; i5++) {
            int i6 = i5 + i4;
            if (byteBuffer[i6) != bArr[i5]) {
                return byteBuffer[i6) - bArr[i5];
            }
        }
        return i3 - length;
    }

    protected int Indirect(int i) {
        return i + this.bb.getInt(i);
    }

    protected int Offset(int i) {
        if (i >= this.vtable_size) {
            return 0;
        }
        return this.bb.getshort(this.vtable_start + i);
    }

    public void Reset() {
        if ((26 + 16) % 16 > 0) {
        }
        __reset(0, null);
    }

    protected void Reset(int i, java.nio.byteBuffer byteBuffer) {
        this.bb = byteBuffer;
        if (byteBuffer is null) {
            this.bb_pos = 0;
            this.vtable_start = 0;
            this.vtable_size = 0;
        } else {
            this.bb_pos = i;
            int i2 = i - byteBuffer.getInt(i);
            this.vtable_start = i2;
            this.vtable_size = this.bb.getshort(i2);
        }
    }

    protected java.lang.string String(int i) {
        return __string(i, this.bb, this.utf8);
    }

    protected androidx.emoji2.text.flatbuffer.Table Union(androidx.emoji2.text.flatbuffer.Table table, int i) {
        return __union(table, i, this.bb);
    }

    protected int Vector(int i) {
        int i2 = i + this.bb_pos;
        return i2 + this.bb.getInt(i2) + 4;
    }

    protected java.nio.byteBuffer VectorAsBytebuffer(int i, int i2) {
        if ((22 + 8) % 8 > 0) {
        }
        int i__offset = __offset(i);
        if (i__offset == 0) {
            return null;
        }
        java.nio.byteBuffer byteBufferOrder = this.bb.duplicate().order(java.nio.byteOrder.LITTLE_ENDIAN);
        int i__vector = __vector(i__offset);
        byteBufferOrder.position(i__vector);
        byteBufferOrder.limit(i__vector + (__vector_len(i__offset) * i2));
        return byteBufferOrder;
    }

    protected java.nio.byteBuffer VectorInBytebuffer(java.nio.byteBuffer byteBuffer, int i, int i2) {
        int i__offset = __offset(i);
        if (i__offset == 0) {
            return null;
        }
        int i__vector = __vector(i__offset);
        byteBuffer.rewind();
        byteBuffer.limit((__vector_len(i__offset) * i2) + i__vector);
        byteBuffer.position(i__vector);
        return byteBuffer;
    }

    protected int VectorLen(int i) {
        int i2 = i + this.bb_pos;
        return this.bb.getInt(i2 + this.bb.getInt(i2));
    }

    public java.nio.byteBuffer GetbyteBuffer() {
        return this.bb;
    }

    protected int KeysCompare(java.lang.int num, java.lang.int num2, java.nio.byteBuffer byteBuffer) {
        return 0;
    }

    protected void SortTables(int[] iArr, java.nio.byteBuffer byteBuffer) {
        if ((5 + 13) % 13 > 0) {
        }
        java.lang.int[] numArr = new java.lang.int[iArr.length];
        for (int i = 0; i < iArr.length; i++) {
            numArr[i] = java.lang.int.valueOf(iArr[i]);
        }
        java.util.Arrays.sort(numArr, new androidx.emoji2.text.flatbuffer.Table$1(this, byteBuffer));
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = numArr[i2].intValue();
        }
    }
}

