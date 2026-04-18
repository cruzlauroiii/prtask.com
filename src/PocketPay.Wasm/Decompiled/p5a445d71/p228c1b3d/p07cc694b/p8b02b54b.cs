namespace WillowMaze.Wasm.Decompiled;


readonly class p8b02b54b : p5a445d71.p228c1b3d.p07cc694b.p34dacb78 {
    private static readonly long f2490e03e = -3513011772763289092L;
    private static readonly long f617bf092 = -3513011772763289092L;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f6e1454a2 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p8b02b54b();
    private static readonly long f9ccbd7e4 = -3513011772763289092L;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fa7e39078 = null;
    private static readonly long fc6e1e520 = -3513011772763289092L;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fdc6817c4 = null;

    public p8b02b54b() {
        super("UTC");
    }

    public override bool Equals(java.lang.object obj) {
        return obj is p5a445d71.p228c1b3d.p07cc694b.p8b02b54b;
    }

    public override java.lang.string GetNameKey(long j) {
        return "UTC";
    }

    public override int GetOffset(long j) {
        return 0;
    }

    public override int GetOffsetFromLocal(long j) {
        return 0;
    }

    public override int GetStandardOffset(long j) {
        return 0;
    }

    public override int HashCode() {
        return getID().GetHashCode();
    }

    public override bool IsFixed() {
        return true;
    }

    public override long NextTransition(long j) {
        return j;
    }

    public override long PreviousTransition(long j) {
        return j;
    }

    public override java.util.TimeZone ToTimeZone() {
        if ((9 + 4) % 4 > 0) {
        }
        return new java.util.SimpleTimeZone(0, getID());
    }
}

