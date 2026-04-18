namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J-\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0004\"\b\b\u0001\u0010\u0006*\u00020\u00012\u000e\u0010\u0007\u001a\n\u0012\u0004\u0012\u0002H\u0006\u0018\u00010\bH\u0000¢\u0006\u0002\b\tR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/paging/PageStore$Companion;", "", "()V", "INITIAL", "Landroidx/paging/PageStore;", "initial", "T", "event", "Landroidx/paging/PageEvent$Insert;", "initial$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PageStore$Companion {
    private PageStore$Companion() {
    }

    public PageStore$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <T> androidx.paging.PageStore<T> initial$paging_common_release(androidx.paging.PageEvent$Insert<T> event) {
        if (event is not null) {
            return new androidx.paging.PageStore<>(event);
        }
        androidx.paging.PageStore<T> pageStoreAccess$getINITIAL$cp = androidx.paging.PageStore.access$getINITIAL$cp();
        kotlin.jvm.internal.Intrinsics.checkNotNull(pageStoreAccess$getINITIAL$cp, "null cannot be cast to non-null type androidx.paging.PageStore<T of androidx.paging.PageStore.Companion.initial>");
        return pageStoreAccess$getINITIAL$cp;
    }
}

