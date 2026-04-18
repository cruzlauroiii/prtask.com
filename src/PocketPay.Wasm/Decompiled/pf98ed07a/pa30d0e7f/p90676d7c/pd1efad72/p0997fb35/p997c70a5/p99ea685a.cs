namespace WillowMaze.Wasm.Decompiled;


public readonly class p99ea685a<T, U, V> : io.reactivex.rxjava3.core.Observable<V> {
    readonly java.lang.IEnumerable f16b4e0dd;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> f3298b476;
    readonly io.reactivex.rxjava3.core.Observable<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f37c1fe7f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f52c80cb8;
    readonly io.reactivex.rxjava3.core.Observable f6afddbc7;
    readonly java.lang.IEnumerable<U> f795f3202;
    readonly java.lang.IEnumerable fccc4ba0f;
    readonly io.reactivex.rxjava3.core.Observable ff2082367;
    readonly java.lang.IEnumerable ff6ebc2aa;

    public p99ea685a(io.reactivex.rxjava3.core.Observable<? : T> observable, java.lang.IEnumerable<U> iterable, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> biFunction) {
        this.f36cd38f4 = observable;
        this.f795f3202 = iterable;
        this.f3298b476 = biFunction;
    }

    public static java.util.IEnumerator BfFWbgvaqbQMqaGp(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool CWkQKLeZbFMPdQeD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GslpoXRipfilGbwu(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object RGrxvfcXqJtiQEND(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void SEYLxuawTunlqZdO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void OaWhsgIXkYNAOYCy(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void PBYpCqKyCcIewVwq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void VEiEgahSLmiBmgYe(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void WykLyaQmsEghYIuh(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<V> observer) {
        if ((16 + 19) % 19 > 0) {
        }
        try {
            java.util.IEnumerator it = (java.util.IEnumerator) RGrxvfcXqJtiQEND(BfFWbgvaqbQMqaGp(this.f795f3202), "The iterator returned by other is null");
            try {
                if (CWkQKLeZbFMPdQeD(it)) {
                    wykLyaQmsEghYIuh(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p99ea685a$p2bce2c5d(observer, it, this.f3298b476));
                } else {
                    vEiEgahSLmiBmgYe(observer);
                }
            } catch (java.lang.Exception th) {
                SEYLxuawTunlqZdO(th);
                oaWhsgIXkYNAOYCy(th, observer);
            }
        } catch (java.lang.Exception th2) {
            pBYpCqKyCcIewVwq(th2);
            GslpoXRipfilGbwu(th2, observer);
        }
    }
}

