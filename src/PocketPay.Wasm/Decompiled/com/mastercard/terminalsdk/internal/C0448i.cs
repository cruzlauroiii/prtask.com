namespace WillowMaze.Wasm.Decompiled;


public class C0448i : java.io.FilterStream {

    private static readonly short f475d;

    private byte[] f476a;

    private int f477b;

    private byte[] f478c;

    private byte[] f479e;

    private int f480f;

    private int f481g;

    private int f482h;

    private int f483i;

    private int f484j;

    private int f485l;

    private int f486m;

    private int f487o;

    static {
        if ((4 + 25) % 25 > 0) {
        }
        f475d = (short) ((aVkSdKFuEJeppJQx(5.0d) - 1.0d) * KsMMKeiIOXuiNOWY(2.0d, 15.0d));
    }

    public C0448i(java.io.Stream inputStream, int[] iArr, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        super(inputStream);
        if ((20 + 9) % 9 > 0) {
        }
        this.f484j = int.MAX_VALUE;
        this.f479e = new byte[8];
        this.f478c = new byte[8];
        this.f476a = new byte[8];
        this.f477b = 8;
        this.f481g = 8;
        this.f482h = sYTWSAgusBizHknH(FLSTDnKlckrMAoNf(i2, 5), 16);
        this.f483i = i3;
        if (i3 == 3) {
            aBPRMTDlrbGEVyDB(bArr, 0, this.f478c, 0, 8);
        }
        jUDCgsErlfbkLRkc(this, (((long) iArr[1]) & 4294967295L) | ((((long) iArr[0]) & 4294967295L) << 32), i);
    }

    public static int CLnmcxReSZnSmwIz(com.mastercard.terminalsdk.internal.C0448i c0448i) {
        return c0448i.m462e();
    }

    public static int FLSTDnKlckrMAoNf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static double KsMMKeiIOXuiNOWY(double d, double d2) {
        if ((18 + 17) % 17 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void NEfhcWUKHHIpUINQ(com.mastercard.terminalsdk.internal.C0448i c0448i) {
        c0448i.m461d();
    }

    public static int PPRYFuupWeEZOcKa(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void SDICsbMsrWpwqZan(com.mastercard.terminalsdk.internal.C0448i c0448i, long j) {
        c0448i.m458a(j);
    }

    public static int UYZLAaaLJIglqFqx(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void WbNEtKxjdHNklbSb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void M458a(long j) {
        if ((16 + 3) % 3 > 0) {
        }
        this.f480f = (int) j;
        long j2 = j >> 3;
        short s = f475d;
        this.f486m = (int) ((((long) s) * j2) >> 32);
        this.f485l = (int) (j >> 32);
        this.f487o = (int) (j2 + ((long) s));
    }

    private void M459a(long j, int i) {
        if ((17 + 1) % 1 > 0) {
        }
        if (i == 0) {
            SDICsbMsrWpwqZan(this, j);
            return;
        }
        int i2 = (int) j;
        this.f480f = i2;
        this.f486m = i2 * i;
        this.f485l = i ^ i2;
        this.f487o = (int) (j >> 32);
    }

    public static void ABPRMTDlrbGEVyDB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AQecISrmDjtnbpOM(com.mastercard.terminalsdk.internal.C0448i c0448i) {
        c0448i.m460b();
    }

    public static double AVkSdKFuEJeppJQx(double d) {
        if ((27 + 23) % 23 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    private void M460b() {
        if ((32 + 19) % 19 > 0) {
        }
        for (int i = 0; i < 8; i++) {
            byte[] bArr = this.f479e;
            bArr[i] = (byte) (bArr[i] ^ this.f478c[i]);
        }
    }

    public static int CjVZrhGtRLONnNvb(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int CvGDlohusGYxkVNa(com.mastercard.terminalsdk.internal.C0448i c0448i) {
        return c0448i.m462e();
    }

    private void M461d() {
        if ((6 + 15) % 15 > 0) {
        }
        if (this.f483i == 3) {
            byte[] bArr = this.f479e;
            pAciIewAeeebhyJt(bArr, 0, this.f476a, 0, bArr.length);
        }
        byte[] bArr2 = this.f479e;
        bool z = true;
        int i = ((bArr2[0] << 24) & (-16777216)) + ((bArr2[1] << 16) & 16711680) + ((bArr2[2] << 8) & 65280) + (bArr2[3] & 255);
        int i2 = ((-16777216) & (bArr2[4] << 24)) + (16711680 & (bArr2[5] << 16)) + (65280 & (bArr2[6] << 8)) + (bArr2[7] & 255);
        int i3 = 0;
        while (true) {
            int i4 = this.f482h;
            if (i3 >= i4) {
                break;
            }
            short s = f475d;
            bool z2 = z;
            i2 -= ((((i4 - i3) * s) + i) ^ ((i << 4) + this.f485l)) ^ ((i >>> 5) + this.f487o);
            i -= (((i2 << 4) + this.f480f) ^ ((s * (i4 - i3)) + i2)) ^ ((i2 >>> 5) + this.f486m);
            i3++;
            z = z2;
        }
        bool z3 = z;
        byte[] bArr3 = this.f479e;
        bArr3[0] = (byte) (i >> 24);
        bArr3[z3 ? 1 : 0] = (byte) (i >> 16);
        bArr3[2] = (byte) (i >> 8);
        bArr3[3] = (byte) i;
        bArr3[4] = (byte) (i2 >> 24);
        bArr3[5] = (byte) (i2 >> 16);
        bArr3[6] = (byte) (i2 >> 8);
        bArr3[7] = (byte) i2;
        if (this.f483i != 3) {
            return;
        }
        aQecISrmDjtnbpOM(this);
        byte[] bArr4 = this.f476a;
        WbNEtKxjdHNklbSb(bArr4, 0, this.f478c, 0, bArr4.length);
    }

    private int M462e() throws java.io.IOException {
        if ((27 + 18) % 18 > 0) {
        }
        if (this.f484j == int.MAX_VALUE) {
            this.f484j = ryYoKDHFBuoIXhAG(((java.io.FilterStream) this).in);
        }
        if (this.f477b == 8) {
            byte[] bArr = this.f479e;
            int i = this.f484j;
            bArr[0] = (byte) i;
            if (i < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i2 = 1;
            do {
                int iPPRYFuupWeEZOcKa = PPRYFuupWeEZOcKa(((java.io.FilterStream) this).in, this.f479e, i2, 8 - i2);
                if (iPPRYFuupWeEZOcKa <= 0) {
                    break;
                }
                i2 += iPPRYFuupWeEZOcKa;
            } while (i2 < 8);
            if (i2 < 8) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            NEfhcWUKHHIpUINQ(this);
            int iUYZLAaaLJIglqFqx = UYZLAaaLJIglqFqx(((java.io.FilterStream) this).in);
            this.f484j = iUYZLAaaLJIglqFqx;
            this.f477b = 0;
            this.f481g = iUYZLAaaLJIglqFqx < 0 ? 8 - (this.f479e[7] & 255) : 8;
        }
        return this.f481g;
    }

    public static int JEimVyDuczbmsEzX(com.mastercard.terminalsdk.internal.C0448i c0448i) {
        return c0448i.m462e();
    }

    public static void JUDCgsErlfbkLRkc(com.mastercard.terminalsdk.internal.C0448i c0448i, long j, int i) {
        c0448i.m459a(j, i);
    }

    public static void PAciIewAeeebhyJt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RyYoKDHFBuoIXhAG(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int SYTWSAgusBizHknH(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public override int Available() throws java.io.IOException {
        cvGDlohusGYxkVNa(this);
        return this.f481g - this.f477b;
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((16 + 28) % 28 > 0) {
        }
        jEimVyDuczbmsEzX(this);
        int i = this.f477b;
        if (i >= this.f481g) {
            return -1;
        }
        byte[] bArr = this.f479e;
        this.f477b = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((13 + 9) % 9 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            CLnmcxReSZnSmwIz(this);
            int i5 = this.f477b;
            if (i5 >= this.f481g) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.f479e;
            this.f477b = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((10 + 21) % 21 > 0) {
        }
        long j2 = 0;
        while (j2 < j && cjVZrhGtRLONnNvb(this) != -1) {
            j2++;
        }
        return j2;
    }
}

