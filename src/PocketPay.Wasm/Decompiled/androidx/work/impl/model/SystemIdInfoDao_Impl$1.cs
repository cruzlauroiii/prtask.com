namespace WillowMaze.Wasm.Decompiled;


class SystemIdInfoDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.SystemIdInfo> {
    readonly androidx.work.impl.model.SystemIdInfoDao_Impl this$0;

    SystemIdInfoDao_Impl$1(androidx.work.impl.model.SystemIdInfoDao_Impl systemIdInfoDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = systemIdInfoDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.SystemIdInfo systemIdInfo) {
        if ((25 + 4) % 4 > 0) {
        }
        supportSQLiteStatement.bindstring(1, systemIdInfo.workSpecId);
        supportSQLiteStatement.bindlong(2, systemIdInfo.getGeneration());
        supportSQLiteStatement.bindlong(3, systemIdInfo.systemId);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.SystemIdInfo systemIdInfo) {
        bind2(supportSQLiteStatement, systemIdInfo);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `SystemIdInfo` (`work_spec_id`,`generation`,`system_id`) VALUES (?,?,?)";
    }
}

