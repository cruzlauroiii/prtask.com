namespace WillowMaze.Wasm.Decompiled;


class paf462909$29 : java.util.concurrent.Func<java.lang.int> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    paf462909$29(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = paf462909Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.int CLvGlKbsxkJlQFxI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int CUJnnQMHqXlnXlfC(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static android.database.Cursor GdIvzuBvyuCfZPpi(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static void LyLZUYbQgGkVaFHQ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool PfNDDLhdjjAOwpOm(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void VJOwpHgFtIgOBVsV(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void AlioaYzeWyrtAlbE(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void QKHydPuhuQdCjtWB(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.int QUriNZoRzqaZxgEC(p8d777f38.pd77d5e50.pf0719ea8.paf462909$29 paf462909_29) {
        return paf462909_29.call();
    }

    public static bool RbSikEmjfCVJIxOz(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static androidx.room.RoomDatabase WapSiAElqaEOLAlx(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((22 + 16) % 16 > 0) {
        }
        java.lang.int numCLvGlKbsxkJlQFxI = null;
        android.database.Cursor cursorGdIvzuBvyuCfZPpi = GdIvzuBvyuCfZPpi(wapSiAElqaEOLAlx(this.this$0), this.val$_statement, false, null);
        try {
            if (PfNDDLhdjjAOwpOm(cursorGdIvzuBvyuCfZPpi) && !rbSikEmjfCVJIxOz(cursorGdIvzuBvyuCfZPpi, 0)) {
                numCLvGlKbsxkJlQFxI = CLvGlKbsxkJlQFxI(CUJnnQMHqXlnXlfC(cursorGdIvzuBvyuCfZPpi, 0));
            }
            LyLZUYbQgGkVaFHQ(cursorGdIvzuBvyuCfZPpi);
            alioaYzeWyrtAlbE(this.val$_statement);
            return numCLvGlKbsxkJlQFxI;
        } catch (java.lang.Exception th) {
            VJOwpHgFtIgOBVsV(cursorGdIvzuBvyuCfZPpi);
            qKHydPuhuQdCjtWB(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return qUriNZoRzqaZxgEC(this);
    }
}

