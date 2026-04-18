namespace WillowMaze.Wasm.Decompiled;


public readonly class p099f5599<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly java.lang.object[] f29e2ad95;
    readonly java.lang.object[] fe8cb1bd6;
    readonly T[] ff1f713c9;

    public p099f5599(T[] tArr) {
        this.ff1f713c9 = tArr;
    }

    public static void MbxccFadZIJzSWaJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p099f5599$pb8d3bcca p099f5599_pb8d3bcca) {
        p099f5599_pb8d3bcca.run();
    }

    public static void QwTBNTbbDzCWgyAG(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p099f5599$pb8d3bcca p099f5599_pb8d3bcca = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p099f5599$pb8d3bcca(observer, this.ff1f713c9);
        qwTBNTbbDzCWgyAG(observer, p099f5599_pb8d3bcca);
        if (p099f5599_pb8d3bcca.f06b7c4ff) {
            return;
        }
        MbxccFadZIJzSWaJ(p099f5599_pb8d3bcca);
    }
}

