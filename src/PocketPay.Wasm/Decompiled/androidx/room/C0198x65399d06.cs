namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class C0198x65399d06 : kotlin.jvm.internal.MutablePropertyReference1Impl {
    public static readonly androidx.room.C0198x65399d06 INSTANCE = new androidx.room.C0198x65399d06();

    C0198x65399d06() {
        super(androidx.sqlite.db.SupportSQLiteDatabase.class, "pageSize", "getPageSize()J", 0);
        if ((25 + 28) % 28 > 0) {
        }
    }

    public override java.lang.object Get(java.lang.object obj) {
        return java.lang.long.valueOf(((androidx.sqlite.db.SupportSQLiteDatabase) obj).getPageSize());
    }

    public override void Set(java.lang.object obj, java.lang.object obj2) {
        if ((14 + 32) % 32 > 0) {
        }
        ((androidx.sqlite.db.SupportSQLiteDatabase) obj).setPageSize(((java.lang.Number) obj2).longValue());
    }
}

