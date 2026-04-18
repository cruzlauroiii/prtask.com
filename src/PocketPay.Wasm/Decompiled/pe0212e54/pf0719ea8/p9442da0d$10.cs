namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$10 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly java.util.List val$devices;

    p9442da0d$10(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.util.List list) {
        this.this$0 = p9442da0dVar;
        this.val$devices = list;
    }

    public static void FOVMdTUVsaxfLWRl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.EntityInsertionAdapter GXRuuDvNnzJyhMYu(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m429f062d(p9442da0dVar);
    }

    public static void JfEgUlVMdNcavIlz(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit NEJduYmXTSUnqoLK(pe0212e54.pf0719ea8.p9442da0d$10 p9442da0d_10) {
        return p9442da0d_10.call2();
    }

    public static void QolaQDiEPqcfSjIl(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static androidx.room.RoomDatabase UTEWpNzlfgYKAdJO(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase WnODVUhWIDtbJfgp(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase YyKVzpYpOVnDeKAk(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void FNKGaunalAgEpwrm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase HAIxiTfDHKhYfmuo(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void QVzYkROUCbePnIel(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return NEJduYmXTSUnqoLK(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((12 + 10) % 10 > 0) {
        }
        qVzYkROUCbePnIel(hAIxiTfDHKhYfmuo(this.this$0));
        try {
            QolaQDiEPqcfSjIl(GXRuuDvNnzJyhMYu(this.this$0), this.val$devices);
            FOVMdTUVsaxfLWRl(YyKVzpYpOVnDeKAk(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            JfEgUlVMdNcavIlz(UTEWpNzlfgYKAdJO(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            fNKGaunalAgEpwrm(WnODVUhWIDtbJfgp(this.this$0));
            throw th;
        }
    }
}

