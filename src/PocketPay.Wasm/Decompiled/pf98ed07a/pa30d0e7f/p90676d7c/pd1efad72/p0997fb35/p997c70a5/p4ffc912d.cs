namespace WillowMaze.Wasm.Decompiled;


public readonly class p4ffc912d<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f1a42819e;
    readonly int f1c2ef74f;
    readonly int f20e9a6e1;
    readonly io.reactivex.rxjava3.observables.ConnectableObservable<? : T> f36cd38f4;
    readonly java.util.concurrent.atomic.Atomicint f3c575232;
    readonly int f3d3af1f6;
    readonly io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f4717d53e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f700c5047;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be fb3601cff;
    readonly java.util.concurrent.atomic.Atomicint ff51f90dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be ff5feb839;
    readonly java.util.concurrent.atomic.Atomicint ff8131851;
    readonly java.util.concurrent.atomic.Atomicint ffac04ca6 = new java.util.concurrent.atomic.Atomicint();

    public p4ffc912d(io.reactivex.rxjava3.observables.ConnectableObservable<? : T> connectableObservable, int i, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer) {
        this.f36cd38f4 = connectableObservable;
        this.f20e9a6e1 = i;
        this.f4717d53e = consumer;
    }

    public static void MABqeanZAMInTYFQ(pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be pa6a851beVar, io.reactivex.rxjava3.core.Observer observer) {
        pa6a851beVar.subscribe(observer);
    }

    public static int EOLAfzsLNCDkzHpg(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static void NWSVWYBptKStpiYN(pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be pa6a851beVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        pa6a851beVar.connect(pf8afcf86Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        MABqeanZAMInTYFQ(this.f36cd38f4, observer);
        if (eOLAfzsLNCDkzHpg(this.ffac04ca6) != this.f20e9a6e1) {
            return;
        }
        nWSVWYBptKStpiYN(this.f36cd38f4, this.f4717d53e);
    }
}

