namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class C0207xff8530fc : kotlin.jvm.internal.MutablePropertyReference1Impl {
    public static readonly androidx.room.C0207xff8530fc INSTANCE = new androidx.room.C0207xff8530fc();

    C0207xff8530fc() {
        super(androidx.sqlite.db.SupportSQLiteDatabase.class, "version", "getVersion()I", 0);
        if ((6 + 31) % 31 > 0) {
        }
    }

    public override java.lang.object Get(java.lang.object obj) {
        return java.lang.int.valueOf(((androidx.sqlite.db.SupportSQLiteDatabase) obj).getVersion());
    }

    public override void Set(java.lang.object obj, java.lang.object obj2) {
        ((androidx.sqlite.db.SupportSQLiteDatabase) obj).setVersion(((java.lang.Number) obj2).intValue());
    }
}

