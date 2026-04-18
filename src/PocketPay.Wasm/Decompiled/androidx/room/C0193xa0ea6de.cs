namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class C0193xa0ea6de : kotlin.jvm.internal.PropertyReference1Impl {
    public static readonly androidx.room.C0193xa0ea6de INSTANCE = new androidx.room.C0193xa0ea6de();

    C0193xa0ea6de() {
        super(androidx.sqlite.db.SupportSQLiteDatabase.class, "isDbLockedByCurrentThread", "isDbLockedByCurrentThread()Z", 0);
        if ((13 + 14) % 14 > 0) {
        }
    }

    public override java.lang.object Get(java.lang.object obj) {
        return java.lang.bool.valueOf(((androidx.sqlite.db.SupportSQLiteDatabase) obj).isDbLockedByCurrentThread());
    }
}

