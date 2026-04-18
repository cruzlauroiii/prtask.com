namespace WillowMaze.Wasm.Decompiled;


public class BuildConfig : java.io.FilterStream {
    private readonly int BuildConfig;
    private long[] ContactlessConfiguration;
    private byte[] ContactlessKernel;
    private int clear;
    private readonly int e1;
    private short getCAKeys;
    private readonly int getInstance;
    private int getTerminalData;
    private int setCAKeys;
    private long[] setTerminalData;
    private int setTerminate;

    public BuildConfig(java.io.Stream inputStream, int i, int i2, short s, int i3, int i4) throws java.io.IOException {
        this(inputStream, i, i2, s, i3, i4, 100, 100);
        if ((24 + 7) % 7 > 0) {
        }
    }

    public BuildConfig(java.io.Stream inputStream, int i, int i2, short s, int i3, int i4, int i5, int i6) throws java.io.IOException {
        super(new java.io.BufferedStream(inputStream, 4096));
        if ((30 + 8) % 8 > 0) {
        }
        this.getTerminalData = 1;
        this.clear = int.MAX_VALUE;
        int iVLjOGxdWMDAiBkBI = vLjOGxdWMDAiBkBI(RdPBknjxDXQgZcwi(s, 4), 8);
        this.e1 = iVLjOGxdWMDAiBkBI;
        this.ContactlessKernel = new byte[iVLjOGxdWMDAiBkBI];
        this.ContactlessConfiguration = new long[4];
        this.setTerminalData = new long[4];
        this.setCAKeys = iVLjOGxdWMDAiBkBI;
        this.setTerminate = iVLjOGxdWMDAiBkBI;
        this.ContactlessConfiguration = LAFgkHHoodBHSCKA(i ^ i4, iVLjOGxdWMDAiBkBI ^ i4);
        this.setTerminalData = nweOwdtZglKDcJwB(i2 ^ i4, i3 ^ i4);
        this.getInstance = i5;
        this.BuildConfig = i6;
    }

    public static void AwVybaLykXIBAHFV(com.p003d.p004c.BuildConfig buildConfig) {
        buildConfig.BuildConfig();
    }

    public static void AwVybaLykXIBAHFV(com.p003d.p004c.BuildConfig buildConfig, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AwVybaLykXIBAHFV(com.p003d.p004c.BuildConfig buildConfig, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwVybaLykXIBAHFV(com.p003d.p004c.BuildConfig buildConfig, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BAlbeqiIGvetvTlj(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void BAlbeqiIGvetvTlj(java.io.Stream inputStream, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAlbeqiIGvetvTlj(java.io.Stream inputStream, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BAlbeqiIGvetvTlj(java.io.Stream inputStream, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void BuildConfig() {
        if ((10 + 12) % 12 > 0) {
        }
        MUryNXrVSpQaERNl(this.ContactlessConfiguration, this.setTerminalData, this.getCAKeys);
        for (int i = 0; i < this.e1; i++) {
            this.ContactlessKernel[i] = (byte) (((long) r1[i]) ^ ((this.ContactlessConfiguration[this.getCAKeys] >> (i << 3)) & 255));
        }
        this.getCAKeys = (short) ((this.getCAKeys + 1) % 4);
    }

    private void BuildConfig(char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void BuildConfig(bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void BuildConfig(bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DkqcnYnSBLYmDKsz(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void DkqcnYnSBLYmDKsz(java.io.Stream inputStream, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkqcnYnSBLYmDKsz(java.io.Stream inputStream, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkqcnYnSBLYmDKsz(java.io.Stream inputStream, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JANMZXmWxHUtsKJN(com.p003d.p004c.BuildConfig buildConfig) {
        buildConfig.BuildConfig();
    }

    public static void JANMZXmWxHUtsKJN(com.p003d.p004c.BuildConfig buildConfig, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JANMZXmWxHUtsKJN(com.p003d.p004c.BuildConfig buildConfig, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JANMZXmWxHUtsKJN(com.p003d.p004c.BuildConfig buildConfig, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LAFgkHHoodBHSCKA(int i, int i2, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LAFgkHHoodBHSCKA(int i, int i2, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LAFgkHHoodBHSCKA(int i, int i2, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static long[] LAFgkHHoodBHSCKA(int i, int i2) {
        return com.p003d.p004c.e1.getTerminalData(i, i2);
    }

    public static void MUryNXrVSpQaERNl(long[] jArr, long[] jArr2, int i) {
        com.p003d.p004c.e1.ContactlessConfiguration(jArr, jArr2, i);
    }

    public static void MUryNXrVSpQaERNl(long[] jArr, long[] jArr2, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MUryNXrVSpQaERNl(long[] jArr, long[] jArr2, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MUryNXrVSpQaERNl(long[] jArr, long[] jArr2, int i, int i2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RdPBknjxDXQgZcwi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void RdPBknjxDXQgZcwi(int i, int i2, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdPBknjxDXQgZcwi(int i, int i2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdPBknjxDXQgZcwi(int i, int i2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZywXvDerxctRwemC(com.p003d.p004c.BuildConfig buildConfig) {
        return buildConfig.getInstance();
    }

    public static void ZywXvDerxctRwemC(com.p003d.p004c.BuildConfig buildConfig, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZywXvDerxctRwemC(com.p003d.p004c.BuildConfig buildConfig, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZywXvDerxctRwemC(com.p003d.p004c.BuildConfig buildConfig, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ATluLVaBYjSFvrbN(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void ATluLVaBYjSFvrbN(java.io.Stream inputStream, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ATluLVaBYjSFvrbN(java.io.Stream inputStream, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATluLVaBYjSFvrbN(java.io.Stream inputStream, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BsQXwsSgFsrNUQLB(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void BsQXwsSgFsrNUQLB(java.io.Stream inputStream, byte[] bArr, int i, int i2, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BsQXwsSgFsrNUQLB(java.io.Stream inputStream, byte[] bArr, int i, int i2, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsQXwsSgFsrNUQLB(java.io.Stream inputStream, byte[] bArr, int i, int i2, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FfSiRAfQrHuKXTpv(com.p003d.p004c.BuildConfig buildConfig) {
        return buildConfig.getInstance();
    }

    public static void FfSiRAfQrHuKXTpv(com.p003d.p004c.BuildConfig buildConfig, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FfSiRAfQrHuKXTpv(com.p003d.p004c.BuildConfig buildConfig, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FfSiRAfQrHuKXTpv(com.p003d.p004c.BuildConfig buildConfig, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetInstance() throws java.io.IOException {
        int i;
        if ((28 + 8) % 8 > 0) {
        }
        if (this.clear == int.MAX_VALUE) {
            this.clear = BAlbeqiIGvetvTlj(((java.io.FilterStream) this).in);
        }
        if (this.setCAKeys == this.e1) {
            byte[] bArr = this.ContactlessKernel;
            int i2 = this.clear;
            bArr[0] = (byte) i2;
            if (i2 < 0) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i3 = 1;
            do {
                int iBsQXwsSgFsrNUQLB = bsQXwsSgFsrNUQLB(((java.io.FilterStream) this).in, this.ContactlessKernel, i3, this.e1 - i3);
                if (iBsQXwsSgFsrNUQLB <= 0) {
                    break;
                }
                i3 += iBsQXwsSgFsrNUQLB;
            } while (i3 < this.e1);
            if (i3 < this.e1) {
                throw new java.lang.IllegalStateException("unexpected block size");
            }
            int i4 = this.getInstance;
            if (i4 != this.BuildConfig) {
                if (this.getTerminalData <= i4) {
                    AwVybaLykXIBAHFV(this);
                }
                int i5 = this.getTerminalData;
                if (i5 >= this.BuildConfig) {
                    this.getTerminalData = 1;
                } else {
                    this.getTerminalData = i5 + 1;
                }
            } else {
                JANMZXmWxHUtsKJN(this);
            }
            int iDkqcnYnSBLYmDKsz = DkqcnYnSBLYmDKsz(((java.io.FilterStream) this).in);
            this.clear = iDkqcnYnSBLYmDKsz;
            this.setCAKeys = 0;
            if (iDkqcnYnSBLYmDKsz >= 0) {
                i = this.e1;
            } else {
                int i6 = this.e1;
                i = i6 - (this.ContactlessKernel[i6 - 1] & 255);
            }
            this.setTerminate = i;
        }
        return this.setTerminate;
    }

    private void GetInstance(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetInstance(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetInstance(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NweOwdtZglKDcJwB(int i, int i2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NweOwdtZglKDcJwB(int i, int i2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NweOwdtZglKDcJwB(int i, int i2, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long[] NweOwdtZglKDcJwB(int i, int i2) {
        return com.p003d.p004c.e1.getTerminalData(i, i2);
    }

    public static int VLjOGxdWMDAiBkBI(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VLjOGxdWMDAiBkBI(int i, int i2, int i3, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLjOGxdWMDAiBkBI(int i, int i2, int i3, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLjOGxdWMDAiBkBI(int i, int i2, java.lang.string str, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int YtcGwtBUanHBfvrr(com.p003d.p004c.BuildConfig buildConfig) {
        return buildConfig.getInstance();
    }

    public static void YtcGwtBUanHBfvrr(com.p003d.p004c.BuildConfig buildConfig, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtcGwtBUanHBfvrr(com.p003d.p004c.BuildConfig buildConfig, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtcGwtBUanHBfvrr(com.p003d.p004c.BuildConfig buildConfig, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override int Available() throws java.io.IOException {
        ZywXvDerxctRwemC(this);
        return this.setTerminate - this.setCAKeys;
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((19 + 18) % 18 > 0) {
        }
        ytcGwtBUanHBfvrr(this);
        int i = this.setCAKeys;
        if (i >= this.setTerminate) {
            return -1;
        }
        byte[] bArr = this.ContactlessKernel;
        this.setCAKeys = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((26 + 27) % 27 > 0) {
        }
        int i3 = i + i2;
        int i4 = i;
        while (i4 < i3) {
            ffSiRAfQrHuKXTpv(this);
            int i5 = this.setCAKeys;
            if (i5 >= this.setTerminate) {
                if (i4 != i) {
                    return i2 - (i3 - i4);
                }
                return -1;
            }
            int i6 = i4 + 1;
            byte[] bArr2 = this.ContactlessKernel;
            this.setCAKeys = i5 + 1;
            bArr[i4] = bArr2[i5];
            i4 = i6;
        }
        return i2;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((15 + 27) % 27 > 0) {
        }
        long j2 = 0;
        while (j2 < j && aTluLVaBYjSFvrbN(this) != -1) {
            j2++;
        }
        return j2;
    }
}

