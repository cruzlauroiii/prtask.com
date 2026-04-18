namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$8 : androidx.room.SharedSQLiteStatement {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;

    p7a2537aa$8(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p7a2537aaVar;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM current_inventorization_position";
    }
}

