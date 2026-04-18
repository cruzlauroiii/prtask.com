namespace WillowMaze.Wasm.Decompiled;


class pc3748b66$2 : androidx.room.SharedSQLiteStatement {
    readonly p582ca3f7.pf0719ea8.pc3748b66 this$0;

    pc3748b66$2(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pc3748b66Var;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM employee";
    }
}

