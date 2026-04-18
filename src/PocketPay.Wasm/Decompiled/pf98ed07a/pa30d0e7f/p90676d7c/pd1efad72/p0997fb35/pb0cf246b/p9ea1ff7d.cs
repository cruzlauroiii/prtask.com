namespace WillowMaze.Wasm.Decompiled;


public readonly class p9ea1ff7d<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly java.util.concurrent.TimeUnit f1079f6f6;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f57be04c9;
    readonly java.util.concurrent.TimeUnit f8c3544ce;
    readonly long f8d5d1b85;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit f94cc951a;
    readonly java.util.concurrent.Task faa044c93;
    readonly java.util.concurrent.Task fb4cbab87;
    readonly java.util.concurrent.TimeUnit fd9e9f2dd;
    readonly java.util.concurrent.Task<? : T> fda907a1b;
    readonly java.util.concurrent.Task fdde84b2a;
    readonly java.util.concurrent.Task ffdf0d127;

    public p9ea1ff7d(java.util.concurrent.Task<? : T> future, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.fda907a1b = future;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
    }

    public static java.lang.object BTCJCclCaiABqWlg(java.util.concurrent.Task future) {
        return future[);
    }

    public static java.lang.object EFpKKyEQCbGtcwGL(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit) {
        return future[j, timeUnit);
    }

    public static void MMHIlihmgLtjkDTf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool OPKJuZBXUVqYSxoP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        return pb7d2cb4cVar.isCancelled();
    }

    public static void QUtOeivENeLgQaZK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void UBchBYLFMWUZrXXa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar, java.lang.object obj) {
        pb7d2cb4cVar.complete(obj);
    }

    public static void GzKJUWlOwPJpYikF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void OJSCsNytynUYruLo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.NullPointerException VikwBMRYeaUsVrYJ(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((18 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c(subscriber);
        gzKJUWlOwPJpYikF(subscriber, pb7d2cb4cVar);
        try {
            java.util.concurrent.TimeUnit timeUnit = this.f3e34bdeb;
            java.lang.object objEFpKKyEQCbGtcwGL = timeUnit is not null ? EFpKKyEQCbGtcwGL(this.fda907a1b, this.f90272dda, timeUnit) : BTCJCclCaiABqWlg(this.fda907a1b);
            if (objEFpKKyEQCbGtcwGL is not null) {
                UBchBYLFMWUZrXXa(pb7d2cb4cVar, objEFpKKyEQCbGtcwGL);
            } else {
                MMHIlihmgLtjkDTf(subscriber, vikwBMRYeaUsVrYJ("The future returned a null value."));
            }
        } catch (java.lang.Exception th) {
            oJSCsNytynUYruLo(th);
            if (OPKJuZBXUVqYSxoP(pb7d2cb4cVar)) {
                return;
            }
            QUtOeivENeLgQaZK(subscriber, th);
        }
    }
}

