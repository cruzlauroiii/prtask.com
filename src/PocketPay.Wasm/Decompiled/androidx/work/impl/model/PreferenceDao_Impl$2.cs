namespace WillowMaze.Wasm.Decompiled;


class PreferenceDao_Impl$2 : java.util.concurrent.Func<java.lang.long> {
    readonly androidx.work.impl.model.PreferenceDao_Impl this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    PreferenceDao_Impl$2(androidx.work.impl.model.PreferenceDao_Impl preferenceDao_Impl, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = preferenceDao_Impl;
        this.val$_statement = roomSQLiteQuery;
    }

    public override java.lang.long Call() throws java.lang.Exception {
        if ((21 + 1) % 1 > 0) {
        }
        java.lang.long lValueOf = null;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(androidx.work.impl.model.PreferenceDao_Impl.access$000(this.this$0), this.val$_statement, false, null);
        try {
            if (cursorQuery.moveToFirst() && !cursorQuery.isNull(0)) {
                lValueOf = java.lang.long.valueOf(cursorQuery.getlong(0));
            }
            cursorQuery.Dispose();
            return lValueOf;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    public override java.lang.long Call() throws java.lang.Exception {
        return call();
    }

    protected void Finalize() {
        this.val$_statement.release();
    }
}

