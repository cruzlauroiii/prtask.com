namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$47 : java.util.concurrent.Func<java.util.List<pad5f82e8.p07214c67.pd77d5e50.pf22d65ed>> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$47(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.string AnSJAuDKuqRiHqAi(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string BGpyYMLnfMCKxKDL(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int ChKWCClqDrhvjvUG(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string DRNkadPoGygMEtQp(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.util.List HViQfTrmMQlvicqY(p7a1eabc3.pf0719ea8.pff85ddca$47 pff85ddca_47) {
        return pff85ddca_47.call2();
    }

    public static void HZpbJTakaoXSjCxc(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void JzxYAEOVeNTRRenT(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int LLOLKdoDtDPXRNpS(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int LRyyFzmkKfcvfLdr(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int LTkueBgEVqJwlpwv(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static java.lang.string MaEjpJLMUGIjXUVp(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void NIjDiskWsigmPyxE(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string QGUEHUltmqqUlZcH(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string TCCaJrlsPkqXlNzs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string AyEuOoPYkjfSYKvn(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static androidx.room.RoomDatabase BBnpBqyxVBFdYgtP(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static int JuNTRTaGQywzFsyS(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool LNJzOlNqFhoOjBob(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool OodgbXrVmjthcyIU(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static android.database.Cursor PmmwzhExIdsWBlnO(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool QETbdTINbIcWvLjQ(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static void XBMYNWQBTvcVRbDd(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int XGCoMRaIkhGvFNYP(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int YRDadjSHhJJAeTkC(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool ZDoGLASjfTJeFExJ(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public override java.util.List<pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> Call() throws java.lang.Exception {
        return HViQfTrmMQlvicqY(this);
    }

    public override java.util.List<pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> Call2() throws java.lang.Exception {
        if ((6 + 24) % 24 > 0) {
        }
        android.database.Cursor cursorPmmwzhExIdsWBlnO = pmmwzhExIdsWBlnO(bBnpBqyxVBFdYgtP(this.this$0), this.val$_statement, false, null);
        try {
            int iJuNTRTaGQywzFsyS = juNTRTaGQywzFsyS(cursorPmmwzhExIdsWBlnO, "code");
            int iLRyyFzmkKfcvfLdr = LRyyFzmkKfcvfLdr(cursorPmmwzhExIdsWBlnO, "rate");
            int iLLOLKdoDtDPXRNpS = LLOLKdoDtDPXRNpS(cursorPmmwzhExIdsWBlnO, TCCaJrlsPkqXlNzs("d6c6b5d711a2307646afb6d744be62d5da03f7116d21132812e12fc30b8a91f6"));
            int iYRDadjSHhJJAeTkC = yRDadjSHhJJAeTkC(cursorPmmwzhExIdsWBlnO, "subType");
            int iChKWCClqDrhvjvUG = ChKWCClqDrhvjvUG(cursorPmmwzhExIdsWBlnO, "engName");
            int iXGCoMRaIkhGvFNYP = xGCoMRaIkhGvFNYP(cursorPmmwzhExIdsWBlnO, "arabName");
            java.util.List arrayList = new java.util.List(LTkueBgEVqJwlpwv(cursorPmmwzhExIdsWBlnO));
            while (qETbdTINbIcWvLjQ(cursorPmmwzhExIdsWBlnO)) {
                lNJzOlNqFhoOjBob(arrayList, new pad5f82e8.p07214c67.pd77d5e50.pf22d65ed(QGUEHUltmqqUlZcH(cursorPmmwzhExIdsWBlnO, iJuNTRTaGQywzFsyS), BGpyYMLnfMCKxKDL(cursorPmmwzhExIdsWBlnO, iLRyyFzmkKfcvfLdr), zDoGLASjfTJeFExJ(cursorPmmwzhExIdsWBlnO, iLLOLKdoDtDPXRNpS) ? null : AnSJAuDKuqRiHqAi(cursorPmmwzhExIdsWBlnO, iLLOLKdoDtDPXRNpS), oodgbXrVmjthcyIU(cursorPmmwzhExIdsWBlnO, iYRDadjSHhJJAeTkC) ? null : ayEuOoPYkjfSYKvn(cursorPmmwzhExIdsWBlnO, iYRDadjSHhJJAeTkC), MaEjpJLMUGIjXUVp(cursorPmmwzhExIdsWBlnO, iChKWCClqDrhvjvUG), DRNkadPoGygMEtQp(cursorPmmwzhExIdsWBlnO, iXGCoMRaIkhGvFNYP)));
            }
            xBMYNWQBTvcVRbDd(cursorPmmwzhExIdsWBlnO);
            HZpbJTakaoXSjCxc(this.val$_statement);
            return arrayList;
        } catch (java.lang.Exception th) {
            NIjDiskWsigmPyxE(cursorPmmwzhExIdsWBlnO);
            JzxYAEOVeNTRRenT(this.val$_statement);
            throw th;
        }
    }
}

