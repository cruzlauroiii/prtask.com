namespace WillowMaze.Wasm.Decompiled;


public class p1ecb1ec0 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f1ec427bf = null;
    private static readonly int f48d5b9e8 = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f97ae0e9f = null;
    private static readonly int f9d3b8bc5 = 6;
    private static readonly int fa783b446 = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fd1b250b3 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fdb3b722c;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 f1c0c8a2b;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 f9e7bcb63;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 faef87bec;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 ff2fdee93;

    static {
        if ((25 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        fdb3b722c = p5a196a0aVarArr;
    }

    public p1ecb1ec0() {
        super(163, 3, 6, 7);
        if ((32 + 1) % 1 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, null, null);
        this.f0cc175b9 = fromBigint(java.math.Bigint.valueOf(1L));
        this.f92eb5ffe = this.f0cc175b9;
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("04000000000000000000020108A2E0CC0D99F8A5EF"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(2L);
        this.f332de775 = 6;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return fdb3b722c;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1ecb1ec0();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((29 + 3) % 3 > 0) {
        }
        long[] jArr = new long[i2 * 6];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, jArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, jArr, i3 + 3);
            i3 += 6;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1ecb1ec0$1(this, i2, jArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565(bigint);
    }

    public override int GetFieldSize() {
        return 163;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 3;
    }

    public int GetK2() {
        return 6;
    }

    public int GetK3() {
        return 7;
    }

    public int GetM() {
        return 163;
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

