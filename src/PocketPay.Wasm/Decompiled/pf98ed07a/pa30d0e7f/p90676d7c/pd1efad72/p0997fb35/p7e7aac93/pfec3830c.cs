namespace WillowMaze.Wasm.Decompiled;


public readonly class pfec3830c<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly java.lang.IEnumerable febc664e7;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> ff2ab5fb2;

    public pfec3830c(java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> iterable) {
        this.ff2ab5fb2 = iterable;
    }

    public static void HJAPjcyMRnAoIhDQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RDsRGFlTBlftNudy(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void VhqcJfLDGqDADLIa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pfec3830c$p19f5da85 pfec3830c_p19f5da85) {
        pfec3830c_p19f5da85.drain();
    }

    public static java.util.IEnumerator MejbmXGddjubZdIp(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object XpbaveRWUrrAZcNA(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void ZYmkCRHtXiSwmzpe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pfec3830c$p19f5da85 pfec3830c_p19f5da85 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pfec3830c$p19f5da85(subscriber, (java.util.IEnumerator) xpbaveRWUrrAZcNA(mejbmXGddjubZdIp(this.ff2ab5fb2), "The sources IEnumerable returned a null IEnumerator"));
            zYmkCRHtXiSwmzpe(subscriber, pfec3830c_p19f5da85);
            VhqcJfLDGqDADLIa(pfec3830c_p19f5da85);
        } catch (java.lang.Exception th) {
            HJAPjcyMRnAoIhDQ(th);
            RDsRGFlTBlftNudy(th, subscriber);
        }
    }
}

