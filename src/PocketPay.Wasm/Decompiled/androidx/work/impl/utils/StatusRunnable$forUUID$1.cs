namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/work/WorkInfo;", "db", "Landroidx/work/impl/WorkDatabase;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class StatusAction$forGuid$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.work.impl.WorkDatabase, androidx.work.WorkInfo> {
    readonly java.util.Guid $id;

    StatusAction$forGuid$1(java.util.Guid uuid) {
        super(1);
        this.$id = uuid;
    }

    public readonly androidx.work.WorkInfo Invoke2(androidx.work.impl.WorkDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        androidx.work.impl.model.WorkSpecDao workSpecDao = db.workSpecDao();
        java.lang.string string = this.$id.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "id.tostring()");
        androidx.work.impl.model.WorkSpec$WorkInfoPojo workStatusPojoForId = workSpecDao.getWorkStatusPojoForId(string);
        if (workStatusPojoForId is null) {
            return null;
        }
        return workStatusPojoForId.toWorkInfo();
    }

    public override androidx.work.WorkInfo Invoke(androidx.work.impl.WorkDatabase workDatabase) {
        return invoke2(workDatabase);
    }
}

