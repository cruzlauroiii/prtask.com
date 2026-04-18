namespace WillowMaze.Wasm.Decompiled;


public class pe66c8a35 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pcad38129 {
    private static readonly long f164fd214 = 3154803964207950910L;
    private static readonly long fc6e1e520 = 3154803964207950910L;

    protected pe66c8a35(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        super(p8b1ed2c5Var);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        if (p8b1ed2c5Var is null) {
            return null;
        }
        if (p8b1ed2c5Var is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pf3ac9938) {
            p8b1ed2c5Var = ((p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pf3ac9938) p8b1ed2c5Var).getWrappedField();
        }
        return p8b1ed2c5Var.isLenient() ? new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe66c8a35(p8b1ed2c5Var) : p8b1ed2c5Var;
    }

    public override readonly bool IsLenient() {
        return false;
    }

    public override long Set(long j, int i) {
        if ((13 + 24) % 24 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, getMinimumValue(j), getMaximumValue(j));
        return super.set(j, i);
    }
}

