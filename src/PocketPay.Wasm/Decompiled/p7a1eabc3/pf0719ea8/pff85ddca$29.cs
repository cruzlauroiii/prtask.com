namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$29 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$commodityId;

    pff85ddca$29(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$commodityId = str;
    }

    public static androidx.room.SharedSQLiteStatement AqMvpBeucyKixheE(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mcdc7972c(pff85ddcaVar);
    }

    public static void BHIRHICIIAtSbkQE(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase BWQoOyyUWPoFUIVL(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement EYYTNObxdtUvzUfH(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mcdc7972c(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase FGjvFAknsFNfwWAK(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase RrunmCCRcirIodEQ(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void VPPyERAakBhUYwtc(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int VlstTHHOEiXzmPaQ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void EJdWbNkEMWHzaSJp(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.SharedSQLiteStatement HjeUvRyFfUbqzmLH(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mcdc7972c(pff85ddcaVar);
    }

    public static void JWrxyoBdASniGHTo(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void KqOjlbFjfTwZNYCN(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static androidx.room.RoomDatabase MWKDagRONweXavDn(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement PkQelVYtjkQVynLA(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static kotlin.Unit QbUDrdXaujPtSkCp(p7a1eabc3.pf0719ea8.pff85ddca$29 pff85ddca_29) {
        return pff85ddca_29.call2();
    }

    public static void TzgfcWTPRiNDpQda(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void VlVFGlGBIsujrSqU(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return qbUDrdXaujPtSkCp(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((23 + 11) % 11 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementPkQelVYtjkQVynLA = pkQelVYtjkQVynLA(AqMvpBeucyKixheE(this.this$0));
        kqOjlbFjfTwZNYCN(supportSQLiteStatementPkQelVYtjkQVynLA, 1, this.val$commodityId);
        try {
            vlVFGlGBIsujrSqU(mWKDagRONweXavDn(this.this$0));
            try {
                VlstTHHOEiXzmPaQ(supportSQLiteStatementPkQelVYtjkQVynLA);
                eJdWbNkEMWHzaSJp(RrunmCCRcirIodEQ(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                jWrxyoBdASniGHTo(BWQoOyyUWPoFUIVL(this.this$0));
                BHIRHICIIAtSbkQE(hjeUvRyFfUbqzmLH(this.this$0), supportSQLiteStatementPkQelVYtjkQVynLA);
                return unit;
            } catch (java.lang.Exception th) {
                VPPyERAakBhUYwtc(FGjvFAknsFNfwWAK(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            tzgfcWTPRiNDpQda(EYYTNObxdtUvzUfH(this.this$0), supportSQLiteStatementPkQelVYtjkQVynLA);
            throw th2;
        }
    }
}

