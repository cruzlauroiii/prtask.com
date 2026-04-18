namespace WillowMaze.Wasm.Decompiled;


class p9785642f$13 : androidx.room.SharedSQLiteStatement {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$13(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    public override java.lang.string CreateQuery() {
        return "UPDATE current_sell_receipt SET isSelected = 1 WHERE deviceId = ? and receiptType = ?";
    }
}

