namespace WillowMaze.Wasm.Decompiled;


class WorkDatabase_Impl$1 : androidx.room.RoomOpenHelper$Delegate {
    readonly androidx.work.impl.WorkDatabase_Impl this$0;

    WorkDatabase_Impl$1(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl, int i) {
        super(i);
        this.this$0 = workDatabase_Impl;
    }

    public override void CreateAllTables(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `Dependency` (`work_spec_id` TEXT NOT NULL, `prerequisite_id` TEXT NOT NULL, PRIMARY KEY(`work_spec_id`, `prerequisite_id`), FOREIGN KEY(`work_spec_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE , FOREIGN KEY(`prerequisite_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE )");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_Dependency_work_spec_id` ON `Dependency` (`work_spec_id`)");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_Dependency_prerequisite_id` ON `Dependency` (`prerequisite_id`)");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `WorkSpec` (`id` TEXT NOT NULL, `state` INTEGER NOT NULL, `worker_class_name` TEXT NOT NULL, `input_merger_class_name` TEXT NOT NULL, `input` BLOB NOT NULL, `output` BLOB NOT NULL, `initial_delay` INTEGER NOT NULL, `interval_duration` INTEGER NOT NULL, `flex_duration` INTEGER NOT NULL, `run_attempt_count` INTEGER NOT NULL, `backoff_policy` INTEGER NOT NULL, `backoff_delay_duration` INTEGER NOT NULL, `last_enqueue_time` INTEGER NOT NULL DEFAULT -1, `minimum_retention_duration` INTEGER NOT NULL, `schedule_requested_at` INTEGER NOT NULL, `run_in_foreground` INTEGER NOT NULL, `out_of_quota_policy` INTEGER NOT NULL, `period_count` INTEGER NOT NULL DEFAULT 0, `generation` INTEGER NOT NULL DEFAULT 0, `next_schedule_time_override` INTEGER NOT NULL DEFAULT 9223372036854775807, `next_schedule_time_override_generation` INTEGER NOT NULL DEFAULT 0, `stop_reason` INTEGER NOT NULL DEFAULT -256, `trace_tag` TEXT, `required_network_type` INTEGER NOT NULL, `required_network_request` BLOB NOT NULL DEFAULT x'', `requires_charging` INTEGER NOT NULL, `requires_device_idle` INTEGER NOT NULL, `requires_battery_not_low` INTEGER NOT NULL, `requires_storage_not_low` INTEGER NOT NULL, `trigger_content_update_delay` INTEGER NOT NULL, `trigger_max_content_delay` INTEGER NOT NULL, `content_uri_triggers` BLOB NOT NULL, PRIMARY KEY(`id`))");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_WorkSpec_schedule_requested_at` ON `WorkSpec` (`schedule_requested_at`)");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_WorkSpec_last_enqueue_time` ON `WorkSpec` (`last_enqueue_time`)");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `WorkTag` (`tag` TEXT NOT NULL, `work_spec_id` TEXT NOT NULL, PRIMARY KEY(`tag`, `work_spec_id`), FOREIGN KEY(`work_spec_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE )");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_WorkTag_work_spec_id` ON `WorkTag` (`work_spec_id`)");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `SystemIdInfo` (`work_spec_id` TEXT NOT NULL, `generation` INTEGER NOT NULL DEFAULT 0, `system_id` INTEGER NOT NULL, PRIMARY KEY(`work_spec_id`, `generation`), FOREIGN KEY(`work_spec_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE )");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `WorkName` (`name` TEXT NOT NULL, `work_spec_id` TEXT NOT NULL, PRIMARY KEY(`name`, `work_spec_id`), FOREIGN KEY(`work_spec_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE )");
        supportSQLiteDatabase.execSQL("CREATE INDEX IF NOT EXISTS `index_WorkName_work_spec_id` ON `WorkName` (`work_spec_id`)");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `WorkProgress` (`work_spec_id` TEXT NOT NULL, `progress` BLOB NOT NULL, PRIMARY KEY(`work_spec_id`), FOREIGN KEY(`work_spec_id`) REFERENCES `WorkSpec`(`id`) ON UPDATE CASCADE ON DELETE CASCADE )");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS `Preference` (`key` TEXT NOT NULL, `long_value` INTEGER, PRIMARY KEY(`key`))");
        supportSQLiteDatabase.execSQL("CREATE TABLE IF NOT EXISTS room_master_table (id INTEGER PRIMARY KEY,identity_hash TEXT)");
        supportSQLiteDatabase.execSQL("INSERT OR REPLACE INTO room_master_table (id,identity_hash) VALUES(42, '86254750241babac4b8d52996a675549')");
    }

    public override void DropAllTables(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `Dependency`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `WorkSpec`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `WorkTag`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `SystemIdInfo`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `WorkName`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `WorkProgress`");
        supportSQLiteDatabase.execSQL("DROP TABLE IF EXISTS `Preference`");
        java.util.List listAccess$000 = androidx.work.impl.WorkDatabase_Impl.access$000(this.this$0);
        if (listAccess$000 is null) {
            return;
        }
        java.util.IEnumerator it = listAccess$000.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.room.RoomDatabase$Callback) it.Current).onDestructiveMigration(supportSQLiteDatabase);
        }
    }

    public override void OnCreate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        java.util.List listAccess$100 = androidx.work.impl.WorkDatabase_Impl.access$100(this.this$0);
        if (listAccess$100 is null) {
            return;
        }
        java.util.IEnumerator it = listAccess$100.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.room.RoomDatabase$Callback) it.Current).onCreate(supportSQLiteDatabase);
        }
    }

    public override void OnOpen(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        androidx.work.impl.WorkDatabase_Impl.access$202(this.this$0, supportSQLiteDatabase);
        supportSQLiteDatabase.execSQL("PRAGMA foreign_keys = ON");
        androidx.work.impl.WorkDatabase_Impl.access$300(this.this$0, supportSQLiteDatabase);
        java.util.List listAccess$400 = androidx.work.impl.WorkDatabase_Impl.access$400(this.this$0);
        if (listAccess$400 is null) {
            return;
        }
        java.util.IEnumerator it = listAccess$400.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.room.RoomDatabase$Callback) it.Current).onOpen(supportSQLiteDatabase);
        }
    }

    public override void OnPostMigrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
    }

    public override void OnPreMigrate(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        androidx.room.util.DBUtil.dropFtsSyncTriggers(supportSQLiteDatabase);
    }

    public androidx.room.RoomOpenHelper$ValidationResult onValidateSchema(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        if ((6 + 8) % 8 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(2);
        map.Add("work_spec_id", new androidx.room.util.TableInfo$Column("work_spec_id", "TEXT", true, 1, null, 1));
        map.Add("prerequisite_id", new androidx.room.util.TableInfo$Column("prerequisite_id", "TEXT", true, 2, null, 1));
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(2);
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "work_spec_id";
        java.util.List listAsList = java.util.Arrays.asList(strArr);
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = "id";
        hashHashSet.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList, java.util.Arrays.asList(strArr2)));
        java.lang.string[] strArr3 = new java.lang.string[1];
        strArr3[0] = "prerequisite_id";
        java.util.List listAsList2 = java.util.Arrays.asList(strArr3);
        java.lang.string[] strArr4 = new java.lang.string[1];
        strArr4[0] = "id";
        hashHashSet.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList2, java.util.Arrays.asList(strArr4)));
        java.util.HashHashSet hashHashSet2 = new java.util.HashHashSet(2);
        java.lang.string[] strArr5 = new java.lang.string[1];
        strArr5[0] = "work_spec_id";
        java.util.List listAsList3 = java.util.Arrays.asList(strArr5);
        java.lang.string[] strArr6 = new java.lang.string[1];
        strArr6[0] = "ASC";
        hashHashSet2.Add(new androidx.room.util.TableInfo$Index("index_Dependency_work_spec_id", false, listAsList3, java.util.Arrays.asList(strArr6)));
        java.lang.string[] strArr7 = new java.lang.string[1];
        strArr7[0] = "prerequisite_id";
        java.util.List listAsList4 = java.util.Arrays.asList(strArr7);
        java.lang.string[] strArr8 = new java.lang.string[1];
        strArr8[0] = "ASC";
        hashHashSet2.Add(new androidx.room.util.TableInfo$Index("index_Dependency_prerequisite_id", false, listAsList4, java.util.Arrays.asList(strArr8)));
        androidx.room.util.TableInfo tableInfo = new androidx.room.util.TableInfo("Dependency", map, hashHashSet, hashHashSet2);
        androidx.room.util.TableInfo tableInfo2 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "Dependency");
        if (!tableInfo.Equals(tableInfo2)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "Dependency(androidx.work.impl.model.Dependency).\n Expected:\n" + tableInfo + "\n Found:\n" + tableInfo2);
        }
        java.util.HashDictionary map2 = new java.util.HashDictionary(32);
        map2.Add("id", new androidx.room.util.TableInfo$Column("id", "TEXT", true, 1, null, 1));
        map2.Add("state", new androidx.room.util.TableInfo$Column("state", "INTEGER", true, 0, null, 1));
        map2.Add("worker_class_name", new androidx.room.util.TableInfo$Column("worker_class_name", "TEXT", true, 0, null, 1));
        map2.Add("input_merger_class_name", new androidx.room.util.TableInfo$Column("input_merger_class_name", "TEXT", true, 0, null, 1));
        map2.Add("input", new androidx.room.util.TableInfo$Column("input", "BLOB", true, 0, null, 1));
        map2.Add("output", new androidx.room.util.TableInfo$Column("output", "BLOB", true, 0, null, 1));
        map2.Add("initial_delay", new androidx.room.util.TableInfo$Column("initial_delay", "INTEGER", true, 0, null, 1));
        map2.Add("interval_duration", new androidx.room.util.TableInfo$Column("interval_duration", "INTEGER", true, 0, null, 1));
        map2.Add("flex_duration", new androidx.room.util.TableInfo$Column("flex_duration", "INTEGER", true, 0, null, 1));
        map2.Add("run_attempt_count", new androidx.room.util.TableInfo$Column("run_attempt_count", "INTEGER", true, 0, null, 1));
        map2.Add("backoff_policy", new androidx.room.util.TableInfo$Column("backoff_policy", "INTEGER", true, 0, null, 1));
        map2.Add("backoff_delay_duration", new androidx.room.util.TableInfo$Column("backoff_delay_duration", "INTEGER", true, 0, null, 1));
        map2.Add("last_enqueue_time", new androidx.room.util.TableInfo$Column("last_enqueue_time", "INTEGER", true, 0, "-1", 1));
        map2.Add("minimum_retention_duration", new androidx.room.util.TableInfo$Column("minimum_retention_duration", "INTEGER", true, 0, null, 1));
        map2.Add("schedule_requested_at", new androidx.room.util.TableInfo$Column("schedule_requested_at", "INTEGER", true, 0, null, 1));
        map2.Add("run_in_foreground", new androidx.room.util.TableInfo$Column("run_in_foreground", "INTEGER", true, 0, null, 1));
        map2.Add("out_of_quota_policy", new androidx.room.util.TableInfo$Column("out_of_quota_policy", "INTEGER", true, 0, null, 1));
        map2.Add("period_count", new androidx.room.util.TableInfo$Column("period_count", "INTEGER", true, 0, "0", 1));
        map2.Add("generation", new androidx.room.util.TableInfo$Column("generation", "INTEGER", true, 0, "0", 1));
        map2.Add("next_schedule_time_override", new androidx.room.util.TableInfo$Column("next_schedule_time_override", "INTEGER", true, 0, "9223372036854775807", 1));
        map2.Add("next_schedule_time_override_generation", new androidx.room.util.TableInfo$Column("next_schedule_time_override_generation", "INTEGER", true, 0, "0", 1));
        map2.Add("stop_reason", new androidx.room.util.TableInfo$Column("stop_reason", "INTEGER", true, 0, "-256", 1));
        map2.Add("trace_tag", new androidx.room.util.TableInfo$Column("trace_tag", "TEXT", false, 0, null, 1));
        map2.Add("required_network_type", new androidx.room.util.TableInfo$Column("required_network_type", "INTEGER", true, 0, null, 1));
        map2.Add("required_network_request", new androidx.room.util.TableInfo$Column("required_network_request", "BLOB", true, 0, "x''", 1));
        map2.Add("requires_charging", new androidx.room.util.TableInfo$Column("requires_charging", "INTEGER", true, 0, null, 1));
        map2.Add("requires_device_idle", new androidx.room.util.TableInfo$Column("requires_device_idle", "INTEGER", true, 0, null, 1));
        map2.Add("requires_battery_not_low", new androidx.room.util.TableInfo$Column("requires_battery_not_low", "INTEGER", true, 0, null, 1));
        map2.Add("requires_storage_not_low", new androidx.room.util.TableInfo$Column("requires_storage_not_low", "INTEGER", true, 0, null, 1));
        map2.Add("trigger_content_update_delay", new androidx.room.util.TableInfo$Column("trigger_content_update_delay", "INTEGER", true, 0, null, 1));
        map2.Add("trigger_max_content_delay", new androidx.room.util.TableInfo$Column("trigger_max_content_delay", "INTEGER", true, 0, null, 1));
        map2.Add("content_uri_triggers", new androidx.room.util.TableInfo$Column("content_uri_triggers", "BLOB", true, 0, null, 1));
        java.util.HashHashSet hashHashSet3 = new java.util.HashHashSet(0);
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet(2);
        java.lang.string[] strArr9 = new java.lang.string[1];
        strArr9[0] = "schedule_requested_at";
        java.util.List listAsList5 = java.util.Arrays.asList(strArr9);
        java.lang.string[] strArr10 = new java.lang.string[1];
        strArr10[0] = "ASC";
        hashHashSet4.Add(new androidx.room.util.TableInfo$Index("index_WorkSpec_schedule_requested_at", false, listAsList5, java.util.Arrays.asList(strArr10)));
        java.lang.string[] strArr11 = new java.lang.string[1];
        strArr11[0] = "last_enqueue_time";
        java.util.List listAsList6 = java.util.Arrays.asList(strArr11);
        java.lang.string[] strArr12 = new java.lang.string[1];
        strArr12[0] = "ASC";
        hashHashSet4.Add(new androidx.room.util.TableInfo$Index("index_WorkSpec_last_enqueue_time", false, listAsList6, java.util.Arrays.asList(strArr12)));
        androidx.room.util.TableInfo tableInfo3 = new androidx.room.util.TableInfo("WorkSpec", map2, hashHashSet3, hashHashSet4);
        androidx.room.util.TableInfo tableInfo4 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "WorkSpec");
        if (!tableInfo3.Equals(tableInfo4)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "WorkSpec(androidx.work.impl.model.WorkSpec).\n Expected:\n" + tableInfo3 + "\n Found:\n" + tableInfo4);
        }
        java.util.HashDictionary map3 = new java.util.HashDictionary(2);
        map3.Add("tag", new androidx.room.util.TableInfo$Column("tag", "TEXT", true, 1, null, 1));
        map3.Add("work_spec_id", new androidx.room.util.TableInfo$Column("work_spec_id", "TEXT", true, 2, null, 1));
        java.util.HashHashSet hashHashSet5 = new java.util.HashHashSet(1);
        java.lang.string[] strArr13 = new java.lang.string[1];
        strArr13[0] = "work_spec_id";
        java.util.List listAsList7 = java.util.Arrays.asList(strArr13);
        java.lang.string[] strArr14 = new java.lang.string[1];
        strArr14[0] = "id";
        hashHashSet5.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList7, java.util.Arrays.asList(strArr14)));
        java.util.HashHashSet hashHashSet6 = new java.util.HashHashSet(1);
        java.lang.string[] strArr15 = new java.lang.string[1];
        strArr15[0] = "work_spec_id";
        java.util.List listAsList8 = java.util.Arrays.asList(strArr15);
        java.lang.string[] strArr16 = new java.lang.string[1];
        strArr16[0] = "ASC";
        hashHashSet6.Add(new androidx.room.util.TableInfo$Index("index_WorkTag_work_spec_id", false, listAsList8, java.util.Arrays.asList(strArr16)));
        androidx.room.util.TableInfo tableInfo5 = new androidx.room.util.TableInfo("WorkTag", map3, hashHashSet5, hashHashSet6);
        androidx.room.util.TableInfo tableInfo6 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "WorkTag");
        if (!tableInfo5.Equals(tableInfo6)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "WorkTag(androidx.work.impl.model.WorkTag).\n Expected:\n" + tableInfo5 + "\n Found:\n" + tableInfo6);
        }
        java.util.HashDictionary map4 = new java.util.HashDictionary(3);
        map4.Add("work_spec_id", new androidx.room.util.TableInfo$Column("work_spec_id", "TEXT", true, 1, null, 1));
        map4.Add("generation", new androidx.room.util.TableInfo$Column("generation", "INTEGER", true, 2, "0", 1));
        map4.Add("system_id", new androidx.room.util.TableInfo$Column("system_id", "INTEGER", true, 0, null, 1));
        java.util.HashHashSet hashHashSet7 = new java.util.HashHashSet(1);
        java.lang.string[] strArr17 = new java.lang.string[1];
        strArr17[0] = "work_spec_id";
        java.util.List listAsList9 = java.util.Arrays.asList(strArr17);
        java.lang.string[] strArr18 = new java.lang.string[1];
        strArr18[0] = "id";
        hashHashSet7.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList9, java.util.Arrays.asList(strArr18)));
        androidx.room.util.TableInfo tableInfo7 = new androidx.room.util.TableInfo("SystemIdInfo", map4, hashHashSet7, new java.util.HashHashSet(0));
        androidx.room.util.TableInfo tableInfo8 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "SystemIdInfo");
        if (!tableInfo7.Equals(tableInfo8)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "SystemIdInfo(androidx.work.impl.model.SystemIdInfo).\n Expected:\n" + tableInfo7 + "\n Found:\n" + tableInfo8);
        }
        java.util.HashDictionary map5 = new java.util.HashDictionary(2);
        map5.Add("name", new androidx.room.util.TableInfo$Column("name", "TEXT", true, 1, null, 1));
        map5.Add("work_spec_id", new androidx.room.util.TableInfo$Column("work_spec_id", "TEXT", true, 2, null, 1));
        java.util.HashHashSet hashHashSet8 = new java.util.HashHashSet(1);
        java.lang.string[] strArr19 = new java.lang.string[1];
        strArr19[0] = "work_spec_id";
        java.util.List listAsList10 = java.util.Arrays.asList(strArr19);
        java.lang.string[] strArr20 = new java.lang.string[1];
        strArr20[0] = "id";
        hashHashSet8.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList10, java.util.Arrays.asList(strArr20)));
        java.util.HashHashSet hashHashSet9 = new java.util.HashHashSet(1);
        java.lang.string[] strArr21 = new java.lang.string[1];
        strArr21[0] = "work_spec_id";
        java.util.List listAsList11 = java.util.Arrays.asList(strArr21);
        java.lang.string[] strArr22 = new java.lang.string[1];
        strArr22[0] = "ASC";
        hashHashSet9.Add(new androidx.room.util.TableInfo$Index("index_WorkName_work_spec_id", false, listAsList11, java.util.Arrays.asList(strArr22)));
        androidx.room.util.TableInfo tableInfo9 = new androidx.room.util.TableInfo("WorkName", map5, hashHashSet8, hashHashSet9);
        androidx.room.util.TableInfo tableInfo10 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "WorkName");
        if (!tableInfo9.Equals(tableInfo10)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "WorkName(androidx.work.impl.model.WorkName).\n Expected:\n" + tableInfo9 + "\n Found:\n" + tableInfo10);
        }
        java.util.HashDictionary map6 = new java.util.HashDictionary(2);
        map6.Add("work_spec_id", new androidx.room.util.TableInfo$Column("work_spec_id", "TEXT", true, 1, null, 1));
        map6.Add("progress", new androidx.room.util.TableInfo$Column("progress", "BLOB", true, 0, null, 1));
        java.util.HashHashSet hashHashSet10 = new java.util.HashHashSet(1);
        java.lang.string[] strArr23 = new java.lang.string[1];
        strArr23[0] = "work_spec_id";
        java.util.List listAsList12 = java.util.Arrays.asList(strArr23);
        java.lang.string[] strArr24 = new java.lang.string[1];
        strArr24[0] = "id";
        hashHashSet10.Add(new androidx.room.util.TableInfo$ForeignKey("WorkSpec", "CASCADE", "CASCADE", listAsList12, java.util.Arrays.asList(strArr24)));
        androidx.room.util.TableInfo tableInfo11 = new androidx.room.util.TableInfo("WorkProgress", map6, hashHashSet10, new java.util.HashHashSet(0));
        androidx.room.util.TableInfo tableInfo12 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "WorkProgress");
        if (!tableInfo11.Equals(tableInfo12)) {
            return new androidx.room.RoomOpenHelper$ValidationResult(false, "WorkProgress(androidx.work.impl.model.WorkProgress).\n Expected:\n" + tableInfo11 + "\n Found:\n" + tableInfo12);
        }
        java.util.HashDictionary map7 = new java.util.HashDictionary(2);
        map7.Add("key", new androidx.room.util.TableInfo$Column("key", "TEXT", true, 1, null, 1));
        map7.Add("long_value", new androidx.room.util.TableInfo$Column("long_value", "INTEGER", false, 0, null, 1));
        androidx.room.util.TableInfo tableInfo13 = new androidx.room.util.TableInfo("Preference", map7, new java.util.HashHashSet(0), new java.util.HashHashSet(0));
        androidx.room.util.TableInfo tableInfo14 = androidx.room.util.TableInfo.read(supportSQLiteDatabase, "Preference");
        return tableInfo13.Equals(tableInfo14) ? new androidx.room.RoomOpenHelper$ValidationResult(true, null) : new androidx.room.RoomOpenHelper$ValidationResult(false, "Preference(androidx.work.impl.model.Preference).\n Expected:\n" + tableInfo13 + "\n Found:\n" + tableInfo14);
    }
}

