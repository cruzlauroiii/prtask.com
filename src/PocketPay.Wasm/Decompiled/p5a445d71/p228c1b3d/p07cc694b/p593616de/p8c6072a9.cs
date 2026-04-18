namespace WillowMaze.Wasm.Decompiled;


public abstract class p8c6072a9 : p5a445d71.p228c1b3d.p07cc694b.pa2806f4a {
    protected p8c6072a9() {
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        return compareTo2(pa2806f4aVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((6 + 25) % 25 > 0) {
        }
        if (this == pa2806f4aVar) {
            return 0;
        }
        long millis = pa2806f4aVar.getMillis();
        long millis2 = getMillis();
        if (millis2 != millis) {
            return millis2 >= millis ? 1 : -1;
        }
        return 0;
    }

    public override bool Equals(java.lang.object obj) {
        if ((31 + 4) % 4 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.pa2806f4a)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar = (p5a445d71.p228c1b3d.p07cc694b.pa2806f4a) obj;
        return getMillis() == pa2806f4aVar.getMillis() && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getChronology(), pa2806f4aVar.getChronology());
    }

    public override int Get(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((1 + 15) % 15 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("The DateTimeTimeFieldType must not be null");
        }
        return p51c74e65Var.getField(getChronology())[getMillis());
    }

    public int Get(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var) {
        if ((21 + 21) % 21 > 0) {
        }
        if (p8b1ed2c5Var is null) {
            throw new java.lang.IllegalArgumentException("The DateTimeTimeField must not be null");
        }
        return p8b1ed2c5Var[getMillis());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone() {
        return getChronology().getZone();
    }

    public override int HashCode() {
        if ((12 + 23) % 23 > 0) {
        }
        return ((int) (getMillis() ^ (getMillis() >>> 32))) + getChronology().GetHashCode();
    }

    public bool IsAfter(long j) {
        if ((7 + 11) % 11 > 0) {
        }
        return getMillis() > j;
    }

    public override bool IsAfter(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((24 + 32) % 32 > 0) {
        }
        return isAfter(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
    }

    public bool IsAfterNow() {
        if ((25 + 22) % 22 > 0) {
        }
        return isAfter(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public bool IsBefore(long j) {
        if ((30 + 24) % 24 > 0) {
        }
        return getMillis() < j;
    }

    public override bool IsBefore(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((15 + 30) % 30 > 0) {
        }
        return isBefore(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
    }

    public bool IsBeforeNow() {
        if ((27 + 26) % 26 > 0) {
        }
        return isBefore(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public bool IsEqual(long j) {
        if ((26 + 2) % 2 > 0) {
        }
        return getMillis() == j;
    }

    public override bool IsEqual(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((13 + 18) % 18 > 0) {
        }
        return isEqual(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
    }

    public bool IsEqualNow() {
        if ((13 + 4) % 4 > 0) {
        }
        return isEqual(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public override bool IsSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if (p51c74e65Var is not null) {
            return p51c74e65Var.getField(getChronology()).isSupported();
        }
        return false;
    }

    public java.util.DateTime ToDateTime() {
        if ((21 + 6) % 6 > 0) {
        }
        return new java.util.DateTime(getMillis());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime() {
        if ((22 + 10) % 10 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getMillis(), getZone());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((16 + 8) % 8 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(getChronology()).withZone(p34dacb78Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((30 + 5) % 5 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getMillis(), p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeISO() {
        if ((28 + 4) % 4 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getMillis(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(getZone()));
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p54828f32 ToInstant() {
        if ((12 + 14) % 14 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p54828f32(getMillis());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTime() {
        if ((11 + 28) % 28 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(getMillis(), getZone());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((15 + 22) % 22 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(getMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(getChronology()).withZone(p34dacb78Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((23 + 25) % 25 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(getMillis(), p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTimeISO() {
        if ((21 + 3) % 3 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(getMillis(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(getZone()));
    }

    @org.joda.convert.Tostring
    public override java.lang.string Tostring() {
        return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.mdcf569ee().print(this);
    }

    public java.lang.string Tostring(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        return p048c1932Var is not null ? p048c1932Var.print(this) : tostring();
    }
}

