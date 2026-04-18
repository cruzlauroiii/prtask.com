namespace WillowMaze.Wasm.Decompiled;


class pd8eae72c : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938 {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pd8eae72c f448dddfa = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pd8eae72c f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.pd8eae72c();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pd8eae72c fb68a6c19 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.pd8eae72c fd6b6d849 = null;

    protected pd8eae72c() {
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((14 + 26) % 26 > 0) {
        }
        return getChronology(obj, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null).withZone(p34dacb78Var);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p7bf898deVar is not null ? p7bf898deVar : p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(((p5a445d71.p228c1b3d.p07cc694b.p774107a9) obj).getChronology());
    }

    public override int[] GetPartialValues(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((4 + 18) % 18 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var2 = (p5a445d71.p228c1b3d.p07cc694b.p774107a9) obj;
        int size = p774107a9Var.Count;
        int[] iArr = new int[size];
        for (int i = 0; i < size; i++) {
            iArr[i] = p774107a9Var2[p774107a9Var.getFieldType(i));
        }
        p7bf898deVar.validate(p774107a9Var, iArr);
        return iArr;
    }

    public override java.lang.Class<object> GetSupportedType() {
        return p5a445d71.p228c1b3d.p07cc694b.p774107a9.class;
    }
}

