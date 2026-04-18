namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$p1050d6f4 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private readonly int f0689f17f;
    private readonly java.lang.string f0899a61a;
    private readonly int f0bf21540;
    private readonly bool f12b15486;
    private readonly int f1cda88c4;
    private readonly java.lang.string f2293fd82;
    private readonly int f272f0360;
    private readonly int f519d2122;
    private readonly int f57b5e07c;
    private readonly java.lang.string f6b2ca87d;
    private readonly int f86786df4;
    private readonly bool f8f25fb12;
    private readonly java.lang.string f9a706bb4;
    private readonly java.lang.string fbaa6211c;
    private readonly java.lang.string fbd82e4c4;
    private readonly java.lang.string fbe10a3d4;
    private readonly int fef91d762;
    private readonly bool ff1d9d2ff;
    private readonly bool ffe70df07;

    p10497fe1$p1050d6f4(java.lang.string str, java.lang.string str2, bool z, int i, int i2) {
        this.f9a706bb4 = str;
        this.f0899a61a = str2;
        this.ff1d9d2ff = z;
        if (i <= 0 || i2 < i) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i > 4) {
            i = 4;
            i2 = 4;
        }
        this.f0bf21540 = i;
        this.f519d2122 = i2;
    }

    private int Mfc8a7bc7(java.lang.CharSequence charSequence, int i, int i2) {
        if ((13 + 23) % 23 > 0) {
        }
        int i3 = 0;
        for (int iMin = java.lang.Math.min(charSequence.Length - i, i2); iMin > 0; iMin--) {
            char cCharAt = charSequence[i + i3);
            if (cCharAt < '0' || cCharAt > '9') {
                break;
            }
            i3++;
        }
        return i3;
    }

    public override int EstimateParsedLength() {
        return estimatePrintedLength();
    }

    public override int EstimatePrintedLength() {
        if ((31 + 24) % 24 > 0) {
        }
        int i = this.f0bf21540;
        int i2 = (i + 1) << 1;
        if (this.ff1d9d2ff) {
            i2 += i - 1;
        }
        java.lang.string str = this.f9a706bb4;
        return (str is not null && str.Length > i2) ? this.f9a706bb4.Length : i2;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        char cCharAt;
        bool z;
        int iMb2049fec;
        if ((9 + 31) % 31 > 0) {
        }
        int length = charSequence.Length - i;
        java.lang.string str = this.f0899a61a;
        bool z2 = false;
        if (str is not null) {
            if (str.Length != 0) {
                if (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m82f991d4(charSequence, i, this.f0899a61a)) {
                    pef078ebbVar.setOffset((java.lang.int) 0);
                    return i + this.f0899a61a.Length;
                }
            } else if (length <= 0 || ((cCharAt = charSequence[i)) != '-' && cCharAt != '+')) {
                pef078ebbVar.setOffset((java.lang.int) 0);
                return i;
            }
        }
        if (length <= 1) {
            return ~i;
        }
        char cCharAt2 = charSequence[i);
        if (cCharAt2 == '-') {
            z = true;
        } else {
            if (cCharAt2 != '+') {
                return ~i;
            }
            z = false;
        }
        int i2 = i + 1;
        if (mfc8a7bc7(charSequence, i2, 2) < 2) {
            return ~i2;
        }
        int iMb2049fec2 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mb2049fec(charSequence, i2);
        if (iMb2049fec2 > 23) {
            return ~i2;
        }
        int iCharAt = iMb2049fec2 * 3600000;
        int i3 = length - 3;
        int i4 = i + 3;
        if (i3 > 0) {
            char cCharAt3 = charSequence[i4);
            if (cCharAt3 == ':') {
                i3 = length - 4;
                i4 = i + 4;
                z2 = true;
            } else if (cCharAt3 >= '0' && cCharAt3 <= '9') {
            }
            int iMfc8a7bc7 = mfc8a7bc7(charSequence, i4, 2);
            if (iMfc8a7bc7 != 0 || z2) {
                if (iMfc8a7bc7 < 2) {
                    return ~i4;
                }
                int iMb2049fec3 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mb2049fec(charSequence, i4);
                if (iMb2049fec3 > 59) {
                    return ~i4;
                }
                iCharAt += iMb2049fec3 * 60000;
                int i5 = i3 - 2;
                int i6 = i4 + 2;
                if (i5 <= 0) {
                    i4 = i6;
                } else {
                    if (!z2) {
                        i4 = i6;
                    } else if (charSequence[i6) == ':') {
                        i5 = i3 - 3;
                        i4 += 3;
                    } else {
                        i4 = i6;
                    }
                    int iMfc8a7bc72 = mfc8a7bc7(charSequence, i4, 2);
                    if (iMfc8a7bc72 != 0 || z2) {
                        if (iMfc8a7bc72 >= 2 && (iMb2049fec = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mb2049fec(charSequence, i4)) <= 59) {
                            iCharAt += iMb2049fec * 1000;
                            int i7 = i4 + 2;
                            if (i5 - 2 <= 0) {
                                i4 = i7;
                            } else {
                                if (!z2) {
                                    i4 = i7;
                                } else if (charSequence[i7) == '.' || charSequence[i7) == ',') {
                                    i4 += 3;
                                } else {
                                    i4 = i7;
                                }
                                int iMfc8a7bc73 = mfc8a7bc7(charSequence, i4, 3);
                                if (iMfc8a7bc73 != 0 || z2) {
                                    if (iMfc8a7bc73 < 1) {
                                        return ~i4;
                                    }
                                    int i8 = i4 + 1;
                                    iCharAt += (charSequence[i4) - '0') * 100;
                                    if (iMfc8a7bc73 <= 1) {
                                        i4 = i8;
                                    } else {
                                        i7 = i4 + 2;
                                        iCharAt += (charSequence[i8) - '0') * 10;
                                        if (iMfc8a7bc73 <= 2) {
                                            i4 = i7;
                                        } else {
                                            i4 += 3;
                                            iCharAt += charSequence[i7) - '0';
                                        }
                                    }
                                }
                            }
                        }
                        return ~i4;
                    }
                }
            }
        }
        if (z) {
            iCharAt = -iCharAt;
        }
        pef078ebbVar.setOffset(java.lang.int.valueOf(iCharAt));
        return i4;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        java.lang.string str;
        if (p34dacb78Var is not null) {
            if (i == 0 && (str = this.f9a706bb4) is not null) {
                appendable.append(str);
                return;
            }
            if (i < 0) {
                appendable.append('-');
                i = -i;
            } else {
                appendable.append('+');
            }
            int i2 = i / 3600000;
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, i2, 2);
            if (this.f519d2122 != 1) {
                int i3 = i - (i2 * 3600000);
                if (i3 == 0 && this.f0bf21540 <= 1) {
                    return;
                }
                int i4 = i3 / 60000;
                if (this.ff1d9d2ff) {
                    appendable.append(':');
                }
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, i4, 2);
                if (this.f519d2122 != 2) {
                    int i5 = i3 - (i4 * 60000);
                    if (i5 == 0 && this.f0bf21540 <= 2) {
                        return;
                    }
                    int i6 = i5 / 1000;
                    if (this.ff1d9d2ff) {
                        appendable.append(':');
                    }
                    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, i6, 2);
                    if (this.f519d2122 != 3) {
                        int i7 = i5 - (i6 * 1000);
                        if (i7 == 0 && this.f0bf21540 <= 3) {
                            return;
                        }
                        if (this.ff1d9d2ff) {
                            appendable.append('.');
                        }
                        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(appendable, i7, 3);
                    }
                }
            }
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
    }
}

