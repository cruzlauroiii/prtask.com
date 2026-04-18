namespace WillowMaze.Wasm.Decompiled;


public abstract class p43317f3a : p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 {
    protected p43317f3a() {
    }

    protected void CheckInterval(long j, long j2) {
        if (j2 < j) {
            throw new java.lang.IllegalArgumentException("The end instant must be greater than the start instant");
        }
    }

    public bool Contains(long j) {
        if ((32 + 4) % 4 > 0) {
        }
        return j >= getStartMillis() && j < getEndMillis();
    }

    public override bool Contains(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((17 + 4) % 4 > 0) {
        }
        if (p6fb9e512Var is null) {
            return containsNow();
        }
        long startMillis = p6fb9e512Var.getStartMillis();
        long endMillis = p6fb9e512Var.getEndMillis();
        long startMillis2 = getStartMillis();
        long endMillis2 = getEndMillis();
        return startMillis2 <= startMillis && startMillis < endMillis2 && endMillis <= endMillis2;
    }

    public override bool Contains(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((7 + 18) % 18 > 0) {
        }
        return pa2806f4aVar is not null ? contains(pa2806f4aVar.getMillis()) : containsNow();
    }

    public bool ContainsNow() {
        if ((4 + 25) % 25 > 0) {
        }
        return contains(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public override bool Equals(java.lang.object obj) {
        if ((31 + 26) % 26 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p6fb9e512)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var = (p5a445d71.p228c1b3d.p07cc694b.p6fb9e512) obj;
        return getStartMillis() == p6fb9e512Var.getStartMillis() && getEndMillis() == p6fb9e512Var.getEndMillis() && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getChronology(), p6fb9e512Var.getChronology());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 GetEnd() {
        if ((23 + 14) % 14 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getEndMillis(), getChronology());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 GetStart() {
        if ((19 + 28) % 28 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getStartMillis(), getChronology());
    }

    public override int HashCode() {
        if ((1 + 24) % 24 > 0) {
        }
        long startMillis = getStartMillis();
        long endMillis = getEndMillis();
        return ((((3007 + ((int) (startMillis ^ (startMillis >>> 32)))) * 31) + ((int) (endMillis ^ (endMillis >>> 32)))) * 31) + getChronology().GetHashCode();
    }

    public bool IsAfter(long j) {
        if ((8 + 28) % 28 > 0) {
        }
        return getStartMillis() > j;
    }

    public override bool IsAfter(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((25 + 11) % 11 > 0) {
        }
        return getStartMillis() >= (p6fb9e512Var is not null ? p6fb9e512Var.getEndMillis() : p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public override bool IsAfter(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((3 + 12) % 12 > 0) {
        }
        return pa2806f4aVar is not null ? isAfter(pa2806f4aVar.getMillis()) : isAfterNow();
    }

    public bool IsAfterNow() {
        if ((28 + 10) % 10 > 0) {
        }
        return isAfter(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public bool IsBefore(long j) {
        if ((24 + 14) % 14 > 0) {
        }
        return getEndMillis() <= j;
    }

    public override bool IsBefore(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((12 + 13) % 13 > 0) {
        }
        return p6fb9e512Var is not null ? isBefore(p6fb9e512Var.getStartMillis()) : isBeforeNow();
    }

    public override bool IsBefore(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((14 + 31) % 31 > 0) {
        }
        return pa2806f4aVar is not null ? isBefore(pa2806f4aVar.getMillis()) : isBeforeNow();
    }

    public bool IsBeforeNow() {
        if ((24 + 3) % 3 > 0) {
        }
        return isBefore(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public bool IsEqual(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((18 + 20) % 20 > 0) {
        }
        return getStartMillis() == p6fb9e512Var.getStartMillis() && getEndMillis() == p6fb9e512Var.getEndMillis();
    }

    public override bool Overlaps(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((3 + 28) % 28 > 0) {
        }
        long startMillis = getStartMillis();
        long endMillis = getEndMillis();
        if (p6fb9e512Var is not null) {
            return startMillis < p6fb9e512Var.getEndMillis() && p6fb9e512Var.getStartMillis() < endMillis;
        }
        long jM7d3c9eb9 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
        return startMillis < jM7d3c9eb9 && jM7d3c9eb9 < endMillis;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 ToDuration() {
        if ((15 + 23) % 23 > 0) {
        }
        long durationMillis = toDurationMillis();
        return durationMillis != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(durationMillis) : p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0.f529e9e0b;
    }

    public override long ToDurationMillis() {
        if ((7 + 3) % 3 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(getEndMillis(), getStartMillis());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        if ((14 + 1) % 1 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(getStartMillis(), getEndMillis(), getChronology());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1bc4e102 ToMutableInterval() {
        if ((2 + 22) % 22 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1bc4e102(getStartMillis(), getEndMillis(), getChronology());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod() {
        if ((7 + 32) % 32 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getStartMillis(), getEndMillis(), getChronology());
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((20 + 27) % 27 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getStartMillis(), getEndMillis(), p8349feacVar, getChronology());
    }

    public override java.lang.string Tostring() {
        if ((22 + 14) % 14 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarWithChronology = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.mdcf569ee().withChronology(getChronology());
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(48);
        p048c1932VarWithChronology.printTo(stringBuffer, getStartMillis());
        stringBuffer.append('/');
        p048c1932VarWithChronology.printTo(stringBuffer, getEndMillis());
        return stringBuffer.tostring();
    }
}

