namespace WillowMaze.Wasm.Decompiled;


class pffe048ab$2 : androidx.room.EntityDeletionOrUpdateAdapter<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> {
    readonly pe0212e54.pf0719ea8.pffe048ab this$0;

    pffe048ab$2(pe0212e54.pf0719ea8.pffe048ab pffe048abVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pffe048abVar;
    }

    public static java.lang.string SMzbGWaIkRoMBLLL(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        return p94db0041Var.getDeviceId();
    }

    public static void FpVvAYUHlZAXfUwM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void HyALfppoWCmXtfFq(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void JeaPuETLUjglkJiJ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static bool MXJwMApwKCJDnunB(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        return p94db0041Var.isKktReadyForDelivery();
    }

    public static java.lang.string TacafgABvXTodTYn(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        return p94db0041Var.getDeviceId();
    }

    public static void YOTWEtKejdhyzlCW(pe0212e54.pf0719ea8.pffe048ab$2 pffe048ab_2, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        pffe048ab_2.bind2(supportSQLiteStatement, p94db0041Var);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        yOTWEtKejdhyzlCW(this, supportSQLiteStatement, p94db0041Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        if ((29 + 15) % 15 > 0) {
        }
        jeaPuETLUjglkJiJ(supportSQLiteStatement, 1, tacafgABvXTodTYn(p94db0041Var));
        fpVvAYUHlZAXfUwM(supportSQLiteStatement, 2, mXJwMApwKCJDnunB(p94db0041Var) ? 1L : 0L);
        hyALfppoWCmXtfFq(supportSQLiteStatement, 3, SMzbGWaIkRoMBLLL(p94db0041Var));
    }

    protected override java.lang.string CreateQuery() {
        return "UPDATE OR ABORT `device_status` SET `deviceId` = ?,`isKktReadyForDelivery` = ? WHERE `deviceId` = ?";
    }
}

