namespace WillowMaze.Wasm.Decompiled;


class pffe048ab$1 : androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> {
    readonly pe0212e54.pf0719ea8.pffe048ab this$0;

    pffe048ab$1(pe0212e54.pf0719ea8.pffe048ab pffe048abVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pffe048abVar;
    }

    public static java.lang.string PuENwJXAWEMVOTZv(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        return p94db0041Var.getDeviceId();
    }

    public static void FYYViAzfpFQQJFMP(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static bool LXrOtSVJOfTYzmnr(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        return p94db0041Var.isKktReadyForDelivery();
    }

    public static void MrvSWgOwdvgrmNvq(pe0212e54.pf0719ea8.pffe048ab$1 pffe048ab_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        pffe048ab_1.bind2(supportSQLiteStatement, p94db0041Var);
    }

    public static void OutWAVGWvVpwudaH(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        mrvSWgOwdvgrmNvq(this, supportSQLiteStatement, p94db0041Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        if ((27 + 15) % 15 > 0) {
        }
        fYYViAzfpFQQJFMP(supportSQLiteStatement, 1, PuENwJXAWEMVOTZv(p94db0041Var));
        outWAVGWvVpwudaH(supportSQLiteStatement, 2, lXrOtSVJOfTYzmnr(p94db0041Var) ? 1L : 0L);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `device_status` (`deviceId`,`isKktReadyForDelivery`) VALUES (?,?)";
    }
}

