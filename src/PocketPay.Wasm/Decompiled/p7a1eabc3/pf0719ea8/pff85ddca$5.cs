namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$5 : androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.peaf39066> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$5(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pff85ddcaVar;
    }

    public static java.lang.string LmuMUnyFwSLOBqrF(pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        return peaf39066Var.getArabName();
    }

    public static void MhlHGJWzRHusEgHm(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void MvlLJBHwTnIufwqA(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void RMnenNsNKmPQlrGV(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string YTswKorDmsptNmqN(pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        return peaf39066Var.getEngName();
    }

    public static java.lang.string JORHSSgBxXLESFOp(pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        return peaf39066Var.getFrName();
    }

    public static void JexesnIVzLqVduSY(p7a1eabc3.pf0719ea8.pff85ddca$5 pff85ddca_5, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        pff85ddca_5.bind2(supportSQLiteStatement, peaf39066Var);
    }

    public static java.lang.string MJfnkXvJNIrljgFd(pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        return peaf39066Var.getCode();
    }

    public static void TzobQOXXJQRgQBJH(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        jexesnIVzLqVduSY(this, supportSQLiteStatement, peaf39066Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.peaf39066 peaf39066Var) {
        MvlLJBHwTnIufwqA(supportSQLiteStatement, 1, mJfnkXvJNIrljgFd(peaf39066Var));
        MhlHGJWzRHusEgHm(supportSQLiteStatement, 2, YTswKorDmsptNmqN(peaf39066Var));
        tzobQOXXJQRgQBJH(supportSQLiteStatement, 3, LmuMUnyFwSLOBqrF(peaf39066Var));
        RMnenNsNKmPQlrGV(supportSQLiteStatement, 4, jORHSSgBxXLESFOp(peaf39066Var));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR ABORT INTO `measure` (`code`,`engName`,`arabName`,`frName`) VALUES (?,?,?,?)";
    }
}

