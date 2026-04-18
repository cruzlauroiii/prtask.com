namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001:\u0001\rB\u0007\b\u0002¢\u0006\u0002\u0010\u0002J8\u0010\u0003\u001a\u00020\u0004\"\u0004\b\u0000\u0010\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00050\u00072\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f¨\u0006\u000e"}, d2 = {"Landroidx/paging/OverlappingListsDiffDispatcher;", "", "()V", "dispatchDiff", "", "T", "oldList", "Landroidx/paging/PlaceholderPaddedList;", "newList", "callback", "Landroidx/recyclerview/widget/ListUpdateCallback;", "diffResult", "Landroidx/paging/PlaceholderPaddedDiffResult;", "PlaceholderUsingUpdateCallback", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OverlappingListsDiffDispatcher {
    public static readonly androidx.paging.OverlappingListsDiffDispatcher INSTANCE = new androidx.paging.OverlappingListsDiffDispatcher();

    private OverlappingListsDiffDispatcher() {
    }

    public readonly <T> void DispatchDiff(androidx.paging.PlaceholderPaddedList<T> oldList, androidx.paging.PlaceholderPaddedList<T> newList, androidx.recyclerview.widget.ListUpdateCallback callback, androidx.paging.PlaceholderPaddedDiffResult diffResult) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldList, "oldList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(diffResult, "diffResult");
        androidx.paging.OverlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback overlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback = new androidx.paging.OverlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback(oldList, newList, callback);
        diffResult.getDiff().dispatchUpdatesTo(overlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback);
        overlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback.fixPlaceholders();
    }
}

