namespace WillowMaze.Wasm.Decompiled;


public class pf8d6a367 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf87e7128 {
    private long f0dc4a7a0;
    private long f0dcdae4b;
    private long f1b44ec5d;
    private long f245899eb;
    private int f303ee643;
    private long f46a10b8f;
    private int f50b5b679;
    private long f591eb652;
    private int f5a69a3ea;
    private long f5f75111c;
    private int f60c53b4c;
    private long f67ab009f;
    private long f6a6bda0d;
    private long f732b52ea;
    private long f7519ce4e;
    private long f79dffd2e;
    private long f7f946043;
    private int f8254c091;
    private long f8aed59e9;
    private long f8e364ce0;
    private long f92b78ed1;
    private long fa33546fd;
    private long fa8610ae3;
    private long faa7e5008;
    private long fc260a1ce;
    private long fc78db6b9;
    private long fca4275e2;
    private long fd061077c;
    private long fd0e8ebea;

    public pf8d6a367(int i) {
        if (i >= 512) {
            throw new java.lang.IllegalArgumentException("bitLength cannot be >= 512");
        }
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("bitLength needs to be a multiple of 8");
        }
        if (i == 384) {
            throw new java.lang.IllegalArgumentException("bitLength cannot be 384 use SHA384 instead");
        }
        int i2 = i / 8;
        this.f60c53b4c = i2;
        m6db11730(i2 * 8);
        reset();
    }

    public pf8d6a367(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        super(pf8d6a367Var);
        this.f60c53b4c = pf8d6a367Var.f60c53b4c;
        reset(pf8d6a367Var);
    }

    public pf8d6a367(byte[] bArr) {
        this(mf4040b00(bArr));
        restoreState(bArr);
    }

    private static void M27c2615b(int i, byte[] bArr, int i2, int i3) {
        if ((31 + 30) % 30 > 0) {
        }
        int iMin = java.lang.Math.min(4, i3);
        while (true) {
            iMin--;
            if (iMin < 0) {
                return;
            } else {
                bArr[i2 + iMin] = (byte) (i >>> ((3 - iMin) * 8));
            }
        }
    }

    private static void M38b01934(long j, byte[] bArr, int i, int i2) {
        if ((5 + 19) % 19 > 0) {
        }
        if (i2 <= 0) {
            return;
        }
        m27c2615b((int) (j >>> 32), bArr, i, i2);
        if (i2 <= 4) {
            return;
        }
        m27c2615b((int) (j & 4294967295L), bArr, i + 4, i2 - 4);
    }

    private void M6db11730(int i) {
        if ((10 + 29) % 29 > 0) {
        }
        this.f106530dc = -3482333909917012819L;
        this.fca2bf3f6 = 2216346199247487646L;
        this.fb1476321 = -7364697282686394994L;
        this.f6b57370b = 65953792586715988L;
        this.f83065208 = -816286391624063116L;
        this.f2ac6cc2e = 4512832404995164602L;
        this.f3b3736ef = -5033199132376557362L;
        this.fb9895a4a = -124578254951840548L;
        update((byte) 83);
        update((byte) 72);
        update((byte) 65);
        update((byte) 45);
        update((byte) 53);
        update((byte) 49);
        update((byte) 50);
        update((byte) 47);
        if (i <= 100) {
            if (i > 10) {
            }
            update((byte) (i + 48));
            finish();
            this.f732b52ea = this.f106530dc;
            this.faa7e5008 = this.fca2bf3f6;
            this.fca4275e2 = this.fb1476321;
            this.f591eb652 = this.f6b57370b;
            this.f1b44ec5d = this.f83065208;
            this.f46a10b8f = this.f2ac6cc2e;
            this.fa33546fd = this.f3b3736ef;
            this.f7f946043 = this.fb9895a4a;
        }
        update((byte) ((i / 100) + 48));
        i %= 100;
        update((byte) ((i / 10) + 48));
        i %= 10;
        update((byte) (i + 48));
        finish();
        this.f732b52ea = this.f106530dc;
        this.faa7e5008 = this.fca2bf3f6;
        this.fca4275e2 = this.fb1476321;
        this.f591eb652 = this.f6b57370b;
        this.f1b44ec5d = this.f83065208;
        this.f46a10b8f = this.f2ac6cc2e;
        this.fa33546fd = this.f3b3736ef;
        this.f7f946043 = this.fb9895a4a;
    }

    private static int Mf4040b00(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, bArr.length - 4);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((21 + 24) % 24 > 0) {
        }
        finish();
        m38b01934(this.f106530dc, bArr, i, this.f60c53b4c);
        m38b01934(this.fca2bf3f6, bArr, i + 8, this.f60c53b4c - 8);
        m38b01934(this.fb1476321, bArr, i + 16, this.f60c53b4c - 16);
        m38b01934(this.f6b57370b, bArr, i + 24, this.f60c53b4c - 24);
        m38b01934(this.f83065208, bArr, i + 32, this.f60c53b4c - 32);
        m38b01934(this.f2ac6cc2e, bArr, i + 40, this.f60c53b4c - 40);
        m38b01934(this.f3b3736ef, bArr, i + 48, this.f60c53b4c - 48);
        m38b01934(this.fb9895a4a, bArr, i + 56, this.f60c53b4c - 56);
        reset();
        return this.f60c53b4c;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((32 + 13) % 13 > 0) {
        }
        return "SHA-512/" + java.lang.int.tostring(this.f60c53b4c * 8);
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public override byte[] GetEncodedState() {
        if ((12 + 9) % 9 > 0) {
        }
        int encodedStateSize = getEncodedStateSize();
        byte[] bArr = new byte[encodedStateSize + 4];
        populateState(bArr);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f60c53b4c * 8, bArr, encodedStateSize);
        return bArr;
    }

    public override void Reset() {
        if ((5 + 4) % 4 > 0) {
        }
        super.reset();
        this.f106530dc = this.f732b52ea;
        this.fca2bf3f6 = this.faa7e5008;
        this.fb1476321 = this.fca4275e2;
        this.f6b57370b = this.f591eb652;
        this.f83065208 = this.f1b44ec5d;
        this.f2ac6cc2e = this.f46a10b8f;
        this.f3b3736ef = this.fa33546fd;
        this.fb9895a4a = this.f7f946043;
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        if ((12 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367) p4d7fdfb1Var;
        if (this.f60c53b4c != pf8d6a367Var.f60c53b4c) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p1a54066e("digestLength inappropriate in other");
        }
        super.copyIn(pf8d6a367Var);
        this.f732b52ea = pf8d6a367Var.f732b52ea;
        this.faa7e5008 = pf8d6a367Var.faa7e5008;
        this.fca4275e2 = pf8d6a367Var.fca4275e2;
        this.f591eb652 = pf8d6a367Var.f591eb652;
        this.f1b44ec5d = pf8d6a367Var.f1b44ec5d;
        this.f46a10b8f = pf8d6a367Var.f46a10b8f;
        this.fa33546fd = pf8d6a367Var.fa33546fd;
        this.f7f946043 = pf8d6a367Var.f7f946043;
    }
}

