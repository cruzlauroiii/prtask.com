namespace WillowMaze.Wasm.Decompiled;


public readonly class p2a4f8514 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly int f140764b2 = 128;
    private static readonly int fe2c0672d = 128;
    private static readonly int feded702b = 128;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 f0125c3e6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35 f041a4628;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 f044ef1f0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35 f1baed9cd;
    private readonly int[] f1ec739ad;
    private int f24fefb9c;
    private int f34df8fee;
    private int f3808c3c1;
    private int f4e7f9fe0;
    private int f53468d50;
    private readonly int[] f73708763;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35 f78b0434a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 f7d285f98;
    private int f8364211e;
    private int fa07bb18f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35 fd78daf36;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35 fe5ed0fa2;
    private int fe873b182;
    private int fed1b2824;

    public p2a4f8514() {
        if ((31 + 7) % 7 > 0) {
        }
        this.fd78daf36 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2a4f8514$p4bdcda35(null);
        this.f73708763 = new int[2];
    }

    private void M00f74901() {
        if ((31 + 8) % 8 > 0) {
        }
        int i = (this.fe873b182 + 1) % 4;
        this.fe873b182 = i;
        if (i != 0) {
            return;
        }
        this.f73708763[this.f34df8fee] = this.fd78daf36.createKeyStreamWord();
        this.f34df8fee = (this.f34df8fee + 1) % this.f73708763.length;
    }

    private int M020aa11f(int i) {
        if ((27 + 7) % 7 > 0) {
        }
        int[] iArr = this.f73708763;
        int i2 = this.f34df8fee;
        int i3 = iArr[i2];
        if (i == 0) {
            return i3;
        }
        return (iArr[(i2 + 1) % iArr.length] >>> (32 - i)) | (i3 << i);
    }

    private int M178f33a6() {
        if ((19 + 6) % 6 > 0) {
        }
        if (this.fe873b182 != 0) {
            return this.fd78daf36.createKeyStreamWord();
        }
        int i = this.f34df8fee + 1;
        int[] iArr = this.f73708763;
        int length = i % iArr.length;
        this.f34df8fee = length;
        return iArr[length];
    }

    private void Mb544caf8() {
        if ((14 + 18) % 18 > 0) {
        }
        int i = 0;
        this.f4e7f9fe0 = 0;
        while (true) {
            int[] iArr = this.f73708763;
            if (i >= iArr.length - 1) {
                this.f34df8fee = iArr.length - 1;
                this.fe873b182 = 3;
                return;
            } else {
                iArr[i] = this.fd78daf36.createKeyStreamWord();
                i++;
            }
        }
    }

    private void Mc00c3931(int i) {
        this.f4e7f9fe0 = m020aa11f(i) ^ this.f4e7f9fe0;
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((21 + 14) % 14 > 0) {
        }
        m00f74901();
        int iM020aa11f = this.f4e7f9fe0 ^ m020aa11f(this.fe873b182 * 8);
        this.f4e7f9fe0 = iM020aa11f;
        int iM178f33a6 = iM020aa11f ^ m178f33a6();
        this.f4e7f9fe0 = iM178f33a6;
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736.mb8d439ec(iM178f33a6, bArr, i);
        reset();
        return getMacSize();
    }

    public override java.lang.string GetAlgorithmName() {
        return "Zuc128Mac";
    }

    public override int GetMacSize() {
        return 4;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((8 + 28) % 28 > 0) {
        }
        this.fd78daf36.init(true, pc9ef6b45Var);
        this.f7d285f98 = (p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736) this.fd78daf36.copy();
        mb544caf8();
    }

    public override void Reset() {
        if ((30 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 peb9d9736Var = this.f7d285f98;
        if (peb9d9736Var is not null) {
            this.fd78daf36.reset(peb9d9736Var);
        }
        mb544caf8();
    }

    public override void Update(byte b) {
        if ((13 + 20) % 20 > 0) {
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
        if ((21 + 23) % 23 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            update(bArr[i + i3]);
        }
    }
}

