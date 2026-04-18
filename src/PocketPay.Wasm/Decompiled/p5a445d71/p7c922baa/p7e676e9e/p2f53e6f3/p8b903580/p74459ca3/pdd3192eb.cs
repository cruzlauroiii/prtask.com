namespace WillowMaze.Wasm.Decompiled;


public class pdd3192eb : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 {
    private static readonly int f766c94c2 = 6;
    private static readonly int f9c17e49e = 6;
    private static readonly int ffd2f1e1e = 6;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70 f7e88f755;
    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70 ff2fdee93;

    public pdd3192eb() {
        super(239, 158, 0, 0);
        if ((30 + 20) % 20 > 0) {
        }
        this.ff2fdee93 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, null, null);
        this.f0cc175b9 = RkYeSCvkEhcGogjy(this, ihppUIJpZdFuxQiG(0L));
        this.f92eb5ffe = aDcFWdSuDMBBnlBv(this, UxdsCrzHhzwKACUo(1L));
        this.f70a17ffa = new java.math.Bigint(1, yeHtwPxGOyUGVQdY("2000000000000000000000000000005A79FEC67CB6E91F1C1DA800E478A5"));
        this.ff89ed0d1 = wtAameqoNwSfvPXJ(4L);
        this.f332de775 = 6;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a RkYeSCvkEhcGogjy(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb pdd3192ebVar, java.math.Bigint bigint) {
        return pdd3192ebVar.fromBigint(bigint);
    }

    public static java.math.Bigint UxdsCrzHhzwKACUo(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a ADcFWdSuDMBBnlBv(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb pdd3192ebVar, java.math.Bigint bigint) {
        return pdd3192ebVar.fromBigint(bigint);
    }

    public static java.math.Bigint IhppUIJpZdFuxQiG(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint WtAameqoNwSfvPXJ(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static byte[] YeHtwPxGOyUGVQdY(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 CreateDefaultMultiplier() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p295eb2ce();
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, bool z) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, p5a196a0aVar, p5a196a0aVar2, z);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, bool z) {
        if ((24 + 7) % 7 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pae6e7e70(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr, z);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83(bigint);
    }

    public override int GetFieldSize() {
        return 239;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
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

