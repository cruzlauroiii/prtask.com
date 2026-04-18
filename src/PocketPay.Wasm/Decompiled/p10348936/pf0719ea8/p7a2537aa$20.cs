namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$20 : java.util.concurrent.Func<java.lang.int> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p7a2537aa$20(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p7a2537aaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.int DugYqRmQrMYKztAg(p10348936.pf0719ea8.p7a2537aa$20 p7a2537aa_20) {
        return p7a2537aa_20.call();
    }

    public static androidx.room.RoomDatabase HKivyQyFWjYqCtHQ(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static android.database.Cursor LtHksPUhzSkfMKTG(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool UFmJmQToxbcCAznK(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static int WjfiCNTVCsgENwcQ(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static void CFvlHahHUalApTfi(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.int KZQbmwhgVpDAUcDn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void MiNcVdAZiaJPBPAd(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool NfjXtWvLEIsOrIXj(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void QDfJLqVDUkwjUkMp(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void XQQWiUQXFwnWpUzM(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((2 + 20) % 20 > 0) {
        }
        java.lang.int numKZQbmwhgVpDAUcDn = null;
        android.database.Cursor cursorLtHksPUhzSkfMKTG = LtHksPUhzSkfMKTG(HKivyQyFWjYqCtHQ(this.this$0), this.val$_statement, false, null);
        try {
            if (nfjXtWvLEIsOrIXj(cursorLtHksPUhzSkfMKTG) && !UFmJmQToxbcCAznK(cursorLtHksPUhzSkfMKTG, 0)) {
                numKZQbmwhgVpDAUcDn = kZQbmwhgVpDAUcDn(WjfiCNTVCsgENwcQ(cursorLtHksPUhzSkfMKTG, 0));
            }
            qDfJLqVDUkwjUkMp(cursorLtHksPUhzSkfMKTG);
            cFvlHahHUalApTfi(this.val$_statement);
            return numKZQbmwhgVpDAUcDn;
        } catch (java.lang.Exception th) {
            miNcVdAZiaJPBPAd(cursorLtHksPUhzSkfMKTG);
            xQQWiUQXFwnWpUzM(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return DugYqRmQrMYKztAg(this);
    }
}

