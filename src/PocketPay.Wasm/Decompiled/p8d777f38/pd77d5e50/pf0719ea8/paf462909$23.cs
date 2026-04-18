namespace WillowMaze.Wasm.Decompiled;


class paf462909$23 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly java.util.List val$paybackReceiptsDbEntityList;

    paf462909$23(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, java.util.List list) {
        this.this$0 = paf462909Var;
        this.val$paybackReceiptsDbEntityList = list;
    }

    public static void CrWHldgWkLywUiOX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase JfYKzXZnEjFrmgZw(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase MLcBUMGKhsKfydsz(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit ATLIZEMnOvSkArEH(p8d777f38.pd77d5e50.pf0719ea8.paf462909$23 paf462909_23) {
        return paf462909_23.call2();
    }

    public static void CNBTjHeuuukNjddE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void EeKPyRrZGcEfLBdo(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase NovHyqHLszFNcvMY(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase ULZxheyEOsApUPYN(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter XEIkwuGawxtxWdjM(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.ma5940f5e(paf462909Var);
    }

    public static void XobukhwCgpbztbyd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int YKTonmTwXtNsXRAk(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.IEnumerable iterable) {
        return entityDeletionOrUpdateAdapter.handleMultiple(iterable);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return aTLIZEMnOvSkArEH(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((12 + 6) % 6 > 0) {
        }
        cNBTjHeuuukNjddE(JfYKzXZnEjFrmgZw(this.this$0));
        try {
            yKTonmTwXtNsXRAk(xEIkwuGawxtxWdjM(this.this$0), this.val$paybackReceiptsDbEntityList);
            CrWHldgWkLywUiOX(MLcBUMGKhsKfydsz(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            eeKPyRrZGcEfLBdo(novHyqHLszFNcvMY(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            xobukhwCgpbztbyd(uLZxheyEOsApUPYN(this.this$0));
            throw th;
        }
    }
}

