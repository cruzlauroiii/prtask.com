namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$28 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$parentId;

    pff85ddca$28(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$parentId = str;
    }

    public static androidx.room.RoomDatabase IGksfaBfcadUQzmz(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void MWretLGvmtCOZJXy(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void OQvvKYqdQHOltAaP(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void PrIDfGTdVCmLkglJ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement REJrpixWavDCmXDv(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5e49d338(pff85ddcaVar);
    }

    public static void VOLJyTvWgOFfXMGD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void XxjxubuSLKBMuRDm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void YAUFNyxjrmTjmknh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement YTBLezftMvcgCrTk(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5e49d338(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase YnRQWpPSwCgqSJwe(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement ZGTRbyygRyFyTHmy(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement DDSmtbpjvDaCPwRi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5e49d338(pff85ddcaVar);
    }

    public static kotlin.Unit FcMDDWZGmNhwcmaT(p7a1eabc3.pf0719ea8.pff85ddca$28 pff85ddca_28) {
        return pff85ddca_28.call2();
    }

    public static androidx.room.RoomDatabase FvpBficEwScSEzUh(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase HFlDJUQGLzDgILDM(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static int MlWRabNphOOOxeAA(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void VRIbcDGqmtlclGxD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return fcMDDWZGmNhwcmaT(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((16 + 30) % 30 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementZGTRbyygRyFyTHmy = ZGTRbyygRyFyTHmy(dDSmtbpjvDaCPwRi(this.this$0));
        MWretLGvmtCOZJXy(supportSQLiteStatementZGTRbyygRyFyTHmy, 1, this.val$parentId);
        try {
            XxjxubuSLKBMuRDm(fvpBficEwScSEzUh(this.this$0));
            try {
                mlWRabNphOOOxeAA(supportSQLiteStatementZGTRbyygRyFyTHmy);
                vRIbcDGqmtlclGxD(hFlDJUQGLzDgILDM(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                YAUFNyxjrmTjmknh(YnRQWpPSwCgqSJwe(this.this$0));
                PrIDfGTdVCmLkglJ(REJrpixWavDCmXDv(this.this$0), supportSQLiteStatementZGTRbyygRyFyTHmy);
                return unit;
            } catch (java.lang.Exception th) {
                VOLJyTvWgOFfXMGD(IGksfaBfcadUQzmz(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            OQvvKYqdQHOltAaP(YTBLezftMvcgCrTk(this.this$0), supportSQLiteStatementZGTRbyygRyFyTHmy);
            throw th2;
        }
    }
}

