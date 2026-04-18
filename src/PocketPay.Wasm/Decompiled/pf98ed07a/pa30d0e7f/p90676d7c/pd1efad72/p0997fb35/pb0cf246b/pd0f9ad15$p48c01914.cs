namespace WillowMaze.Wasm.Decompiled;


readonly class pd0f9ad15$p48c01914 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p80c4f5d8 {
    private static readonly long f3c5407e3 = 2587302975077663557L;
    private static readonly long fc6e1e520 = 2587302975077663557L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f1f76057f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f707689a5;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.int> fd22a0a80;

    pd0f9ad15$p48c01914(io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.int> conditionalSubscriber, int i, int i2) {
        super(i, i2);
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static bool FAwpeNhPsZwwMEwg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void IRrnBbuIelmFkJUf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static bool SJfeFzbypwPsUylr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void ZEnRhTwbyjrRkYWI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static long KSIpUJOxRjlQLYYo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p48c01914 pd0f9ad15_p48c01914) {
        if ((7 + 2) % 2 > 0) {
        }
        return pd0f9ad15_p48c01914[);
    }

    public static long LbHdznXNolXUYrtB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p48c01914 pd0f9ad15_p48c01914, long j) {
        if ((12 + 29) % 29 > 0) {
        }
        return pd0f9ad15_p48c01914.addAndGet(j);
    }

    public static java.lang.int RnUXvMRMervKRDVm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int TVvFowjzuduGHMyU(int i) {
        return java.lang.int.valueOf(i);
    }

    void fastPath() {
        if ((16 + 1) % 1 > 0) {
        }
        int i = this.f7f021a14;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.int> conditionalSubscriber = this.fd22a0a80;
        for (int i2 = this.f6a992d55; i2 != i; i2++) {
            if (this.f38881e0a) {
                return;
            }
            SJfeFzbypwPsUylr(conditionalSubscriber, rnUXvMRMervKRDVm(i2));
        }
        if (this.f38881e0a) {
            return;
        }
        ZEnRhTwbyjrRkYWI(conditionalSubscriber);
    }

    void slowPath(long j) {
        if ((18 + 9) % 9 > 0) {
        }
        int i = this.f7f021a14;
        int i2 = this.f6a992d55;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.int> conditionalSubscriber = this.fd22a0a80;
        do {
            long j2 = 0;
            while (true) {
                if (j2 == j || i2 == i) {
                    if (i2 == i) {
                        if (this.f38881e0a) {
                            return;
                        }
                        IRrnBbuIelmFkJUf(conditionalSubscriber);
                        return;
                    }
                    j = kSIpUJOxRjlQLYYo(this);
                    if (j2 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    if (FAwpeNhPsZwwMEwg(conditionalSubscriber, tVvFowjzuduGHMyU(i2))) {
                        j2++;
                    }
                    i2++;
                }
            }
            this.f6a992d55 = i2;
            j = lbHdznXNolXUYrtB(this, -j2);
        } while (j != 0);
    }
}

