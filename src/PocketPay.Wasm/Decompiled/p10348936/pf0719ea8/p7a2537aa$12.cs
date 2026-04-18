namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$12 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly p10348936.pf5e638cc.pd77d5e50.p12e406c7 val$inventorizationDbEntity;

    p7a2537aa$12(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        this.this$0 = p7a2537aaVar;
        this.val$inventorizationDbEntity = p12e406c7Var;
    }

    public static void AsHnbGqdADJJxJGY(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void EGiujDrmYRZITXBF(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void EnXfkuPOxaExNTBu(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void GurUFikRvYUMVKbd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase GuwPmkfuiPBEqqIt(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase JWlkjQJhaeOfaCnj(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.EntityInsertionAdapter QiJjdWYFsZfvUjZT(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m13fe7af4(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase VEYmrVtLbqPJyLwE(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static kotlin.Unit XgonpGpfRexiybFG(p10348936.pf0719ea8.p7a2537aa$12 p7a2537aa_12) {
        return p7a2537aa_12.call2();
    }

    public static void VdrmnGKLLtBMofOk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase ZcmuCtHIwkUKKzGw(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return XgonpGpfRexiybFG(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((30 + 10) % 10 > 0) {
        }
        EnXfkuPOxaExNTBu(GuwPmkfuiPBEqqIt(this.this$0));
        try {
            AsHnbGqdADJJxJGY(QiJjdWYFsZfvUjZT(this.this$0), this.val$inventorizationDbEntity);
            vdrmnGKLLtBMofOk(zcmuCtHIwkUKKzGw(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            GurUFikRvYUMVKbd(JWlkjQJhaeOfaCnj(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            EGiujDrmYRZITXBF(VEYmrVtLbqPJyLwE(this.this$0));
            throw th;
        }
    }
}

