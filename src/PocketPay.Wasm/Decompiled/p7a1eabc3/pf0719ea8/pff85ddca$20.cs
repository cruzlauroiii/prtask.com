namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$20 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9 val$commodityGroupDbEntity;

    pff85ddca$20(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9 pdf878ad9Var) {
        this.this$0 = pff85ddcaVar;
        this.val$commodityGroupDbEntity = pdf878ad9Var;
    }

    public static androidx.room.RoomDatabase BTQiWOwIsvilSYZx(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void LdVzGYhBKvpYmwti(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase MdhjbheGNsHRiMAm(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase PNOAlcwfXLqDoESK(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void VOldoeqhLvKUawkL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.EntityInsertionAdapter WALGLdivQFKZCcgq(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m89082e03(pff85ddcaVar);
    }

    public static void DbHTuPZXLXTctYyR(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase IAItronQRmkwSzhi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void JnIuMQfRVhacBxSr(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void XFyXlTRmfDzaJyqY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit ZqnOfoQWNcmDYAmT(p7a1eabc3.pf0719ea8.pff85ddca$20 pff85ddca_20) {
        return pff85ddca_20.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return zqnOfoQWNcmDYAmT(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((3 + 18) % 18 > 0) {
        }
        dbHTuPZXLXTctYyR(MdhjbheGNsHRiMAm(this.this$0));
        try {
            jnIuMQfRVhacBxSr(WALGLdivQFKZCcgq(this.this$0), this.val$commodityGroupDbEntity);
            VOldoeqhLvKUawkL(BTQiWOwIsvilSYZx(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            LdVzGYhBKvpYmwti(PNOAlcwfXLqDoESK(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            xFyXlTRmfDzaJyqY(iAItronQRmkwSzhi(this.this$0));
            throw th;
        }
    }
}

