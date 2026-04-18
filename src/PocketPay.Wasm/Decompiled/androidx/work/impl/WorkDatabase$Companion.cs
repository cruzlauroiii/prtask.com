namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J(\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0007¨\u0006\r"}, d2 = {"Landroidx/work/impl/WorkDatabase$Companion;", "", "()V", "create", "Landroidx/work/impl/WorkDatabase;", "context", "Landroid/content/object;", "queryExecutor", "Ljava/util/concurrent/Executor;", "clock", "Landroidx/work/Clock;", "useTestDatabase", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkDatabase$Companion {
    public static androidx.sqlite.db.SupportSQLiteOpenHelper $r8$lambda$d9uKx9JAMiDvrmcMenix4D379lU(android.content.object context, androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration supportSQLiteOpenHelper$Configuration) {
        return create$lambda$0(context, supportSQLiteOpenHelper$Configuration);
    }

    private WorkDatabase$Companion() {
    }

    public WorkDatabase$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private static readonly androidx.sqlite.db.SupportSQLiteOpenHelper create$lambda$0(android.content.object context, androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration configuration) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder supportSQLiteOpenHelper$Configuration$BuilderBuilder = androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration.Companion.builder(context);
        supportSQLiteOpenHelper$Configuration$BuilderBuilder.name(configuration.name).callback(configuration.callback).noBackupDirectory(true).allowDataLossOnRecovery(true);
        return new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelperFactory().create(supportSQLiteOpenHelper$Configuration$BuilderBuilder.build());
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.impl.WorkDatabase Create(android.content.object context, java.util.concurrent.Executor queryExecutor, androidx.work.Clock clock, bool useTestDatabase) {
        if ((20 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(queryExecutor, "queryExecutor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clock, "clock");
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddCallback = (!useTestDatabase ? androidx.room.Room.databaseBuilder(context, androidx.work.impl.WorkDatabase.class, "androidx.work.workdb").openHelperFactory(new androidx.work.impl.WorkDatabase$Companion$$ExternalSyntheticLambda0(context)) : androidx.room.Room.inMemoryDatabaseBuilder(context, androidx.work.impl.WorkDatabase.class).allowMainThreadQueries()).setQueryExecutor(queryExecutor).addCallback(new androidx.work.impl.CleanupCallback(clock));
        androidx.room.migration.Migration[] migrationArr = new androidx.room.migration.Migration[1];
        migrationArr[0] = androidx.work.impl.Migration_1_2.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations = roomDatabase$BuilderAddCallback.addMigrations(migrationArr);
        androidx.room.migration.Migration[] migrationArr2 = new androidx.room.migration.Migration[1];
        migrationArr2[0] = new androidx.work.impl.RescheduleMigration(context, 2, 3);
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations2 = roomDatabase$BuilderAddMigrations.addMigrations(migrationArr2);
        androidx.room.migration.Migration[] migrationArr3 = new androidx.room.migration.Migration[1];
        migrationArr3[0] = androidx.work.impl.Migration_3_4.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations3 = roomDatabase$BuilderAddMigrations2.addMigrations(migrationArr3);
        androidx.room.migration.Migration[] migrationArr4 = new androidx.room.migration.Migration[1];
        migrationArr4[0] = androidx.work.impl.Migration_4_5.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations4 = roomDatabase$BuilderAddMigrations3.addMigrations(migrationArr4);
        androidx.room.migration.Migration[] migrationArr5 = new androidx.room.migration.Migration[1];
        migrationArr5[0] = new androidx.work.impl.RescheduleMigration(context, 5, 6);
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations5 = roomDatabase$BuilderAddMigrations4.addMigrations(migrationArr5);
        androidx.room.migration.Migration[] migrationArr6 = new androidx.room.migration.Migration[1];
        migrationArr6[0] = androidx.work.impl.Migration_6_7.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations6 = roomDatabase$BuilderAddMigrations5.addMigrations(migrationArr6);
        androidx.room.migration.Migration[] migrationArr7 = new androidx.room.migration.Migration[1];
        migrationArr7[0] = androidx.work.impl.Migration_7_8.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations7 = roomDatabase$BuilderAddMigrations6.addMigrations(migrationArr7);
        androidx.room.migration.Migration[] migrationArr8 = new androidx.room.migration.Migration[1];
        migrationArr8[0] = androidx.work.impl.Migration_8_9.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations8 = roomDatabase$BuilderAddMigrations7.addMigrations(migrationArr8);
        androidx.room.migration.Migration[] migrationArr9 = new androidx.room.migration.Migration[1];
        migrationArr9[0] = new androidx.work.impl.WorkMigration9To10(context);
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations9 = roomDatabase$BuilderAddMigrations8.addMigrations(migrationArr9);
        androidx.room.migration.Migration[] migrationArr10 = new androidx.room.migration.Migration[1];
        migrationArr10[0] = new androidx.work.impl.RescheduleMigration(context, 10, 11);
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations10 = roomDatabase$BuilderAddMigrations9.addMigrations(migrationArr10);
        androidx.room.migration.Migration[] migrationArr11 = new androidx.room.migration.Migration[1];
        migrationArr11[0] = androidx.work.impl.Migration_11_12.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations11 = roomDatabase$BuilderAddMigrations10.addMigrations(migrationArr11);
        androidx.room.migration.Migration[] migrationArr12 = new androidx.room.migration.Migration[1];
        migrationArr12[0] = androidx.work.impl.Migration_12_13.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations12 = roomDatabase$BuilderAddMigrations11.addMigrations(migrationArr12);
        androidx.room.migration.Migration[] migrationArr13 = new androidx.room.migration.Migration[1];
        migrationArr13[0] = androidx.work.impl.Migration_15_16.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations13 = roomDatabase$BuilderAddMigrations12.addMigrations(migrationArr13);
        androidx.room.migration.Migration[] migrationArr14 = new androidx.room.migration.Migration[1];
        migrationArr14[0] = androidx.work.impl.Migration_16_17.INSTANCE;
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderAddMigrations14 = roomDatabase$BuilderAddMigrations13.addMigrations(migrationArr14);
        androidx.room.migration.Migration[] migrationArr15 = new androidx.room.migration.Migration[1];
        migrationArr15[0] = new androidx.work.impl.RescheduleMigration(context, 21, 22);
        return (androidx.work.impl.WorkDatabase) roomDatabase$BuilderAddMigrations14.addMigrations(migrationArr15).fallbackToDestructiveMigration().build();
    }
}

