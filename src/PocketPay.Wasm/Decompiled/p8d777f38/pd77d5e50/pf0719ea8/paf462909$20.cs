namespace WillowMaze.Wasm.Decompiled;


class paf462909$20 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.p25a7e996 val$queueReceiptDbEntity;

    paf462909$20(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        this.this$0 = paf462909Var;
        this.val$queueReceiptDbEntity = p25a7e996Var;
    }

    public static androidx.room.EntityInsertionAdapter HlqCjGRZuvasNFfo(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m5e49d338(paf462909Var);
    }

    public static androidx.room.RoomDatabase JVAretJZiyRwgGjT(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit QZJCvcxyfCvdYtPk(p8d777f38.pd77d5e50.pf0719ea8.paf462909$20 paf462909_20) {
        return paf462909_20.call2();
    }

    public static androidx.room.RoomDatabase YHdRYWxbwxYxcJDt(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase CyIZpwYVQjBsWGMv(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void JhnZnkuKRgknvCEK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void KimtnOmartjIwnPX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void KwhQrhPoezYpInYJ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void OZsqsdnLpfsQgWMj(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase PlMrZEwNLdOkDiWm(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void TMRybWXgBlcZOLiJ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return QZJCvcxyfCvdYtPk(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((17 + 8) % 8 > 0) {
        }
        kimtnOmartjIwnPX(JVAretJZiyRwgGjT(this.this$0));
        try {
            oZsqsdnLpfsQgWMj(HlqCjGRZuvasNFfo(this.this$0), this.val$queueReceiptDbEntity);
            jhnZnkuKRgknvCEK(YHdRYWxbwxYxcJDt(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kwhQrhPoezYpInYJ(cyIZpwYVQjBsWGMv(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            tMRybWXgBlcZOLiJ(plMrZEwNLdOkDiWm(this.this$0));
            throw th;
        }
    }
}

