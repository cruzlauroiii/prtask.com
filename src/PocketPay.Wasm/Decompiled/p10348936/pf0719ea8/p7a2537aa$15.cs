namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$15 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly p10348936.pf5e638cc.p14abd389 val$status;

    p7a2537aa$15(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        this.this$0 = p7a2537aaVar;
        this.val$status = p14abd389Var;
    }

    public static androidx.room.RoomDatabase DQFmwcdWDSoMiWLM(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void EQHrNpMBgejXCxnk(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void GTAKRSGnMSMBSjmO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void IUESanXRWWUnyYFL(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static java.lang.string JnPaGzlvXqWkFLJU(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return p10348936.pf0719ea8.p7a2537aa.mf8f67da7(p7a2537aaVar, p14abd389Var);
    }

    public static void LBpvCDSnDnyUsaAk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase RoCBeGzmDQaWEoul(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void SyiDtxkSlIoIlgWd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement XZOHwLTQnBxnYSIG(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mebdbf394(p7a2537aaVar);
    }

    public static kotlin.Unit HjkaCXgelMNjCcez(p10348936.pf0719ea8.p7a2537aa$15 p7a2537aa_15) {
        return p7a2537aa_15.call2();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement LTCfSnImiqyBIPph(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void NPiqFaGNhBUCymTV(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void RmifnCBfzJFuEomf(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase TpWEiLZUZcNbSmMB(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase WMgtCzUTHxAEPaGq(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement XvKrQbsQDQTzpAou(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mebdbf394(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement YrvAgVcWduKQFvgh(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mebdbf394(p7a2537aaVar);
    }

    public static int ZItWrkneqseScEcO(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return hjkaCXgelMNjCcez(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((9 + 21) % 21 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementLTCfSnImiqyBIPph = lTCfSnImiqyBIPph(yrvAgVcWduKQFvgh(this.this$0));
        EQHrNpMBgejXCxnk(supportSQLiteStatementLTCfSnImiqyBIPph, 1, JnPaGzlvXqWkFLJU(this.this$0, this.val$status));
        try {
            LBpvCDSnDnyUsaAk(RoCBeGzmDQaWEoul(this.this$0));
            try {
                zItWrkneqseScEcO(supportSQLiteStatementLTCfSnImiqyBIPph);
                GTAKRSGnMSMBSjmO(tpWEiLZUZcNbSmMB(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                SyiDtxkSlIoIlgWd(wMgtCzUTHxAEPaGq(this.this$0));
                IUESanXRWWUnyYFL(xvKrQbsQDQTzpAou(this.this$0), supportSQLiteStatementLTCfSnImiqyBIPph);
                return unit;
            } catch (java.lang.Exception th) {
                rmifnCBfzJFuEomf(DQFmwcdWDSoMiWLM(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            nPiqFaGNhBUCymTV(XZOHwLTQnBxnYSIG(this.this$0), supportSQLiteStatementLTCfSnImiqyBIPph);
            throw th2;
        }
    }
}

