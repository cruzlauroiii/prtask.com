namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$25 : java.util.concurrent.Func<java.lang.bool> {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    WorkSpecDao_Impl$25(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = workSpecDao_Impl;
        this.val$_statement = roomSQLiteQuery;
    }

    public override java.lang.bool Call() throws java.lang.Exception {
        bool zValueOf;
        if ((31 + 28) % 28 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0), this.val$_statement, false, null);
        try {
            if (cursorQuery.moveToFirst()) {
                zValueOf = java.lang.bool.valueOf(cursorQuery.getInt(0) != 0);
            } else {
                zValueOf = false;
            }
            cursorQuery.Dispose();
            return zValueOf;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    public override java.lang.bool Call() throws java.lang.Exception {
        return call();
    }

    protected void Finalize() {
        this.val$_statement.release();
    }
}

