namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$13 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;

    p9442da0d$13(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        this.this$0 = p9442da0dVar;
    }

    public static androidx.room.SharedSQLiteStatement CwZkNdXvcNKdGSwY(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m0dc0a6ea(p9442da0dVar);
    }

    public static void FPiueybmPajyhxME(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase KXXwCprzqytHtPPq(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase MsSaNKXPUjRPKyvy(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase OPZZiUhnIegaOYAd(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void OdziWDYqODwAKfpD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement PxPEGFgjhFYhyIYH(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m0dc0a6ea(p9442da0dVar);
    }

    public static void QSnHGVJVvhqrVsgA(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void RLQiCeyfzXylhvLZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void WlyfOiJVLfzvZwnP(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void XIHcARJXidcoldbq(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static int YaVBdzEVZtrVgNIU(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.room.RoomDatabase ZnvUECrZHVJlBRft(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement AlmwDfxZYXPiplGu(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m0dc0a6ea(p9442da0dVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement EgWueEtccDKVluDU(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static kotlin.Unit JYpPqDofHOspPdFw(pe0212e54.pf0719ea8.p9442da0d$13 p9442da0d_13) {
        return p9442da0d_13.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return jYpPqDofHOspPdFw(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((20 + 27) % 27 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementEgWueEtccDKVluDU = egWueEtccDKVluDU(PxPEGFgjhFYhyIYH(this.this$0));
        try {
            RLQiCeyfzXylhvLZ(MsSaNKXPUjRPKyvy(this.this$0));
            try {
                YaVBdzEVZtrVgNIU(supportSQLiteStatementEgWueEtccDKVluDU);
                WlyfOiJVLfzvZwnP(ZnvUECrZHVJlBRft(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                XIHcARJXidcoldbq(OPZZiUhnIegaOYAd(this.this$0));
                QSnHGVJVvhqrVsgA(CwZkNdXvcNKdGSwY(this.this$0), supportSQLiteStatementEgWueEtccDKVluDU);
                return unit;
            } catch (java.lang.Exception th) {
                OdziWDYqODwAKfpD(KXXwCprzqytHtPPq(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            FPiueybmPajyhxME(almwDfxZYXPiplGu(this.this$0), supportSQLiteStatementEgWueEtccDKVluDU);
            throw th2;
        }
    }
}

