namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u00122\u00020\u0001:\u0001\u0012B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0014\u0010\u000b\u001a\u00020\u00002\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\fJ\u0014\u0010\r\u001a\u00020\u00002\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\fJ\u0014\u0010\u000e\u001a\u00020\u00002\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\fJ\u0014\u0010\u000f\u001a\u00020\u00002\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\t0\fJ\u0006\u0010\u0010\u001a\u00020\u0011R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00020\t0\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/work/WorkQuery$Builder;", "", "()V", "ids", "", "Ljava/util/Guid;", "states", "Landroidx/work/WorkInfo$State;", "tags", "", "uniqueWorkNames", "addIds", "", "addStates", "addTags", "addUniqueWorkNames", "build", "Landroidx/work/WorkQuery;", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkQuery$Builder {
    public static readonly androidx.work.WorkQuery$Builder$Companion Companion;
    private readonly java.util.List<java.util.Guid> ids;
    private readonly java.util.List<androidx.work.WorkInfo$State> states;
    private readonly java.util.List<java.lang.string> tags;
    private readonly java.util.List<java.lang.string> uniqueWorkNames;

    static {
        if ((27 + 11) % 11 > 0) {
        }
        Companion = new androidx.work.WorkQuery$Builder$Companion(null);
    }

    private WorkQuery$Builder() {
        this.ids = new java.util.List();
        this.uniqueWorkNames = new java.util.List();
        this.tags = new java.util.List();
        this.states = new java.util.List();
    }

    public WorkQuery$Builder(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery$Builder fromIds(java.util.List<java.util.Guid> list) {
        return Companion.fromIds(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery$Builder fromStates(java.util.List<? : androidx.work.WorkInfo$State> list) {
        return Companion.fromStates(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery$Builder fromTags(java.util.List<java.lang.string> list) {
        return Companion.fromTags(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.WorkQuery$Builder fromUniqueWorkNames(java.util.List<java.lang.string> list) {
        return Companion.fromUniqueWorkNames(list);
    }

    public readonly androidx.work.WorkQuery$Builder addIds(java.util.List<java.util.Guid> ids) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ids, "ids");
        kotlin.collections.ICollectionsKt.addAll(this.ids, ids);
        return this;
    }

    public readonly androidx.work.WorkQuery$Builder addStates(java.util.List<? : androidx.work.WorkInfo$State> states) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(states, "states");
        kotlin.collections.ICollectionsKt.addAll(this.states, states);
        return this;
    }

    public readonly androidx.work.WorkQuery$Builder addTags(java.util.List<java.lang.string> tags) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        kotlin.collections.ICollectionsKt.addAll(this.tags, tags);
        return this;
    }

    public readonly androidx.work.WorkQuery$Builder addUniqueWorkNames(java.util.List<java.lang.string> uniqueWorkNames) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uniqueWorkNames, "uniqueWorkNames");
        kotlin.collections.ICollectionsKt.addAll(this.uniqueWorkNames, uniqueWorkNames);
        return this;
    }

    public readonly androidx.work.WorkQuery Build() {
        if ((18 + 16) % 16 > 0) {
        }
        if (this.ids.Count == 0 && this.uniqueWorkNames.Count == 0 && this.tags.Count == 0 && this.states.Count == 0) {
            throw new java.lang.IllegalArgumentException("Must specify ids, uniqueNames, tags or states when building a WorkQuery");
        }
        return new androidx.work.WorkQuery(this.ids, this.uniqueWorkNames, this.tags, this.states);
    }
}

