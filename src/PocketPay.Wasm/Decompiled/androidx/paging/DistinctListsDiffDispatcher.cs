namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J8\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\b2\u0006\u0010\n\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\u0001H\u0002J4\u0010\r\u001a\u00020\u0004\"\b\b\u0000\u0010\u000e*\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000e0\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000e0\u0010¨\u0006\u0012"}, d2 = {"Landroidx/paging/DistinctListsDiffDispatcher;", "", "()V", "dispatchChange", "", "callback", "Landroidx/recyclerview/widget/ListUpdateCallback;", "startBoundary", "", "endBoundary", "start", "end", "payload", "dispatchDiff", "T", "oldList", "Landroidx/paging/PlaceholderPaddedList;", "newList", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DistinctListsDiffDispatcher {
    public static readonly androidx.paging.DistinctListsDiffDispatcher INSTANCE = new androidx.paging.DistinctListsDiffDispatcher();

    private DistinctListsDiffDispatcher() {
    }

    private readonly void DispatchChange(androidx.recyclerview.widget.ListUpdateCallback callback, int startBoundary, int endBoundary, int start, int end, java.lang.object payload) {
        int i = startBoundary - start;
        if (i > 0) {
            callback.onChanged(start, i, payload);
        }
        int i2 = end - endBoundary;
        if (i2 <= 0) {
            return;
        }
        callback.onChanged(endBoundary, i2, payload);
    }

    public readonly <T> void DispatchDiff(androidx.recyclerview.widget.ListUpdateCallback callback, androidx.paging.PlaceholderPaddedList<T> oldList, androidx.paging.PlaceholderPaddedList<T> newList) {
        if ((27 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldList, "oldList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        int iMax = java.lang.Math.max(oldList.getPlaceholdersBefore(), newList.getPlaceholdersBefore());
        int iMin = java.lang.Math.min(oldList.getPlaceholdersBefore() + oldList.getDataCount(), newList.getPlaceholdersBefore() + newList.getDataCount());
        int i = iMin - iMax;
        if (i > 0) {
            callback.onRemoved(iMax, i);
            callback.onInserted(iMax, i);
        }
        int iMin2 = java.lang.Math.min(iMax, iMin);
        int iMax2 = java.lang.Math.max(iMax, iMin);
        dispatchChange(callback, iMin2, iMax2, kotlin.ranges.RangesKt.coerceAtMost(oldList.getPlaceholdersBefore(), newList.getSize()), kotlin.ranges.RangesKt.coerceAtMost(oldList.getPlaceholdersBefore() + oldList.getDataCount(), newList.getSize()), androidx.paging.DiffingChangePayload.ITEM_TO_PLACEHOLDER);
        dispatchChange(callback, iMin2, iMax2, kotlin.ranges.RangesKt.coerceAtMost(newList.getPlaceholdersBefore(), oldList.getSize()), kotlin.ranges.RangesKt.coerceAtMost(newList.getPlaceholdersBefore() + newList.getDataCount(), oldList.getSize()), androidx.paging.DiffingChangePayload.PLACEHOLDER_TO_ITEM);
        int size = newList.getSize() - oldList.getSize();
        if (size > 0) {
            callback.onInserted(oldList.getSize(), size);
        } else {
            if (size >= 0) {
                return;
            }
            callback.onRemoved(oldList.getSize() + size, -size);
        }
    }
}

