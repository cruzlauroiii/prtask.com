namespace WillowMaze.Wasm.Decompiled;


class paf462909$38 : java.util.concurrent.Func<java.lang.int> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    paf462909$38(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = paf462909Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static bool IBTHCwuxMuLEkJkB(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static java.lang.int WWGeXAfVHJWLmkKP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.database.Cursor BTSsosWyABbWDrRz(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static androidx.room.RoomDatabase EXRTXoiRRKzoeUgR(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static java.lang.int INDUwbTyCXuyllqo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IgFLhWkBrTEtLbGO(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void JGRavUDCysoRdiPp(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void MWRxEJyFFiBdTQVI(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.int OCXLmpjvkWnOALJZ(p8d777f38.pd77d5e50.pf0719ea8.paf462909$38 paf462909_38) {
        return paf462909_38.call();
    }

    public static int OoXqmNILjnehOubM(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static void VyKrHCBmuDBfxAUc(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((16 + 4) % 4 > 0) {
        }
        android.database.Cursor cursorBTSsosWyABbWDrRz = bTSsosWyABbWDrRz(eXRTXoiRRKzoeUgR(this.this$0), this.val$_statement, false, null);
        try {
            java.lang.int numINDUwbTyCXuyllqo = IBTHCwuxMuLEkJkB(cursorBTSsosWyABbWDrRz) ? iNDUwbTyCXuyllqo(ooXqmNILjnehOubM(cursorBTSsosWyABbWDrRz, 0)) : WWGeXAfVHJWLmkKP(0);
            igFLhWkBrTEtLbGO(cursorBTSsosWyABbWDrRz);
            vyKrHCBmuDBfxAUc(this.val$_statement);
            return numINDUwbTyCXuyllqo;
        } catch (java.lang.Exception th) {
            jGRavUDCysoRdiPp(cursorBTSsosWyABbWDrRz);
            mWRxEJyFFiBdTQVI(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return oCXLmpjvkWnOALJZ(this);
    }
}

