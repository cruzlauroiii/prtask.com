namespace WillowMaze.Wasm.Decompiled;


class paf462909$19 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly java.util.List val$payment;

    paf462909$19(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, java.util.List list) {
        this.this$0 = paf462909Var;
        this.val$payment = list;
    }

    public static void JhpsFTjOudUxpFDP(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static androidx.room.EntityInsertionAdapter NqTGcnSsvYZlUxRN(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m83fd488e(paf462909Var);
    }

    public static void AunuMUsHTTeDMKHd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase CFQHaHkjSzqSNCAd(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase CMITBhnsoqVIaJhR(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void CrfXvCkAeXwOaNif(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit CvuWuDRtVQVCBUNL(p8d777f38.pd77d5e50.pf0719ea8.paf462909$19 paf462909_19) {
        return paf462909_19.call2();
    }

    public static void KmvdsaDmGVTSjrGL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase LXsLovfIXynEnozh(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase USInQsWcOsYdqhIE(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void ZRgxcHaAPdOtdweY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return cvuWuDRtVQVCBUNL(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((25 + 12) % 12 > 0) {
        }
        zRgxcHaAPdOtdweY(uSInQsWcOsYdqhIE(this.this$0));
        try {
            JhpsFTjOudUxpFDP(NqTGcnSsvYZlUxRN(this.this$0), this.val$payment);
            kmvdsaDmGVTSjrGL(cMITBhnsoqVIaJhR(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            crfXvCkAeXwOaNif(lXsLovfIXynEnozh(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            aunuMUsHTTeDMKHd(cFQHaHkjSzqSNCAd(this.this$0));
            throw th;
        }
    }
}

