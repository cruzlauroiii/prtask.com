namespace WillowMaze.Wasm.Decompiled;


readonly class pa4690a5a$p03fceb00$pa02735fe<U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<U> {
    private static readonly long f504f0472 = -1266041316834525931L;
    private static readonly long f8c181fcf = -1266041316834525931L;
    private static readonly long fadc2682c = -1266041316834525931L;
    private static readonly long fc6e1e520 = -1266041316834525931L;
    private static readonly long fdf329122 = -1266041316834525931L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 f2a32088c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 f32bc6d2a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 fa258870f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 fbd05d43c;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTakeUntilMaybe$TakeUntilMainMaybeObserver<object, U> fd0e45878;

    pa4690a5a$p03fceb00$pa02735fe(io.reactivex.rxjava3.internal.operators.maybe.MaybeTakeUntilMaybe$TakeUntilMainMaybeObserver<object, U> maybeTakeUntilMaybe$TakeUntilMainMaybeObserver) {
        this.fd0e45878 = maybeTakeUntilMaybe$TakeUntilMainMaybeObserver;
    }

    public static void UopNjrOyeSdTezGz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 pa4690a5a_p03fceb00) {
        pa4690a5a_p03fceb00.otherComplete();
    }

    public static void ISfsUJeYteOIGMhw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 pa4690a5a_p03fceb00) {
        pa4690a5a_p03fceb00.otherComplete();
    }

    public static bool KdvcUbbKKbBzrBBS(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void ZqeskawKHAArIwce(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 pa4690a5a_p03fceb00, java.lang.Exception th) {
        pa4690a5a_p03fceb00.otherError(th);
    }

    public override void OnComplete() {
        iSfsUJeYteOIGMhw(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        zqeskawKHAArIwce(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        kdvcUbbKKbBzrBBS(this, p7beea252Var);
    }

    public override void OnSuccess(java.lang.object obj) {
        UopNjrOyeSdTezGz(this.fd0e45878);
    }
}

