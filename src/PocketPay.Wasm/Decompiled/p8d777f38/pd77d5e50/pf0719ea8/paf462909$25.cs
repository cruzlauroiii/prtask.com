namespace WillowMaze.Wasm.Decompiled;


class paf462909$25 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$25(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        this.this$0 = paf462909Var;
    }

    public static kotlin.Unit CzutNWnGmuuaeMbG(p8d777f38.pd77d5e50.pf0719ea8.paf462909$25 paf462909_25) {
        return paf462909_25.call2();
    }

    public static androidx.room.RoomDatabase FNTPvsYbIiPciMvV(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase FUJryfQQhAGVHoRW(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.SharedSQLiteStatement HViPTZucvFOuAwDo(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m649493cb(paf462909Var);
    }

    public static void HyDTbCXlTPwXPQvL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void OLRHGbTayKKXQwAl(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int PRCYhJClFtGfhOgB(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.SharedSQLiteStatement YFGTWNlMGTczqIPy(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m649493cb(paf462909Var);
    }

    public static androidx.room.RoomDatabase AFCiomgQEZeBlIob(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase CIJyScocMoqgEEEe(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void LkQVeaUcIafUtJYC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void MUtBUmgYqMmkPAvV(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement OthofvVjSjxRRJjb(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m649493cb(paf462909Var);
    }

    public static void TViitDkEJcEfccHr(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement XflMutYaqAXpdvIC(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void ZidBHxJLebsGqRMi(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return CzutNWnGmuuaeMbG(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((32 + 30) % 30 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementXflMutYaqAXpdvIC = xflMutYaqAXpdvIC(YFGTWNlMGTczqIPy(this.this$0));
        try {
            HyDTbCXlTPwXPQvL(FUJryfQQhAGVHoRW(this.this$0));
            try {
                PRCYhJClFtGfhOgB(supportSQLiteStatementXflMutYaqAXpdvIC);
                lkQVeaUcIafUtJYC(cIJyScocMoqgEEEe(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                tViitDkEJcEfccHr(aFCiomgQEZeBlIob(this.this$0));
                zidBHxJLebsGqRMi(HViPTZucvFOuAwDo(this.this$0), supportSQLiteStatementXflMutYaqAXpdvIC);
                return unit;
            } catch (java.lang.Exception th) {
                mUtBUmgYqMmkPAvV(FNTPvsYbIiPciMvV(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            OLRHGbTayKKXQwAl(othofvVjSjxRRJjb(this.this$0), supportSQLiteStatementXflMutYaqAXpdvIC);
            throw th2;
        }
    }
}

