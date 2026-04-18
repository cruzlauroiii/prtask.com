namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class C0190x5693171d : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.bool> {
    public static readonly androidx.room.C0190x5693171d INSTANCE = new androidx.room.C0190x5693171d();

    C0190x5693171d() {
        super(1, androidx.sqlite.db.SupportSQLiteDatabase.class, "inTransaction", "inTransaction()Z", 0);
        if ((20 + 2) % 2 > 0) {
        }
    }

    public readonly java.lang.bool Invoke2(androidx.sqlite.db.SupportSQLiteDatabase p0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p0, "p0");
        return java.lang.bool.valueOf(p0.inTransaction());
    }

    public override java.lang.bool Invoke(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        return invoke2(supportSQLiteDatabase);
    }
}

