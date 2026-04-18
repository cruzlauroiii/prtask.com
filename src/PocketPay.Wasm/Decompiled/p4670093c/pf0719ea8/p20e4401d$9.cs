namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$9 : androidx.room.SharedSQLiteStatement {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$9(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM current_payback_receipt";
    }
}

