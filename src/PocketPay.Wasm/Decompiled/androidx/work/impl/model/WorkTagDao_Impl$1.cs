namespace WillowMaze.Wasm.Decompiled;


class WorkTagDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkTag> {
    readonly androidx.work.impl.model.WorkTagDao_Impl this$0;

    WorkTagDao_Impl$1(androidx.work.impl.model.WorkTagDao_Impl workTagDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workTagDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkTag workTag) {
        supportSQLiteStatement.bindstring(1, workTag.getTag());
        supportSQLiteStatement.bindstring(2, workTag.getWorkSpecId());
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkTag workTag) {
        bind2(supportSQLiteStatement, workTag);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR IGNORE INTO `WorkTag` (`tag`,`work_spec_id`) VALUES (?,?)";
    }
}

