namespace WillowMaze.Wasm.Decompiled;


class p8572d174$13 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly java.lang.string val$uuid;

    p8572d174$13(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, java.lang.string str) {
        this.this$0 = p8572d174Var;
        this.val$uuid = str;
    }

    public static void CsrAjDgbXEjMAgvs(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static kotlin.Unit HhJixAwBqUaePARq(p0c985ebf.pf0719ea8.p8572d174$13 p8572d174_13) {
        return p8572d174_13.call2();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement MSkOouMvUjhmfgaZ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement PuITTHEecKIRjWgF(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m0dc0a6ea(p8572d174Var);
    }

    public static androidx.room.SharedSQLiteStatement QjraeYHdDpemRzls(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m0dc0a6ea(p8572d174Var);
    }

    public static androidx.room.RoomDatabase QuodRUFxhoTVLZNQ(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void TPtdSkkPWoZLoahd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void TmpyjCfNwmupreid(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase CaihxpkJTySoYXII(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase EgoVKhjLHjpoLNno(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static int IQWSaYOWDswlWXrM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void LTERvwFdkgMRyaQR(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void LZEJEEGcRAVuFSPC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void OCSMtGXAGqeELmzl(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static androidx.room.RoomDatabase PDhaAqsZIOIHtNIc(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void RGqqOhpiAVinvFAI(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement XWANgrSrgbrnvvxG(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m0dc0a6ea(p8572d174Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return HhJixAwBqUaePARq(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((3 + 9) % 9 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementMSkOouMvUjhmfgaZ = MSkOouMvUjhmfgaZ(QjraeYHdDpemRzls(this.this$0));
        oCSMtGXAGqeELmzl(supportSQLiteStatementMSkOouMvUjhmfgaZ, 1, this.val$uuid);
        try {
            TmpyjCfNwmupreid(egoVKhjLHjpoLNno(this.this$0));
            try {
                iQWSaYOWDswlWXrM(supportSQLiteStatementMSkOouMvUjhmfgaZ);
                lZEJEEGcRAVuFSPC(QuodRUFxhoTVLZNQ(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                lTERvwFdkgMRyaQR(caihxpkJTySoYXII(this.this$0));
                CsrAjDgbXEjMAgvs(xWANgrSrgbrnvvxG(this.this$0), supportSQLiteStatementMSkOouMvUjhmfgaZ);
                return unit;
            } catch (java.lang.Exception th) {
                TPtdSkkPWoZLoahd(pDhaAqsZIOIHtNIc(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            rGqqOhpiAVinvFAI(PuITTHEecKIRjWgF(this.this$0), supportSQLiteStatementMSkOouMvUjhmfgaZ);
            throw th2;
        }
    }
}

