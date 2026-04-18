namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$23 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.util.List val$measures;

    pff85ddca$23(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list) {
        this.this$0 = pff85ddcaVar;
        this.val$measures = list;
    }

    public static void IfsqQUmfHeMWULhD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.EntityInsertionAdapter KeZZxwYDqdeGkfit(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m0dc0a6ea(pff85ddcaVar);
    }

    public static void QeTbJtKKTtEfouWg(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit XXCTlQDlmzmRnqXI(p7a1eabc3.pf0719ea8.pff85ddca$23 pff85ddca_23) {
        return pff85ddca_23.call2();
    }

    public static androidx.room.RoomDatabase YcgGmWMAQAkflhle(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void FHlDKdCfHpYsFNxX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void FJbQHvOjVRbIpLFV(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static void LdCxAkJOvmqoQxRG(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase POYCMHEwzmOLuTaB(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase WHeMqunBqsqWbEHa(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase ZieqPBgebjLXuorY(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return XXCTlQDlmzmRnqXI(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((11 + 29) % 29 > 0) {
        }
        IfsqQUmfHeMWULhD(YcgGmWMAQAkflhle(this.this$0));
        try {
            fJbQHvOjVRbIpLFV(KeZZxwYDqdeGkfit(this.this$0), this.val$measures);
            fHlDKdCfHpYsFNxX(wHeMqunBqsqWbEHa(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            ldCxAkJOvmqoQxRG(zieqPBgebjLXuorY(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            QeTbJtKKTtEfouWg(pOYCMHEwzmOLuTaB(this.this$0));
            throw th;
        }
    }
}

