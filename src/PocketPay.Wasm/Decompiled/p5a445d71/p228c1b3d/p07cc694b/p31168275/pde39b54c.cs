namespace WillowMaze.Wasm.Decompiled;


class pde39b54c : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.p853435af, p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938 {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c f19b8bd3e = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c f4a3f89c7 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c f55785013 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pde39b54c f9281abf6 = null;

    protected pde39b54c() {
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = ((p5a445d71.p228c1b3d.p07cc694b.pa2806f4a) obj).getChronology();
        if (chronology is null) {
            return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var);
        }
        if (chronology.getZone() == p34dacb78Var) {
            return chronology;
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithZone = chronology.withZone(p34dacb78Var);
        return p7bf898deVarWithZone is not null ? p7bf898deVarWithZone : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p7bf898deVar is not null ? p7bf898deVar : p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(((p5a445d71.p228c1b3d.p07cc694b.pa2806f4a) obj).getChronology());
    }

    public override long GetInstantMillis(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return ((p5a445d71.p228c1b3d.p07cc694b.pa2806f4a) obj).getMillis();
    }

    public override java.lang.Class<object> GetSupportedType() {
        return p5a445d71.p228c1b3d.p07cc694b.pa2806f4a.class;
    }
}

