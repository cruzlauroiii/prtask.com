namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$36 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$36(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        this.this$0 = pff85ddcaVar;
    }

    public static androidx.room.RoomDatabase ApkwpopMOAVvjzyR(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase BtJjkONBIUFnnOkP(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement HTlHtqsZtGYuDVDJ(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m53786ceb(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase NUUZBaYLzxDPIqbF(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void OZswTshSqzUQhIMb(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void QJiWlLMxJCMEotqx(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void RjEqfiBvxnekHgdG(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void ESMlqDqQUMtqjqPq(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void HqeHpOoZLwPwjneS(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static kotlin.Unit JVOIVQJkjiifEhJb(p7a1eabc3.pf0719ea8.pff85ddca$36 pff85ddca_36) {
        return pff85ddca_36.call2();
    }

    public static androidx.room.SharedSQLiteStatement MKZxgoWqcqZpCimf(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m53786ceb(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement MOdOjMzHoiTxVRWu(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m53786ceb(pff85ddcaVar);
    }

    public static void NEsTuTfkVHwfZmTl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement PKhBvGKXXbtZAaDi(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static int SOMiXtTyovfhsbYg(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.RoomDatabase XLAtWaOJChmDPWdk(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return jVOIVQJkjiifEhJb(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((5 + 5) % 5 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementPKhBvGKXXbtZAaDi = pKhBvGKXXbtZAaDi(HTlHtqsZtGYuDVDJ(this.this$0));
        try {
            OZswTshSqzUQhIMb(NUUZBaYLzxDPIqbF(this.this$0));
            try {
                sOMiXtTyovfhsbYg(supportSQLiteStatementPKhBvGKXXbtZAaDi);
                eSMlqDqQUMtqjqPq(ApkwpopMOAVvjzyR(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                nEsTuTfkVHwfZmTl(xLAtWaOJChmDPWdk(this.this$0));
                RjEqfiBvxnekHgdG(mOdOjMzHoiTxVRWu(this.this$0), supportSQLiteStatementPKhBvGKXXbtZAaDi);
                return unit;
            } catch (java.lang.Exception th) {
                QJiWlLMxJCMEotqx(BtJjkONBIUFnnOkP(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            hqeHpOoZLwPwjneS(mKZxgoWqcqZpCimf(this.this$0), supportSQLiteStatementPKhBvGKXXbtZAaDi);
            throw th2;
        }
    }
}

