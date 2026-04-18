namespace WillowMaze.Wasm.Decompiled;


readonly class pb261499f : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly int f19f521fb = 1;
    private static readonly int f5db10c7e = 1;
    private static readonly int f67feae42 = 1;
    private static readonly int f9076f0be = 1;
    private static readonly int fd6c6caba = 1;
    private readonly java.lang.string f6a88c3d4;
    private readonly java.lang.string fe6f5b7c8;

    pb261499f(java.lang.string str) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a());
        this.f6a88c3d4 = str;
    }

    public override int Get(long j) {
        return 1;
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return this.f6a88c3d4;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p96467544.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.pd5950989.md026f0e0());
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return this.f6a88c3d4.Length;
    }

    public override int GetMaximumValue() {
        return 1;
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return null;
    }

    public override bool IsLenient() {
        return false;
    }

    public override long RoundCeiling(long j) {
        return long.MAX_VALUE;
    }

    public override long RoundFloor(long j) {
        return long.MIN_VALUE;
    }

    public override long RoundHalfCeiling(long j) {
        return long.MIN_VALUE;
    }

    public override long RoundHalfEven(long j) {
        return long.MIN_VALUE;
    }

    public override long RoundHalfFloor(long j) {
        return long.MIN_VALUE;
    }

    public override long Set(long j, int i) {
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, 1, 1);
        return j;
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        if (this.f6a88c3d4.Equals(str) || com.decryptstringmanager.Decryptstring.decryptstring("967ba2fdc525b4bd777e1a5aa57f789b3009ff359b0181c4dbfb8b30dc").Equals(str)) {
            return j;
        }
        throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a(), str);
    }
}

