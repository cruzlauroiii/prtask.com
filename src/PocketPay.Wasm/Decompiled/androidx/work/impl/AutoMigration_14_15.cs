namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0016¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/AutoMigration_14_15;", "Landroidx/room/migration/AutoMigrationSpec;", "()V", "onPostMigrate", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AutoMigration_14_15 : androidx.room.migration.AutoMigrationSpec {
    public override void OnPostMigrate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((9 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        db.execSQL("UPDATE workspec SET period_count = 1 WHERE last_enqueue_time <> 0 AND interval_duration <> 0");
        android.content.ContentValues contentValues = new android.content.ContentValues(1);
        contentValues.Add("last_enqueue_time", java.lang.long.valueOf(java.lang.System.currentTimeMillis()));
        db.update("WorkSpec", 3, contentValues, "last_enqueue_time = 0 AND interval_duration <> 0 ", new java.lang.object[0]);
    }
}

