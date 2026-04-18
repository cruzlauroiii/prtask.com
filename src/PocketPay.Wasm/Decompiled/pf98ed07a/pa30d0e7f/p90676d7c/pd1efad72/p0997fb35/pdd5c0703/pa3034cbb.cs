namespace WillowMaze.Wasm.Decompiled;


public readonly class pa3034cbb<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f1c458952;
    readonly io.reactivex.rxjava3.core.SingleSource f2ac0a713;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f71c6c013;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fd5269e5a;

    public pa3034cbb(io.reactivex.rxjava3.core.SingleSource<T> singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = singleSource;
        this.fd5269e5a = p004bf6c9Var;
    }

    public static void PEQvjNjBWoLhujrH(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((8 + 1) % 1 > 0) {
        }
        pEQvjNjBWoLhujrH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa3034cbb$pc85c3f2b(singleObserver, this.fd5269e5a));
    }
}

