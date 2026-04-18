namespace WillowMaze.Wasm.Decompiled;


public abstract class paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.p60ad5b1d {
    protected paf625b95() {
    }

    public p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
    }

    public long GetInstantMillis(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
    }

    public int[] GetPartialValues(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((14 + 19) % 19 > 0) {
        }
        return p7bf898deVar[p774107a9Var, getInstantMillis(obj, p7bf898deVar));
    }

    public int[] GetPartialValues(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        return getPartialValues(p774107a9Var, obj, p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8349feac GetPeriodType(java.lang.object obj) {
        return p5a445d71.p228c1b3d.p07cc694b.p8349feac.mc00f0c46();
    }

    public bool IsReadableInterval(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return false;
    }

    public java.lang.string Tostring() {
        if ((20 + 25) % 25 > 0) {
        }
        return "Converter[" + (getSupportedType() is not null ? getSupportedType().getName() : com.decryptstringmanager.Decryptstring.decryptstring("13d00d3027638c097ab6b9ac1bf3d8e8a62b90207dc4fb9eee652c6a29682152")) + "]";
    }
}

