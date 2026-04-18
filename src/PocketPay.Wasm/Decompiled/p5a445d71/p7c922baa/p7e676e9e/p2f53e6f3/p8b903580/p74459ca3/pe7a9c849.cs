namespace WillowMaze.Wasm.Decompiled;


public class pe7a9c849 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f2698a4d7 = 6;
    private static readonly int f5f64abfc = 6;
    private static readonly int f9fc70e2b = 6;
    private static readonly int ff920a92b = 6;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcf537439 f4be053ba;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcf537439 ff2fdee93;

    public pe7a9c849() {
        super(409, 87, 0, 0);
        if ((4 + 20) % 20 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcf537439(this, null, null);
        this.f0cc175b9 = xcBRayrEsBacmwRS(this, EqZMNRyPjOOZozcx(1L));
        this.f92eb5ffe = AdPxbYWFvBENdpHV(this, new java.math.Bigint(1, aUbtNdzvJNEuLfGg("0021A5C2C8EE9FEB5C4B9A753B7B476B7FD6422EF1F3DD674761FA99D6AC27C8A9A197B272822F6CD57A55AA4F50AE317B13545F")));
        this.f70a17ffa = new java.math.Bigint(1, OLOtBfEYZcEcSwNw("010000000000000000000000000000000000000000000000000001E2AAD6A612F33307BE5FA47C3C9E052F838164CD37D9A21173"));
        this.ff89ed0d1 = DXbLxytpkVtKTliC(2L);
        this.f332de775 = 6;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a AdPxbYWFvBENdpHV(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849 pe7a9c849Var, java.math.Bigint bigint) {
        return pe7a9c849Var.fromBigint(bigint);
    }

    public static java.math.Bigint DXbLxytpkVtKTliC(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint EqZMNRyPjOOZozcx(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static byte[] OLOtBfEYZcEcSwNw(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static byte[] AUbtNdzvJNEuLfGg(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a XcBRayrEsBacmwRS(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849 pe7a9c849Var, java.math.Bigint bigint) {
        return pe7a9c849Var.fromBigint(bigint);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, bool z) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcf537439(this, p5a196a0aVar, p5a196a0aVar2, z);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, bool z) {
        if ((16 + 22) % 22 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcf537439(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr, z);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcfa73bff(bigint);
    }

    public override int GetFieldSize() {
        return 409;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 87;
    }

    public int GetK2() {
        return 0;
    }

    public int GetK3() {
        return 0;
    }

    public int GetM() {
        return 409;
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

