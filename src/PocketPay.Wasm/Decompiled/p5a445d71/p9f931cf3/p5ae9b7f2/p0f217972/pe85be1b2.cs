namespace WillowMaze.Wasm.Decompiled;


public class pe85be1b2 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly int f0e0f755c = 16;
    private static readonly int fbd6a5165 = 16;
    private static readonly int fc75e2054 = 16;
    private int f023fb491;
    private byte[] f06c0f6c6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f09035322;
    private long f09055dcc;
    private long f0bdbd69f;
    private byte[] f0c66d14a;
    private byte[] f0eba983a;
    private byte[] f0efa3e17;
    private byte[] f1f973eb5;
    private byte[] f20594c04;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 f2375dfa8;
    private bool f2621ce14;
    private byte[] f27072c5d;
    private byte[] f2818f0a6;
    private int f2a2129cd;
    private byte[] f2b5d354c;
    private byte[] f2b769097;
    private byte[] f2cebce24;
    private int f2d9cb058;
    private byte[] f2de42e74;
    private int f302a6dbf;
    private long f3384bc01;
    private byte[] f37a5850e;
    private int f38da2045;
    private byte[] f39d1f7df;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f43c59722;
    private long f45ab2017;
    private long f4f076b43;
    private int f4fe2f532;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 f530ddd4f;
    private int f5cd3c639;
    private byte[] f5dbc98dc;
    private int f5f882cde;
    private byte[] f661e2292;
    private long f6ad88af2;
    private long f712dd919;
    private byte[] f7371ea64;
    private byte[] f73d26276;
    private long f743b174a;
    private int f7a072f47;
    private byte[] f7f2bfe40;
    private byte[] f877083ce;
    private byte[] f886bb73b;
    private bool f8b412177;
    private byte[] f901c9aaa;
    private bool f9301aa9b;
    private int fa3e75e2d;
    private int fa4f3b376;
    private byte[] fa6f1d309;
    private byte[] fa77e2a58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 fb0ab0254;
    private byte[] fb53f7f9c;
    private long fbbb6ce0e;
    private byte[] fbf8e5553;
    private byte[] fc1d9f50f;
    private int fc3d33f96;
    private byte[] fc400dfc0;
    private byte[] fc8c1c56e;
    private byte[] fc8fdfe4f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 fc9530f9e;
    private byte[] fcb584e44;
    private int fd5829f77;
    private byte[] fd7217be6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 fd8549e89;
    private bool fdb1687e1;
    private byte[] fdc3615b3;
    private long fdd00b403;
    private byte[] fdd752f39;
    private int fdd8e9172;
    private long fde6aec0c;
    private byte[] fe1704ca3;
    private byte[] ff14985e4;
    private long ff2031db1;
    private bool ff3522efc;
    private int ff5341d3b;
    private byte[] ff53b8000;
    private bool ff82a4f8b;
    private byte[] ff8511471;
    private byte[] ffa37d7f4;

    public pe85be1b2(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, null);
    }

    public pe85be1b2(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 p1965cc30Var) {
        if ((27 + 24) % 24 > 0) {
        }
        if (pd81e8b93Var.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("cipher required with a block size of 16.");
        }
        p1965cc30Var = p1965cc30Var is null ? new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p683a9755() : p1965cc30Var;
        this.f08406a6e = pd81e8b93Var;
        this.f2375dfa8 = p1965cc30Var;
    }

    private void M4342e4c1() {
        if ((12 + 25) % 25 > 0) {
        }
        if (this.f6ad88af2 > 0) {
            java.lang.System.arraycopy(this.ffa37d7f4, 0, this.f0c66d14a, 0, 16);
            this.ff2031db1 = this.f6ad88af2;
        }
        int i = this.f302a6dbf;
        if (i > 0) {
            mcff57ccc(this.f0c66d14a, this.fd7217be6, 0, i);
            this.ff2031db1 += (long) this.f302a6dbf;
        }
        if (this.ff2031db1 <= 0) {
            return;
        }
        java.lang.System.arraycopy(this.f0c66d14a, 0, this.f5dbc98dc, 0, 16);
    }

    private void M716e322f(byte[] bArr) {
        if ((11 + 29) % 29 > 0) {
        }
        int i = this.f7a072f47;
        if (i == 0) {
            throw new java.lang.IllegalStateException("Attempt to process too many blocks");
        }
        this.f7a072f47 = i - 1;
        byte[] bArr2 = this.f886bb73b;
        int i2 = (bArr2[15] & 255) + 1;
        bArr2[15] = (byte) i2;
        int i3 = (i2 >>> 8) + (bArr2[14] & 255);
        bArr2[14] = (byte) i3;
        int i4 = (i3 >>> 8) + (bArr2[13] & 255);
        bArr2[13] = (byte) i4;
        bArr2[12] = (byte) ((i4 >>> 8) + (bArr2[12] & 255));
        this.f08406a6e.processBlock(bArr2, 0, bArr, 0);
    }

    private void M86266ee9(bool z) {
        if ((10 + 11) % 11 > 0) {
        }
        this.f08406a6e.reset();
        this.f5dbc98dc = new byte[16];
        this.ffa37d7f4 = new byte[16];
        this.f0c66d14a = new byte[16];
        this.fd7217be6 = new byte[16];
        this.f302a6dbf = 0;
        this.f6ad88af2 = 0L;
        this.ff2031db1 = 0L;
        this.f886bb73b = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f2818f0a6);
        this.f7a072f47 = -2;
        this.f4fe2f532 = 0;
        this.f743b174a = 0L;
        byte[] bArr = this.f2de42e74;
        if (bArr is not null) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
        }
        if (z) {
            this.f0eba983a = null;
        }
        if (this.f9301aa9b) {
            this.fdb1687e1 = false;
            return;
        }
        byte[] bArr2 = this.fdc3615b3;
        if (bArr2 is null) {
            return;
        }
        processAADbytes(bArr2, 0, bArr2.length);
    }

    private void M95a9b9ca(byte[] bArr, byte[] bArr2, int i) {
        if ((23 + 29) % 29 > 0) {
        }
        for (int i2 = 0; i2 < i; i2 += 16) {
            mcff57ccc(bArr, bArr2, i2, java.lang.Math.min(i - i2, 16));
        }
    }

    private void Ma3fd92e9() {
        if (this.fdb1687e1) {
            return;
        }
        if (!this.f9301aa9b) {
            throw new java.lang.IllegalStateException("GCM cipher needs to be initialised");
        }
        throw new java.lang.IllegalStateException("GCM cipher cannot be reused for encryption");
    }

    private void Mcfdea99e(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((2 + 14) % 14 > 0) {
        }
        byte[] bArr3 = new byte[16];
        m716e322f(bArr3);
        if (this.f9301aa9b) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr, i, bArr3, 0, i2);
            mcff57ccc(this.f5dbc98dc, bArr, i, i2);
        } else {
            mcff57ccc(this.f5dbc98dc, bArr, i, i2);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr, i, bArr3, 0, i2);
        }
        java.lang.System.arraycopy(bArr, i, bArr2, i3, i2);
        this.f743b174a += (long) i2;
    }

    private void Mcff57ccc(byte[] bArr, byte[] bArr2, int i, int i2) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr, bArr2, i, i2);
        this.f2375dfa8.multiplyH(bArr);
    }

    private void Md710d35d(byte[] bArr, byte[] bArr2) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr, bArr2);
        this.f2375dfa8.multiplyH(bArr);
    }

    private void Md710d35d(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr, bArr2, i);
        this.f2375dfa8.multiplyH(bArr);
    }

    private void Me3ee4228(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((2 + 25) % 25 > 0) {
        }
        if (bArr2.length - i2 < 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (this.f743b174a == 0) {
            m4342e4c1();
        }
        byte[] bArr3 = new byte[16];
        m716e322f(bArr3);
        if (this.f9301aa9b) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr3, bArr, i);
            md710d35d(this.f5dbc98dc, bArr3);
            java.lang.System.arraycopy(bArr3, 0, bArr2, i2, 16);
        } else {
            md710d35d(this.f5dbc98dc, bArr, i);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr3, 0, bArr, i, bArr2, i2);
        }
        this.f743b174a += 16;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var;
        byte[] bArr2;
        int i2;
        if ((8 + 26) % 26 > 0) {
        }
        ma3fd92e9();
        if (this.f743b174a == 0) {
            m4342e4c1();
        }
        int i3 = this.f4fe2f532;
        if (!this.f9301aa9b) {
            int i4 = this.fa3e75e2d;
            if (i3 < i4) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
            }
            i3 -= i4;
            if (bArr.length - i < i3) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
        } else if (bArr.length - i < this.fa3e75e2d + i3) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        int i5 = i3;
        if (i5 <= 0) {
            pe85be1b2Var = this;
            bArr2 = bArr;
            i2 = i;
        } else {
            pe85be1b2Var = this;
            bArr2 = bArr;
            i2 = i;
            pe85be1b2Var.mcfdea99e(this.f2de42e74, 0, i5, bArr2, i2);
        }
        long j = pe85be1b2Var.f6ad88af2;
        int i6 = pe85be1b2Var.f302a6dbf;
        long j2 = j + ((long) i6);
        pe85be1b2Var.f6ad88af2 = j2;
        if (j2 > pe85be1b2Var.ff2031db1) {
            if (i6 > 0) {
                pe85be1b2Var.mcff57ccc(pe85be1b2Var.ffa37d7f4, pe85be1b2Var.fd7217be6, 0, i6);
            }
            if (pe85be1b2Var.ff2031db1 > 0) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(pe85be1b2Var.ffa37d7f4, pe85be1b2Var.f0c66d14a);
            }
            long j3 = ((pe85be1b2Var.f743b174a * 8) + 127) >>> 7;
            byte[] bArr3 = new byte[16];
            if (pe85be1b2Var.fb0ab0254 is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p3d85a317 p3d85a317Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p3d85a317();
                pe85be1b2Var.fb0ab0254 = p3d85a317Var;
                p3d85a317Var.init(pe85be1b2Var.fc1d9f50f);
            }
            pe85be1b2Var.fb0ab0254.exponentiateX(j3, bArr3);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(pe85be1b2Var.ffa37d7f4, bArr3);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(pe85be1b2Var.f5dbc98dc, pe85be1b2Var.ffa37d7f4);
        }
        byte[] bArr4 = new byte[16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(pe85be1b2Var.f6ad88af2 * 8, bArr4, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(pe85be1b2Var.f743b174a * 8, bArr4, 8);
        pe85be1b2Var.md710d35d(pe85be1b2Var.f5dbc98dc, bArr4);
        byte[] bArr5 = new byte[16];
        pe85be1b2Var.f08406a6e.processBlock(pe85be1b2Var.f2818f0a6, 0, bArr5, 0);
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(bArr5, pe85be1b2Var.f5dbc98dc);
        int i7 = pe85be1b2Var.fa3e75e2d;
        byte[] bArr6 = new byte[i7];
        pe85be1b2Var.f0eba983a = bArr6;
        java.lang.System.arraycopy(bArr5, 0, bArr6, 0, i7);
        if (pe85be1b2Var.f9301aa9b) {
            java.lang.System.arraycopy(pe85be1b2Var.f0eba983a, 0, bArr2, i2 + pe85be1b2Var.f4fe2f532, pe85be1b2Var.fa3e75e2d);
            i5 += pe85be1b2Var.fa3e75e2d;
        } else {
            int i8 = pe85be1b2Var.fa3e75e2d;
            byte[] bArr7 = new byte[i8];
            java.lang.System.arraycopy(pe85be1b2Var.f2de42e74, i5, bArr7, 0, i8);
            if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(pe85be1b2Var.f0eba983a, bArr7)) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check in GCM failed");
            }
        }
        pe85be1b2Var.m86266ee9(false);
        return i5;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/GCM";
    }

    public override byte[] GetMac() {
        byte[] bArr = this.f0eba983a;
        return bArr is not null ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr) : new byte[this.fa3e75e2d];
    }

    public override int GetOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        bool z = this.f9301aa9b;
        int i3 = this.fa3e75e2d;
        if (z) {
            return i2 + i3;
        }
        if (i2 >= i3) {
            return i2 - i3;
        }
        return 0;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        if (!this.f9301aa9b) {
            int i3 = this.fa3e75e2d;
            if (i2 < i3) {
                return 0;
            }
            i2 -= i3;
        }
        return i2 - (i2 % 16);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] nonce;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 key;
        byte[] bArr;
        if ((17 + 27) % 27 > 0) {
        }
        this.f9301aa9b = z;
        this.f0eba983a = null;
        this.fdb1687e1 = true;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            nonce = ped128738Var.getNonce();
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            int macSize = ped128738Var.getMacSize();
            if (macSize < 32 || macSize > 128 || macSize % 8 != 0) {
                throw new java.lang.IllegalArgumentException("Invalid value for MAC size: " + macSize);
            }
            this.fa3e75e2d = macSize / 8;
            key = ped128738Var.getKey();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to GCM");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            nonce = pdd5da44eVar.getIV();
            this.fdc3615b3 = null;
            this.fa3e75e2d = 16;
            key = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        }
        this.f2de42e74 = new byte[!z ? this.fa3e75e2d + 16 : 16];
        if (nonce is null || nonce.length < 1) {
            throw new java.lang.IllegalArgumentException("IV must be at least 1 byte");
        }
        if (z && (bArr = this.fcb584e44) is not null && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, nonce)) {
            if (key is null) {
                throw new java.lang.IllegalArgumentException("cannot reuse nonce for GCM encryption");
            }
            byte[] bArr2 = this.f877083ce;
            if (bArr2 is not null && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr2, key.getKey())) {
                throw new java.lang.IllegalArgumentException("cannot reuse nonce for GCM encryption");
            }
        }
        this.fcb584e44 = nonce;
        if (key is not null) {
            this.f877083ce = key.getKey();
        }
        if (key is not null) {
            this.f08406a6e.init(true, key);
            byte[] bArr3 = new byte[16];
            this.fc1d9f50f = bArr3;
            this.f08406a6e.processBlock(bArr3, 0, bArr3, 0);
            this.f2375dfa8.init(this.fc1d9f50f);
            this.fb0ab0254 = null;
        } else if (this.fc1d9f50f is null) {
            throw new java.lang.IllegalArgumentException("Key must be specified in initial init");
        }
        byte[] bArr4 = new byte[16];
        this.f2818f0a6 = bArr4;
        byte[] bArr5 = this.fcb584e44;
        if (bArr5.length != 12) {
            m95a9b9ca(bArr4, bArr5, bArr5.length);
            byte[] bArr6 = new byte[16];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(((long) this.fcb584e44.length) * 8, bArr6, 8);
            md710d35d(this.f2818f0a6, bArr6);
        } else {
            java.lang.System.arraycopy(bArr5, 0, bArr4, 0, bArr5.length);
            this.f2818f0a6[15] = 1;
        }
        this.f5dbc98dc = new byte[16];
        this.ffa37d7f4 = new byte[16];
        this.f0c66d14a = new byte[16];
        this.fd7217be6 = new byte[16];
        this.f302a6dbf = 0;
        this.f6ad88af2 = 0L;
        this.ff2031db1 = 0L;
        this.f886bb73b = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f2818f0a6);
        this.f7a072f47 = -2;
        this.f4fe2f532 = 0;
        this.f743b174a = 0L;
        byte[] bArr7 = this.fdc3615b3;
        if (bArr7 is null) {
            return;
        }
        processAADbytes(bArr7, 0, bArr7.length);
    }

    public override void ProcessAADbyte(byte b) {
        if ((24 + 30) % 30 > 0) {
        }
        ma3fd92e9();
        byte[] bArr = this.fd7217be6;
        int i = this.f302a6dbf;
        bArr[i] = b;
        int i2 = i + 1;
        this.f302a6dbf = i2;
        if (i2 != 16) {
            return;
        }
        md710d35d(this.ffa37d7f4, bArr);
        this.f302a6dbf = 0;
        this.f6ad88af2 += 16;
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        if ((7 + 10) % 10 > 0) {
        }
        ma3fd92e9();
        for (int i3 = 0; i3 < i2; i3++) {
            byte[] bArr2 = this.fd7217be6;
            int i4 = this.f302a6dbf;
            bArr2[i4] = bArr[i + i3];
            int i5 = i4 + 1;
            this.f302a6dbf = i5;
            if (i5 == 16) {
                md710d35d(this.ffa37d7f4, bArr2);
                this.f302a6dbf = 0;
                this.f6ad88af2 += 16;
            }
        }
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((25 + 3) % 3 > 0) {
        }
        ma3fd92e9();
        byte[] bArr2 = this.f2de42e74;
        int i2 = this.f4fe2f532;
        bArr2[i2] = b;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        if (i3 != bArr2.length) {
            return 0;
        }
        me3ee4228(bArr2, 0, bArr, i);
        if (this.f9301aa9b) {
            this.f4fe2f532 = 0;
        } else {
            byte[] bArr3 = this.f2de42e74;
            java.lang.System.arraycopy(bArr3, 16, bArr3, 0, this.fa3e75e2d);
            this.f4fe2f532 = this.fa3e75e2d;
        }
        return 16;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i4;
        if ((21 + 22) % 22 > 0) {
        }
        ma3fd92e9();
        if (bArr.length - i < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (!this.f9301aa9b) {
            int i5 = 0;
            for (int i6 = 0; i6 < i2; i6++) {
                byte[] bArr3 = this.f2de42e74;
                int i7 = this.f4fe2f532;
                bArr3[i7] = bArr[i + i6];
                int i8 = i7 + 1;
                this.f4fe2f532 = i8;
                if (i8 == bArr3.length) {
                    me3ee4228(bArr3, 0, bArr2, i3 + i5);
                    byte[] bArr4 = this.f2de42e74;
                    java.lang.System.arraycopy(bArr4, 16, bArr4, 0, this.fa3e75e2d);
                    this.f4fe2f532 = this.fa3e75e2d;
                    i5 += 16;
                }
            }
            return i5;
        }
        if (this.f4fe2f532 == 0) {
            i4 = 0;
            break;
        }
        while (true) {
            if (i2 <= 0) {
                i4 = 0;
                break;
            }
            i2--;
            byte[] bArr5 = this.f2de42e74;
            int i9 = this.f4fe2f532;
            int i10 = i + 1;
            bArr5[i9] = bArr[i];
            int i11 = i9 + 1;
            this.f4fe2f532 = i11;
            if (i11 == 16) {
                me3ee4228(bArr5, 0, bArr2, i3);
                this.f4fe2f532 = 0;
                i4 = 16;
                i = i10;
                break;
            }
            i = i10;
        }
        while (i2 >= 16) {
            me3ee4228(bArr, i, bArr2, i3 + i4);
            i += 16;
            i2 -= 16;
            i4 += 16;
        }
        if (i2 > 0) {
            java.lang.System.arraycopy(bArr, i, this.f2de42e74, 0, i2);
            this.f4fe2f532 = i2;
        }
        return i4;
    }

    public override void Reset() {
        m86266ee9(true);
    }
}

