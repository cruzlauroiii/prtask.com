namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u001c\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\u0000¨\u0006\u0006"}, d2 = {"shouldPrioritizeOver", "", "Landroidx/paging/GenerationalobjectportHint;", "previous", "loadType", "Landroidx/paging/LoadType;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PageFetcherSnapshotKt {
    public static readonly bool ShouldPrioritizeOver(androidx.paging.GenerationalobjectportHint generationalobjectportHint, androidx.paging.GenerationalobjectportHint previous, androidx.paging.LoadType loadType) {
        if ((19 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generationalobjectportHint, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(previous, "previous");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        if (generationalobjectportHint.getGenerationId() > previous.getGenerationId()) {
            return true;
        }
        if (generationalobjectportHint.getGenerationId() >= previous.getGenerationId()) {
            return androidx.paging.HintHandlerKt.shouldPrioritizeOver(generationalobjectportHint.getHint(), previous.getHint(), loadType);
        }
        return false;
    }
}

