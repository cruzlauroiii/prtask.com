namespace WillowMaze.Wasm.Decompiled;


readonly class p5e964be4$pa9bdabca<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly int f1bc65ab4;
    java.lang.Exception f3304e86d;
    volatile bool f33557091;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 f405be39b;
    java.lang.Exception f4836426a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f5b458e98;
    readonly int f6a992d55;
    volatile bool f6b2ded51;
    volatile bool f805c1816;
    java.lang.Exception f8162426a;
    volatile bool f85255907;
    volatile bool f97a27d8c;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 fb1bab012;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fba69bd32;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 fc34841ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fc99ee28e;
    java.lang.Exception fcacc5c1b;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqualSingle$EqualCoordinator<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 fe6fb8b2e;

    p5e964be4$pa9bdabca(io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqualSingle$EqualCoordinator<T> observableSequenceEqualSingle$EqualCoordinator, int i, int i2) {
        this.fd0e45878 = observableSequenceEqualSingle$EqualCoordinator;
        this.f6a992d55 = i;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i2);
    }

    public static void UQmawMPdGYWCPZeg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        p5e964be4_pe7a52b77.drain();
    }

    public static void AcVdldusitpEZHYI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        p5e964be4_pe7a52b77.drain();
    }

    public static bool IobOjITqwMPODHXR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static bool MHOMSYZuPBdzUFUN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i) {
        return p5e964be4_pe7a52b77.setDisposable(p7beea252Var, i);
    }

    public static void TwqFothfujkpqZiS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        p5e964be4_pe7a52b77.drain();
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        twqFothfujkpqZiS(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        UQmawMPdGYWCPZeg(this.fd0e45878);
    }

    public override void OnNext(T t) {
        iobOjITqwMPODHXR(this.fa9d1cbf7, t);
        acVdldusitpEZHYI(this.fd0e45878);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        mHOMSYZuPBdzUFUN(this.fd0e45878, p7beea252Var, this.f6a992d55);
    }
}

