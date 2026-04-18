namespace WillowMaze.Wasm.Decompiled;


class paf462909$17 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.pa2839366 val$paybackReceiptDbEntity;

    paf462909$17(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.pa2839366 pa2839366Var) {
        this.this$0 = paf462909Var;
        this.val$paybackReceiptDbEntity = pa2839366Var;
    }

    public static androidx.room.RoomDatabase CLIsxmEKZvvOrxyR(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.EntityInsertionAdapter UcxDZeWImiqHFNQh(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.mebdbf394(paf462909Var);
    }

    public static void ZYrzayveqXMsmfLX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit FemEpyrqhaucwuZb(p8d777f38.pd77d5e50.pf0719ea8.paf462909$17 paf462909_17) {
        return paf462909_17.call2();
    }

    public static void GANrRMMOewgnzmQL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HDhTychOxgGkhsbe(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase SfBRTYWxbhZjufcG(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase TBVjKdDhEgaWQmjx(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void TTODryyaWowdNWBG(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void XUMwixkhvWQKalum(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase YZutAHPlCALYDTHa(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return femEpyrqhaucwuZb(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((14 + 32) % 32 > 0) {
        }
        hDhTychOxgGkhsbe(sfBRTYWxbhZjufcG(this.this$0));
        try {
            xUMwixkhvWQKalum(UcxDZeWImiqHFNQh(this.this$0), this.val$paybackReceiptDbEntity);
            tTODryyaWowdNWBG(tBVjKdDhEgaWQmjx(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            gANrRMMOewgnzmQL(yZutAHPlCALYDTHa(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            ZYrzayveqXMsmfLX(CLIsxmEKZvvOrxyR(this.this$0));
            throw th;
        }
    }
}

