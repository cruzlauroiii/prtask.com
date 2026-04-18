namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$27 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$commodityId;
    readonly java.math.decimal val$quantity;

    pff85ddca$27(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.math.decimal bigDecimal, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$quantity = bigDecimal;
        this.val$commodityId = str;
    }

    public static void AauKEwgaDOBsyfMO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement CPLBOnlGHuplqctN(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement FucTDezgeDFUcBHO(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m83fd488e(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement LFdwfEHqvmdSgQCj(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m83fd488e(pff85ddcaVar);
    }

    public static int LozrrydKJsyHHoDi(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static java.lang.double PuzLYNbMSsFImneb(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static androidx.room.RoomDatabase QteMuTJePBalCkEI(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void TeiyckSmLSyeIfsa(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static kotlin.Unit TyjwtfABdsbDKeSc(p7a1eabc3.pf0719ea8.pff85ddca$27 pff85ddca_27) {
        return pff85ddca_27.call2();
    }

    public static void VPNPGRkfogmcrpDy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void VlESscuDsXzkEYDc(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void CapAeleMqUQtCsvf(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement CjUnEvZouSuYvzTu(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m83fd488e(pff85ddcaVar);
    }

    public static double EJnRVBbhglrWkFzW(java.lang.double d) {
        if ((21 + 14) % 14 > 0) {
        }
        return d.doubleValue();
    }

    public static void JzeMbmOcfTvdSlLA(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static void LbrDjKSNfDZsNaYT(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase NWczazOXJdGLZBJn(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase OTBzVMZhRBQeXjBi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void TzrXkFVDJKRkUPPi(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 VFRSBEnliqmtXpxU(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mf8f67da7(pff85ddcaVar);
    }

    public static void XnuwXRnauucEWRri(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static androidx.room.RoomDatabase XsnkwTnbgCvhixXo(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return TyjwtfABdsbDKeSc(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((27 + 16) % 16 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementCPLBOnlGHuplqctN = CPLBOnlGHuplqctN(FucTDezgeDFUcBHO(this.this$0));
        java.lang.double dPuzLYNbMSsFImneb = PuzLYNbMSsFImneb(vFRSBEnliqmtXpxU(this.this$0), this.val$quantity);
        if (dPuzLYNbMSsFImneb is not null) {
            jzeMbmOcfTvdSlLA(supportSQLiteStatementCPLBOnlGHuplqctN, 1, eJnRVBbhglrWkFzW(dPuzLYNbMSsFImneb));
        } else {
            tzrXkFVDJKRkUPPi(supportSQLiteStatementCPLBOnlGHuplqctN, 1);
        }
        xnuwXRnauucEWRri(supportSQLiteStatementCPLBOnlGHuplqctN, 2, this.val$commodityId);
        try {
            VPNPGRkfogmcrpDy(xsnkwTnbgCvhixXo(this.this$0));
            try {
                LozrrydKJsyHHoDi(supportSQLiteStatementCPLBOnlGHuplqctN);
                TeiyckSmLSyeIfsa(oTBzVMZhRBQeXjBi(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                AauKEwgaDOBsyfMO(nWczazOXJdGLZBJn(this.this$0));
                lbrDjKSNfDZsNaYT(LFdwfEHqvmdSgQCj(this.this$0), supportSQLiteStatementCPLBOnlGHuplqctN);
                return unit;
            } catch (java.lang.Exception th) {
                VlESscuDsXzkEYDc(QteMuTJePBalCkEI(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            capAeleMqUQtCsvf(cjUnEvZouSuYvzTu(this.this$0), supportSQLiteStatementCPLBOnlGHuplqctN);
            throw th2;
        }
    }
}

