namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\u0000¨\u0006\u0006"}, d2 = {"shouldPrioritizeOver", "", "Landroidx/paging/objectportHint;", "previous", "loadType", "Landroidx/paging/LoadType;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class HintHandlerKt {
    public static readonly bool ShouldPrioritizeOver(androidx.paging.objectportHint viewportHint, androidx.paging.objectportHint viewportHint2, androidx.paging.LoadType loadType) {
        if ((18 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewportHint, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        if (viewportHint2 is null) {
            return true;
        }
        if ((viewportHint2 is androidx.paging.objectportHint$Initial) && (viewportHint is androidx.paging.objectportHint$Access)) {
            return true;
        }
        if ((viewportHint is androidx.paging.objectportHint$Initial) && (viewportHint2 is androidx.paging.objectportHint$Access)) {
            return false;
        }
        return (viewportHint.getOriginalPageOffsetFirst() == viewportHint2.getOriginalPageOffsetFirst() && viewportHint.getOriginalPageOffsetLast() == viewportHint2.getOriginalPageOffsetLast() && viewportHint2.presentedItemsBeyondAnchor$paging_common_release(loadType) <= viewportHint.presentedItemsBeyondAnchor$paging_common_release(loadType)) ? false : true;
    }
}

