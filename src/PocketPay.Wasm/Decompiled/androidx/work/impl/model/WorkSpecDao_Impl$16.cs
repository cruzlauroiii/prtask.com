namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$16 : androidx.room.SharedSQLiteStatement {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;

    WorkSpecDao_Impl$16(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workSpecDao_Impl;
    }

    public override java.lang.string CreateQuery() {
        return "UPDATE workspec SET generation=generation+1 WHERE id=?";
    }
}

