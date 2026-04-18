namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001aF\u0010\u0000\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00040\u00020\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0005\"\b\b\u0001\u0010\u0004*\u00020\u0005*\b\u0012\u0004\u0012\u0002H\u00030\u00012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0007H\u0007\u001ad\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\b0\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0005\"\b\b\u0001\u0010\u0004*\u00020\u0005\"\b\b\u0002\u0010\b*\u00020\u0005*\b\u0012\u0004\u0012\u0002H\u00030\u00012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u00072\u001a\b\u0004\u0010\t\u001a\u0014\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u0002H\b0\nH\u0087\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000b"}, d2 = {"zipWith", "Lio/reactivex/rxjava3/core/Maybe;", "Lkotlin/ValueTuple;", "T", "U", "", "other", "Lio/reactivex/rxjava3/core/MaybeSource;", "R", "zipper", "Lkotlin/Function2;", "rxkotlin"}, m527k = 2, mv = {1, 4, 0})
public readonly class pf2a5f00c {
    public static void GCFMkWwppXpAUFyk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QygwUGflqHazGQkU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Maybe RQKDiaLBuDtJayxM(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeSource maybeSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar) {
        return maybe.zipWith(maybeSource, pa3d429baVar);
    }

    public static io.reactivex.rxjava3.core.Maybe UXUwIGkxsRqfDixQ(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeSource maybeSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar) {
        return maybe.zipWith(maybeSource, pa3d429baVar);
    }

    public static void VJfDmrMfTmIgEwID(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YVAEusGZhBSLHfzx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IdPRGrQFtqcgYmSp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T, U> io.reactivex.rxjava3.core.Maybe<kotlin.ValueTuple<T, U>> M51f5e484(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.core.MaybeSource<U> maybeSource) {
        QygwUGflqHazGQkU(maybe, "$this$zipWith");
        nJGtzjvQilkHqACz(maybeSource, "other");
        io.reactivex.rxjava3.core.Maybe<kotlin.ValueTuple<T, U>> maybeRQKDiaLBuDtJayxM = RQKDiaLBuDtJayxM(maybe, maybeSource, pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pf2a5f00c$p51f5e484$2.f76425f17);
        idPRGrQFtqcgYmSp(maybeRQKDiaLBuDtJayxM, "zipWith(other, BiFunction { t, u -> ValueTuple(t, u) })");
        return maybeRQKDiaLBuDtJayxM;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "New type inference algorithm in Kotlin 1.4 makes this method obsolete. Method will be removed in future RxKotlin release.", replaceWith = @kotlin.ReplaceWith(expression = "zipWith(other, zipper)", imports = {}))
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
    public static readonly <T, U, R> io.reactivex.rxjava3.core.Maybe<R> M51f5e484(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.core.MaybeSource<U> maybeSource, kotlin.jvm.functions.Function2<? super T, ? super U, ? : R> function2) {
        qVScqqDrlQfLRDAX(maybe, "$this$zipWith");
        GCFMkWwppXpAUFyk(maybeSource, "other");
        VJfDmrMfTmIgEwID(function2, "zipper");
        io.reactivex.rxjava3.core.Maybe<R> maybeUXUwIGkxsRqfDixQ = UXUwIGkxsRqfDixQ(maybe, maybeSource, new pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pf2a5f00c$p51f5e484$1(function2));
        YVAEusGZhBSLHfzx(maybeUXUwIGkxsRqfDixQ, "zipWith(other, BiFunctio…-> zipper.invoke(t, u) })");
        return maybeUXUwIGkxsRqfDixQ;
    }

    public static void NJGtzjvQilkHqACz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QVScqqDrlQfLRDAX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

