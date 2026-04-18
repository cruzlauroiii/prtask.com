namespace WillowMaze.Wasm.Decompiled;


readonly class p33e58a9f : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.p853435af, p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938 {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p33e58a9f f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p33e58a9f();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p33e58a9f f868b0309 = null;

    protected p33e58a9f() {
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((11 + 6) % 6 > 0) {
        }
        if (obj.GetType().getName().EndsWith(".BuddhistDateTime")) {
            return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8d57f7eb.m8bab0102(p34dacb78Var);
        }
        if (!(obj is java.util.GregorianDateTime)) {
            return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var);
        }
        long time = ((java.util.GregorianDateTime) obj).getGregorianChange().getTime();
        return time != long.MIN_VALUE ? time != long.MAX_VALUE ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.m8bab0102(p34dacb78Var, time, 4) : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p343ff6a9.m8bab0102(p34dacb78Var) : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p661c135e.m8bab0102(p34dacb78Var);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMa330146e;
        if (p7bf898deVar is not null) {
            return p7bf898deVar;
        }
        java.util.DateTime calendar = (java.util.DateTime) obj;
        try {
            p34dacb78VarMa330146e = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.m3b0e9f8b(calendar.getTimeZone());
        } catch (java.lang.IllegalArgumentException unused) {
            p34dacb78VarMa330146e = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        return getChronology(calendar, p34dacb78VarMa330146e);
    }

    public override long GetInstantMillis(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return ((java.util.DateTime) obj).getTime().getTime();
    }

    public override java.lang.Class<object> GetSupportedType() {
        return java.util.DateTime.class;
    }
}

