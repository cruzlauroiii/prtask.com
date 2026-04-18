namespace WillowMaze.Wasm.Decompiled;


class p9785642f$8 : androidx.room.EntityDeletionOrUpdateAdapter<p8325324b.p07214c67.pd77d5e50.p32a285cf> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$8(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar) {
        bind2(supportSQLiteStatement, p32a285cfVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar) {
        supportSQLiteStatement.bindstring(1, p32a285cfVar.getUuid());
        supportSQLiteStatement.bindstring(2, p32a285cfVar.getReceiptUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "DELETE FROM `current_sell_payment` WHERE `uuid` = ? AND `receiptUuid` = ?";
    }
}

