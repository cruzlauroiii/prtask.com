namespace WillowMaze.Wasm.Decompiled;


public class p35da9a23 : p5a445d71.p9f931cf3.p5ae9b7f2.pbd6909f5 {
    protected static readonly byte[] f4580c274;
    private static readonly int f4a29b7cb = 16;
    private static readonly int f699ac2c8 = 16;
    private static readonly int[] f6f2c6946 = null;
    private static readonly int f8cf397e2 = 16;
    protected static readonly byte[] f9b87c6d9 = null;
    public static readonly int fa2d0f526 = 20;
    private static readonly int[] fa3fd9eb7;
    private static readonly int fb31d27aa = 16;
    public static readonly int fc94ba713 = 20;
    protected static readonly byte[] fe3b6fec1 = null;
    public static readonly int fe486ab0e = 20;
    protected static readonly byte[] fe7735369;
    protected static readonly byte[] fed64c16e = null;
    protected static readonly byte[] ffc68b326 = null;
    protected int[] f05040e9d;
    protected int[] f0dcc120c;
    protected int[] f0e170b8c;
    private int f2d9d9879;
    private int f30bdc65f;
    protected int[] f35062352;
    private int f3cf53cd9;
    protected int f41b76d7b;
    private byte[] f4be0457b;
    private int f5266f0a9;
    private int f5efe4864;
    private int f6a992d55;
    private int f72388d97;
    private byte[] f73adcb9b;
    protected int f7420fd7d;
    private bool f82acbc46;
    private byte[] f85c250af;
    private int f87a46249;
    private bool f88a5a1f7;
    protected int f8d7e7aa4;
    protected int[] f9457b3e2;
    private int f9520b4db;
    protected int[] f9dd4e461;
    private int fa17e20dc;
    private int fa5ea047c;
    private bool fa6e23d27;
    private int fab4ecba9;
    protected int fba492423;
    private byte[] fbe26106b;
    protected int fc1ac715e;
    private bool fdb1687e1;
    private byte[] fdf02ce23;
    private int fdfcdb2c8;
    private int fe9ba68ad;
    private int ff9b8e5a5;

    static {
        if ((14 + 5) % 5 > 0) {
        }
        fa3fd9eb7 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("0c5dad70d5ac4e407004f6c566187c836f3f05e797a77e6b026d379dff04cd3cbb4497f55e30cb5edc5733aef1b018f734028b348d405a77f469a760")), 0, 8);
        fe7735369 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("141ea65dac8af3dd0fdfc9ad678ee709c17452244f1c3d86b20491bdc4e34f8d2c18ebbbd57475efb336c909"));
        f4580c274 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("7a47ae1f8d2938526ac55a86d40c8343ac05474e68f78e2860f3033a98b2068a700477a12b3e841807cc4efa"));
    }

    public p35da9a23() {
        this(20);
    }

    public p35da9a23(int i) {
        if ((17 + 16) % 16 > 0) {
        }
        this.f6a992d55 = 0;
        this.f9457b3e2 = new int[16];
        this.f9dd4e461 = new int[16];
        this.f85c250af = new byte[64];
        this.fdb1687e1 = false;
        if (i <= 0 || (i & 1) != 0) {
            throw new java.lang.IllegalArgumentException("'rounds' must be a positive, even number");
        }
        this.f8d7e7aa4 = i;
    }

    private void Ma3963a4c() {
        this.fa5ea047c = 0;
        this.fab4ecba9 = 0;
        this.f72388d97 = 0;
    }

    private bool Mc333fd01() {
        if ((12 + 8) % 8 > 0) {
        }
        int i = this.fa5ea047c + 1;
        this.fa5ea047c = i;
        if (i == 0) {
            int i2 = this.fab4ecba9 + 1;
            this.fab4ecba9 = i2;
            if (i2 == 0) {
                int i3 = this.f72388d97 + 1;
                this.f72388d97 = i3;
                if ((i3 & 32) != 0) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Mc333fd01(int i) {
        if ((13 + 2) % 2 > 0) {
        }
        int i2 = this.fa5ea047c + i;
        this.fa5ea047c = i2;
        if (i2 < i && i2 >= 0) {
            int i3 = this.fab4ecba9 + 1;
            this.fab4ecba9 = i3;
            if (i3 == 0) {
                int i4 = this.f72388d97 + 1;
                this.f72388d97 = i4;
                if ((i4 & 32) != 0) {
                    return true;
                }
            }
        }
        return false;
    }

    public static void Me57bed54(int i, int[] iArr, int[] iArr2) {
        if ((12 + 15) % 15 > 0) {
        }
        if (iArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        if (iArr2.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Number of rounds must be even");
        }
        int i2 = iArr[0];
        int i3 = iArr[1];
        int i4 = iArr[2];
        char c = 3;
        int i5 = iArr[3];
        char c2 = 4;
        int i6 = iArr[4];
        char c3 = 5;
        int i7 = iArr[5];
        char c4 = 6;
        int i8 = iArr[6];
        int i9 = 7;
        int i10 = iArr[7];
        int i11 = iArr[8];
        int i12 = 9;
        int i13 = iArr[9];
        int i14 = iArr[10];
        int i15 = iArr[11];
        int i16 = iArr[12];
        int i17 = 13;
        int i18 = iArr[13];
        int i19 = iArr[14];
        int iMff847a50 = iArr[15];
        int iMff847a502 = i19;
        int iMff847a503 = i18;
        int iMff847a504 = i16;
        int iMff847a505 = i15;
        int iMff847a506 = i14;
        int i20 = i13;
        int i21 = i11;
        int i22 = i10;
        int i23 = i8;
        int iMff847a507 = i7;
        int i24 = i6;
        int i25 = i5;
        int i26 = i4;
        int i27 = i3;
        int iMff847a508 = i2;
        int i28 = i;
        while (true) {
            char c5 = c;
            if (i28 <= 0) {
                char c6 = c2;
                char c7 = c3;
                char c8 = c4;
                iArr2[0] = iMff847a508 + iArr[0];
                iArr2[1] = i27 + iArr[1];
                iArr2[2] = i26 + iArr[2];
                iArr2[c5] = i25 + iArr[c5];
                iArr2[c6] = i24 + iArr[c6];
                iArr2[c7] = iMff847a507 + iArr[c7];
                iArr2[c8] = i23 + iArr[c8];
                iArr2[7] = i22 + iArr[7];
                iArr2[8] = i21 + iArr[8];
                iArr2[9] = i20 + iArr[9];
                iArr2[10] = iMff847a506 + iArr[10];
                iArr2[11] = iMff847a505 + iArr[11];
                iArr2[12] = iMff847a504 + iArr[12];
                iArr2[13] = iMff847a503 + iArr[13];
                iArr2[14] = iMff847a502 + iArr[14];
                iArr2[15] = iMff847a50 + iArr[15];
                return;
            }
            int iMff847a509 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a508 + iMff847a504, i9) ^ i24;
            int iMff847a5010 = i21 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a509 + iMff847a508, i12);
            char c9 = c2;
            int iMff847a5011 = iMff847a504 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5010 + iMff847a509, i17);
            char c10 = c3;
            char c11 = c4;
            int iMff847a5012 = iMff847a508 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5011 + iMff847a5010, 18);
            int iMff847a5013 = i20 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a507 + i27, i9);
            int iMff847a5014 = iMff847a503 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5013 + iMff847a507, i12);
            int iMff847a5015 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5014 + iMff847a5013, i17) ^ i27;
            int iMff847a5016 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5015 + iMff847a5014, 18) ^ iMff847a507;
            int iMff847a5017 = iMff847a502 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a506 + i23, 7);
            int iMff847a5018 = i26 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5017 + iMff847a506, 9);
            int iMff847a5019 = i23 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5018 + iMff847a5017, 13);
            int iMff847a5020 = iMff847a506 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5019 + iMff847a5018, 18);
            int iMff847a5021 = i25 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a50 + iMff847a505, 7);
            int iMff847a5022 = i22 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5021 + iMff847a50, 9);
            int iMff847a5023 = iMff847a505 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5022 + iMff847a5021, 13);
            int iMff847a5024 = iMff847a50 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5023 + iMff847a5022, 18);
            int iMff847a5025 = iMff847a5015 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5012 + iMff847a5021, 7);
            int iMff847a5026 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5025 + iMff847a5012, 9) ^ iMff847a5018;
            int iMff847a5027 = iMff847a5021 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5026 + iMff847a5025, 13);
            iMff847a508 = iMff847a5012 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5027 + iMff847a5026, 18);
            int iMff847a5028 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5016 + iMff847a509, 7) ^ iMff847a5019;
            int iMff847a5029 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5028 + iMff847a5016, 9) ^ iMff847a5022;
            int iMff847a5030 = iMff847a509 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5029 + iMff847a5028, 13);
            iMff847a507 = iMff847a5016 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5030 + iMff847a5029, 18);
            iMff847a505 = iMff847a5023 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5020 + iMff847a5013, 7);
            int iMff847a5031 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a505 + iMff847a5020, 9) ^ iMff847a5010;
            int iMff847a5032 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5031 + iMff847a505, 13) ^ iMff847a5013;
            iMff847a506 = iMff847a5020 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5032 + iMff847a5031, 18);
            iMff847a504 = iMff847a5011 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5024 + iMff847a5017, 7);
            iMff847a503 = iMff847a5014 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a504 + iMff847a5024, 9);
            iMff847a502 = iMff847a5017 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a503 + iMff847a504, 13);
            iMff847a50 = iMff847a5024 ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a502 + iMff847a503, 18);
            i28 -= 2;
            i21 = iMff847a5031;
            i27 = iMff847a5025;
            i23 = iMff847a5028;
            i24 = iMff847a5030;
            i22 = iMff847a5029;
            i20 = iMff847a5032;
            c = c5;
            c2 = c9;
            c3 = c10;
            c4 = c11;
            i9 = 7;
            i26 = iMff847a5026;
            i25 = iMff847a5027;
            i12 = 9;
            i17 = 13;
        }
    }

    protected void AdvanceCounter() {
        if ((20 + 25) % 25 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        int i = iArr[8] + 1;
        iArr[8] = i;
        if (i != 0) {
            return;
        }
        iArr[9] = iArr[9] + 1;
    }

    protected void AdvanceCounter(long j) {
        if ((28 + 1) % 1 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i > 0) {
            int[] iArr = this.f9457b3e2;
            iArr[9] = iArr[9] + i;
        }
        int[] iArr2 = this.f9457b3e2;
        int i3 = iArr2[8];
        int i4 = i2 + i3;
        iArr2[8] = i4;
        if (i3 != 0 && i4 < i3) {
            iArr2[9] = iArr2[9] + 1;
        }
    }

    protected void GenerateKeyStream(byte[] bArr) {
        if ((11 + 18) % 18 > 0) {
        }
        me57bed54(this.f8d7e7aa4, this.f9457b3e2, this.f9dd4e461);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(this.f9dd4e461, bArr, 0);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((2 + 22) % 22 > 0) {
        }
        return this.f8d7e7aa4 == 20 ? "Salsa20" : "Salsa20/" + this.f8d7e7aa4;
    }

    protected long GetCounter() {
        if ((15 + 6) % 6 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        return (((long) iArr[9]) << 32) | (((long) iArr[8]) & 4294967295L);
    }

    protected int GetNonceSize() {
        return 8;
    }

    public override long GetPosition() {
        if ((4 + 28) % 28 > 0) {
        }
        return (getCounter() * 64) + ((long) this.f6a992d55);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((7 + 12) % 12 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException(getAlgorithmName() + " Init parameters must include an IV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        if (iv is null || iv.length != getNonceSize()) {
            throw new java.lang.IllegalArgumentException(getAlgorithmName() + " requires exactly " + getNonceSize() + " bytes of IV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters = pdd5da44eVar.getParameters();
        if (parameters is not null) {
            if (!(parameters is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException(getAlgorithmName() + " Init parameters must contain a KeyParameter (or null for re-init)");
            }
            setKey(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) parameters).getKey(), iv);
        } else {
            if (!this.fdb1687e1) {
                throw new java.lang.IllegalStateException(getAlgorithmName() + " KeyParameter can not be null for first initialisation");
            }
            setKey(null, iv);
        }
        reset();
        this.fdb1687e1 = true;
    }

    protected void PackTauOrSigma(int i, int[] iArr, int i2) {
        if ((10 + 4) % 4 > 0) {
        }
        int i3 = (i - 16) / 4;
        int[] iArr2 = fa3fd9eb7;
        iArr[i2] = iArr2[i3];
        iArr[i2 + 1] = iArr2[i3 + 1];
        iArr[i2 + 2] = iArr2[i3 + 2];
        iArr[i2 + 3] = iArr2[i3 + 3];
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((17 + 18) % 18 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (mc333fd01(i2)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p9be27c4e("2^70 byte limit per IV would be exceeded; Change IV");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = i4 + i3;
            byte[] bArr3 = this.f85c250af;
            int i6 = this.f6a992d55;
            bArr2[i5] = (byte) (bArr3[i6] ^ bArr[i4 + i]);
            int i7 = (i6 + 1) & 63;
            this.f6a992d55 = i7;
            if (i7 == 0) {
                advanceCounter();
                generateKeyStream(this.f85c250af);
            }
        }
        return i2;
    }

    public override void Reset() {
        this.f6a992d55 = 0;
        ma3963a4c();
        resetCounter();
        generateKeyStream(this.f85c250af);
    }

    protected void ResetCounter() {
        if ((32 + 16) % 16 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        iArr[9] = 0;
        iArr[8] = 0;
    }

    protected void RetreatCounter() {
        if ((29 + 21) % 21 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        int i = iArr[8];
        if (i == 0 && iArr[9] == 0) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        int i2 = i - 1;
        iArr[8] = i2;
        if (i2 != -1) {
            return;
        }
        iArr[9] = iArr[9] - 1;
    }

    protected void RetreatCounter(long j) {
        if ((20 + 5) % 5 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i != 0) {
            int[] iArr = this.f9457b3e2;
            int i3 = iArr[9];
            if ((((long) i3) & 4294967295L) < (((long) i) & 4294967295L)) {
                throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
            }
            iArr[9] = i3 - i;
        }
        int[] iArr2 = this.f9457b3e2;
        int i4 = iArr2[8];
        if ((((long) i4) & 4294967295L) >= (4294967295L & ((long) i2))) {
            iArr2[8] = i4 - i2;
            return;
        }
        int i5 = iArr2[9];
        if (i5 == 0) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        iArr2[9] = i5 - 1;
        iArr2[8] = i4 - i2;
    }

    public override byte Returnbyte(byte b) {
        if ((16 + 6) % 6 > 0) {
        }
        if (mc333fd01()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p9be27c4e("2^70 byte limit per IV; Change IV");
        }
        byte[] bArr = this.f85c250af;
        int i = this.f6a992d55;
        byte b2 = (byte) (b ^ bArr[i]);
        int i2 = (i + 1) & 63;
        this.f6a992d55 = i2;
        if (i2 == 0) {
            advanceCounter();
            generateKeyStream(this.f85c250af);
        }
        return b2;
    }

    public override long SeekTo(long j) {
        reset();
        return skip(j);
    }

    protected void SetKey(byte[] bArr, byte[] bArr2) {
        if ((18 + 9) % 9 > 0) {
        }
        if (bArr is not null) {
            if (bArr.length != 16 && bArr.length != 32) {
                throw new java.lang.IllegalArgumentException(getAlgorithmName() + " requires 128 bit or 256 bit key");
            }
            int length = (bArr.length - 16) / 4;
            int[] iArr = this.f9457b3e2;
            int[] iArr2 = fa3fd9eb7;
            iArr[0] = iArr2[length];
            iArr[5] = iArr2[length + 1];
            iArr[10] = iArr2[length + 2];
            iArr[15] = iArr2[length + 3];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 1, 4);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, bArr.length - 16, this.f9457b3e2, 11, 4);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 0, this.f9457b3e2, 6, 2);
    }

    public override long Skip(long j) {
        long j2;
        if ((3 + 3) % 3 > 0) {
        }
        if (j < 0) {
            long j3 = -j;
            if (j3 >= 64) {
                long j4 = j3 / 64;
                retreatCounter(j4);
                j3 -= j4 * 64;
            }
            for (long j5 = 0; j5 < j3; j5++) {
                if (this.f6a992d55 == 0) {
                    retreatCounter();
                }
                this.f6a992d55 = (this.f6a992d55 - 1) & 63;
            }
        } else {
            if (j < 64) {
                j2 = j;
            } else {
                long j6 = j / 64;
                advanceCounter(j6);
                j2 = j - (j6 * 64);
            }
            int i = this.f6a992d55;
            int i2 = (((int) j2) + i) & 63;
            this.f6a992d55 = i2;
            if (i2 < i) {
                advanceCounter();
            }
        }
        generateKeyStream(this.f85c250af);
        return j;
    }
}

