namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p51949957 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p223f51d7 {
    protected p10497fe1$p51949957(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, bool z) {
        super(p51c74e65Var, i, z, i);
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        int i2;
        int into = super.parseInto(pef078ebbVar, charSequence, i);
        if (into >= 0 && into != (i2 = this.fc90a27fe + i)) {
            if (this.fa2c0f696) {
                char cCharAt = charSequence[i);
                if (cCharAt == '-' || cCharAt == '+') {
                    i2++;
                }
            }
            if (into > i2) {
                return ~(i2 + 1);
            }
            if (into < i2) {
                return ~into;
            }
        }
        return into;
    }
}

