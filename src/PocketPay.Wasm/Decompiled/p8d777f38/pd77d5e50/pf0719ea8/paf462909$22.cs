namespace WillowMaze.Wasm.Decompiled;


class paf462909$22 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly java.util.List val$sellReceiptDbEntityList;

    paf462909$22(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, java.util.List list) {
        this.this$0 = paf462909Var;
        this.val$sellReceiptDbEntityList = list;
    }

    public static kotlin.Unit BezlvVXpEWERVOnO(p8d777f38.pd77d5e50.pf0719ea8.paf462909$22 paf462909_22) {
        return paf462909_22.call2();
    }

    public static void HiPrYTwGpQhsuQCj(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int IbFPKyJItvadfuYb(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.IEnumerable iterable) {
        return entityDeletionOrUpdateAdapter.handleMultiple(iterable);
    }

    public static void JxPgyrInVqALciyz(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter RqKmxWXsOiJzHIoe(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.mc7321d99(paf462909Var);
    }

    public static androidx.room.RoomDatabase DzSEnQoSiXQQzAoi(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase LosuYNdQJKgziZmp(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase LxqCWfgStTZYvKZu(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void NRBIWuhwnXOBDHaH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase WttfGSUyNeuSCslK(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void XuJaBMThEsQsSxMW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return BezlvVXpEWERVOnO(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((8 + 1) % 1 > 0) {
        }
        xuJaBMThEsQsSxMW(losuYNdQJKgziZmp(this.this$0));
        try {
            IbFPKyJItvadfuYb(RqKmxWXsOiJzHIoe(this.this$0), this.val$sellReceiptDbEntityList);
            nRBIWuhwnXOBDHaH(wttfGSUyNeuSCslK(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            HiPrYTwGpQhsuQCj(lxqCWfgStTZYvKZu(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            JxPgyrInVqALciyz(dzSEnQoSiXQQzAoi(this.this$0));
            throw th;
        }
    }
}

