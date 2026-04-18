namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$4 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 val$fastSellHashSettingsDbEntity;

    p9988fca9$4(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        this.this$0 = p9988fca9Var;
        this.val$fastSellHashSettingsDbEntity = p985d1fa1Var;
    }

    public static androidx.room.RoomDatabase KawZLsKsCxdgfULI(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static androidx.room.RoomDatabase QlageWJSAUFmMdgw(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void VDOHxgTKGFlrsMPk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase WMikXslPgsXQWnwo(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void CfUtOnJynmPazDfB(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase GwNKhFkvUyaGPERC(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static kotlin.Unit JypnjfKLzAccwDMj(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$4 p9988fca9_4) {
        return p9988fca9_4.call2();
    }

    public static void OlxAuRFOulQUVTaA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.EntityInsertionAdapter TAszDVBhWOrDeHkP(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.m337ceba5(p9988fca9Var);
    }

    public static void VlPmrBnBrBrkwWos(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void ZMmdPqznooncRzHx(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return jypnjfKLzAccwDMj(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((23 + 24) % 24 > 0) {
        }
        olxAuRFOulQUVTaA(QlageWJSAUFmMdgw(this.this$0));
        try {
            zMmdPqznooncRzHx(tAszDVBhWOrDeHkP(this.this$0), this.val$fastSellHashSettingsDbEntity);
            VDOHxgTKGFlrsMPk(gwNKhFkvUyaGPERC(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            vlPmrBnBrBrkwWos(KawZLsKsCxdgfULI(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            cfUtOnJynmPazDfB(WMikXslPgsXQWnwo(this.this$0));
            throw th;
        }
    }
}

