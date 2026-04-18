namespace WillowMaze.Wasm.Decompiled;


public class C0443d : java.io.FilterStream {

    private long[] f432a;

    private long[] f433b;

    private byte[] f434c;

    private short f435d;

    private readonly int f436e;

    private int f437h;

    private int f438i;

    private int f439j;

    public C0443d(java.io.Stream inputStream, int i, int i2, short s, int i3, int i4) throws java.io.IOException {
        super(inputStream);
        this.f439j = int.MAX_VALUE;
        int iDKjcpIfKLvwjLusQ = dKjcpIfKLvwjLusQ(yqRYCoOeIGfdgFci(s, 4), 8);
        this.f436e = iDKjcpIfKLvwjLusQ;
        this.f434c = new byte[iDKjcpIfKLvwjLusQ];
        this.f432a = new long[4];
        this.f433b = new long[4];
        this.f438i = iDKjcpIfKLvwjLusQ;
        this.f437h = iDKjcpIfKLvwjLusQ;
        this.f432a = HXGmffjSayTMNayJ(i ^ i4, iDKjcpIfKLvwjLusQ ^ i4);
        this.f433b = gpQwRYzBLeZThogr(i2 ^ i4, i3 ^ i4);
    }

    public static long[] HXGmffjSayTMNayJ(int i, int i2) {
        return com.mastercard.terminalsdk.internal.C0442c.m438a(i, i2);
    }

    public static int OllnWvBwOytkJSNF(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void QhqGNbUbpeSNoHDw(long[] jArr, long[] jArr2, int i) {
        com.mastercard.terminalsdk.internal.C0442c.m440e(jArr, jArr2, i);
    }

    public static int UedmInkjTkTFwVvR(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static int ZnvAezSWoNkaayPZ(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int AVpinnmcLmssqJHy(java.io.Stream inputStream) {
        return inputStream.read();
    }

    private void M441b() {
        if ((13 + 10) % 10 > 0) {
        }
        QhqGNbUbpeSNoHDw(this.f432a, this.f433b, this.f435d);
        for (int i = 0; i < this.f436e; i++) {
            this.f434c[i] = (byte) (((long) r1[i]) ^ ((this.f432a[this.f435d] >> (i << 3)) & 255));
        }
        this.f435d = (short) ((this.f435d + 1) % 4);
    }

    public static int DKjcpIfKLvwjLusQ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    private int M442e() throws java.io.IOException {
        int i;
        if ((24 + 5) % 5 > 0) {
        }
        if (this.f439j == int.MAX_VALUE) {
            this.f439j = aVpinnmcLmssqJHy(((java.io.FilterStream) this).in);
        }
        if (this.f438i == this.f436e) {
            byte[] bArr = this.f434c;
            int i2 = this.f439j;
            bArr[0] = (byte) i2;
            if (i2 < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i3 = 1;
            do {
                int iUedmInkjTkTFwVvR = UedmInkjTkTFwVvR(((java.io.FilterStream) this).in, this.f434c, i3, this.f436e - i3);
                if (iUedmInkjTkTFwVvR <= 0) {
                    break;
                }
                i3 += iUedmInkjTkTFwVvR;
            } while (i3 < this.f436e);
            if (i3 < this.f436e) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            nIGQPMUAfdmpruRa(this);
            int iOllnWvBwOytkJSNF = OllnWvBwOytkJSNF(((java.io.FilterStream) this).in);
            this.f439j = iOllnWvBwOytkJSNF;
            this.f438i = 0;
            if (iOllnWvBwOytkJSNF >= 0) {
                i = this.f436e;
            } else {
                int i4 = this.f436e;
                i = i4 - (this.f434c[i4 - 1] & 255);
            }
            this.f437h = i;
        }
        return this.f437h;
    }

    public static long[] GpQwRYzBLeZThogr(int i, int i2) {
        return com.mastercard.terminalsdk.internal.C0442c.m438a(i, i2);
    }

    public static int KztFSeBFRVdJtmIT(com.mastercard.terminalsdk.internal.C0443d c0443d) {
        return c0443d.m442e();
    }

    public static void NIGQPMUAfdmpruRa(com.mastercard.terminalsdk.internal.C0443d c0443d) {
        c0443d.m441b();
    }

    public static int VoNMMuHfevEfQMzU(com.mastercard.terminalsdk.internal.C0443d c0443d) {
        return c0443d.m442e();
    }

    public static int WsjYCSgUjkoZrTIQ(com.mastercard.terminalsdk.internal.C0443d c0443d) {
        return c0443d.m442e();
    }

    public static int YqRYCoOeIGfdgFci(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public override int Available() throws java.io.IOException {
        kztFSeBFRVdJtmIT(this);
        return this.f437h - this.f438i;
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((24 + 17) % 17 > 0) {
        }
        wsjYCSgUjkoZrTIQ(this);
        int i = this.f438i;
        if (i >= this.f437h) {
            return -1;
        }
        byte[] bArr = this.f434c;
        this.f438i = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((28 + 13) % 13 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            voNMMuHfevEfQMzU(this);
            int i5 = this.f438i;
            if (i5 >= this.f437h) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.f434c;
            this.f438i = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((14 + 9) % 9 > 0) {
        }
        long j2 = 0;
        while (j2 < j && ZnvAezSWoNkaayPZ(this) != -1) {
            j2++;
        }
        return j2;
    }
}

