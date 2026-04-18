namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$pef993538 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    protected int f0cc0cc64;
    protected int f1274527e;
    protected int f153aab5f;
    protected int f209a4b10;
    protected int f24adadc4;
    protected int f2dd53a73;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f5c2e4863;
    protected int f84ac4623;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fbe27b153;
    protected int fd954fb22;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 ffb699f8c;

    protected p10497fe1$pef993538(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2) {
        this.ffb699f8c = p51c74e65Var;
        i2 = i2 > 18 ? 18 : i2;
        this.f84ac4623 = i;
        this.fd954fb22 = i2;
    }

    private long[] Maf95e827(long j, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        long j2;
        if ((15 + 13) % 13 > 0) {
        }
        long unitMillis = p8b1ed2c5Var.getDurationField().getUnitMillis();
        int i = this.fd954fb22;
        while (true) {
            switch (i) {
                case 1:
                    j2 = 10;
                    break;
                case 2:
                    j2 = 100;
                    break;
                case 3:
                    j2 = 1000;
                    break;
                case 4:
                    j2 = 10000;
                    break;
                case 5:
                    j2 = 100000;
                    break;
                case 6:
                    j2 = 1000000;
                    break;
                case 7:
                    j2 = 10000000;
                    break;
                case 8:
                    j2 = 100000000;
                    break;
                case 9:
                    j2 = 1000000000;
                    break;
                case 10:
                    j2 = 10000000000L;
                    break;
                case 11:
                    j2 = 100000000000L;
                    break;
                case 12:
                    j2 = 1000000000000L;
                    break;
                case 13:
                    j2 = 10000000000000L;
                    break;
                case 14:
                    j2 = 100000000000000L;
                    break;
                case 15:
                    j2 = 1000000000000000L;
                    break;
                case 16:
                    j2 = 10000000000000000L;
                    break;
                case 17:
                    j2 = 100000000000000000L;
                    break;
                case 18:
                    j2 = 1000000000000000000L;
                    break;
                default:
                    j2 = 1;
                    break;
            }
            if ((unitMillis * j2) / j2 == unitMillis) {
                long j3 = (j * j2) / unitMillis;
                long j4 = i;
                long[] jArr = new long[2];
                jArr[0] = j3;
                jArr[1] = j4;
                return jArr;
            }
            i--;
        }
    }

    public override int EstimateParsedLength() {
        return this.fd954fb22;
    }

    public override int EstimatePrintedLength() {
        return this.fd954fb22;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        if ((22 + 8) % 8 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = this.ffb699f8c.getField(pef078ebbVar.getChronology());
        int iMin = java.lang.Math.min(this.fd954fb22, charSequence.Length - i);
        long unitMillis = field.getDurationField().getUnitMillis() * 10;
        long j = 0;
        int i2 = 0;
        while (i2 < iMin) {
            char cCharAt = charSequence[i + i2);
            if (cCharAt < '0' || cCharAt > '9') {
                break;
            }
            i2++;
            unitMillis /= 10;
            j += ((long) (cCharAt - '0')) * unitMillis;
        }
        long j2 = j / 10;
        if (i2 != 0 && j2 <= 2147483647L) {
            pef078ebbVar.saveField(new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p740e286a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9ca06283(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pa28e264d.f76425f17, field.getDurationField()), (int) j2);
            return i + i2;
        }
        return ~i;
    }

    protected void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) throws java.io.IOException {
        if ((24 + 22) % 22 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = this.ffb699f8c.getField(p7bf898deVar);
        int i = this.f84ac4623;
        try {
            long jRemainder = field.remainder(j);
            if (jRemainder != 0) {
                long[] jArrMaf95e827 = maf95e827(jRemainder, field);
                long j2 = jArrMaf95e827[0];
                int i2 = (int) jArrMaf95e827[1];
                java.lang.string string = (2147483647L & j2) != j2 ? java.lang.long.tostring(j2) : java.lang.int.tostring((int) j2);
                int length = string.Length;
                while (length < i2) {
                    appendable.append('0');
                    i--;
                    i2--;
                }
                if (i < i2) {
                    while (i < i2 && length > 1 && string[length - 1) == '0') {
                        i2--;
                        length--;
                    }
                    if (length < string.Length) {
                        for (int i3 = 0; i3 < length; i3++) {
                            appendable.append(string[i3));
                        }
                        return;
                    }
                }
                appendable.append(string);
                return;
            }
            while (true) {
                i--;
                if (i < 0) {
                    return;
                } else {
                    appendable.append('0');
                }
            }
        } catch (java.lang.Exception unused) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m09cad532(appendable, i);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        printTo(appendable, j, p7bf898deVar);
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        if ((31 + 29) % 29 > 0) {
        }
        printTo(appendable, p774107a9Var.getChronology().set(p774107a9Var, 0L), p774107a9Var.getChronology());
    }
}

