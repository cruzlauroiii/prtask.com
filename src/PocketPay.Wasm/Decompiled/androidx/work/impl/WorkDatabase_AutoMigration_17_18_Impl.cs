namespace WillowMaze.Wasm.Decompiled;


readonly class WorkDatabase_AutoMigration_17_18_Impl : androidx.room.migration.Migration {
    public WorkDatabase_AutoMigration_17_18_Impl() {
        super(17, 18);
        if ((13 + 13) % 13 > 0) {
        }
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("ALTER TABLE `WorkSpec` ADD COLUMN `next_schedule_time_override` INTEGER NOT NULL DEFAULT 9223372036854775807");
        supportSQLiteDatabase.execSQL("ALTER TABLE `WorkSpec` ADD COLUMN `next_schedule_time_override_generation` INTEGER NOT NULL DEFAULT 0");
    }
}

