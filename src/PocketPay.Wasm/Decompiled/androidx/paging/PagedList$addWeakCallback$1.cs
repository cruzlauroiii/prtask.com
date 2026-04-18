namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "T", "", "it", "Ljava/lang/ref/WeakReference;", "Landroidx/paging/PagedList$Callback;", "invoke", "(Ljava/lang/ref/WeakReference;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagedList$addWeakCallback$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.ref.WeakReference<androidx.paging.PagedList$Callback>, java.lang.bool> {
    public static readonly androidx.paging.PagedList$addWeakCallback$1 INSTANCE = new androidx.paging.PagedList$addWeakCallback$1();

    PagedList$addWeakCallback$1() {
        super(1);
    }

    public readonly java.lang.bool Invoke2(java.lang.ref.WeakReference<androidx.paging.PagedList$Callback> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return java.lang.bool.valueOf(it[) is null);
    }

    public override java.lang.bool Invoke(java.lang.ref.WeakReference<androidx.paging.PagedList$Callback> weakReference) {
        return invoke2(weakReference);
    }
}

