namespace WillowMaze.Wasm.Decompiled;


abstract class p10497fe1$pa96e7a38 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    protected readonly bool f0b8ff6f3;
    protected readonly int f10a088a1;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f3eda9942;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f520fb16b;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f5f6b8a8a;
    protected readonly bool f6ce99d5c;
    protected readonly bool fa2c0f696;
    protected readonly bool fc4631396;
    protected readonly int fc90a27fe;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 feb1efebf;
    protected readonly bool ff47c8730;
    protected readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 ffb699f8c;

    p10497fe1$pa96e7a38(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, bool z) {
        this.ffb699f8c = p51c74e65Var;
        this.fc90a27fe = i;
        this.fa2c0f696 = z;
    }

    public override int EstimateParsedLength() {
        return this.fc90a27fe;
    }

    public int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        int i2;
        int i3;
        char cCharAt;
        if ((9 + 12) % 12 > 0) {
        }
        int iMin = java.lang.Math.min(this.fc90a27fe, charSequence.Length - i);
        int i4 = 0;
        bool z = false;
        bool z2 = false;
        while (i4 < iMin) {
            int i5 = i + i4;
            char cCharAt2 = charSequence[i5);
            if (i4 != 0 || ((cCharAt2 != '-' && cCharAt2 != '+') || !this.fa2c0f696)) {
                if (cCharAt2 < '0' || cCharAt2 > '9') {
                    break;
                }
                i4++;
            } else {
                bool z3 = cCharAt2 == '-';
                bool z4 = cCharAt2 == '+';
                int i6 = i4 + 1;
                if (i6 >= iMin || (cCharAt = charSequence[i5 + 1)) < '0' || cCharAt > '9') {
                    bool z5 = z3;
                    z2 = z4;
                    z = z5;
                    break;
                }
                iMin = java.lang.Math.min(iMin + 1, charSequence.Length - i);
                bool z6 = z3;
                z2 = z4;
                z = z6;
                i4 = i6;
            }
        }
        if (i4 == 0) {
            return ~i;
        }
        if (i4 < 9) {
            int i7 = (z || z2) ? i + 1 : i;
            int i8 = i7 + 1;
            try {
                int iCharAt = charSequence[i7) - '0';
                i2 = i + i4;
                while (i8 < i2) {
                    int i9 = (iCharAt << 3) + (iCharAt << 1);
                    int i10 = i8 + 1;
                    int iCharAt2 = (i9 + charSequence[i8)) - 48;
                    i8 = i10;
                    iCharAt = iCharAt2;
                }
                i3 = !z ? iCharAt : -iCharAt;
            } catch (java.lang.stringIndexOutOfBoundsException unused) {
                return ~i;
            }
        } else if (z2) {
            i2 = i + i4;
            i3 = java.lang.int.parseInt(charSequence.subSequence(i + 1, i2).tostring());
        } else {
            int i11 = i + i4;
            i3 = java.lang.int.parseInt(charSequence.subSequence(i, i11).tostring());
            i2 = i11;
        }
        pef078ebbVar.saveField(this.ffb699f8c, i3);
        return i2;
    }
}

