namespace WillowMaze.Wasm.Decompiled;


public class p1ecb1ec0 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int fc1d6230d = 6;
    private static readonly int fd67b1310 = 6;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 f1e583175;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 f6ef17dad;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 fedc54c30;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7 ff2fdee93;

    public p1ecb1ec0() {
        super(163, 3, 6, 7);
        if ((9 + 10) % 10 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, null, null);
        this.f0cc175b9 = tuPanirsMGslzlWl(this, reZLSdiYOmEApGmh(1L));
        this.f92eb5ffe = this.f0cc175b9;
        this.f70a17ffa = new java.math.Bigint(1, lwjmeCFKWdimefsx("04000000000000000000020108A2E0CC0D99F8A5EF"));
        this.ff89ed0d1 = PFabWsPxVnstUyyc(2L);
        this.f332de775 = 6;
    }

    public static java.math.Bigint PFabWsPxVnstUyyc(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static byte[] LwjmeCFKWdimefsx(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static java.math.Bigint ReZLSdiYOmEApGmh(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a TuPanirsMGslzlWl(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1ecb1ec0 p1ecb1ec0Var, java.math.Bigint bigint) {
        return p1ecb1ec0Var.fromBigint(bigint);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1ecb1ec0();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, bool z) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, p5a196a0aVar, p5a196a0aVar2, z);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, bool z) {
        if ((27 + 23) % 23 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdb6a34b7(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr, z);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565(bigint);
    }

    public override int GetFieldSize() {
        return 163;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
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

