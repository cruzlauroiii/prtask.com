namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$8 : androidx.room.SharedSQLiteStatement {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$8(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pff85ddcaVar;
    }

    public override java.lang.string CreateQuery() {
        return "\n            UPDATE commodity\n            SET\n                quantity = CAST((ifnull(CAST(quantity as REAL), 0) + ?) as TEXT),\n                price = ?,\n                purchasePrice = ?\n            WHERE id = ?\n        ";
    }
}

