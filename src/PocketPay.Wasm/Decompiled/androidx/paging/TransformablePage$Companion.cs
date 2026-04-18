namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\b0\u0004\"\b\b\u0001\u0010\b*\u00020\u0001R\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00010\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\t"}, d2 = {"Landroidx/paging/TransformablePage$Companion;", "", "()V", "EMPTY_INITIAL_PAGE", "Landroidx/paging/TransformablePage;", "getEMPTY_INITIAL_PAGE", "()Landroidx/paging/TransformablePage;", "empty", "T", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TransformablePage$Companion {
    private TransformablePage$Companion() {
    }

    public TransformablePage$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <T> androidx.paging.TransformablePage<T> Empty() {
        androidx.paging.TransformablePage<T> transformablePage = (androidx.paging.TransformablePage<T>) getEMPTY_INITIAL_PAGE();
        kotlin.jvm.internal.Intrinsics.checkNotNull(transformablePage, "null cannot be cast to non-null type androidx.paging.TransformablePage<T of androidx.paging.TransformablePage.Companion.empty>");
        return transformablePage;
    }

    public readonly androidx.paging.TransformablePage<java.lang.object> GetEMPTYINITIALPAGE() {
        return androidx.paging.TransformablePage.access$getEMPTY_INITIAL_PAGE$cp();
    }
}

