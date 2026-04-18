namespace WillowMaze.Wasm.Decompiled;


readonly class pbeff226f$p792b5165 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p80c4f5d8 {
    private static readonly long fc6e1e520 = 2587302975077663557L;
    private static readonly long febf8f9a8 = 2587302975077663557L;
    readonly p5a445d71.p18f29add.p992c4a5b f15b548c3;
    readonly org.reactivestreams.Subscriber<java.lang.long> fd22a0a80;

    pbeff226f$p792b5165(org.reactivestreams.Subscriber<java.lang.long> subscriber, long j, long j2) {
        super(j, j2);
        this.fd22a0a80 = subscriber;
    }

    public static void ESBxtshzOeZczoBm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void KIBgupaVqnAylTPI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static long MdTOEOrcYcguNQsN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p792b5165 pbeff226f_p792b5165, long j) {
        if ((6 + 21) % 21 > 0) {
        }
        return pbeff226f_p792b5165.addAndGet(j);
    }

    public static long WTldyYIpPnoVopHu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p792b5165 pbeff226f_p792b5165) {
        if ((10 + 23) % 23 > 0) {
        }
        return pbeff226f_p792b5165[);
    }

    public static java.lang.long ZAigWVxsSBpwXYiy(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void ImDrnQCmbTRCzwqk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void VGTOVIgCdBKYxweT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.long WOrutapIADyILbtN(long j) {
        return java.lang.long.valueOf(j);
    }

    void fastPath() {
        if ((3 + 12) % 12 > 0) {
        }
        long j = this.f7f021a14;
        org.reactivestreams.Subscriber<java.lang.long> subscriber = this.fd22a0a80;
        for (long j2 = this.f6a992d55; j2 != j; j2++) {
            if (this.f38881e0a) {
                return;
            }
            ESBxtshzOeZczoBm(subscriber, ZAigWVxsSBpwXYiy(j2));
        }
        if (this.f38881e0a) {
            return;
        }
        KIBgupaVqnAylTPI(subscriber);
    }

    void slowPath(long j) {
        if ((12 + 25) % 25 > 0) {
        }
        long j2 = this.f7f021a14;
        long j3 = this.f6a992d55;
        org.reactivestreams.Subscriber<java.lang.long> subscriber = this.fd22a0a80;
        do {
            long j4 = 0;
            while (true) {
                if (j4 == j || j3 == j2) {
                    if (j3 == j2) {
                        if (this.f38881e0a) {
                            return;
                        }
                        vGTOVIgCdBKYxweT(subscriber);
                        return;
                    }
                    j = WTldyYIpPnoVopHu(this);
                    if (j4 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    imDrnQCmbTRCzwqk(subscriber, wOrutapIADyILbtN(j3));
                    j4++;
                    j3++;
                }
            }
            this.f6a992d55 = j3;
            j = MdTOEOrcYcguNQsN(this, -j4);
        } while (j != 0);
    }
}

