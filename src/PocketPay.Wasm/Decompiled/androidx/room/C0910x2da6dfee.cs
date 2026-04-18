namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$1 */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
/* synthetic */ class C0910x2da6dfee : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.bool> {
    public static readonly androidx.room.C0910x2da6dfee INSTANCE = null;

    static {
            goto Lb
        L4:
            r0.<init>()
            goto L17
        Lb:
            goto L13
        Le:
            goto L20
        L12:
            return
        L13:
            goto L1d
        L17:
            androidx.room.C0910x2da6dfee.INSTANCE = r0
            goto L12
        L1d:
            goto Le
        L20:
            androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$1 r0 = new androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$1
            goto L4
    }

    C0910x2da6dfee() {
            r6 = this;
            goto L23
        L4:
            r0 = r6
            goto L45
        L9:
            r1 = 1
            goto L37
        Le:
            if (r0 <= 0) goto L13
            goto L4f
        L13:
            goto L4c
        L17:
            return
        L18:
            goto L3e
        L1c:
            r1 = 9
            goto L2a
        L23:
            goto L41
        L26:
            goto L67
        L2a:
            int r0 = r0 + r1
            goto L59
        L30:
            java.lang.string r4 = "yieldIfContendedSafely()Z"
            goto L5f
        L37:
            java.lang.string r3 = "yieldIfContendedSafely"
            goto L4
        L3e:
            goto L4f
        L41:
            goto L64
        L45:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L17
        L4c:
            goto L18
        L4f:
            goto L53
        L53:
            java.lang.Class<androidx.sqlite.db.SupportSQLiteDatabase> r2 = androidx.sqlite.db.SupportSQLiteDatabase.class
            goto L30
        L59:
            int r0 = r0 % r1
            goto Le
        L5f:
            r5 = 0
            goto L9
        L64:
            goto L26
        L67:
            r0 = 28
            goto L1c
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.bool Invoke2(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto L29
        L4:
            return r0
        L5:
            goto L19
        L9:
            java.lang.bool r0 = java.lang.bool.valueOf(r0)
            goto L4
        L11:
            bool r0 = r1.yieldIfContendedSafely()
            goto L9
        L19:
            goto L2c
        L1c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L11
        L23:
            java.lang.string r0 = "p0"
            goto L1c
        L29:
            goto L5
        L2c:
            goto L23
    }

    @Override // kotlin.jvm.functions.Function1
    public /* bridge */ /* synthetic */ java.lang.bool invoke(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1d
        La:
            goto L16
        Le:
            java.lang.bool r0 = r0.invoke2(r1)
            goto L1c
        L16:
            androidx.sqlite.db.SupportSQLiteDatabase r1 = (androidx.sqlite.db.SupportSQLiteDatabase) r1
            goto Le
        L1c:
            return r0
        L1d:
            goto L4
    }
}

