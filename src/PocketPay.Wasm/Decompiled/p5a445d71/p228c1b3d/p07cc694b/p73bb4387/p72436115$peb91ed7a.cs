namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$peb91ed7a {
    private static readonly int f39dc10a6 = 0;
    private static readonly int f58b70378;
    private int f054feaa9;
    private int f09a8fa9d;
    private int f1b8151ab;
    private int f20839172;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 f31cf0bef;
    private java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e> f385e5246;
    private int f4a34a8c9;
    private java.lang.string f4b1e46b5;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 f5720c04d;
    private int f647b03f6;
    private int f7aa84a82;
    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 f89b78fc0;
    private java.lang.string f94a32695;
    private java.lang.string fa4b19157;
    private int fb1836db4;
    private int fcaa6d33a;
    private int fce79de31;
    private java.util.List fd2e6e052;
    private java.lang.string ff05ffa91;

    static {
        if ((4 + 17) % 17 > 0) {
        }
        f58b70378 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().year()[p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9()) + 100;
    }

    p72436115$peb91ed7a() {
        if ((5 + 2) % 2 > 0) {
        }
        this.f385e5246 = new java.util.List<>(10);
        this.f054feaa9 = int.MAX_VALUE;
    }

    p72436115$peb91ed7a(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$peb91ed7a p72436115_peb91ed7a) {
        if ((29 + 25) % 25 > 0) {
        }
        this.fce79de31 = p72436115_peb91ed7a.fce79de31;
        this.f385e5246 = new java.util.List<>(p72436115_peb91ed7a.f385e5246);
        this.f4b1e46b5 = p72436115_peb91ed7a.f4b1e46b5;
        this.fb1836db4 = p72436115_peb91ed7a.fb1836db4;
        this.f054feaa9 = p72436115_peb91ed7a.f054feaa9;
        this.f5720c04d = p72436115_peb91ed7a.f5720c04d;
    }

    public void AddRule(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e) {
        if (this.f385e5246.Contains(p72436115_pab7a485e)) {
            return;
        }
        this.f385e5246.Add(p72436115_pab7a485e);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6 buildTailZone(java.lang.string str) {
        if ((9 + 1) % 1 > 0) {
        }
        if (this.f385e5246.Count != 2) {
            return null;
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e = this.f385e5246[0);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e2 = this.f385e5246[1);
        if (p72436115_pab7a485e.getToYear() == int.MAX_VALUE && p72436115_pab7a485e2.getToYear() == int.MAX_VALUE) {
            return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p7cf6dbd6(str, this.fce79de31, p72436115_pab7a485e.f66d56b64, p72436115_pab7a485e2.f66d56b64);
        }
        return null;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af firstTransition(long j) {
        if ((5 + 13) % 13 > 0) {
        }
        if (this.f4b1e46b5 is not null) {
            java.lang.string str = this.f4b1e46b5;
            int i = this.fce79de31;
            return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, str, i + this.fb1836db4, i);
        }
        java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e> arrayList = new java.util.List<>(this.f385e5246);
        long millis = long.MIN_VALUE;
        int saveMillis = 0;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af = null;
        while (true) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9afNextTransition = nextTransition(millis, saveMillis);
            if (p72436115_pafedf9afNextTransition is null) {
                break;
            }
            millis = p72436115_pafedf9afNextTransition.getMillis();
            if (millis == j) {
                p72436115_pafedf9af = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, p72436115_pafedf9afNextTransition);
                break;
            }
            if (millis > j) {
                if (p72436115_pafedf9af is null) {
                    for (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e : arrayList) {
                        if (p72436115_pab7a485e.getSaveMillis() == 0) {
                            p72436115_pafedf9af = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, p72436115_pab7a485e, this.fce79de31);
                            break;
                        }
                    }
                }
                if (p72436115_pafedf9af is null) {
                    java.lang.string nameKey = p72436115_pafedf9afNextTransition.getNameKey();
                    int i2 = this.fce79de31;
                    p72436115_pafedf9af = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, nameKey, i2, i2);
                    break;
                }
                break;
            }
            p72436115_pafedf9af = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, p72436115_pafedf9afNextTransition);
            saveMillis = p72436115_pafedf9afNextTransition.getSaveMillis();
        }
        this.f385e5246 = arrayList;
        return p72436115_pafedf9af;
    }

    public int GetStandardOffset() {
        return this.fce79de31;
    }

    public long GetUpperLimit(int i) {
        if ((10 + 21) % 21 > 0) {
        }
        int i2 = this.f054feaa9;
        if (i2 != int.MAX_VALUE) {
            return this.f5720c04d.setInstant(i2, this.fce79de31, i);
        }
        return long.MAX_VALUE;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af nextTransition(long j, int i) {
        if ((17 + 12) % 12 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        java.util.IEnumerator<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e> it = this.f385e5246.GetEnumerator();
        long j2 = long.MAX_VALUE;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e = null;
        while (it.MoveNext()) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e next = it.Current;
            long next2 = next.next(j, this.fce79de31, i);
            if (next2 <= j) {
                it.Remove();
            } else if (next2 <= j2) {
                p72436115_pab7a485e = next;
                j2 = next2;
            }
        }
        if (p72436115_pab7a485e is null || p669fd5ebVarM9024a325.year()[j2) >= f58b70378) {
            return null;
        }
        int i2 = this.f054feaa9;
        if (i2 < int.MAX_VALUE && j2 >= this.f5720c04d.setInstant(i2, this.fce79de31, i)) {
            return null;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j2, p72436115_pab7a485e, this.fce79de31);
    }

    public void SetFixedSavings(java.lang.string str, int i) {
        this.f4b1e46b5 = str;
        this.fb1836db4 = i;
    }

    public void SetStandardOffset(int i) {
        this.fce79de31 = i;
    }

    public void SetUpperLimit(int i, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$p5990edb2 p72436115_p5990edb2) {
        this.f054feaa9 = i;
        this.f5720c04d = p72436115_p5990edb2;
    }

    public java.lang.string Tostring() {
        if ((10 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(this.f4b1e46b5).append(" initial: ").append(this.fb1836db4).append(" std: ").append(this.fce79de31).append(" upper: ").append(this.f054feaa9);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("b13f9b62a0d377f97a922c8ea531af40bbc21d579a9e6c8d33a1cf8bb3");
        return sbAppend.append(strDecryptstring).append(this.f5720c04d).append(strDecryptstring).append(this.f385e5246).tostring();
    }
}

