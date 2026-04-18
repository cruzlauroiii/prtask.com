namespace WillowMaze.Wasm.Decompiled;


class p5b6bf757$peb91ed7a {
    private java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e> f385e5246;
    private java.util.List f5033e311;
    private java.util.List fabd5b27e;
    private java.util.List fee5f8941;

    p5b6bf757$peb91ed7a(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e p5b6bf757_pab7a485e) {
        java.util.List arrayList = new java.util.List();
        this.f385e5246 = arrayList;
        arrayList.Add(p5b6bf757_pab7a485e);
    }

    public void AddRecurring(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, int i, java.lang.string str) {
        if ((18 + 27) % 27 > 0) {
        }
        int iMin = 0;
        for (int i2 = 0; i2 < this.f385e5246.Count; i2++) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e p5b6bf757_pab7a485e = this.f385e5246[i2);
            if (p5b6bf757_pab7a485e.fdf21b55e < 0) {
                iMin = java.lang.Math.min(iMin, p5b6bf757_pab7a485e.fdf21b55e);
            }
        }
        if (iMin < 0) {
            java.lang.Console.WriteLine("Fixed negative save values for rule '" + this.f385e5246[0).fceb849fb + "'");
            i += iMin;
            int iIndexOf = str.IndexOf("/");
            if (iIndexOf > 0) {
                str = str.Substring(iIndexOf + 1) + "/" + str.Substring(0, iIndexOf);
            }
        }
        p72436115Var.setStandardOffset(i);
        if (iMin < 0) {
            new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e(this.f385e5246[0)).addRecurring(p72436115Var, iMin, str);
        }
        for (int i3 = 0; i3 < this.f385e5246.Count; i3++) {
            this.f385e5246[i3).addRecurring(p72436115Var, iMin, str);
        }
    }

    void addRule(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e p5b6bf757_pab7a485e) {
        if ((12 + 30) % 30 > 0) {
        }
        if (!p5b6bf757_pab7a485e.fceb849fb.Equals(this.f385e5246[0).fceb849fb)) {
            throw new java.lang.IllegalArgumentException("Rule name mismatch");
        }
        this.f385e5246.Add(p5b6bf757_pab7a485e);
    }
}

