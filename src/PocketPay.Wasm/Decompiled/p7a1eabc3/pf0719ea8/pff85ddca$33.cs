namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$33 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$33(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        this.this$0 = pff85ddcaVar;
    }

    public static androidx.room.RoomDatabase AGHPMGYgKrLbbYGs(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase DDSQnKDZrAxGuRdp(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase FlbpFLPveQweFsxu(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void GVLYmyeIqkBaFeJA(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static kotlin.Unit IwmhKUfRqGzQbHkt(p7a1eabc3.pf0719ea8.pff85ddca$33 pff85ddca_33) {
        return pff85ddca_33.call2();
    }

    public static void LypuPpoyzykpuqAv(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int OGVWApqYdForGgNz(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.SharedSQLiteStatement RBNjXeokTTUIWIjI(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m649493cb(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement SbUCHNrYnkJWKjKH(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m649493cb(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement YwoUmHATyaOdPSke(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void ZELxxRyqxlwCUQCK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.SharedSQLiteStatement DsOWdaktlCEagtGB(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m649493cb(pff85ddcaVar);
    }

    public static void HxanfTCBLNoVnNxh(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void JvMivRDfXNdvsoWw(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase SqNkemetNtLITteF(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void XhRioisdjrDsNWLy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return IwmhKUfRqGzQbHkt(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((1 + 7) % 7 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementYwoUmHATyaOdPSke = YwoUmHATyaOdPSke(dsOWdaktlCEagtGB(this.this$0));
        try {
            jvMivRDfXNdvsoWw(FlbpFLPveQweFsxu(this.this$0));
            try {
                OGVWApqYdForGgNz(supportSQLiteStatementYwoUmHATyaOdPSke);
                ZELxxRyqxlwCUQCK(sqNkemetNtLITteF(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                LypuPpoyzykpuqAv(DDSQnKDZrAxGuRdp(this.this$0));
                hxanfTCBLNoVnNxh(SbUCHNrYnkJWKjKH(this.this$0), supportSQLiteStatementYwoUmHATyaOdPSke);
                return unit;
            } catch (java.lang.Exception th) {
                xhRioisdjrDsNWLy(AGHPMGYgKrLbbYGs(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            GVLYmyeIqkBaFeJA(RBNjXeokTTUIWIjI(this.this$0), supportSQLiteStatementYwoUmHATyaOdPSke);
            throw th2;
        }
    }
}

