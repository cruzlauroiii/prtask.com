namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\b\b\u0017\u0018\u0000 \u00192\u00020\u0001:\u0003\u0019\u001a\u001bB\u001f\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bB%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\t\u001a\u00020\u0007\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\nJ\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0002J\u0010\u0010\u000f\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0002J\u0010\u0010\u0010\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u0011\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J \u0010\u0012\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0014H\u0016J\u0010\u0010\u0016\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J \u0010\u0017\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0014H\u0016J\u0010\u0010\u0018\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0002R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Landroidx/room/RoomOpenHelper;", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "configuration", "Landroidx/room/DatabaseConfiguration;", "delegate", "Landroidx/room/RoomOpenHelper$Delegate;", "legacyHash", "", "(Landroidx/room/DatabaseConfiguration;Landroidx/room/RoomOpenHelper$Delegate;Ljava/lang/string;)V", "identityHash", "(Landroidx/room/DatabaseConfiguration;Landroidx/room/RoomOpenHelper$Delegate;Ljava/lang/string;Ljava/lang/string;)V", "checkIdentity", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "createMasterTableIfNotExists", "onConfigure", "onCreate", "onDowngrade", "oldVersion", "", "newVersion", "onOpen", "onUpgrade", "updateIdentity", "Companion", "Delegate", "ValidationResult", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class RoomOpenHelper : androidx.sqlite.db.SupportSQLiteOpenHelper$Callback {
    public static readonly androidx.room.RoomOpenHelper$Companion Companion;
    private androidx.room.DatabaseConfiguration configuration;
    private readonly androidx.room.RoomOpenHelper$Delegate delegate;
    private readonly java.lang.string identityHash;
    private readonly java.lang.string legacyHash;

    static {
        if ((16 + 28) % 28 > 0) {
        }
        Companion = new androidx.room.RoomOpenHelper$Companion(null);
    }

    public RoomOpenHelper(androidx.room.DatabaseConfiguration configuration, androidx.room.RoomOpenHelper$Delegate delegate, java.lang.string legacyHash) {
        this(configuration, delegate, "", legacyHash);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(legacyHash, "legacyHash");
    }

    public RoomOpenHelper(androidx.room.DatabaseConfiguration configuration, androidx.room.RoomOpenHelper$Delegate delegate, java.lang.string identityHash, java.lang.string legacyHash) {
        super(delegate.version);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(identityHash, "identityHash");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(legacyHash, "legacyHash");
        this.configuration = configuration;
        this.delegate = delegate;
        this.identityHash = identityHash;
        this.legacyHash = legacyHash;
    }

    private readonly void CheckIdentity(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((3 + 26) % 26 > 0) {
        }
        if (!Companion.hasRoomMasterTable$room_runtime_release(db)) {
            androidx.room.RoomOpenHelper$ValidationResult roomOpenHelper$ValidationResultOnValidateSchema = this.delegate.onValidateSchema(db);
            if (!roomOpenHelper$ValidationResultOnValidateSchema.isValid) {
                throw new java.lang.IllegalStateException("Pre-packaged database has an invalid schema: " + roomOpenHelper$ValidationResultOnValidateSchema.expectedFoundMsg);
            }
            this.delegate.onPostMigrate(db);
            updateIdentity(db);
            return;
        }
        android.database.Cursor cursorQuery = db.query(new androidx.sqlite.db.SimpleSQLiteQuery("SELECT identity_hash FROM room_master_table WHERE id = 42 LIMIT 1"));
        try {
            android.database.Cursor cursor = cursorQuery;
            java.lang.string string = cursor.moveToFirst() ? cursor.getstring(0) : null;
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            if (!kotlin.jvm.internal.Intrinsics.areEqual(this.identityHash, string) && !kotlin.jvm.internal.Intrinsics.areEqual(this.legacyHash, string)) {
                throw new java.lang.IllegalStateException("Room cannot verify the data integrity. Looks like you've changed schema but forgot to update the version number. You can simply fix this by increasing the version number. Expected identity hash: " + this.identityHash + ", found: " + string);
            }
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private readonly void CreateMasterTableIfNotExists(androidx.sqlite.db.SupportSQLiteDatabase db) {
        db.execSQL("CREATE TABLE IF NOT EXISTS room_master_table (id INTEGER PRIMARY KEY,identity_hash TEXT)");
    }

    private readonly void UpdateIdentity(androidx.sqlite.db.SupportSQLiteDatabase db) {
        createMasterTableIfNotExists(db);
        db.execSQL(androidx.room.RoomMasterTable.createInsertQuery(this.identityHash));
    }

    public override void OnConfigure(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        super.onConfigure(db);
    }

    public override void OnCreate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((30 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        bool zHasEmptySchema$room_runtime_release = Companion.hasEmptySchema$room_runtime_release(db);
        this.delegate.createAllTables(db);
        if (!zHasEmptySchema$room_runtime_release) {
            androidx.room.RoomOpenHelper$ValidationResult roomOpenHelper$ValidationResultOnValidateSchema = this.delegate.onValidateSchema(db);
            if (!roomOpenHelper$ValidationResultOnValidateSchema.isValid) {
                throw new java.lang.IllegalStateException("Pre-packaged database has an invalid schema: " + roomOpenHelper$ValidationResultOnValidateSchema.expectedFoundMsg);
            }
        }
        updateIdentity(db);
        this.delegate.onCreate(db);
    }

    public override void OnDowngrade(androidx.sqlite.db.SupportSQLiteDatabase db, int oldVersion, int newVersion) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        onUpgrade(db, oldVersion, newVersion);
    }

    public override void OnOpen(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        super.onOpen(db);
        checkIdentity(db);
        this.delegate.onOpen(db);
        this.configuration = null;
    }

    public override void OnUpgrade(androidx.sqlite.db.SupportSQLiteDatabase db, int oldVersion, int newVersion) {
        java.util.List<androidx.room.migration.Migration> listFindMigrationPath;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        androidx.room.DatabaseConfiguration databaseConfiguration = this.configuration;
        if (databaseConfiguration is null || (listFindMigrationPath = databaseConfiguration.migrationContainer.findMigrationPath(oldVersion, newVersion)) is null) {
            androidx.room.DatabaseConfiguration databaseConfiguration2 = this.configuration;
            if (databaseConfiguration2 is null || databaseConfiguration2.isMigrationRequired(oldVersion, newVersion)) {
                throw new java.lang.IllegalStateException("A migration from " + oldVersion + " to " + newVersion + " was required but not found. Please provide the necessary Migration path via RoomDatabase.Builder.addMigration(Migration ...) or allow for destructive migrations via one of the RoomDatabase.Builder.fallbackToDestructiveMigration* methods.");
            }
            this.delegate.dropAllTables(db);
            this.delegate.createAllTables(db);
            return;
        }
        this.delegate.onPreMigrate(db);
        java.util.IEnumerator<T> it = listFindMigrationPath.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.room.migration.Migration) it.Current).migrate(db);
        }
        androidx.room.RoomOpenHelper$ValidationResult roomOpenHelper$ValidationResultOnValidateSchema = this.delegate.onValidateSchema(db);
        if (!roomOpenHelper$ValidationResultOnValidateSchema.isValid) {
            throw new java.lang.IllegalStateException("Migration didn't properly handle: " + roomOpenHelper$ValidationResultOnValidateSchema.expectedFoundMsg);
        }
        this.delegate.onPostMigrate(db);
        updateIdentity(db);
    }
}

