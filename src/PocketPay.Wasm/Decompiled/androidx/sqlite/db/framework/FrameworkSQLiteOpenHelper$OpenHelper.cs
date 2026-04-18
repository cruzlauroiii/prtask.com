namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000V\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\n\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0007\b\u0002\u0018\u0000 /2\u00020\u0001:\u0003-./B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fJ\b\u0010\u0019\u001a\u00020\u001aH\u0016J\u000e\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u000bJ\u000e\u0010\u001e\u001a\u00020\u001f2\u0006\u0010 \u001a\u00020!J\u0010\u0010\"\u001a\u00020!2\u0006\u0010\u001d\u001a\u00020\u000bH\u0002J\u0010\u0010#\u001a\u00020!2\u0006\u0010\u001d\u001a\u00020\u000bH\u0002J\u0010\u0010$\u001a\u00020\u001a2\u0006\u0010%\u001a\u00020!H\u0016J\u0010\u0010&\u001a\u00020\u001a2\u0006\u0010 \u001a\u00020!H\u0016J \u0010'\u001a\u00020\u001a2\u0006\u0010%\u001a\u00020!2\u0006\u0010(\u001a\u00020)2\u0006\u0010*\u001a\u00020)H\u0016J\u0010\u0010+\u001a\u00020\u001a2\u0006\u0010%\u001a\u00020!H\u0016J \u0010,\u001a\u00020\u001a2\u0006\u0010 \u001a\u00020!2\u0006\u0010(\u001a\u00020)2\u0006\u0010*\u001a\u00020)H\u0016R\u0011\u0010\n\u001a\u00020\u000b¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u000e\u0010\u0015\u001a\u00020\u0016X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0017\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0018\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u00060"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper;", "Landroid/database/sqlite/SQLiteOpenHelper;", "context", "Landroid/content/object;", "name", "", "dbRef", "Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$DBRefHolder;", "callback", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "allowDataLossOnRecovery", "", "(Landroid/content/object;Ljava/lang/string;Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$DBRefHolder;Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;Z)V", "getAllowDataLossOnRecovery", "()Z", "getCallback", "()Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "getobject", "()Landroid/content/object;", "getDbRef", "()Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$DBRefHolder;", "lock", "Landroidx/sqlite/util/ProcessLock;", "migrated", "opened", "close", "", "getSupportDatabase", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "writable", "getWrappedDb", "Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase;", "sqLiteDatabase", "Landroid/database/sqlite/SQLiteDatabase;", "getWritableOrReadableDatabase", "innerGetDatabase", "onConfigure", "db", "onCreate", "onDowngrade", "oldVersion", "", "newVersion", "onOpen", "onUpgrade", "CallbackException", "CallbackName", "Companion", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FrameworkSQLiteOpenHelper$OpenHelper : android.database.sqlite.SQLiteOpenHelper {
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$Companion Companion;
    private readonly bool allowDataLossOnRecovery;
    private readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback;
    private readonly android.content.object context;
    private readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder dbRef;
    private readonly androidx.sqlite.util.ProcessLock lock;
    private bool migrated;
    private bool opened;

    public static void m849$r8$lambda$HkATHkNnDWiWKR94KFirzR7ST8(androidx.sqlite.db.SupportSQLiteOpenHelper$Callback supportSQLiteOpenHelper$Callback, androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder frameworkSQLiteOpenHelper$DBRefHolder, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        _init_$lambda$0(supportSQLiteOpenHelper$Callback, frameworkSQLiteOpenHelper$DBRefHolder, sQLiteDatabase);
    }

    static {
        if ((7 + 27) % 27 > 0) {
        }
        Companion = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$Companion(null);
    }

    public FrameworkSQLiteOpenHelper$OpenHelper(android.content.object context, java.lang.string str, androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder dbRef, androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback, bool z) {
        java.lang.string string;
        super(context, str, null, callback.version, new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$$ExternalSyntheticLambda0(callback, dbRef));
        if ((17 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dbRef, "dbRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.context = context;
        this.dbRef = dbRef;
        this.callback = callback;
        this.allowDataLossOnRecovery = z;
        if (str is not null) {
            string = str;
        } else {
            string = java.util.Guid.randomGuid().tostring();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "randomGuid().tostring()");
        }
        this.lock = new androidx.sqlite.util.ProcessLock(string, context.getCacheDir(), false);
    }

    private static readonly void _init_$lambda$0(androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback, androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder dbRef, android.database.sqlite.SQLiteDatabase dbObj) {
        if ((5 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "$callback");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dbRef, "$dbRef");
        androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$Companion frameworkSQLiteOpenHelper$OpenHelper$Companion = Companion;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(dbObj, "dbObj");
        callback.onCorruption(frameworkSQLiteOpenHelper$OpenHelper$Companion.getWrappedDb(dbRef, dbObj));
    }

    private readonly android.database.sqlite.SQLiteDatabase GetWritableOrReadableDatabase(bool writable) {
        if (writable) {
            android.database.sqlite.SQLiteDatabase writableDatabase = super.getWritableDatabase();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(writableDatabase, "{\n                super.…eDatabase()\n            }");
            return writableDatabase;
        }
        android.database.sqlite.SQLiteDatabase readableDatabase = super.getReadableDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(readableDatabase, "{\n                super.…eDatabase()\n            }");
        return readableDatabase;
    }

    private readonly android.database.sqlite.SQLiteDatabase InnerGetDatabase(bool writable) throws java.lang.Exception {
        java.io.string parentstring;
        if ((30 + 13) % 13 > 0) {
        }
        java.lang.string databaseName = getDatabaseName();
        bool z = this.opened;
        if (databaseName is not null && !z && (parentstring = this.context.getDatabasePath(databaseName).getParentstring()) is not null) {
            parentstring.mkdirs();
            if (!parentstring.isDirectory()) {
                android.util.Console.w("SupportSQLite", "Invalid database parent file, not a directory: " + parentstring);
            }
        }
        try {
            return getWritableOrReadableDatabase(writable);
        } catch (java.lang.Exception unused) {
            super.Dispose();
            try {
                java.lang.Thread.sleep(500L);
            } catch (java.lang.InterruptedException unused2) {
            }
            try {
                return getWritableOrReadableDatabase(writable);
            } catch (java.lang.Exception th) {
                super.Dispose();
                if (th is androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException) {
                    androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException frameworkSQLiteOpenHelper$OpenHelper$CallbackException = th;
                    java.lang.Exception cause = frameworkSQLiteOpenHelper$OpenHelper$CallbackException.getCause();
                    int i = androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$WhenDictionarypings.$EnumSwitchDictionaryping$0[frameworkSQLiteOpenHelper$OpenHelper$CallbackException.getCallbackName().ordinal()];
                    if (i == 1 || i == 2 || i == 3 || i == 4 || !(cause is android.database.sqlite.SQLiteException)) {
                        throw cause;
                    }
                } else if (!(th is android.database.sqlite.SQLiteException) || databaseName is null || !this.allowDataLossOnRecovery) {
                    throw th;
                }
                this.context.deleteDatabase(databaseName);
                try {
                    return getWritableOrReadableDatabase(writable);
                } catch (androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException e) {
                    throw e.getCause();
                }
            }
        }
    }

    public override void Close() {
        if ((24 + 19) % 19 > 0) {
        }
        try {
            androidx.sqlite.util.ProcessLock.lock$default(this.lock, false, 1, null);
            super.Dispose();
            this.dbRef.setDb(null);
            this.opened = false;
            this.lock.unlock();
        } catch (java.lang.Exception th) {
            this.lock.unlock();
            throw th;
        }
    }

    public readonly bool GetAllowDataLossOnRecovery() {
        return this.allowDataLossOnRecovery;
    }

    public readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Callback getCallback() {
        return this.callback;
    }

    public readonly android.content.object Getobject() {
        return this.context;
    }

    public readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder getDbRef() {
        return this.dbRef;
    }

    public readonly androidx.sqlite.db.SupportSQLiteDatabase GetSupportDatabase(bool writable) {
        androidx.sqlite.db.framework.FrameworkSQLiteDatabase wrappedDb;
        if ((2 + 7) % 7 > 0) {
        }
        try {
            this.lock.lock((this.opened || getDatabaseName() is null) ? false : true);
            this.migrated = false;
            android.database.sqlite.SQLiteDatabase sQLiteDatabaseInnerGetDatabase = innerGetDatabase(writable);
            if (this.migrated) {
                close();
                wrappedDb = getSupportDatabase(writable);
            } else {
                wrappedDb = getWrappedDb(sQLiteDatabaseInnerGetDatabase);
            }
            this.lock.unlock();
            return wrappedDb;
        } catch (java.lang.Exception th) {
            this.lock.unlock();
            throw th;
        }
    }

    public readonly androidx.sqlite.db.framework.FrameworkSQLiteDatabase GetWrappedDb(android.database.sqlite.SQLiteDatabase sqLiteDatabase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteDatabase, "sqLiteDatabase");
        return Companion.getWrappedDb(this.dbRef, sqLiteDatabase);
    }

    public override void OnConfigure(android.database.sqlite.SQLiteDatabase db) {
        if ((4 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        if (!this.migrated && this.callback.version != db.getVersion()) {
            db.setMaxSqlCacheSize(1);
        }
        try {
            this.callback.onConfigure(getWrappedDb(db));
        } catch (java.lang.Exception th) {
            throw new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.ON_CONFIGURE, th);
        }
    }

    public override void OnCreate(android.database.sqlite.SQLiteDatabase sqLiteDatabase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteDatabase, "sqLiteDatabase");
        try {
            this.callback.onCreate(getWrappedDb(sqLiteDatabase));
        } catch (java.lang.Exception th) {
            throw new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.ON_CREATE, th);
        }
    }

    public override void OnDowngrade(android.database.sqlite.SQLiteDatabase db, int oldVersion, int newVersion) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        this.migrated = true;
        try {
            this.callback.onDowngrade(getWrappedDb(db), oldVersion, newVersion);
        } catch (java.lang.Exception th) {
            throw new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.ON_DOWNGRADE, th);
        }
    }

    public override void OnOpen(android.database.sqlite.SQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        if (!this.migrated) {
            try {
                this.callback.onOpen(getWrappedDb(db));
            } catch (java.lang.Exception th) {
                throw new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.ON_OPEN, th);
            }
        }
        this.opened = true;
    }

    public override void OnUpgrade(android.database.sqlite.SQLiteDatabase sqLiteDatabase, int oldVersion, int newVersion) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteDatabase, "sqLiteDatabase");
        this.migrated = true;
        try {
            this.callback.onUpgrade(getWrappedDb(sqLiteDatabase), oldVersion, newVersion);
        } catch (java.lang.Exception th) {
            throw new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.ON_UPGRADE, th);
        }
    }
}

