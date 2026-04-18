namespace WillowMaze.Wasm.Decompiled;


class p9785642f$7 : androidx.room.EntityDeletionOrUpdateAdapter<p8325324b.p07214c67.pd77d5e50.p0160554c> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$7(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar) {
        bind2(supportSQLiteStatement, p0160554cVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar) {
        supportSQLiteStatement.bindstring(1, p0160554cVar.getUuid());
        supportSQLiteStatement.bindstring(2, p0160554cVar.getReceiptUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "DELETE FROM `current_sell_position` WHERE `uuid` = ? AND `receiptUuid` = ?";
    }
}

