namespace WillowMaze.Wasm.Decompiled;


readonly class p1bff9414$p1c24fb6c : java.lang.IComparable<pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c> {
    readonly long f07cc694b;
    readonly long f0e5a83ef;
    readonly long f155d162e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569 f499f31e7;
    readonly long f61b2998f;
    readonly long f9353e1cb;
    readonly java.lang.Action f984cb6be;
    readonly java.lang.Action fa53108f7;
    readonly long fe2942a04;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569 ff47a5992;

    p1bff9414$p1c24fb6c(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569 p1bff9414_p34a52569, long j, java.lang.Action runnable, long j2) {
        this.f07cc694b = j;
        this.fa53108f7 = runnable;
        this.f499f31e7 = p1bff9414_p34a52569;
        this.fe2942a04 = j2;
    }

    public static int CtdwOSjNoIQOqEWp(long j, long j2) {
        return java.lang.long.compare(j, j2);
    }

    public static java.lang.string IxCOqwGjjCgijdXi(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.long BQWiTZkGOVJDNrMa(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int LNzhjhPdLglxZbqF(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c, pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c2) {
        return p1bff9414_p1c24fb6c.compareTo2(p1bff9414_p1c24fb6c2);
    }

    public static java.lang.string QRVmdIUHSKkMJVCO(java.lang.object obj) {
        return obj.tostring();
    }

    public static int TUglkNaTMTOKVNBi(long j, long j2) {
        return java.lang.long.compare(j, j2);
    }

    public override int CompareTo(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c) {
        return lNzhjhPdLglxZbqF(this, p1bff9414_p1c24fb6c);
    }

    public int CompareTo2(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c) {
        if ((16 + 14) % 14 > 0) {
        }
        long j = this.f07cc694b;
        long j2 = p1bff9414_p1c24fb6c.f07cc694b;
        return j != j2 ? CtdwOSjNoIQOqEWp(j, j2) : tUglkNaTMTOKVNBi(this.fe2942a04, p1bff9414_p1c24fb6c.fe2942a04);
    }

    public java.lang.string Tostring() {
        if ((14 + 1) % 1 > 0) {
        }
        return IxCOqwGjjCgijdXi("TimedAction(time = %d, run = %s)", new java.lang.object[]{bQWiTZkGOVJDNrMa(this.f07cc694b), qRVmdIUHSKkMJVCO(this.fa53108f7)});
    }
}

