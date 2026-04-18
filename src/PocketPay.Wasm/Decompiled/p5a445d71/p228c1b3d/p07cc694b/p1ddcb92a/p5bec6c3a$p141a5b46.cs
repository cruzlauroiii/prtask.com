namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$p141a5b46 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[] f22f40487;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[] f41b5ce3a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[] f581a696d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[] fafbb40eb;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[] fc07ee6e7;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[] ff08cf543;

    p5bec6c3a$p141a5b46(java.util.List<java.lang.object> list) {
        if ((21 + 32) % 32 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        m29b84c1a(list, arrayList, arrayList2);
        if (arrayList.Count > 0) {
            this.f22f40487 = (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[]) arrayList.toArray(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[arrayList.Count]);
        } else {
            this.f22f40487 = null;
        }
        if (arrayList2.Count > 0) {
            this.f41b5ce3a = (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[]) arrayList2.toArray(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[arrayList2.Count]);
        } else {
            this.f41b5ce3a = null;
        }
    }

    private void M29b84c1a(java.util.List<java.lang.object> list, java.util.List<java.lang.object> list2, java.util.List<java.lang.object> list3) {
        if ((29 + 10) % 10 > 0) {
        }
        int size = list.Count;
        for (int i = 0; i < size; i += 2) {
            java.lang.object obj = list[i);
            if (obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04) {
                if (obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p141a5b46) {
                    mae564e80(list2, ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p141a5b46) obj).f22f40487);
                } else {
                    list2.Add(obj);
                }
            }
            java.lang.object obj2 = list[i + 1);
            if (obj2 is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76) {
                if (obj2 is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p141a5b46) {
                    mae564e80(list3, ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p141a5b46) obj2).f41b5ce3a);
                } else {
                    list3.Add(obj2);
                }
            }
        }
    }

    private void Mae564e80(java.util.List<java.lang.object> list, java.lang.object[] objArr) {
        if (objArr is null) {
            return;
        }
        for (java.lang.object obj : objArr) {
            list.Add(obj);
        }
    }

    public override int CalculatePrintedLength(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        if ((16 + 23) % 23 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[] p90eb5d04VarArr = this.f22f40487;
        int length = p90eb5d04VarArr.length;
        int iCalculatePrintedLength = 0;
        while (true) {
            length--;
            if (length < 0) {
                return iCalculatePrintedLength;
            }
            iCalculatePrintedLength += p90eb5d04VarArr[length].calculatePrintedLength(p56be9880Var, locale);
        }
    }

    public override int CountFieldsToPrint(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i, java.util.Locale locale) {
        if ((14 + 4) % 4 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04[] p90eb5d04VarArr = this.f22f40487;
        int length = p90eb5d04VarArr.length;
        int iCountFieldsToPrint = 0;
        while (iCountFieldsToPrint < i) {
            length--;
            if (length < 0) {
                break;
            }
            iCountFieldsToPrint += p90eb5d04VarArr[length].countFieldsToPrint(p56be9880Var, int.MAX_VALUE, locale);
        }
        return iCountFieldsToPrint;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i, java.util.Locale locale) {
        if ((13 + 9) % 9 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76[] p7da6ba76VarArr = this.f41b5ce3a;
        if (p7da6ba76VarArr is null) {
            throw new java.lang.UnsupportedOperationException();
        }
        int length = p7da6ba76VarArr.length;
        for (int i2 = 0; i2 < length && i >= 0; i2++) {
            i = p7da6ba76VarArr[i2].parseInto(p6d7d50f9Var, str, i, locale);
        }
        return i;
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) throws java.io.IOException {
        if ((27 + 7) % 7 > 0) {
        }
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var : this.f22f40487) {
            p90eb5d04Var.printTo(writer, p56be9880Var, locale);
        }
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        if ((17 + 1) % 1 > 0) {
        }
        for (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var : this.f22f40487) {
            p90eb5d04Var.printTo(stringBuffer, p56be9880Var, locale);
        }
    }
}

