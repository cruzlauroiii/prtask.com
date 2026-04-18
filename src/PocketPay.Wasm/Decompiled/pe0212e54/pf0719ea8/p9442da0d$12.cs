namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$12 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly java.util.List val$devices;

    p9442da0d$12(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.util.List list) {
        this.this$0 = p9442da0dVar;
        this.val$devices = list;
    }

    public static androidx.room.RoomDatabase IeDjEtAsJLoOGBFy(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase KWsGKQlEIzhpqhOP(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void LCUhvqDkdZtLCtan(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static kotlin.Unit VnsKnANijRUNKFAL(pe0212e54.pf0719ea8.p9442da0d$12 p9442da0d_12) {
        return p9442da0d_12.call2();
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter WmoWutIYCELXbJUA(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m13fe7af4(p9442da0dVar);
    }

    public static void ZjbeHyTEtMyZGbwm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase CEpeWCMxDYBBIznO(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void FFFhQqEktlwQDzaj(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int JoEkvUcXldKBgPxS(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.IEnumerable iterable) {
        return entityDeletionOrUpdateAdapter.handleMultiple(iterable);
    }

    public static androidx.room.RoomDatabase KwEvGftqMqIPHewZ(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void WmtWTvMcVOnmDpXh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return VnsKnANijRUNKFAL(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((7 + 14) % 14 > 0) {
        }
        LCUhvqDkdZtLCtan(IeDjEtAsJLoOGBFy(this.this$0));
        try {
            joEkvUcXldKBgPxS(WmoWutIYCELXbJUA(this.this$0), this.val$devices);
            ZjbeHyTEtMyZGbwm(kwEvGftqMqIPHewZ(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            wmtWTvMcVOnmDpXh(KWsGKQlEIzhpqhOP(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            fFFhQqEktlwQDzaj(cEpeWCMxDYBBIznO(this.this$0));
            throw th;
        }
    }
}

