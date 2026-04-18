namespace WillowMaze.Wasm.Decompiled;


class p8572d174$6 : androidx.room.SharedSQLiteStatement {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;

    p8572d174$6(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p8572d174Var;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM current_inspection_position WHERE uuid = ?";
    }
}

