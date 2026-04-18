namespace WillowMaze.Wasm.Decompiled;


class pea6979f9$1 : androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> {
    readonly pe0212e54.pf0719ea8.pea6979f9 this$0;

    pea6979f9$1(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pea6979f9Var;
    }

    public static java.lang.string CVypRAHXvikhOVEL(pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        return p107d0d2aVar.getName();
    }

    public static void EgoHJXHNCaNxLvLF(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string GtDBOfoddtqaQrdI(pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        return p107d0d2aVar.getAddress();
    }

    public static void OTnnGIOFzdWzccpt(pe0212e54.pf0719ea8.pea6979f9$1 pea6979f9_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        pea6979f9_1.bind2(supportSQLiteStatement, p107d0d2aVar);
    }

    public static java.lang.string PgshjJVmGeKxUcPP(pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        return p107d0d2aVar.getName();
    }

    public static void PocULInFlAjSDSwv(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.lang.string AILwQbsguoQaMEeR(pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        return p107d0d2aVar.getId();
    }

    public static void HJCIqTUwSozvYcJL(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string HNiDNXNURjbqfipV(pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        return p107d0d2aVar.getAddress();
    }

    public static void PwqdSorVyfWrCvKJ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void QuMchpxeUKYWbNEo(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        OTnnGIOFzdWzccpt(this, supportSQLiteStatement, p107d0d2aVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a p107d0d2aVar) {
        EgoHJXHNCaNxLvLF(supportSQLiteStatement, 1, aILwQbsguoQaMEeR(p107d0d2aVar));
        if (CVypRAHXvikhOVEL(p107d0d2aVar) is not null) {
            pwqdSorVyfWrCvKJ(supportSQLiteStatement, 2, PgshjJVmGeKxUcPP(p107d0d2aVar));
        } else {
            PocULInFlAjSDSwv(supportSQLiteStatement, 2);
        }
        if (GtDBOfoddtqaQrdI(p107d0d2aVar) is not null) {
            hJCIqTUwSozvYcJL(supportSQLiteStatement, 3, hNiDNXNURjbqfipV(p107d0d2aVar));
        } else {
            quMchpxeUKYWbNEo(supportSQLiteStatement, 3);
        }
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `shop` (`id`,`name`,`address`) VALUES (?,?,?)";
    }
}

