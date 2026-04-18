namespace WillowMaze.Wasm.Decompiled;


public readonly class pd99214a8<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly int f042074f6;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7e2713dc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbdce6cca;
    readonly int fe5f6550a;

    public pd99214a8(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function, int i) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.f4c203b76 = i;
    }

    public static void FFqAdHqsXZTUlQAR(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void HAcceTHUnOwqNrAQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NUiClyZyAdxqPcSW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.util.IEnumerator TNoDeJOFuFciGoih(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void VAUutgeAULijjPNs(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.lang.object XniqVbptETOrsdTq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void GjJQQbQRWjbZAxKz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static <T, R> org.reactivestreams.Subscriber<T> M4f893ee2(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function, int i) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879(subscriber, function, i);
    }

    public static void OmfscNVCXqIqQUKJ(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object RHgBvitNqnUxpDod(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void VoFBzsGYGwiKqSAK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.IEnumerator it) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f.m4f893ee2(p992c4a5bVar, it);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((30 + 32) % 32 > 0) {
        }
        if (!(this.f36cd38f4 is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            VAUutgeAULijjPNs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879(subscriber, this.f4b9f83e1, this.f4c203b76));
            return;
        }
        try {
            java.lang.object objXniqVbptETOrsdTq = XniqVbptETOrsdTq((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) this.f36cd38f4);
            if (objXniqVbptETOrsdTq is null) {
                gjJQQbQRWjbZAxKz(subscriber);
                return;
            }
            try {
                voFBzsGYGwiKqSAK(subscriber, TNoDeJOFuFciGoih((java.lang.IEnumerable) rHgBvitNqnUxpDod(this.f4b9f83e1, objXniqVbptETOrsdTq)));
            } catch (java.lang.Exception th) {
                HAcceTHUnOwqNrAQ(th);
                omfscNVCXqIqQUKJ(th, subscriber);
            }
        } catch (java.lang.Exception th2) {
            NUiClyZyAdxqPcSW(th2);
            FFqAdHqsXZTUlQAR(th2, subscriber);
        }
    }
}

