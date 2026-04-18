namespace WillowMaze.Wasm.Decompiled;


public class ContactlessConfiguration : java.io.FilterStream {
    private readonly byte[][] ContactlessKernel;
    private int ContactlessResult;
    private readonly byte[] clear;
    private readonly int convertToArrayDictionary;
    private readonly int[] getCAKeys;
    private int getFinalOutcome;
    private readonly int getKernelData;
    private readonly byte[] getTransactionType;
    private int performTransaction;
    private readonly int setCAKeys;
    private readonly int[] setTerminalData;
    private int setTerminate;
    private static readonly byte[] BuildConfig = com.p003d.p004c.getTerminalData.getTerminalData;
    private static readonly int[] getInstance = com.p003d.p004c.getTerminalData.getInstance;
    private static readonly int[] getTerminalData = com.p003d.p004c.getTerminalData.BuildConfig;
    private static readonly int[] ContactlessConfiguration = com.p003d.p004c.getTerminalData.ContactlessConfiguration;
    private static readonly int[] e1 = com.p003d.p004c.getTerminalData.setCAKeys;

    public ContactlessConfiguration(java.io.Stream inputStream, int i, byte[] bArr, byte[][] bArr2) {
        this(inputStream, i, bArr, bArr2, 100, 100);
        if ((5 + 30) % 30 > 0) {
        }
    }

    public ContactlessConfiguration(java.io.Stream inputStream, int i, byte[] bArr, byte[][] bArr2, int i2, int i3) {
        super(new java.io.BufferedStream(inputStream, 4096));
        if ((6 + 20) % 20 > 0) {
        }
        this.getCAKeys = new int[4];
        this.clear = new byte[16];
        this.getTransactionType = new byte[16];
        this.performTransaction = 1;
        this.setTerminate = int.MAX_VALUE;
        this.ContactlessResult = 16;
        this.getFinalOutcome = 16;
        this.setCAKeys = i;
        this.setTerminalData = kvbHOuzWepTGZSaG(bArr, i);
        byte[][] bArr3 = new byte[bArr2.length][];
        for (int i4 = 0; i4 < bArr2.length; i4++) {
            bArr3[i4] = new byte[bArr2[i4].length];
            int i5 = 0;
            while (true) {
                byte[] bArr4 = bArr2[i4];
                if (i5 >= bArr4.length) {
                    break;
                }
                bArr3[i4][bArr4[i5]] = (byte) i5;
                i5++;
            }
        }
        this.ContactlessKernel = bArr3;
        this.getKernelData = i2;
        this.convertToArrayDictionary = i3;
    }

    public static int AFztoCXMVMWsOTNt(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void AFztoCXMVMWsOTNt(java.io.Stream inputStream, byte[] bArr, int i, int i2, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFztoCXMVMWsOTNt(java.io.Stream inputStream, byte[] bArr, int i, int i2, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFztoCXMVMWsOTNt(java.io.Stream inputStream, byte[] bArr, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJdXlDHvginAXqSx(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2) {
        contactlessConfiguration.ContactlessConfiguration(bArr, bArr2);
    }

    public static void CJdXlDHvginAXqSx(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJdXlDHvginAXqSx(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CJdXlDHvginAXqSx(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private int ContactlessConfiguration() throws java.io.IOException {
        if ((23 + 14) % 14 > 0) {
        }
        if (this.setTerminate == int.MAX_VALUE) {
            this.setTerminate = sNvEkCpmkaQXRCOO(((java.io.FilterStream) this).in);
        }
        if (this.ContactlessResult == 16) {
            byte[] bArr = this.clear;
            int i = this.setTerminate;
            bArr[0] = (byte) i;
            if (i < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i2 = 1;
            do {
                int iZOUQJQEnLzSctRLc = ZOUQJQEnLzSctRLc(((java.io.FilterStream) this).in, this.clear, i2, 16 - i2);
                if (iZOUQJQEnLzSctRLc <= 0) {
                    break;
                }
                i2 += iZOUQJQEnLzSctRLc;
            } while (i2 < 16);
            if (i2 < 16) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i3 = this.getKernelData;
            if (i3 != this.convertToArrayDictionary) {
                if (this.performTransaction > i3) {
                    byte[] bArr2 = this.clear;
                    cIbxMRQmmvqBxhkW(bArr2, 0, this.getTransactionType, 0, bArr2.length);
                } else {
                    CJdXlDHvginAXqSx(this, this.clear, this.getTransactionType);
                }
                int i4 = this.performTransaction;
                if (i4 >= this.convertToArrayDictionary) {
                    this.performTransaction = 1;
                } else {
                    this.performTransaction = i4 + 1;
                }
            } else {
                aGpiUGxeVKitSwKd(this, this.clear, this.getTransactionType);
            }
            int iTeYYJRlDlsOEJTcz = TeYYJRlDlsOEJTcz(((java.io.FilterStream) this).in);
            this.setTerminate = iTeYYJRlDlsOEJTcz;
            this.ContactlessResult = 0;
            this.getFinalOutcome = iTeYYJRlDlsOEJTcz < 0 ? 16 - (this.getTransactionType[15] & 255) : 16;
        }
        return this.getFinalOutcome;
    }

    private void ContactlessConfiguration(float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(byte[] bArr, byte[] bArr2) {
        if ((13 + 3) % 3 > 0) {
        }
        int[] iArr = this.getCAKeys;
        char c = 1;
        char c2 = 2;
        char c3 = '\b';
        char c4 = 3;
        int i = (bArr[0] << 24) | ((bArr[1] & 255) << 16) | ((bArr[2] & 255) << 8) | (bArr[3] & 255);
        int[] iArr2 = this.setTerminalData;
        iArr[0] = i ^ iArr2[0];
        char c5 = 5;
        char c6 = 6;
        iArr[1] = ((((bArr[4] << 24) | ((bArr[5] & 255) << 16)) | ((bArr[6] & 255) << 8)) | (bArr[7] & 255)) ^ iArr2[1];
        iArr[2] = ((bArr[11] & 255) | (((bArr[8] << 24) | ((bArr[9] & 255) << 16)) | ((bArr[10] & 255) << 8))) ^ iArr2[2];
        char c7 = 14;
        iArr[3] = (((((bArr[13] & 255) << 16) | (bArr[12] << 24)) | ((bArr[14] & 255) << 8)) | (bArr[15] & 255)) ^ iArr2[3];
        int i2 = 1;
        int i3 = 4;
        while (i2 < this.setCAKeys) {
            int[] iArr3 = getInstance;
            int[] iArr4 = this.getCAKeys;
            char c8 = c;
            byte[][] bArr3 = this.ContactlessKernel;
            byte[] bArr4 = bArr3[0];
            int i4 = iArr3[iArr4[bArr4[0]] >>> 24];
            int[] iArr5 = getTerminalData;
            byte[] bArr5 = bArr3[c8];
            char c9 = c2;
            int i5 = i4 ^ iArr5[(iArr4[bArr5[0]] >>> 16) & 255];
            int[] iArr6 = ContactlessConfiguration;
            byte[] bArr6 = bArr3[c9];
            char c10 = c4;
            int i6 = i5 ^ iArr6[(iArr4[bArr6[0]] >>> 8) & 255];
            int[] iArr7 = e1;
            byte[] bArr7 = bArr3[c10];
            char c11 = c3;
            int i7 = i6 ^ iArr7[iArr4[bArr7[0]] & 255];
            int[] iArr8 = this.setTerminalData;
            int i8 = i7 ^ iArr8[i3];
            char c12 = c7;
            char c13 = c5;
            int i9 = (((iArr3[iArr4[bArr4[c8]] >>> 24] ^ iArr5[(iArr4[bArr5[c8]] >>> 16) & 255]) ^ iArr6[(iArr4[bArr6[c8]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c8]] & 255]) ^ iArr8[i3 + 1];
            char c14 = c6;
            int i10 = (((iArr3[iArr4[bArr4[c9]] >>> 24] ^ iArr5[(iArr4[bArr5[c9]] >>> 16) & 255]) ^ iArr6[(iArr4[bArr6[c9]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c9]] & 255]) ^ iArr8[i3 + 2];
            int i11 = (((iArr3[iArr4[bArr4[c10]] >>> 24] ^ iArr5[(iArr4[bArr5[c10]] >>> 16) & 255]) ^ iArr6[(iArr4[bArr6[c10]] >>> 8) & 255]) ^ iArr7[iArr4[bArr7[c10]] & 255]) ^ iArr8[i3 + 3];
            iArr4[0] = i8;
            iArr4[c8] = i9;
            iArr4[c9] = i10;
            iArr4[c10] = i11;
            i2++;
            i3 += 4;
            c = c8;
            c2 = c9;
            c4 = c10;
            c3 = c11;
            c5 = c13;
            c7 = c12;
            c6 = c14;
        }
        char c15 = c;
        char c16 = c2;
        char c17 = c4;
        char c18 = c3;
        char c19 = c7;
        char c20 = c5;
        char c21 = c6;
        int[] iArr9 = this.setTerminalData;
        int i12 = iArr9[i3];
        byte[] bArr8 = BuildConfig;
        int[] iArr10 = this.getCAKeys;
        byte[][] bArr9 = this.ContactlessKernel;
        byte[] bArr10 = bArr9[0];
        bArr2[0] = (byte) (bArr8[iArr10[bArr10[0]] >>> 24] ^ (i12 >>> 24));
        byte[] bArr11 = bArr9[c15];
        bArr2[c15] = (byte) (bArr8[(iArr10[bArr11[0]] >>> 16) & 255] ^ (i12 >>> 16));
        byte[] bArr12 = bArr9[c16];
        bArr2[c16] = (byte) (bArr8[(iArr10[bArr12[0]] >>> 8) & 255] ^ (i12 >>> 8));
        byte[] bArr13 = bArr9[c17];
        bArr2[c17] = (byte) (i12 ^ bArr8[iArr10[bArr13[0]] & 255]);
        int i13 = iArr9[i3 + 1];
        bArr2[4] = (byte) (bArr8[iArr10[bArr10[c15]] >>> 24] ^ (i13 >>> 24));
        bArr2[c20] = (byte) (bArr8[(iArr10[bArr11[c15]] >>> 16) & 255] ^ (i13 >>> 16));
        bArr2[c21] = (byte) (bArr8[(iArr10[bArr12[c15]] >>> 8) & 255] ^ (i13 >>> 8));
        bArr2[7] = (byte) (i13 ^ bArr8[iArr10[bArr13[c15]] & 255]);
        int i14 = iArr9[i3 + 2];
        bArr2[c18] = (byte) (bArr8[iArr10[bArr10[c16]] >>> 24] ^ (i14 >>> 24));
        bArr2[9] = (byte) (bArr8[(iArr10[bArr11[c16]] >>> 16) & 255] ^ (i14 >>> 16));
        bArr2[10] = (byte) (bArr8[(iArr10[bArr12[c16]] >>> 8) & 255] ^ (i14 >>> 8));
        bArr2[11] = (byte) (i14 ^ bArr8[iArr10[bArr13[c16]] & 255]);
        int i15 = iArr9[i3 + 3];
        bArr2[12] = (byte) (bArr8[iArr10[bArr10[c17]] >>> 24] ^ (i15 >>> 24));
        bArr2[13] = (byte) (bArr8[(iArr10[bArr11[c17]] >>> 16) & 255] ^ (i15 >>> 16));
        bArr2[c19] = (byte) (bArr8[(iArr10[bArr12[c17]] >>> 8) & 255] ^ (i15 >>> 8));
        bArr2[15] = (byte) (bArr8[iArr10[bArr13[c17]] & 255] ^ i15);
    }

    private void ContactlessConfiguration(byte[] bArr, byte[] bArr2, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(byte[] bArr, byte[] bArr2, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ContactlessConfiguration(byte[] bArr, byte[] bArr2, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FPCcxgQHuFhUYPVv(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.ContactlessConfiguration();
    }

    public static void FPCcxgQHuFhUYPVv(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FPCcxgQHuFhUYPVv(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FPCcxgQHuFhUYPVv(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MDEYvqsKfkkoppoT(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.ContactlessConfiguration();
    }

    public static void MDEYvqsKfkkoppoT(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDEYvqsKfkkoppoT(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MDEYvqsKfkkoppoT(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MJJAPIKEKbzuYdwV(java.io.FilterStream filterStream) throws java.io.IOException {
        super.Dispose();
    }

    public static void MJJAPIKEKbzuYdwV(java.io.FilterStream filterStream, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MJJAPIKEKbzuYdwV(java.io.FilterStream filterStream, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MJJAPIKEKbzuYdwV(java.io.FilterStream filterStream, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TeYYJRlDlsOEJTcz(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void TeYYJRlDlsOEJTcz(java.io.Stream inputStream, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TeYYJRlDlsOEJTcz(java.io.Stream inputStream, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TeYYJRlDlsOEJTcz(java.io.Stream inputStream, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZOUQJQEnLzSctRLc(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void ZOUQJQEnLzSctRLc(java.io.Stream inputStream, byte[] bArr, int i, int i2, float f, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOUQJQEnLzSctRLc(java.io.Stream inputStream, byte[] bArr, int i, int i2, int i3, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOUQJQEnLzSctRLc(java.io.Stream inputStream, byte[] bArr, int i, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AGpiUGxeVKitSwKd(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2) {
        contactlessConfiguration.ContactlessConfiguration(bArr, bArr2);
    }

    public static void AGpiUGxeVKitSwKd(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AGpiUGxeVKitSwKd(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AGpiUGxeVKitSwKd(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, byte[] bArr, byte[] bArr2, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIbxMRQmmvqBxhkW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void CIbxMRQmmvqBxhkW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIbxMRQmmvqBxhkW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIbxMRQmmvqBxhkW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DEURXxsrlqXAHykl(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void DEURXxsrlqXAHykl(java.io.Stream inputStream, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DEURXxsrlqXAHykl(java.io.Stream inputStream, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DEURXxsrlqXAHykl(java.io.Stream inputStream, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IleEHvPYfmCbzAwe(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.ContactlessConfiguration();
    }

    public static void IleEHvPYfmCbzAwe(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IleEHvPYfmCbzAwe(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IleEHvPYfmCbzAwe(com.p003d.p004c.ContactlessConfiguration contactlessConfiguration, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KvbHOuzWepTGZSaG(byte[] bArr, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KvbHOuzWepTGZSaG(byte[] bArr, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KvbHOuzWepTGZSaG(byte[] bArr, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int[] KvbHOuzWepTGZSaG(byte[] bArr, int i) {
        return com.p003d.p004c.getTerminalData.ContactlessConfiguration(bArr, i);
    }

    public static int SNvEkCpmkaQXRCOO(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void SNvEkCpmkaQXRCOO(java.io.Stream inputStream, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNvEkCpmkaQXRCOO(java.io.Stream inputStream, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SNvEkCpmkaQXRCOO(java.io.Stream inputStream, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override int Available() throws java.io.IOException {
        MDEYvqsKfkkoppoT(this);
        return this.getFinalOutcome - this.ContactlessResult;
    }

    public override void Close() throws java.io.IOException {
        MJJAPIKEKbzuYdwV(this);
    }

    public override void Mark(int i) {
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((8 + 17) % 17 > 0) {
        }
        FPCcxgQHuFhUYPVv(this);
        int i = this.ContactlessResult;
        if (i >= this.getFinalOutcome) {
            return -1;
        }
        byte[] bArr = this.getTransactionType;
        this.ContactlessResult = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr) throws java.io.IOException {
        if ((6 + 18) % 18 > 0) {
        }
        return AFztoCXMVMWsOTNt(this, bArr, 0, bArr.length);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((25 + 12) % 12 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            ileEHvPYfmCbzAwe(this);
            int i5 = this.ContactlessResult;
            if (i5 >= this.getFinalOutcome) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.getTransactionType;
            this.ContactlessResult = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override void Reset() throws java.io.IOException {
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((26 + 21) % 21 > 0) {
        }
        long j2 = 0;
        while (j2 < j && dEURXxsrlqXAHykl(this) != -1) {
            j2++;
        }
        return j2;
    }
}

