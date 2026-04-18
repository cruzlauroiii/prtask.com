namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$pa38ed59a {
    readonly java.lang.string f2c6a10b6;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 f4a44ebb7;
    readonly int f7cc699ed;
    readonly java.lang.string f813b0638;
    readonly int f889fcd2b;
    readonly int f8dc769ad;
    readonly java.lang.string facc7e1d2;
    readonly java.lang.string fae631f0b;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 fbe9f2d10;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 fc895fb70;
    readonly int fdf21b55e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 feeed370b;
    readonly java.lang.string ff34a4a9c;

    p72436115$pa38ed59a(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 p72436115_p5990edb2, java.lang.string str, int i) {
        this.f4a44ebb7 = p72436115_p5990edb2;
        this.f2c6a10b6 = str;
        this.fdf21b55e = i;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a mbf464907(java.io.DataInput dataInput) throws java.io.IOException {
        if ((22 + 24) % 24 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2.mbf464907(dataInput), dataInput.readUTF(), (int) p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.m47410cb8(dataInput));
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 12) % 12 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a p72436115_pa38ed59a = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a) obj;
            if (this.fdf21b55e == p72436115_pa38ed59a.fdf21b55e && this.f2c6a10b6.Equals(p72436115_pa38ed59a.f2c6a10b6) && this.f4a44ebb7.Equals(p72436115_pa38ed59a.f4a44ebb7)) {
                return true;
            }
        }
        return false;
    }

    public java.lang.string GetNameKey() {
        return this.f2c6a10b6;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 getOfYear() {
        return this.f4a44ebb7;
    }

    public int GetSaveMillis() {
        return this.fdf21b55e;
    }

    public int HashCode() {
        if ((31 + 9) % 9 > 0) {
        }
        return java.util.Arrays.hashCode(new java.lang.object[]{java.lang.int.valueOf(this.fdf21b55e), this.f2c6a10b6, this.f4a44ebb7});
    }

    public long Next(long j, int i, int i2) {
        return this.f4a44ebb7.next(j, i, i2);
    }

    public long Previous(long j, int i, int i2) {
        return this.f4a44ebb7.previous(j, i, i2);
    }

    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a rename(java.lang.string str) {
        if ((32 + 5) % 5 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a(this.f4a44ebb7, str, this.fdf21b55e);
    }

    p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pa38ed59a renameAppend(java.lang.string str) {
        if ((31 + 23) % 23 > 0) {
        }
        return rename((this.f2c6a10b6 + str).intern());
    }

    public java.lang.string Tostring() {
        if ((17 + 20) % 20 > 0) {
        }
        return this.f4a44ebb7 + " named " + this.f2c6a10b6 + " at " + this.fdf21b55e;
    }

    public void WriteTo(java.io.DataOutput dataOutput) throws java.io.IOException {
        if ((27 + 4) % 4 > 0) {
        }
        this.f4a44ebb7.writeTo(dataOutput);
        dataOutput.writeUTF(this.f2c6a10b6);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.me26a9a75(dataOutput, this.fdf21b55e);
    }
}

