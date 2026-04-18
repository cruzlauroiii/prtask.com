namespace WillowMaze.Wasm.Decompiled;


public class pdd3192eb : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f4c7b0131 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f9d0dec2c = null;
    private static readonly int f9dc1bb5c = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fbad0d8e6;
    private static readonly int febfcd9ea = 6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] ffc500e14 = null;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70 f2a1d844b;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70 ff2fdee93;

    static {
        if ((7 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        fbad0d8e6 = p5a196a0aVarArr;
    }

    public pdd3192eb() {
        super(239, 158, 0, 0);
        if ((13 + 13) % 13 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, null, null);
        this.f0cc175b9 = fromBigint(java.math.Bigint.valueOf(0L));
        this.f92eb5ffe = fromBigint(java.math.Bigint.valueOf(1L));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("2000000000000000000000000000005A79FEC67CB6E91F1C1DA800E478A5"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(4L);
        this.f332de775 = 6;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return fbad0d8e6;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((32 + 14) % 14 > 0) {
        }
        long[] jArr = new long[i2 * 8];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, jArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m0246eff8(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, jArr, i3 + 4);
            i3 += 8;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb$1(this, i2, jArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83(bigint);
    }

    public override int GetFieldSize() {
        return 239;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 158;
    }

    public int GetK2() {
        return 0;
    }

    public int GetK3() {
        return 0;
    }

    public int GetM() {
        return 239;
    }

    public override bool IsKoblitz() {
        return true;
    }

    public bool IsTrinomial() {
        return true;
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 6;
    }
}

