namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$3 : androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p12e406c7> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;

    p7a2537aa$3(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p7a2537aaVar;
    }

    public static void DtdNqcmIBuhAfIiL(p10348936.pf0719ea8.p7a2537aa$3 p7a2537aa_3, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        p7a2537aa_3.bind2(supportSQLiteStatement, p12e406c7Var);
    }

    public static void LKsbnDakSldChNHo(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static p10348936.pf5e638cc.p14abd389 ADfxMKGncSvXIMCy(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        return p12e406c7Var.getStatus();
    }

    public static void FGdfiwnLulLPLdOU(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void MkwFULYimwlLCuCZ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string NqxwgIVBmiZWmPSW(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return p10348936.pf0719ea8.p7a2537aa.mf8f67da7(p7a2537aaVar, p14abd389Var);
    }

    public static java.lang.string XDWemSuuKpLaFRco(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        return p12e406c7Var.getUuid();
    }

    public static java.lang.string ZgiaPJEulUfTLLtw(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        return p12e406c7Var.getEmployeeId();
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        DtdNqcmIBuhAfIiL(this, supportSQLiteStatement, p12e406c7Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var) {
        if ((28 + 14) % 14 > 0) {
        }
        LKsbnDakSldChNHo(supportSQLiteStatement, 1, xDWemSuuKpLaFRco(p12e406c7Var));
        mkwFULYimwlLCuCZ(supportSQLiteStatement, 2, zgiaPJEulUfTLLtw(p12e406c7Var));
        fGdfiwnLulLPLdOU(supportSQLiteStatement, 3, nqxwgIVBmiZWmPSW(this.this$0, aDfxMKGncSvXIMCy(p12e406c7Var)));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR ABORT INTO `current_inventorization` (`uuid`,`employeeId`,`status`) VALUES (?,?,?)";
    }
}

