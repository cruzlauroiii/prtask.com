namespace WillowMaze.Wasm.Decompiled;


class paf462909$13 : androidx.room.SharedSQLiteStatement {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$13(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = paf462909Var;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM payback_receipt";
    }
}

