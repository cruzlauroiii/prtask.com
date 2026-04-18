namespace WillowMaze.Wasm.Decompiled;


class p8572d174$1 : androidx.room.EntityInsertionAdapter<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;

    p8572d174$1(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p8572d174Var;
    }

    public static void DjhveXijQnTxIsaz(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string NnJSoXMyyBDrRGuN(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getUuid();
    }

    public static void CDOTxaLFVDYvUttZ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void MuLqXPGheRMUKSQi(p0c985ebf.pf0719ea8.p8572d174$1 p8572d174_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        p8572d174_1.bind2(supportSQLiteStatement, pf7c281bfVar);
    }

    public static java.lang.string QovUfZVutbmHVlUr(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getReason();
    }

    public static java.lang.string RGddCyQlPoiovoXp(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getName();
    }

    public static void XniFRSvJOuaihJZI(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        muLqXPGheRMUKSQi(this, supportSQLiteStatement, pf7c281bfVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        xniFRSvJOuaihJZI(supportSQLiteStatement, 1, NnJSoXMyyBDrRGuN(pf7c281bfVar));
        DjhveXijQnTxIsaz(supportSQLiteStatement, 2, rGddCyQlPoiovoXp(pf7c281bfVar));
        cDOTxaLFVDYvUttZ(supportSQLiteStatement, 3, qovUfZVutbmHVlUr(pf7c281bfVar));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR ABORT INTO `current_inspection` (`uuid`,`name`,`reason`) VALUES (?,?,?)";
    }
}

