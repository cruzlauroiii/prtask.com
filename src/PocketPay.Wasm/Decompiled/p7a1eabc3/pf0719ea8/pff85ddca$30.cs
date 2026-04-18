namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$30 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$shopId;

    pff85ddca$30(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$shopId = str;
    }

    public static androidx.room.RoomDatabase EBCNldEARMrYwxnz(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void ETyDVGgYLCCRrnRp(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void FyIIEicYIeEcYjkS(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static kotlin.Unit JHbEUbpacDmJBgwR(p7a1eabc3.pf0719ea8.pff85ddca$30 pff85ddca_30) {
        return pff85ddca_30.call2();
    }

    public static void LNoZLtUNDRcGvLgU(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void OAEfAkGWwBuCNPoZ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int OddDzBIGFifTgTNM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.RoomDatabase VtjYDyQgnqTJhxjk(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement WRGlCwBTokyicfQG(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase YogZnvqxwtjXwXkl(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement AsTvOauvjSsjFxlu(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mc7321d99(pff85ddcaVar);
    }

    public static void CTomXqTHtmXUBHXt(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement ILhnlaPzVdnrjLfj(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mc7321d99(pff85ddcaVar);
    }

    public static void JbqHjpbnCTFkLisr(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement KJTcEAxfefVRvAjz(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mc7321d99(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase YkgCNbxlHdOcPETr(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void YrXPRkCDoUWzRNcN(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return JHbEUbpacDmJBgwR(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((29 + 18) % 18 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementWRGlCwBTokyicfQG = WRGlCwBTokyicfQG(asTvOauvjSsjFxlu(this.this$0));
        yrXPRkCDoUWzRNcN(supportSQLiteStatementWRGlCwBTokyicfQG, 1, this.val$shopId);
        try {
            LNoZLtUNDRcGvLgU(YogZnvqxwtjXwXkl(this.this$0));
            try {
                OddDzBIGFifTgTNM(supportSQLiteStatementWRGlCwBTokyicfQG);
                FyIIEicYIeEcYjkS(ykgCNbxlHdOcPETr(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                jbqHjpbnCTFkLisr(EBCNldEARMrYwxnz(this.this$0));
                ETyDVGgYLCCRrnRp(kJTcEAxfefVRvAjz(this.this$0), supportSQLiteStatementWRGlCwBTokyicfQG);
                return unit;
            } catch (java.lang.Exception th) {
                cTomXqTHtmXUBHXt(VtjYDyQgnqTJhxjk(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            OAEfAkGWwBuCNPoZ(iLhnlaPzVdnrjLfj(this.this$0), supportSQLiteStatementWRGlCwBTokyicfQG);
            throw th2;
        }
    }
}

