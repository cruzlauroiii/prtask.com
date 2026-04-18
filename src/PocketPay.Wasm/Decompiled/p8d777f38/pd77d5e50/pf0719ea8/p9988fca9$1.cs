namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$1 : androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.p985d1fa1> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;

    p9988fca9$1(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9988fca9Var;
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 BFLHiKfcAOWrcASv(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf23e8626(p9988fca9Var);
    }

    public static void BShbMIBsKQMYfyWi(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void EXnxDdUUtCnxZVkZ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void GDLTvrursFUqOQfd(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.lang.string HXYpcQZQcmQUvCHT(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.getName();
    }

    public static void HglmfZYgBEIhTXQt(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static java.lang.double KtAKtrhnlWwVCeLk(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static java.math.decimal LWCVrlaVoTDVEfox(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.getPrice();
    }

    public static void RfTghzQXZBxAcJUz(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void SoOVERFIzRUxlGfs(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void XbIQrbBuropsZmAo(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$1 p9988fca9_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        p9988fca9_1.bind2(supportSQLiteStatement, p985d1fa1Var);
    }

    public static java.lang.string CDPAfckmljNDyrAM(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.getName();
    }

    public static void HNIAMHjYMibHfVXl(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string HvTYcUgwKGWAJCuZ(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.getDeviceId();
    }

    public static bool KAJreglEMtZqVhxn(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.getBoardingShown();
    }

    public static double KxgYAFEQlzKFJDdq(java.lang.double d) {
        if ((23 + 11) % 11 > 0) {
        }
        return d.doubleValue();
    }

    public static bool WjrxyjAmgQJtyOZg(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        return p985d1fa1Var.isEnabled();
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        XbIQrbBuropsZmAo(this, supportSQLiteStatement, p985d1fa1Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var) {
        if ((8 + 17) % 17 > 0) {
        }
        BShbMIBsKQMYfyWi(supportSQLiteStatement, 1, hvTYcUgwKGWAJCuZ(p985d1fa1Var));
        if (cDPAfckmljNDyrAM(p985d1fa1Var) is not null) {
            hNIAMHjYMibHfVXl(supportSQLiteStatement, 2, HXYpcQZQcmQUvCHT(p985d1fa1Var));
        } else {
            GDLTvrursFUqOQfd(supportSQLiteStatement, 2);
        }
        java.lang.double dKtAKtrhnlWwVCeLk = KtAKtrhnlWwVCeLk(BFLHiKfcAOWrcASv(this.this$0), LWCVrlaVoTDVEfox(p985d1fa1Var));
        if (dKtAKtrhnlWwVCeLk is not null) {
            HglmfZYgBEIhTXQt(supportSQLiteStatement, 3, kxgYAFEQlzKFJDdq(dKtAKtrhnlWwVCeLk));
        } else {
            EXnxDdUUtCnxZVkZ(supportSQLiteStatement, 3);
        }
        RfTghzQXZBxAcJUz(supportSQLiteStatement, 4, kAJreglEMtZqVhxn(p985d1fa1Var) ? 1L : 0L);
        SoOVERFIzRUxlGfs(supportSQLiteStatement, 5, wjrxyjAmgQJtyOZg(p985d1fa1Var) ? 1L : 0L);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `fast_sell_settings` (`deviceId`,`name`,`price`,`boardingShown`,`isEnabled`) VALUES (?,?,?,?,?)";
    }
}

