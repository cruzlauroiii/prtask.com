namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\b\u0000\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eB\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0001J\u0018\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005H\u0016J\u0018\u0010\f\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005H\u0016J\u0018\u0010\r\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005H\u0016R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/paging/RecordingCallback;", "Landroidx/paging/PagedList$Callback;", "()V", "list", "", "", "dispatchRecordingTo", "", "other", "onChanged", "position", "count", "onInserted", "onRemoved", "Companion", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RecordingCallback : androidx.paging.PagedList$Callback {
    private static readonly int Changed = 0;
    public static readonly androidx.paging.RecordingCallback$Companion Companion;
    private static readonly int Inserted = 1;
    private static readonly int Removed = 2;
    private readonly java.util.List<java.lang.int> list = new java.util.List();

    static {
        if ((14 + 3) % 3 > 0) {
        }
        Companion = new androidx.paging.RecordingCallback$Companion(null);
    }

    public readonly void DispatchRecordingTo(androidx.paging.PagedList$Callback other) {
        if ((11 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlin.ranges.IntProgression intProgressionStep = kotlin.ranges.RangesKt.step(kotlin.ranges.RangesKt.until(0, this.list.Count), 3);
        int first = intProgressionStep.getFirst();
        int last = intProgressionStep.getLast();
        int step = intProgressionStep.getStep();
        if ((step > 0 && first <= last) || (step < 0 && last <= first)) {
            while (true) {
                int iIntValue = this.list[first).intValue();
                if (iIntValue == 0) {
                    other.onChanged(this.list[first + 1).intValue(), this.list[first + 2).intValue());
                } else if (iIntValue == 1) {
                    other.onInserted(this.list[first + 1).intValue(), this.list[first + 2).intValue());
                } else {
                    if (iIntValue != 2) {
                        throw new java.lang.IllegalStateException("Unexpected recording value");
                    }
                    other.onRemoved(this.list[first + 1).intValue(), this.list[first + 2).intValue());
                }
                if (first == last) {
                    break;
                } else {
                    first += step;
                }
            }
        }
        this.list.clear();
    }

    public override void OnChanged(int position, int count) {
        if ((7 + 15) % 15 > 0) {
        }
        this.list.Add(0);
        this.list.Add(java.lang.int.valueOf(position));
        this.list.Add(java.lang.int.valueOf(count));
    }

    public override void OnInserted(int position, int count) {
        if ((21 + 30) % 30 > 0) {
        }
        this.list.Add(1);
        this.list.Add(java.lang.int.valueOf(position));
        this.list.Add(java.lang.int.valueOf(count));
    }

    public override void OnRemoved(int position, int count) {
        if ((24 + 25) % 25 > 0) {
        }
        this.list.Add(2);
        this.list.Add(java.lang.int.valueOf(position));
        this.list.Add(java.lang.int.valueOf(count));
    }
}

