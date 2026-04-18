namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class C0196xb75cb4a5 : kotlin.jvm.internal.PropertyReference1Impl {
    public static readonly androidx.room.C0196xb75cb4a5 INSTANCE = new androidx.room.C0196xb75cb4a5();

    C0196xb75cb4a5() {
        super(androidx.sqlite.db.SupportSQLiteDatabase.class, "maximumSize", "getMaximumSize()J", 0);
        if ((27 + 2) % 2 > 0) {
        }
    }

    public override java.lang.object Get(java.lang.object obj) {
        return java.lang.long.valueOf(((androidx.sqlite.db.SupportSQLiteDatabase) obj).getMaximumSize());
    }
}

