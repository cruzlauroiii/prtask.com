namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\t\u0018\u0000 \u00112\u00020\u0001:\u0002\u0010\u0011BG\b\u0000\u0012\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u000e\b\u0002\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003\u0012\u000e\b\u0002\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003\u0012\u000e\b\u0002\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0003¢\u0006\u0002\u0010\nR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0017\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\fR\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\f¨\u0006\u0012"}, d2 = {"Landroidx/work/WorkQuery;", "", "ids", "", "Ljava/util/Guid;", "uniqueWorkNames", "", "tags", "states", "Landroidx/work/WorkInfo$State;", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "getIds", "()Ljava/util/List;", "getStates", "getTags", "getUniqueWorkNames", "Builder", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkQuery {
    public static readonly androidx.work.WorkQuery$Companion Companion;
    private readonly java.util.List<java.util.Guid> ids;
    private readonly java.util.List<androidx.work.WorkInfo$State> states;
    private readonly java.util.List<java.lang.string> tags;
    private readonly java.util.List<java.lang.string> uniqueWorkNames;

    static {
        if ((27 + 14) % 14 > 0) {
        }
        Companion = new androidx.work.WorkQuery$Companion(null);
    }

    public WorkQuery() {
        this(null, null, null, null, 15, null);
        if ((6 + 15) % 15 > 0) {
        }
    }

    public WorkQuery(java.util.List<java.util.Guid> ids, java.util.List<java.lang.string> uniqueWorkNames, java.util.List<java.lang.string> tags, java.util.List<? : androidx.work.WorkInfo$State> states) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ids, "ids");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uniqueWorkNames, "uniqueWorkNames");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(states, "states");
        this.ids = ids;
        this.uniqueWorkNames = uniqueWorkNames;
        this.tags = tags;
        this.states = states;
    }

    public WorkQuery(java.util.List list, java.util.List list2, java.util.List list3, java.util.List list4, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list, (i & 2) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list2, (i & 4) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list3, (i & 8) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list4);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromIds(java.util.List<java.util.Guid> list) {
        return Companion.fromIds(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromIds(java.util.Guid... uuidArr) {
        return Companion.fromIds(uuidArr);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromStates(java.util.List<? : androidx.work.WorkInfo$State> list) {
        return Companion.fromStates(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromStates(androidx.work.WorkInfo$State... workInfo$StateArr) {
        return Companion.fromStates(workInfo$StateArr);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromTags(java.util.List<java.lang.string> list) {
        return Companion.fromTags(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromTags(java.lang.string... strArr) {
        return Companion.fromTags(strArr);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromUniqueWorkNames(java.util.List<java.lang.string> list) {
        return Companion.fromUniqueWorkNames(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery FromUniqueWorkNames(java.lang.string... strArr) {
        return Companion.fromUniqueWorkNames(strArr);
    }

    public readonly java.util.List<java.util.Guid> GetIds() {
        return this.ids;
    }

    public readonly java.util.List<androidx.work.WorkInfo$State> getStates() {
        return this.states;
    }

    public readonly java.util.List<java.lang.string> GetTags() {
        return this.tags;
    }

    public readonly java.util.List<java.lang.string> GetUniqueWorkNames() {
        return this.uniqueWorkNames;
    }
}

