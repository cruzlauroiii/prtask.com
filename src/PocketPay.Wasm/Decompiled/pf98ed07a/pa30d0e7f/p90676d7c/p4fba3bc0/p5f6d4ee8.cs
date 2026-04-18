namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001aF\u0010\u0000\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00040\u00020\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0005\"\b\b\u0001\u0010\u0004*\u00020\u0005*\b\u0012\u0004\u0012\u0002H\u00030\u00012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0007H\u0007\u001ad\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\b0\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0005\"\b\b\u0001\u0010\u0004*\u00020\u0005\"\b\b\u0002\u0010\b*\u00020\u0005*\b\u0012\u0004\u0012\u0002H\u00030\u00012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u00072\u001a\b\u0004\u0010\t\u001a\u0014\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u0002H\b0\nH\u0087\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000b"}, d2 = {"zipWith", "Lio/reactivex/rxjava3/core/Single;", "Lkotlin/ValueTuple;", "T", "U", "", "other", "Lio/reactivex/rxjava3/core/SingleSource;", "R", "zipper", "Lkotlin/Function2;", "rxkotlin"}, m527k = 2, mv = {1, 4, 0})
public readonly class p5f6d4ee8 {
    public static void DUqEjRFAdDuvUeAl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FCQmuYHUxqBXxjJS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IkoEHBZkdiMzJrlM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IuMQNCzSVBGPjlOg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single LShrDWGMfZhrlNfu(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleSource singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar) {
        return single.zipWith(singleSource, pa3d429baVar);
    }

    public static void VvZPaDsmeOXgxXrk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void WFjscWczwWuzNBpT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void FYqRJMaTKgESxGjb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T, U> io.reactivex.rxjava3.core.Single<kotlin.ValueTuple<T, U>> M51f5e484(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.core.SingleSource<U> singleSource) {
        DUqEjRFAdDuvUeAl(single, "$this$zipWith");
        IuMQNCzSVBGPjlOg(singleSource, "other");
        io.reactivex.rxjava3.core.Single<kotlin.ValueTuple<T, U>> singleLShrDWGMfZhrlNfu = LShrDWGMfZhrlNfu(single, singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.p5f6d4ee8$p51f5e484$2.f76425f17);
        WFjscWczwWuzNBpT(singleLShrDWGMfZhrlNfu, "zipWith(other, BiFunction { t, u -> ValueTuple(t, u) })");
        return singleLShrDWGMfZhrlNfu;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "New type inference algorithm in Kotlin 1.4 makes this method obsolete. Method will be removed in future RxKotlin release.", replaceWith = @kotlin.ReplaceWith(expression = "zipWith(other, zipper)", imports = {}))
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T, U, R> io.reactivex.rxjava3.core.Single<R> M51f5e484(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.core.SingleSource<U> singleSource, kotlin.jvm.functions.Function2<? super T, ? super U, ? : R> function2) {
        IkoEHBZkdiMzJrlM(single, "$this$zipWith");
        fYqRJMaTKgESxGjb(singleSource, "other");
        FCQmuYHUxqBXxjJS(function2, "zipper");
        io.reactivex.rxjava3.core.Single<R> singleVdgNjmOxcvueUozS = vdgNjmOxcvueUozS(single, singleSource, new pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.p5f6d4ee8$p51f5e484$1(function2));
        VvZPaDsmeOXgxXrk(singleVdgNjmOxcvueUozS, "zipWith(other, BiFunctio…-> zipper.invoke(t, u) })");
        return singleVdgNjmOxcvueUozS;
    }

    public static io.reactivex.rxjava3.core.Single VdgNjmOxcvueUozS(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleSource singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar) {
        return single.zipWith(singleSource, pa3d429baVar);
    }
}

