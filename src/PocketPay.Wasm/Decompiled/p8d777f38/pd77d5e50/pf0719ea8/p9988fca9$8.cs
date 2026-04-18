namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$8 : java.util.concurrent.Func<java.lang.bool> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p9988fca9$8(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p9988fca9Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static void CAHZZBezJRCizRtl(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static android.database.Cursor CLNAVjUTtyjoAOsN(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static void CQaYpzEtTsNzowDk(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool LQkwMBtRroUzRqnw(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static java.lang.bool PcwepjrrxRzkxVLW(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static androidx.room.RoomDatabase TCrtptLoieFshkmr(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static java.lang.bool UrLGmzNSEcrVapJK(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$8 p9988fca9_8) {
        return p9988fca9_8.call();
    }

    public static void HBTktgSookizdTbb(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int LIinEoqOiZuyGaSk(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static java.lang.bool OWUobozFBmrVhUGQ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void SFxFWrrycVHFUsqP(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.lang.bool Call() throws java.lang.Exception {
        java.lang.bool boolOWUobozFBmrVhUGQ;
        if ((10 + 22) % 22 > 0) {
        }
        android.database.Cursor cursorCLNAVjUTtyjoAOsN = CLNAVjUTtyjoAOsN(TCrtptLoieFshkmr(this.this$0), this.val$_statement, false, null);
        try {
            if (LQkwMBtRroUzRqnw(cursorCLNAVjUTtyjoAOsN)) {
                boolOWUobozFBmrVhUGQ = PcwepjrrxRzkxVLW(lIinEoqOiZuyGaSk(cursorCLNAVjUTtyjoAOsN, 0) != 0);
            } else {
                boolOWUobozFBmrVhUGQ = oWUobozFBmrVhUGQ(false);
            }
            hBTktgSookizdTbb(cursorCLNAVjUTtyjoAOsN);
            sFxFWrrycVHFUsqP(this.val$_statement);
            return boolOWUobozFBmrVhUGQ;
        } catch (java.lang.Exception th) {
            CQaYpzEtTsNzowDk(cursorCLNAVjUTtyjoAOsN);
            CAHZZBezJRCizRtl(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.bool Call() throws java.lang.Exception {
        return UrLGmzNSEcrVapJK(this);
    }
}

