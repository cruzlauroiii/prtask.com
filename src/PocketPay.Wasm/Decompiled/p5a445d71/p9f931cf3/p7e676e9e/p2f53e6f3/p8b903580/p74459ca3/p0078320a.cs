namespace WillowMaze.Wasm.Decompiled;


public class p0078320a : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f0c63cd7b = 6;
    private static readonly int f415335f2 = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f4a450277 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f567f0693 = null;
    private static readonly int f9e5b0ef4 = 6;
    private static readonly int fa6cdf3bb = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fbd9692c3 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fc668b798 = null;
    private static readonly int fd046acbe = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fd171350b;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a f1199af76;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a ff2fdee93;

    static {
        if ((26 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        fd171350b = p5a196a0aVarArr;
    }

    public p0078320a() {
        super(571, 2, 5, 10);
        if ((6 + 9) % 9 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(this, null, null);
        this.f0cc175b9 = fromBigint(java.math.Bigint.valueOf(0L));
        this.f92eb5ffe = fromBigint(java.math.Bigint.valueOf(1L));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("020000000000000000000000000000000000000000000000000000000000000000000000131850E1F19A63E4B391A8DB917F4138B630D84BE5D639381E91DEB45CFE778F637C1001"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(4L);
        this.f332de775 = 6;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return fd171350b;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0078320a();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((7 + 14) % 14 > 0) {
        }
        long[] jArr = new long[i2 * 18];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, jArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p40bd9e0a.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, jArr, i3 + 9);
            i3 += 18;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0078320a$1(this, i2, jArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5aa2d32a(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdc0b1dbe(bigint);
    }

    public override int GetFieldSize() {
        return 571;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 2;
    }

    public int GetK2() {
        return 5;
    }

    public int GetK3() {
        return 10;
    }

    public int GetM() {
        return 571;
    }

    public override bool IsKoblitz() {
        return true;
    }

    public bool IsTrinomial() {
        return false;
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 6;
    }
}

