namespace WillowMaze.Wasm.Decompiled;


class p8572d174$3 : androidx.room.EntityDeletionOrUpdateAdapter<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;

    p8572d174$3(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p8572d174Var;
    }

    public static void AehiwmoquzKJMykb(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void OTxlpQnNMbGqiuhU(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string QTxsluVTVlBxrzKd(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getUuid();
    }

    public static java.lang.string TAeISrDojQlZbfcd(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getReason();
    }

    public static void AqgrgERLOJngMzAo(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string IkVFCsuzwWsSGwtO(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getName();
    }

    public static void LuZYhnUojtTEJJIq(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string PybszXNIgFGftFMP(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        return pf7c281bfVar.getUuid();
    }

    public static void REsMzGtmEBrKBCdh(p0c985ebf.pf0719ea8.p8572d174$3 p8572d174_3, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        p8572d174_3.bind2(supportSQLiteStatement, pf7c281bfVar);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        rEsMzGtmEBrKBCdh(this, supportSQLiteStatement, pf7c281bfVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar) {
        AehiwmoquzKJMykb(supportSQLiteStatement, 1, QTxsluVTVlBxrzKd(pf7c281bfVar));
        luZYhnUojtTEJJIq(supportSQLiteStatement, 2, ikVFCsuzwWsSGwtO(pf7c281bfVar));
        aqgrgERLOJngMzAo(supportSQLiteStatement, 3, TAeISrDojQlZbfcd(pf7c281bfVar));
        OTxlpQnNMbGqiuhU(supportSQLiteStatement, 4, pybszXNIgFGftFMP(pf7c281bfVar));
    }

    protected override java.lang.string CreateQuery() {
        return "UPDATE OR ABORT `current_inspection` SET `uuid` = ?,`name` = ?,`reason` = ? WHERE `uuid` = ?";
    }
}

