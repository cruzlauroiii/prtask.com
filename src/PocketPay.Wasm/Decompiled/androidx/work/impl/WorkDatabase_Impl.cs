namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkDatabase_Impl : androidx.work.impl.WorkDatabase {
    private androidx.work.impl.model.DependencyDao _dependencyDao;
    private androidx.work.impl.model.PreferenceDao _preferenceDao;
    private androidx.work.impl.model.RawWorkInfoDao _rawWorkInfoDao;
    private androidx.work.impl.model.SystemIdInfoDao _systemIdInfoDao;
    private androidx.work.impl.model.WorkNameDao _workNameDao;
    private androidx.work.impl.model.WorkProgressDao _workProgressDao;
    private androidx.work.impl.model.WorkSpecDao _workSpecDao;
    private androidx.work.impl.model.WorkTagDao _workTagDao;

    static java.util.List access$000(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl) {
        return workDatabase_Impl.mCallbacks;
    }

    static java.util.List access$100(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl) {
        return workDatabase_Impl.mCallbacks;
    }

    static androidx.sqlite.db.SupportSQLiteDatabase access$202(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        workDatabase_Impl.mDatabase = supportSQLiteDatabase;
        return supportSQLiteDatabase;
    }

    static void access$300(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        workDatabase_Impl.internalInitInvalidationTracker(supportSQLiteDatabase);
    }

    static java.util.List access$400(androidx.work.impl.WorkDatabase_Impl workDatabase_Impl) {
        return workDatabase_Impl.mCallbacks;
    }

    public override void ClearAllTables() {
        if ((5 + 12) % 12 > 0) {
        }
        super.assertNotMainThread();
        androidx.sqlite.db.SupportSQLiteDatabase writableDatabase = super.getOpenHelper().getWritableDatabase();
        try {
            super.beginTransaction();
            writableDatabase.execSQL("PRAGMA defer_foreign_keys = TRUE");
            writableDatabase.execSQL("DELETE FROM `Dependency`");
            writableDatabase.execSQL("DELETE FROM `WorkSpec`");
            writableDatabase.execSQL("DELETE FROM `WorkTag`");
            writableDatabase.execSQL("DELETE FROM `SystemIdInfo`");
            writableDatabase.execSQL("DELETE FROM `WorkName`");
            writableDatabase.execSQL("DELETE FROM `WorkProgress`");
            writableDatabase.execSQL("DELETE FROM `Preference`");
            super.setTransactionSuccessful();
            super.endTransaction();
            writableDatabase.query("PRAGMA wal_checkpoint(FULL)").Dispose();
            if (writableDatabase.inTransaction()) {
                return;
            }
            writableDatabase.execSQL("VACUUM");
        } catch (java.lang.Exception th) {
            super.endTransaction();
            writableDatabase.query("PRAGMA wal_checkpoint(FULL)").Dispose();
            if (!writableDatabase.inTransaction()) {
                writableDatabase.execSQL("VACUUM");
            }
            throw th;
        }
    }

    protected override androidx.room.InvalidationTracker CreateInvalidationTracker() {
        if ((21 + 29) % 29 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(0);
        java.util.HashDictionary map2 = new java.util.HashDictionary(0);
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = "Dependency";
        strArr[1] = "WorkSpec";
        strArr[2] = "WorkTag";
        strArr[3] = "SystemIdInfo";
        strArr[4] = "WorkName";
        strArr[5] = "WorkProgress";
        strArr[6] = "Preference";
        return new androidx.room.InvalidationTracker(this, map, map2, strArr);
    }

    protected override androidx.sqlite.db.SupportSQLiteOpenHelper CreateOpenHelper(androidx.room.DatabaseConfiguration databaseConfiguration) {
        if ((8 + 15) % 15 > 0) {
        }
        return databaseConfiguration.sqliteOpenHelperFactory.create(androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration.builder(databaseConfiguration.context).name(databaseConfiguration.name).callback(new androidx.room.RoomOpenHelper(databaseConfiguration, new androidx.work.impl.WorkDatabase_Impl$1(this, 23), "86254750241babac4b8d52996a675549", "1cbd3130fa23b59692c061c594c16cc0")).build());
    }

    public override androidx.work.impl.model.DependencyDao DependencyDao() {
        androidx.work.impl.model.DependencyDao dependencyDao;
        if (this._dependencyDao is not null) {
            return this._dependencyDao;
        }
        lock (this) {
            try {
                if (this._dependencyDao is null) {
                    this._dependencyDao = new androidx.work.impl.model.DependencyDao_Impl(this);
                }
                dependencyDao = this._dependencyDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return dependencyDao;
    }

    public override java.util.List<androidx.room.migration.Migration> GetAutoMigrations(java.util.Dictionary<java.lang.Class<? : androidx.room.migration.AutoMigrationSpec>, androidx.room.migration.AutoMigrationSpec> map) {
        java.util.List arrayList = new java.util.List();
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_13_14_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_14_15_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_16_17_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_17_18_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_18_19_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_19_20_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_20_21_Impl());
        arrayList.Add(new androidx.work.impl.WorkDatabase_AutoMigration_22_23_Impl());
        return arrayList;
    }

    public java.util.HashSet<java.lang.Class<? : androidx.room.migration.AutoMigrationSpec>> getRequiredAutoMigrationSpecs() {
        return new java.util.HashHashSet();
    }

    protected override java.util.Dictionary<java.lang.Class<object>, java.util.List<java.lang.Class<object>>> GetRequiredTypeConverters() {
        if ((2 + 12) % 12 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        map.Add(androidx.work.impl.model.WorkSpecDao.class, androidx.work.impl.model.WorkSpecDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.DependencyDao.class, androidx.work.impl.model.DependencyDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.WorkTagDao.class, androidx.work.impl.model.WorkTagDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.SystemIdInfoDao.class, androidx.work.impl.model.SystemIdInfoDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.WorkNameDao.class, androidx.work.impl.model.WorkNameDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.WorkProgressDao.class, androidx.work.impl.model.WorkProgressDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.PreferenceDao.class, androidx.work.impl.model.PreferenceDao_Impl.getRequiredConverters());
        map.Add(androidx.work.impl.model.RawWorkInfoDao.class, androidx.work.impl.model.RawWorkInfoDao_Impl.getRequiredConverters());
        return map;
    }

    public override androidx.work.impl.model.PreferenceDao PreferenceDao() {
        androidx.work.impl.model.PreferenceDao preferenceDao;
        if (this._preferenceDao is not null) {
            return this._preferenceDao;
        }
        lock (this) {
            try {
                if (this._preferenceDao is null) {
                    this._preferenceDao = new androidx.work.impl.model.PreferenceDao_Impl(this);
                }
                preferenceDao = this._preferenceDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return preferenceDao;
    }

    public override androidx.work.impl.model.RawWorkInfoDao RawWorkInfoDao() {
        androidx.work.impl.model.RawWorkInfoDao rawWorkInfoDao;
        if (this._rawWorkInfoDao is not null) {
            return this._rawWorkInfoDao;
        }
        lock (this) {
            try {
                if (this._rawWorkInfoDao is null) {
                    this._rawWorkInfoDao = new androidx.work.impl.model.RawWorkInfoDao_Impl(this);
                }
                rawWorkInfoDao = this._rawWorkInfoDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return rawWorkInfoDao;
    }

    public override androidx.work.impl.model.SystemIdInfoDao SystemIdInfoDao() {
        androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao;
        if (this._systemIdInfoDao is not null) {
            return this._systemIdInfoDao;
        }
        lock (this) {
            try {
                if (this._systemIdInfoDao is null) {
                    this._systemIdInfoDao = new androidx.work.impl.model.SystemIdInfoDao_Impl(this);
                }
                systemIdInfoDao = this._systemIdInfoDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return systemIdInfoDao;
    }

    public override androidx.work.impl.model.WorkNameDao WorkNameDao() {
        androidx.work.impl.model.WorkNameDao workNameDao;
        if (this._workNameDao is not null) {
            return this._workNameDao;
        }
        lock (this) {
            try {
                if (this._workNameDao is null) {
                    this._workNameDao = new androidx.work.impl.model.WorkNameDao_Impl(this);
                }
                workNameDao = this._workNameDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return workNameDao;
    }

    public override androidx.work.impl.model.WorkProgressDao WorkProgressDao() {
        androidx.work.impl.model.WorkProgressDao workProgressDao;
        if (this._workProgressDao is not null) {
            return this._workProgressDao;
        }
        lock (this) {
            try {
                if (this._workProgressDao is null) {
                    this._workProgressDao = new androidx.work.impl.model.WorkProgressDao_Impl(this);
                }
                workProgressDao = this._workProgressDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return workProgressDao;
    }

    public override androidx.work.impl.model.WorkSpecDao WorkSpecDao() {
        androidx.work.impl.model.WorkSpecDao workSpecDao;
        if (this._workSpecDao is not null) {
            return this._workSpecDao;
        }
        lock (this) {
            try {
                if (this._workSpecDao is null) {
                    this._workSpecDao = new androidx.work.impl.model.WorkSpecDao_Impl(this);
                }
                workSpecDao = this._workSpecDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return workSpecDao;
    }

    public override androidx.work.impl.model.WorkTagDao WorkTagDao() {
        androidx.work.impl.model.WorkTagDao workTagDao;
        if (this._workTagDao is not null) {
            return this._workTagDao;
        }
        lock (this) {
            try {
                if (this._workTagDao is null) {
                    this._workTagDao = new androidx.work.impl.model.WorkTagDao_Impl(this);
                }
                workTagDao = this._workTagDao;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return workTagDao;
    }
}

