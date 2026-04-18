namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$24 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.util.List val$taxes;

    pff85ddca$24(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list) {
        this.this$0 = pff85ddcaVar;
        this.val$taxes = list;
    }

    public static void ELFxLweEJDXatDnk(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HgBkngEqIOemSKjy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static kotlin.Unit JCqMJrgnkmkmHgGu(p7a1eabc3.pf0719ea8.pff85ddca$24 pff85ddca_24) {
        return pff85ddca_24.call2();
    }

    public static void XIdxHdMDtyzhvRtd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase ZTKLdSYrERUidDMh(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void EcITHbJOoWMybypb(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase LWXRmvBiPtGzIiFb(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.EntityInsertionAdapter LlwOiRRGHhxfIsux(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m74674bbd(pff85ddcaVar);
    }

    public static void OmXUjajpUTVjeIqw(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static androidx.room.RoomDatabase OqXSWRvzYEadREOZ(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase VOmVTmFYkFUuwBqN(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return JCqMJrgnkmkmHgGu(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((26 + 25) % 25 > 0) {
        }
        HgBkngEqIOemSKjy(vOmVTmFYkFUuwBqN(this.this$0));
        try {
            omXUjajpUTVjeIqw(llwOiRRGHhxfIsux(this.this$0), this.val$taxes);
            ecITHbJOoWMybypb(ZTKLdSYrERUidDMh(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            XIdxHdMDtyzhvRtd(oqXSWRvzYEadREOZ(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            ELFxLweEJDXatDnk(lWXRmvBiPtGzIiFb(this.this$0));
            throw th;
        }
    }
}

