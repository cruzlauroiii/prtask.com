namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$inTransaction$1 */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
/* synthetic */ class C0891x5693171d : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.bool> {
    public static readonly androidx.room.C0891x5693171d INSTANCE = null;

    static {
            goto Le
        L4:
            goto L11
        L7:
            r0.<init>()
            goto L15
        Le:
            goto L1c
        L11:
            goto L20
        L15:
            androidx.room.C0891x5693171d.INSTANCE = r0
            goto L1b
        L1b:
            return
        L1c:
            goto L4
        L20:
            androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$inTransaction$1 r0 = new androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$inTransaction$1
            goto L7
    }

    C0891x5693171d() {
            r6 = this;
            goto L15
        L4:
            r0 = r6
            goto L26
        L9:
            java.lang.string r4 = "inTransaction()Z"
            goto L21
        Lf:
            java.lang.string r3 = "inTransaction"
            goto L4
        L15:
            goto L68
        L18:
            goto L2d
        L1c:
            r1 = 1
            goto Lf
        L21:
            r5 = 0
            goto L1c
        L26:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L34
        L2d:
            r0 = 20
            goto L4f
        L34:
            return
        L35:
            goto L65
        L39:
            int r0 = r0 + r1
            goto L56
        L3f:
            goto L35
        L42:
            goto L49
        L46:
            goto L18
        L49:
            java.lang.Class<androidx.sqlite.db.SupportSQLiteDatabase> r2 = androidx.sqlite.db.SupportSQLiteDatabase.class
            goto L9
        L4f:
            r1 = 2
            goto L39
        L56:
            int r0 = r0 % r1
            goto L5c
        L5c:
            if (r0 <= 0) goto L61
            goto L42
        L61:
            goto L3f
        L65:
            goto L42
        L68:
            goto L46
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.bool Invoke2(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto L19
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L20
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L1c
        L13:
            java.lang.string r0 = "p0"
            goto L4
        L19:
            goto Lc
        L1c:
            goto L13
        L20:
            bool r0 = r1.inTransaction()
            goto L28
        L28:
            java.lang.bool r0 = java.lang.bool.valueOf(r0)
            goto Lb
    }

    @Override // kotlin.jvm.functions.Function1
    public /* bridge */ /* synthetic */ java.lang.bool invoke(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto La
        L4:
            androidx.sqlite.db.SupportSQLiteDatabase r1 = (androidx.sqlite.db.SupportSQLiteDatabase) r1
            goto L11
        La:
            goto L1d
        Ld:
            goto L4
        L11:
            java.lang.bool r0 = r0.invoke2(r1)
            goto L1c
        L19:
            goto Ld
        L1c:
            return r0
        L1d:
            goto L19
    }
}

