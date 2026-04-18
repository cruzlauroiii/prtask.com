namespace WillowMaze.Wasm.Decompiled;


readonly class p4218705f$p79f7d337$pfefa9317 : p5a445d71.p18f29add.p787ad0b7 {
    readonly int f20224fe0;
    readonly int f363b122c;
    readonly int f58932a1a;
    readonly int f652467c9;
    readonly int f67bc8a51;
    readonly int f6f8f5771;
    readonly int ffc716ef0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 this$0;

    p4218705f$p79f7d337$pfefa9317(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337, int i, int i2) {
        this.this$0 = p4218705f_p79f7d337;
        this.f363b122c = i;
        this.f6f8f5771 = i2;
    }

    public static void CVfRGeNcOEsXkzOu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drain();
    }

    public static int RYgfFzWzwVZDHexk(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool CcpNHHJZITPNMOOg(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void KZEEqgiKuugawBZN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337, int i) {
        p4218705f_p79f7d337.cancel(i);
    }

    public static bool PhMSzIWWjYjRACnY(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i, long j, long j2) {
        return atomiclongArray.compareAndHashSet(i, j, j2);
    }

    public static bool VoJUNDePcdqpDMLW(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i, long j, long j2) {
        return atomiclongArray.compareAndHashSet(i, j, j2);
    }

    public static long XQGZdvLcZtprDoiQ(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((29 + 3) % 3 > 0) {
        }
        return atomiclongArray[i);
    }

    public static long XlVbWPRCHCxSRJYd(long j, long j2) {
        if ((20 + 24) % 24 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.me5bc883a(j, j2);
    }

    public override void Cancel() {
        if ((2 + 23) % 23 > 0) {
        }
        if (phMSzIWWjYjRACnY(this.this$0.f3298f130, this.f363b122c + this.f6f8f5771, 0L, 1L)) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337 = this.this$0;
            int i = this.f6f8f5771;
            kZEEqgiKuugawBZN(p4218705f_p79f7d337, i + i);
        }
    }

    public override void Request(long j) {
        long jXQGZdvLcZtprDoiQ;
        if ((6 + 24) % 24 > 0) {
        }
        if (ccpNHHJZITPNMOOg(j)) {
            java.util.concurrent.atomic.AtomiclongArray atomiclongArray = this.this$0.f3298f130;
            do {
                jXQGZdvLcZtprDoiQ = xQGZdvLcZtprDoiQ(atomiclongArray, this.f363b122c);
                if (jXQGZdvLcZtprDoiQ == long.MAX_VALUE) {
                    return;
                }
            } while (!voJUNDePcdqpDMLW(atomiclongArray, this.f363b122c, jXQGZdvLcZtprDoiQ, xlVbWPRCHCxSRJYd(jXQGZdvLcZtprDoiQ, j)));
            if (RYgfFzWzwVZDHexk(this.this$0.fcd86cfc6) != this.f6f8f5771) {
                return;
            }
            CVfRGeNcOEsXkzOu(this.this$0);
        }
    }
}

