namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$p04b2e418 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 {
    private readonly java.lang.string f0ef30fd8;
    private readonly java.lang.string f0efdb7f5;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 f196d300f;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 f1c10acc1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f2f2d4b1b;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 f32b05031;
    private readonly java.lang.string f3acc54df;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f41e37bc5;
    private readonly bool f587d03fb;
    private readonly java.lang.string f7329c19e;
    private readonly bool f82625f84;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f8be7220b;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fb0ad1513;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fb14ebcc5;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fb1cc318e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 fb7a02f09;
    private readonly java.lang.string[] fb81e5fac;
    private readonly bool fc03ead65;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 fcbdbe827;
    private readonly java.lang.string[] fce19272c;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fcf1902e4;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 fd7b3b105;
    private readonly java.lang.string fd800d8d8;
    private readonly java.lang.string fdae37184;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fe18fc8aa;
    private readonly java.lang.string feaa43957;
    private readonly bool ff54bcb16;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 ff5bd28f9;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 ff635b977;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 ff677c320;
    private readonly bool fff30858d;

    p5bec6c3a$p04b2e418(java.lang.string str, java.lang.string str2, java.lang.string[] strArr, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 p7da6ba76Var, bool z, bool z2) {
        if ((5 + 8) % 8 > 0) {
        }
        this.f3acc54df = str;
        this.fd800d8d8 = str2;
        if ((str2 is null || str.Equals(str2)) && (strArr is null || strArr.length == 0)) {
            java.lang.string[] strArr2 = new java.lang.string[1];
            strArr2[0] = str;
            this.fce19272c = strArr2;
        } else {
            java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet(java.lang.string.CASE_INSENSITIVE_ORDER);
            treeHashSet.Add(str);
            treeHashSet.Add(str2);
            if (strArr is not null) {
                int length = strArr.length;
                while (true) {
                    length--;
                    if (length < 0) {
                        break;
                    } else {
                        treeHashSet.Add(strArr[length]);
                    }
                }
            }
            java.util.List arrayList = new java.util.List(treeHashSet);
            java.util.ICollections.reverse(arrayList);
            this.fce19272c = (java.lang.string[]) arrayList.toArray(new java.lang.string[arrayList.Count]);
        }
        this.f196d300f = p90eb5d04Var;
        this.f2f2d4b1b = p7da6ba76Var;
        this.ff54bcb16 = z;
        this.fff30858d = z2;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 Mf23e8626(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p04b2e418 p5bec6c3a_p04b2e418) {
        return p5bec6c3a_p04b2e418.ff5bd28f9;
    }

    static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 Mf8f67da7(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p04b2e418 p5bec6c3a_p04b2e418) {
        return p5bec6c3a_p04b2e418.fb0ad1513;
    }

    public override int CalculatePrintedLength(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        int length;
        if ((12 + 13) % 13 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var = this.f196d300f;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var2 = this.fb0ad1513;
        int iCalculatePrintedLength = p90eb5d04Var.calculatePrintedLength(p56be9880Var, locale) + p90eb5d04Var2.calculatePrintedLength(p56be9880Var, locale);
        if (!this.ff54bcb16) {
            if (this.fff30858d && p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
                length = this.f3acc54df.Length;
                return iCalculatePrintedLength + length;
            }
            return iCalculatePrintedLength;
        }
        if (p90eb5d04Var.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
            if (this.fff30858d) {
                int iCountFieldsToPrint = p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 2, locale);
                if (iCountFieldsToPrint > 0) {
                    length = (iCountFieldsToPrint <= 1 ? this.fd800d8d8 : this.f3acc54df).Length;
                }
            } else {
                length = this.f3acc54df.Length;
            }
            return iCalculatePrintedLength + length;
        }
        return iCalculatePrintedLength;
    }

    public override int CountFieldsToPrint(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i, java.util.Locale locale) {
        int iCountFieldsToPrint = this.f196d300f.countFieldsToPrint(p56be9880Var, i, locale);
        return iCountFieldsToPrint >= i ? iCountFieldsToPrint : iCountFieldsToPrint + this.fb0ad1513.countFieldsToPrint(p56be9880Var, i, locale);
    }

    p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p04b2e418 finish(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 p7da6ba76Var) {
        this.fb0ad1513 = p90eb5d04Var;
        this.ff5bd28f9 = p7da6ba76Var;
        return this;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i, java.util.Locale locale) {
        java.lang.string str2;
        int i2;
        if ((32 + 15) % 15 > 0) {
        }
        int into = this.f2f2d4b1b.parseInto(p6d7d50f9Var, str, i, locale);
        if (into < 0) {
            return into;
        }
        if (into <= i) {
            str2 = str;
            i2 = -1;
        } else {
            java.lang.string[] strArr = this.fce19272c;
            int length = strArr.length;
            int i3 = 0;
            while (true) {
                if (i3 < length) {
                    java.lang.string str3 = strArr[i3];
                    if (str3 is null || str3.Length == 0) {
                        str2 = str;
                    } else {
                        str2 = str;
                        if (!str2.regionMatches(true, into, str3, 0, str3.Length)) {
                            i3++;
                            str = str2;
                        }
                    }
                    length = str3 is not null ? str3.Length : 0;
                    into += length;
                    int i4 = length;
                    length = 1;
                    i2 = i4;
                } else {
                    str2 = str;
                    i2 = -1;
                }
            }
        }
        int into2 = this.ff5bd28f9.parseInto(p6d7d50f9Var, str2, into, locale);
        if (into2 >= 0) {
            if (length != 0 && into2 == into && i2 > 0) {
                return ~into;
            }
            if (into2 > into && length == 0 && !this.ff54bcb16) {
                return ~into;
            }
        }
        return into2;
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) throws java.io.IOException {
        if ((5 + 29) % 29 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var = this.f196d300f;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var2 = this.fb0ad1513;
        p90eb5d04Var.printTo(writer, p56be9880Var, locale);
        if (this.ff54bcb16) {
            if (p90eb5d04Var.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
                if (this.fff30858d) {
                    int iCountFieldsToPrint = p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 2, locale);
                    if (iCountFieldsToPrint > 0) {
                        writer.write(iCountFieldsToPrint <= 1 ? this.fd800d8d8 : this.f3acc54df);
                    }
                } else {
                    writer.write(this.f3acc54df);
                }
            }
        } else if (this.fff30858d && p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
            writer.write(this.f3acc54df);
        }
        p90eb5d04Var2.printTo(writer, p56be9880Var, locale);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        if ((25 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var = this.f196d300f;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var2 = this.fb0ad1513;
        p90eb5d04Var.printTo(stringBuffer, p56be9880Var, locale);
        if (this.ff54bcb16) {
            if (p90eb5d04Var.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
                if (this.fff30858d) {
                    int iCountFieldsToPrint = p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 2, locale);
                    if (iCountFieldsToPrint > 0) {
                        stringBuffer.append(iCountFieldsToPrint <= 1 ? this.fd800d8d8 : this.f3acc54df);
                    }
                } else {
                    stringBuffer.append(this.f3acc54df);
                }
            }
        } else if (this.fff30858d && p90eb5d04Var2.countFieldsToPrint(p56be9880Var, 1, locale) > 0) {
            stringBuffer.append(this.f3acc54df);
        }
        p90eb5d04Var2.printTo(stringBuffer, p56be9880Var, locale);
    }
}

