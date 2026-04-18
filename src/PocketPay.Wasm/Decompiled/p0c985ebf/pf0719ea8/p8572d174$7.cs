namespace WillowMaze.Wasm.Decompiled;


class p8572d174$7 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly p0c985ebf.p07214c67.pd77d5e50.pf7c281bf val$inspectionDbEntity;

    p8572d174$7(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        this.this$0 = p8572d174Var;
        this.val$inspectionDbEntity = pf7c281bfVar;
    }

    public static androidx.room.RoomDatabase LmOpnBDwOPSobuaR(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void SoPFSaWfoxPDMOPo(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase TMcdmczWPydIItLl(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase VQnSSsmoWRDYWEvS(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void VZitgdUliRMvUtSC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit YRXdtWIKBloRDdwO(p0c985ebf.pf0719ea8.p8572d174$7 p8572d174_7) {
        return p8572d174_7.call2();
    }

    public static void AIVGMOaJlXOpKure(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.EntityInsertionAdapter BeLrcTKBEGWDVwJq(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m5ec06fdf(p8572d174Var);
    }

    public static androidx.room.RoomDatabase JbvdvCifZHcHswNW(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void PpwREuwgVoGloped(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void ZDLABSnKIcrmZfHs(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return YRXdtWIKBloRDdwO(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((20 + 23) % 23 > 0) {
        }
        aIVGMOaJlXOpKure(jbvdvCifZHcHswNW(this.this$0));
        try {
            ppwREuwgVoGloped(beLrcTKBEGWDVwJq(this.this$0), this.val$inspectionDbEntity);
            zDLABSnKIcrmZfHs(VQnSSsmoWRDYWEvS(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            VZitgdUliRMvUtSC(LmOpnBDwOPSobuaR(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            SoPFSaWfoxPDMOPo(TMcdmczWPydIItLl(this.this$0));
            throw th;
        }
    }
}

