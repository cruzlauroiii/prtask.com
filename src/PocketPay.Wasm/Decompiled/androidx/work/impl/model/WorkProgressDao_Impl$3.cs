namespace WillowMaze.Wasm.Decompiled;


class WorkProgressDao_Impl$3 : androidx.room.SharedSQLiteStatement {
    readonly androidx.work.impl.model.WorkProgressDao_Impl this$0;

    WorkProgressDao_Impl$3(androidx.work.impl.model.WorkProgressDao_Impl workProgressDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workProgressDao_Impl;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM WorkProgress";
    }
}

