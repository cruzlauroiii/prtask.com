namespace WillowMaze.Wasm.Decompiled;


class paf462909$16 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.p36ac2c8d val$sellReceiptDbEntity;

    paf462909$16(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.p36ac2c8d p36ac2c8dVar) {
        this.this$0 = paf462909Var;
        this.val$sellReceiptDbEntity = p36ac2c8dVar;
    }

    public static androidx.room.RoomDatabase DTMdGzvflwUUTkTV(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.EntityInsertionAdapter HVLMolZwCAjZnFtS(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m74674bbd(paf462909Var);
    }

    public static androidx.room.RoomDatabase JuNhKqAuyrywceSV(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void SYNyUqhJskArHcPT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static kotlin.Unit BGofOxSDvERhQksg(p8d777f38.pd77d5e50.pf0719ea8.paf462909$16 paf462909_16) {
        return paf462909_16.call2();
    }

    public static androidx.room.RoomDatabase CJjbopYhTfasKzdV(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase DQluvabuvtGGgkRv(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void FddEfSKJPpcWUZlt(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HVpgXqMWNeVnDSmz(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void IbsOCMlvcvhrslHl(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void TFxcebWYIyknewCg(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return bGofOxSDvERhQksg(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((2 + 31) % 31 > 0) {
        }
        tFxcebWYIyknewCg(dQluvabuvtGGgkRv(this.this$0));
        try {
            ibsOCMlvcvhrslHl(HVLMolZwCAjZnFtS(this.this$0), this.val$sellReceiptDbEntity);
            SYNyUqhJskArHcPT(DTMdGzvflwUUTkTV(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            hVpgXqMWNeVnDSmz(JuNhKqAuyrywceSV(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            fddEfSKJPpcWUZlt(cJjbopYhTfasKzdV(this.this$0));
            throw th;
        }
    }
}

