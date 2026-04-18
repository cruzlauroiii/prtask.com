namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$18 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly java.lang.string val$uuid;

    p7a2537aa$18(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        this.this$0 = p7a2537aaVar;
        this.val$uuid = str;
    }

    public static androidx.room.SharedSQLiteStatement APSnYaDAXzWkCaNf(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m5e49d338(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement DtdecsbeEUDCHgmE(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m5e49d338(p7a2537aaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement GnEIPNzDymUxXPoY(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase GpcsUgHsKziYjqly(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase KZBwEwnJgfIWmAPl(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void LpOtwkcXjDlJqMMO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void MOMUfLuSayvSrYtA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void SGReqsjqkjceGRbm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void TPxbbkhmMhzmgSmj(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void VYvUKnNwDcGuppeb(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static kotlin.Unit AFclTKjValMUGwmQ(p10348936.pf0719ea8.p7a2537aa$18 p7a2537aa_18) {
        return p7a2537aa_18.call2();
    }

    public static androidx.room.RoomDatabase DtHGBMszvfnHHKMa(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static int INvzFJsiGhuveXdY(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.SharedSQLiteStatement KNBefOXXEFPLUYLH(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m5e49d338(p7a2537aaVar);
    }

    public static void KlrjYnwqnwxjVLqv(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase UltCfuOMwTpNduzU(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void VynvyeQtaBKkMuCA(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return aFclTKjValMUGwmQ(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((17 + 6) % 6 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementGnEIPNzDymUxXPoY = GnEIPNzDymUxXPoY(DtdecsbeEUDCHgmE(this.this$0));
        vynvyeQtaBKkMuCA(supportSQLiteStatementGnEIPNzDymUxXPoY, 1, this.val$uuid);
        try {
            MOMUfLuSayvSrYtA(ultCfuOMwTpNduzU(this.this$0));
            try {
                iNvzFJsiGhuveXdY(supportSQLiteStatementGnEIPNzDymUxXPoY);
                TPxbbkhmMhzmgSmj(dtHGBMszvfnHHKMa(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                SGReqsjqkjceGRbm(GpcsUgHsKziYjqly(this.this$0));
                klrjYnwqnwxjVLqv(kNBefOXXEFPLUYLH(this.this$0), supportSQLiteStatementGnEIPNzDymUxXPoY);
                return unit;
            } catch (java.lang.Exception th) {
                LpOtwkcXjDlJqMMO(KZBwEwnJgfIWmAPl(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            VYvUKnNwDcGuppeb(APSnYaDAXzWkCaNf(this.this$0), supportSQLiteStatementGnEIPNzDymUxXPoY);
            throw th2;
        }
    }
}

