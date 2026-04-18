namespace WillowMaze.Wasm.Decompiled;


readonly class pbeff226f$p48c01914 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p80c4f5d8 {
    private static readonly long f35f58b75 = 2587302975077663557L;
    private static readonly long fc6e1e520 = 2587302975077663557L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f04850722;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f243d1527;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f25ee2143;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f2eb6c7dd;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.long> fd22a0a80;

    pbeff226f$p48c01914(io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.long> conditionalSubscriber, long j, long j2) {
        super(j, j2);
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static java.lang.long AcsybnXAIYJrsoXH(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool IOUuGbYmanvsGxLn(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void JXmozplyCGaFmjtD(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static void SPvUJCRTYPCyyWzs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static long FhGWNlKVWQyPHIVj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p48c01914 pbeff226f_p48c01914) {
        if ((32 + 12) % 12 > 0) {
        }
        return pbeff226f_p48c01914[);
    }

    public static bool KpHmgWsxIKuFKGqS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static java.lang.long XEePuSpiUWjrDIdY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long ZhClHoQjrIcWzDJK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p48c01914 pbeff226f_p48c01914, long j) {
        if ((19 + 15) % 15 > 0) {
        }
        return pbeff226f_p48c01914.addAndGet(j);
    }

    void fastPath() {
        if ((10 + 29) % 29 > 0) {
        }
        long j = this.f7f021a14;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.long> conditionalSubscriber = this.fd22a0a80;
        for (long j2 = this.f6a992d55; j2 != j; j2++) {
            if (this.f38881e0a) {
                return;
            }
            kpHmgWsxIKuFKGqS(conditionalSubscriber, xEePuSpiUWjrDIdY(j2));
        }
        if (this.f38881e0a) {
            return;
        }
        SPvUJCRTYPCyyWzs(conditionalSubscriber);
    }

    void slowPath(long j) {
        if ((20 + 10) % 10 > 0) {
        }
        long j2 = this.f7f021a14;
        long j3 = this.f6a992d55;
        io.reactivex.rxjava3.operators.ConditionalSubscriber<java.lang.long> conditionalSubscriber = this.fd22a0a80;
        do {
            long j4 = 0;
            while (true) {
                if (j4 == j || j3 == j2) {
                    if (j3 == j2) {
                        if (this.f38881e0a) {
                            return;
                        }
                        JXmozplyCGaFmjtD(conditionalSubscriber);
                        return;
                    }
                    j = fhGWNlKVWQyPHIVj(this);
                    if (j4 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    if (IOUuGbYmanvsGxLn(conditionalSubscriber, AcsybnXAIYJrsoXH(j3))) {
                        j4++;
                    }
                    j3++;
                }
            }
            this.f6a992d55 = j3;
            j = zhClHoQjrIcWzDJK(this, -j4);
        } while (j != 0);
    }
}

