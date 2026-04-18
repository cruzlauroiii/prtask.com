namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$7 : androidx.room.SharedSQLiteStatement {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;

    p9442da0d$7(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9442da0dVar;
    }

    public override java.lang.string CreateQuery() {
        return "DELETE FROM device WHERE storageType = 'REMOTE'";
    }
}

