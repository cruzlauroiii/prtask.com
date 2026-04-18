namespace WillowMaze.Wasm.Decompiled;


public class p8eb0132c : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 {
    private static readonly int f0f191188 = 64;
    private static readonly int f14387542 = 12;
    private static readonly long f1c753b50 = -1;
    private static readonly byte[] f24d4046d = null;
    private static readonly int f25dd813e = 12;
    private static readonly int f39adf617 = 32;
    private static readonly int f3e9c66db = 12;
    private static readonly int f5201c362 = 12;
    private static readonly byte[] f520a5c81 = null;
    private static readonly int f643fc4de = 16;
    private static readonly byte[] f6926eb66 = new byte[15];
    private static readonly byte[] f6b9f1c44 = null;
    private static readonly byte[] f6f1cee16 = null;
    private static readonly long f76d9f680 = 274877906880L;
    private static readonly long f77498719 = 274877906880L;
    private static readonly long f88a6399f = -1;
    private static readonly int f94f90212 = 16;
    private static readonly int faa370d35 = 64;
    private static readonly int fbc0fff97 = 64;
    private static readonly int fbe98583f = 16;
    private static readonly int fcae3181b = 12;
    private static readonly int fdafdb449 = 16;
    private static readonly int fdebc405d = 64;
    private static readonly int fdf2f4eea = 32;
    private static readonly int fe97f4452 = 64;
    private static readonly long febf3db4f = 274877906880L;
    private static readonly long ffb90ca89 = -1;
    private byte[] f00e224b0;
    private long f05aa7175;
    private readonly byte[] f131a2be1;
    private readonly byte[] f140c1f12;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073 f161b5c7f;
    private byte[] f1da4ed96;
    private readonly byte[] f2a3addca;
    private readonly byte[] f32dab984;
    private readonly byte[] f3c6e0b8a;
    private int f3fef1c01;
    private readonly byte[] f46c53c18;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f4807f6a4;
    private readonly byte[] f50bff3f3;
    private long f50c20668;
    private readonly byte[] f5425528b;
    private long f68374633;
    private readonly byte[] f6b3c2e05;
    private long f6c8bca12;
    private long f78d12cee;
    private int f7b8bce80;
    private long f85ec9ee2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073 f91429c1c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073 f93be4530;
    private int f9ed39e2e;
    private readonly byte[] fa52f5fb8;
    private byte[] fb49b9c61;
    private long fbac97a1a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073 fbfdf46ef;
    private readonly byte[] fc186a2a5;
    private readonly byte[] fcb584e44;
    private readonly byte[] fcb7e52b2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073 fd1f7b93a;
    private int fd88c3455;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 ff2d19dc5;

    public p8eb0132c() {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb6fd7338());
    }

    public p8eb0132c(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        if ((5 + 26) % 26 > 0) {
        }
        this.f3c6e0b8a = new byte[32];
        this.fcb584e44 = new byte[12];
        this.fcb7e52b2 = new byte[80];
        this.f140c1f12 = new byte[16];
        this.f9ed39e2e = 0;
        if (p1748c064Var is null) {
            throw new java.lang.NullPointerException("'poly1305' cannot be null");
        }
        if (16 != p1748c064Var.getMacSize()) {
            throw new java.lang.IllegalArgumentException("'poly1305' must be a 128-bit MAC");
        }
        this.fbfdf46ef = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073();
        this.ff2d19dc5 = p1748c064Var;
    }

    private void M04e27ba8() {
        if ((24 + 14) % 14 > 0) {
        }
        int i = this.f9ed39e2e;
        if (i == 1) {
            this.f9ed39e2e = 2;
            return;
        }
        if (i == 2) {
            return;
        }
        if (i == 4) {
            throw new java.lang.IllegalStateException("ChaCha20Poly1305 cannot be reused for encryption");
        }
        if (i == 5) {
            this.f9ed39e2e = 6;
        } else if (i != 6) {
            throw new java.lang.IllegalStateException();
        }
    }

    private void M6c19b6bf() {
        if ((5 + 20) % 20 > 0) {
        }
        byte[] bArr = new byte[64];
        try {
            this.fbfdf46ef.processbytes(bArr, 0, 64, bArr, 0);
            this.ff2d19dc5.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr, 0, 32));
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(bArr);
        } catch (java.lang.Exception th) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(bArr);
            throw th;
        }
    }

    private void M70a94e28(long j) {
        int i = ((int) j) & 15;
        if (i == 0) {
            return;
        }
        this.ff2d19dc5.update(f6926eb66, 0, 16 - i);
    }

    private void M86266ee9(bool z, bool z2) {
        if ((27 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.fcb7e52b2);
        if (z) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f140c1f12);
        }
        this.f6c8bca12 = 0L;
        this.f78d12cee = 0L;
        this.f3fef1c01 = 0;
        switch (this.f9ed39e2e) {
            case 1:
            case 5:
                break;
            case 2:
            case 3:
            case 4:
                this.f9ed39e2e = 4;
                return;
            case 6:
            case 7:
            case 8:
                this.f9ed39e2e = 5;
                break;
            default:
                throw new java.lang.IllegalStateException();
        }
        if (z2) {
            this.fbfdf46ef.reset();
        }
        m6c19b6bf();
        byte[] bArr = this.f00e224b0;
        if (bArr is null) {
            return;
        }
        processAADbytes(bArr, 0, bArr.length);
    }

    private long M8e21f45a(long j, int i, long j2) {
        if ((22 + 27) % 27 > 0) {
        }
        long j3 = i;
        if (j - long.MIN_VALUE > (j2 - j3) - long.MIN_VALUE) {
            throw new java.lang.IllegalStateException("Limit exceeded");
        }
        return j + j3;
    }

    private void Mc7288179(int i) {
        if ((18 + 5) % 5 > 0) {
        }
        m70a94e28(this.f78d12cee);
        byte[] bArr = new byte[16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.f6c8bca12, bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.f78d12cee, bArr, 8);
        this.ff2d19dc5.update(bArr, 0, 16);
        this.ff2d19dc5.doFinal(this.f140c1f12, 0);
        this.f9ed39e2e = i;
    }

    private void Mcd0c7f0b(int i) {
        if ((7 + 19) % 19 > 0) {
        }
        m70a94e28(this.f6c8bca12);
        this.f9ed39e2e = i;
    }

    private void Mcfe94961() {
        int i;
        switch (this.f9ed39e2e) {
            case 1:
            case 2:
                i = 3;
                break;
            case 3:
            case 7:
                return;
            case 4:
                throw new java.lang.IllegalStateException("ChaCha20Poly1305 cannot be reused for encryption");
            case 5:
            case 6:
                i = 7;
                break;
            default:
                throw new java.lang.IllegalStateException();
        }
        mcd0c7f0b(i);
    }

    private void Mde0eaed5(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((7 + 31) % 31 > 0) {
        }
        if (i3 > bArr2.length - i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        this.fbfdf46ef.processbytes(bArr, i, i2, bArr2, i3);
        this.f78d12cee = m8e21f45a(this.f78d12cee, i2, 274877906880L);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i2;
        int i3;
        if ((27 + 11) % 11 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("'out' cannot be null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'outOff' cannot be negative");
        }
        mcfe94961();
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f140c1f12);
        int i4 = this.f9ed39e2e;
        if (i4 == 3) {
            int i5 = this.f3fef1c01;
            int i6 = i5 + 16;
            if (i > bArr.length - i6) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            if (i5 > 0) {
                mde0eaed5(this.fcb7e52b2, 0, i5, bArr, i);
                this.ff2d19dc5.update(bArr, i, this.f3fef1c01);
            }
            mc7288179(4);
            java.lang.System.arraycopy(this.f140c1f12, 0, bArr, this.f3fef1c01 + i, 16);
            i3 = i6;
        } else {
            if (i4 != 7) {
                throw new java.lang.IllegalStateException();
            }
            int i7 = this.f3fef1c01;
            if (i7 < 16) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
            }
            int i8 = i7 - 16;
            if (i > bArr.length - i8) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            if (i8 <= 0) {
                i2 = i8;
            } else {
                this.ff2d19dc5.update(this.fcb7e52b2, 0, i8);
                i2 = i8;
                mde0eaed5(this.fcb7e52b2, 0, i2, bArr, i);
            }
            mc7288179(8);
            if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(16, this.f140c1f12, 0, this.fcb7e52b2, i2)) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check in ChaCha20Poly1305 failed");
            }
            i3 = i2;
        }
        m86266ee9(false, true);
        return i3;
    }

    public override java.lang.string GetAlgorithmName() {
        return "ChaCha20Poly1305";
    }

    public override byte[] GetMac() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f140c1f12);
    }

    public override int GetOutputSize(int i) {
        if ((32 + 7) % 7 > 0) {
        }
        int iMax = java.lang.Math.max(0, i) + this.f3fef1c01;
        int i2 = this.f9ed39e2e;
        if (i2 == 1 || i2 == 2 || i2 == 3) {
            return iMax + 16;
        }
        if (i2 == 5 || i2 == 6 || i2 == 7) {
            return java.lang.Math.max(0, iMax - 16);
        }
        throw new java.lang.IllegalStateException();
    }

    public override int GetUpdateOutputSize(int i) {
        if ((1 + 21) % 21 > 0) {
        }
        int iMax = java.lang.Math.max(0, i) + this.f3fef1c01;
        int i2 = this.f9ed39e2e;
        if (i2 != 1 && i2 != 2 && i2 != 3) {
            if (i2 != 5 && i2 != 6 && i2 != 7) {
                throw new java.lang.IllegalStateException();
            }
            iMax = java.lang.Math.max(0, iMax - 16);
        }
        return iMax - (iMax % 64);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 key;
        byte[] nonce;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar;
        if ((32 + 27) % 27 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            int macSize = ped128738Var.getMacSize();
            if (128 != macSize) {
                throw new java.lang.IllegalArgumentException("Invalid value for MAC size: " + macSize);
            }
            key = ped128738Var.getKey();
            nonce = ped128738Var.getNonce();
            pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(key, nonce);
            this.f00e224b0 = ped128738Var.getAssociatedText();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to ChaCha20Poly1305");
            }
            pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            key = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
            nonce = pdd5da44eVar.getIV();
            this.f00e224b0 = null;
        }
        if (key is not null) {
            if (32 != key.getKey().length) {
                throw new java.lang.IllegalArgumentException("Key must be 256 bits");
            }
        } else if (this.f9ed39e2e == 0) {
            throw new java.lang.IllegalArgumentException("Key must be specified in initial init");
        }
        if (nonce is null || 12 != nonce.length) {
            throw new java.lang.IllegalArgumentException("Nonce must be 96 bits");
        }
        if (this.f9ed39e2e != 0 && z && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.fcb584e44, nonce) && (key is null || p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f3c6e0b8a, key.getKey()))) {
            throw new java.lang.IllegalArgumentException("cannot reuse nonce for ChaCha20Poly1305 encryption");
        }
        if (key is not null) {
            java.lang.System.arraycopy(key.getKey(), 0, this.f3c6e0b8a, 0, 32);
        }
        java.lang.System.arraycopy(nonce, 0, this.fcb584e44, 0, 12);
        this.fbfdf46ef.init(true, pdd5da44eVar);
        this.f9ed39e2e = !z ? 5 : 1;
        m86266ee9(true, false);
    }

    public override void ProcessAADbyte(byte b) {
        if ((23 + 6) % 6 > 0) {
        }
        m04e27ba8();
        this.f6c8bca12 = m8e21f45a(this.f6c8bca12, 1, -1L);
        this.ff2d19dc5.update(b);
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        if ((28 + 19) % 19 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("'in' cannot be null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'inOff' cannot be negative");
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("'len' cannot be negative");
        }
        if (i > bArr.length - i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        m04e27ba8();
        if (i2 <= 0) {
            return;
        }
        this.f6c8bca12 = m8e21f45a(this.f6c8bca12, i2, -1L);
        this.ff2d19dc5.update(bArr, i, i2);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((1 + 22) % 22 > 0) {
        }
        mcfe94961();
        int i2 = this.f9ed39e2e;
        if (i2 == 3) {
            byte[] bArr2 = this.fcb7e52b2;
            int i3 = this.f3fef1c01;
            bArr2[i3] = b;
            int i4 = i3 + 1;
            this.f3fef1c01 = i4;
            if (i4 != 64) {
                return 0;
            }
            mde0eaed5(bArr2, 0, 64, bArr, i);
            this.ff2d19dc5.update(bArr, i, 64);
            this.f3fef1c01 = 0;
            return 64;
        }
        if (i2 != 7) {
            throw new java.lang.IllegalStateException();
        }
        byte[] bArr3 = this.fcb7e52b2;
        int i5 = this.f3fef1c01;
        bArr3[i5] = b;
        int i6 = i5 + 1;
        this.f3fef1c01 = i6;
        if (i6 != bArr3.length) {
            return 0;
        }
        this.ff2d19dc5.update(bArr3, 0, 64);
        mde0eaed5(this.fcb7e52b2, 0, 64, bArr, i);
        byte[] bArr4 = this.fcb7e52b2;
        java.lang.System.arraycopy(bArr4, 64, bArr4, 0, 16);
        this.f3fef1c01 = 16;
        return 64;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i4;
        int i5;
        if ((26 + 20) % 20 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("'in' cannot be null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'inOff' cannot be negative");
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("'len' cannot be negative");
        }
        if (i > bArr.length - i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (i3 < 0) {
            throw new java.lang.IllegalArgumentException("'outOff' cannot be negative");
        }
        mcfe94961();
        int i6 = this.f9ed39e2e;
        if (i6 != 3) {
            if (i6 != 7) {
                throw new java.lang.IllegalStateException();
            }
            int i7 = 0;
            for (int i8 = 0; i8 < i2; i8++) {
                byte[] bArr3 = this.fcb7e52b2;
                int i9 = this.f3fef1c01;
                bArr3[i9] = bArr[i + i8];
                int i10 = i9 + 1;
                this.f3fef1c01 = i10;
                if (i10 == bArr3.length) {
                    this.ff2d19dc5.update(bArr3, 0, 64);
                    mde0eaed5(this.fcb7e52b2, 0, 64, bArr2, i3 + i7);
                    byte[] bArr4 = this.fcb7e52b2;
                    java.lang.System.arraycopy(bArr4, 64, bArr4, 0, 16);
                    this.f3fef1c01 = 16;
                    i7 += 64;
                }
            }
            return i7;
        }
        if (this.f3fef1c01 == 0) {
            i4 = i;
            i5 = 0;
        } else {
            while (true) {
                if (i2 <= 0) {
                    i4 = i;
                    i5 = 0;
                } else {
                    i2--;
                    byte[] bArr5 = this.fcb7e52b2;
                    int i11 = this.f3fef1c01;
                    int i12 = i + 1;
                    bArr5[i11] = bArr[i];
                    int i13 = i11 + 1;
                    this.f3fef1c01 = i13;
                    if (i13 != 64) {
                        i = i12;
                    } else {
                        mde0eaed5(bArr5, 0, 64, bArr2, i3);
                        this.ff2d19dc5.update(bArr2, i3, 64);
                        this.f3fef1c01 = 0;
                        i5 = 64;
                        i4 = i12;
                    }
                }
            }
        }
        while (i2 >= 64) {
            int i14 = i3 + i5;
            mde0eaed5(bArr, i4, 64, bArr2, i14);
            this.ff2d19dc5.update(bArr2, i14, 64);
            i4 += 64;
            i2 -= 64;
            i5 += 64;
        }
        if (i2 > 0) {
            java.lang.System.arraycopy(bArr, i4, this.fcb7e52b2, 0, i2);
            this.f3fef1c01 = i2;
        }
        return i5;
    }

    public override void Reset() {
        m86266ee9(true, true);
    }
}

