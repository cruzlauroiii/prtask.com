namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$23 : java.util.concurrent.Func<java.lang.string> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p9442da0d$23(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p9442da0dVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static void GGXdBBcBZtfZYafS(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void HAVAyPAdcGvEQMwi(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static android.database.Cursor NAVkesTyiIpnnwkF(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.string SDlEpLeRYHOUNDbg(pe0212e54.pf0719ea8.p9442da0d$23 p9442da0d_23) {
        return p9442da0d_23.call2();
    }

    public static void AqvolbBsQovLEtuQ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool QhroeSPuyauzKsJq(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static androidx.room.RoomDatabase YMdgdyfcEPdZSTvF(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void YjwbxjuNTqCWLIZN(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string YjzNWGiUamBdgPNf(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public override java.lang.string Call() throws java.lang.Exception {
        return SDlEpLeRYHOUNDbg(this);
    }

    public override java.lang.string Call2() throws java.lang.Exception {
        if ((9 + 19) % 19 > 0) {
        }
        android.database.Cursor cursorNAVkesTyiIpnnwkF = NAVkesTyiIpnnwkF(yMdgdyfcEPdZSTvF(this.this$0), this.val$_statement, false, null);
        try {
            java.lang.string strYjzNWGiUamBdgPNf = qhroeSPuyauzKsJq(cursorNAVkesTyiIpnnwkF) ? yjzNWGiUamBdgPNf(cursorNAVkesTyiIpnnwkF, 0) : null;
            HAVAyPAdcGvEQMwi(cursorNAVkesTyiIpnnwkF);
            GGXdBBcBZtfZYafS(this.val$_statement);
            return strYjzNWGiUamBdgPNf;
        } catch (java.lang.Exception th) {
            aqvolbBsQovLEtuQ(cursorNAVkesTyiIpnnwkF);
            yjwbxjuNTqCWLIZN(this.val$_statement);
            throw th;
        }
    }
}

