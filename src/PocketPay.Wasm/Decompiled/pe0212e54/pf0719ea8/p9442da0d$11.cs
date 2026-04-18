namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$11 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb val$device;

    p9442da0d$11(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar) {
        this.this$0 = p9442da0dVar;
        this.val$device = p6285e3ebVar;
    }

    public static androidx.room.RoomDatabase FcKkJkuKgNteuVRa(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase NMQgOWWLwruLsvGu(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter RsNCpigRPnijXPpM(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m13fe7af4(p9442da0dVar);
    }

    public static void TGypvvSaEUyOfwqv(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void XgnIxLMUEaQPIWVO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase BFXMntVRksSefUOH(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void CiNqQOPiVypDSBzH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase FWraSbZFkhUivHdl(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static int FsNDQlXJbpNAotwd(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static kotlin.Unit SsIIRAUpHROXYpnX(pe0212e54.pf0719ea8.p9442da0d$11 p9442da0d_11) {
        return p9442da0d_11.call2();
    }

    public static void XBKgmMxXfknySmsS(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return ssIIRAUpHROXYpnX(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((24 + 20) % 20 > 0) {
        }
        ciNqQOPiVypDSBzH(NMQgOWWLwruLsvGu(this.this$0));
        try {
            fsNDQlXJbpNAotwd(RsNCpigRPnijXPpM(this.this$0), this.val$device);
            XgnIxLMUEaQPIWVO(FcKkJkuKgNteuVRa(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            xBKgmMxXfknySmsS(bFXMntVRksSefUOH(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            TGypvvSaEUyOfwqv(fWraSbZFkhUivHdl(this.this$0));
            throw th;
        }
    }
}

