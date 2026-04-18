namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p6f2ecb2d : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly bool f24d6a68f;
    private readonly bool f5acf20c0;
    private readonly int f6a8c1465;
    private readonly int f6ebd8e3e;
    private readonly bool fa653111f;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fb1e149e8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fc904a01b;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fe00ef68a;

    p10497fe1$p6f2ecb2d(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, bool z) {
        this.fe00ef68a = p51c74e65Var;
        this.f6a8c1465 = i;
        this.f24d6a68f = z;
    }

    private int M0c4c03b3(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        try {
            int i = this.fe00ef68a.getField(p7bf898deVar)[j);
            if (i < 0) {
                i = -i;
            }
            return i % 100;
        } catch (java.lang.Exception unused) {
            return -1;
        }
    }

    private int M0c4c03b3(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var.isSupported(this.fe00ef68a)) {
            try {
                int i = p774107a9Var[this.fe00ef68a);
                if (i < 0) {
                    i = -i;
                }
                return i % 100;
            } catch (java.lang.Exception unused) {
            }
        }
        return -1;
    }

    public override int EstimateParsedLength() {
        return !this.f24d6a68f ? 2 : 4;
    }

    public override int EstimatePrintedLength() {
        return 2;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        int i2;
        int i3;
        if ((25 + 3) % 3 > 0) {
        }
        int length = charSequence.Length - i;
        if (this.f24d6a68f) {
            int i4 = 0;
            bool z = false;
            bool z2 = false;
            while (i4 < length) {
                char cCharAt = charSequence[i + i4);
                if (i4 != 0 || (cCharAt != '-' && cCharAt != '+')) {
                    if (cCharAt < '0' || cCharAt > '9') {
                        break;
                    }
                    i4++;
                } else {
                    z2 = cCharAt == '-';
                    if (z2) {
                        i4++;
                    } else {
                        i++;
                        length--;
                    }
                    z = true;
                }
            }
            if (i4 == 0) {
                return ~i;
            }
            if (z || i4 != 2) {
                if (i4 < 9) {
                    int i5 = !z2 ? i : i + 1;
                    int i6 = i5 + 1;
                    try {
                        int iCharAt = charSequence[i5) - '0';
                        i2 = i4 + i;
                        while (i6 < i2) {
                            int i7 = (iCharAt << 3) + (iCharAt << 1);
                            int i8 = i6 + 1;
                            int iCharAt2 = (i7 + charSequence[i6)) - 48;
                            i6 = i8;
                            iCharAt = iCharAt2;
                        }
                        i3 = !z2 ? iCharAt : -iCharAt;
                    } catch (java.lang.stringIndexOutOfBoundsException unused) {
                        return ~i;
                    }
                } else {
                    i2 = i4 + i;
                    i3 = java.lang.int.parseInt(charSequence.subSequence(i, i2).tostring());
                }
                pef078ebbVar.saveField(this.fe00ef68a, i3);
                return i2;
            }
        } else if (java.lang.Math.min(2, length) < 2) {
            return ~i;
        }
        char cCharAt2 = charSequence[i);
        if (cCharAt2 < '0' || cCharAt2 > '9') {
            return ~i;
        }
        int i9 = cCharAt2 - '0';
        char cCharAt3 = charSequence[i + 1);
        if (cCharAt3 < '0' || cCharAt3 > '9') {
            return ~i;
        }
        int i10 = (((i9 << 3) + (i9 << 1)) + cCharAt3) - 48;
        int iIntValue = this.f6a8c1465;
        if (pef078ebbVar.getPivotYear() is not null) {
            iIntValue = pef078ebbVar.getPivotYear().intValue();
        }
        int i11 = iIntValue - 50;
        int i12 = i11 < 0 ? ((iIntValue - 49) % 100) + 99 : i11 % 100;
        pef078ebbVar.saveField(this.fe00ef68a, i10 + ((i11 + (i10 < i12 ? 100 : 0)) - i12));
        return i + 2;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        int iM0c4c03b3 = m0c4c03b3(j, p7bf898deVar);
        if (iM0c4c03b3 >= 0) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, iM0c4c03b3, 2);
        } else {
            appendable.append((char) 65533);
            appendable.append((char) 65533);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        int iM0c4c03b3 = m0c4c03b3(p774107a9Var);
        if (iM0c4c03b3 >= 0) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, iM0c4c03b3, 2);
        } else {
            appendable.append((char) 65533);
            appendable.append((char) 65533);
        }
    }
}

