namespace WillowMaze.Wasm.Decompiled;


class p9785642f$15 : androidx.room.SharedSQLiteStatement {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$15(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM current_sell_payment";
    }
}

