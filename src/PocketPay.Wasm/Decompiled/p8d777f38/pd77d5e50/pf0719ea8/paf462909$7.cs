namespace WillowMaze.Wasm.Decompiled;


class paf462909$7 : androidx.room.EntityDeletionOrUpdateAdapter<pad5f82e8.p07214c67.pd77d5e50.p25a7e996> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$7(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = paf462909Var;
    }

    public static int BKnceRWdFYUZQlkI(pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        return p25a7e996Var.getId();
    }

    public static void XPVOzFYzHKsiXntU(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void QjVvZXdvXrRyAopP(p8d777f38.pd77d5e50.pf0719ea8.paf462909$7 paf462909_7, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        paf462909_7.bind2(supportSQLiteStatement, p25a7e996Var);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        qjVvZXdvXrRyAopP(this, supportSQLiteStatement, p25a7e996Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        if ((27 + 1) % 1 > 0) {
        }
        XPVOzFYzHKsiXntU(supportSQLiteStatement, 1, BKnceRWdFYUZQlkI(p25a7e996Var));
    }

    protected override java.lang.string CreateQuery() {
        return "DELETE FROM `queue_receipt` WHERE `id` = ?";
    }
}

