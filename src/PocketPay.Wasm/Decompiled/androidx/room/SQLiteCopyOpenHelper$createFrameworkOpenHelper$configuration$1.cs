namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J \u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\tH\u0016¨\u0006\u000b"}, d2 = {"androidx/room/SQLiteCopyOpenHelper$createFrameworkOpenHelper$configuration$1", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "onCreate", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "onOpen", "onUpgrade", "oldVersion", "", "newVersion", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SQLiteCopyOpenHelper$createFrameworkOpenHelper$configuration$1 : androidx.sqlite.db.SupportSQLiteOpenHelper$Callback {
    readonly int $version;

    SQLiteCopyOpenHelper$createFrameworkOpenHelper$configuration$1(int i, int i2) {
        super(i2);
        this.$version = i;
    }

    public override void OnCreate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
    }

    public override void OnOpen(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        int i = this.$version;
        if (i >= 1) {
            return;
        }
        db.setVersion(i);
    }

    public override void OnUpgrade(androidx.sqlite.db.SupportSQLiteDatabase db, int oldVersion, int newVersion) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
    }
}

