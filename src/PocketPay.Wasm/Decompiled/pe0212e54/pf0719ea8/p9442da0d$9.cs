namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$9 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb val$device;

    p9442da0d$9(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar) {
        this.this$0 = p9442da0dVar;
        this.val$device = p6285e3ebVar;
    }

    public static kotlin.Unit AVWyAIvGsmsCNkXZ(pe0212e54.pf0719ea8.p9442da0d$9 p9442da0d_9) {
        return p9442da0d_9.call2();
    }

    public static androidx.room.EntityInsertionAdapter BLRsItYpsflUHIfC(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m89082e03(p9442da0dVar);
    }

    public static void EwTuFRUvIiWKfQGl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void RaCiKZNGTWbSylsX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase TEBwFhIuRJawPjzI(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase TKkLyuOlPtItAOiw(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase ZJSAduZqHCdzuFLa(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void AhevrhedfETnHMaJ(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase MMeRSxodcHAHKGLs(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void RueJJXRcEMtuwZzV(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void ZzaYcJMdPLGtsJSY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return AVWyAIvGsmsCNkXZ(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((12 + 21) % 21 > 0) {
        }
        EwTuFRUvIiWKfQGl(TKkLyuOlPtItAOiw(this.this$0));
        try {
            ahevrhedfETnHMaJ(BLRsItYpsflUHIfC(this.this$0), this.val$device);
            zzaYcJMdPLGtsJSY(mMeRSxodcHAHKGLs(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            RaCiKZNGTWbSylsX(ZJSAduZqHCdzuFLa(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            rueJJXRcEMtuwZzV(TEBwFhIuRJawPjzI(this.this$0));
            throw th;
        }
    }
}

