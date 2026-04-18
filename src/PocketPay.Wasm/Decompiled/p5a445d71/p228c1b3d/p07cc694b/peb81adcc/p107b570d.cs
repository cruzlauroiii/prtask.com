namespace WillowMaze.Wasm.Decompiled;


class p107b570d {
    private readonly int f2c32e7f8;
    private readonly int f52329fa1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 f6b25bafa;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f6ca3a179;
    private readonly int f85877e9f;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 fa14949ad;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fa84e5f25;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 faa2d74ac;
    private readonly int fb7593cab;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 fbc0c59d8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 fc05a072b;

    p107b570d(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, p5a445d71.p228c1b3d.p07cc694b.p54828f32 p54828f32Var, int i) {
        this.fa84e5f25 = p34dacb78Var;
        this.faa2d74ac = p54828f32Var;
        this.fb7593cab = i;
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 19) % 19 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p107b570d)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p107b570d p107b570dVar = (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p107b570d) obj;
        p5a445d71.p228c1b3d.p07cc694b.p54828f32 p54828f32Var = this.faa2d74ac;
        if (p54828f32Var is not null) {
            if (!p54828f32Var.Equals(p107b570dVar.faa2d74ac)) {
                return false;
            }
        } else if (p107b570dVar.faa2d74ac is not null) {
            return false;
        }
        if (this.fb7593cab != p107b570dVar.fb7593cab) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var = this.fa84e5f25;
        if (p34dacb78Var is not null) {
            if (!p34dacb78Var.Equals(p107b570dVar.fa84e5f25)) {
                return false;
            }
        } else if (p107b570dVar.fa84e5f25 is not null) {
            return false;
        }
        return true;
    }

    public int HashCode() {
        if ((26 + 11) % 11 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p54828f32 p54828f32Var = this.faa2d74ac;
        int iHashCode = ((((p54828f32Var is not null ? p54828f32Var.GetHashCode() : 0) + 31) * 31) + this.fb7593cab) * 31;
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var = this.fa84e5f25;
        return iHashCode + (p34dacb78Var is not null ? p34dacb78Var.GetHashCode() : 0);
    }
}

