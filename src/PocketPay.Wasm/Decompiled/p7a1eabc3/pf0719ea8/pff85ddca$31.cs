namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$31 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$shopId;

    pff85ddca$31(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$shopId = str;
    }

    public static androidx.room.RoomDatabase GFDfTJITdweEzrFc(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement HIjvizvcrkFkjlnN(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.ma5940f5e(pff85ddcaVar);
    }

    public static void JeWUsLmNYnJWqnDZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase KDXQjBNRZQlPikCS(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void LIbvhccmEHkckWKd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void LSPbSIOUWpqOMubG(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void MuEXSQmqFVxjlIzn(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void RfMbrsMVXZHbbYNK(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement UtgIQDYIcleIXDse(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void WLvjLaUiJxiITzdG(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static androidx.room.RoomDatabase ZqopBqOKoYpcNJRn(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement AiktjUHBGikdjOhI(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.ma5940f5e(pff85ddcaVar);
    }

    public static kotlin.Unit CBeyLXgALJxRJpAx(p7a1eabc3.pf0719ea8.pff85ddca$31 pff85ddca_31) {
        return pff85ddca_31.call2();
    }

    public static androidx.room.RoomDatabase FtQBGMsDQMlGdxSr(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement ScJMJRcDRSCuXnll(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.ma5940f5e(pff85ddcaVar);
    }

    public static void TIvxtlxMIYBvDFmF(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static int XUxOtFdamzSdToSI(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return cBeyLXgALJxRJpAx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((22 + 32) % 32 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementUtgIQDYIcleIXDse = UtgIQDYIcleIXDse(scJMJRcDRSCuXnll(this.this$0));
        WLvjLaUiJxiITzdG(supportSQLiteStatementUtgIQDYIcleIXDse, 1, this.val$shopId);
        try {
            tIvxtlxMIYBvDFmF(ftQBGMsDQMlGdxSr(this.this$0));
            try {
                xUxOtFdamzSdToSI(supportSQLiteStatementUtgIQDYIcleIXDse);
                LIbvhccmEHkckWKd(KDXQjBNRZQlPikCS(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                LSPbSIOUWpqOMubG(ZqopBqOKoYpcNJRn(this.this$0));
                RfMbrsMVXZHbbYNK(HIjvizvcrkFkjlnN(this.this$0), supportSQLiteStatementUtgIQDYIcleIXDse);
                return unit;
            } catch (java.lang.Exception th) {
                JeWUsLmNYnJWqnDZ(GFDfTJITdweEzrFc(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            MuEXSQmqFVxjlIzn(aiktjUHBGikdjOhI(this.this$0), supportSQLiteStatementUtgIQDYIcleIXDse);
            throw th2;
        }
    }
}

