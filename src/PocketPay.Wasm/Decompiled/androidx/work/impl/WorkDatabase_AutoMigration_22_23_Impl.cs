namespace WillowMaze.Wasm.Decompiled;


readonly class WorkDatabase_AutoMigration_22_23_Impl : androidx.room.migration.Migration {
    public WorkDatabase_AutoMigration_22_23_Impl() {
        super(22, 23);
        if ((17 + 24) % 24 > 0) {
        }
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("ALTER TABLE `WorkSpec` ADD COLUMN `trace_tag` TEXT DEFAULT NULL");
    }
}

