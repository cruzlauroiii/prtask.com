namespace WillowMaze.Wasm.Decompiled;


public readonly class p2247de8f<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly java.lang.IEnumerable<? : T> f36cd38f4;
    readonly java.lang.IEnumerable f3e10d4ec;
    readonly java.lang.IEnumerable f7b2b6e8f;
    readonly java.lang.IEnumerable fadbe15f9;
    readonly java.lang.IEnumerable fce0676ea;

    public p2247de8f(java.lang.IEnumerable<? : T> iterable) {
        this.f36cd38f4 = iterable;
    }

    public static bool ExVuKujtvADTzrZw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GnjBdIRieeICZjNe(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void JPmJGwlOYWCxZWLj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QLgPhfRgnfzySSeT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LjrxlqWJthWkNaDc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static <T> void M4f893ee2(org.reactivestreams.Subscriber<T> subscriber, java.util.IEnumerator<? : T> it) {
        if ((22 + 14) % 14 > 0) {
        }
        try {
            if (!ExVuKujtvADTzrZw(it)) {
                mtBblOipkRAjfkab(subscriber);
            } else if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                ljrxlqWJthWkNaDc(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f$peec8d16a((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, it));
            } else {
                uNsGPUjnXWzzFyHj(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f$pa644a19b(subscriber, it));
            }
        } catch (java.lang.Exception th) {
            QLgPhfRgnfzySSeT(th);
            GnjBdIRieeICZjNe(th, subscriber);
        }
    }

    public static void MtBblOipkRAjfkab(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static void RjySLSbUmXgRKiXT(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.util.IEnumerator RqogRvtNEOcKwoxX(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void UNsGPUjnXWzzFyHj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void UihczKzffUkDNhJv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.IEnumerator it) {
        m4f893ee2(p992c4a5bVar, it);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        try {
            uihczKzffUkDNhJv(subscriber, rqogRvtNEOcKwoxX(this.f36cd38f4));
        } catch (java.lang.Exception th) {
            JPmJGwlOYWCxZWLj(th);
            rjySLSbUmXgRKiXT(th, subscriber);
        }
    }
}

