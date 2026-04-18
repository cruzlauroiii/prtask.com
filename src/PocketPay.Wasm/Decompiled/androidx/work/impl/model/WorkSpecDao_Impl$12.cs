namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$12 : androidx.room.SharedSQLiteStatement {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;

    WorkSpecDao_Impl$12(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workSpecDao_Impl;
    }

    public override java.lang.string CreateQuery() {
        return "UPDATE workspec SET next_schedule_time_override=9223372036854775807 WHERE (id=? AND next_schedule_time_override_generation=?)";
    }
}

