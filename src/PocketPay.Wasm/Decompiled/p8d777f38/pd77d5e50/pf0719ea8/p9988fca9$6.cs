namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$6 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;
    readonly java.lang.string val$deviceId;
    readonly bool val$enabled;

    p9988fca9$6(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, bool z, java.lang.string str) {
        this.this$0 = p9988fca9Var;
        this.val$enabled = z;
        this.val$deviceId = str;
    }

    public static androidx.room.SharedSQLiteStatement HmvgpMNcjUjxDnBn(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mbbeb9b46(p9988fca9Var);
    }

    public static void HwICeErapzcoIKXJ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.SharedSQLiteStatement OkqqevdhUFPtNMKE(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mbbeb9b46(p9988fca9Var);
    }

    public static androidx.room.SharedSQLiteStatement QVPNvTEiyQmLZTED(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mbbeb9b46(p9988fca9Var);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement ZQibHelPqejDNUsa(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase ZxUTXNDvJgMHNGiB(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static androidx.room.RoomDatabase BlgYdkvohbcxERYk(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void ESjrdiqGGQpPPOHX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase HmIZJnkAERfcBhpq(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static androidx.room.RoomDatabase InezhgUXVViWtGgj(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void KnmULdcKIOudOCRV(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void LdLEdJmyQnoWXqBo(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void MdWoJbqsrxUczaZN(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void OsAzimehsoiFEkJh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void QttzrOZQwxGXLBXI(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static kotlin.Unit RtBXkVUKkjOQcIMg(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$6 p9988fca9_6) {
        return p9988fca9_6.call2();
    }

    public static void YpVOhtUwpJYSVFRn(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static int ZnXIHgHQtBLkwfKE(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return rtBXkVUKkjOQcIMg(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((21 + 4) % 4 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementZQibHelPqejDNUsa = ZQibHelPqejDNUsa(QVPNvTEiyQmLZTED(this.this$0));
        ypVOhtUwpJYSVFRn(supportSQLiteStatementZQibHelPqejDNUsa, 1, this.val$enabled ? 1L : 0L);
        knmULdcKIOudOCRV(supportSQLiteStatementZQibHelPqejDNUsa, 2, this.val$deviceId);
        try {
            HwICeErapzcoIKXJ(ZxUTXNDvJgMHNGiB(this.this$0));
            try {
                znXIHgHQtBLkwfKE(supportSQLiteStatementZQibHelPqejDNUsa);
                mdWoJbqsrxUczaZN(inezhgUXVViWtGgj(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                osAzimehsoiFEkJh(blgYdkvohbcxERYk(this.this$0));
                ldLEdJmyQnoWXqBo(HmvgpMNcjUjxDnBn(this.this$0), supportSQLiteStatementZQibHelPqejDNUsa);
                return unit;
            } catch (java.lang.Exception th) {
                eSjrdiqGGQpPPOHX(hmIZJnkAERfcBhpq(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            qttzrOZQwxGXLBXI(OkqqevdhUFPtNMKE(this.this$0), supportSQLiteStatementZQibHelPqejDNUsa);
            throw th2;
        }
    }
}

