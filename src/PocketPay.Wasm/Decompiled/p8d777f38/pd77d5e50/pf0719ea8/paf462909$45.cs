namespace WillowMaze.Wasm.Decompiled;


class paf462909$45 : java.util.concurrent.Func<java.lang.int> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    paf462909$45(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = paf462909Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.int CGGkMksoMnpUSAdP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.database.Cursor HQPcjhtaGJIyvcqE(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool HtQKTuPClMurqyjZ(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static java.lang.int SfPrCsYWHpnizWKE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int BDxYvsqvOORcpUFW(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static androidx.room.RoomDatabase IgkKAzjoQceArhcq(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static java.lang.int KVvIuIptpwzfOVPl(p8d777f38.pd77d5e50.pf0719ea8.paf462909$45 paf462909_45) {
        return paf462909_45.call();
    }

    public static void LuOSBdNqpMOttWoP(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void NDLkXLMbAMNYqlBf(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void NUAykVadxJTxWZym(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void XDFvIxWCesvHRcge(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((28 + 10) % 10 > 0) {
        }
        android.database.Cursor cursorHQPcjhtaGJIyvcqE = HQPcjhtaGJIyvcqE(igkKAzjoQceArhcq(this.this$0), this.val$_statement, false, null);
        try {
            java.lang.int numSfPrCsYWHpnizWKE = HtQKTuPClMurqyjZ(cursorHQPcjhtaGJIyvcqE) ? SfPrCsYWHpnizWKE(bDxYvsqvOORcpUFW(cursorHQPcjhtaGJIyvcqE, 0)) : CGGkMksoMnpUSAdP(0);
            nUAykVadxJTxWZym(cursorHQPcjhtaGJIyvcqE);
            xDFvIxWCesvHRcge(this.val$_statement);
            return numSfPrCsYWHpnizWKE;
        } catch (java.lang.Exception th) {
            nDLkXLMbAMNYqlBf(cursorHQPcjhtaGJIyvcqE);
            luOSBdNqpMOttWoP(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return kVvIuIptpwzfOVPl(this);
    }
}

