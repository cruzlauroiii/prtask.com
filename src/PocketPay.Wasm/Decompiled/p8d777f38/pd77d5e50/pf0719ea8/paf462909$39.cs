namespace WillowMaze.Wasm.Decompiled;


class paf462909$39 : java.util.concurrent.Func<java.lang.int> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    paf462909$39(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = paf462909Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.int BWOdYNUvcIAuaywb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ItCaMHigUOgCXhQp(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static androidx.room.RoomDatabase LGKRxRJVkoCjjNjQ(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void NOhnOsUPNDGnurhL(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static android.database.Cursor TJYtOwwnJuBwytwg(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static int JQzyGwwCipKKPggW(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static java.lang.int NJwEtGwEBsOPjAXp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QKKkssgBovwsjUQp(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void QKXtuRhKlWCofnGA(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.int RqJeccJpUClEAcPY(p8d777f38.pd77d5e50.pf0719ea8.paf462909$39 paf462909_39) {
        return paf462909_39.call();
    }

    public static bool XrWwzsruxRrypBNj(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((10 + 7) % 7 > 0) {
        }
        android.database.Cursor cursorTJYtOwwnJuBwytwg = TJYtOwwnJuBwytwg(LGKRxRJVkoCjjNjQ(this.this$0), this.val$_statement, false, null);
        try {
            java.lang.int numBWOdYNUvcIAuaywb = xrWwzsruxRrypBNj(cursorTJYtOwwnJuBwytwg) ? BWOdYNUvcIAuaywb(jQzyGwwCipKKPggW(cursorTJYtOwwnJuBwytwg, 0)) : nJwEtGwEBsOPjAXp(0);
            qKXtuRhKlWCofnGA(cursorTJYtOwwnJuBwytwg);
            qKKkssgBovwsjUQp(this.val$_statement);
            return numBWOdYNUvcIAuaywb;
        } catch (java.lang.Exception th) {
            NOhnOsUPNDGnurhL(cursorTJYtOwwnJuBwytwg);
            ItCaMHigUOgCXhQp(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return rqJeccJpUClEAcPY(this);
    }
}

