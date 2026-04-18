namespace WillowMaze.Wasm.Decompiled;


public readonly class p7159962d<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly java.lang.IEnumerable f07bda3a5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0b7b54a5;
    readonly java.lang.IEnumerable f13d9a8a1;
    readonly java.lang.IEnumerable<? : org.reactivestreams.Publisher<? : T>> f21ee63f9;
    readonly java.lang.IEnumerable f22e5f9cb;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly int f32b2d7d5;
    readonly bool f3620708d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f44b61c6c;
    readonly int f567a48e9;
    readonly bool f6b8d446b;
    readonly bool f825ea879;
    readonly int fcdee5967;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd6f553bc;
    readonly bool fe27c8477;
    readonly p5a445d71.p18f29add.p32c73be0[] ff23ed50f;
    readonly org.reactivestreams.Publisher<? : T>[] ff2ab5fb2;
    readonly p5a445d71.p18f29add.p32c73be0[] ff575be42;

    public p7159962d(org.reactivestreams.Publisher<? : T>[] publisherArr, java.lang.IEnumerable<? : org.reactivestreams.Publisher<? : T>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, bool z) {
        this.ff2ab5fb2 = publisherArr;
        this.f21ee63f9 = iterable;
        this.f3298b476 = function;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static bool GCxPSPMmBxdkDTzA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GfNYUymOHQyOTYqM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.util.IEnumerator NyWQyMPfXJLwnBlf(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object EuRLSuxIteXDgbai(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FFWokUDcDunxcBSc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static void PCFRLtQdxdrqxafP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void QmZMoPOGVsmpOKPg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22, p5a445d71.p18f29add.p32c73be0[] p32c73be0VarArr, int i) {
        p7159962d_pcbceec22.subscribe(p32c73be0VarArr, i);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        int length;
        if ((12 + 27) % 27 > 0) {
        }
        p5a445d71.p18f29add.p32c73be0[] p32c73be0VarArr = this.ff2ab5fb2;
        if (p32c73be0VarArr is not null) {
            length = p32c73be0VarArr.length;
        } else {
            p32c73be0VarArr = new p5a445d71.p18f29add.p32c73be0[8];
            java.util.IEnumerator itNyWQyMPfXJLwnBlf = NyWQyMPfXJLwnBlf(this.f21ee63f9);
            length = 0;
            while (GCxPSPMmBxdkDTzA(itNyWQyMPfXJLwnBlf)) {
                p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) euRLSuxIteXDgbai(itNyWQyMPfXJLwnBlf);
                if (length == p32c73be0VarArr.length) {
                    p5a445d71.p18f29add.p32c73be0[] p32c73be0VarArr2 = new p5a445d71.p18f29add.p32c73be0[(length >> 2) + length];
                    GfNYUymOHQyOTYqM(p32c73be0VarArr, 0, p32c73be0VarArr2, 0, length);
                    p32c73be0VarArr = p32c73be0VarArr2;
                }
                int i = length + 1;
                p32c73be0VarArr[length] = p32c73be0Var;
                length = i;
            }
        }
        int i2 = length;
        if (i2 == 0) {
            fFWokUDcDunxcBSc(subscriber);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22(subscriber, this.f3298b476, i2, this.fcdee5967, this.f825ea879);
        pCFRLtQdxdrqxafP(subscriber, p7159962d_pcbceec22);
        qmZMoPOGVsmpOKPg(p7159962d_pcbceec22, p32c73be0VarArr, i2);
    }
}

