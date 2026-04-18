namespace WillowMaze.Wasm.Decompiled;


public class pa827ecfa$p73b12670 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f320a04e7 = 6;
    private static readonly int f4815cbe9 = 6;
    private static readonly int f5fc8ded1 = 6;
    private static readonly int fcc843550 = 6;
    private int f219c9b30;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670 f3586aff6;
    private int f47ff939e;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670 f57343c01;
    private int f5a3972fc;
    private int f5cd02cec;
    private int f61620957;
    private int f6f8f5771;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670 f8730d70a;
    private int f98f8d4ba;
    private int facfbdc97;
    private int fb637b17a;
    private int fc49c6e7b;
    private int fd499a61f;
    private int fec067774;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670 ff2fdee93;
    private int ff7ab469d;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670 ffbfb00f4;

    public pa827ecfa$p73b12670(int i, int i2, int i3, int i4, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(i, i2, i3, i4, bigint, bigint2, (java.math.Bigint) null, (java.math.Bigint) null);
        if ((19 + 25) % 25 > 0) {
        }
    }

    public pa827ecfa$p73b12670(int i, int i2, int i3, int i4, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        super(i, i2, i3, i4);
        this.f6f8f5771 = i;
        this.fb637b17a = i2;
        this.f61620957 = i3;
        this.ff7ab469d = i4;
        this.f70a17ffa = bigint3;
        this.ff89ed0d1 = bigint4;
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670(this, null, null);
        this.f0cc175b9 = fromBigint(bigint);
        this.f92eb5ffe = fromBigint(bigint2);
        this.f332de775 = 6;
    }

    protected pa827ecfa$p73b12670(int i, int i2, int i3, int i4, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(i, i2, i3, i4);
        this.f6f8f5771 = i;
        this.fb637b17a = i2;
        this.f61620957 = i3;
        this.ff7ab469d = i4;
        this.f70a17ffa = bigint;
        this.ff89ed0d1 = bigint2;
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670(this, null, null);
        this.f0cc175b9 = p5a196a0aVar;
        this.f92eb5ffe = p5a196a0aVar2;
        this.f332de775 = 6;
    }

    public pa827ecfa$p73b12670(int i, int i2, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(i, i2, 0, 0, bigint, bigint2, (java.math.Bigint) null, (java.math.Bigint) null);
        if ((25 + 4) % 4 > 0) {
        }
    }

    public pa827ecfa$p73b12670(int i, int i2, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        this(i, i2, 0, 0, bigint, bigint2, bigint3, bigint4);
        if ((8 + 10) % 10 > 0) {
        }
    }

    static int Mf23e8626(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 pa827ecfa_p73b12670) {
        return pa827ecfa_p73b12670.f6f8f5771;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        if ((16 + 29) % 29 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(this.f6f8f5771, this.fb637b17a, this.f61620957, this.ff7ab469d, this.f0cc175b9, this.f92eb5ffe, this.f70a17ffa, this.ff89ed0d1);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        int[] iArr;
        if ((27 + 25) % 25 > 0) {
        }
        int i3 = (this.f6f8f5771 + 63) >>> 6;
        if (isTrinomial()) {
            iArr = new int[1];
            iArr[0] = this.fb637b17a;
        } else {
            iArr = new int[3];
            iArr[0] = this.fb637b17a;
            iArr[1] = this.f61620957;
            iArr[2] = this.ff7ab469d;
        }
        int[] iArr2 = iArr;
        long[] jArr = new long[i2 * i3 * 2];
        int i4 = 0;
        for (int i5 = 0; i5 < i2; i5++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i5];
            ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p53a5793fVar.getRawXCoord()).f9dd4e461.copyTo(jArr, i4);
            int i6 = i4 + i3;
            ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p53a5793fVar.getRawYCoord()).f9dd4e461.copyTo(jArr, i6);
            i4 = i6 + i3;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670$1(this, i2, i3, jArr, iArr2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return !isKoblitz() ? super.createDefaultMultiplier() : new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p73b12670(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        if ((2 + 11) % 11 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.fb637b17a, this.f61620957, this.ff7ab469d, bigint);
    }

    public override int GetFieldSize() {
        return this.f6f8f5771;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return this.fb637b17a;
    }

    public int GetK2() {
        return this.f61620957;
    }

    public int GetK3() {
        return this.ff7ab469d;
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public bool IsTrinomial() {
        return this.f61620957 == 0 && this.ff7ab469d == 0;
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 0 || i == 1 || i == 6;
    }
}

