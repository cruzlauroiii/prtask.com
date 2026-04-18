namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$11 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly java.util.List val$inventorizationPositionDbEntities;

    p7a2537aa$11(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.util.List list) {
        this.this$0 = p7a2537aaVar;
        this.val$inventorizationPositionDbEntities = list;
    }

    public static androidx.room.RoomDatabase MVJIycUnvtFpncGP(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase YqHHeROgURxKRDzJ(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase DLYpWHxEYGaakGlG(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void ErEyWsWCDYkwMZTT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static kotlin.Unit IsRJgAgpBqkRVGWJ(p10348936.pf0719ea8.p7a2537aa$11 p7a2537aa_11) {
        return p7a2537aa_11.call2();
    }

    public static void KHNRPprqkMuZsdOV(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.EntityInsertionAdapter MwcNqYSXEtwpbCIS(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m429f062d(p7a2537aaVar);
    }

    public static void OrxfzBUDAOPCWNVI(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static void RnSompyqJIfODxRm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void SWtpbTObTjVRtOjZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase YbgjXAdGVEgDjpDi(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return isRJgAgpBqkRVGWJ(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((30 + 4) % 4 > 0) {
        }
        erEyWsWCDYkwMZTT(dLYpWHxEYGaakGlG(this.this$0));
        try {
            orxfzBUDAOPCWNVI(mwcNqYSXEtwpbCIS(this.this$0), this.val$inventorizationPositionDbEntities);
            sWtpbTObTjVRtOjZ(ybgjXAdGVEgDjpDi(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            rnSompyqJIfODxRm(YqHHeROgURxKRDzJ(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            kHNRPprqkMuZsdOV(MVJIycUnvtFpncGP(this.this$0));
            throw th;
        }
    }
}

