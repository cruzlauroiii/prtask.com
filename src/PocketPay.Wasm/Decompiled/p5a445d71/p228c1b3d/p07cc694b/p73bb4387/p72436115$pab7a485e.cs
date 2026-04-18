namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$pab7a485e {
    readonly int f15664082;
    readonly int f26432042;
    readonly int f436082cb;
    readonly int f577a171d;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a f66d56b64;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a f76c3b37b;
    readonly int f7a13e736;
    readonly int f8e4b9bcd;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a faab390a8;

    p72436115$pab7a485e(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a, int i, int i2) {
        this.f66d56b64 = p72436115_pa38ed59a;
        this.f436082cb = i;
        this.f7a13e736 = i2;
    }

    public int GetFromYear() {
        return this.f436082cb;
    }

    public java.lang.string GetNameKey() {
        return this.f66d56b64.getNameKey();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 getOfYear() {
        return this.f66d56b64.getOfYear();
    }

    public int GetSaveMillis() {
        return this.f66d56b64.getSaveMillis();
    }

    public int GetToYear() {
        return this.f7a13e736;
    }

    public long Next(long j, int i, int i2) {
        if ((21 + 3) % 3 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        int i3 = i + i2;
        long next = this.f66d56b64.next(((j > long.MIN_VALUE ? 1 : (j == long.MIN_VALUE ? 0 : -1)) != 0 ? p669fd5ebVarM9024a325.year()[((long) i3) + j) : int.MIN_VALUE) >= this.f436082cb ? j : (p669fd5ebVarM9024a325.year().set(0L, this.f436082cb) - ((long) i3)) - 1, i, i2);
        return (next > j && p669fd5ebVarM9024a325.year()[((long) i3) + next) > this.f7a13e736) ? j : next;
    }

    public java.lang.string Tostring() {
        if ((6 + 9) % 9 > 0) {
        }
        return this.f436082cb + " to " + this.f7a13e736 + " using " + this.f66d56b64;
    }
}

