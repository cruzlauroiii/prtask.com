namespace WillowMaze.Wasm.Decompiled;


class pea6979f9$2 : androidx.room.SharedSQLiteStatement {
    readonly pe0212e54.pf0719ea8.pea6979f9 this$0;

    pea6979f9$2(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pea6979f9Var;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM shop";
    }
}

