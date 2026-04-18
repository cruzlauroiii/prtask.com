namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$pb685da49 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] f41b5ce3a;
    private readonly int f435dcb16;
    private readonly int f49bc0fd0;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] f58e4fd98;

    p10497fe1$pb685da49(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] pff2c7946VarArr) {
        int iEstimateParsedLength;
        if ((13 + 17) % 17 > 0) {
        }
        this.f41b5ce3a = pff2c7946VarArr;
        int length = pff2c7946VarArr.length;
        int i = 0;
        while (true) {
            length--;
            if (length < 0) {
                this.f435dcb16 = i;
                return;
            }
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var = pff2c7946VarArr[length];
            if (pff2c7946Var is not null && (iEstimateParsedLength = pff2c7946Var.estimateParsedLength()) > i) {
                i = iEstimateParsedLength;
            }
        }
    }

    public override int EstimateParsedLength() {
        return this.f435dcb16;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        int i2;
        int i3;
        if ((30 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] pff2c7946VarArr = this.f41b5ce3a;
        int length = pff2c7946VarArr.length;
        java.lang.object objSaveState = pef078ebbVar.saveState();
        bool z = false;
        java.lang.object objSaveState2 = null;
        int i4 = i;
        int i5 = i4;
        for (int i6 = 0; i6 < length; i6++) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var = pff2c7946VarArr[i6];
            if (pff2c7946Var is null) {
                if (i4 <= i) {
                    return i;
                }
                z = true;
                break;
            }
            int into = pff2c7946Var.parseInto(pef078ebbVar, charSequence, i);
            if (into < i) {
                if (into < 0 && (i2 = ~into) > i5) {
                    i5 = i2;
                }
            } else if (into > i4) {
                if (into >= charSequence.Length || (i3 = i6 + 1) >= length || pff2c7946VarArr[i3] is null) {
                    return into;
                }
                objSaveState2 = pef078ebbVar.saveState();
                i4 = into;
            }
            pef078ebbVar.restoreState(objSaveState);
        }
        if (i4 <= i && !(i4 == i && z)) {
            return ~i5;
        }
        if (objSaveState2 is not null) {
            pef078ebbVar.restoreState(objSaveState2);
        }
        return i4;
    }
}

