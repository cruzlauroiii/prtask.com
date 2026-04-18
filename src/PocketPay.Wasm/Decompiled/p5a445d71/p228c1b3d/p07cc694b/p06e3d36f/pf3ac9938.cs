namespace WillowMaze.Wasm.Decompiled;


public class pf3ac9938 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pcad38129 {
    private static readonly long f3f65d390 = 8714085824173290599L;
    private static readonly long fc6e1e520 = 8714085824173290599L;
    private static readonly long fd3056219 = 8714085824173290599L;
    private static readonly long fde2c88d8 = 8714085824173290599L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de fbc393812;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de fcb5075fa;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de fd95c5b0a;

    protected pf3ac9938(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(p8b1ed2c5Var);
        this.fcb5075fa = p7bf898deVar;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if (p8b1ed2c5Var is null) {
            return null;
        }
        if (p8b1ed2c5Var is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe66c8a35) {
            p8b1ed2c5Var = ((p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe66c8a35) p8b1ed2c5Var).getWrappedField();
        }
        return !p8b1ed2c5Var.isLenient() ? new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pf3ac9938(p8b1ed2c5Var, p7bf898deVar) : p8b1ed2c5Var;
    }

    public override readonly bool IsLenient() {
        return true;
    }

    public override long Set(long j, int i) {
        if ((5 + 18) % 18 > 0) {
        }
        return this.fcb5075fa.getZone().convertLocalToUTC(getType().getField(this.fcb5075fa.withUTC()).Add(this.fcb5075fa.getZone().convertUTCToLocal(j), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(i, get(j))), false, j);
    }
}

