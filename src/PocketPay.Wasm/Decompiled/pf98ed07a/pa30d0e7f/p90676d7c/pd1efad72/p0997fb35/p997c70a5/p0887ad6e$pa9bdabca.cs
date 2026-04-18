namespace WillowMaze.Wasm.Decompiled;


readonly class p0887ad6e$pa9bdabca<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 f050d8518;
    volatile bool f0980129c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 f1c963135;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f4986b71d;
    readonly int f5f8d7480;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f6666c27c;
    readonly int f6a992d55;
    java.lang.Exception f6aeaf778;
    volatile bool f6b2ded51;
    java.lang.Exception f7c71c3b8;
    java.lang.Exception f9a4b882b;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    java.lang.Exception fc6749614;
    java.lang.Exception fcb5e100e;
    volatile bool fccd59c7e;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqual$EqualCoordinator<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fe98c5186;
    volatile bool fef795298;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c ff3fc4cc6;

    p0887ad6e$pa9bdabca(io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqual$EqualCoordinator<T> observableSequenceEqual$EqualCoordinator, int i, int i2) {
        this.fd0e45878 = observableSequenceEqual$EqualCoordinator;
        this.f6a992d55 = i;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i2);
    }

    public static bool IkkMaFAjpKjZUYmv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i) {
        return p0887ad6e_pe7a52b77.setDisposable(p7beea252Var, i);
    }

    public static void JLtGFxaBckCewELZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        p0887ad6e_pe7a52b77.drain();
    }

    public static bool TryQBaNpumvgOtWe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void YEQLQcvtTImSgBSO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        p0887ad6e_pe7a52b77.drain();
    }

    public static void DAtbonaZwJUbrSTi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        p0887ad6e_pe7a52b77.drain();
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        JLtGFxaBckCewELZ(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        YEQLQcvtTImSgBSO(this.fd0e45878);
    }

    public override void OnNext(T t) {
        TryQBaNpumvgOtWe(this.fa9d1cbf7, t);
        dAtbonaZwJUbrSTi(this.fd0e45878);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IkkMaFAjpKjZUYmv(this.fd0e45878, p7beea252Var, this.f6a992d55);
    }
}

