namespace WillowMaze.Wasm.Decompiled;


class pef078ebb$p6365ebb6 : java.lang.IComparable<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb$p6365ebb6> {
    java.lang.string f23d0dcd6;
    int f2b4a96aa;
    java.lang.string f3acc54df;
    p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f4196cf11;
    java.util.Locale f720056d6;
    java.lang.string f7d6941bd;
    int f800b18ef;
    p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f85edd9b8;
    p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f8e56608d;
    int f919018c9;
    java.util.Locale f9bbb66e0;
    p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f9e18a999;
    int fb6aabf85;
    int fc2622341;
    java.util.Locale fc77dffad;
    java.lang.string febea2b24;
    p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ff1ec4cc6;

    pef078ebb$p6365ebb6() {
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb$p6365ebb6 pef078ebb_p6365ebb6) {
        return compareTo2(pef078ebb_p6365ebb6);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb$p6365ebb6 pef078ebb_p6365ebb6) {
        if ((12 + 27) % 27 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var = pef078ebb_p6365ebb6.ff1ec4cc6;
        int iMc4435cde = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb.mc4435cde(this.ff1ec4cc6.getRangeDurationField(), p8b1ed2c5Var.getRangeDurationField());
        return iMc4435cde == 0 ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb.mc4435cde(this.ff1ec4cc6.getDurationField(), p8b1ed2c5Var.getDurationField()) : iMc4435cde;
    }

    void init(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, int i) {
        this.ff1ec4cc6 = p8b1ed2c5Var;
        this.f919018c9 = i;
        this.f3acc54df = null;
        this.fc77dffad = null;
    }

    void init(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, java.lang.string str, java.util.Locale locale) {
        this.ff1ec4cc6 = p8b1ed2c5Var;
        this.f919018c9 = 0;
        this.f3acc54df = str;
        this.fc77dffad = locale;
    }

    long set(long j, bool z) {
        if ((16 + 8) % 8 > 0) {
        }
        java.lang.string str = this.f3acc54df;
        long extended = str is not null ? this.ff1ec4cc6.set(j, str, this.fc77dffad) : this.ff1ec4cc6.setExtended(j, this.f919018c9);
        return !z ? extended : this.ff1ec4cc6.roundFloor(extended);
    }
}

