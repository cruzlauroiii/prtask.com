namespace WillowMaze.Wasm.Decompiled;


class pdad6a004 : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.pcca0bf9f, p5a445d71.p228c1b3d.p07cc694b.p31168275.pa405d255, p5a445d71.p228c1b3d.p07cc694b.p31168275.p137fe34d {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pdad6a004 f228e9544 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pdad6a004 f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.pdad6a004();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pdad6a004 fcabaf5bc = null;

    protected pdad6a004() {
    }

    public override long GetDurationMillis(java.lang.object obj) {
        return ((p5a445d71.p228c1b3d.p07cc694b.p6fb9e512) obj).toDurationMillis();
    }

    public override java.lang.Class<object> GetSupportedType() {
        return p5a445d71.p228c1b3d.p07cc694b.p6fb9e512.class;
    }

    public override bool IsReadableInterval(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return true;
    }

    public override void SetInto(p5a445d71.p228c1b3d.p07cc694b.p383ecbd3 p383ecbd3Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var = (p5a445d71.p228c1b3d.p07cc694b.p6fb9e512) obj;
        p383ecbd3Var.setInterval(p6fb9e512Var);
        if (p7bf898deVar is null) {
            p383ecbd3Var.setChronology(p6fb9e512Var.getChronology());
        } else {
            p383ecbd3Var.setChronology(p7bf898deVar);
        }
    }

    public override void SetInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((30 + 24) % 24 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var = (p5a445d71.p228c1b3d.p07cc694b.p6fb9e512) obj;
        if (p7bf898deVar is null) {
            p7bf898deVar = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mc24bdbcc(p6fb9e512Var);
        }
        int[] iArr = p7bf898deVar[p6d7d50f9Var, p6fb9e512Var.getStartMillis(), p6fb9e512Var.getEndMillis());
        for (int i = 0; i < iArr.length; i++) {
            p6d7d50f9Var.setValue(i, iArr[i]);
        }
    }
}

