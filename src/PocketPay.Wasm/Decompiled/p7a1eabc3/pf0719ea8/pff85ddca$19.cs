namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$19 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly p7a1eabc3.p07214c67.pd77d5e50.p821c9e21 val$commodityDbEntity;

    pff85ddca$19(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, p7a1eabc3.p07214c67.pd77d5e50.p821c9e21 p821c9e21Var) {
        this.this$0 = pff85ddcaVar;
        this.val$commodityDbEntity = p821c9e21Var;
    }

    public static void ELAwEvRxyQcwvlbw(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit EsCoWeXtlodtzMYx(p7a1eabc3.pf0719ea8.pff85ddca$19 pff85ddca_19) {
        return pff85ddca_19.call2();
    }

    public static androidx.room.RoomDatabase KEplKZrONPZdTGoq(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase LFDRXBKICqqvXATw(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void PALusYXMnRxAFuAG(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void PzbvtGoJGILvJiOm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase AiSfKXbTXubpMWBE(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase KwtbxtHjucKbQoSY(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void LMMobrlLNHZYDfQQ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void PSDcuERvDgZIMRvS(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.EntityInsertionAdapter PrcnMyLHuLXLFnUo(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mbbeb9b46(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return EsCoWeXtlodtzMYx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((30 + 21) % 21 > 0) {
        }
        PzbvtGoJGILvJiOm(KEplKZrONPZdTGoq(this.this$0));
        try {
            PALusYXMnRxAFuAG(prcnMyLHuLXLFnUo(this.this$0), this.val$commodityDbEntity);
            lMMobrlLNHZYDfQQ(aiSfKXbTXubpMWBE(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            ELAwEvRxyQcwvlbw(LFDRXBKICqqvXATw(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            pSDcuERvDgZIMRvS(kwtbxtHjucKbQoSY(this.this$0));
            throw th;
        }
    }
}

