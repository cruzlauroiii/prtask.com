namespace WillowMaze.Wasm.Decompiled;


readonly class p9f287dff$pee0fdafd<T> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f2f66d326 = 4063763155303814625L;
    private static readonly long fc6e1e520 = 4063763155303814625L;
    bool f18dfdbfd;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : org.reactivestreams.Publisher<? : T>> f1a4f6e5a;
    bool f27b526bf;
    long f5051d8ee;
    bool f5b0c470f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f62248137;
    long f69a1920e;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8e5ae019;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f92ecabb4;
    long f9c38af7d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9fc487c7;
    long fa849bc35;
    long fc2d6a006;
    readonly p5a445d71.p18f29add.p992c4a5b fc9149d3d;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    bool fe2eff6c2;
    bool fe7df6be9;
    readonly p5a445d71.p18f29add.p992c4a5b fee16245d;
    bool ff79544a7;

    p9f287dff$pee0fdafd(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : org.reactivestreams.Publisher<? : T>> function) {
        super(false);
        this.fd22a0a80 = subscriber;
        this.f1a4f6e5a = function;
    }

    public static void GPLxePGTrhPkRvuz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JTUDzgXhbBDXmFEp(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void JmMjnrRSwxklljVC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object OXjllXlwTQxfxdKh(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void UtKrSNNuGAYQYbFM(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CreuqKRbgBdgzZOD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9f287dff$pee0fdafd p9f287dff_pee0fdafd, long j) {
        p9f287dff_pee0fdafd.produced(j);
    }

    public static java.lang.object HZuzgNsXoPgRwahA(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void IkFVEbywPKSBcOFL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9f287dff$pee0fdafd p9f287dff_pee0fdafd, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p9f287dff_pee0fdafd.setSubscription(p787ad0b7Var);
    }

    public static void PqoCofvGgvkJzxpl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void RFTihaEwVKXPkxXg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void USxWsyfafYrdpYgX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        this.fe2eff6c2 = true;
        pqoCofvGgvkJzxpl(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((32 + 30) % 30 > 0) {
        }
        if (this.fe2eff6c2) {
            if (this.f6b2ded51) {
                rFTihaEwVKXPkxXg(th);
                return;
            } else {
                GPLxePGTrhPkRvuz(this.fd22a0a80, th);
                return;
            }
        }
        this.fe2eff6c2 = true;
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) hZuzgNsXoPgRwahA(OXjllXlwTQxfxdKh(this.f1a4f6e5a, th), "The nextSupplier returned a null Publisher");
            long j = this.f5051d8ee;
            if (j != 0) {
                creuqKRbgBdgzZOD(this, j);
            }
            JTUDzgXhbBDXmFEp(p32c73be0Var, this);
        } catch (java.lang.Exception th2) {
            UtKrSNNuGAYQYbFM(th2);
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            JmMjnrRSwxklljVC(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        if ((23 + 19) % 19 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (!this.fe2eff6c2) {
            this.f5051d8ee++;
        }
        uSxWsyfafYrdpYgX(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        ikFVEbywPKSBcOFL(this, p787ad0b7Var);
    }
}

