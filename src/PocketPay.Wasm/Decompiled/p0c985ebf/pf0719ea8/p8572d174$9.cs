namespace WillowMaze.Wasm.Decompiled;


class p8572d174$9 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly p0c985ebf.p07214c67.pd77d5e50.pf7c281bf val$inspectionDbEntity;

    p8572d174$9(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        this.this$0 = p8572d174Var;
        this.val$inspectionDbEntity = pf7c281bfVar;
    }

    public static androidx.room.RoomDatabase FQOcPJVDxMkbBQqS(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter GqRzaJdxGlBhSuWJ(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m89082e03(p8572d174Var);
    }

    public static androidx.room.RoomDatabase QwGTFhGdOKVFKsRL(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase WeilrCvsQFVpyfTS(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void ZvTaMijhDHsskNOO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void DoqTEGHAFqcVifzO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase IWLWmZuItqIJDaBY(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static int NuPCTHRgrgiHNyEH(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static void RxWzhVSeSjwulHqV(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void TcdHekQrTtryJgQS(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit ZafASjseokayWqgN(p0c985ebf.pf0719ea8.p8572d174$9 p8572d174_9) {
        return p8572d174_9.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return zafASjseokayWqgN(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((30 + 29) % 29 > 0) {
        }
        ZvTaMijhDHsskNOO(iWLWmZuItqIJDaBY(this.this$0));
        try {
            nuPCTHRgrgiHNyEH(GqRzaJdxGlBhSuWJ(this.this$0), this.val$inspectionDbEntity);
            doqTEGHAFqcVifzO(FQOcPJVDxMkbBQqS(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            tcdHekQrTtryJgQS(WeilrCvsQFVpyfTS(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            rxWzhVSeSjwulHqV(QwGTFhGdOKVFKsRL(this.this$0));
            throw th;
        }
    }
}

