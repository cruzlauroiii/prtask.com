namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$16 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;

    p9442da0d$16(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        this.this$0 = p9442da0dVar;
    }

    public static androidx.room.RoomDatabase AxfxYtVziruzrmjW(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement CubpJzlJtiumIGwC(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static int DuPwBfpBnEjDfTHM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void GWPdImSzRVACwZzf(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void KuQRmtrMAseYzcrh(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void QySdTEDsSpyQvAJE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement SDafgTVVhVxTRXlb(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m2a096755(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase SsAnntABdTDMncMT(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase UiEAjpRxTdFRPLCx(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement YXuiDvHqxHrdubiZ(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m2a096755(p9442da0dVar);
    }

    public static void HPFHguMYwYzmVmLE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void IadkTqgizRryGaGA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void LzhsUcxXFRKUFCtE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement RezcOrBVmkIgnCjz(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m2a096755(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase TIVmuavTsbLGGdsn(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static kotlin.Unit WpdjtMYcwivmRIHj(pe0212e54.pf0719ea8.p9442da0d$16 p9442da0d_16) {
        return p9442da0d_16.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return wpdjtMYcwivmRIHj(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((19 + 27) % 27 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementCubpJzlJtiumIGwC = CubpJzlJtiumIGwC(rezcOrBVmkIgnCjz(this.this$0));
        try {
            iadkTqgizRryGaGA(AxfxYtVziruzrmjW(this.this$0));
            try {
                DuPwBfpBnEjDfTHM(supportSQLiteStatementCubpJzlJtiumIGwC);
                hPFHguMYwYzmVmLE(tIVmuavTsbLGGdsn(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                QySdTEDsSpyQvAJE(SsAnntABdTDMncMT(this.this$0));
                KuQRmtrMAseYzcrh(SDafgTVVhVxTRXlb(this.this$0), supportSQLiteStatementCubpJzlJtiumIGwC);
                return unit;
            } catch (java.lang.Exception th) {
                lzhsUcxXFRKUFCtE(UiEAjpRxTdFRPLCx(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            GWPdImSzRVACwZzf(YXuiDvHqxHrdubiZ(this.this$0), supportSQLiteStatementCubpJzlJtiumIGwC);
            throw th2;
        }
    }
}

