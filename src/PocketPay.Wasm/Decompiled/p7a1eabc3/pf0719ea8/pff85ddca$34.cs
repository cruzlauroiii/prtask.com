namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$34 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$34(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        this.this$0 = pff85ddcaVar;
    }

    public static void CoqSgHBTyUkkGeqq(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement CtaxHRFcTPrjKSKB(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m59c413ba(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase QxPEKEUxEYKjqzix(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement RkMtDaLapPZhjhRx(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement UDIbLtsMgJpKBbJg(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m59c413ba(pff85ddcaVar);
    }

    public static kotlin.Unit UetROCOGbDENdJuf(p7a1eabc3.pf0719ea8.pff85ddca$34 pff85ddca_34) {
        return pff85ddca_34.call2();
    }

    public static void WMtcoeOfhkHZXuQP(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int ZKAegsvUtQdFHXlM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.RoomDatabase DVyfiQQVsNZRQHfh(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase GQbGdmIICIBWXZbp(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.SharedSQLiteStatement IqaKaDaHaqjwZByi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m59c413ba(pff85ddcaVar);
    }

    public static void KCSbDGSQyutQpPJO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase OqBVKgiBUOAimGbR(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void UOTdcaiSQZjwmihD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void VTEuEDGpmATHaXzk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void WJjusRzBFltMPsIH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return UetROCOGbDENdJuf(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((18 + 10) % 10 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementRkMtDaLapPZhjhRx = RkMtDaLapPZhjhRx(iqaKaDaHaqjwZByi(this.this$0));
        try {
            vTEuEDGpmATHaXzk(oqBVKgiBUOAimGbR(this.this$0));
            try {
                ZKAegsvUtQdFHXlM(supportSQLiteStatementRkMtDaLapPZhjhRx);
                wJjusRzBFltMPsIH(QxPEKEUxEYKjqzix(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                uOTdcaiSQZjwmihD(gQbGdmIICIBWXZbp(this.this$0));
                WMtcoeOfhkHZXuQP(CtaxHRFcTPrjKSKB(this.this$0), supportSQLiteStatementRkMtDaLapPZhjhRx);
                return unit;
            } catch (java.lang.Exception th) {
                kCSbDGSQyutQpPJO(dVyfiQQVsNZRQHfh(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            CoqSgHBTyUkkGeqq(UDIbLtsMgJpKBbJg(this.this$0), supportSQLiteStatementRkMtDaLapPZhjhRx);
            throw th2;
        }
    }
}

