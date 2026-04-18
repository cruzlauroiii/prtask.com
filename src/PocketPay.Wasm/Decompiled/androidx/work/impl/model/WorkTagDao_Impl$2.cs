namespace WillowMaze.Wasm.Decompiled;


class WorkTagDao_Impl$2 : androidx.room.SharedSQLiteStatement {
    readonly androidx.work.impl.model.WorkTagDao_Impl this$0;

    WorkTagDao_Impl$2(androidx.work.impl.model.WorkTagDao_Impl workTagDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workTagDao_Impl;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM worktag WHERE work_spec_id=?";
    }
}

