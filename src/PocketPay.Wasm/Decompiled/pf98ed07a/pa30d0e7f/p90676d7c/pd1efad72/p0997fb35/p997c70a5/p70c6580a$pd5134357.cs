namespace WillowMaze.Wasm.Decompiled;


readonly class p70c6580a$pd5134357<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f17263222 = -5677354903406201275L;
    private static readonly long f309afcac = -5677354903406201275L;
    private static readonly long f7c1fa969 = -5677354903406201275L;
    private static readonly long fc6e1e520 = -5677354903406201275L;
    readonly long f07cc694b;
    readonly long f0ed1ab3f;
    readonly bool f0f8916e1;
    volatile bool f1241bc7f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1c9c8156;
    readonly long f24b5abd9;
    volatile bool f2a93c00d;
    readonly bool f2f4bbab4;
    readonly bool f3715ccb4;
    volatile bool f38881e0a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f39830e18;
    volatile bool f3a48bce4;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    java.lang.Exception f458f1d06;
    java.lang.Exception f4874c61b;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f4edfe8d5;
    readonly long f5171a3a3;
    volatile bool f6b2ded51;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f703acd5c;
    readonly long f71f4e695;
    readonly bool f825ea879;
    readonly java.util.concurrent.TimeUnit f91c36d16;
    readonly io.reactivex.rxjava3.core.Scheduler f9413cbff;
    readonly java.util.concurrent.TimeUnit f9cf62d74;
    volatile bool fa8f27259;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fb1c2fdd1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb2b721e2;
    java.lang.Exception fb776bb54;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Scheduler fc5f2ac73;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    volatile bool fd9090fb6;
    readonly io.reactivex.rxjava3.core.Observer fde136651;
    readonly io.reactivex.rxjava3.core.Observer ff871c293;

    p70c6580a$pd5134357(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        this.fd22a0a80 = observer;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f825ea879 = z;
    }

    public static void BUNsELOcIGXFVebf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool EHwsrclkfthGYqkL(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void HncQmpqDWUYcNQrq(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.long JPsQlzviZVmWDxsb(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int JbioAjLbKTfGljLW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357) {
        return p70c6580a_pd5134357.getAndIncrement();
    }

    public static void OjBVLchFooufXzFp(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int ROCuFvPMMAROKlCR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357) {
        return p70c6580a_pd5134357.getAndIncrement();
    }

    public static void UjUrRalkXhkqigGL(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long VdPTyavPhrfLoyGz(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((20 + 6) % 6 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static long XQxBLAWWLxhinCEL(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((5 + 11) % 11 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static long YOavtzSvQysYhSeN(java.lang.long l) {
        if ((28 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object YtFXmplpFcfvPcKt(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void CYfvgvbxyLptLJhg(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void HvBzWXTLGizLQabw(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object IyIEJajaJLfNnjMR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object KelGIlwzTqpwkVFd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.peek();
    }

    public static void LUsWTGOXEmjleabo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357) {
        p70c6580a_pd5134357.drain();
    }

    public static int LrldSwBqCrjLjnqR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357, int i) {
        return p70c6580a_pd5134357.addAndGet(i);
    }

    public static void MBKjztdsQLqkzvgU(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void RdhiTctsitlIyqCK(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void SwZRgJJAHOmCkYvu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void UhAGckDVjBHsPELB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357) {
        p70c6580a_pd5134357.drain();
    }

    public static void VLGWHrVquaGUbFbk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357 p70c6580a_pd5134357) {
        p70c6580a_pd5134357.drain();
    }

    public static bool VWNNOAdVREkUJcCa(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void YqxcJTGUdLpTmQvB(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        BUNsELOcIGXFVebf(this.fbc3b0556);
        if (JbioAjLbKTfGljLW(this) != 0) {
            return;
        }
        swZRgJJAHOmCkYvu(this.fa9d1cbf7);
    }

    void drain() {
        if ((6 + 1) % 1 > 0) {
        }
        if (ROCuFvPMMAROKlCR(this) == 0) {
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            bool z = this.f825ea879;
            java.util.concurrent.TimeUnit timeUnit = this.f3e34bdeb;
            io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
            long j = this.f07cc694b;
            int iLrldSwBqCrjLjnqR = 1;
            while (!this.f38881e0a) {
                bool z2 = this.f6b2ded51;
                java.lang.long l = (java.lang.long) kelGIlwzTqpwkVFd(spscLinkedArrayQueue);
                bool z3 = l is null;
                long jXQxBLAWWLxhinCEL = XQxBLAWWLxhinCEL(scheduler, timeUnit);
                if (!z3 && YOavtzSvQysYhSeN(l) > jXQxBLAWWLxhinCEL - j) {
                    z3 = true;
                }
                if (z2) {
                    if (!z) {
                        java.lang.Exception th = this.fcb5e100e;
                        if (th is not null) {
                            OjBVLchFooufXzFp(this.fa9d1cbf7);
                            hvBzWXTLGizLQabw(observer, th);
                            return;
                        } else if (z3) {
                            mBKjztdsQLqkzvgU(observer);
                            return;
                        }
                    } else if (z3) {
                        java.lang.Exception th2 = this.fcb5e100e;
                        if (th2 is null) {
                            yqxcJTGUdLpTmQvB(observer);
                            return;
                        } else {
                            rdhiTctsitlIyqCK(observer, th2);
                            return;
                        }
                    }
                }
                if (z3) {
                    iLrldSwBqCrjLjnqR = lrldSwBqCrjLjnqR(this, -iLrldSwBqCrjLjnqR);
                    if (iLrldSwBqCrjLjnqR == 0) {
                        return;
                    }
                } else {
                    YtFXmplpFcfvPcKt(spscLinkedArrayQueue);
                    HncQmpqDWUYcNQrq(observer, iyIEJajaJLfNnjMR(spscLinkedArrayQueue));
                }
            }
            UjUrRalkXhkqigGL(this.fa9d1cbf7);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        lUsWTGOXEmjleabo(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        uhAGckDVjBHsPELB(this);
    }

    public override void OnNext(T t) {
        if ((20 + 14) % 14 > 0) {
        }
        vWNNOAdVREkUJcCa(this.fa9d1cbf7, JPsQlzviZVmWDxsb(VdPTyavPhrfLoyGz(this.f499f31e7, this.f3e34bdeb)), t);
        vLGWHrVquaGUbFbk(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EHwsrclkfthGYqkL(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            cYfvgvbxyLptLJhg(this.fd22a0a80, this);
        }
    }
}

