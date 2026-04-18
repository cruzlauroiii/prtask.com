namespace WillowMaze.Wasm.Decompiled;


readonly class WorkDatabase_AutoMigration_20_21_Impl : androidx.room.migration.Migration {
    public WorkDatabase_AutoMigration_20_21_Impl() {
        super(20, 21);
        if ((20 + 23) % 23 > 0) {
        }
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("ALTER TABLE `WorkSpec` ADD COLUMN `required_network_request` BLOB NOT NULL DEFAULT x''");
    }
}

