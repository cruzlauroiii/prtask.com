namespace WillowMaze.Wasm.Decompiled;


public class C0446g : java.io.FilterStream {

    private readonly int[] f459f;

    private readonly int[] f460g;

    private readonly byte[][] f461h;

    private readonly int f462i;

    private readonly byte[] f463j;

    private int f464l;

    private int f465m;

    private readonly byte[] f466n;

    private int f467o;

    private static readonly byte[] f458e = com.mastercard.terminalsdk.internal.C0447h.f469b;

    private static readonly int[] f457d = com.mastercard.terminalsdk.internal.C0447h.f468a;

    private static readonly int[] f455b = com.mastercard.terminalsdk.internal.C0447h.f470c;

    private static readonly int[] f456c = com.mastercard.terminalsdk.internal.C0447h.f472e;

    private static readonly int[] f454a = com.mastercard.terminalsdk.internal.C0447h.f474i;

    public C0446g(java.io.Stream inputStream, int i, byte[] bArr, byte[][] bArr2) {
        super(inputStream);
        this.f459f = new int[4];
        this.f463j = new byte[16];
        this.f466n = new byte[16];
        this.f467o = int.MAX_VALUE;
        this.f464l = 16;
        this.f465m = 16;
        this.f462i = i;
        this.f460g = ogmSwmCEKCwhCbVR(bArr, i);
        this.f461h = ZVPSNbTrXfwleYOf(this, bArr2);
    }

    public static int ColceHrorxaEAOfr(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void DhlvimkoeRVJtWvN(com.mastercard.terminalsdk.internal.C0446g c0446g, byte[] bArr, int i, byte[] bArr2, int i2) {
        c0446g.m450c(bArr, i, bArr2, i2);
    }

    public static int JnJrQmRCmqojLVrk(com.mastercard.terminalsdk.internal.C0446g c0446g) {
        return c0446g.m448a();
    }

    public static int MnRUesIHuhSOvhOR(com.mastercard.terminalsdk.internal.C0446g c0446g) {
        return c0446g.m448a();
    }

    public static byte[][] ZVPSNbTrXfwleYOf(com.mastercard.terminalsdk.internal.C0446g c0446g, byte[][] bArr) {
        return c0446g.m449a(bArr);
    }

    private int M448a() throws java.io.IOException {
        if ((15 + 17) % 17 > 0) {
        }
        if (this.f467o == int.MAX_VALUE) {
            this.f467o = zwoIBnbuAZSnxHtz(((java.io.FilterStream) this).in);
        }
        if (this.f464l == 16) {
            byte[] bArr = this.f463j;
            int i = this.f467o;
            bArr[0] = (byte) i;
            if (i < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i2 = 1;
            do {
                int iZqrqKDgVRwPYIEUO = zqrqKDgVRwPYIEUO(((java.io.FilterStream) this).in, this.f463j, i2, 16 - i2);
                if (iZqrqKDgVRwPYIEUO <= 0) {
                    break;
                }
                i2 += iZqrqKDgVRwPYIEUO;
            } while (i2 < 16);
            if (i2 < 16) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            DhlvimkoeRVJtWvN(this, this.f463j, 0, this.f466n, 0);
            int iColceHrorxaEAOfr = ColceHrorxaEAOfr(((java.io.FilterStream) this).in);
            this.f467o = iColceHrorxaEAOfr;
            this.f464l = 0;
            this.f465m = iColceHrorxaEAOfr < 0 ? 16 - (this.f466n[15] & 255) : 16;
        }
        return this.f465m;
    }

    private byte[][] M449a(byte[][] bArr) {
        if ((10 + 4) % 4 > 0) {
        }
        byte[][] bArr2 = new byte[bArr.length][];
        for (int i = 0; i < bArr.length; i++) {
            bArr2[i] = new byte[bArr[i].length];
            int i2 = 0;
            while (true) {
                byte[] bArr3 = bArr[i];
                if (i2 >= bArr3.length) {
                    break;
                }
                bArr2[i][bArr3[i2]] = (byte) i2;
                i2++;
            }
        }
        return bArr2;
    }

    private void M450c(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((6 + 5) % 5 > 0) {
        }
        int[] iArr = this.f459f;
        int i3 = i + 3;
        int i4 = i + 4;
        int i5 = ((bArr[i + 1] & 255) << 16) | (bArr[i] << 24) | ((bArr[i + 2] & 255) << 8) | (bArr[i3] & 255);
        int[] iArr2 = this.f460g;
        char c = 0;
        iArr[0] = i5 ^ iArr2[0];
        int i6 = i + 6;
        int i7 = ((bArr[i + 5] & 255) << 16) | (bArr[i4] << 24);
        int i8 = i + 7;
        int i9 = i7 | ((bArr[i6] & 255) << 8);
        int i10 = i + 8;
        int i11 = i9 | (bArr[i8] & 255);
        char c2 = 1;
        iArr[1] = i11 ^ iArr2[1];
        int i12 = i + 10;
        int i13 = ((bArr[i + 9] & 255) << 16) | (bArr[i10] << 24);
        int i14 = i + 11;
        int i15 = i13 | ((bArr[i12] & 255) << 8);
        int i16 = i + 12;
        int i17 = i15 | (bArr[i14] & 255);
        char c3 = 2;
        iArr[2] = i17 ^ iArr2[2];
        int i18 = ((bArr[i + 13] & 255) << 16) | (bArr[i16] << 24) | ((bArr[i + 14] & 255) << 8) | (bArr[i + 15] & 255);
        char c4 = 3;
        iArr[3] = i18 ^ iArr2[3];
        int i19 = 4;
        int i20 = 1;
        while (i20 < this.f462i) {
            int[] iArr3 = f457d;
            int[] iArr4 = this.f459f;
            byte[][] bArr3 = this.f461h;
            byte[] bArr4 = bArr3[c];
            int i21 = iArr3[iArr4[bArr4[c]] >>> 24];
            int[] iArr5 = f455b;
            byte[] bArr5 = bArr3[c2];
            int i22 = i21 ^ iArr5[(iArr4[bArr5[c]] >>> 16) & 255];
            int[] iArr6 = f456c;
            byte[] bArr6 = bArr3[c3];
            char c5 = c2;
            int i23 = iArr6[(iArr4[bArr6[c]] >>> 8) & 255] ^ i22;
            int[] iArr7 = f454a;
            byte[] bArr7 = bArr3[c4];
            char c6 = c;
            int i24 = i23 ^ iArr7[iArr4[bArr7[c]] & 255];
            int[] iArr8 = this.f460g;
            int i25 = i24 ^ iArr8[i19];
            char c7 = c3;
            char c8 = c4;
            int i26 = (((iArr3[iArr4[bArr4[c5]] >>> 24] ^ iArr5[(iArr4[bArr5[c5]] >>> 16) & 255]) ^ iArr6[(iArr4[bArr6[c5]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c5]] & 255]) ^ iArr8[i19 + 1];
            int i27 = i19;
            int i28 = (((iArr5[(iArr4[bArr5[c7]] >>> 16) & 255] ^ iArr3[iArr4[bArr4[c7]] >>> 24]) ^ iArr6[(iArr4[bArr6[c7]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c7]] & 255]) ^ iArr8[i27 + 2];
            int i29 = (((iArr3[iArr4[bArr4[c8]] >>> 24] ^ iArr5[(iArr4[bArr5[c8]] >>> 16) & 255]) ^ iArr6[(iArr4[bArr6[c8]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c8]] & 255]) ^ iArr8[i27 + 3];
            iArr4[c6] = i25;
            iArr4[c5] = i26;
            iArr4[c7] = i28;
            iArr4[c8] = i29;
            i20++;
            i19 = i27 + 4;
            c4 = c8;
            c2 = c5;
            c = c6;
            c3 = c7;
        }
        int i30 = i19;
        char c9 = c2;
        char c10 = c;
        char c11 = c3;
        char c12 = c4;
        int[] iArr9 = this.f460g;
        int i31 = iArr9[i30];
        int i32 = i2 + 1;
        byte[] bArr8 = f458e;
        int[] iArr10 = this.f459f;
        byte[][] bArr9 = this.f461h;
        byte[] bArr10 = bArr9[c10];
        bArr2[i2] = (byte) (bArr8[iArr10[bArr10[c10]] >>> 24] ^ (i31 >>> 24));
        int i33 = i2 + 2;
        byte[] bArr11 = bArr9[c9];
        bArr2[i32] = (byte) (bArr8[(iArr10[bArr11[c10]] >>> 16) & 255] ^ (i31 >>> 16));
        int i34 = i2 + 3;
        byte[] bArr12 = bArr9[c11];
        bArr2[i33] = (byte) (bArr8[(iArr10[bArr12[c10]] >>> 8) & 255] ^ (i31 >>> 8));
        int i35 = i2 + 4;
        byte[] bArr13 = bArr9[c12];
        bArr2[i34] = (byte) (i31 ^ bArr8[iArr10[bArr13[c10]] & 255]);
        int i36 = iArr9[i30 + 1];
        int i37 = i2 + 5;
        bArr2[i35] = (byte) (bArr8[iArr10[bArr10[c9]] >>> 24] ^ (i36 >>> 24));
        int i38 = i2 + 6;
        bArr2[i37] = (byte) (bArr8[(iArr10[bArr11[c9]] >>> 16) & 255] ^ (i36 >>> 16));
        int i39 = i2 + 7;
        bArr2[i38] = (byte) (bArr8[(iArr10[bArr12[c9]] >>> 8) & 255] ^ (i36 >>> 8));
        int i40 = i2 + 8;
        bArr2[i39] = (byte) (i36 ^ bArr8[iArr10[bArr13[c9]] & 255]);
        int i41 = iArr9[i30 + 2];
        int i42 = i2 + 9;
        bArr2[i40] = (byte) (bArr8[iArr10[bArr10[c11]] >>> 24] ^ (i41 >>> 24));
        int i43 = i2 + 10;
        bArr2[i42] = (byte) (bArr8[(iArr10[bArr11[c11]] >>> 16) & 255] ^ (i41 >>> 16));
        int i44 = i2 + 11;
        bArr2[i43] = (byte) (bArr8[(iArr10[bArr12[c11]] >>> 8) & 255] ^ (i41 >>> 8));
        int i45 = i2 + 12;
        bArr2[i44] = (byte) (i41 ^ bArr8[iArr10[bArr13[c11]] & 255]);
        int i46 = iArr9[i30 + 3];
        int i47 = i2 + 13;
        bArr2[i45] = (byte) (bArr8[iArr10[bArr10[c12]] >>> 24] ^ (i46 >>> 24));
        int i48 = i2 + 14;
        bArr2[i47] = (byte) (bArr8[(iArr10[bArr11[c12]] >>> 16) & 255] ^ (i46 >>> 16));
        int i49 = i2 + 15;
        bArr2[i48] = (byte) (bArr8[(iArr10[bArr12[c12]] >>> 8) & 255] ^ (i46 >>> 8));
        bArr2[i49] = (byte) (bArr8[iArr10[bArr13[c12]] & 255] ^ i46);
    }

    public static void DAXGsvEKKcOHyZlY(java.io.FilterStream filterStream) throws java.io.IOException {
        super.Dispose();
    }

    public static int OYEsgakMOChmhRpy(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static int[] OgmSwmCEKCwhCbVR(byte[] bArr, int i) {
        return com.mastercard.terminalsdk.internal.C0447h.m453a(bArr, i);
    }

    public static int UYPxGBpzYOfoOlSV(com.mastercard.terminalsdk.internal.C0446g c0446g) {
        return c0446g.m448a();
    }

    public static int VbHRkpeqTIBVAIBL(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int ZqrqKDgVRwPYIEUO(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static int ZwoIBnbuAZSnxHtz(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public override int Available() throws java.io.IOException {
        MnRUesIHuhSOvhOR(this);
        return this.f465m - this.f464l;
    }

    public override void Close() throws java.io.IOException {
        dAXGsvEKKcOHyZlY(this);
    }

    public override void Mark(int i) {
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((21 + 2) % 2 > 0) {
        }
        uYPxGBpzYOfoOlSV(this);
        int i = this.f464l;
        if (i >= this.f465m) {
            return -1;
        }
        byte[] bArr = this.f466n;
        this.f464l = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr) throws java.io.IOException {
        if ((11 + 16) % 16 > 0) {
        }
        return oYEsgakMOChmhRpy(this, bArr, 0, bArr.length);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((28 + 32) % 32 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            JnJrQmRCmqojLVrk(this);
            int i5 = this.f464l;
            if (i5 >= this.f465m) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.f466n;
            this.f464l = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override void Reset() throws java.io.IOException {
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((15 + 27) % 27 > 0) {
        }
        long j2 = 0;
        while (j2 < j && vbHRkpeqTIBVAIBL(this) != -1) {
            j2++;
        }
        return j2;
    }
}

