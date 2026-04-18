namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "Landroidx/work/WorkInfo;", "db", "Landroidx/work/impl/WorkDatabase;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class StatusAction$forTag$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.work.impl.WorkDatabase, java.util.List<? : androidx.work.WorkInfo>> {
    readonly java.lang.string $tag;

    StatusAction$forTag$1(java.lang.string str) {
        super(1);
        this.$tag = str;
    }

    public java.util.List<? : androidx.work.WorkInfo> invoke(androidx.work.impl.WorkDatabase workDatabase) {
        return invoke2(workDatabase);
    }

    public override readonly java.util.List<androidx.work.WorkInfo> Invoke2(androidx.work.impl.WorkDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        java.util.List<androidx.work.WorkInfo> listApply = androidx.work.impl.model.WorkSpec.WORK_INFO_MAPPER.apply(db.workSpecDao().getWorkStatusPojoForTag(this.$tag));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listApply, "WORK_INFO_MAPPER.apply(d…orkStatusPojoForTag(tag))");
        return listApply;
    }
}

