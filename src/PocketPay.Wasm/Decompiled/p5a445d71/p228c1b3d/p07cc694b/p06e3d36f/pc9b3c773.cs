namespace WillowMaze.Wasm.Decompiled;


public readonly class pc9b3c773 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pcad38129 {
    private static readonly long f9bdf4091 = -8869148464118507846L;
    private static readonly long fc6e1e520 = -8869148464118507846L;
    private readonly int f00053b17;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f52ae1786;
    private readonly int f6556fabb;
    private readonly int f6dfc5954;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f721336d9;
    private readonly int f7aa7b659;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f937d74d1;
    private int f9980f2d1;
    private int fdbe38783;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de ff1e3caed;

    public pc9b3c773(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        this(p7bf898deVar, p8b1ed2c5Var, 0);
    }

    public pc9b3c773(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, int i) {
        super(p8b1ed2c5Var);
        this.f3fedc733 = p7bf898deVar;
        int minimumValue = super.getMinimumValue();
        if (minimumValue < i) {
            this.fdbe38783 = minimumValue - 1;
        } else if (minimumValue != i) {
            this.fdbe38783 = minimumValue;
        } else {
            this.fdbe38783 = i + 1;
        }
        this.f00053b17 = i;
    }

    private java.lang.object M73fa47c3() {
        return getType().getField(this.f3fedc733);
    }

    public override int Get(long j) {
        int i = super[j);
        return i > this.f00053b17 ? i : i - 1;
    }

    public override int GetMinimumValue() {
        return this.fdbe38783;
    }

    public override long Set(long j, int i) {
        if ((1 + 4) % 4 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i, this.fdbe38783, getMaximumValue());
        int i2 = this.f00053b17;
        if (i <= i2) {
            if (i == i2) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), java.lang.int.valueOf(i), (java.lang.Number) null, (java.lang.Number) null);
            }
            i++;
        }
        return super.set(j, i);
    }
}

