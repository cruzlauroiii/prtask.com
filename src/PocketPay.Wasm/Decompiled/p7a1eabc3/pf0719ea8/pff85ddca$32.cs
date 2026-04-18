namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$32 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$32(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        this.this$0 = pff85ddcaVar;
    }

    public static void FRSBNWrJWYTzslph(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement HQxsToNPtfsieeYb(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m1740fbc7(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase MKVmMsSBagTYGZWq(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void SAMBgqWNfueitOkM(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement CtKLorhUWTvIjkoS(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m1740fbc7(pff85ddcaVar);
    }

    public static kotlin.Unit EeddDvKQPvIzBGjR(p7a1eabc3.pf0719ea8.pff85ddca$32 pff85ddca_32) {
        return pff85ddca_32.call2();
    }

    public static void FpdOXhMekXqNHeoW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void GJYjTHiqcdpgHCaM(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase GPXmgpqykCeSjJyq(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void HrlIgSgWsdDYzVuh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase IMuhCKcqbnAlfxGD(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement KTvBCdVpTpKzhPou(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m1740fbc7(pff85ddcaVar);
    }

    public static int PpvWWoGUTktkyUqP(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void TBpwGUWUmgoGcXwe(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase VkifTwOLgADxthbx(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement WpZSFEjLEhXxqvDQ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return eeddDvKQPvIzBGjR(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((29 + 25) % 25 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementWpZSFEjLEhXxqvDQ = wpZSFEjLEhXxqvDQ(ctKLorhUWTvIjkoS(this.this$0));
        try {
            hrlIgSgWsdDYzVuh(gPXmgpqykCeSjJyq(this.this$0));
            try {
                ppvWWoGUTktkyUqP(supportSQLiteStatementWpZSFEjLEhXxqvDQ);
                gJYjTHiqcdpgHCaM(vkifTwOLgADxthbx(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                fpdOXhMekXqNHeoW(iMuhCKcqbnAlfxGD(this.this$0));
                tBpwGUWUmgoGcXwe(kTvBCdVpTpKzhPou(this.this$0), supportSQLiteStatementWpZSFEjLEhXxqvDQ);
                return unit;
            } catch (java.lang.Exception th) {
                FRSBNWrJWYTzslph(MKVmMsSBagTYGZWq(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            SAMBgqWNfueitOkM(HQxsToNPtfsieeYb(this.this$0), supportSQLiteStatementWpZSFEjLEhXxqvDQ);
            throw th2;
        }
    }
}

