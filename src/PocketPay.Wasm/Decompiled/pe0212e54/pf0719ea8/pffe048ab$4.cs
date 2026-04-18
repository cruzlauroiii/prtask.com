namespace WillowMaze.Wasm.Decompiled;


class pffe048ab$4 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.pffe048ab this$0;
    readonly pe0212e54.pf5e638cc.pd77d5e50.p94db0041 val$deviceStatus;

    pffe048ab$4(pe0212e54.pf0719ea8.pffe048ab pffe048abVar, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        this.this$0 = pffe048abVar;
        this.val$deviceStatus = p94db0041Var;
    }

    public static androidx.room.RoomDatabase CmXapaXCiNxFlLwF(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static kotlin.Unit JVKPlGwjSbzFtZTx(pe0212e54.pf0719ea8.pffe048ab$4 pffe048ab_4) {
        return pffe048ab_4.call2();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter LyhccVBEqWKEwIrv(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.m337ceba5(pffe048abVar);
    }

    public static int OwffiErILdUTloih(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static androidx.room.RoomDatabase SCxHURYVURQjVWLy(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static void DUXYGszEvhSaHZSW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void GFZEDIZYmjdzHkEB(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HtzqCkmdHUVsRnKh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase IcCZKnCetyJmkSpe(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static androidx.room.RoomDatabase NsFpJwiBYBrBQhxW(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static void UBqZSpnqgUJulhmb(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return JVKPlGwjSbzFtZTx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((6 + 15) % 15 > 0) {
        }
        dUXYGszEvhSaHZSW(nsFpJwiBYBrBQhxW(this.this$0));
        try {
            OwffiErILdUTloih(LyhccVBEqWKEwIrv(this.this$0), this.val$deviceStatus);
            htzqCkmdHUVsRnKh(SCxHURYVURQjVWLy(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            gFZEDIZYmjdzHkEB(CmXapaXCiNxFlLwF(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            uBqZSpnqgUJulhmb(icCZKnCetyJmkSpe(this.this$0));
            throw th;
        }
    }
}

