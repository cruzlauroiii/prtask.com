namespace WillowMaze.Wasm.Decompiled;


class p8572d174$11 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly java.util.List val$currentInspectionPositionDbEntities;

    p8572d174$11(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, java.util.List list) {
        this.this$0 = p8572d174Var;
        this.val$currentInspectionPositionDbEntities = list;
    }

    public static void ADgTXUlPWDAogBjd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static int BnXoXveOjRGKvWOD(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.IEnumerable iterable) {
        return entityDeletionOrUpdateAdapter.handleMultiple(iterable);
    }

    public static androidx.room.RoomDatabase IHcvQFgTqtNnanuz(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter UAmjlrLVkAMScxyO(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m429f062d(p8572d174Var);
    }

    public static androidx.room.RoomDatabase DhovMvTmJnLDpsXV(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase FDZVFzrCNIWxJCGn(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void IGAsfVHSVPITYlUo(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase JLdbojSIcyVFTSaT(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void JgPdXljbSyTqKvSB(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void UKQqowerEyKWWzjK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit WcIufITojGWEOFzr(p0c985ebf.pf0719ea8.p8572d174$11 p8572d174_11) {
        return p8572d174_11.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return wcIufITojGWEOFzr(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((24 + 20) % 20 > 0) {
        }
        ADgTXUlPWDAogBjd(fDZVFzrCNIWxJCGn(this.this$0));
        try {
            BnXoXveOjRGKvWOD(UAmjlrLVkAMScxyO(this.this$0), this.val$currentInspectionPositionDbEntities);
            jgPdXljbSyTqKvSB(dhovMvTmJnLDpsXV(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            iGAsfVHSVPITYlUo(jLdbojSIcyVFTSaT(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            uKQqowerEyKWWzjK(IHcvQFgTqtNnanuz(this.this$0));
            throw th;
        }
    }
}

