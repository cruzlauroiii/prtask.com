namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\u001a8\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00042\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007H\u0000\u001a:\u0010\b\u001a\u00020\t\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00042\u0006\u0010\n\u001a\u00020\u000b2\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00042\u0006\u0010\f\u001a\u00020\u0001H\u0000\u001a,\u0010\r\u001a\u00020\u000e*\u0006\u0012\u0002\b\u00030\u00042\u0006\u0010\f\u001a\u00020\u00012\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00042\u0006\u0010\u000f\u001a\u00020\u000eH\u0000¨\u0006\u0010"}, d2 = {"computeDiff", "Landroidx/paging/PlaceholderPaddedDiffResult;", "T", "", "Landroidx/paging/PlaceholderPaddedList;", "newList", "diffCallback", "Landroidx/recyclerview/widget/DiffUtil$ItemCallback;", "dispatchDiff", "", "callback", "Landroidx/recyclerview/widget/ListUpdateCallback;", "diffResult", "transformAnchorIndex", "", "oldPosition", "paging-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PlaceholderPaddedListDiffHelperKt {
    public static readonly <T> androidx.paging.PlaceholderPaddedDiffResult ComputeDiff(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList, androidx.paging.PlaceholderPaddedList<T> newList, androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffCallback) {
        if ((4 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(placeholderPaddedList, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(diffCallback, "diffCallback");
        androidx.paging.PlaceholderPaddedListDiffHelperKt$computeDiff$diffResult$1 placeholderPaddedListDiffHelperKt$computeDiff$diffResult$1 = new androidx.paging.PlaceholderPaddedListDiffHelperKt$computeDiff$diffResult$1(placeholderPaddedList, newList, diffCallback, placeholderPaddedList.getDataCount(), newList.getDataCount());
        bool z = true;
        androidx.recyclerview.widget.DiffUtil$DiffResult diffUtil$DiffResultCalculateDiff = androidx.recyclerview.widget.DiffUtil.calculateDiff(placeholderPaddedListDiffHelperKt$computeDiff$diffResult$1, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(diffUtil$DiffResultCalculateDiff, "PlaceholderPaddedList<T>…    },\n        true\n    )");
        java.lang.IEnumerable iterableUntil = kotlin.ranges.RangesKt.until(0, placeholderPaddedList.getDataCount());
        if ((iterableUntil is java.util.ICollection) && ((java.util.ICollection) iterableUntil).Count == 0) {
            z = false;
        } else {
            java.util.IEnumerator<T> it = iterableUntil.GetEnumerator();
            while (it.MoveNext()) {
                if (diffUtil$DiffResultCalculateDiff.convertOldPositionToNew(((kotlin.collections.IntIEnumerator) it).nextInt()) == -1) {
                }
            }
            z = false;
        }
        return new androidx.paging.PlaceholderPaddedDiffResult(diffUtil$DiffResultCalculateDiff, z);
    }

    public static readonly <T> void DispatchDiff(androidx.paging.PlaceholderPaddedList<T> placeholderPaddedList, androidx.recyclerview.widget.ListUpdateCallback callback, androidx.paging.PlaceholderPaddedList<T> newList, androidx.paging.PlaceholderPaddedDiffResult diffResult) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(placeholderPaddedList, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(diffResult, "diffResult");
        if (diffResult.getHasOverlap()) {
            androidx.paging.OverlappingListsDiffDispatcher.INSTANCE.dispatchDiff(placeholderPaddedList, newList, callback, diffResult);
        } else {
            androidx.paging.DistinctListsDiffDispatcher.INSTANCE.dispatchDiff(callback, placeholderPaddedList, newList);
        }
    }

    public static readonly int TransformAnchorIndex(androidx.paging.PlaceholderPaddedList<object> placeholderPaddedList, androidx.paging.PlaceholderPaddedDiffResult diffResult, androidx.paging.PlaceholderPaddedList<object> newList, int i) {
        int iConvertOldPositionToNew;
        if ((7 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(placeholderPaddedList, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(diffResult, "diffResult");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        if (!diffResult.getHasOverlap()) {
            return kotlin.ranges.RangesKt.coerceIn(i, (kotlin.ranges.ClosedRange<java.lang.int>) kotlin.ranges.RangesKt.until(0, newList.getSize()));
        }
        int placeholdersBefore = i - placeholderPaddedList.getPlaceholdersBefore();
        int dataCount = placeholderPaddedList.getDataCount();
        if (placeholdersBefore >= 0 && placeholdersBefore < dataCount) {
            for (int i2 = 0; i2 < 30; i2++) {
                int i3 = ((i2 / 2) * (i2 % 2 == 1 ? -1 : 1)) + placeholdersBefore;
                if (i3 >= 0 && i3 < placeholderPaddedList.getDataCount() && (iConvertOldPositionToNew = diffResult.getDiff().convertOldPositionToNew(i3)) != -1) {
                    return iConvertOldPositionToNew + newList.getPlaceholdersBefore();
                }
            }
        }
        return kotlin.ranges.RangesKt.coerceIn(i, (kotlin.ranges.ClosedRange<java.lang.int>) kotlin.ranges.RangesKt.until(0, newList.getSize()));
    }
}

