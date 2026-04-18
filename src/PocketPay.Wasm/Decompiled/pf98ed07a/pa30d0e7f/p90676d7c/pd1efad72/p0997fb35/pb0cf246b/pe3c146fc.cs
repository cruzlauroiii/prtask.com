namespace WillowMaze.Wasm.Decompiled;


public readonly class pe3c146fc<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly java.lang.IEnumerable f012fe2dd;
    readonly java.lang.IEnumerable<? : org.reactivestreams.Publisher<object>> f3ee0557a;
    readonly org.reactivestreams.Publisher<object>[] f44c387ca;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5e0efbe1;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> f61aaf8fd;
    readonly p5a445d71.p18f29add.p32c73be0[] f64f994f1;
    readonly java.lang.IEnumerable f80ee3d4e;
    readonly java.lang.IEnumerable fa6058450;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc72b165e;
    readonly p5a445d71.p18f29add.p32c73be0[] fce1da139;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd9cbc5af;

    public pe3c146fc(io.reactivex.rxjava3.core.Flowable<T> flowable, java.lang.IEnumerable<? : org.reactivestreams.Publisher<object>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function) {
        super(flowable);
        this.f44c387ca = null;
        this.f3ee0557a = iterable;
        this.f61aaf8fd = function;
    }

    public pe3c146fc(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<object>[] publisherArr, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function) {
        super(flowable);
        this.f44c387ca = publisherArr;
        this.f3ee0557a = null;
        this.f61aaf8fd = function;
    }

    public static java.lang.object[] AiNAjJzFQArGuLkw(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void DnXzlIVKvOvXFdBP(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.util.IEnumerator EfUKDDONYMcVRyqJ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void EkEzxQztNJIktbcs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void FdXVWKpzxSaLsBaA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, p5a445d71.p18f29add.p32c73be0[] p32c73be0VarArr, int i) {
        pe3c146fc_p0d7efdfb.subscribe(p32c73be0VarArr, i);
    }

    public static bool HhwAlfjAJwfMxVWL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void KZBzYwXjQEwToAxB(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void NyxlvotJvJlPfWBj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793 pa04d7793Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pa04d7793Var.subscribeActual(p992c4a5bVar);
    }

    public static java.lang.object TrycOcydIgtDvqnl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UdbITCtnJUkCkEHK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        int length;
        if ((1 + 1) % 1 > 0) {
        }
        p5a445d71.p18f29add.p32c73be0[] p32c73be0VarArr = this.f44c387ca;
        if (p32c73be0VarArr is not null) {
            length = p32c73be0VarArr.length;
        } else {
            p32c73be0VarArr = new p5a445d71.p18f29add.p32c73be0[8];
            try {
                java.util.IEnumerator itEfUKDDONYMcVRyqJ = EfUKDDONYMcVRyqJ(this.f3ee0557a);
                length = 0;
                while (hhwAlfjAJwfMxVWL(itEfUKDDONYMcVRyqJ)) {
                    p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) trycOcydIgtDvqnl(itEfUKDDONYMcVRyqJ);
                    if (length == p32c73be0VarArr.length) {
                        p32c73be0VarArr = (p5a445d71.p18f29add.p32c73be0[]) AiNAjJzFQArGuLkw(p32c73be0VarArr, (length >> 1) + length);
                    }
                    int i = length + 1;
                    p32c73be0VarArr[length] = p32c73be0Var;
                    length = i;
                }
            } catch (java.lang.Exception th) {
                ekEzxQztNJIktbcs(th);
                kZBzYwXjQEwToAxB(th, subscriber);
                return;
            }
        }
        if (length == 0) {
            nyxlvotJvJlPfWBj(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$pfb7c43fc(this)), subscriber);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb(subscriber, this.f61aaf8fd, length);
        udbITCtnJUkCkEHK(subscriber, pe3c146fc_p0d7efdfb);
        fdXVWKpzxSaLsBaA(pe3c146fc_p0d7efdfb, p32c73be0VarArr, length);
        DnXzlIVKvOvXFdBP(this.f36cd38f4, pe3c146fc_p0d7efdfb);
    }
}

