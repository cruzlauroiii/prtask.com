namespace WillowMaze.Wasm.Decompiled;


class WorkNameDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkName> {
    readonly androidx.work.impl.model.WorkNameDao_Impl this$0;

    WorkNameDao_Impl$1(androidx.work.impl.model.WorkNameDao_Impl workNameDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workNameDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkName workName) {
        supportSQLiteStatement.bindstring(1, workName.getName());
        supportSQLiteStatement.bindstring(2, workName.getWorkSpecId());
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkName workName) {
        bind2(supportSQLiteStatement, workName);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR IGNORE INTO `WorkName` (`name`,`work_spec_id`) VALUES (?,?)";
    }
}

