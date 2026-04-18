namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$14 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly java.lang.string val$deviceId;

    p9442da0d$14(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        this.this$0 = p9442da0dVar;
        this.val$deviceId = str;
    }

    public static void AlRAvbcGHDUFjpBs(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement EtnEEdTylqeQkGVq(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m74674bbd(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement EzUizmPcTvsvYsFs(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m74674bbd(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase IIXrqefcTwnxYFFG(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement CmbPbVnABvhRgaXB(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m74674bbd(p9442da0dVar);
    }

    public static void CrinrWfpdzHnteHe(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void GwlJehSDkHgVrTds(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase HGcFDmjztNuyXjqO(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void NgpZoDZnGAGJPfab(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static int OcVruXgkZKyqNuih(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement OnhNcAtjzKKJIdKU(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static kotlin.Unit VWVsgRaRiooNtzYa(pe0212e54.pf0719ea8.p9442da0d$14 p9442da0d_14) {
        return p9442da0d_14.call2();
    }

    public static androidx.room.RoomDatabase VvYHNGcaFPBWigYX(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void XZPrGdImOqyEiAAO(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase YRDwUrgEGTcIbnJP(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void YwXNgPlHomzMbkwz(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void ZmyrtnIKVLluVwyb(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return vWVsgRaRiooNtzYa(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((7 + 2) % 2 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementOnhNcAtjzKKJIdKU = onhNcAtjzKKJIdKU(EtnEEdTylqeQkGVq(this.this$0));
        crinrWfpdzHnteHe(supportSQLiteStatementOnhNcAtjzKKJIdKU, 1, this.val$deviceId);
        try {
            ngpZoDZnGAGJPfab(hGcFDmjztNuyXjqO(this.this$0));
            try {
                ocVruXgkZKyqNuih(supportSQLiteStatementOnhNcAtjzKKJIdKU);
                zmyrtnIKVLluVwyb(IIXrqefcTwnxYFFG(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                gwlJehSDkHgVrTds(vvYHNGcaFPBWigYX(this.this$0));
                ywXNgPlHomzMbkwz(cmbPbVnABvhRgaXB(this.this$0), supportSQLiteStatementOnhNcAtjzKKJIdKU);
                return unit;
            } catch (java.lang.Exception th) {
                AlRAvbcGHDUFjpBs(yRDwUrgEGTcIbnJP(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            xZPrGdImOqyEiAAO(EzUizmPcTvsvYsFs(this.this$0), supportSQLiteStatementOnhNcAtjzKKJIdKU);
            throw th2;
        }
    }
}

