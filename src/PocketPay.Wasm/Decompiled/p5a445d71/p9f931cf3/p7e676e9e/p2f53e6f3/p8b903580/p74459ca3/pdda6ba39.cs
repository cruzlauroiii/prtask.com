namespace WillowMaze.Wasm.Decompiled;


public class pdda6ba39 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41 {
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f09a1f228 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f33164634 = null;
    private static readonly int f36d1ff2e = 2;
    private static readonly int f47b1df0c = 2;
    public static readonly java.math.Bigint f490ced37 = null;
    public static readonly java.math.Bigint f7694f4a6;
    public static readonly java.math.Bigint f7cdfb539 = null;
    private static readonly int f86c4ec7a = 2;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] faa3b8659;
    public static readonly java.math.Bigint faba8ed55 = null;
    private static readonly int fc1d1550f = 2;
    private static readonly int fd2d19cf0 = 2;
    public static readonly java.math.Bigint fda56cee6 = null;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762 f233f3882;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762 f2bd2ad30;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762 f2e333921;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762 fd71e2f86;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762 ff2fdee93;

    static {
        if ((29 + 26) % 26 > 0) {
        }
        f7694f4a6 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7.ff09564c9;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        faa3b8659 = p5a196a0aVarArr;
    }

    public pdda6ba39() {
        super(f7694f4a6);
        if ((7 + 10) % 10 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(this, null, null);
        this.f0cc175b9 = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFC")));
        this.f92eb5ffe = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("B3312FA7E23EE7E4988E056BE3F82D19181D9C6EFE8141120314088F5013875AC656398D8A2ED19D2A85C8EDD3EC2AEF")));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC7634D81F4372DDF581A0DB248B0A77AECEC196ACCC52973"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(1L);
        this.f332de775 = 2;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return faa3b8659;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdda6ba39();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((14 + 29) % 29 > 0) {
        }
        int[] iArr = new int[i2 * 24];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m12cba3ee(12, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, iArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m12cba3ee(12, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, iArr, i3 + 12);
            i3 += 24;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdda6ba39$1(this, i2, iArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9c04f762(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(bigint);
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
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.m7ddf32e1(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElementMult(java.security.SecureRandom secureRandom) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(12);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p7cbc162a.mb1442554(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pc26229f7(iArrM76ea0beb);
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 2;
    }
}

