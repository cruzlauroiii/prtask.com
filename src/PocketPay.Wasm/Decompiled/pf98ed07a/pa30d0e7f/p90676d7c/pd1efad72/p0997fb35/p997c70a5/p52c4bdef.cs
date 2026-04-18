namespace WillowMaze.Wasm.Decompiled;


public readonly class p52c4bdef<T> : java.lang.IEnumerable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f2de960b7;
    readonly int f3561700e;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f87ca8e6f;
    readonly io.reactivex.rxjava3.core.ObservableSource f9a8b737c;
    readonly int fa7bfca1a;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.ObservableSource fce69b021;
    readonly int fd6fd3525;
    readonly int fe8eaaef7;

    public p52c4bdef(io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, int i) {
        this.f36cd38f4 = observableSource;
        this.fcdee5967 = i;
    }

    public static void BAXxaclQxkrGyBgs(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((14 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b(this.fcdee5967);
        bAXxaclQxkrGyBgs(this.f36cd38f4, p52c4bdef_pb173946b);
        return p52c4bdef_pb173946b;
    }
}

