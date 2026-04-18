namespace WillowMaze.Wasm.Decompiled;


public readonly class pd31aba9b<T, U> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f3e0b3f93;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f7a08b27e;
    readonly p5a445d71.p18f29add.p32c73be0 f85859441;
    readonly p5a445d71.p18f29add.p32c73be0 f8a3b664f;
    readonly p5a445d71.p18f29add.p32c73be0 f93f48843;
    readonly p5a445d71.p18f29add.p32c73be0 f95a18821;
    readonly p5a445d71.p18f29add.p32c73be0 fd445e2bc;
    readonly p5a445d71.p18f29add.p32c73be0 fecbbb972;
    readonly org.reactivestreams.Publisher<? : T> ffad58de7;

    public pd31aba9b(org.reactivestreams.Publisher<? : T> publisher, org.reactivestreams.Publisher<U> publisher2) {
        this.ffad58de7 = publisher;
        this.f795f3202 = publisher2;
    }

    public static void TqKPlkaziCJktsYB(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void CqWoRhcCIVjoAYln(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((15 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749 pd31aba9b_pfee09749 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749(subscriber, this.ffad58de7);
        cqWoRhcCIVjoAYln(subscriber, pd31aba9b_pfee09749);
        TqKPlkaziCJktsYB(this.f795f3202, pd31aba9b_pfee09749.f795f3202);
    }
}

