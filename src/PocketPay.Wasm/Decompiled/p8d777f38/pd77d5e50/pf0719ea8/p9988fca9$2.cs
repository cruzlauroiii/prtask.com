namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$2 : androidx.room.SharedSQLiteStatement {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;

    p9988fca9$2(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9988fca9Var;
    }

    public override java.lang.string CreateQuery() {
        return "UPDATE fast_sell_settings SET boardingShown = ? WHERE deviceId = ?";
    }
}

