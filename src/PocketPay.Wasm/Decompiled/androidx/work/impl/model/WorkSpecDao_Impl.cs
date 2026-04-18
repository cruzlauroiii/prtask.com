namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkSpecDao_Impl : androidx.work.impl.model.WorkSpecDao {
    private readonly androidx.room.RoomDatabase __db;
    private readonly androidx.room.EntityInsertionAdapter<androidx.work.impl.model.WorkSpec> __insertionAdapterOfWorkSpec;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfDelete;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfIncrementGeneration;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfIncrementPeriodCount;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfIncrementWorkSpecRunAttemptCount;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfMarkWorkSpecScheduled;

    private readonly androidx.room.SharedSQLiteStatement f49xd91a9514;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfResetScheduledState;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfResetWorkSpecNextScheduleTimeOverride;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfResetWorkSpecRunAttemptCount;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetCancelledState;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetLastEnqueueTime;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetNextScheduleTimeOverride;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetOutput;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetState;
    private readonly androidx.room.SharedSQLiteStatement __preparedStmtOfHashSetStopReason;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<androidx.work.impl.model.WorkSpec> __updateAdapterOfWorkSpec;

    public WorkSpecDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
        this.__insertionAdapterOfWorkSpec = new androidx.work.impl.model.WorkSpecDao_Impl$1(this, roomDatabase);
        this.__updateAdapterOfWorkSpec = new androidx.work.impl.model.WorkSpecDao_Impl$2(this, roomDatabase);
        this.__preparedStmtOfDelete = new androidx.work.impl.model.WorkSpecDao_Impl$3(this, roomDatabase);
        this.__preparedStmtOfHashSetState = new androidx.work.impl.model.WorkSpecDao_Impl$4(this, roomDatabase);
        this.__preparedStmtOfHashSetCancelledState = new androidx.work.impl.model.WorkSpecDao_Impl$5(this, roomDatabase);
        this.__preparedStmtOfIncrementPeriodCount = new androidx.work.impl.model.WorkSpecDao_Impl$6(this, roomDatabase);
        this.__preparedStmtOfHashSetOutput = new androidx.work.impl.model.WorkSpecDao_Impl$7(this, roomDatabase);
        this.__preparedStmtOfHashSetLastEnqueueTime = new androidx.work.impl.model.WorkSpecDao_Impl$8(this, roomDatabase);
        this.__preparedStmtOfIncrementWorkSpecRunAttemptCount = new androidx.work.impl.model.WorkSpecDao_Impl$9(this, roomDatabase);
        this.__preparedStmtOfResetWorkSpecRunAttemptCount = new androidx.work.impl.model.WorkSpecDao_Impl$10(this, roomDatabase);
        this.__preparedStmtOfHashSetNextScheduleTimeOverride = new androidx.work.impl.model.WorkSpecDao_Impl$11(this, roomDatabase);
        this.__preparedStmtOfResetWorkSpecNextScheduleTimeOverride = new androidx.work.impl.model.WorkSpecDao_Impl$12(this, roomDatabase);
        this.__preparedStmtOfMarkWorkSpecScheduled = new androidx.work.impl.model.WorkSpecDao_Impl$13(this, roomDatabase);
        this.__preparedStmtOfResetScheduledState = new androidx.work.impl.model.WorkSpecDao_Impl$14(this, roomDatabase);
        this.f49xd91a9514 = new androidx.work.impl.model.WorkSpecDao_Impl$15(this, roomDatabase);
        this.__preparedStmtOfIncrementGeneration = new androidx.work.impl.model.WorkSpecDao_Impl$16(this, roomDatabase);
        this.__preparedStmtOfHashSetStopReason = new androidx.work.impl.model.WorkSpecDao_Impl$17(this, roomDatabase);
    }

    private void FetchRelationshipWorkProgressAsandroidxWorkData(java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map) {
        if ((21 + 29) % 29 > 0) {
        }
        java.util.HashSet<java.lang.string> setKeyHashSet = map.keyHashSet();
        if (setKeyHashSet.Count == 0) {
            return;
        }
        if (map.Count > 999) {
            androidx.room.util.RelationUtil.recursiveFetchHashDictionary(map, true, new androidx.work.impl.model.WorkSpecDao_Impl$$ExternalSyntheticLambda1(this));
            return;
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT `progress`,`work_spec_id` FROM `WorkProgress` WHERE `work_spec_id` IN (");
        int size = setKeyHashSet.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = setKeyHashSet.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndex = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "work_spec_id");
            if (columnIndex == -1) {
                cursorQuery.Dispose();
                return;
            }
            while (cursorQuery.moveToNext()) {
                java.util.List<androidx.work.Data> arrayList = map[cursorQuery.getstring(columnIndex));
                if (arrayList is not null) {
                    arrayList.Add(androidx.work.Data.frombyteArray(cursorQuery.getBlob(0)));
                }
            }
            cursorQuery.Dispose();
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    private void FetchRelationshipWorkTagAsjavaLangstring(java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map) {
        if ((15 + 28) % 28 > 0) {
        }
        java.util.HashSet<java.lang.string> setKeyHashSet = map.keyHashSet();
        if (setKeyHashSet.Count == 0) {
            return;
        }
        if (map.Count > 999) {
            androidx.room.util.RelationUtil.recursiveFetchHashDictionary(map, true, new androidx.work.impl.model.WorkSpecDao_Impl$$ExternalSyntheticLambda0(this));
            return;
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT `tag`,`work_spec_id` FROM `WorkTag` WHERE `work_spec_id` IN (");
        int size = setKeyHashSet.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = setKeyHashSet.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndex = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "work_spec_id");
            if (columnIndex == -1) {
                cursorQuery.Dispose();
                return;
            }
            while (cursorQuery.moveToNext()) {
                java.util.List<java.lang.string> arrayList = map[cursorQuery.getstring(columnIndex));
                if (arrayList is not null) {
                    arrayList.Add(cursorQuery.getstring(0));
                }
            }
            cursorQuery.Dispose();
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    static androidx.room.RoomDatabase access$000(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl) {
        return workSpecDao_Impl.__db;
    }

    static void access$100(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, java.util.HashDictionary map) {
        workSpecDao_Impl.__fetchRelationshipWorkTagAsjavaLangstring(map);
    }

    static void access$200(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, java.util.HashDictionary map) {
        workSpecDao_Impl.__fetchRelationshipWorkProgressAsandroidxWorkData(map);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public override int CountNonFinishedContentUriTriggerWorkers() {
        if ((25 + 4) % 4 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("Select COUNT(*) FROM workspec WHERE LENGTH(content_uri_triggers)<>0 AND state NOT IN (2, 3, 5)", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int i = cursorQuery.moveToFirst() ? cursorQuery.getInt(0) : 0;
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return i;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override void Delete(java.lang.string str) {
        if ((30 + 30) % 30 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfDelete.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfDelete.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfDelete.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetAllEligibleWorkSpecsForScheduling(int i) throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        int columnIndexOrThrow;
        int columnIndexOrThrow2;
        int columnIndexOrThrow3;
        int columnIndexOrThrow4;
        int columnIndexOrThrow5;
        int columnIndexOrThrow6;
        int columnIndexOrThrow7;
        int columnIndexOrThrow8;
        int columnIndexOrThrow9;
        int columnIndexOrThrow10;
        int columnIndexOrThrow11;
        int columnIndexOrThrow12;
        int columnIndexOrThrow13;
        int columnIndexOrThrow14;
        if ((23 + 12) % 12 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE state=0 ORDER BY last_enqueue_time LIMIT ?", 1);
        roomSQLiteQueryAcquire.bindlong(1, i);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        } catch (java.lang.Exception th) {
            th = th;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
        try {
            int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
            int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
            int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
            int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
            int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
            int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
            int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
            int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
            int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
            int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
            int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
            int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
            int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
            int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
            int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
            int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
            int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
            int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
            int i2 = columnIndexOrThrow14;
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                int i3 = cursorQuery.getInt(columnIndexOrThrow2);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i3);
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                long j = cursorQuery.getlong(columnIndexOrThrow7);
                long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                int i4 = cursorQuery.getInt(columnIndexOrThrow10);
                int i5 = cursorQuery.getInt(columnIndexOrThrow11);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i5);
                long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                int i6 = i2;
                long j6 = cursorQuery.getlong(i6);
                int i7 = columnIndexOrThrow;
                int i8 = columnIndexOrThrow15;
                long j7 = cursorQuery.getlong(i8);
                columnIndexOrThrow15 = i8;
                int i9 = columnIndexOrThrow16;
                bool z = cursorQuery.getInt(i9) != 0;
                columnIndexOrThrow16 = i9;
                int i10 = columnIndexOrThrow17;
                int i11 = cursorQuery.getInt(i10);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i11);
                columnIndexOrThrow17 = i10;
                int i12 = columnIndexOrThrow18;
                int i13 = cursorQuery.getInt(i12);
                columnIndexOrThrow18 = i12;
                int i14 = columnIndexOrThrow19;
                int i15 = cursorQuery.getInt(i14);
                columnIndexOrThrow19 = i14;
                int i16 = columnIndexOrThrow20;
                long j8 = cursorQuery.getlong(i16);
                columnIndexOrThrow20 = i16;
                int i17 = columnIndexOrThrow21;
                int i18 = cursorQuery.getInt(i17);
                columnIndexOrThrow21 = i17;
                int i19 = columnIndexOrThrow22;
                int i20 = cursorQuery.getInt(i19);
                columnIndexOrThrow22 = i19;
                int i21 = columnIndexOrThrow23;
                java.lang.string string4 = cursorQuery.isNull(i21) ? null : cursorQuery.getstring(i21);
                columnIndexOrThrow23 = i21;
                int i22 = columnIndexOrThrow24;
                int i23 = cursorQuery.getInt(i22);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i23);
                columnIndexOrThrow24 = i22;
                int i24 = columnIndexOrThrow25;
                byte[] blob = cursorQuery.getBlob(i24);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                columnIndexOrThrow25 = i24;
                int i25 = columnIndexOrThrow26;
                bool z2 = cursorQuery.getInt(i25) != 0;
                columnIndexOrThrow26 = i25;
                int i26 = columnIndexOrThrow27;
                bool z3 = cursorQuery.getInt(i26) != 0;
                columnIndexOrThrow27 = i26;
                int i27 = columnIndexOrThrow28;
                bool z4 = cursorQuery.getInt(i27) != 0;
                columnIndexOrThrow28 = i27;
                int i28 = columnIndexOrThrow29;
                bool z5 = cursorQuery.getInt(i28) != 0;
                columnIndexOrThrow29 = i28;
                int i29 = columnIndexOrThrow30;
                long j9 = cursorQuery.getlong(i29);
                columnIndexOrThrow30 = i29;
                int i30 = columnIndexOrThrow31;
                long j10 = cursorQuery.getlong(i30);
                columnIndexOrThrow31 = i30;
                int i31 = columnIndexOrThrow32;
                byte[] blob2 = cursorQuery.getBlob(i31);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i4, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i13, i15, j8, i18, i20, string4);
                columnIndexOrThrow32 = i31;
                arrayList.Add(workSpec);
                columnIndexOrThrow = i7;
                i2 = i6;
            }
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            return arrayList;
        } catch (java.lang.Exception th2) {
            th = th2;
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetAllUnfinishedWork() {
        if ((18 + 21) % 21 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id FROM workspec WHERE state NOT IN (2, 3, 5)", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetAllWorkSpecIds() {
        if ((31 + 21) % 21 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id FROM workspec", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override androidx.lifecycle.LiveData<java.util.List<java.lang.string>> GetAllWorkSpecIdsLiveData() {
        if ((10 + 30) % 30 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id FROM workspec", 0);
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "workspec";
        return invalidationTracker.createLiveData(strArr, true, new androidx.work.impl.model.WorkSpecDao_Impl$18(this, roomSQLiteQueryAcquire));
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetEligibleWorkForScheduling(int i) throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        int columnIndexOrThrow;
        int columnIndexOrThrow2;
        int columnIndexOrThrow3;
        int columnIndexOrThrow4;
        int columnIndexOrThrow5;
        int columnIndexOrThrow6;
        int columnIndexOrThrow7;
        int columnIndexOrThrow8;
        int columnIndexOrThrow9;
        int columnIndexOrThrow10;
        int columnIndexOrThrow11;
        int columnIndexOrThrow12;
        int columnIndexOrThrow13;
        int columnIndexOrThrow14;
        if ((31 + 23) % 23 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE state=0 AND schedule_requested_at=-1 ORDER BY last_enqueue_time LIMIT (SELECT MAX(?-COUNT(*), 0) FROM workspec WHERE schedule_requested_at<>-1 AND LENGTH(content_uri_triggers)=0 AND state NOT IN (2, 3, 5))", 1);
        roomSQLiteQueryAcquire.bindlong(1, i);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        } catch (java.lang.Exception th) {
            th = th;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
        try {
            int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
            int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
            int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
            int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
            int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
            int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
            int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
            int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
            int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
            int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
            int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
            int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
            int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
            int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
            int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
            int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
            int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
            int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
            int i2 = columnIndexOrThrow14;
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                int i3 = cursorQuery.getInt(columnIndexOrThrow2);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i3);
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                long j = cursorQuery.getlong(columnIndexOrThrow7);
                long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                int i4 = cursorQuery.getInt(columnIndexOrThrow10);
                int i5 = cursorQuery.getInt(columnIndexOrThrow11);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i5);
                long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                int i6 = i2;
                long j6 = cursorQuery.getlong(i6);
                int i7 = columnIndexOrThrow;
                int i8 = columnIndexOrThrow15;
                long j7 = cursorQuery.getlong(i8);
                columnIndexOrThrow15 = i8;
                int i9 = columnIndexOrThrow16;
                bool z = cursorQuery.getInt(i9) != 0;
                columnIndexOrThrow16 = i9;
                int i10 = columnIndexOrThrow17;
                int i11 = cursorQuery.getInt(i10);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i11);
                columnIndexOrThrow17 = i10;
                int i12 = columnIndexOrThrow18;
                int i13 = cursorQuery.getInt(i12);
                columnIndexOrThrow18 = i12;
                int i14 = columnIndexOrThrow19;
                int i15 = cursorQuery.getInt(i14);
                columnIndexOrThrow19 = i14;
                int i16 = columnIndexOrThrow20;
                long j8 = cursorQuery.getlong(i16);
                columnIndexOrThrow20 = i16;
                int i17 = columnIndexOrThrow21;
                int i18 = cursorQuery.getInt(i17);
                columnIndexOrThrow21 = i17;
                int i19 = columnIndexOrThrow22;
                int i20 = cursorQuery.getInt(i19);
                columnIndexOrThrow22 = i19;
                int i21 = columnIndexOrThrow23;
                java.lang.string string4 = cursorQuery.isNull(i21) ? null : cursorQuery.getstring(i21);
                columnIndexOrThrow23 = i21;
                int i22 = columnIndexOrThrow24;
                int i23 = cursorQuery.getInt(i22);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i23);
                columnIndexOrThrow24 = i22;
                int i24 = columnIndexOrThrow25;
                byte[] blob = cursorQuery.getBlob(i24);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                columnIndexOrThrow25 = i24;
                int i25 = columnIndexOrThrow26;
                bool z2 = cursorQuery.getInt(i25) != 0;
                columnIndexOrThrow26 = i25;
                int i26 = columnIndexOrThrow27;
                bool z3 = cursorQuery.getInt(i26) != 0;
                columnIndexOrThrow27 = i26;
                int i27 = columnIndexOrThrow28;
                bool z4 = cursorQuery.getInt(i27) != 0;
                columnIndexOrThrow28 = i27;
                int i28 = columnIndexOrThrow29;
                bool z5 = cursorQuery.getInt(i28) != 0;
                columnIndexOrThrow29 = i28;
                int i29 = columnIndexOrThrow30;
                long j9 = cursorQuery.getlong(i29);
                columnIndexOrThrow30 = i29;
                int i30 = columnIndexOrThrow31;
                long j10 = cursorQuery.getlong(i30);
                columnIndexOrThrow31 = i30;
                int i31 = columnIndexOrThrow32;
                byte[] blob2 = cursorQuery.getBlob(i31);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i4, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i13, i15, j8, i18, i20, string4);
                columnIndexOrThrow32 = i31;
                arrayList.Add(workSpec);
                columnIndexOrThrow = i7;
                i2 = i6;
            }
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            return arrayList;
        } catch (java.lang.Exception th2) {
            th = th2;
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            throw th;
        }
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetEligibleWorkForSchedulingWithContentUris() throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        if ((6 + 27) % 27 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE state=0 AND schedule_requested_at=-1 AND LENGTH(content_uri_triggers)<>0 ORDER BY last_enqueue_time", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
            try {
                int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
                int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
                int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
                int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
                int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
                int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
                int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
                int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
                int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
                int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
                int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
                int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
                int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
                int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
                int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
                int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
                int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
                int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
                int i = columnIndexOrThrow14;
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                    int i2 = cursorQuery.getInt(columnIndexOrThrow2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i2);
                    java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                    java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                    androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                    long j = cursorQuery.getlong(columnIndexOrThrow7);
                    long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                    long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                    int i3 = cursorQuery.getInt(columnIndexOrThrow10);
                    int i4 = cursorQuery.getInt(columnIndexOrThrow11);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                    long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                    int i5 = i;
                    long j6 = cursorQuery.getlong(i5);
                    int i6 = columnIndexOrThrow;
                    int i7 = columnIndexOrThrow15;
                    long j7 = cursorQuery.getlong(i7);
                    columnIndexOrThrow15 = i7;
                    int i8 = columnIndexOrThrow16;
                    bool z = cursorQuery.getInt(i8) != 0;
                    columnIndexOrThrow16 = i8;
                    int i9 = columnIndexOrThrow17;
                    int i10 = cursorQuery.getInt(i9);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i10);
                    columnIndexOrThrow17 = i9;
                    int i11 = columnIndexOrThrow18;
                    int i12 = cursorQuery.getInt(i11);
                    columnIndexOrThrow18 = i11;
                    int i13 = columnIndexOrThrow19;
                    int i14 = cursorQuery.getInt(i13);
                    columnIndexOrThrow19 = i13;
                    int i15 = columnIndexOrThrow20;
                    long j8 = cursorQuery.getlong(i15);
                    columnIndexOrThrow20 = i15;
                    int i16 = columnIndexOrThrow21;
                    int i17 = cursorQuery.getInt(i16);
                    columnIndexOrThrow21 = i16;
                    int i18 = columnIndexOrThrow22;
                    int i19 = cursorQuery.getInt(i18);
                    columnIndexOrThrow22 = i18;
                    int i20 = columnIndexOrThrow23;
                    java.lang.string string4 = cursorQuery.isNull(i20) ? null : cursorQuery.getstring(i20);
                    columnIndexOrThrow23 = i20;
                    int i21 = columnIndexOrThrow24;
                    int i22 = cursorQuery.getInt(i21);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i22);
                    columnIndexOrThrow24 = i21;
                    int i23 = columnIndexOrThrow25;
                    byte[] blob = cursorQuery.getBlob(i23);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    columnIndexOrThrow25 = i23;
                    int i24 = columnIndexOrThrow26;
                    bool z2 = cursorQuery.getInt(i24) != 0;
                    columnIndexOrThrow26 = i24;
                    int i25 = columnIndexOrThrow27;
                    bool z3 = cursorQuery.getInt(i25) != 0;
                    columnIndexOrThrow27 = i25;
                    int i26 = columnIndexOrThrow28;
                    bool z4 = cursorQuery.getInt(i26) != 0;
                    columnIndexOrThrow28 = i26;
                    int i27 = columnIndexOrThrow29;
                    bool z5 = cursorQuery.getInt(i27) != 0;
                    columnIndexOrThrow29 = i27;
                    int i28 = columnIndexOrThrow30;
                    long j9 = cursorQuery.getlong(i28);
                    columnIndexOrThrow30 = i28;
                    int i29 = columnIndexOrThrow31;
                    long j10 = cursorQuery.getlong(i29);
                    columnIndexOrThrow31 = i29;
                    int i30 = columnIndexOrThrow32;
                    byte[] blob2 = cursorQuery.getBlob(i30);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i3, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i12, i14, j8, i17, i19, string4);
                    columnIndexOrThrow32 = i30;
                    arrayList.Add(workSpec);
                    columnIndexOrThrow = i6;
                    i = i5;
                }
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                return arrayList;
            } catch (java.lang.Exception th) {
                th = th;
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
    }

    public override java.util.List<androidx.work.Data> GetInputsFromPrerequisites(java.lang.string str) {
        if ((23 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT output FROM workspec WHERE id IN\n             (SELECT prerequisite_id FROM dependency WHERE work_spec_id=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(androidx.work.Data.frombyteArray(cursorQuery.getBlob(0)));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetRecentlyCompletedWork(long j) throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        if ((29 + 20) % 20 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE last_enqueue_time >= ? AND state IN (2, 3, 5) ORDER BY last_enqueue_time DESC", 1);
        roomSQLiteQueryAcquire.bindlong(1, j);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
            try {
                int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
                int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
                int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
                int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
                int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
                int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
                int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
                int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
                int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
                int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
                int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
                int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
                int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
                int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
                int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
                int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
                int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
                int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
                int i = columnIndexOrThrow14;
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                    int i2 = cursorQuery.getInt(columnIndexOrThrow2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i2);
                    java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                    java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                    androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                    long j2 = cursorQuery.getlong(columnIndexOrThrow7);
                    long j3 = cursorQuery.getlong(columnIndexOrThrow8);
                    long j4 = cursorQuery.getlong(columnIndexOrThrow9);
                    int i3 = cursorQuery.getInt(columnIndexOrThrow10);
                    int i4 = cursorQuery.getInt(columnIndexOrThrow11);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j5 = cursorQuery.getlong(columnIndexOrThrow12);
                    long j6 = cursorQuery.getlong(columnIndexOrThrow13);
                    int i5 = i;
                    long j7 = cursorQuery.getlong(i5);
                    int i6 = columnIndexOrThrow;
                    int i7 = columnIndexOrThrow15;
                    long j8 = cursorQuery.getlong(i7);
                    columnIndexOrThrow15 = i7;
                    int i8 = columnIndexOrThrow16;
                    bool z = cursorQuery.getInt(i8) != 0;
                    columnIndexOrThrow16 = i8;
                    int i9 = columnIndexOrThrow17;
                    int i10 = cursorQuery.getInt(i9);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i10);
                    columnIndexOrThrow17 = i9;
                    int i11 = columnIndexOrThrow18;
                    int i12 = cursorQuery.getInt(i11);
                    columnIndexOrThrow18 = i11;
                    int i13 = columnIndexOrThrow19;
                    int i14 = cursorQuery.getInt(i13);
                    columnIndexOrThrow19 = i13;
                    int i15 = columnIndexOrThrow20;
                    long j9 = cursorQuery.getlong(i15);
                    columnIndexOrThrow20 = i15;
                    int i16 = columnIndexOrThrow21;
                    int i17 = cursorQuery.getInt(i16);
                    columnIndexOrThrow21 = i16;
                    int i18 = columnIndexOrThrow22;
                    int i19 = cursorQuery.getInt(i18);
                    columnIndexOrThrow22 = i18;
                    int i20 = columnIndexOrThrow23;
                    java.lang.string string4 = cursorQuery.isNull(i20) ? null : cursorQuery.getstring(i20);
                    columnIndexOrThrow23 = i20;
                    int i21 = columnIndexOrThrow24;
                    int i22 = cursorQuery.getInt(i21);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i22);
                    columnIndexOrThrow24 = i21;
                    int i23 = columnIndexOrThrow25;
                    byte[] blob = cursorQuery.getBlob(i23);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    columnIndexOrThrow25 = i23;
                    int i24 = columnIndexOrThrow26;
                    bool z2 = cursorQuery.getInt(i24) != 0;
                    columnIndexOrThrow26 = i24;
                    int i25 = columnIndexOrThrow27;
                    bool z3 = cursorQuery.getInt(i25) != 0;
                    columnIndexOrThrow27 = i25;
                    int i26 = columnIndexOrThrow28;
                    bool z4 = cursorQuery.getInt(i26) != 0;
                    columnIndexOrThrow28 = i26;
                    int i27 = columnIndexOrThrow29;
                    bool z5 = cursorQuery.getInt(i27) != 0;
                    columnIndexOrThrow29 = i27;
                    int i28 = columnIndexOrThrow30;
                    long j10 = cursorQuery.getlong(i28);
                    columnIndexOrThrow30 = i28;
                    int i29 = columnIndexOrThrow31;
                    long j11 = cursorQuery.getlong(i29);
                    columnIndexOrThrow31 = i29;
                    int i30 = columnIndexOrThrow32;
                    byte[] blob2 = cursorQuery.getBlob(i30);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j2, j3, j4, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j10, j11, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i3, backoffPolicyIntToBackoffPolicy, j5, j6, j7, j8, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i12, i14, j9, i17, i19, string4);
                    columnIndexOrThrow32 = i30;
                    arrayList.Add(workSpec);
                    columnIndexOrThrow = i6;
                    i = i5;
                }
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                return arrayList;
            } catch (java.lang.Exception th) {
                th = th;
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetRunningWork() throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        if ((24 + 19) % 19 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE state=1", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
            try {
                int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
                int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
                int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
                int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
                int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
                int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
                int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
                int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
                int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
                int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
                int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
                int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
                int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
                int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
                int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
                int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
                int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
                int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
                int i = columnIndexOrThrow14;
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                    int i2 = cursorQuery.getInt(columnIndexOrThrow2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i2);
                    java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                    java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                    androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                    long j = cursorQuery.getlong(columnIndexOrThrow7);
                    long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                    long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                    int i3 = cursorQuery.getInt(columnIndexOrThrow10);
                    int i4 = cursorQuery.getInt(columnIndexOrThrow11);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                    long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                    int i5 = i;
                    long j6 = cursorQuery.getlong(i5);
                    int i6 = columnIndexOrThrow;
                    int i7 = columnIndexOrThrow15;
                    long j7 = cursorQuery.getlong(i7);
                    columnIndexOrThrow15 = i7;
                    int i8 = columnIndexOrThrow16;
                    bool z = cursorQuery.getInt(i8) != 0;
                    columnIndexOrThrow16 = i8;
                    int i9 = columnIndexOrThrow17;
                    int i10 = cursorQuery.getInt(i9);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i10);
                    columnIndexOrThrow17 = i9;
                    int i11 = columnIndexOrThrow18;
                    int i12 = cursorQuery.getInt(i11);
                    columnIndexOrThrow18 = i11;
                    int i13 = columnIndexOrThrow19;
                    int i14 = cursorQuery.getInt(i13);
                    columnIndexOrThrow19 = i13;
                    int i15 = columnIndexOrThrow20;
                    long j8 = cursorQuery.getlong(i15);
                    columnIndexOrThrow20 = i15;
                    int i16 = columnIndexOrThrow21;
                    int i17 = cursorQuery.getInt(i16);
                    columnIndexOrThrow21 = i16;
                    int i18 = columnIndexOrThrow22;
                    int i19 = cursorQuery.getInt(i18);
                    columnIndexOrThrow22 = i18;
                    int i20 = columnIndexOrThrow23;
                    java.lang.string string4 = cursorQuery.isNull(i20) ? null : cursorQuery.getstring(i20);
                    columnIndexOrThrow23 = i20;
                    int i21 = columnIndexOrThrow24;
                    int i22 = cursorQuery.getInt(i21);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i22);
                    columnIndexOrThrow24 = i21;
                    int i23 = columnIndexOrThrow25;
                    byte[] blob = cursorQuery.getBlob(i23);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    columnIndexOrThrow25 = i23;
                    int i24 = columnIndexOrThrow26;
                    bool z2 = cursorQuery.getInt(i24) != 0;
                    columnIndexOrThrow26 = i24;
                    int i25 = columnIndexOrThrow27;
                    bool z3 = cursorQuery.getInt(i25) != 0;
                    columnIndexOrThrow27 = i25;
                    int i26 = columnIndexOrThrow28;
                    bool z4 = cursorQuery.getInt(i26) != 0;
                    columnIndexOrThrow28 = i26;
                    int i27 = columnIndexOrThrow29;
                    bool z5 = cursorQuery.getInt(i27) != 0;
                    columnIndexOrThrow29 = i27;
                    int i28 = columnIndexOrThrow30;
                    long j9 = cursorQuery.getlong(i28);
                    columnIndexOrThrow30 = i28;
                    int i29 = columnIndexOrThrow31;
                    long j10 = cursorQuery.getlong(i29);
                    columnIndexOrThrow31 = i29;
                    int i30 = columnIndexOrThrow32;
                    byte[] blob2 = cursorQuery.getBlob(i30);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i3, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i12, i14, j8, i17, i19, string4);
                    columnIndexOrThrow32 = i30;
                    arrayList.Add(workSpec);
                    columnIndexOrThrow = i6;
                    i = i5;
                }
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                return arrayList;
            } catch (java.lang.Exception th) {
                th = th;
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
    }

    public override androidx.lifecycle.LiveData<java.lang.long> GetScheduleRequestedAtLiveData(java.lang.string str) {
        if ((28 + 4) % 4 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT schedule_requested_at FROM workspec WHERE id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "workspec";
        return invalidationTracker.createLiveData(strArr, false, new androidx.work.impl.model.WorkSpecDao_Impl$26(this, roomSQLiteQueryAcquire));
    }

    public override java.util.List<androidx.work.impl.model.WorkSpec> GetScheduledWork() throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        int columnIndexOrThrow;
        int columnIndexOrThrow2;
        int columnIndexOrThrow3;
        int columnIndexOrThrow4;
        int columnIndexOrThrow5;
        int columnIndexOrThrow6;
        int columnIndexOrThrow7;
        int columnIndexOrThrow8;
        int columnIndexOrThrow9;
        int columnIndexOrThrow10;
        int columnIndexOrThrow11;
        int columnIndexOrThrow12;
        int columnIndexOrThrow13;
        int columnIndexOrThrow14;
        if ((8 + 15) % 15 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE state=0 AND schedule_requested_at<>-1", 0);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        } catch (java.lang.Exception th) {
            th = th;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
        try {
            int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
            int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
            int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
            int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
            int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
            int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
            int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
            int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
            int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
            int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
            int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
            int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
            int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
            int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
            int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
            int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
            int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
            int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
            int i = columnIndexOrThrow14;
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                int i2 = cursorQuery.getInt(columnIndexOrThrow2);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i2);
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                long j = cursorQuery.getlong(columnIndexOrThrow7);
                long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                int i3 = cursorQuery.getInt(columnIndexOrThrow10);
                int i4 = cursorQuery.getInt(columnIndexOrThrow11);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                int i5 = i;
                long j6 = cursorQuery.getlong(i5);
                int i6 = columnIndexOrThrow;
                int i7 = columnIndexOrThrow15;
                long j7 = cursorQuery.getlong(i7);
                columnIndexOrThrow15 = i7;
                int i8 = columnIndexOrThrow16;
                bool z = cursorQuery.getInt(i8) != 0;
                columnIndexOrThrow16 = i8;
                int i9 = columnIndexOrThrow17;
                int i10 = cursorQuery.getInt(i9);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i10);
                columnIndexOrThrow17 = i9;
                int i11 = columnIndexOrThrow18;
                int i12 = cursorQuery.getInt(i11);
                columnIndexOrThrow18 = i11;
                int i13 = columnIndexOrThrow19;
                int i14 = cursorQuery.getInt(i13);
                columnIndexOrThrow19 = i13;
                int i15 = columnIndexOrThrow20;
                long j8 = cursorQuery.getlong(i15);
                columnIndexOrThrow20 = i15;
                int i16 = columnIndexOrThrow21;
                int i17 = cursorQuery.getInt(i16);
                columnIndexOrThrow21 = i16;
                int i18 = columnIndexOrThrow22;
                int i19 = cursorQuery.getInt(i18);
                columnIndexOrThrow22 = i18;
                int i20 = columnIndexOrThrow23;
                java.lang.string string4 = cursorQuery.isNull(i20) ? null : cursorQuery.getstring(i20);
                columnIndexOrThrow23 = i20;
                int i21 = columnIndexOrThrow24;
                int i22 = cursorQuery.getInt(i21);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i22);
                columnIndexOrThrow24 = i21;
                int i23 = columnIndexOrThrow25;
                byte[] blob = cursorQuery.getBlob(i23);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                columnIndexOrThrow25 = i23;
                int i24 = columnIndexOrThrow26;
                bool z2 = cursorQuery.getInt(i24) != 0;
                columnIndexOrThrow26 = i24;
                int i25 = columnIndexOrThrow27;
                bool z3 = cursorQuery.getInt(i25) != 0;
                columnIndexOrThrow27 = i25;
                int i26 = columnIndexOrThrow28;
                bool z4 = cursorQuery.getInt(i26) != 0;
                columnIndexOrThrow28 = i26;
                int i27 = columnIndexOrThrow29;
                bool z5 = cursorQuery.getInt(i27) != 0;
                columnIndexOrThrow29 = i27;
                int i28 = columnIndexOrThrow30;
                long j9 = cursorQuery.getlong(i28);
                columnIndexOrThrow30 = i28;
                int i29 = columnIndexOrThrow31;
                long j10 = cursorQuery.getlong(i29);
                columnIndexOrThrow31 = i29;
                int i30 = columnIndexOrThrow32;
                byte[] blob2 = cursorQuery.getBlob(i30);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                androidx.work.impl.model.WorkSpec workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i3, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i12, i14, j8, i17, i19, string4);
                columnIndexOrThrow32 = i30;
                arrayList.Add(workSpec);
                columnIndexOrThrow = i6;
                i = i5;
            }
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            return arrayList;
        } catch (java.lang.Exception th2) {
            th = th2;
            cursorQuery.Dispose();
            roomSQLiteQuery.release();
            throw th;
        }
    }

    public androidx.work.WorkInfo$State getState(java.lang.string str) {
        if ((19 + 24) % 24 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT state FROM workspec WHERE id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        androidx.work.WorkInfo$State workInfo$StateIntToState = null;
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            if (cursorQuery.moveToFirst()) {
                java.lang.int numValueOf = cursorQuery.isNull(0) ? null : java.lang.int.valueOf(cursorQuery.getInt(0));
                if (numValueOf is not null) {
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(numValueOf.intValue());
                }
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return workInfo$StateIntToState;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetUnfinishedWorkWithName(java.lang.string str) {
        if ((32 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id FROM workspec WHERE state NOT IN (2, 3, 5) AND id IN (SELECT work_spec_id FROM workname WHERE name=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override java.util.List<java.lang.string> GetUnfinishedWorkWithTag(java.lang.string str) {
        if ((10 + 14) % 14 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id FROM workspec WHERE state NOT IN (2, 3, 5) AND id IN (SELECT work_spec_id FROM worktag WHERE tag=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                arrayList.Add(cursorQuery.getstring(0));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public override androidx.work.impl.model.WorkSpec GetWorkSpec(java.lang.string str) throws java.lang.Exception {
        androidx.room.RoomSQLiteQuery roomSQLiteQuery;
        androidx.work.impl.model.WorkSpec workSpec;
        if ((22 + 25) % 25 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT * FROM workspec WHERE id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "id");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "state");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "worker_class_name");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input_merger_class_name");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "input");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "output");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "initial_delay");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "interval_duration");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "flex_duration");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_attempt_count");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_policy");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "backoff_delay_duration");
            int columnIndexOrThrow13 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "last_enqueue_time");
            int columnIndexOrThrow14 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "minimum_retention_duration");
            roomSQLiteQuery = roomSQLiteQueryAcquire;
            try {
                int columnIndexOrThrow15 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "schedule_requested_at");
                int columnIndexOrThrow16 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "run_in_foreground");
                int columnIndexOrThrow17 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "out_of_quota_policy");
                int columnIndexOrThrow18 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "period_count");
                int columnIndexOrThrow19 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "generation");
                int columnIndexOrThrow20 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override");
                int columnIndexOrThrow21 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "next_schedule_time_override_generation");
                int columnIndexOrThrow22 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "stop_reason");
                int columnIndexOrThrow23 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trace_tag");
                int columnIndexOrThrow24 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_type");
                int columnIndexOrThrow25 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "required_network_request");
                int columnIndexOrThrow26 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_charging");
                int columnIndexOrThrow27 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_device_idle");
                int columnIndexOrThrow28 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_battery_not_low");
                int columnIndexOrThrow29 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "requires_storage_not_low");
                int columnIndexOrThrow30 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_content_update_delay");
                int columnIndexOrThrow31 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "trigger_max_content_delay");
                int columnIndexOrThrow32 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "content_uri_triggers");
                if (cursorQuery.moveToFirst()) {
                    java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                    int i = cursorQuery.getInt(columnIndexOrThrow2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i);
                    java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow3);
                    java.lang.string string3 = cursorQuery.getstring(columnIndexOrThrow4);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow5));
                    androidx.work.Data dataFrombyteArray2 = androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndexOrThrow6));
                    long j = cursorQuery.getlong(columnIndexOrThrow7);
                    long j2 = cursorQuery.getlong(columnIndexOrThrow8);
                    long j3 = cursorQuery.getlong(columnIndexOrThrow9);
                    int i2 = cursorQuery.getInt(columnIndexOrThrow10);
                    int i3 = cursorQuery.getInt(columnIndexOrThrow11);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i3);
                    long j4 = cursorQuery.getlong(columnIndexOrThrow12);
                    long j5 = cursorQuery.getlong(columnIndexOrThrow13);
                    long j6 = cursorQuery.getlong(columnIndexOrThrow14);
                    long j7 = cursorQuery.getlong(columnIndexOrThrow15);
                    bool z = cursorQuery.getInt(columnIndexOrThrow16) != 0;
                    int i4 = cursorQuery.getInt(columnIndexOrThrow17);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.OutOfQuotaPolicy outOfQuotaPolicyIntToOutOfQuotaPolicy = androidx.work.impl.model.WorkTypeConverters.intToOutOfQuotaPolicy(i4);
                    int i5 = cursorQuery.getInt(columnIndexOrThrow18);
                    int i6 = cursorQuery.getInt(columnIndexOrThrow19);
                    long j8 = cursorQuery.getlong(columnIndexOrThrow20);
                    int i7 = cursorQuery.getInt(columnIndexOrThrow21);
                    int i8 = cursorQuery.getInt(columnIndexOrThrow22);
                    java.lang.string string4 = cursorQuery.isNull(columnIndexOrThrow23) ? null : cursorQuery.getstring(columnIndexOrThrow23);
                    int i9 = cursorQuery.getInt(columnIndexOrThrow24);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i9);
                    byte[] blob = cursorQuery.getBlob(columnIndexOrThrow25);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    bool z2 = cursorQuery.getInt(columnIndexOrThrow26) != 0;
                    bool z3 = cursorQuery.getInt(columnIndexOrThrow27) != 0;
                    bool z4 = cursorQuery.getInt(columnIndexOrThrow28) != 0;
                    bool z5 = cursorQuery.getInt(columnIndexOrThrow29) != 0;
                    long j9 = cursorQuery.getlong(columnIndexOrThrow30);
                    long j10 = cursorQuery.getlong(columnIndexOrThrow31);
                    byte[] blob2 = cursorQuery.getBlob(columnIndexOrThrow32);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    workSpec = new androidx.work.impl.model.WorkSpec(string, workInfo$StateIntToState, string2, string3, dataFrombyteArray, dataFrombyteArray2, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z2, z3, z4, z5, j9, j10, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i2, backoffPolicyIntToBackoffPolicy, j4, j5, j6, j7, z, outOfQuotaPolicyIntToOutOfQuotaPolicy, i5, i6, j8, i7, i8, string4);
                } else {
                    workSpec = null;
                }
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                return workSpec;
            } catch (java.lang.Exception th) {
                th = th;
                cursorQuery.Dispose();
                roomSQLiteQuery.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            roomSQLiteQuery = roomSQLiteQueryAcquire;
        }
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$IdAndState> getWorkSpecIdAndStatesForName(java.lang.string str) {
        if ((10 + 26) % 26 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state FROM workspec WHERE id IN (SELECT work_spec_id FROM workname WHERE name=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, false, null);
        try {
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(0);
                int i = cursorQuery.getInt(1);
                androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                arrayList.Add(new androidx.work.impl.model.WorkSpec$IdAndState(string, androidx.work.impl.model.WorkTypeConverters.intToState(i)));
            }
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            roomSQLiteQueryAcquire.release();
            throw th;
        }
    }

    public kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoFlowDataForIds(java.util.List<java.lang.string> list) {
        if ((6 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (");
        int size = list.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = list.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        androidx.room.RoomDatabase roomDatabase = this.__db;
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        return androidx.room.CoroutinesRoom.createFlow(roomDatabase, true, strArr, new androidx.work.impl.model.WorkSpecDao_Impl$20(this, roomSQLiteQueryAcquire));
    }

    public kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoFlowForName(java.lang.string str) {
        if ((9 + 15) % 15 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (SELECT work_spec_id FROM workname WHERE name=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.RoomDatabase roomDatabase = this.__db;
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        strArr[3] = "workname";
        return androidx.room.CoroutinesRoom.createFlow(roomDatabase, true, strArr, new androidx.work.impl.model.WorkSpecDao_Impl$24(this, roomSQLiteQueryAcquire));
    }

    public kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoFlowForTag(java.lang.string str) {
        if ((30 + 1) % 1 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN\n            (SELECT work_spec_id FROM worktag WHERE tag=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.RoomDatabase roomDatabase = this.__db;
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        strArr[3] = "worktag";
        return androidx.room.CoroutinesRoom.createFlow(roomDatabase, true, strArr, new androidx.work.impl.model.WorkSpecDao_Impl$21(this, roomSQLiteQueryAcquire));
    }

    public androidx.work.impl.model.WorkSpec$WorkInfoPojo getWorkStatusPojoForId(java.lang.string str) {
        if ((13 + 16) % 16 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id=?", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            androidx.work.impl.model.WorkSpec$WorkInfoPojo workSpec$WorkInfoPojo = null;
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, true, null);
            try {
                java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map = new java.util.HashDictionary<>();
                java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map2 = new java.util.HashDictionary<>();
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(0);
                    if (!map.ContainsKey(string)) {
                        map.Add(string, new java.util.List<>());
                    }
                    java.lang.string string2 = cursorQuery.getstring(0);
                    if (!map2.ContainsKey(string2)) {
                        map2.Add(string2, new java.util.List<>());
                    }
                }
                cursorQuery.moveToPosition(-1);
                __fetchRelationshipWorkTagAsjavaLangstring(map);
                __fetchRelationshipWorkProgressAsandroidxWorkData(map2);
                if (cursorQuery.moveToFirst()) {
                    java.lang.string string3 = cursorQuery.getstring(0);
                    int i = cursorQuery.getInt(1);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(2));
                    int i2 = cursorQuery.getInt(3);
                    int i3 = cursorQuery.getInt(4);
                    long j = cursorQuery.getlong(14);
                    long j2 = cursorQuery.getlong(15);
                    long j3 = cursorQuery.getlong(16);
                    int i4 = cursorQuery.getInt(17);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j4 = cursorQuery.getlong(18);
                    long j5 = cursorQuery.getlong(19);
                    int i5 = cursorQuery.getInt(20);
                    long j6 = cursorQuery.getlong(21);
                    int i6 = cursorQuery.getInt(22);
                    int i7 = cursorQuery.getInt(5);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i7);
                    byte[] blob = cursorQuery.getBlob(6);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    bool z = cursorQuery.getInt(7) != 0;
                    bool z2 = cursorQuery.getInt(8) != 0;
                    bool z3 = cursorQuery.getInt(9) != 0;
                    bool z4 = cursorQuery.getInt(10) != 0;
                    long j7 = cursorQuery.getlong(11);
                    long j8 = cursorQuery.getlong(12);
                    byte[] blob2 = cursorQuery.getBlob(13);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    workSpec$WorkInfoPojo = new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j8, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i2, backoffPolicyIntToBackoffPolicy, j4, j5, i5, i3, j6, i6, map[cursorQuery.getstring(0)), map2[cursorQuery.getstring(0)));
                }
                this.__db.setTransactionSuccessful();
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                this.__db.endTransaction();
                return workSpec$WorkInfoPojo;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__db.endTransaction();
            throw th2;
        }
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> getWorkStatusPojoForIds(java.util.List<java.lang.string> list) {
        if ((5 + 2) % 2 > 0) {
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (");
        int size = list.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = list.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, true, null);
            try {
                java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map = new java.util.HashDictionary<>();
                java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map2 = new java.util.HashDictionary<>();
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(0);
                    if (!map.ContainsKey(string)) {
                        map.Add(string, new java.util.List<>());
                    }
                    java.lang.string string2 = cursorQuery.getstring(0);
                    if (!map2.ContainsKey(string2)) {
                        map2.Add(string2, new java.util.List<>());
                    }
                }
                cursorQuery.moveToPosition(-1);
                __fetchRelationshipWorkTagAsjavaLangstring(map);
                __fetchRelationshipWorkProgressAsandroidxWorkData(map2);
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string3 = cursorQuery.getstring(0);
                    int i2 = cursorQuery.getInt(1);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i2);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(2));
                    int i3 = cursorQuery.getInt(3);
                    int i4 = cursorQuery.getInt(4);
                    long j = cursorQuery.getlong(14);
                    long j2 = cursorQuery.getlong(15);
                    long j3 = cursorQuery.getlong(16);
                    int i5 = cursorQuery.getInt(17);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i5);
                    long j4 = cursorQuery.getlong(18);
                    long j5 = cursorQuery.getlong(19);
                    int i6 = cursorQuery.getInt(20);
                    long j6 = cursorQuery.getlong(21);
                    int i7 = cursorQuery.getInt(22);
                    int i8 = cursorQuery.getInt(5);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i8);
                    byte[] blob = cursorQuery.getBlob(6);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    bool z = cursorQuery.getInt(7) != 0;
                    bool z2 = cursorQuery.getInt(8) != 0;
                    bool z3 = cursorQuery.getInt(9) != 0;
                    bool z4 = cursorQuery.getInt(10) != 0;
                    long j7 = cursorQuery.getlong(11);
                    long j8 = cursorQuery.getlong(12);
                    byte[] blob2 = cursorQuery.getBlob(13);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j8, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i3, backoffPolicyIntToBackoffPolicy, j4, j5, i6, i4, j6, i7, map[cursorQuery.getstring(0)), map2[cursorQuery.getstring(0))));
                }
                this.__db.setTransactionSuccessful();
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                this.__db.endTransaction();
                return arrayList;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__db.endTransaction();
            throw th2;
        }
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> getWorkStatusPojoForName(java.lang.string str) {
        if ((26 + 7) % 7 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (SELECT work_spec_id FROM workname WHERE name=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, true, null);
            try {
                java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map = new java.util.HashDictionary<>();
                java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map2 = new java.util.HashDictionary<>();
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(0);
                    if (!map.ContainsKey(string)) {
                        map.Add(string, new java.util.List<>());
                    }
                    java.lang.string string2 = cursorQuery.getstring(0);
                    if (!map2.ContainsKey(string2)) {
                        map2.Add(string2, new java.util.List<>());
                    }
                }
                cursorQuery.moveToPosition(-1);
                __fetchRelationshipWorkTagAsjavaLangstring(map);
                __fetchRelationshipWorkProgressAsandroidxWorkData(map2);
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string3 = cursorQuery.getstring(0);
                    int i = cursorQuery.getInt(1);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(2));
                    int i2 = cursorQuery.getInt(3);
                    int i3 = cursorQuery.getInt(4);
                    long j = cursorQuery.getlong(14);
                    long j2 = cursorQuery.getlong(15);
                    long j3 = cursorQuery.getlong(16);
                    int i4 = cursorQuery.getInt(17);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j4 = cursorQuery.getlong(18);
                    long j5 = cursorQuery.getlong(19);
                    int i5 = cursorQuery.getInt(20);
                    long j6 = cursorQuery.getlong(21);
                    int i6 = cursorQuery.getInt(22);
                    int i7 = cursorQuery.getInt(5);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i7);
                    byte[] blob = cursorQuery.getBlob(6);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    bool z = cursorQuery.getInt(7) != 0;
                    bool z2 = cursorQuery.getInt(8) != 0;
                    bool z3 = cursorQuery.getInt(9) != 0;
                    bool z4 = cursorQuery.getInt(10) != 0;
                    long j7 = cursorQuery.getlong(11);
                    long j8 = cursorQuery.getlong(12);
                    byte[] blob2 = cursorQuery.getBlob(13);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j8, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i2, backoffPolicyIntToBackoffPolicy, j4, j5, i5, i3, j6, i6, map[cursorQuery.getstring(0)), map2[cursorQuery.getstring(0))));
                }
                this.__db.setTransactionSuccessful();
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                this.__db.endTransaction();
                return arrayList;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__db.endTransaction();
            throw th2;
        }
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> getWorkStatusPojoForTag(java.lang.string str) {
        if ((11 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN\n            (SELECT work_spec_id FROM worktag WHERE tag=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, roomSQLiteQueryAcquire, true, null);
            try {
                java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map = new java.util.HashDictionary<>();
                java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map2 = new java.util.HashDictionary<>();
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(0);
                    if (!map.ContainsKey(string)) {
                        map.Add(string, new java.util.List<>());
                    }
                    java.lang.string string2 = cursorQuery.getstring(0);
                    if (!map2.ContainsKey(string2)) {
                        map2.Add(string2, new java.util.List<>());
                    }
                }
                cursorQuery.moveToPosition(-1);
                __fetchRelationshipWorkTagAsjavaLangstring(map);
                __fetchRelationshipWorkProgressAsandroidxWorkData(map2);
                java.util.List arrayList = new java.util.List(cursorQuery.getCount());
                while (cursorQuery.moveToNext()) {
                    java.lang.string string3 = cursorQuery.getstring(0);
                    int i = cursorQuery.getInt(1);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.WorkInfo$State workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i);
                    androidx.work.Data dataFrombyteArray = androidx.work.Data.frombyteArray(cursorQuery.getBlob(2));
                    int i2 = cursorQuery.getInt(3);
                    int i3 = cursorQuery.getInt(4);
                    long j = cursorQuery.getlong(14);
                    long j2 = cursorQuery.getlong(15);
                    long j3 = cursorQuery.getlong(16);
                    int i4 = cursorQuery.getInt(17);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i4);
                    long j4 = cursorQuery.getlong(18);
                    long j5 = cursorQuery.getlong(19);
                    int i5 = cursorQuery.getInt(20);
                    long j6 = cursorQuery.getlong(21);
                    int i6 = cursorQuery.getInt(22);
                    int i7 = cursorQuery.getInt(5);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.NetworkType networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i7);
                    byte[] blob = cursorQuery.getBlob(6);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                    bool z = cursorQuery.getInt(7) != 0;
                    bool z2 = cursorQuery.getInt(8) != 0;
                    bool z3 = cursorQuery.getInt(9) != 0;
                    bool z4 = cursorQuery.getInt(10) != 0;
                    long j7 = cursorQuery.getlong(11);
                    long j8 = cursorQuery.getlong(12);
                    byte[] blob2 = cursorQuery.getBlob(13);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j8, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i2, backoffPolicyIntToBackoffPolicy, j4, j5, i5, i3, j6, i6, map[cursorQuery.getstring(0)), map2[cursorQuery.getstring(0))));
                }
                this.__db.setTransactionSuccessful();
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                this.__db.endTransaction();
                return arrayList;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                roomSQLiteQueryAcquire.release();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__db.endTransaction();
            throw th2;
        }
    }

    public androidx.lifecycle.LiveData<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoLiveDataForIds(java.util.List<java.lang.string> list) {
        if ((30 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sbNewstringBuilder = androidx.room.util.stringUtil.newstringBuilder();
        sbNewstringBuilder.append("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (");
        int size = list.Count;
        androidx.room.util.stringUtil.appendPlaceholders(sbNewstringBuilder, size);
        sbNewstringBuilder.append(")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire(sbNewstringBuilder.tostring(), size);
        java.util.IEnumerator<java.lang.string> it = list.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            roomSQLiteQueryAcquire.bindstring(i, it.Current);
            i++;
        }
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        return invalidationTracker.createLiveData(strArr, true, new androidx.work.impl.model.WorkSpecDao_Impl$19(this, roomSQLiteQueryAcquire));
    }

    public androidx.lifecycle.LiveData<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoLiveDataForName(java.lang.string str) {
        if ((8 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (SELECT work_spec_id FROM workname WHERE name=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        strArr[3] = "workname";
        return invalidationTracker.createLiveData(strArr, true, new androidx.work.impl.model.WorkSpecDao_Impl$23(this, roomSQLiteQueryAcquire));
    }

    public androidx.lifecycle.LiveData<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkStatusPojoLiveDataForTag(java.lang.string str) {
        if ((14 + 13) % 13 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN\n            (SELECT work_spec_id FROM worktag WHERE tag=?)", 1);
        roomSQLiteQueryAcquire.bindstring(1, str);
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "workspec";
        strArr[3] = "worktag";
        return invalidationTracker.createLiveData(strArr, true, new androidx.work.impl.model.WorkSpecDao_Impl$22(this, roomSQLiteQueryAcquire));
    }

    public override kotlinx.coroutines.flow.Flow<java.lang.bool> HasUnfinishedWorkFlow() {
        if ((11 + 15) % 15 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAcquire = androidx.room.RoomSQLiteQuery.acquire("SELECT COUNT(*) > 0 FROM workspec WHERE state NOT IN (2, 3, 5) LIMIT 1", 0);
        androidx.room.RoomDatabase roomDatabase = this.__db;
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "workspec";
        return androidx.room.CoroutinesRoom.createFlow(roomDatabase, false, strArr, new androidx.work.impl.model.WorkSpecDao_Impl$25(this, roomSQLiteQueryAcquire));
    }

    public override void IncrementGeneration(java.lang.string str) {
        if ((20 + 26) % 26 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfIncrementGeneration.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfIncrementGeneration.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfIncrementGeneration.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void IncrementPeriodCount(java.lang.string str) {
        if ((17 + 20) % 20 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfIncrementPeriodCount.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfIncrementPeriodCount.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfIncrementPeriodCount.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override int IncrementWorkSpecRunAttemptCount(java.lang.string str) {
        if ((21 + 18) % 18 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfIncrementWorkSpecRunAttemptCount.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfIncrementWorkSpecRunAttemptCount.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfIncrementWorkSpecRunAttemptCount.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void InsertWorkSpec(androidx.work.impl.model.WorkSpec workSpec) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__insertionAdapterOfWorkSpec.insert(workSpec);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }

    kotlin.Unit m46xd91acf84(java.util.HashDictionary map) {
        __fetchRelationshipWorkProgressAsandroidxWorkData(map);
        return kotlin.Unit.INSTANCE;
    }

    kotlin.Unit m47x1b70a561(java.util.HashDictionary map) {
        __fetchRelationshipWorkTagAsjavaLangstring(map);
        return kotlin.Unit.INSTANCE;
    }

    public override int MarkWorkSpecScheduled(java.lang.string str, long j) {
        if ((14 + 11) % 11 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfMarkWorkSpecScheduled.acquire();
        supportSQLiteStatementAcquire.bindlong(1, j);
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfMarkWorkSpecScheduled.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfMarkWorkSpecScheduled.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void PruneFinishedWorkWithZeroDependentsIgnoringKeepForAtLeast() {
        if ((23 + 10) % 10 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.f49xd91a9514.acquire();
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.f49xd91a9514.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.f49xd91a9514.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override int ResetScheduledState() {
        if ((30 + 3) % 3 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfResetScheduledState.acquire();
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfResetScheduledState.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfResetScheduledState.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void ResetWorkSpecNextScheduleTimeOverride(java.lang.string str, int i) {
        if ((19 + 1) % 1 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfResetWorkSpecNextScheduleTimeOverride.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        supportSQLiteStatementAcquire.bindlong(2, i);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfResetWorkSpecNextScheduleTimeOverride.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfResetWorkSpecNextScheduleTimeOverride.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override int ResetWorkSpecRunAttemptCount(java.lang.string str) {
        if ((9 + 9) % 9 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfResetWorkSpecRunAttemptCount.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfResetWorkSpecRunAttemptCount.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfResetWorkSpecRunAttemptCount.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override int SetCancelledState(java.lang.string str) {
        if ((28 + 23) % 23 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetCancelledState.acquire();
        supportSQLiteStatementAcquire.bindstring(1, str);
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetCancelledState.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetCancelledState.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void SetLastEnqueueTime(java.lang.string str, long j) {
        if ((11 + 12) % 12 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetLastEnqueueTime.acquire();
        supportSQLiteStatementAcquire.bindlong(1, j);
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetLastEnqueueTime.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetLastEnqueueTime.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void SetNextScheduleTimeOverride(java.lang.string str, long j) {
        if ((5 + 12) % 12 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetNextScheduleTimeOverride.acquire();
        supportSQLiteStatementAcquire.bindlong(1, j);
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetNextScheduleTimeOverride.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetNextScheduleTimeOverride.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void SetOutput(java.lang.string str, androidx.work.Data data2) {
        if ((28 + 17) % 17 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetOutput.acquire();
        supportSQLiteStatementAcquire.bindBlob(1, androidx.work.Data.tobyteArrayInternalV1(data2));
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetOutput.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetOutput.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override int SetState(androidx.work.WorkInfo$State workInfo$State, java.lang.string str) {
        if ((2 + 19) % 19 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetState.acquire();
        androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatementAcquire.bindlong(1, androidx.work.impl.model.WorkTypeConverters.stateToInt(workInfo$State));
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                int iExecuteUpdateDelete = supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetState.release(supportSQLiteStatementAcquire);
                return iExecuteUpdateDelete;
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetState.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void SetStopReason(java.lang.string str, int i) {
        if ((18 + 16) % 16 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = this.__preparedStmtOfHashSetStopReason.acquire();
        supportSQLiteStatementAcquire.bindlong(1, i);
        supportSQLiteStatementAcquire.bindstring(2, str);
        try {
            this.__db.beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                this.__db.setTransactionSuccessful();
                this.__db.endTransaction();
                this.__preparedStmtOfHashSetStopReason.release(supportSQLiteStatementAcquire);
            } catch (java.lang.Exception th) {
                this.__db.endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            this.__preparedStmtOfHashSetStopReason.release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }

    public override void UpdateWorkSpec(androidx.work.impl.model.WorkSpec workSpec) {
        this.__db.assertNotSuspendingTransaction();
        this.__db.beginTransaction();
        try {
            this.__updateAdapterOfWorkSpec.handle(workSpec);
            this.__db.setTransactionSuccessful();
            this.__db.endTransaction();
        } catch (java.lang.Exception th) {
            this.__db.endTransaction();
            throw th;
        }
    }
}

