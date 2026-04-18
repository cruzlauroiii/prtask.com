namespace WillowMaze.Wasm.Decompiled;


public abstract class pd0b74b0c : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f711ca30e = 7190739608550251860L;
    private static readonly long fc6e1e520 = 7190739608550251860L;
    readonly long f6891ebe8;
    readonly long f9834a589;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa0fe9756;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    readonly long fa732d6a0;
    readonly long fcaf66fe4;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fe0e64fb0;

    public pd0b74b0c(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, long j) {
        super(p51c74e65Var);
        this.fcaf66fe4 = j;
        this.fa28ee680 = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c$pd42efca7(this, p51c74e65Var.getDurationType());
    }

    public override abstract long Add(long j, int i);

    public override abstract long Add(long j, long j2);

    public override abstract int Get(long j);

    public override int GetDifference(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getDifferenceAslong(j, j2));
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((5 + 9) % 9 > 0) {
        }
        if (j < j2) {
            return -getDifferenceAslong(j2, j);
        }
        long j3 = (j - j2) / this.fcaf66fe4;
        if (add(j2, j3) >= j) {
            if (add(j2, j3) > j) {
                do {
                    j3--;
                } while (add(j2, j3) > j);
            }
            return j3;
        }
        while (true) {
            long j4 = j3 + 1;
            if (add(j2, j4) > j) {
                return j3;
            }
            j3 = j4;
        }
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    protected readonly long GetDurationUnitMillis() {
        if ((4 + 12) % 12 > 0) {
        }
        return this.fcaf66fe4;
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField();

    public override abstract long RoundFloor(long j);

    public override abstract long Set(long j, int i);
}

