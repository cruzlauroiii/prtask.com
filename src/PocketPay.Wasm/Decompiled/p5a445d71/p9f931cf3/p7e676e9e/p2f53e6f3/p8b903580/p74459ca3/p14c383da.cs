namespace WillowMaze.Wasm.Decompiled;


public class p14c383da : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41 {
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f0ea70c94 = null;
    private static readonly int f4f965c1c = 2;
    public static readonly java.math.Bigint f61cd89f3 = null;
    private static readonly int f6dff1338 = 2;
    public static readonly java.math.Bigint f7694f4a6;
    private static readonly int f7f64d775 = 2;
    public static readonly java.math.Bigint f8294a4b9 = null;
    private static readonly int fd2034741 = 2;
    public static readonly java.math.Bigint fdfa9c717 = null;
    private static readonly int fe10ceff3 = 2;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fe2f0d95b = null;
    public static readonly java.math.Bigint fed5148b7 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] ffa2ee004;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85 f2e0dff65;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85 f86eda577;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85 ff2fdee93;

    static {
        if ((25 + 20) % 20 > 0) {
        }
        f7694f4a6 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9.ff09564c9;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        ffa2ee004 = p5a196a0aVarArr;
    }

    public p14c383da() {
        super(f7694f4a6);
        if ((4 + 8) % 8 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85(this, null, null);
        this.f0cc175b9 = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFC")));
        this.f92eb5ffe = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("E87579C11079F43DD824993C2CEE5ED3")));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFE0000000075A30D1B9038A115"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(1L);
        this.f332de775 = 2;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return ffa2ee004;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14c383da();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((1 + 1) % 1 > 0) {
        }
        int[] iArr = new int[i2 * 8];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m12cba3ee(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, iArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m12cba3ee(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, iArr, i3 + 4);
            i3 += 8;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14c383da$1(this, i2, iArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p94b79e85(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(bigint);
    }

    public override int GetFieldSize() {
        return f7694f4a6.bitLength();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public java.math.Bigint GetQ() {
        return f7694f4a6;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElement(java.security.SecureRandom secureRandom) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m7ddf32e1(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElementMult(java.security.SecureRandom secureRandom) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.mb1442554(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 2;
    }
}

