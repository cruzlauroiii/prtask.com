namespace WillowMaze.Wasm.Decompiled;


public class p2729bfac : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41 {
    public static readonly java.math.Bigint f0f15c787 = null;
    private static readonly int f1ba3f2a4 = 2;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f241c4ac7;
    private static readonly int f5331bed8 = 2;
    private static readonly int f6be367cc = 2;
    public static readonly java.math.Bigint f723d7c12 = null;
    public static readonly java.math.Bigint f7694f4a6;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f7e9560fb = null;
    private static readonly int f867c5945 = 2;
    public static readonly java.math.Bigint f86fd8d8d = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fd8cad932 = null;
    private static readonly int ff8d98a61 = 2;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2 f3e8e8682;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2 f5b300f54;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2 fb38f1700;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2 fcc009ec9;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2 ff2fdee93;

    static {
        if ((15 + 13) % 13 > 0) {
        }
        f7694f4a6 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4.ff09564c9;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        f241c4ac7 = p5a196a0aVarArr;
    }

    public p2729bfac() {
        super(f7694f4a6);
        if ((13 + 23) % 23 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(this, null, null);
        this.f0cc175b9 = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFC")));
        this.f92eb5ffe = fromBigint(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("5AC635D8AA3A93E7B3EBBD55769886BC651D06B0CC53B0F63BCE3C3E27D2604B")));
        this.f70a17ffa = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("FFFFFFFF00000000FFFFFFFFFFFFFFFFBCE6FAADA7179E84F3B9CAC2FC632551"));
        this.ff89ed0d1 = java.math.Bigint.valueOf(1L);
        this.f332de775 = 2;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mf23e8626() {
        return f241c4ac7;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p2729bfac();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f CreateCacheSafeLookupTable(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((2 + 31) % 31 > 0) {
        }
        int[] iArr = new int[i2 * 16];
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i + i4];
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m12cba3ee(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p53a5793fVar.getRawXCoord()).f9dd4e461, 0, iArr, i3);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m12cba3ee(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p53a5793fVar.getRawYCoord()).f9dd4e461, 0, iArr, i3 + 8);
            i3 += 16;
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p2729bfac$1(this, i2, iArr);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pa21ebaf2(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(bigint);
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
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m7ddf32e1(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a RandomFieldElementMult(java.security.SecureRandom secureRandom) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.mb1442554(secureRandom, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 2;
    }
}

