namespace WillowMaze.Wasm.Decompiled;


public class pd43a7172 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f4a444303 = 6;
    private static readonly int f62800819 = 6;
    private static readonly int f6b292d78 = 6;
    private static readonly int fc1cadf36 = 6;
    private static readonly int ff70816a1 = 6;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36 f96ebc722;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36 fdb5ebbf9;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36 ff2fdee93;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36 ffb3b7796;

    public pd43a7172() {
        super(193, 15, 0, 0);
        if ((3 + 12) % 12 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36(this, null, null);
        this.f0cc175b9 = ruanrubgSTnujCIz(this, new java.math.Bigint(1, IYpgHRGKyBEjBHEJ("0017858FEB7A98975169E171F77B4087DE098AC8A911DF7B01")));
        this.f92eb5ffe = YPuwJuQeRdGmPBfT(this, new java.math.Bigint(1, opXpgRSUInnlQwhz("00FDFB49BFE6C3A89FACADAA7A1E5BBC7CC1C2E5D831478814")));
        this.f70a17ffa = new java.math.Bigint(1, vpZfrRKakVUDOOxA("01000000000000000000000000C7F34A778F443ACC920EBA49"));
        this.ff89ed0d1 = gamykXfacLKTbpQy(2L);
        this.f332de775 = 6;
    }

    public static byte[] IYpgHRGKyBEjBHEJ(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a YPuwJuQeRdGmPBfT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd43a7172 pd43a7172Var, java.math.Bigint bigint) {
        return pd43a7172Var.fromBigint(bigint);
    }

    public static java.math.Bigint GamykXfacLKTbpQy(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static byte[] OpXpgRSUInnlQwhz(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a RuanrubgSTnujCIz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd43a7172 pd43a7172Var, java.math.Bigint bigint) {
        return pd43a7172Var.fromBigint(bigint);
    }

    public static byte[] VpZfrRKakVUDOOxA(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd43a7172();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, bool z) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36(this, p5a196a0aVar, p5a196a0aVar2, z);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, bool z) {
        if ((29 + 24) % 24 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p730e2b36(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr, z);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p27c3a9ba(bigint);
    }

    public override int GetFieldSize() {
        return 193;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public int GetK1() {
        return 15;
    }

    public int GetK2() {
        return 0;
    }

    public int GetK3() {
        return 0;
    }

    public int GetM() {
        return 193;
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

