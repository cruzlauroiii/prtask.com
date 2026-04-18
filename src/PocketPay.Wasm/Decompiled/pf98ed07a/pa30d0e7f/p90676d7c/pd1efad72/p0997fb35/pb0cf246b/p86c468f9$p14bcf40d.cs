namespace WillowMaze.Wasm.Decompiled;


readonly class p86c468f9$p14bcf40d<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f3f00a1ee = 8443155186132538303L;
    private static readonly long f3fb262d1 = 8443155186132538303L;
    private static readonly long fb4fd149a = 8443155186132538303L;
    private static readonly long fc6e1e520 = 8443155186132538303L;
    volatile bool f0b4bc862;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f19027166;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2016525c;
    readonly p5a445d71.p18f29add.p992c4a5b f26a0b463;
    volatile bool f2b0b430b;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3b480d96;
    p5a445d71.p18f29add.p787ad0b7 f3d7b0090;
    readonly int f42088376;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f43d2979f;
    readonly bool f45874977;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f4dc39a56;
    readonly bool f50fee566;
    readonly int f5c80b6ee;
    readonly p5a445d71.p18f29add.p992c4a5b f6b4b859d;
    readonly p5a445d71.p18f29add.p992c4a5b f82917545;
    readonly p5a445d71.p18f29add.p992c4a5b f951058cd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fae64a857;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc02dc425;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcbc34e9f;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly bool fdb1d230e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fdfa257ae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 feba4693b;
    readonly bool ff4f8b8bd;
    p5a445d71.p18f29add.p787ad0b7 ff850acb8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();

    p86c468f9$p14bcf40d(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z, int i) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        YAislMImppWwYySH(this, 1);
    }

    public static void ANuWfAzwUYdTcLga(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ExMRogcZQskNkACm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool JHRbpHmpVtGNUHbV(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool KaIUaRseCiGSDqwC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static java.lang.object NfYPePUyfKQXYEnU(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void NiyffDEyzPYpIUhY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void NtmWyjLEHhpMkxZc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void QUKzWxXOAAUpqssI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QxZGemLeoIrJUExe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool RlUyNLOuJDdpBYHY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void SFOyWJCLDZlBBHOd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void TUsATaIbPTPklCpq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d, java.lang.Exception th) {
        p86c468f9_p14bcf40d.onError(th);
    }

    public static void UjWSnHDQliXDBUri(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d) {
        p86c468f9_p14bcf40d.onComplete();
    }

    public static void YAislMImppWwYySH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d, int i) {
        p86c468f9_p14bcf40d.lazyHashSet(i);
    }

    public static int YuATYbtZXJlSrpBA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d) {
        return p86c468f9_p14bcf40d.getAndIncrement();
    }

    public static void ZnaoUrWBGqdLMshU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void ASerWgTRtcsHukuk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void BTlGZboLuqzbnYYR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void BstZrGXtywxoXtwW(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void CYONmsbXpakEXEdC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d, java.lang.Exception th) {
        p86c468f9_p14bcf40d.onError(th);
    }

    public static void ElirUnjVTHMPzuVB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void KxcBcKldEJQVBlrP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static int MhhicwwzWdkDoYxz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d) {
        return p86c468f9_p14bcf40d.decrementAndGet();
    }

    public static int NQAoHGSfPkweUJCf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d) {
        return p86c468f9_p14bcf40d.decrementAndGet();
    }

    public static void NXOduGJdsgHlJzHU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NdtbuHVaTckVTDqy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool OikrSsUqVbpmbuxU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.object PBkUSbeYzmXVZefO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool XMBJhJsNHxtGqxpN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void XlbwcNxMatQHBruo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public void Cancel() {
        this.f38881e0a = true;
        SFOyWJCLDZlBBHOd(this.fbc3b0556);
        aSerWgTRtcsHukuk(this.fcdaeeeba);
        xlbwcNxMatQHBruo(this.f07213a01);
    }

    public void Clear() {
    }

    void innerComplete(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber<T>.FlowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer flowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer) {
        KaIUaRseCiGSDqwC(this.fcdaeeeba, flowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer);
        UjWSnHDQliXDBUri(this);
    }

    void innerError(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber<T>.FlowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer flowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer, java.lang.Exception th) {
        RlUyNLOuJDdpBYHY(this.fcdaeeeba, flowableFlatDictionaryCompletable$FlatDictionaryCompletableMainSubscriber$InnerConsumer);
        TUsATaIbPTPklCpq(this, th);
    }

    public bool IsEmpty() {
        return true;
    }

    public void OnComplete() {
        if ((8 + 24) % 24 > 0) {
        }
        if (nQAoHGSfPkweUJCf(this) == 0) {
            kxcBcKldEJQVBlrP(this.f07213a01, this.fd22a0a80);
        } else {
            if (this.f42088376 == int.MAX_VALUE) {
                return;
            }
            QUKzWxXOAAUpqssI(this.fbc3b0556, 1L);
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((27 + 23) % 23 > 0) {
        }
        if (xMBJhJsNHxtGqxpN(this.f07213a01, th)) {
            if (!this.f50fee566) {
                this.f38881e0a = true;
                elirUnjVTHMPzuVB(this.fbc3b0556);
                NiyffDEyzPYpIUhY(this.fcdaeeeba);
                ZnaoUrWBGqdLMshU(this.f07213a01, this.fd22a0a80);
                return;
            }
            if (mhhicwwzWdkDoYxz(this) == 0) {
                NtmWyjLEHhpMkxZc(this.f07213a01, this.fd22a0a80);
            } else {
                if (this.f42088376 == int.MAX_VALUE) {
                    return;
                }
                bTlGZboLuqzbnYYR(this.fbc3b0556, 1L);
            }
        }
    }

    public void OnNext(T t) {
        if ((9 + 4) % 4 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) pBkUSbeYzmXVZefO(NfYPePUyfKQXYEnU(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            YuATYbtZXJlSrpBA(this);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d$p18060bc7 p86c468f9_p14bcf40d_p18060bc7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d$p18060bc7(this);
            if (!this.f38881e0a && oikrSsUqVbpmbuxU(this.fcdaeeeba, p86c468f9_p14bcf40d_p18060bc7)) {
                bstZrGXtywxoXtwW(completableSource, p86c468f9_p14bcf40d_p18060bc7);
            }
        } catch (java.lang.Exception th) {
            nXOduGJdsgHlJzHU(th);
            QxZGemLeoIrJUExe(this.fbc3b0556);
            cYONmsbXpakEXEdC(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((23 + 19) % 19 > 0) {
        }
        if (JHRbpHmpVtGNUHbV(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            ExMRogcZQskNkACm(this.fd22a0a80, this);
            int i = this.f42088376;
            if (i != int.MAX_VALUE) {
                ANuWfAzwUYdTcLga(p787ad0b7Var, i);
            } else {
                ndtbuHVaTckVTDqy(p787ad0b7Var, long.MAX_VALUE);
            }
        }
    }

    public T Poll() {
        return null;
    }

    public void Request(long j) {
    }

    public int RequestFusion(int i) {
        return i & 2;
    }
}

