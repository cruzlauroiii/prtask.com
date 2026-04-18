namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$25 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$commodityId;
    readonly java.math.decimal val$quantity;

    pff85ddca$25(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.math.decimal bigDecimal, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$quantity = bigDecimal;
        this.val$commodityId = str;
    }

    public static void ElpzDZfwFffhguDx(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static void FKRUXBNdXhxLTGrH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement IGaWLSQMpYqfDfMv(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mebdbf394(pff85ddcaVar);
    }

    public static void KswbUKvHhVEExRSz(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement NJLrckIgQPvIDYrm(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase PjKaZyNzDcVabxlX(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase QtSMUDUelmSZTLDn(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static kotlin.Unit SGLrBmkgvQkUGWar(p7a1eabc3.pf0719ea8.pff85ddca$25 pff85ddca_25) {
        return pff85ddca_25.call2();
    }

    public static java.lang.double TRGNPfDomLQAcMwo(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static void TndxRjMjlEEZAYFb(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void VLHAZlZPZzilymlr(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void VLtFZvrBmPQZLlQU(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase YGdiDdSEzmfYiCte(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 YmTXiBIFicSyvvDX(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mf8f67da7(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase FWkeQhHZfBqoeimN(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void HSrCSykGyEmtMAum(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static double KEYRjYQbGaXFUywy(java.lang.double d) {
        if ((16 + 8) % 8 > 0) {
        }
        return d.doubleValue();
    }

    public static androidx.room.SharedSQLiteStatement OOnphlZInYiGeEnd(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mebdbf394(pff85ddcaVar);
    }

    public static void QkQhuwCDMziJxeuv(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void RVmyzZCeWUqxpAYT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int WKLjQTwlrCnWTpja(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.SharedSQLiteStatement XqMLtbmMvLhAuOMU(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mebdbf394(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return SGLrBmkgvQkUGWar(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((10 + 25) % 25 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementNJLrckIgQPvIDYrm = NJLrckIgQPvIDYrm(xqMLtbmMvLhAuOMU(this.this$0));
        java.lang.double dTRGNPfDomLQAcMwo = TRGNPfDomLQAcMwo(YmTXiBIFicSyvvDX(this.this$0), this.val$quantity);
        if (dTRGNPfDomLQAcMwo is not null) {
            ElpzDZfwFffhguDx(supportSQLiteStatementNJLrckIgQPvIDYrm, 1, kEYRjYQbGaXFUywy(dTRGNPfDomLQAcMwo));
        } else {
            qkQhuwCDMziJxeuv(supportSQLiteStatementNJLrckIgQPvIDYrm, 1);
        }
        hSrCSykGyEmtMAum(supportSQLiteStatementNJLrckIgQPvIDYrm, 2, this.val$commodityId);
        try {
            VLHAZlZPZzilymlr(YGdiDdSEzmfYiCte(this.this$0));
            try {
                wKLjQTwlrCnWTpja(supportSQLiteStatementNJLrckIgQPvIDYrm);
                KswbUKvHhVEExRSz(PjKaZyNzDcVabxlX(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                FKRUXBNdXhxLTGrH(QtSMUDUelmSZTLDn(this.this$0));
                TndxRjMjlEEZAYFb(IGaWLSQMpYqfDfMv(this.this$0), supportSQLiteStatementNJLrckIgQPvIDYrm);
                return unit;
            } catch (java.lang.Exception th) {
                rVmyzZCeWUqxpAYT(fWkeQhHZfBqoeimN(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            VLtFZvrBmPQZLlQU(oOnphlZInYiGeEnd(this.this$0), supportSQLiteStatementNJLrckIgQPvIDYrm);
            throw th2;
        }
    }
}

