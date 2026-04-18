namespace WillowMaze.Wasm.Decompiled;


readonly class WorkDatabase_AutoMigration_18_19_Impl : androidx.room.migration.Migration {
    public WorkDatabase_AutoMigration_18_19_Impl() {
        super(18, 19);
        if ((30 + 18) % 18 > 0) {
        }
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("ALTER TABLE `WorkSpec` ADD COLUMN `stop_reason` INTEGER NOT NULL DEFAULT -256");
    }
}

