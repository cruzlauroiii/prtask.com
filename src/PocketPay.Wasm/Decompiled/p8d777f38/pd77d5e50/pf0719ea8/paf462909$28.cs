namespace WillowMaze.Wasm.Decompiled;


class paf462909$28 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$28(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        this.this$0 = paf462909Var;
    }

    public static void DQBkYMQHHcFyXnDF(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement ESXjygKBXhNayWPf(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement EftikglGtZPdnZpH(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m53786ceb(paf462909Var);
    }

    public static void IPPicASxChuHvGba(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int KVPaznGWmDhQaSya(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void LIghhJrTaolTMzMk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit RTlDpKlsOWtheWPq(p8d777f38.pd77d5e50.pf0719ea8.paf462909$28 paf462909_28) {
        return paf462909_28.call2();
    }

    public static androidx.room.RoomDatabase RwtOEgBPuGqjaTzk(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.SharedSQLiteStatement UcuHFMTNHbcQIhjm(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m53786ceb(paf462909Var);
    }

    public static void AeUUldiCcOACdEfq(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase NAaoygxNEWxDyFIa(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void NvcvboYakBBCeOSR(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.SharedSQLiteStatement SGUDJrxzshvpLvGl(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m53786ceb(paf462909Var);
    }

    public static androidx.room.RoomDatabase SSRsFCStQrVmMJqv(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase TWnmtxpvQzwBQVLd(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void VNooiMoadgfUjHZb(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return RTlDpKlsOWtheWPq(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((9 + 4) % 4 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementESXjygKBXhNayWPf = ESXjygKBXhNayWPf(UcuHFMTNHbcQIhjm(this.this$0));
        try {
            nvcvboYakBBCeOSR(RwtOEgBPuGqjaTzk(this.this$0));
            try {
                KVPaznGWmDhQaSya(supportSQLiteStatementESXjygKBXhNayWPf);
                vNooiMoadgfUjHZb(sSRsFCStQrVmMJqv(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                DQBkYMQHHcFyXnDF(tWnmtxpvQzwBQVLd(this.this$0));
                IPPicASxChuHvGba(EftikglGtZPdnZpH(this.this$0), supportSQLiteStatementESXjygKBXhNayWPf);
                return unit;
            } catch (java.lang.Exception th) {
                LIghhJrTaolTMzMk(nAaoygxNEWxDyFIa(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            aeUUldiCcOACdEfq(sGUDJrxzshvpLvGl(this.this$0), supportSQLiteStatementESXjygKBXhNayWPf);
            throw th2;
        }
    }
}

