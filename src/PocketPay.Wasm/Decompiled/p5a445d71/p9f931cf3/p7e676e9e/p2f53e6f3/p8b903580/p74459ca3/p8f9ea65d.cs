namespace WillowMaze.Wasm.Decompiled;


public class p8f9ea65d : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f9750b9e8 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fa80b9561 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fb977ad34;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fbba91427 = null;
    private static readonly int fc08f7d34 = 6;
    private static readonly int fdd11f7d7 = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fff24919f = null;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b f8d22f544;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b ff2fdee93;

    static {
        if ((18 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1f3b2070(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        fb977ad34 = p5a196a0aVarArr;
    }

    public p8f9ea65d() {
        super(233, 74, 0, 0);
        if ((31 + 21) % 21 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, null, null);
        this.f0cc175b9 = fromBigint(java.math.Bigint.valueOf(1L));
        this.f92eb5ffe = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("0066647EDE6C332C7F8C0923BB58213B333B20E9CE4281FE115F7D8F90AD")));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("01000000000000000000000000000013E974E72F8A6922031D2603CFE0D7"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(2L);
        this.f332de775 = 6;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return fb977ad34;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8f9ea65d();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((2 + 12) % 12 > 0) {
        }
        long[] jArr = new long[i2 * 8];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1f3b2070) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, jArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1f3b2070) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, jArr, i3 + 4);
            i3 += 8;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8f9ea65d$1(this, i2, jArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1f3b2070(bigint);
    }

    public override int GetFieldSize() {
        return 233;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 74;
    }

    public int GetK2() {
        return 0;
    }

    public int GetK3() {
        return 0;
    }

    public int GetM() {
        return 233;
    }

    public override bool IsKoblitz() {
        return false;
    }

    public bool IsTrinomial() {
        return true;
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 6;
    }
}

