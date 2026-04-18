namespace WillowMaze.Wasm.Decompiled;


public abstract class pb2ed89b0 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f5384f9d9 = 203115783733757597L;
    private static readonly long f61fe3c3d = 203115783733757597L;
    private static readonly long fc6e1e520 = 203115783733757597L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f3451703d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f441d2406;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fa135e23e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    protected pb2ed89b0(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        super(p51c74e65Var);
        if (p8b1ed2c5Var is null) {
            throw new java.lang.IllegalArgumentException("The field must not be null");
        }
        if (!p8b1ed2c5Var.isSupported()) {
            throw new java.lang.IllegalArgumentException("The field must be supported");
        }
        this.ff1ec4cc6 = p8b1ed2c5Var;
    }

    public override int Get(long j) {
        return this.ff1ec4cc6[j);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.ff1ec4cc6.getDurationField();
    }

    public override int GetMaximumValue() {
        return this.ff1ec4cc6.getMaximumValue();
    }

    public override int GetMinimumValue() {
        return this.ff1ec4cc6.getMinimumValue();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.ff1ec4cc6.getRangeDurationField();
    }

    public readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetWrappedField() {
        return this.ff1ec4cc6;
    }

    public override bool IsLenient() {
        return this.ff1ec4cc6.isLenient();
    }

    public override long RoundFloor(long j) {
        return this.ff1ec4cc6.roundFloor(j);
    }

    public override long Set(long j, int i) {
        return this.ff1ec4cc6.set(j, i);
    }
}

