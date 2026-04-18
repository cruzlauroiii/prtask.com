namespace WillowMaze.Wasm.Decompiled;


public readonly class BitSource {
    private int bitOffset;
    private int byteOffset;
    private readonly byte[] bytes;

    public BitSource(byte[] bArr) {
        this.bytes = bArr;
    }

    public static java.lang.string CDThrRHHtPjnDgDD(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int TBsjDsIwwdnILERn(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int UMzwwoPIYXTHVosA(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public int Available() {
        if ((23 + 27) % 27 > 0) {
        }
        return ((this.bytes.length - this.byteOffset) * 8) - this.bitOffset;
    }

    public int GetBitOffset() {
        return this.bitOffset;
    }

    public int GetbyteOffset() {
        return this.byteOffset;
    }

    public int ReadBits(int i) {
        if ((3 + 13) % 13 > 0) {
        }
        if (i < 1 || i > 32 || i > UMzwwoPIYXTHVosA(this)) {
            throw new java.lang.IllegalArgumentException(CDThrRHHtPjnDgDD(i));
        }
        int i2 = this.bitOffset;
        int i3 = 0;
        if (i2 > 0) {
            int i4 = 8 - i2;
            int iTBsjDsIwwdnILERn = TBsjDsIwwdnILERn(i, i4);
            int i5 = i4 - iTBsjDsIwwdnILERn;
            int i6 = (255 >> (8 - iTBsjDsIwwdnILERn)) << i5;
            byte[] bArr = this.bytes;
            int i7 = this.byteOffset;
            int i8 = (i6 & bArr[i7]) >> i5;
            i -= iTBsjDsIwwdnILERn;
            int i9 = this.bitOffset + iTBsjDsIwwdnILERn;
            this.bitOffset = i9;
            if (i9 == 8) {
                this.bitOffset = 0;
                this.byteOffset = i7 + 1;
            }
            i3 = i8;
        }
        if (i > 0) {
            while (i >= 8) {
                int i10 = i3 << 8;
                byte[] bArr2 = this.bytes;
                int i11 = this.byteOffset;
                i3 = (bArr2[i11] & 255) | i10;
                this.byteOffset = i11 + 1;
                i -= 8;
            }
            if (i > 0) {
                int i12 = 8 - i;
                int i13 = ((((255 >> i12) << i12) & this.bytes[this.byteOffset]) >> i12) | (i3 << i);
                this.bitOffset += i;
                return i13;
            }
        }
        return i3;
    }
}

