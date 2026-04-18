namespace WillowMaze.Wasm.Decompiled;


public class p6871c538 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly int f3183a1c2 = 16;
    private static readonly int fbf865626 = 16;
    private static readonly int fc75e2054 = 16;
    private static readonly int fd2f662ac = 16;
    private java.util.Vector f046eda80;
    private byte[] f0eba983a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f0fa9b53d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f13ebddc0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f140a7ffa;
    private bool f17eb0595;
    private long f1cebe9e6;
    private byte[] f1d003ba3;
    private byte[] f2212d0ed;
    private byte[] f245f1979;
    private int f25ac2bd2;
    private long f2745ec50;
    private byte[] f2aee1083;
    private byte[] f2de669e6;
    private byte[] f32e9e601;
    private byte[] f35487eba;
    private java.util.Vector f38c9f1d8;
    private byte[] f3a26e6e5;
    private byte[] f42f0941d;
    private byte[] f475d83a2;
    private int f47904241;
    private byte[] f4c9ba2aa;
    private byte[] f50b9b6d5;
    private byte[] f5b46f88f;
    private byte[] f5cd4aad2;
    private byte[] f5e59bc8b;
    private bool f5fd3692d;
    private byte[] f646b5c24;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f652f5d61;
    private byte[] f6541cf85;
    private byte[] f6bb5d376;
    private byte[] f70693f3e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f726e3452;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f79394ea9;
    private byte[] f800319f1;
    private java.util.Vector f8437bc89;
    private long f87a3ff18;
    private byte[] f89f37066;
    private bool f8c1961e4;
    private bool f9301aa9b;
    private byte[] f96988d91;
    private byte[] f9a28c6c0;
    private byte[] f9aa3028f;
    private byte[] fa0ec8705;
    private long fa145324a;
    private int fa3e75e2d;
    private byte[] fa468cca1;
    private byte[] fa9bcdc42;
    private byte[] fb36bcd5e;
    private int fb9fef78d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fbd6e70a4;
    private byte[] fc366742d;
    private byte[] fc73b1bf1;
    private byte[] fcc00f58a;
    private long fcd345466;
    private java.util.Vector fd20caec3;
    private long fd4b1e991;
    private int fda78e6c0;
    private int fdb268edc;
    private byte[] fdb7ab500;
    private byte[] fdc3615b3;
    private int fe1ecca3f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fe682f3b7;
    private byte[] fea193874;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fec633be0;
    private byte[] fee46fb25;
    private java.util.Vector ff1042e80;
    private long ff11cc649;
    private byte[] ff2cb88ce;
    private int ff30ecdb4;
    private byte[] ff560ce01;
    private byte[] ffbb09a82;

    public p6871c538(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var2) {
        if ((9 + 14) % 14 > 0) {
        }
        this.f5b46f88f = null;
        this.ffbb09a82 = new byte[24];
        this.f35487eba = new byte[16];
        this.f9a28c6c0 = new byte[16];
        if (pd81e8b93Var is null) {
            throw new java.lang.IllegalArgumentException("'hashCipher' cannot be null");
        }
        if (pd81e8b93Var.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("'hashCipher' must have a block size of 16");
        }
        if (pd81e8b93Var2 is null) {
            throw new java.lang.IllegalArgumentException("'mainCipher' cannot be null");
        }
        if (pd81e8b93Var2.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("'mainCipher' must have a block size of 16");
        }
        if (!pd81e8b93Var.getAlgorithmName().Equals(pd81e8b93Var2.getAlgorithmName())) {
            throw new java.lang.IllegalArgumentException("'hashCipher' and 'mainCipher' must be the same algorithm");
        }
        this.f140a7ffa = pd81e8b93Var;
        this.f652f5d61 = pd81e8b93Var2;
    }

    protected static byte[] M6bde0870(byte[] bArr) {
        if ((26 + 30) % 30 > 0) {
        }
        byte[] bArr2 = new byte[16];
        bArr2[15] = (byte) ((135 >>> ((1 - mb3c44417(bArr, bArr2)) << 3)) ^ bArr2[15]);
        return bArr2;
    }

    protected static void M7e44d9c4(byte[] bArr, int i) {
        bArr[i] = -128;
        while (true) {
            i++;
            if (i >= 16) {
                return;
            } else {
                bArr[i] = 0;
            }
        }
    }

    protected static void Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((19 + 9) % 9 > 0) {
        }
        for (int i = 15; i >= 0; i--) {
            bArr[i] = (byte) (bArr[i] ^ bArr2[i]);
        }
    }

    protected static int Mb3c44417(byte[] bArr, byte[] bArr2) {
        if ((8 + 12) % 12 > 0) {
        }
        int i = 16;
        int i2 = 0;
        while (true) {
            i--;
            if (i < 0) {
                return i2;
            }
            int i3 = bArr[i] & 255;
            bArr2[i] = (byte) (i2 | (i3 << 1));
            i2 = (i3 >>> 7) & 1;
        }
    }

    protected static int Mc698dde1(long j) {
        if ((25 + 1) % 1 > 0) {
        }
        if (j == 0) {
            return 64;
        }
        int i = 0;
        while ((1 & j) == 0) {
            i++;
            j >>>= 1;
        }
        return i;
    }

    protected void Clear(byte[] bArr) {
        if (bArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        byte[] bArr2;
        if ((7 + 32) % 32 > 0) {
        }
        if (this.f9301aa9b) {
            bArr2 = null;
        } else {
            int i2 = this.fb9fef78d;
            int i3 = this.fa3e75e2d;
            if (i2 < i3) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("data too short");
            }
            int i4 = i2 - i3;
            this.fb9fef78d = i4;
            bArr2 = new byte[i3];
            java.lang.System.arraycopy(this.f2212d0ed, i4, bArr2, 0, i3);
        }
        int i5 = this.fda78e6c0;
        if (i5 > 0) {
            m7e44d9c4(this.f96988d91, i5);
            updateHASH(this.fdb7ab500);
        }
        int i6 = this.fb9fef78d;
        if (i6 > 0) {
            if (this.f9301aa9b) {
                m7e44d9c4(this.f2212d0ed, i6);
                ma3929604(this.f89f37066, this.f2212d0ed);
            }
            ma3929604(this.f9a28c6c0, this.fdb7ab500);
            byte[] bArr3 = new byte[16];
            this.f140a7ffa.processBlock(this.f9a28c6c0, 0, bArr3, 0);
            ma3929604(this.f2212d0ed, bArr3);
            int length = bArr.length;
            int i7 = this.fb9fef78d;
            if (length < i + i7) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            java.lang.System.arraycopy(this.f2212d0ed, 0, bArr, i, i7);
            if (!this.f9301aa9b) {
                m7e44d9c4(this.f2212d0ed, this.fb9fef78d);
                ma3929604(this.f89f37066, this.f2212d0ed);
            }
        }
        ma3929604(this.f89f37066, this.f9a28c6c0);
        ma3929604(this.f89f37066, this.f9aa3028f);
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f140a7ffa;
        byte[] bArr4 = this.f89f37066;
        pd81e8b93Var.processBlock(bArr4, 0, bArr4, 0);
        ma3929604(this.f89f37066, this.fa0ec8705);
        int i8 = this.fa3e75e2d;
        byte[] bArr5 = new byte[i8];
        this.f0eba983a = bArr5;
        java.lang.System.arraycopy(this.f89f37066, 0, bArr5, 0, i8);
        int i9 = this.fb9fef78d;
        if (this.f9301aa9b) {
            int length2 = bArr.length;
            int i10 = i + i9;
            int i11 = this.fa3e75e2d;
            if (length2 < i10 + i11) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            java.lang.System.arraycopy(this.f0eba983a, 0, bArr, i10, i11);
            i9 += this.fa3e75e2d;
        } else if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f0eba983a, bArr2)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check in OCB failed");
        }
        reset(false);
        return i9;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f652f5d61.getAlgorithmName() + "/OCB";
    }

    protected byte[] GetLSub(int i) {
        if ((19 + 10) % 10 > 0) {
        }
        while (i >= this.fd20caec3.Count) {
            java.util.Vector vector = this.fd20caec3;
            vector.addElement(m6bde0870((byte[]) vector.lastElement()));
        }
        return (byte[]) this.fd20caec3.elementAt(i);
    }

    public override byte[] GetMac() {
        byte[] bArr = this.f0eba983a;
        return bArr is not null ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr) : new byte[this.fa3e75e2d];
    }

    public override int GetOutputSize(int i) {
        int i2 = i + this.fb9fef78d;
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
        return this.f652f5d61;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.fb9fef78d;
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
        if ((32 + 8) % 8 > 0) {
        }
        bool z2 = this.f9301aa9b;
        this.f9301aa9b = z;
        this.f0eba983a = null;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            nonce = ped128738Var.getNonce();
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            int macSize = ped128738Var.getMacSize();
            if (macSize < 64 || macSize > 128 || macSize % 8 != 0) {
                throw new java.lang.IllegalArgumentException("Invalid value for MAC size: " + macSize);
            }
            this.fa3e75e2d = macSize / 8;
            key = ped128738Var.getKey();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to OCB");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            nonce = pdd5da44eVar.getIV();
            this.fdc3615b3 = null;
            this.fa3e75e2d = 16;
            key = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        }
        this.f96988d91 = new byte[16];
        this.f2212d0ed = new byte[!z ? this.fa3e75e2d + 16 : 16];
        if (nonce is null) {
            nonce = new byte[0];
        }
        if (nonce.length > 15) {
            throw new java.lang.IllegalArgumentException("IV must be no more than 15 bytes");
        }
        if (key is not null) {
            this.f140a7ffa.init(true, key);
            this.f652f5d61.init(z, key);
            this.f5b46f88f = null;
        } else if (z2 != z) {
            throw new java.lang.IllegalArgumentException("cannot change encrypting state without providing key.");
        }
        byte[] bArr = new byte[16];
        this.fdb7ab500 = bArr;
        this.f140a7ffa.processBlock(bArr, 0, bArr, 0);
        this.f9aa3028f = m6bde0870(this.fdb7ab500);
        java.util.Vector vector = new java.util.Vector();
        this.fd20caec3 = vector;
        vector.addElement(m6bde0870(this.f9aa3028f));
        int iProcessNonce = processNonce(nonce);
        int i = iProcessNonce % 8;
        int i2 = iProcessNonce / 8;
        if (i != 0) {
            for (int i3 = 0; i3 < 16; i3++) {
                byte[] bArr2 = this.ffbb09a82;
                int i4 = bArr2[i2] & 255;
                i2++;
                this.f35487eba[i3] = (byte) (((bArr2[i2] & 255) >>> (8 - i)) | (i4 << i));
            }
        } else {
            java.lang.System.arraycopy(this.ffbb09a82, i2, this.f35487eba, 0, 16);
        }
        this.fda78e6c0 = 0;
        this.fb9fef78d = 0;
        this.f87a3ff18 = 0L;
        this.fa145324a = 0L;
        this.fc366742d = new byte[16];
        this.fa0ec8705 = new byte[16];
        java.lang.System.arraycopy(this.f35487eba, 0, this.f9a28c6c0, 0, 16);
        this.f89f37066 = new byte[16];
        byte[] bArr3 = this.fdc3615b3;
        if (bArr3 is null) {
            return;
        }
        processAADbytes(bArr3, 0, bArr3.length);
    }

    public override void ProcessAADbyte(byte b) {
        if ((24 + 26) % 26 > 0) {
        }
        byte[] bArr = this.f96988d91;
        int i = this.fda78e6c0;
        bArr[i] = b;
        int i2 = i + 1;
        this.fda78e6c0 = i2;
        if (i2 != bArr.length) {
            return;
        }
        processHashBlock();
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        if ((27 + 12) % 12 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            byte[] bArr2 = this.f96988d91;
            int i4 = this.fda78e6c0;
            bArr2[i4] = bArr[i + i3];
            int i5 = i4 + 1;
            this.fda78e6c0 = i5;
            if (i5 == bArr2.length) {
                processHashBlock();
            }
        }
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((4 + 14) % 14 > 0) {
        }
        byte[] bArr2 = this.f2212d0ed;
        int i2 = this.fb9fef78d;
        bArr2[i2] = b;
        int i3 = i2 + 1;
        this.fb9fef78d = i3;
        if (i3 != bArr2.length) {
            return 0;
        }
        processMainBlock(bArr, i);
        return 16;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((28 + 7) % 7 > 0) {
        }
        if (bArr.length < i + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        int i4 = 0;
        for (int i5 = 0; i5 < i2; i5++) {
            byte[] bArr3 = this.f2212d0ed;
            int i6 = this.fb9fef78d;
            bArr3[i6] = bArr[i + i5];
            int i7 = i6 + 1;
            this.fb9fef78d = i7;
            if (i7 == bArr3.length) {
                processMainBlock(bArr2, i3 + i4);
                i4 += 16;
            }
        }
        return i4;
    }

    protected void ProcessHashBlock() {
        if ((28 + 3) % 3 > 0) {
        }
        long j = this.f87a3ff18 + 1;
        this.f87a3ff18 = j;
        updateHASH(getLSub(mc698dde1(j)));
        this.fda78e6c0 = 0;
    }

    protected void ProcessMainBlock(byte[] bArr, int i) {
        if ((18 + 20) % 20 > 0) {
        }
        if (bArr.length < i + 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (this.f9301aa9b) {
            ma3929604(this.f89f37066, this.f2212d0ed);
            this.fb9fef78d = 0;
        }
        byte[] bArr2 = this.f9a28c6c0;
        long j = this.fa145324a + 1;
        this.fa145324a = j;
        ma3929604(bArr2, getLSub(mc698dde1(j)));
        ma3929604(this.f2212d0ed, this.f9a28c6c0);
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f652f5d61;
        byte[] bArr3 = this.f2212d0ed;
        pd81e8b93Var.processBlock(bArr3, 0, bArr3, 0);
        ma3929604(this.f2212d0ed, this.f9a28c6c0);
        java.lang.System.arraycopy(this.f2212d0ed, 0, bArr, i, 16);
        if (this.f9301aa9b) {
            return;
        }
        ma3929604(this.f89f37066, this.f2212d0ed);
        byte[] bArr4 = this.f2212d0ed;
        java.lang.System.arraycopy(bArr4, 16, bArr4, 0, this.fa3e75e2d);
        this.fb9fef78d = this.fa3e75e2d;
    }

    protected int ProcessNonce(byte[] bArr) {
        if ((23 + 8) % 8 > 0) {
        }
        byte[] bArr2 = new byte[16];
        int i = 0;
        java.lang.System.arraycopy(bArr, 0, bArr2, 16 - bArr.length, bArr.length);
        bArr2[0] = (byte) (this.fa3e75e2d << 4);
        int length = 15 - bArr.length;
        bArr2[length] = (byte) (bArr2[length] | 1);
        byte b = bArr2[15];
        int i2 = b & 63;
        bArr2[15] = (byte) (b & 192);
        byte[] bArr3 = this.f5b46f88f;
        if (bArr3 is null || !p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr2, bArr3)) {
            byte[] bArr4 = new byte[16];
            this.f5b46f88f = bArr2;
            this.f140a7ffa.processBlock(bArr2, 0, bArr4, 0);
            java.lang.System.arraycopy(bArr4, 0, this.ffbb09a82, 0, 16);
            while (i < 8) {
                byte[] bArr5 = this.ffbb09a82;
                int i3 = i + 16;
                byte b2 = bArr4[i];
                i++;
                bArr5[i3] = (byte) (b2 ^ bArr4[i]);
            }
        }
        return i2;
    }

    public override void Reset() {
        reset(true);
    }

    protected void Reset(bool z) {
        if ((31 + 5) % 5 > 0) {
        }
        this.f140a7ffa.reset();
        this.f652f5d61.reset();
        clear(this.f96988d91);
        clear(this.f2212d0ed);
        this.fda78e6c0 = 0;
        this.fb9fef78d = 0;
        this.f87a3ff18 = 0L;
        this.fa145324a = 0L;
        clear(this.fc366742d);
        clear(this.fa0ec8705);
        java.lang.System.arraycopy(this.f35487eba, 0, this.f9a28c6c0, 0, 16);
        clear(this.f89f37066);
        if (z) {
            this.f0eba983a = null;
        }
        byte[] bArr = this.fdc3615b3;
        if (bArr is null) {
            return;
        }
        processAADbytes(bArr, 0, bArr.length);
    }

    protected void UpdateHASH(byte[] bArr) {
        if ((26 + 31) % 31 > 0) {
        }
        ma3929604(this.fc366742d, bArr);
        ma3929604(this.f96988d91, this.fc366742d);
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f140a7ffa;
        byte[] bArr2 = this.f96988d91;
        pd81e8b93Var.processBlock(bArr2, 0, bArr2, 0);
        ma3929604(this.fa0ec8705, this.f96988d91);
    }
}

