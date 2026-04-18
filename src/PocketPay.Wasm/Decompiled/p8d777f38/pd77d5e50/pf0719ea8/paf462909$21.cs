namespace WillowMaze.Wasm.Decompiled;


class paf462909$21 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly pad5f82e8.p07214c67.pd77d5e50.p25a7e996 val$queueReceiptDbEntity;

    paf462909$21(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        this.this$0 = paf462909Var;
        this.val$queueReceiptDbEntity = p25a7e996Var;
    }

    public static void BfvNbnHQVDuLlFgd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter CKLNqYdEonAYoqMz(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.mcdc7972c(paf462909Var);
    }

    public static androidx.room.RoomDatabase CehLyIsapmojaYXn(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void MqxxwblzaiwjcXcl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void YTCcwSBnrLpmkQKT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase BemDQLynZImMIsWL(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase IZOMCEAnVaOnPiFX(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static int JypNnOSXqwYzFJDI(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static androidx.room.RoomDatabase MeLeMzibgJmxGniz(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit OiptgwDYbJCQWnwx(p8d777f38.pd77d5e50.pf0719ea8.paf462909$21 paf462909_21) {
        return paf462909_21.call2();
    }

    public static void VdqwODRylpmaAtgR(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return oiptgwDYbJCQWnwx(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((18 + 4) % 4 > 0) {
        }
        MqxxwblzaiwjcXcl(bemDQLynZImMIsWL(this.this$0));
        try {
            jypNnOSXqwYzFJDI(CKLNqYdEonAYoqMz(this.this$0), this.val$queueReceiptDbEntity);
            BfvNbnHQVDuLlFgd(CehLyIsapmojaYXn(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            vdqwODRylpmaAtgR(meLeMzibgJmxGniz(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            YTCcwSBnrLpmkQKT(iZOMCEAnVaOnPiFX(this.this$0));
            throw th;
        }
    }
}

