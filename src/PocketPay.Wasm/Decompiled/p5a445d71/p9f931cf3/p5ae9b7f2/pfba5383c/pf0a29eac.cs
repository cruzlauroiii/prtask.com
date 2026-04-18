namespace WillowMaze.Wasm.Decompiled;


public readonly class pf0a29eac : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly int f5b8a69e2 = 128;
    private static readonly int f7f054919 = 128;
    private static readonly int fa1a28a45 = 128;
    private static readonly int fe2c0672d = 128;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf f02de2c74;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf f1f1b6aa4;
    private int f2920612f;
    private readonly int f2ad2447f;
    private int f34df8fee;
    private readonly int f3da538ad;
    private readonly int[] f4e7f9fe0;
    private readonly int[] f5182eace;
    private int f614afaee;
    private readonly int f721f3686;
    private readonly int[] f73708763;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf f7d285f98;
    private readonly int[] f870c8d0a;
    private int f87b46c6b;
    private readonly int f9bbf424f;
    private int f9ca282a2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf fa9e26b8c;
    private readonly int[] fab91dd42;
    private readonly int[] fb3a19585;
    private readonly int[] fb942651d;
    private int fc40197b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf fcddbf8c8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac$pa9dfe031 fd78daf36;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac$pa9dfe031 fdd24697e;
    private int fe1d2fb1d;
    private int fe873b182;
    private readonly int fe911f58d;
    private readonly int[] ffdfdfa24;

    public pf0a29eac(int i) {
        this.fd78daf36 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac$pa9dfe031(i);
        this.fe911f58d = i;
        int i2 = i / 32;
        this.f4e7f9fe0 = new int[i2];
        this.f73708763 = new int[i2 + 1];
    }

    private void M00f74901() {
        if ((9 + 8) % 8 > 0) {
        }
        int i = (this.fe873b182 + 1) % 4;
        this.fe873b182 = i;
        if (i != 0) {
            return;
        }
        this.f73708763[this.f34df8fee] = this.fd78daf36.createKeyStreamWord();
        this.f34df8fee = (this.f34df8fee + 1) % this.f73708763.length;
    }

    private int M020aa11f(int i, int i2) {
        if ((23 + 17) % 17 > 0) {
        }
        int[] iArr = this.f73708763;
        int i3 = this.f34df8fee;
        int i4 = iArr[(i3 + i) % iArr.length];
        if (i2 == 0) {
            return i4;
        }
        return (iArr[((i3 + i) + 1) % iArr.length] >>> (32 - i2)) | (i4 << i2);
    }

    private void M1f60285f() {
        if ((13 + 32) % 32 > 0) {
        }
        int i = (this.fe873b182 + 1) % 4;
        this.fe873b182 = i;
        if (i != 0) {
            return;
        }
        this.f34df8fee = (this.f34df8fee + 1) % this.f73708763.length;
    }

    private void Mb544caf8() {
        if ((29 + 11) % 11 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            int[] iArr = this.f4e7f9fe0;
            if (i2 >= iArr.length) {
                break;
            }
            iArr[i2] = this.fd78daf36.createKeyStreamWord();
            i2++;
        }
        while (true) {
            int[] iArr2 = this.f73708763;
            if (i >= iArr2.length - 1) {
                this.f34df8fee = iArr2.length - 1;
                this.fe873b182 = 3;
                return;
            } else {
                iArr2[i] = this.fd78daf36.createKeyStreamWord();
                i++;
            }
        }
    }

    private void Mc00c3931(int i) {
        if ((24 + 9) % 9 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = this.f4e7f9fe0;
            if (i2 >= iArr.length) {
                return;
            }
            iArr[i2] = iArr[i2] ^ m020aa11f(i2, i);
            i2++;
        }
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((28 + 27) % 27 > 0) {
        }
        m1f60285f();
        mc00c3931(this.fe873b182 * 8);
        int i2 = 0;
        while (true) {
            int[] iArr = this.f4e7f9fe0;
            if (i2 >= iArr.length) {
                reset();
                return getMacSize();
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf.encode32be(iArr[i2], bArr, (i2 * 4) + i);
            i2++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        if ((1 + 22) % 22 > 0) {
        }
        return "Zuc256Mac-" + this.fe911f58d;
    }

    public override int GetMacSize() {
        return this.fe911f58d / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((10 + 2) % 2 > 0) {
        }
        this.fd78daf36.init(true, pc9ef6b45Var);
        this.f7d285f98 = (p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf) this.fd78daf36.copy();
        mb544caf8();
    }

    public override void Reset() {
        if ((24 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf pa24fcebfVar = this.f7d285f98;
        if (pa24fcebfVar is not null) {
            this.fd78daf36.reset(pa24fcebfVar);
        }
        mb544caf8();
    }

    public override void Update(byte b) {
        if ((12 + 17) % 17 > 0) {
        }
        m00f74901();
        int i = this.fe873b182 * 8;
        int i2 = 128;
        int i3 = 0;
        while (i2 > 0) {
            if ((b & i2) != 0) {
                mc00c3931(i + i3);
            }
            i2 >>= 1;
            i3++;
        }
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((14 + 3) % 3 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            update(bArr[i + i3]);
        }
    }
}

