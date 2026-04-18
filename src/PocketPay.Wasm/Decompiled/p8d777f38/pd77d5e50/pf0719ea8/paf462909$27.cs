namespace WillowMaze.Wasm.Decompiled;


class paf462909$27 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$27(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        this.this$0 = paf462909Var;
    }

    public static kotlin.Unit AZVEOpqlBttlQwaF(p8d777f38.pd77d5e50.pf0719ea8.paf462909$27 paf462909_27) {
        return paf462909_27.call2();
    }

    public static androidx.room.RoomDatabase FdpmUpWJQrOQpBMD(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.SharedSQLiteStatement GWLRhwUUhZVLcgxo(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m74faefcd(paf462909Var);
    }

    public static androidx.room.RoomDatabase JUDxpJHJsVQOFuvf(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase OeJhGpjVrdVbDBjr(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement UYNfDxIlqrnhEGQn(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void VqcqtOffZJMTwPxy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void ZKUTEwdMOcMOmlSp(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HGQXUIDpkfzUHXlC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.SharedSQLiteStatement HmIzAqYVBXGOZMNr(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m74faefcd(paf462909Var);
    }

    public static void IZiwTMBMECvvlstC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase LQauZVqNkXivdyZy(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.SharedSQLiteStatement TOKuamnSVkvGFZbR(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m74faefcd(paf462909Var);
    }

    public static void UrmCIzoZEFBoXWyb(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void UsGFApsgUZovtCYi(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int XEJAkKrAEXbiBIvt(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return AZVEOpqlBttlQwaF(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((31 + 26) % 26 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementUYNfDxIlqrnhEGQn = UYNfDxIlqrnhEGQn(hmIzAqYVBXGOZMNr(this.this$0));
        try {
            VqcqtOffZJMTwPxy(JUDxpJHJsVQOFuvf(this.this$0));
            try {
                xEJAkKrAEXbiBIvt(supportSQLiteStatementUYNfDxIlqrnhEGQn);
                hGQXUIDpkfzUHXlC(lQauZVqNkXivdyZy(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                ZKUTEwdMOcMOmlSp(FdpmUpWJQrOQpBMD(this.this$0));
                urmCIzoZEFBoXWyb(tOKuamnSVkvGFZbR(this.this$0), supportSQLiteStatementUYNfDxIlqrnhEGQn);
                return unit;
            } catch (java.lang.Exception th) {
                iZiwTMBMECvvlstC(OeJhGpjVrdVbDBjr(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            usGFApsgUZovtCYi(GWLRhwUUhZVLcgxo(this.this$0), supportSQLiteStatementUYNfDxIlqrnhEGQn);
            throw th2;
        }
    }
}

