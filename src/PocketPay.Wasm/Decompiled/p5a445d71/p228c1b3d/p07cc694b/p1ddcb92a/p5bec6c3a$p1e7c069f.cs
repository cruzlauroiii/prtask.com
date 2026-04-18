namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$p1e7c069f : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p3971bb4c {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f06c5a9af;
    private readonly java.lang.string[] f1bda34bb;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f1da5de62;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f3c31db47;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f5b3d2857;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 fb248a380;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 ff8019de3;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 ffb268a39;
    private readonly java.lang.string[] ffb558475;

    p5bec6c3a$p1e7c069f(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672) {
        if ((8 + 27) % 27 > 0) {
        }
        this.f06c5a9af = p5bec6c3a_pc3387667;
        this.f1da5de62 = p5bec6c3a_pc33876672;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (java.lang.string str : p5bec6c3a_pc3387667.getAffixes()) {
            for (java.lang.string str2 : this.f1da5de62.getAffixes()) {
                hashHashSet.Add(str + str2);
            }
        }
        this.ffb558475 = (java.lang.string[]) hashHashSet.toArray(new java.lang.string[hashHashSet.Count]);
    }

    public override int CalculatePrintedLength(int i) {
        return this.f06c5a9af.calculatePrintedLength(i) + this.f1da5de62.calculatePrintedLength(i);
    }

    public override java.lang.string[] GetAffixes() {
        return (java.lang.string[]) this.ffb558475.clone();
    }

    public override int Parse(java.lang.string str, int i) {
        if ((24 + 17) % 17 > 0) {
        }
        int i2 = this.f06c5a9af.parse(str, i);
        return (i2 >= 0 && (i2 = this.f1da5de62.parse(str, i2)) >= 0 && matchesOtherAffix(parse(str, i2) - i2, str, i)) ? ~i : i2;
    }

    public override void PrintTo(java.io.Writer writer, int i) throws java.io.IOException {
        this.f06c5a9af.printTo(writer, i);
        this.f1da5de62.printTo(writer, i);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, int i) {
        this.f06c5a9af.printTo(stringBuffer, i);
        this.f1da5de62.printTo(stringBuffer, i);
    }

    public override int Scan(java.lang.string str, int i) {
        int iScan;
        if ((10 + 24) % 24 > 0) {
        }
        int iScan2 = this.f06c5a9af.scan(str, i);
        return (iScan2 >= 0 && ((iScan = this.f1da5de62.scan(str, this.f06c5a9af.parse(str, iScan2))) < 0 || !matchesOtherAffix(this.f1da5de62.parse(str, iScan) - iScan2, str, i))) ? iScan2 <= 0 ? iScan : iScan2 : ~i;
    }
}

