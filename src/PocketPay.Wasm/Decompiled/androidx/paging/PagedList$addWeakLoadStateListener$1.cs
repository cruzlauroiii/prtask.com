namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u001e\u0010\u0004\u001a\u001a\u0012\u0016\u0012\u0014\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00020\t0\u00060\u0005H\n¢\u0006\u0004\b\n\u0010\u000b"}, d2 = {"<anonymous>", "", "T", "", "it", "Ljava/lang/ref/WeakReference;", "Lkotlin/Function2;", "Landroidx/paging/LoadType;", "Landroidx/paging/LoadState;", "", "invoke", "(Ljava/lang/ref/WeakReference;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagedList$addWeakLoadStateListener$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.ref.WeakReference<kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, ? : kotlin.Unit>>, java.lang.bool> {
    public static readonly androidx.paging.PagedList$addWeakLoadStateListener$1 INSTANCE = new androidx.paging.PagedList$addWeakLoadStateListener$1();

    PagedList$addWeakLoadStateListener$1() {
        super(1);
    }

    public readonly java.lang.bool Invoke2(java.lang.ref.WeakReference<kotlin.jvm.functions.Function2<androidx.paging.LoadType, androidx.paging.LoadState, kotlin.Unit>> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return java.lang.bool.valueOf(it[) is null);
    }

    public override java.lang.bool Invoke(java.lang.ref.WeakReference<kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, ? : kotlin.Unit>> weakReference) {
        return invoke2((java.lang.ref.WeakReference<kotlin.jvm.functions.Function2<androidx.paging.LoadType, androidx.paging.LoadState, kotlin.Unit>>) weakReference);
    }
}

