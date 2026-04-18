namespace WillowMaze.Wasm.Decompiled;


public readonly class p1500091d<T, U, V> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, V> {
    readonly java.lang.IEnumerable f001fe311;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f06d9f79d;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> f3298b476;
    readonly java.lang.IEnumerable<U> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa525cd76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fb518664a;
    readonly java.lang.IEnumerable fe93eed65;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff11af077;

    public p1500091d(io.reactivex.rxjava3.core.Flowable<T> flowable, java.lang.IEnumerable<U> iterable, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> biFunction) {
        super(flowable);
        this.f795f3202 = iterable;
        this.f3298b476 = biFunction;
    }

    public static java.lang.object FyifpzsrfpEpXYhR(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void LjYzOLfogKRFIIqw(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.util.IEnumerator NVIbVtXhsEeJXpEh(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void PywjlpjMzCTbzOhP(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void UFvoEvixqCjMxoSY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static void AAsyxjGrupMhQwhk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool KgtuZdyAqbafuTVi(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QaBtRzhivEYAgOpe(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void ZafIosSsABeGMeis(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<V> subscriber) {
        if ((29 + 8) % 8 > 0) {
        }
        try {
            java.util.IEnumerator it = (java.util.IEnumerator) FyifpzsrfpEpXYhR(NVIbVtXhsEeJXpEh(this.f795f3202), "The iterator returned by other is null");
            try {
                if (kgtuZdyAqbafuTVi(it)) {
                    qaBtRzhivEYAgOpe(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1500091d$pcfdeef2e(subscriber, it, this.f3298b476));
                } else {
                    UFvoEvixqCjMxoSY(subscriber);
                }
            } catch (java.lang.Exception th) {
                aAsyxjGrupMhQwhk(th);
                LjYzOLfogKRFIIqw(th, subscriber);
            }
        } catch (java.lang.Exception th2) {
            zafIosSsABeGMeis(th2);
            PywjlpjMzCTbzOhP(th2, subscriber);
        }
    }
}

