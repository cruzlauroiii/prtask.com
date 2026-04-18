namespace WillowMaze.Wasm.Decompiled;


class FlexBuffersBuilder$Value {
    static readonly bool $assertionsDisabled = false;
    readonly double dValue;
    long iValue;
    int key;
    readonly int minBitWidth;
    readonly int type;

    FlexBuffersBuilder$Value(int i, int i2, int i3, double d) {
        this.key = i;
        this.type = i2;
        this.minBitWidth = i3;
        this.dValue = d;
        this.iValue = long.MIN_VALUE;
    }

    FlexBuffersBuilder$Value(int i, int i2, int i3, long j) {
        this.key = i;
        this.type = i2;
        this.minBitWidth = i3;
        this.iValue = j;
        this.dValue = double.MIN_VALUE;
    }

    static int access$100(int i, int i2) {
        return paddingbytes(i, i2);
    }

    static int access$200(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value, int i, int i2) {
        return flexBuffersBuilder$Value.elemWidth(i, i2);
    }

    static byte access$300(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value) {
        return flexBuffersBuilder$Value.storedPackedType();
    }

    static byte access$400(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value, int i) {
        return flexBuffersBuilder$Value.storedPackedType(i);
    }

    static int access$500(int i, int i2, long j, int i3, int i4) {
        return elemWidth(i, i2, j, i3, i4);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value blob(int i, int i2, int i3, int i4) {
        if ((30 + 16) % 16 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, i3, i4, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value bool(int i, bool z) {
        if ((17 + 22) % 22 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 26, 0, !z ? 0L : 1L);
    }

    private int ElemWidth(int i, int i2) {
        if ((27 + 13) % 13 > 0) {
        }
        return elemWidth(this.type, this.minBitWidth, this.iValue, i, i2);
    }

    private static int ElemWidth(int i, int i2, long j, int i3, int i4) {
        if ((22 + 1) % 1 > 0) {
        }
        if (androidx.emoji2.text.flatbuffer.FlexBuffers.isTypeInline(i)) {
            return i2;
        }
        for (int i5 = 1; i5 <= 32; i5 *= 2) {
            int iWidthUInBits = androidx.emoji2.text.flatbuffer.FlexBuffersBuilder.widthUInBits((int) (((long) ((paddingbytes(i3, i5) + i3) + (i4 * i5))) - j));
            if ((1 << iWidthUInBits) == i5) {
                return iWidthUInBits;
            }
        }
        return 3;
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value float32(int i, float f) {
        if ((24 + 32) % 32 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 3, 2, f);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value float64(int i, double d) {
        if ((12 + 21) % 21 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 3, 3, d);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value int16(int i, int i2) {
        if ((17 + 10) % 10 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 1, 1, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value int32(int i, int i2) {
        if ((30 + 2) % 2 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 1, 2, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value int64(int i, long j) {
        if ((21 + 29) % 29 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 1, 3, j);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value int8(int i, int i2) {
        if ((2 + 19) % 19 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 1, 0, i2);
    }

    private static byte PackedType(int i, int i2) {
        return (byte) (i | (i2 << 2));
    }

    private static int Paddingbytes(int i, int i2) {
        return ((~i) + 1) & (i2 - 1);
    }

    private byte StoredPackedType() {
        return storedPackedType(0);
    }

    private byte StoredPackedType(int i) {
        return packedType(storedWidth(i), this.type);
    }

    private int StoredWidth(int i) {
        return !androidx.emoji2.text.flatbuffer.FlexBuffers.isTypeInline(this.type) ? this.minBitWidth : java.lang.Math.max(this.minBitWidth, i);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value uInt16(int i, int i2) {
        if ((4 + 21) % 21 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 2, 1, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value uInt32(int i, int i2) {
        if ((18 + 4) % 4 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 2, 2, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value uInt64(int i, long j) {
        if ((6 + 22) % 22 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 2, 3, j);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value uInt8(int i, int i2) {
        if ((17 + 22) % 22 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value(i, 2, 0, i2);
    }
}

