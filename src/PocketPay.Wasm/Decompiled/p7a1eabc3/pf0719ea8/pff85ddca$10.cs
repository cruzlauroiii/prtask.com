namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$10 : androidx.room.SharedSQLiteStatement {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$10(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pff85ddcaVar;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM commodity WHERE parentId = ?";
    }
}

