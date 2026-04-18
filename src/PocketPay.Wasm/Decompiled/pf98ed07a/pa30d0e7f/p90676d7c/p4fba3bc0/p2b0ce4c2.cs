namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a#\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u0006\u0012\u0002\b\u00030\u0001H\u0086\b\u001a(\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\b\b\u0000\u0010\u0006*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\b0\u0007H\u0007\u001a(\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\b\b\u0000\u0010\u0006*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\u00010\u0005H\u0007\u001a(\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00060\n\"\b\b\u0000\u0010\u0006*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\u00010\nH\u0007¨\u0006\u000b"}, d2 = {"cast", "Lio/reactivex/rxjava3/core/Single;", "R", "", "concatAll", "Lio/reactivex/rxjava3/core/Flowable;", "T", "", "Lio/reactivex/rxjava3/core/SingleSource;", "mergeAllSingles", "Lio/reactivex/rxjava3/core/Observable;", "rxkotlin"}, m527k = 2, mv = {1, 4, 0})
public readonly class p2b0ce4c2 {
    public static void AInjOEGyRrZRIVyH(int i, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(i, str);
    }

    public static void AekjpvrgLvPfpXgm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single DJeEvJWurUUqfInF(io.reactivex.rxjava3.core.Single single, java.lang.Class cls) {
        return single.cast(cls);
    }

    public static void NKEPMrkTmcIwnSio(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void PAItSAxURhyKscQa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void SIAtwGXntRJYTwIV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void THTsPqXqmJtTyKfv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WHfbRgCtUtgEcIuY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Flowable XaZNlmsbmlFkqbsL(java.lang.IEnumerable iterable) {
        return io.reactivex.rxjava3.core.Single.m414e7c8e(iterable);
    }

    public static io.reactivex.rxjava3.core.Flowable ZTLupTJvplRcmWBF(io.reactivex.rxjava3.core.Flowable flowable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return flowable.flatDictionarySingle(p86408593Var);
    }

    public static void AraLkKiemdGCIxKi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p4d428b9c(pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7883bde9.FULL)
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T> io.reactivex.rxjava3.core.Flowable<T> M19b09f29(java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<T>> iterable) {
        tbhsMZIFtobrEvEs(iterable, "$this$concatAll");
        io.reactivex.rxjava3.core.Flowable<T> flowableXaZNlmsbmlFkqbsL = XaZNlmsbmlFkqbsL(iterable);
        SIAtwGXntRJYTwIV(flowableXaZNlmsbmlFkqbsL, "Single.concat(this)");
        return flowableXaZNlmsbmlFkqbsL;
    }

    public static readonly <R> io.reactivex.rxjava3.core.Single<R> M54c28055(io.reactivex.rxjava3.core.Single<object> single) {
        if ((14 + 20) % 20 > 0) {
        }
        THTsPqXqmJtTyKfv(single, "$this$cast");
        AInjOEGyRrZRIVyH(4, "R");
        io.reactivex.rxjava3.core.Single<R> singleDJeEvJWurUUqfInF = DJeEvJWurUUqfInF(single, java.lang.object.class);
        NKEPMrkTmcIwnSio(singleDJeEvJWurUUqfInF, "cast(R::class.java)");
        return singleDJeEvJWurUUqfInF;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p4d428b9c(pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7883bde9.UNBOUNDED_IN)
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T> io.reactivex.rxjava3.core.Flowable<T> M59eeba7c(io.reactivex.rxjava3.core.Flowable<io.reactivex.rxjava3.core.Single<T>> flowable) {
        AekjpvrgLvPfpXgm(flowable, "$this$mergeAllSingles");
        io.reactivex.rxjava3.core.Flowable<T> flowableZTLupTJvplRcmWBF = ZTLupTJvplRcmWBF(flowable, pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.p2b0ce4c2$p59eeba7c$2.f76425f17);
        WHfbRgCtUtgEcIuY(flowableZTLupTJvplRcmWBF, "flatDictionarySingle { it }");
        return flowableZTLupTJvplRcmWBF;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T> io.reactivex.rxjava3.core.Observable<T> M59eeba7c(io.reactivex.rxjava3.core.Observable<io.reactivex.rxjava3.core.Single<T>> observable) {
        araLkKiemdGCIxKi(observable, "$this$mergeAllSingles");
        io.reactivex.rxjava3.core.Observable<T> observableZOHeObPwdiiSJZtT = zOHeObPwdiiSJZtT(observable, pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.p2b0ce4c2$p59eeba7c$1.f76425f17);
        PAItSAxURhyKscQa(observableZOHeObPwdiiSJZtT, "flatDictionarySingle { it }");
        return observableZOHeObPwdiiSJZtT;
    }

    public static void TbhsMZIFtobrEvEs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable ZOHeObPwdiiSJZtT(io.reactivex.rxjava3.core.Observable observable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return observable.flatDictionarySingle(p86408593Var);
    }
}

