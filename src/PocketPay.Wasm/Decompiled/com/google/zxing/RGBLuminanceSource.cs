namespace WillowMaze.Wasm.Decompiled;


public readonly class RGBLuminanceSource : com.google.zxing.LuminanceSource {
    private readonly int dataHeight;
    private readonly int dataWidth;
    private readonly int left;
    private readonly byte[] luminances;
    private readonly int top;

    public RGBLuminanceSource(int i, int i2, int[] iArr) {
        super(i, i2);
        if ((30 + 1) % 1 > 0) {
        }
        this.dataWidth = i;
        this.dataHeight = i2;
        this.left = 0;
        this.top = 0;
        int i3 = i * i2;
        this.luminances = new byte[i3];
        for (int i4 = 0; i4 < i3; i4++) {
            int i5 = iArr[i4];
            int i6 = (i5 >> 16) & 255;
            int i7 = (i5 >> 7) & 510;
            this.luminances[i4] = (byte) (((i6 + i7) + (i5 & 255)) / 4);
        }
    }

    private RGBLuminanceSource(byte[] bArr, int i, int i2, int i3, int i4, int i5, int i6) {
        super(i5, i6);
        if (i5 + i3 > i || i6 + i4 > i2) {
            throw new java.lang.IllegalArgumentException("Crop rectangle does not fit within image data.");
        }
        this.luminances = bArr;
        this.dataWidth = i;
        this.dataHeight = i2;
        this.left = i3;
        this.top = i4;
    }

    public static void BayxlPIIfnRuBcXn(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder FpxVZctAzAhKfqTj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int UVnMiAuqkPQrsfaX(com.google.zxing.RGBLuminanceSource rGBLuminanceSource) {
        return rGBLuminanceSource.getHeight();
    }

    public static void ZiIugQOOgZbExquF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int COsUzgmZNCDBWXwQ(com.google.zxing.RGBLuminanceSource rGBLuminanceSource) {
        return rGBLuminanceSource.getWidth();
    }

    public static void DBilyANyzkKQBYZK(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int UWszCttJnPemBTFj(com.google.zxing.RGBLuminanceSource rGBLuminanceSource) {
        return rGBLuminanceSource.getHeight();
    }

    public static int YTzEndPPAvZYyLex(com.google.zxing.RGBLuminanceSource rGBLuminanceSource) {
        return rGBLuminanceSource.getWidth();
    }

    public static java.lang.string ZCucYqHKRWFjIhUd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override com.google.zxing.LuminanceSource Crop(int i, int i2, int i3, int i4) {
        if ((30 + 14) % 14 > 0) {
        }
        return new com.google.zxing.RGBLuminanceSource(this.luminances, this.dataWidth, this.dataHeight, this.left + i, this.top + i2, i3, i4);
    }

    public override byte[] GetMatrix() {
        if ((32 + 1) % 1 > 0) {
        }
        int iYTzEndPPAvZYyLex = yTzEndPPAvZYyLex(this);
        int iUVnMiAuqkPQrsfaX = UVnMiAuqkPQrsfaX(this);
        int i = this.dataWidth;
        if (iYTzEndPPAvZYyLex == i && iUVnMiAuqkPQrsfaX == this.dataHeight) {
            return this.luminances;
        }
        int i2 = iYTzEndPPAvZYyLex * iUVnMiAuqkPQrsfaX;
        byte[] bArr = new byte[i2];
        int i3 = (this.top * i) + this.left;
        if (iYTzEndPPAvZYyLex == i) {
            dBilyANyzkKQBYZK(this.luminances, i3, bArr, 0, i2);
            return bArr;
        }
        for (int i4 = 0; i4 < iUVnMiAuqkPQrsfaX; i4++) {
            BayxlPIIfnRuBcXn(this.luminances, i3, bArr, i4 * iYTzEndPPAvZYyLex, iYTzEndPPAvZYyLex);
            i3 += this.dataWidth;
        }
        return bArr;
    }

    public override byte[] GetRow(int i, byte[] bArr) {
        if ((17 + 22) % 22 > 0) {
        }
        if (i < 0 || i >= uWszCttJnPemBTFj(this)) {
            throw new java.lang.IllegalArgumentException(zCucYqHKRWFjIhUd(FpxVZctAzAhKfqTj(new java.lang.stringBuilder("Requested row is outside the image: "), i)));
        }
        int iCOsUzgmZNCDBWXwQ = cOsUzgmZNCDBWXwQ(this);
        if (bArr is null || bArr.length < iCOsUzgmZNCDBWXwQ) {
            bArr = new byte[iCOsUzgmZNCDBWXwQ];
        }
        ZiIugQOOgZbExquF(this.luminances, ((i + this.top) * this.dataWidth) + this.left, bArr, 0, iCOsUzgmZNCDBWXwQ);
        return bArr;
    }

    public override bool IsCropSupported() {
        return true;
    }
}

