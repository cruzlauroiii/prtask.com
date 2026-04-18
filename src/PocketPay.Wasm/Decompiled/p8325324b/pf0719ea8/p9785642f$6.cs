namespace WillowMaze.Wasm.Decompiled;


class p9785642f$6 : androidx.room.EntityDeletionOrUpdateAdapter<p8325324b.p07214c67.pd77d5e50.pf79cee86> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$6(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var) {
        bind2(supportSQLiteStatement, pf79cee86Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var) {
        supportSQLiteStatement.bindstring(1, pf79cee86Var.getUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "DELETE FROM `current_sell_receipt` WHERE `uuid` = ?";
    }
}

