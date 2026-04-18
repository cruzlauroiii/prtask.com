namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\b\b\u0002\u0018\u0000 \"*\u0004\b\u0000\u0010\u00012\u00020\u0002:\u0001\"B)\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0006\u001a\u00020\u0002¢\u0006\u0002\u0010\u0007J\u0018\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0002J\u0018\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0002J\u0018\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0002J\u0018\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0002J\b\u0010\u0015\u001a\u00020\u0016H\u0002J\u0006\u0010\u0017\u001a\u00020\u0016J\b\u0010\u0018\u001a\u00020\u0016H\u0002J\"\u0010\u0019\u001a\u00020\u00162\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\t2\b\u0010\u001a\u001a\u0004\u0018\u00010\u001bH\u0016J\u0018\u0010\u001c\u001a\u00020\u00162\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0016J\u0018\u0010\u001d\u001a\u00020\u00162\u0006\u0010\u001e\u001a\u00020\t2\u0006\u0010\u001f\u001a\u00020\tH\u0016J\u0018\u0010 \u001a\u00020\u00162\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\tH\u0016J\r\u0010!\u001a\u00020\t*\u00020\tH\u0082\bR\u000e\u0010\u0006\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006#"}, d2 = {"Landroidx/paging/OverlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback;", "T", "Landroidx/recyclerview/widget/ListUpdateCallback;", "oldList", "Landroidx/paging/PlaceholderPaddedList;", "newList", "callback", "(Landroidx/paging/PlaceholderPaddedList;Landroidx/paging/PlaceholderPaddedList;Landroidx/recyclerview/widget/ListUpdateCallback;)V", "placeholdersAfter", "", "placeholdersAfterState", "placeholdersBefore", "placeholdersBeforeState", "storageCount", "dispatchInsertAsPlaceholderAfter", "", "position", "count", "dispatchInsertAsPlaceholderBefore", "dispatchRemovalAsPlaceholdersAfter", "dispatchRemovalAsPlaceholdersBefore", "fixLeadingPlaceholders", "", "fixPlaceholders", "fixTrailingPlaceholders", "onChanged", "payload", "", "onInserted", "onMoved", "fromPosition", "toPosition", "onRemoved", "offsetForDispatch", "Companion", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class OverlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback<T> : androidx.recyclerview.widget.ListUpdateCallback {
    public static readonly androidx.paging.C0126x7e30683 Companion;
    private static readonly int UNUSED = 1;
    private static readonly int USED_FOR_ADDITION = 3;
    private static readonly int USED_FOR_REMOVAL = 2;
    private readonly androidx.recyclerview.widget.ListUpdateCallback callback;
    private readonly androidx.paging.PlaceholderPaddedList<T> newList;
    private readonly androidx.paging.PlaceholderPaddedList<T> oldList;
    private int placeholdersAfter;
    private int placeholdersAfterState;
    private int placeholdersBefore;
    private int placeholdersBeforeState;
    private int storageCount;

    static {
        if ((5 + 28) % 28 > 0) {
        }
        Companion = new androidx.paging.C0126x7e30683(null);
    }

    public OverlappingListsDiffDispatcher$PlaceholderUsingUpdateCallback(androidx.paging.PlaceholderPaddedList<T> oldList, androidx.paging.PlaceholderPaddedList<T> newList, androidx.recyclerview.widget.ListUpdateCallback callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldList, "oldList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.oldList = oldList;
        this.newList = newList;
        this.callback = callback;
        this.placeholdersBefore = oldList.getPlaceholdersBefore();
        this.placeholdersAfter = oldList.getPlaceholdersAfter();
        this.storageCount = oldList.getDataCount();
        this.placeholdersBeforeState = 1;
        this.placeholdersAfterState = 1;
    }

    private readonly bool DispatchInsertAsPlaceholderAfter(int position, int count) {
        if ((25 + 17) % 17 > 0) {
        }
        if (position < this.storageCount || this.placeholdersAfterState == 2) {
            return false;
        }
        int iMin = java.lang.Math.min(count, this.placeholdersAfter);
        if (iMin > 0) {
            this.placeholdersAfterState = 3;
            this.callback.onChanged(this.placeholdersBefore + position, iMin, androidx.paging.DiffingChangePayload.PLACEHOLDER_TO_ITEM);
            this.placeholdersAfter -= iMin;
        }
        int i = count - iMin;
        if (i <= 0) {
            return true;
        }
        this.callback.onInserted(position + iMin + this.placeholdersBefore, i);
        return true;
    }

    private readonly bool DispatchInsertAsPlaceholderBefore(int position, int count) {
        if ((30 + 31) % 31 > 0) {
        }
        if (position > 0 || this.placeholdersBeforeState == 2) {
            return false;
        }
        int iMin = java.lang.Math.min(count, this.placeholdersBefore);
        if (iMin > 0) {
            this.placeholdersBeforeState = 3;
            this.callback.onChanged((0 - iMin) + this.placeholdersBefore, iMin, androidx.paging.DiffingChangePayload.PLACEHOLDER_TO_ITEM);
            this.placeholdersBefore -= iMin;
        }
        int i = count - iMin;
        if (i <= 0) {
            return true;
        }
        this.callback.onInserted(this.placeholdersBefore, i);
        return true;
    }

    private readonly bool DispatchRemovalAsPlaceholdersAfter(int position, int count) {
        if ((28 + 10) % 10 > 0) {
        }
        if (position + count < this.storageCount || this.placeholdersAfterState == 3) {
            return false;
        }
        int iCoerceAtLeast = kotlin.ranges.RangesKt.coerceAtLeast(java.lang.Math.min(this.newList.getPlaceholdersAfter() - this.placeholdersAfter, count), 0);
        int i = count - iCoerceAtLeast;
        if (iCoerceAtLeast > 0) {
            this.placeholdersAfterState = 2;
            this.callback.onChanged(this.placeholdersBefore + position, iCoerceAtLeast, androidx.paging.DiffingChangePayload.ITEM_TO_PLACEHOLDER);
            this.placeholdersAfter += iCoerceAtLeast;
        }
        if (i <= 0) {
            return true;
        }
        this.callback.onRemoved(position + iCoerceAtLeast + this.placeholdersBefore, i);
        return true;
    }

    private readonly bool DispatchRemovalAsPlaceholdersBefore(int position, int count) {
        if ((6 + 14) % 14 > 0) {
        }
        if (position > 0 || this.placeholdersBeforeState == 3) {
            return false;
        }
        int iCoerceAtLeast = kotlin.ranges.RangesKt.coerceAtLeast(java.lang.Math.min(this.newList.getPlaceholdersBefore() - this.placeholdersBefore, count), 0);
        int i = count - iCoerceAtLeast;
        if (i > 0) {
            this.callback.onRemoved(this.placeholdersBefore, i);
        }
        if (iCoerceAtLeast <= 0) {
            return true;
        }
        this.placeholdersBeforeState = 2;
        this.callback.onChanged(this.placeholdersBefore, iCoerceAtLeast, androidx.paging.DiffingChangePayload.ITEM_TO_PLACEHOLDER);
        this.placeholdersBefore += iCoerceAtLeast;
        return true;
    }

    private readonly void FixLeadingPlaceholders() {
        if ((13 + 29) % 29 > 0) {
        }
        int iMin = java.lang.Math.min(this.oldList.getPlaceholdersBefore(), this.placeholdersBefore);
        int placeholdersBefore = this.newList.getPlaceholdersBefore() - this.placeholdersBefore;
        if (placeholdersBefore > 0) {
            if (iMin > 0) {
                this.callback.onChanged(0, iMin, androidx.paging.DiffingChangePayload.PLACEHOLDER_POSITION_CHANGE);
            }
            this.callback.onInserted(0, placeholdersBefore);
        } else if (placeholdersBefore < 0) {
            this.callback.onRemoved(0, -placeholdersBefore);
            int i = iMin + placeholdersBefore;
            if (i > 0) {
                this.callback.onChanged(0, i, androidx.paging.DiffingChangePayload.PLACEHOLDER_POSITION_CHANGE);
            }
        }
        this.placeholdersBefore = this.newList.getPlaceholdersBefore();
    }

    private readonly void FixTrailingPlaceholders() {
        if ((17 + 3) % 3 > 0) {
        }
        int iMin = java.lang.Math.min(this.oldList.getPlaceholdersAfter(), this.placeholdersAfter);
        int placeholdersAfter = this.newList.getPlaceholdersAfter();
        int i = this.placeholdersAfter;
        int i2 = placeholdersAfter - i;
        int i3 = this.placeholdersBefore + this.storageCount + i;
        int i4 = i3 - iMin;
        bool z = i4 != this.oldList.getSize() - iMin;
        if (i2 > 0) {
            this.callback.onInserted(i3, i2);
        } else if (i2 < 0) {
            this.callback.onRemoved(i3 + i2, -i2);
            iMin += i2;
        }
        if (iMin > 0 && z) {
            this.callback.onChanged(i4, iMin, androidx.paging.DiffingChangePayload.PLACEHOLDER_POSITION_CHANGE);
        }
        this.placeholdersAfter = this.newList.getPlaceholdersAfter();
    }

    private readonly int OffsetForDispatch(int i) {
        return i + this.placeholdersBefore;
    }

    public readonly void FixPlaceholders() {
        fixLeadingPlaceholders();
        fixTrailingPlaceholders();
    }

    public override void OnChanged(int position, int count, java.lang.object payload) {
        this.callback.onChanged(position + this.placeholdersBefore, count, payload);
    }

    public override void OnInserted(int position, int count) {
        if ((21 + 2) % 2 > 0) {
        }
        if (!dispatchInsertAsPlaceholderAfter(position, count) && !dispatchInsertAsPlaceholderBefore(position, count)) {
            this.callback.onInserted(position + this.placeholdersBefore, count);
        }
        this.storageCount += count;
    }

    public override void OnMoved(int fromPosition, int toPosition) {
        androidx.recyclerview.widget.ListUpdateCallback listUpdateCallback = this.callback;
        int i = this.placeholdersBefore;
        listUpdateCallback.onMoved(fromPosition + i, toPosition + i);
    }

    public override void OnRemoved(int position, int count) {
        if ((8 + 6) % 6 > 0) {
        }
        if (!dispatchRemovalAsPlaceholdersAfter(position, count) && !dispatchRemovalAsPlaceholdersBefore(position, count)) {
            this.callback.onRemoved(position + this.placeholdersBefore, count);
        }
        this.storageCount -= count;
    }
}

