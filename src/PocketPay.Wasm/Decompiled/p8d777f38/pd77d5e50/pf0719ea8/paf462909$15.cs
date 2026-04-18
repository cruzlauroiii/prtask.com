namespace WillowMaze.Wasm.Decompiled;


class paf462909$15 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.pa6b2262c val$receiptTotalCountDbEntity;

    paf462909$15(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        this.this$0 = paf462909Var;
        this.val$receiptTotalCountDbEntity = pa6b2262cVar;
    }

    public static androidx.room.EntityInsertionAdapter BcgXtAciIrhvDyPk(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m0dc0a6ea(paf462909Var);
    }

    public static void FUdGavUBXezWllrQ(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase GKyjlnVnxMZWvHWy(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void ONqnDJPcfmGPshuv(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase PeQGVoLnNxiiqBRS(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void RgFqSoBXSEyKuykG(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void XCCpvHIIfjtsTaGl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase LudhhIFGzQJJqkwh(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase OLWbSqGNmyjBhtcW(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit XdtwbLeeQIqzdZYZ(p8d777f38.pd77d5e50.pf0719ea8.paf462909$15 paf462909_15) {
        return paf462909_15.call2();
    }

    public static void XeYTgwbgRlZhMYdy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return xdtwbLeeQIqzdZYZ(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((23 + 20) % 20 > 0) {
        }
        RgFqSoBXSEyKuykG(GKyjlnVnxMZWvHWy(this.this$0));
        try {
            FUdGavUBXezWllrQ(BcgXtAciIrhvDyPk(this.this$0), this.val$receiptTotalCountDbEntity);
            ONqnDJPcfmGPshuv(oLWbSqGNmyjBhtcW(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            XCCpvHIIfjtsTaGl(PeQGVoLnNxiiqBRS(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            xeYTgwbgRlZhMYdy(ludhhIFGzQJJqkwh(this.this$0));
            throw th;
        }
    }
}

