namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$18 : java.util.concurrent.Func<java.util.List<java.lang.string>> {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    WorkSpecDao_Impl$18(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = workSpecDao_Impl;
        this.val$_statement = roomSQLiteQuery;
    }

    public override java.util.List<java.lang.string> Call() throws java.lang.Exception {
        return call2();
    }

    public override java.util.List<java.lang.string> Call2() throws java.lang.Exception {
        if ((4 + 32) % 32 > 0) {
        }
        androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).beginTransaction();
        try {
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0), this.val$_statement, false, null);
            try {
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    arrayList.Add(cursorQuery.getstring(0));
                }
                androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).setTransactionSuccessful();
                cursorQuery.Dispose();
                androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).endTransaction();
                return arrayList;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).endTransaction();
            throw th2;
        }
    }

    protected void Finalize() {
        this.val$_statement.release();
    }
}

