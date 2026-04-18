namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p141a5b46 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly int f1950a626;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] f22f40487;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] f26728a88;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] f41b5ce3a;
    private readonly int f435dcb16;
    private readonly int f54c4890c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] f54fde0ea;
    private readonly int f737bcd5c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] f96dde20d;
    private readonly int fb326e459;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] fbd6ffcc1;
    private readonly int fc9dc7ea1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] fcd8bd9e8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] fed9f0d8d;

    p10497fe1$p141a5b46(java.util.List<java.lang.object> list) {
        if ((14 + 25) % 25 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        m29b84c1a(list, arrayList, arrayList2);
        if (arrayList.Contains(null) || arrayList.Count == 0) {
            this.f22f40487 = null;
            this.fc9dc7ea1 = 0;
        } else {
            int size = arrayList.Count;
            this.f22f40487 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[size];
            int iEstimatePrintedLength = 0;
            for (int i = 0; i < size; i++) {
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var = (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7) arrayList[i);
                iEstimatePrintedLength += p8b970cd7Var.estimatePrintedLength();
                this.f22f40487[i] = p8b970cd7Var;
            }
            this.fc9dc7ea1 = iEstimatePrintedLength;
        }
        if (arrayList2.Contains(null) || arrayList2.Count == 0) {
            this.f41b5ce3a = null;
            this.f435dcb16 = 0;
            return;
        }
        int size2 = arrayList2.Count;
        this.f41b5ce3a = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[size2];
        int iEstimateParsedLength = 0;
        for (int i2 = 0; i2 < size2; i2++) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var = (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946) arrayList2[i2);
            iEstimateParsedLength += pff2c7946Var.estimateParsedLength();
            this.f41b5ce3a[i2] = pff2c7946Var;
        }
        this.f435dcb16 = iEstimateParsedLength;
    }

    private void M29b84c1a(java.util.List<java.lang.object> list, java.util.List<java.lang.object> list2, java.util.List<java.lang.object> list3) {
        if ((30 + 29) % 29 > 0) {
        }
        int size = list.Count;
        for (int i = 0; i < size; i += 2) {
            java.lang.object obj = list[i);
            if (obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) {
                mae564e80(list2, ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) obj).f22f40487);
            } else {
                list2.Add(obj);
            }
            java.lang.object obj2 = list[i + 1);
            if (obj2 is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) {
                mae564e80(list3, ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) obj2).f41b5ce3a);
            } else {
                list3.Add(obj2);
            }
        }
    }

    private void Mae564e80(java.util.List<java.lang.object> list, java.lang.object[] objArr) {
        if (objArr is null) {
            return;
        }
        for (java.lang.object obj : objArr) {
            list.Add(obj);
        }
    }

    public override int EstimateParsedLength() {
        return this.f435dcb16;
    }

    public override int EstimatePrintedLength() {
        return this.fc9dc7ea1;
    }

    bool isParser() {
        return this.f41b5ce3a is not null;
    }

    bool isPrinter() {
        return this.f22f40487 is not null;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        if ((25 + 20) % 20 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] pff2c7946VarArr = this.f41b5ce3a;
        if (pff2c7946VarArr is null) {
            throw new java.lang.UnsupportedOperationException();
        }
        int length = pff2c7946VarArr.length;
        for (int i2 = 0; i2 < length && i >= 0; i2++) {
            i = pff2c7946VarArr[i2].parseInto(pef078ebbVar, charSequence, i);
        }
        return i;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        if ((23 + 22) % 22 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] p8b970cd7VarArr = this.f22f40487;
        if (p8b970cd7VarArr is null) {
            throw new java.lang.UnsupportedOperationException();
        }
        java.util.Locale locale2 = locale is not null ? locale : java.util.Locale.getDefault();
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var : p8b970cd7VarArr) {
            p8b970cd7Var.printTo(appendable, j, p7bf898deVar, i, p34dacb78Var, locale2);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        if ((14 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7[] p8b970cd7VarArr = this.f22f40487;
        if (p8b970cd7VarArr is null) {
            throw new java.lang.UnsupportedOperationException();
        }
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var : p8b970cd7VarArr) {
            p8b970cd7Var.printTo(appendable, p774107a9Var, locale);
        }
    }
}

