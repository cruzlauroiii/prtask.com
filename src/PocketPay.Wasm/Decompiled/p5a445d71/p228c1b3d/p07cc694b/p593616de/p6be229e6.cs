namespace WillowMaze.Wasm.Decompiled;


public abstract class p6be229e6 : p5a445d71.p228c1b3d.p07cc694b.p3f224b4c {
    protected p6be229e6() {
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        return compareTo2(p3f224b4cVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((14 + 29) % 29 > 0) {
        }
        long millis = getMillis();
        long millis2 = p3f224b4cVar.getMillis();
        if (millis >= millis2) {
            return millis <= millis2 ? 0 : 1;
        }
        return -1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((15 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p3f224b4c) {
            return getMillis() == ((p5a445d71.p228c1b3d.p07cc694b.p3f224b4c) obj).getMillis();
        }
        return false;
    }

    public override int HashCode() {
        if ((14 + 21) % 21 > 0) {
        }
        long millis = getMillis();
        return (int) (millis ^ (millis >>> 32));
    }

    public override bool IsEqual(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if (p3f224b4cVar is null) {
            p3f224b4cVar = p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0.f529e9e0b;
        }
        return compareTo2(p3f224b4cVar) == 0;
    }

    public override bool IslongerThan(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if (p3f224b4cVar is null) {
            p3f224b4cVar = p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0.f529e9e0b;
        }
        return compareTo2(p3f224b4cVar) > 0;
    }

    public override bool IsshorterThan(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if (p3f224b4cVar is null) {
            p3f224b4cVar = p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0.f529e9e0b;
        }
        return compareTo2(p3f224b4cVar) < 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 ToDuration() {
        if ((24 + 10) % 10 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(getMillis());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod() {
        if ((3 + 28) % 28 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getMillis());
    }

    @org.joda.convert.Tostring
    public override java.lang.string Tostring() {
        if ((2 + 2) % 2 > 0) {
        }
        long millis = getMillis();
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        stringBuffer.append("PT");
        bool z = millis < 0;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mc9813c4c(stringBuffer, millis);
        while (true) {
            if (stringBuffer.Length >= (!z ? 6 : 7)) {
                break;
            }
            stringBuffer.insert(z ? 3 : 2, com.decryptstringmanager.Decryptstring.decryptstring("1801b303f81d9f284b45979f47650de3426b6aae1cd777670528087713"));
        }
        if ((millis / 1000) * 1000 != millis) {
            stringBuffer.insert(stringBuffer.Length - 3, com.decryptstringmanager.Decryptstring.decryptstring("bfc0c3ac8bfba81016e4e88c9efc6cc43863c252e975c9d86a11b9620a"));
        } else {
            stringBuffer.setLength(stringBuffer.Length - 3);
        }
        stringBuffer.append('S');
        return stringBuffer.tostring();
    }
}

