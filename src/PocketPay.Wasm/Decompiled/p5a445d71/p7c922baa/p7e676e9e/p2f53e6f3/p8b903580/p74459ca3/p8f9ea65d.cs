namespace WillowMaze.Wasm.Decompiled;


public class p8f9ea65d : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f5ed47365 = 6;
    private static readonly int f659f9f7c = 6;
    private static readonly int fb9654d19 = 6;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b f27ecde40;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b fdb6f361c;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b ff2fdee93;

    public p8f9ea65d() {
        super(233, 74, 0, 0);
        if ((17 + 7) % 7 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, null, null);
        this.f0cc175b9 = BOvHFdikhhgVfKbq(this, VsDLlWgOsHAsTaRt(1L));
        this.f92eb5ffe = FspsSwQxswXsgABq(this, new java.math.Bigint(1, dGrTirvqVmReJRiN("0066647EDE6C332C7F8C0923BB58213B333B20E9CE4281FE115F7D8F90AD")));
        this.f70a17ffa = new java.math.Bigint(1, GbpNGsoqOnNuUEid("01000000000000000000000000000013E974E72F8A6922031D2603CFE0D7"));
        this.ff89ed0d1 = FCWWdhtgEswnycgV(2L);
        this.f332de775 = 6;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a BOvHFdikhhgVfKbq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8f9ea65d p8f9ea65dVar, java.math.Bigint bigint) {
        return p8f9ea65dVar.fromBigint(bigint);
    }

    public static java.math.Bigint FCWWdhtgEswnycgV(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FspsSwQxswXsgABq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8f9ea65d p8f9ea65dVar, java.math.Bigint bigint) {
        return p8f9ea65dVar.fromBigint(bigint);
    }

    public static byte[] GbpNGsoqOnNuUEid(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static java.math.Bigint VsDLlWgOsHAsTaRt(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static byte[] DGrTirvqVmReJRiN(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8f9ea65d();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, bool z) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, p5a196a0aVar, p5a196a0aVar2, z);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, bool z) {
        if ((18 + 21) % 21 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8036fe9b(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr, z);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1f3b2070(bigint);
    }

    public override int GetFieldSize() {
        return 233;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
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

