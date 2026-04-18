namespace WillowMaze.Wasm.Decompiled;


class p8572d174$10 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly p0c985ebf.p07214c67.pd77d5e50.p1aa865ba val$currentInspectionPositionDbEntity;

    p8572d174$10(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        this.this$0 = p8572d174Var;
        this.val$currentInspectionPositionDbEntity = p1aa865baVar;
    }

    public static androidx.room.RoomDatabase AbBMiZPbQlRVpQIL(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase CkQsEucXKgBwsUFv(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void DOVTBWkHEjhvvtll(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void FORIDEBSKisdYoEW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase HdPtNMLbKPBuZruK(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static int DRoULPIxBiZdPVwd(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static androidx.room.RoomDatabase ENMennVffmzKzKya(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void OEQBWInKFwHHDHDh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void QnoHUbXDVsMJUiaA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static kotlin.Unit WycHdsoMhrJgqJLp(p0c985ebf.pf0719ea8.p8572d174$10 p8572d174_10) {
        return p8572d174_10.call2();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter XPxBfZVTUVeSrAWv(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m429f062d(p8572d174Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return wycHdsoMhrJgqJLp(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((11 + 5) % 5 > 0) {
        }
        DOVTBWkHEjhvvtll(HdPtNMLbKPBuZruK(this.this$0));
        try {
            dRoULPIxBiZdPVwd(xPxBfZVTUVeSrAWv(this.this$0), this.val$currentInspectionPositionDbEntity);
            qnoHUbXDVsMJUiaA(CkQsEucXKgBwsUFv(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            FORIDEBSKisdYoEW(eNMennVffmzKzKya(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            oEQBWInKFwHHDHDh(AbBMiZPbQlRVpQIL(this.this$0));
            throw th;
        }
    }
}

