namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$pf98c04ed : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 {
    private readonly int f0093c059;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f0f9740ea;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f1d705cf0;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f26425eeb;
    private readonly int f272a666f;
    private readonly int f2e5ad613;
    private readonly int f30f086c2;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f32d18744;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f38420fbb;
    private readonly int f437ae0dc;
    private readonly int f4bea7ff7;
    private readonly int f5f38d71d;
    private readonly int f672004bd;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] f69af2be9;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] f6cb8b7da;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f8a900c99;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 f8b870545;
    private readonly bool faabbe301;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 fc319215a;
    private readonly int fc90a27fe;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 fca881369;
    private readonly int fcc2ee858;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 fceafcb91;
    private readonly int fd533ba1b;
    private readonly int fd98ddb10;
    private readonly int fda4b32d4;
    private readonly bool fee63cf59;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] ff50506c2;
    private readonly int ffb699f8c;
    private readonly int ffcac5c7a;

    p5bec6c3a$pf98c04ed(int i, int i2, int i3, bool z, int i4, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] p5bec6c3a_pf98c04edArr, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672) {
        this.f4bea7ff7 = i;
        this.ffcac5c7a = i2;
        this.fc90a27fe = i3;
        this.fee63cf59 = z;
        this.ffb699f8c = i4;
        this.ff50506c2 = p5bec6c3a_pf98c04edArr;
        this.f32d18744 = p5bec6c3a_pc3387667;
        this.fceafcb91 = p5bec6c3a_pc33876672;
    }

    p5bec6c3a$pf98c04ed(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed p5bec6c3a_pf98c04ed, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667) {
        this.f4bea7ff7 = p5bec6c3a_pf98c04ed.f4bea7ff7;
        this.ffcac5c7a = p5bec6c3a_pf98c04ed.ffcac5c7a;
        this.fc90a27fe = p5bec6c3a_pf98c04ed.fc90a27fe;
        this.fee63cf59 = p5bec6c3a_pf98c04ed.fee63cf59;
        this.ffb699f8c = p5bec6c3a_pf98c04ed.ffb699f8c;
        this.ff50506c2 = p5bec6c3a_pf98c04ed.ff50506c2;
        this.f32d18744 = p5bec6c3a_pf98c04ed.f32d18744;
        this.fceafcb91 = p5bec6c3a_pf98c04ed.fceafcb91 is not null ? new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p1e7c069f(p5bec6c3a_pf98c04ed.fceafcb91, p5bec6c3a_pc3387667) : p5bec6c3a_pc3387667;
    }

    private int M1c4051b5(java.lang.string str, int i, int i2) {
        if ((5 + 27) % 27 > 0) {
        }
        if (i2 >= 10) {
            return java.lang.int.parseInt(str.Substring(i, i2 + i));
        }
        bool z = false;
        if (i2 <= 0) {
            return 0;
        }
        int i3 = i + 1;
        char cCharAt = str[i);
        int i4 = i2 - 1;
        if (cCharAt == '-') {
            i4 = i2 - 2;
            if (i4 < 0) {
                return 0;
            }
            int i5 = i + 2;
            cCharAt = str[i3);
            z = true;
            i3 = i5;
        }
        int i6 = cCharAt - '0';
        while (true) {
            int i7 = i4 - 1;
            if (i4 <= 0) {
                break;
            }
            int i8 = (i6 << 3) + (i6 << 1);
            int i9 = i3 + 1;
            int iCharAt = (i8 + str[i3)) - 48;
            i4 = i7;
            i3 = i9;
            i6 = iCharAt;
        }
        return !z ? i6 : -i6;
    }

    public override int CalculatePrintedLength(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        if ((2 + 27) % 27 > 0) {
        }
        long fieldValue = getFieldValue(p56be9880Var);
        if (fieldValue == long.MAX_VALUE) {
            return 0;
        }
        int iMax = java.lang.Math.max(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.m3d109d35(fieldValue), this.f4bea7ff7);
        if (this.ffb699f8c >= 8) {
            int iMax2 = java.lang.Math.max(iMax, fieldValue >= 0 ? 4 : 5);
            iMax = (this.ffb699f8c == 9 && java.lang.Math.abs(fieldValue) % 1000 == 0) ? iMax2 - 3 : iMax2 + 1;
            fieldValue /= 1000;
        }
        int i = (int) fieldValue;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667 = this.f32d18744;
        if (p5bec6c3a_pc3387667 is not null) {
            iMax += p5bec6c3a_pc3387667.calculatePrintedLength(i);
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672 = this.fceafcb91;
        return p5bec6c3a_pc33876672 is null ? iMax : iMax + p5bec6c3a_pc33876672.calculatePrintedLength(i);
    }

    public override int CountFieldsToPrint(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i, java.util.Locale locale) {
        if ((16 + 6) % 6 > 0) {
        }
        if (i > 0) {
            return (this.ffcac5c7a != 4 && getFieldValue(p56be9880Var) == long.MAX_VALUE) ? 0 : 1;
        }
        return 0;
    }

    public void Finish(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] p5bec6c3a_pf98c04edArr) {
        if ((18 + 4) % 4 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet2 = new java.util.HashHashSet();
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed p5bec6c3a_pf98c04ed : p5bec6c3a_pf98c04edArr) {
            if (p5bec6c3a_pf98c04ed is not null && !equals(p5bec6c3a_pf98c04ed)) {
                hashHashSet.Add(p5bec6c3a_pf98c04ed.f32d18744);
                hashHashSet2.Add(p5bec6c3a_pf98c04ed.fceafcb91);
            }
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667 = this.f32d18744;
        if (p5bec6c3a_pc3387667 is not null) {
            p5bec6c3a_pc3387667.finish(hashHashSet);
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672 = this.fceafcb91;
        if (p5bec6c3a_pc33876672 is null) {
            return;
        }
        p5bec6c3a_pc33876672.finish(hashHashSet2);
    }

    int getFieldType() {
        return this.ffb699f8c;
    }

    long getFieldValue(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        int i;
        long j;
        int i2;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] p5bec6c3a_pf98c04edArr;
        int i3;
        int iMin;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pf98c04ed[] p5bec6c3a_pf98c04edArr2;
        int i4;
        int i5;
        if ((17 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8349feac periodType = this.ffcac5c7a != 4 ? p56be9880Var.getPeriodType() : null;
        if (periodType is not null && !isSupported(periodType, this.ffb699f8c)) {
            return long.MAX_VALUE;
        }
        switch (this.ffb699f8c) {
            case 0:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin) && this.ff50506c2[iMin] is not null) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                for (i5 = i4 + 1; i5 <= 9; i5++) {
                                    if (!isSupported(periodType, i5) && this.ff50506c2[i5] is not null) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 1:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 2:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.mae60f11a());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 3:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 4:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m73cdddd7());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 5:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m640fd0cc());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 6:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 7:
                i = p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e());
                j = i;
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            case 8:
            case 9:
                j = (((long) p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29())) * 1000) + ((long) p56be9880Var[p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e()));
                if (j == 0) {
                    i2 = this.ffcac5c7a;
                    if (i2 == 1) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr = this.ff50506c2;
                            i3 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr[i3] == this) {
                                iMin = java.lang.Math.min(i3, 8);
                                while (true) {
                                    iMin--;
                                    if (iMin >= 0) {
                                        if (!isSupported(periodType, iMin)) {
                                        }
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 2) {
                        if (isZero(p56be9880Var)) {
                            p5bec6c3a_pf98c04edArr2 = this.ff50506c2;
                            i4 = this.ffb699f8c;
                            if (p5bec6c3a_pf98c04edArr2[i4] == this) {
                                while (i5 <= 9) {
                                    if (!isSupported(periodType, i5)) {
                                        return long.MAX_VALUE;
                                    }
                                }
                            }
                        }
                        return long.MAX_VALUE;
                    }
                    if (i2 == 5) {
                        return long.MAX_VALUE;
                    }
                }
                return j;
            default:
                return long.MAX_VALUE;
        }
    }

    bool isSupported(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar, int i) {
        switch (i) {
            case 0:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e());
            case 1:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf());
            case 2:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mae60f11a());
            case 3:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47());
            case 4:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m73cdddd7());
            case 5:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m640fd0cc());
            case 6:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29());
            case 7:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e());
            case 8:
            case 9:
                return p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29()) || p8349feacVar.isSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e());
            default:
                return false;
        }
    }

    bool isZero(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((2 + 10) % 10 > 0) {
        }
        int size = p56be9880Var.Count;
        for (int i = 0; i < size; i++) {
            if (p56be9880Var.getValue(i) != 0) {
                return false;
            }
        }
        return true;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i, java.util.Locale locale) {
        int iScan;
        int i2;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667;
        char cCharAt;
        if ((18 + 2) % 2 > 0) {
        }
        int i3 = i;
        bool z = this.ffcac5c7a == 4;
        if (i3 >= str.Length) {
            return !z ? i3 : ~i3;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672 = this.f32d18744;
        if (p5bec6c3a_pc33876672 is not null) {
            i3 = p5bec6c3a_pc33876672.parse(str, i3);
            if (i3 < 0) {
                return z ? i3 : ~i3;
            }
            z = true;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876673 = this.fceafcb91;
        int i4 = -1;
        if (p5bec6c3a_pc33876673 is null || z) {
            iScan = -1;
        } else {
            iScan = p5bec6c3a_pc33876673.scan(str, i3);
            if (iScan < 0) {
                return z ? iScan : ~iScan;
            }
            z = true;
        }
        if (!z && !isSupported(p6d7d50f9Var.getPeriodType(), this.ffb699f8c)) {
            return i3;
        }
        int iMin = iScan <= 0 ? java.lang.Math.min(this.fc90a27fe, str.Length - i3) : java.lang.Math.min(this.fc90a27fe, iScan - i3);
        int i5 = 0;
        bool z2 = false;
        bool z3 = false;
        while (true) {
            if (i5 >= iMin) {
                i2 = 1;
                break;
            }
            int i6 = i3 + i5;
            char cCharAt2 = str[i6);
            i2 = 1;
            if (i5 == 0 && ((cCharAt2 == '-' || cCharAt2 == '+') && !this.fee63cf59)) {
                z3 = cCharAt2 == '-';
                int i7 = i5 + 1;
                if (i7 >= iMin || (cCharAt = str[i6 + 1)) < '0' || cCharAt > '9') {
                    break;
                }
                if (z3) {
                    i5 = i7;
                } else {
                    i3++;
                }
                iMin = java.lang.Math.min(iMin + 1, str.Length - i3);
            } else {
                if (cCharAt2 >= '0' && cCharAt2 <= '9') {
                    z2 = true;
                } else {
                    if (cCharAt2 != '.' && cCharAt2 != ',') {
                        break;
                    }
                    int i8 = this.ffb699f8c;
                    if (!(i8 == 8 || i8 == 9) || i4 >= 0) {
                        break;
                    }
                    int i9 = i6 + 1;
                    iMin = java.lang.Math.min(iMin + 1, str.Length - i3);
                    i4 = i9;
                }
                i5++;
            }
        }
        if (!z2) {
            return ~i3;
        }
        if (iScan >= 0 && i3 + i5 != iScan) {
            return i3;
        }
        int i10 = this.ffb699f8c;
        if (i10 != 8 && i10 != 9) {
            setFieldValue(p6d7d50f9Var, i10, m1c4051b5(str, i3, i5));
        } else if (i4 >= 0) {
            int iM1c4051b5 = 0;
            int iM1c4051b52 = m1c4051b5(str, i3, (i4 - i3) - 1);
            setFieldValue(p6d7d50f9Var, 6, iM1c4051b52);
            int i11 = (i3 + i5) - i4;
            if (i11 > 0) {
                if (i11 < 3) {
                    int iM1c4051b53 = m1c4051b5(str, i4, i11);
                    iM1c4051b5 = i11 != i2 ? iM1c4051b53 * 10 : iM1c4051b53 * 100;
                } else {
                    iM1c4051b5 = m1c4051b5(str, i4, 3);
                }
                if (z3 || iM1c4051b52 < 0) {
                    iM1c4051b5 = -iM1c4051b5;
                }
            }
            setFieldValue(p6d7d50f9Var, 7, iM1c4051b5);
        } else {
            setFieldValue(p6d7d50f9Var, 6, m1c4051b5(str, i3, i5));
            setFieldValue(p6d7d50f9Var, 7, 0);
        }
        int i12 = i3 + i5;
        return (i12 >= 0 && (p5bec6c3a_pc3387667 = this.fceafcb91) is not null) ? p5bec6c3a_pc3387667.parse(str, i12) : i12;
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) throws java.io.IOException {
        if ((3 + 29) % 29 > 0) {
        }
        long fieldValue = getFieldValue(p56be9880Var);
        if (fieldValue != long.MAX_VALUE) {
            int i = (int) fieldValue;
            if (this.ffb699f8c >= 8) {
                i = (int) (fieldValue / 1000);
            }
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667 = this.f32d18744;
            if (p5bec6c3a_pc3387667 is not null) {
                p5bec6c3a_pc3387667.printTo(writer, i);
            }
            int i2 = this.f4bea7ff7;
            if (i2 > 1) {
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.m9b1d7eb3(writer, i, i2);
            } else {
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.m7b91ee8e(writer, i);
            }
            if (this.ffb699f8c >= 8) {
                int iAbs = (int) (java.lang.Math.abs(fieldValue) % 1000);
                if (this.ffb699f8c == 8 || iAbs > 0) {
                    writer.write(46);
                    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.m9b1d7eb3(writer, iAbs, 3);
                }
            }
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672 = this.fceafcb91;
            if (p5bec6c3a_pc33876672 is null) {
                return;
            }
            p5bec6c3a_pc33876672.printTo(writer, i);
        }
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        if ((9 + 31) % 31 > 0) {
        }
        long fieldValue = getFieldValue(p56be9880Var);
        if (fieldValue != long.MAX_VALUE) {
            int i = (int) fieldValue;
            if (this.ffb699f8c >= 8) {
                i = (int) (fieldValue / 1000);
            }
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc3387667 = this.f32d18744;
            if (p5bec6c3a_pc3387667 is not null) {
                p5bec6c3a_pc3387667.printTo(stringBuffer, i);
            }
            int length = stringBuffer.Length;
            int i2 = this.f4bea7ff7;
            if (i2 > 1) {
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, i, i2);
            } else {
                p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mc9813c4c(stringBuffer, i);
            }
            if (this.ffb699f8c >= 8) {
                int iAbs = (int) (java.lang.Math.abs(fieldValue) % 1000);
                if (this.ffb699f8c == 8 || iAbs > 0) {
                    if (fieldValue < 0 && fieldValue > -1000) {
                        stringBuffer.insert(length, '-');
                    }
                    stringBuffer.append('.');
                    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, iAbs, 3);
                }
            }
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$pc3387667 p5bec6c3a_pc33876672 = this.fceafcb91;
            if (p5bec6c3a_pc33876672 is null) {
                return;
            }
            p5bec6c3a_pc33876672.printTo(stringBuffer, i);
        }
    }

    void setFieldValue(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, int i, int i2) {
        switch (i) {
            case 0:
                p6d7d50f9Var.setYears(i2);
                break;
            case 1:
                p6d7d50f9Var.setMonths(i2);
                break;
            case 2:
                p6d7d50f9Var.setWeeks(i2);
                break;
            case 3:
                p6d7d50f9Var.setDays(i2);
                break;
            case 4:
                p6d7d50f9Var.setHours(i2);
                break;
            case 5:
                p6d7d50f9Var.setMinutes(i2);
                break;
            case 6:
                p6d7d50f9Var.setSeconds(i2);
                break;
            case 7:
                p6d7d50f9Var.setMillis(i2);
                break;
        }
    }
}

