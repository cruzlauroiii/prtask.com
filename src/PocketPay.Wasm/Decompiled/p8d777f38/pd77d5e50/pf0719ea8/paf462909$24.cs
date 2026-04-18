namespace WillowMaze.Wasm.Decompiled;


class paf462909$24 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd val$payment;

    paf462909$24(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd pe8fa6fcdVar) {
        this.this$0 = paf462909Var;
        this.val$payment = pe8fa6fcdVar;
    }

    public static kotlin.Unit CnJNcprcdHwJXNhQ(p8d777f38.pd77d5e50.pf0719ea8.paf462909$24 paf462909_24) {
        return paf462909_24.call2();
    }

    public static int GYkeNkayDQznZEfp(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static void KhApCVGrGzqqExPH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase QUjhIOSaYCmYfPSe(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase VOvcRXcrfTmyBuRz(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void BVBjLnFDQSAQMGho(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter MKwruPswieTpvAuz(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m1740fbc7(paf462909Var);
    }

    public static void SBYQYGNGWrnKrCUF(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase TfgmhfMuZrqFwngb(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void VcjllKalJQXsWZbr(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase WpZUpPBNQvCZDpWJ(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return CnJNcprcdHwJXNhQ(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((27 + 31) % 31 > 0) {
        }
        vcjllKalJQXsWZbr(QUjhIOSaYCmYfPSe(this.this$0));
        try {
            GYkeNkayDQznZEfp(mKwruPswieTpvAuz(this.this$0), this.val$payment);
            KhApCVGrGzqqExPH(tfgmhfMuZrqFwngb(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            bVBjLnFDQSAQMGho(VOvcRXcrfTmyBuRz(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            sBYQYGNGWrnKrCUF(wpZUpPBNQvCZDpWJ(this.this$0));
            throw th;
        }
    }
}

