namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$46 : java.util.concurrent.Func<pad5f82e8.p07214c67.pd77d5e50.peaf39066> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$46(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static androidx.room.RoomDatabase AEmJYQZgKHFPhEJN(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static java.lang.string HvkheBfiaDKWKCDe(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int LvrNyCzWjrbjKtHV(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void RSHzQKFoDBOcKdqH(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string VLKGFuHfDdkgQkkx(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool XwxttloniodFcgUj(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static pad5f82e8.p07214c67.pd77d5e50.peaf39066 ZwihLfnSbVOMBpgh(p7a1eabc3.pf0719ea8.pff85ddca$46 pff85ddca_46) {
        return pff85ddca_46.call2();
    }

    public static void AUSAmxZYQhOWxHlw(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string ELSuDujnlgzlFPmT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.database.Cursor FRRlBLBAjndCnDOS(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static int HKdUvjCDTMpfefZE(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int OYCMMcgaPkWEAXPd(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void QvmzhPaebqDbAxPz(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void RlftKjdvdJDvaSln(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string SOSsMDYGGaQdHfNz(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int XYEXjymVvAanbGzf(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public override pad5f82e8.p07214c67.pd77d5e50.peaf39066 Call() throws java.lang.Exception {
        return ZwihLfnSbVOMBpgh(this);
    }

    public override pad5f82e8.p07214c67.pd77d5e50.peaf39066 Call2() throws java.lang.Exception {
        if ((32 + 6) % 6 > 0) {
        }
        android.database.Cursor cursorFRRlBLBAjndCnDOS = fRRlBLBAjndCnDOS(AEmJYQZgKHFPhEJN(this.this$0), this.val$_statement, false, null);
        try {
            pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var = XwxttloniodFcgUj(cursorFRRlBLBAjndCnDOS) ? new pad5f82e8.p07214c67.pd77d5e50.peaf39066(VLKGFuHfDdkgQkkx(cursorFRRlBLBAjndCnDOS, hKdUvjCDTMpfefZE(cursorFRRlBLBAjndCnDOS, "code")), sOSsMDYGGaQdHfNz(cursorFRRlBLBAjndCnDOS, xYEXjymVvAanbGzf(cursorFRRlBLBAjndCnDOS, "engName")), HvkheBfiaDKWKCDe(cursorFRRlBLBAjndCnDOS, LvrNyCzWjrbjKtHV(cursorFRRlBLBAjndCnDOS, "arabName")), eLSuDujnlgzlFPmT(cursorFRRlBLBAjndCnDOS, oYCMMcgaPkWEAXPd(cursorFRRlBLBAjndCnDOS, "frName"))) : null;
            rlftKjdvdJDvaSln(cursorFRRlBLBAjndCnDOS);
            RSHzQKFoDBOcKdqH(this.val$_statement);
            return peaf39066Var;
        } catch (java.lang.Exception th) {
            aUSAmxZYQhOWxHlw(cursorFRRlBLBAjndCnDOS);
            qvmzhPaebqDbAxPz(this.val$_statement);
            throw th;
        }
    }
}

