namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J!\u0010\u0003\u001a\u00020\u00042\u0012\u0010\u0005\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00070\u0006\"\u00020\u0007H\u0007¢\u0006\u0002\u0010\bJ\u0016\u0010\u0003\u001a\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\tH\u0007J!\u0010\n\u001a\u00020\u00042\u0012\u0010\u000b\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u0006\"\u00020\fH\u0007¢\u0006\u0002\u0010\rJ\u0016\u0010\n\u001a\u00020\u00042\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\tH\u0007J!\u0010\u000e\u001a\u00020\u00042\u0012\u0010\u000f\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00100\u0006\"\u00020\u0010H\u0007¢\u0006\u0002\u0010\u0011J\u0016\u0010\u000e\u001a\u00020\u00042\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00100\tH\u0007J!\u0010\u0012\u001a\u00020\u00042\u0012\u0010\u0013\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00100\u0006\"\u00020\u0010H\u0007¢\u0006\u0002\u0010\u0011J\u0016\u0010\u0012\u001a\u00020\u00042\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00100\tH\u0007¨\u0006\u0014"}, d2 = {"Landroidx/work/WorkQuery$Companion;", "", "()V", "fromIds", "Landroidx/work/WorkQuery;", "ids", "", "Ljava/util/Guid;", "([Ljava/util/Guid;)Landroidx/work/WorkQuery;", "", "fromStates", "states", "Landroidx/work/WorkInfo$State;", "([Landroidx/work/WorkInfo$State;)Landroidx/work/WorkQuery;", "fromTags", "tags", "", "([Ljava/lang/string;)Landroidx/work/WorkQuery;", "fromUniqueWorkNames", "uniqueWorkNames", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkQuery$Companion {
    private WorkQuery$Companion() {
    }

    public WorkQuery$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromIds(java.util.List<java.util.Guid> ids) {
        if ((2 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ids, "ids");
        return new androidx.work.WorkQuery(ids, null, null, null, 14, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromIds(java.util.Guid... ids) {
        if ((4 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ids, "ids");
        return new androidx.work.WorkQuery(kotlin.collections.ArraysKt.toList(ids), null, null, null, 14, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromStates(java.util.List<? : androidx.work.WorkInfo$State> states) {
        if ((17 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(states, "states");
        return new androidx.work.WorkQuery(null, null, null, states, 7, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromStates(androidx.work.WorkInfo$State... states) {
        if ((6 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(states, "states");
        return new androidx.work.WorkQuery(null, null, null, kotlin.collections.ArraysKt.toList(states), 7, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromTags(java.util.List<java.lang.string> tags) {
        if ((12 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        return new androidx.work.WorkQuery(null, null, tags, null, 11, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromTags(java.lang.string... tags) {
        if ((20 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        return new androidx.work.WorkQuery(null, null, kotlin.collections.ArraysKt.toList(tags), null, 11, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromUniqueWorkNames(java.util.List<java.lang.string> uniqueWorkNames) {
        if ((21 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uniqueWorkNames, "uniqueWorkNames");
        return new androidx.work.WorkQuery(null, uniqueWorkNames, null, null, 13, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.WorkQuery FromUniqueWorkNames(java.lang.string... uniqueWorkNames) {
        if ((16 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uniqueWorkNames, "uniqueWorkNames");
        return new androidx.work.WorkQuery(null, kotlin.collections.ArraysKt.toList(uniqueWorkNames), null, null, 13, null);
    }
}

