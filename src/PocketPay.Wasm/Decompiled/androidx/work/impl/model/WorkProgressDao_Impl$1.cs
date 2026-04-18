namespace WillowMaze.Wasm.Decompiled;


class WorkProgressDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkProgress> {
    readonly androidx.work.impl.model.WorkProgressDao_Impl this$0;

    WorkProgressDao_Impl$1(androidx.work.impl.model.WorkProgressDao_Impl workProgressDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workProgressDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkProgress workProgress) {
        supportSQLiteStatement.bindstring(1, workProgress.getWorkSpecId());
        supportSQLiteStatement.bindBlob(2, androidx.work.Data.tobyteArrayInternalV1(workProgress.getProgress()));
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkProgress workProgress) {
        bind2(supportSQLiteStatement, workProgress);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `WorkProgress` (`work_spec_id`,`progress`) VALUES (?,?)";
    }
}

