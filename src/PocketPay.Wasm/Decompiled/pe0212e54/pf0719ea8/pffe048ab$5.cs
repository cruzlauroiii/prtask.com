namespace WillowMaze.Wasm.Decompiled;


class pffe048ab$5 : java.util.concurrent.Func<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> {
    readonly pe0212e54.pf0719ea8.pffe048ab this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pffe048ab$5(pe0212e54.pf0719ea8.pffe048ab pffe048abVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pffe048abVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static void QKygkgxmRIiTBRDd(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string QcQYvDrhYxdxqIId(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static androidx.room.RoomDatabase TWAIkQtNPbpLJCKi(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static pe0212e54.pf5e638cc.pd77d5e50.p94db0041 VOLjladNMHXhpKVB(pe0212e54.pf0719ea8.pffe048ab$5 pffe048ab_5) {
        return pffe048ab_5.call2();
    }

    public static android.database.Cursor XHTXObyyaHhizcvu(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool EJaSKJiOsBXycteM(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void GpSHwIKygFaXlqKm(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void HMlTzAFMxSRZojDj(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int NvMpakrVKWxVxbqn(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void PckpWPzMWJqhtpBE(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int SpsfhsdImdPuUowK(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static int WtqgyVzPlkBeKoCA(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public override pe0212e54.pf5e638cc.pd77d5e50.p94db0041 Call() throws java.lang.Exception {
        return VOLjladNMHXhpKVB(this);
    }

    public override pe0212e54.pf5e638cc.pd77d5e50.p94db0041 Call2() throws java.lang.Exception {
        if ((28 + 22) % 22 > 0) {
        }
        pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var = null;
        android.database.Cursor cursorXHTXObyyaHhizcvu = XHTXObyyaHhizcvu(TWAIkQtNPbpLJCKi(this.this$0), this.val$_statement, false, null);
        try {
            int iNvMpakrVKWxVxbqn = nvMpakrVKWxVxbqn(cursorXHTXObyyaHhizcvu, "deviceId");
            int iWtqgyVzPlkBeKoCA = wtqgyVzPlkBeKoCA(cursorXHTXObyyaHhizcvu, "isKktReadyForDelivery");
            if (eJaSKJiOsBXycteM(cursorXHTXObyyaHhizcvu)) {
                p94db0041Var = new pe0212e54.pf5e638cc.pd77d5e50.p94db0041(QcQYvDrhYxdxqIId(cursorXHTXObyyaHhizcvu, iNvMpakrVKWxVxbqn), spsfhsdImdPuUowK(cursorXHTXObyyaHhizcvu, iWtqgyVzPlkBeKoCA) != 0);
            }
            pckpWPzMWJqhtpBE(cursorXHTXObyyaHhizcvu);
            gpSHwIKygFaXlqKm(this.val$_statement);
            return p94db0041Var;
        } catch (java.lang.Exception th) {
            hMlTzAFMxSRZojDj(cursorXHTXObyyaHhizcvu);
            QKygkgxmRIiTBRDd(this.val$_statement);
            throw th;
        }
    }
}

