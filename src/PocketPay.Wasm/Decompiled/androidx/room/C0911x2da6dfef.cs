namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$2 */
/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
/* synthetic */ class C0911x2da6dfef : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<androidx.sqlite.db.SupportSQLiteDatabase, java.lang.bool> {
    public static readonly androidx.room.C0911x2da6dfef INSTANCE = null;

    static {
            goto L16
        L4:
            r0.<init>()
            goto L10
        Lb:
            return
        Lc:
            goto L23
        L10:
            androidx.room.C0911x2da6dfef.INSTANCE = r0
            goto Lb
        L16:
            goto Lc
        L19:
            goto L1d
        L1d:
            androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$2 r0 = new androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase$yieldIfContendedSafely$2
            goto L4
        L23:
            goto L19
    }

    C0911x2da6dfef() {
            r6 = this;
            goto L3f
        L4:
            goto L42
        L7:
            goto L6a
        La:
            goto L34
        Le:
            java.lang.string r4 = "yieldIfContendedSafely()Z"
            goto L15
        L15:
            r5 = 0
            goto L4f
        L1a:
            r0 = 12
            goto L62
        L21:
            java.lang.string r3 = "yieldIfContendedSafely"
            goto L3a
        L28:
            int r0 = r0 + r1
            goto L2e
        L2e:
            int r0 = r0 % r1
            goto L46
        L34:
            java.lang.Class<androidx.sqlite.db.SupportSQLiteDatabase> r2 = androidx.sqlite.db.SupportSQLiteDatabase.class
            goto Le
        L3a:
            r0 = r6
            goto L54
        L3f:
            goto L5e
        L42:
            goto L1a
        L46:
            if (r0 <= 0) goto L4b
            goto La
        L4b:
            goto L7
        L4f:
            r1 = 1
            goto L21
        L54:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L69
        L5b:
            goto La
        L5e:
            goto L4
        L62:
            r1 = 21
            goto L28
        L69:
            return
        L6a:
            goto L5b
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.bool Invoke2(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto L29
        L4:
            java.lang.string r0 = "p0"
            goto L22
        La:
            java.lang.bool r0 = java.lang.bool.valueOf(r0)
            goto L12
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L2c
        L1a:
            bool r0 = r1.yieldIfContendedSafely()
            goto La
        L22:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L1a
        L29:
            goto L13
        L2c:
            goto L4
    }

    @Override // kotlin.jvm.functions.Function1
    public /* bridge */ /* synthetic */ java.lang.bool invoke(androidx.sqlite.db.SupportSQLiteDatabase r1) {
            r0 = this;
            goto Lc
        L4:
            java.lang.bool r0 = r0.invoke2(r1)
            goto L19
        Lc:
            goto L1a
        Lf:
            goto L13
        L13:
            androidx.sqlite.db.SupportSQLiteDatabase r1 = (androidx.sqlite.db.SupportSQLiteDatabase) r1
            goto L4
        L19:
            return r0
        L1a:
            goto L1e
        L1e:
            goto Lf
    }
}

