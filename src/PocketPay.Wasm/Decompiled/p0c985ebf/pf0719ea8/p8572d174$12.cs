namespace WillowMaze.Wasm.Decompiled;


class p8572d174$12 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;

    p8572d174$12(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        this.this$0 = p8572d174Var;
    }

    public static androidx.room.SharedSQLiteStatement CBhWRDCQNdQCmNKM(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m13fe7af4(p8572d174Var);
    }

    public static androidx.room.RoomDatabase CajGdRAvtDWNoTNu(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void HnXTpUEgJnyYdLJZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void IVOVWGwUNyVgzorN(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void MilyJaajfZcxtokl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase PTZOaxmXzolSwpbg(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static kotlin.Unit PWqWihCDsePFIjUx(p0c985ebf.pf0719ea8.p8572d174$12 p8572d174_12) {
        return p8572d174_12.call2();
    }

    public static void WJvqmmErqrPHVSEx(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase WVPnAobjsdTGAEAv(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.SharedSQLiteStatement WoJdtsklpTMxRMXT(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m13fe7af4(p8572d174Var);
    }

    public static androidx.room.RoomDatabase FPJUZgsEqTtiBWwy(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void RxywyqGoyrlPptsV(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement SyeqRogZMEoiqkCE(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement VIFfmpYBSvBoqBHe(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m13fe7af4(p8572d174Var);
    }

    public static int WzVNnBSTrhRFOLTq(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void XgIhwwDUSUyQNJBI(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return PWqWihCDsePFIjUx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((26 + 1) % 1 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementSyeqRogZMEoiqkCE = syeqRogZMEoiqkCE(WoJdtsklpTMxRMXT(this.this$0));
        try {
            IVOVWGwUNyVgzorN(CajGdRAvtDWNoTNu(this.this$0));
            try {
                wzVNnBSTrhRFOLTq(supportSQLiteStatementSyeqRogZMEoiqkCE);
                HnXTpUEgJnyYdLJZ(PTZOaxmXzolSwpbg(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                WJvqmmErqrPHVSEx(fPJUZgsEqTtiBWwy(this.this$0));
                rxywyqGoyrlPptsV(vIFfmpYBSvBoqBHe(this.this$0), supportSQLiteStatementSyeqRogZMEoiqkCE);
                return unit;
            } catch (java.lang.Exception th) {
                MilyJaajfZcxtokl(WVPnAobjsdTGAEAv(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            xgIhwwDUSUyQNJBI(CBhWRDCQNdQCmNKM(this.this$0), supportSQLiteStatementSyeqRogZMEoiqkCE);
            throw th2;
        }
    }
}

