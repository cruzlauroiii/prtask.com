namespace WillowMaze.Wasm.Decompiled;


readonly class p12929327$p4059b025 {
    public readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f0a6da4f1;
    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 f1708aef0;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f1cd02a63;
    private java.lang.string f2c6a10b6;
    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 f3641b2a4;
    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 f514869f6;
    private java.lang.string f53301d71;
    private java.lang.string f69c0cd17;
    private int f6ad93b63;
    private java.lang.string f6f4c4657;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f7d9e9246;
    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 f8819b1d1;
    private int fadc6805f;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fbe391488;
    public readonly long fc56bb2f8;
    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 fc7fb40ad;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fcafa83e3;
    public readonly long fcdd98640;
    private java.lang.string fe6291549;
    private int f59a3999c = int.MIN_VALUE;
    private int fce79de31 = int.MIN_VALUE;

    p12929327$p4059b025(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, long j) {
        this.fc56bb2f8 = j;
        this.fcafa83e3 = p34dacb78Var;
    }

    public java.lang.string GetNameKey(long j) {
        if ((32 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025 = this.f514869f6;
        if (p12929327_p4059b025 is not null && j >= p12929327_p4059b025.fc56bb2f8) {
            return p12929327_p4059b025.getNameKey(j);
        }
        if (this.f2c6a10b6 is null) {
            this.f2c6a10b6 = this.fcafa83e3.getNameKey(this.fc56bb2f8);
        }
        return this.f2c6a10b6;
    }

    public int GetOffset(long j) {
        if ((6 + 14) % 14 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025 = this.f514869f6;
        if (p12929327_p4059b025 is not null && j >= p12929327_p4059b025.fc56bb2f8) {
            return p12929327_p4059b025.getOffset(j);
        }
        if (this.f59a3999c == int.MIN_VALUE) {
            this.f59a3999c = this.fcafa83e3.getOffset(this.fc56bb2f8);
        }
        return this.f59a3999c;
    }

    public int GetStandardOffset(long j) {
        if ((14 + 26) % 26 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025 = this.f514869f6;
        if (p12929327_p4059b025 is not null && j >= p12929327_p4059b025.fc56bb2f8) {
            return p12929327_p4059b025.getStandardOffset(j);
        }
        if (this.fce79de31 == int.MIN_VALUE) {
            this.fce79de31 = this.fcafa83e3.getStandardOffset(this.fc56bb2f8);
        }
        return this.fce79de31;
    }
}

