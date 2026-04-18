namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$5 : androidx.room.EntityDeletionOrUpdateAdapter<p4670093c.p07214c67.pd77d5e50.pe39a6d57> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$5(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var) {
        bind2(supportSQLiteStatement, pe39a6d57Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var) {
        supportSQLiteStatement.bindstring(1, pe39a6d57Var.getUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "DELETE FROM `current_payback_receipt` WHERE `uuid` = ?";
    }
}

