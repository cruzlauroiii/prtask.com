namespace WillowMaze.Wasm.Decompiled;


class SystemIdInfoDao_Impl$3 : androidx.room.SharedSQLiteStatement {
    readonly androidx.work.impl.model.SystemIdInfoDao_Impl this$0;

    SystemIdInfoDao_Impl$3(androidx.work.impl.model.SystemIdInfoDao_Impl systemIdInfoDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = systemIdInfoDao_Impl;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM SystemIdInfo where work_spec_id=?";
    }
}

