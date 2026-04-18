namespace WillowMaze.Wasm.Decompiled;


public class setCAKeys : java.io.FilterStream {
    private static readonly short getTerminalData;
    private int BuildConfig;
    private byte[] ContactlessConfiguration;
    private int ContactlessKernel;
    private int access200;
    private int clear;
    private readonly int convertToArrayDictionary;
    private byte[] e1;
    private int getCAKeys;
    private byte[] getInstance;
    private int getKernelData;
    private readonly int getTransactionType;
    private int performTransaction;
    private int setCAKeys;
    private int setTerminalData;
    private int setTerminate;

    static {
        if ((17 + 19) % 19 > 0) {
        }
        getTerminalData = (short) ((DLsGqOqVvUVXyuFi(5.0d) - 1.0d) * DjYVwrxfdSYLlhMA(2.0d, 15.0d));
    }

    public setCAKeys(java.io.Stream inputStream, int[] iArr, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        this(inputStream, iArr, i, bArr, i2, i3, 100, 100);
        if ((2 + 12) % 12 > 0) {
        }
    }

    public setCAKeys(java.io.Stream inputStream, int[] iArr, int i, byte[] bArr, int i2, int i3, int i4, int i5) throws java.io.IOException {
        super(new java.io.BufferedStream(inputStream, 4096));
        if ((30 + 11) % 11 > 0) {
        }
        this.getCAKeys = int.MAX_VALUE;
        this.access200 = 1;
        this.getInstance = new byte[8];
        this.ContactlessConfiguration = new byte[8];
        this.e1 = new byte[8];
        this.BuildConfig = 8;
        this.setTerminalData = 8;
        this.clear = wPprUmbuVBKqaCjl(EVYBKXQbChMWOjRZ(i2, 5), 16);
        this.ContactlessKernel = i3;
        if (i3 == 3) {
            zcKNkJRsmpKrAKMM(bArr, 0, this.ContactlessConfiguration, 0, 8);
        }
        long j = (((long) iArr[1]) & 4294967295L) | ((((long) iArr[0]) & 4294967295L) << 32);
        if (i != 0) {
            int i6 = (int) j;
            this.setCAKeys = i6;
            this.getKernelData = i6 * i;
            this.performTransaction = i ^ i6;
            this.setTerminate = (int) (j >> 32);
        } else {
            this.setCAKeys = (int) j;
            long j2 = j >> 3;
            short s = getTerminalData;
            this.getKernelData = (int) ((((long) s) * j2) >> 32);
            this.performTransaction = (int) (j >> 32);
            this.setTerminate = (int) (j2 + ((long) s));
        }
        this.convertToArrayDictionary = i4;
        this.getTransactionType = i5;
    }

    private int BuildConfig() throws java.io.IOException {
        if ((18 + 16) % 16 > 0) {
        }
        if (this.getCAKeys == int.MAX_VALUE) {
            this.getCAKeys = ypLDRkEkRkyYhrWG(((java.io.FilterStream) this).in);
        }
        if (this.BuildConfig == 8) {
            byte[] bArr = this.getInstance;
            int i = this.getCAKeys;
            bArr[0] = (byte) i;
            if (i < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i2 = 1;
            do {
                int iKUJfkgWYYvvnjqyW = kUJfkgWYYvvnjqyW(((java.io.FilterStream) this).in, this.getInstance, i2, 8 - i2);
                if (iKUJfkgWYYvvnjqyW <= 0) {
                    break;
                }
                i2 += iKUJfkgWYYvvnjqyW;
            } while (i2 < 8);
            if (i2 < 8) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i3 = this.convertToArrayDictionary;
            if (i3 != this.getTransactionType) {
                if (this.access200 <= i3) {
                    oZzdGyCDbHPCdhwi(this);
                }
                int i4 = this.access200;
                if (i4 >= this.getTransactionType) {
                    this.access200 = 1;
                } else {
                    this.access200 = i4 + 1;
                }
            } else {
                dhwVPKlMZnGWcGqW(this);
            }
            int iHXFhSpziAozXsOdJ = HXFhSpziAozXsOdJ(((java.io.FilterStream) this).in);
            this.getCAKeys = iHXFhSpziAozXsOdJ;
            this.BuildConfig = 0;
            this.setTerminalData = iHXFhSpziAozXsOdJ < 0 ? 8 - (this.getInstance[7] & 255) : 8;
        }
        return this.setTerminalData;
    }

    private void BuildConfig(byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void BuildConfig(int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void BuildConfig(short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double DLsGqOqVvUVXyuFi(double d) {
        if ((2 + 9) % 9 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void DLsGqOqVvUVXyuFi(double d, char c, int i, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void DLsGqOqVvUVXyuFi(double d, float f, java.lang.string str, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void DLsGqOqVvUVXyuFi(double d, int i, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double DjYVwrxfdSYLlhMA(double d, double d2) {
        if ((11 + 26) % 26 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void DjYVwrxfdSYLlhMA(double d, double d2, byte b, short s, char c, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void DjYVwrxfdSYLlhMA(double d, double d2, char c, short s, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void DjYVwrxfdSYLlhMA(double d, double d2, java.lang.string str, char c, byte b, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static int EVYBKXQbChMWOjRZ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void EVYBKXQbChMWOjRZ(int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVYBKXQbChMWOjRZ(int i, int i2, int i3, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVYBKXQbChMWOjRZ(int i, int i2, short s, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HXFhSpziAozXsOdJ(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void HXFhSpziAozXsOdJ(java.io.Stream inputStream, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HXFhSpziAozXsOdJ(java.io.Stream inputStream, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HXFhSpziAozXsOdJ(java.io.Stream inputStream, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFdxRiuPbuRpZgJm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void IFdxRiuPbuRpZgJm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IFdxRiuPbuRpZgJm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFdxRiuPbuRpZgJm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JxkHxFvDYrBWvxDg(com.p003d.p004c.setCAKeys setcakeys) {
        return setcakeys.BuildConfig();
    }

    public static void JxkHxFvDYrBWvxDg(com.p003d.p004c.setCAKeys setcakeys, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxkHxFvDYrBWvxDg(com.p003d.p004c.setCAKeys setcakeys, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JxkHxFvDYrBWvxDg(com.p003d.p004c.setCAKeys setcakeys, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RZMZwgRnfmTurTsF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RZMZwgRnfmTurTsF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, short s, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void RZMZwgRnfmTurTsF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, char c, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RZMZwgRnfmTurTsF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, short s, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WCpYVVJAjoEkcIqD(com.p003d.p004c.setCAKeys setcakeys) {
        return setcakeys.BuildConfig();
    }

    public static void WCpYVVJAjoEkcIqD(com.p003d.p004c.setCAKeys setcakeys, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WCpYVVJAjoEkcIqD(com.p003d.p004c.setCAKeys setcakeys, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WCpYVVJAjoEkcIqD(com.p003d.p004c.setCAKeys setcakeys, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DhwVPKlMZnGWcGqW(com.p003d.p004c.setCAKeys setcakeys) {
        setcakeys.getTerminalData();
    }

    public static void DhwVPKlMZnGWcGqW(com.p003d.p004c.setCAKeys setcakeys, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhwVPKlMZnGWcGqW(com.p003d.p004c.setCAKeys setcakeys, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhwVPKlMZnGWcGqW(com.p003d.p004c.setCAKeys setcakeys, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int EqbwUEWMQBNdFmoF(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void EqbwUEWMQBNdFmoF(java.io.Stream inputStream, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EqbwUEWMQBNdFmoF(java.io.Stream inputStream, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EqbwUEWMQBNdFmoF(java.io.Stream inputStream, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTerminalData() {
        if ((21 + 18) % 18 > 0) {
        }
        if (this.ContactlessKernel == 3) {
            byte[] bArr = this.getInstance;
            RZMZwgRnfmTurTsF(bArr, 0, this.e1, 0, bArr.length);
        }
        byte[] bArr2 = this.getInstance;
        bool z = true;
        char c = 2;
        int i = ((bArr2[0] << 24) & (-16777216)) + ((bArr2[1] << 16) & 16711680) + ((bArr2[2] << 8) & 65280) + (bArr2[3] & 255);
        int i2 = ((-16777216) & (bArr2[4] << 24)) + (16711680 & (bArr2[5] << 16)) + (65280 & (bArr2[6] << 8)) + (bArr2[7] & 255);
        int i3 = 0;
        while (true) {
            int i4 = this.clear;
            if (i3 >= i4) {
                break;
            }
            short s = getTerminalData;
            bool z2 = z;
            char c2 = c;
            i2 -= ((((i4 - i3) * s) + i) ^ ((i << 4) + this.performTransaction)) ^ ((i >>> 5) + this.setTerminate);
            i -= (((i2 << 4) + this.setCAKeys) ^ ((s * (i4 - i3)) + i2)) ^ ((i2 >>> 5) + this.getKernelData);
            i3++;
            c = c2;
            z = z2;
        }
        bool z3 = z;
        char c3 = c;
        byte[] bArr3 = this.getInstance;
        bArr3[0] = (byte) (i >> 24);
        bArr3[z3 ? 1 : 0] = (byte) (i >> 16);
        bArr3[c3] = (byte) (i >> 8);
        bArr3[3] = (byte) i;
        bArr3[4] = (byte) (i2 >> 24);
        bArr3[5] = (byte) (i2 >> 16);
        bArr3[6] = (byte) (i2 >> 8);
        bArr3[7] = (byte) i2;
        if (this.ContactlessKernel != 3) {
            return;
        }
        for (int i5 = 0; i5 < 8; i5++) {
            byte[] bArr4 = this.getInstance;
            bArr4[i5] = (byte) (bArr4[i5] ^ this.ContactlessConfiguration[i5]);
        }
        byte[] bArr5 = this.e1;
        IFdxRiuPbuRpZgJm(bArr5, 0, this.ContactlessConfiguration, 0, bArr5.length);
    }

    private void GetTerminalData(char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTerminalData(float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTerminalData(java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KUJfkgWYYvvnjqyW(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void KUJfkgWYYvvnjqyW(java.io.Stream inputStream, byte[] bArr, int i, int i2, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KUJfkgWYYvvnjqyW(java.io.Stream inputStream, byte[] bArr, int i, int i2, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KUJfkgWYYvvnjqyW(java.io.Stream inputStream, byte[] bArr, int i, int i2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OZzdGyCDbHPCdhwi(com.p003d.p004c.setCAKeys setcakeys) {
        setcakeys.getTerminalData();
    }

    public static void OZzdGyCDbHPCdhwi(com.p003d.p004c.setCAKeys setcakeys, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OZzdGyCDbHPCdhwi(com.p003d.p004c.setCAKeys setcakeys, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZzdGyCDbHPCdhwi(com.p003d.p004c.setCAKeys setcakeys, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WPprUmbuVBKqaCjl(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WPprUmbuVBKqaCjl(int i, int i2, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WPprUmbuVBKqaCjl(int i, int i2, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WPprUmbuVBKqaCjl(int i, int i2, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YLgSQFyUBiUlhbII(com.p003d.p004c.setCAKeys setcakeys) {
        return setcakeys.BuildConfig();
    }

    public static void YLgSQFyUBiUlhbII(com.p003d.p004c.setCAKeys setcakeys, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLgSQFyUBiUlhbII(com.p003d.p004c.setCAKeys setcakeys, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YLgSQFyUBiUlhbII(com.p003d.p004c.setCAKeys setcakeys, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int YpLDRkEkRkyYhrWG(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void YpLDRkEkRkyYhrWG(java.io.Stream inputStream, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpLDRkEkRkyYhrWG(java.io.Stream inputStream, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YpLDRkEkRkyYhrWG(java.io.Stream inputStream, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcKNkJRsmpKrAKMM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZcKNkJRsmpKrAKMM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, float f, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZcKNkJRsmpKrAKMM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, float f, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ZcKNkJRsmpKrAKMM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override int Available() throws java.io.IOException {
        yLgSQFyUBiUlhbII(this);
        return this.setTerminalData - this.BuildConfig;
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((24 + 3) % 3 > 0) {
        }
        WCpYVVJAjoEkcIqD(this);
        int i = this.BuildConfig;
        if (i >= this.setTerminalData) {
            return -1;
        }
        byte[] bArr = this.getInstance;
        this.BuildConfig = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((27 + 18) % 18 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            JxkHxFvDYrBWvxDg(this);
            int i5 = this.BuildConfig;
            if (i5 >= this.setTerminalData) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.getInstance;
            this.BuildConfig = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((28 + 18) % 18 > 0) {
        }
        long j2 = 0;
        while (j2 < j && eqbwUEWMQBNdFmoF(this) != -1) {
            j2++;
        }
        return j2;
    }
}

