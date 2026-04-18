namespace WillowMaze.Wasm.Decompiled;


class pa41a5325 : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.pa405d255, p5a445d71.p228c1b3d.p07cc694b.p31168275.p137fe34d {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pa41a5325 f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.pa41a5325();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pa41a5325 ff7de0ec3 = null;

    protected pa41a5325() {
    }

    public override long GetDurationMillis(java.lang.object obj) {
        return ((p5a445d71.p228c1b3d.p07cc694b.p3f224b4c) obj).getMillis();
    }

    public override java.lang.Class<object> GetSupportedType() {
        return p5a445d71.p228c1b3d.p07cc694b.p3f224b4c.class;
    }

    public override void SetInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        int[] iArr = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar)[p6d7d50f9Var, ((p5a445d71.p228c1b3d.p07cc694b.p3f224b4c) obj).getMillis());
        for (int i = 0; i < iArr.length; i++) {
            p6d7d50f9Var.setValue(i, iArr[i]);
        }
    }
}

