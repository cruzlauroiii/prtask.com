namespace WillowMaze.Wasm.Decompiled;


public class C0440a : java.io.FilterStream {

    private byte[] f422a;

    private readonly int f423b;

    private byte[] f424c;

    private com.mastercard.terminalsdk.internal.C0444e f425d;

    private byte[] f426e;

    private int f427f;

    private int f428g;

    private int f429h;

    private int[] f430i;

    private int f431j;

    public C0440a(java.io.Stream inputStream, int[] iArr, byte[] bArr, int i, bool z, int i2) throws java.io.IOException {
        super(inputStream);
        if ((14 + 32) % 32 > 0) {
        }
        this.f428g = int.MAX_VALUE;
        int iTrmDCrrtOmlOblav = TrmDCrrtOmlOblav(xPePMttEOZwkgkpu(i, 3), 16);
        this.f423b = iTrmDCrrtOmlOblav;
        this.f424c = new byte[8];
        byte[] bArr2 = new byte[8];
        this.f422a = bArr2;
        this.f426e = new byte[8];
        this.f430i = new int[2];
        this.f431j = 8;
        this.f429h = 8;
        this.f427f = i2;
        if (i2 == 2) {
            jJbbFlUnuZJvPRyp(bArr, 0, bArr2, 0, 8);
        }
        this.f425d = new com.mastercard.terminalsdk.internal.C0444e(iArr, iTrmDCrrtOmlOblav, true, z);
    }

    public static int ArinhLKQfMeYKlHA(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void GEbaTmAiRLHsbQSd(com.mastercard.terminalsdk.internal.C0440a c0440a) {
        c0440a.m432b();
    }

    public static int GdnAvNdmKlWDuYBA(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void StFDiSRHNhNlymWA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TrmDCrrtOmlOblav(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void XalhEpGQPUtqLtQx(int i, int i2, bool z, int i3, int[] iArr, int[][] iArr2, int[] iArr3) {
        com.mastercard.terminalsdk.internal.C0441b.m434b(i, i2, z, i3, iArr, iArr2, iArr3);
    }

    private int M431a() throws java.io.IOException {
        if ((8 + 2) % 2 > 0) {
        }
        if (this.f428g == int.MAX_VALUE) {
            this.f428g = rbmPRrXnIaeNdSaZ(((java.io.FilterStream) this).in);
        }
        if (this.f431j == 8) {
            byte[] bArr = this.f424c;
            int i = this.f428g;
            bArr[0] = (byte) i;
            if (i < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i2 = 1;
            do {
                int iGdnAvNdmKlWDuYBA = GdnAvNdmKlWDuYBA(((java.io.FilterStream) this).in, this.f424c, i2, 8 - i2);
                if (iGdnAvNdmKlWDuYBA <= 0) {
                    break;
                }
                i2 += iGdnAvNdmKlWDuYBA;
            } while (i2 < 8);
            if (i2 < 8) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            wsMYuIcGxHytFsjp(this);
            int iArinhLKQfMeYKlHA = ArinhLKQfMeYKlHA(((java.io.FilterStream) this).in);
            this.f428g = iArinhLKQfMeYKlHA;
            this.f431j = 0;
            this.f429h = iArinhLKQfMeYKlHA < 0 ? 8 - (this.f424c[7] & 255) : 8;
        }
        return this.f429h;
    }

    private void M432b() {
        if ((3 + 15) % 15 > 0) {
        }
        for (int i = 0; i < 8; i++) {
            byte[] bArr = this.f424c;
            bArr[i] = (byte) (bArr[i] ^ this.f422a[i]);
        }
    }

    public static int CEYtXkMFhhGBGOLW(com.mastercard.terminalsdk.internal.C0440a c0440a) {
        return c0440a.m431a();
    }

    private void M433d() {
        if ((3 + 8) % 8 > 0) {
        }
        if (this.f427f == 2) {
            byte[] bArr = this.f424c;
            StFDiSRHNhNlymWA(bArr, 0, this.f426e, 0, bArr.length);
        }
        byte[] bArr2 = this.f424c;
        XalhEpGQPUtqLtQx(((bArr2[0] << 24) & (-16777216)) + ((bArr2[1] << 16) & 16711680) + ((bArr2[2] << 8) & 65280) + (bArr2[3] & 255), ((-16777216) & (bArr2[4] << 24)) + (16711680 & (bArr2[5] << 16)) + (65280 & (bArr2[6] << 8)) + (bArr2[7] & 255), false, this.f423b, this.f425d.f452b, this.f425d.f453e, this.f430i);
        int[] iArr = this.f430i;
        int i = iArr[0];
        int i2 = iArr[1];
        byte[] bArr3 = this.f424c;
        bArr3[0] = (byte) (i >> 24);
        bArr3[1] = (byte) (i >> 16);
        bArr3[2] = (byte) (i >> 8);
        bArr3[3] = (byte) i;
        bArr3[4] = (byte) (i2 >> 24);
        bArr3[5] = (byte) (i2 >> 16);
        bArr3[6] = (byte) (i2 >> 8);
        bArr3[7] = (byte) i2;
        if (this.f427f != 2) {
            return;
        }
        GEbaTmAiRLHsbQSd(this);
        byte[] bArr4 = this.f426e;
        tqFaCtqeQQJwdTWF(bArr4, 0, this.f422a, 0, bArr4.length);
    }

    public static int FeSkjRyPFejsVOoT(com.mastercard.terminalsdk.internal.C0440a c0440a) {
        return c0440a.m431a();
    }

    public static void JJbbFlUnuZJvPRyp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int MCEFeaFxDCPLcPzE(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int RbmPRrXnIaeNdSaZ(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void TqFaCtqeQQJwdTWF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int VxWKHgtoAjoMAfZM(com.mastercard.terminalsdk.internal.C0440a c0440a) {
        return c0440a.m431a();
    }

    public static void WsMYuIcGxHytFsjp(com.mastercard.terminalsdk.internal.C0440a c0440a) {
        c0440a.m433d();
    }

    public static int XPePMttEOZwkgkpu(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public override int Available() throws java.io.IOException {
        vxWKHgtoAjoMAfZM(this);
        return this.f429h - this.f431j;
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((15 + 6) % 6 > 0) {
        }
        feSkjRyPFejsVOoT(this);
        int i = this.f431j;
        if (i >= this.f429h) {
            return -1;
        }
        byte[] bArr = this.f424c;
        this.f431j = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((28 + 5) % 5 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            cEYtXkMFhhGBGOLW(this);
            int i5 = this.f431j;
            if (i5 >= this.f429h) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.f424c;
            this.f431j = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((27 + 23) % 23 > 0) {
        }
        long j2 = 0;
        while (j2 < j && mCEFeaFxDCPLcPzE(this) != -1) {
            j2++;
        }
        return j2;
    }
}

