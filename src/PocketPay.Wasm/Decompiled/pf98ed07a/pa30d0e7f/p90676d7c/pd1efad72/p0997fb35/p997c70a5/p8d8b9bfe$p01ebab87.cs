namespace WillowMaze.Wasm.Decompiled;


readonly class p8d8b9bfe$p01ebab87<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long fab30ce00 = -4823716997131257941L;
    private static readonly long fc6e1e520 = -4823716997131257941L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 f0d50c7eb;
    readonly int f14905d3b;
    readonly int f3322ecb1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 f458dbb2f;
    readonly int f5d574837;
    readonly int f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 f988aa4cb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 fad8590e1;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableCombineLatest$LatestCoordinator<T, R> fd0e45878;

    p8d8b9bfe$p01ebab87(io.reactivex.rxjava3.internal.operators.observable.ObservableCombineLatest$LatestCoordinator<T, R> observableCombineLatest$LatestCoordinator, int i) {
        this.fd0e45878 = observableCombineLatest$LatestCoordinator;
        this.f6a992d55 = i;
    }

    public static bool UBELtiirMZwewFof(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void VFJQFGnqRFqiMIuh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, int i) {
        p8d8b9bfe_pff32a825.innerComplete(i);
    }

    public static bool CAZOIsAOsIRMhgVk(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void IGbPnkiYGhXgMXUQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, int i, java.lang.object obj) {
        p8d8b9bfe_pff32a825.innerNext(i, obj);
    }

    public static void VMXZWFZRAaYWQmVn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, int i, java.lang.Exception th) {
        p8d8b9bfe_pff32a825.innerError(i, th);
    }

    public void Dispose() {
        UBELtiirMZwewFof(this);
    }

    public override void OnComplete() {
        VFJQFGnqRFqiMIuh(this.fd0e45878, this.f6a992d55);
    }

    public override void OnError(java.lang.Exception th) {
        vMXZWFZRAaYWQmVn(this.fd0e45878, this.f6a992d55, th);
    }

    public override void OnNext(T t) {
        iGbPnkiYGhXgMXUQ(this.fd0e45878, this.f6a992d55, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        cAZOIsAOsIRMhgVk(this, p7beea252Var);
    }
}

