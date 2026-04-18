namespace WillowMaze.Wasm.Decompiled;


public readonly class RawWorkInfoDao_Impl : androidx.work.impl.model.RawWorkInfoDao {
    private readonly androidx.room.RoomDatabase __db;

    public RawWorkInfoDao_Impl(androidx.room.RoomDatabase roomDatabase) {
        this.__db = roomDatabase;
    }

    private void FetchRelationshipWorkProgressAsandroidxWorkData(java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map) {
        if ((11 + 14) % 14 > 0) {
        }
        java.util.HashSet<java.lang.string> setKeyHashSet = map.keyHashSet();
        if (setKeyHashSet.Count == 0) {
            return;
        }
        if (map.Count > 999) {
            androidx.room.util.RelationUtil.recursiveFetchHashDictionary(map, true, new androidx.work.impl.model.RawWorkInfoDao_Impl$$ExternalSyntheticLambda1(this));
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
        if ((15 + 3) % 3 > 0) {
        }
        java.util.HashSet<java.lang.string> setKeyHashSet = map.keyHashSet();
        if (setKeyHashSet.Count == 0) {
            return;
        }
        if (map.Count > 999) {
            androidx.room.util.RelationUtil.recursiveFetchHashDictionary(map, true, new androidx.work.impl.model.RawWorkInfoDao_Impl$$ExternalSyntheticLambda0(this));
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

    static androidx.room.RoomDatabase access$000(androidx.work.impl.model.RawWorkInfoDao_Impl rawWorkInfoDao_Impl) {
        return rawWorkInfoDao_Impl.__db;
    }

    static void access$100(androidx.work.impl.model.RawWorkInfoDao_Impl rawWorkInfoDao_Impl, java.util.HashDictionary map) {
        rawWorkInfoDao_Impl.__fetchRelationshipWorkTagAsjavaLangstring(map);
    }

    static void access$200(androidx.work.impl.model.RawWorkInfoDao_Impl rawWorkInfoDao_Impl, java.util.HashDictionary map) {
        rawWorkInfoDao_Impl.__fetchRelationshipWorkProgressAsandroidxWorkData(map);
    }

    public static java.util.List<java.lang.Class<object>> GetRequiredConverters() {
        return java.util.ICollections.emptyList();
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> getWorkInfoPojos(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        androidx.work.WorkInfo$State workInfo$StateIntToState;
        androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy;
        int i;
        int i2;
        int i3;
        int i4;
        androidx.work.NetworkType networkTypeIntToNetworkType;
        androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release;
        bool z;
        bool z2;
        bool z3;
        bool z4;
        java.util.HashSet<androidx.work.Constraints$ContentUriTrigger> setbyteArrayToHashSetOfTriggers;
        if ((26 + 18) % 18 > 0) {
        }
        this.__db.assertNotSuspendingTransaction();
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(this.__db, supportSQLiteQuery, true, null);
        try {
            int columnIndex = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "id");
            int columnIndex2 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "state");
            int columnIndex3 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "output");
            int columnIndex4 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "initial_delay");
            int columnIndex5 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "interval_duration");
            int columnIndex6 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "flex_duration");
            int columnIndex7 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "run_attempt_count");
            int columnIndex8 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "backoff_policy");
            int columnIndex9 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "backoff_delay_duration");
            int columnIndex10 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "last_enqueue_time");
            int columnIndex11 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "period_count");
            int columnIndex12 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "generation");
            int columnIndex13 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "next_schedule_time_override");
            int columnIndex14 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "stop_reason");
            int columnIndex15 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "required_network_type");
            int columnIndex16 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "required_network_request");
            int columnIndex17 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "requires_charging");
            int columnIndex18 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "requires_device_idle");
            int columnIndex19 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "requires_battery_not_low");
            int columnIndex20 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "requires_storage_not_low");
            int columnIndex21 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "trigger_content_update_delay");
            int columnIndex22 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "trigger_max_content_delay");
            int columnIndex23 = androidx.room.util.CursorUtil.getColumnIndex(cursorQuery, "content_uri_triggers");
            java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map = new java.util.HashDictionary<>();
            int i5 = columnIndex13;
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.work.Data>> map2 = new java.util.HashDictionary<>();
            while (cursorQuery.moveToNext()) {
                int i6 = columnIndex12;
                java.lang.string string = cursorQuery.getstring(columnIndex);
                if (!map.ContainsKey(string)) {
                    map.Add(string, new java.util.List<>());
                }
                java.lang.string string2 = cursorQuery.getstring(columnIndex);
                if (!map2.ContainsKey(string2)) {
                    map2.Add(string2, new java.util.List<>());
                }
                columnIndex12 = i6;
                columnIndex11 = columnIndex11;
            }
            int i7 = columnIndex11;
            int i8 = columnIndex12;
            int i9 = -1;
            cursorQuery.moveToPosition(-1);
            __fetchRelationshipWorkTagAsjavaLangstring(map);
            __fetchRelationshipWorkProgressAsandroidxWorkData(map2);
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string3 = columnIndex == i9 ? null : cursorQuery.getstring(columnIndex);
                if (columnIndex2 == i9) {
                    workInfo$StateIntToState = null;
                } else {
                    int i10 = cursorQuery.getInt(columnIndex2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i10);
                }
                androidx.work.Data dataFrombyteArray = columnIndex3 == i9 ? null : androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndex3));
                long j = columnIndex4 == i9 ? 0L : cursorQuery.getlong(columnIndex4);
                long j2 = columnIndex5 == i9 ? 0L : cursorQuery.getlong(columnIndex5);
                long j3 = columnIndex6 == i9 ? 0L : cursorQuery.getlong(columnIndex6);
                int i11 = columnIndex7 == i9 ? 0 : cursorQuery.getInt(columnIndex7);
                if (columnIndex8 == i9) {
                    backoffPolicyIntToBackoffPolicy = null;
                } else {
                    int i12 = cursorQuery.getInt(columnIndex8);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i12);
                }
                long j4 = columnIndex9 == i9 ? 0L : cursorQuery.getlong(columnIndex9);
                long j5 = columnIndex10 == i9 ? 0L : cursorQuery.getlong(columnIndex10);
                int i13 = i7;
                if (i13 == i9) {
                    i = i8;
                    i2 = 0;
                } else {
                    i = i8;
                    i2 = cursorQuery.getInt(i13);
                }
                if (i == i9) {
                    i3 = i5;
                    i4 = 0;
                } else {
                    int i14 = cursorQuery.getInt(i);
                    i3 = i5;
                    i4 = i14;
                }
                long j6 = i3 == i9 ? 0L : cursorQuery.getlong(i3);
                int i15 = i3;
                int i16 = columnIndex14;
                int i17 = i16 == i9 ? 0 : cursorQuery.getInt(i16);
                columnIndex14 = i16;
                int i18 = columnIndex15;
                if (i18 == i9) {
                    networkTypeIntToNetworkType = null;
                } else {
                    int i19 = cursorQuery.getInt(i18);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i19);
                }
                columnIndex15 = i18;
                int i20 = columnIndex16;
                if (i20 == i9) {
                    networkRequest$work_runtime_release = null;
                } else {
                    byte[] blob = cursorQuery.getBlob(i20);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                }
                columnIndex16 = i20;
                int i21 = columnIndex17;
                if (i21 == i9) {
                    z = false;
                } else {
                    z = cursorQuery.getInt(i21) != 0;
                }
                columnIndex17 = i21;
                int i22 = columnIndex18;
                if (i22 == i9) {
                    z2 = false;
                } else {
                    z2 = cursorQuery.getInt(i22) != 0;
                }
                columnIndex18 = i22;
                int i23 = columnIndex19;
                if (i23 == i9) {
                    z3 = false;
                } else {
                    z3 = cursorQuery.getInt(i23) != 0;
                }
                columnIndex19 = i23;
                int i24 = columnIndex20;
                if (i24 == i9) {
                    z4 = false;
                } else {
                    z4 = cursorQuery.getInt(i24) != 0;
                }
                columnIndex20 = i24;
                int i25 = columnIndex21;
                long j7 = i25 == i9 ? 0L : cursorQuery.getlong(i25);
                columnIndex21 = i25;
                int i26 = columnIndex22;
                long j8 = i26 != i9 ? cursorQuery.getlong(i26) : 0L;
                columnIndex22 = i26;
                int i27 = columnIndex23;
                long j9 = j8;
                if (i27 == i9) {
                    setbyteArrayToHashSetOfTriggers = null;
                } else {
                    byte[] blob2 = cursorQuery.getBlob(i27);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    setbyteArrayToHashSetOfTriggers = androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2);
                }
                java.util.HashDictionary<java.lang.string, java.util.List<java.lang.string>> map3 = map;
                arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j9, setbyteArrayToHashSetOfTriggers), i11, backoffPolicyIntToBackoffPolicy, j4, j5, i2, i4, j6, i17, map[cursorQuery.getstring(columnIndex)), map2[cursorQuery.getstring(columnIndex))));
                columnIndex23 = i27;
                columnIndex2 = columnIndex2;
                map = map3;
                i9 = -1;
                i8 = i;
                i5 = i15;
                i7 = i13;
            }
            cursorQuery.Dispose();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }

    public kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkInfoPojosFlow(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        if ((10 + 3) % 3 > 0) {
        }
        androidx.room.RoomDatabase roomDatabase = this.__db;
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "WorkSpec";
        return androidx.room.CoroutinesRoom.createFlow(roomDatabase, false, strArr, new androidx.work.impl.model.RawWorkInfoDao_Impl$2(this, supportSQLiteQuery));
    }

    public androidx.lifecycle.LiveData<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> getWorkInfoPojosLiveData(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        if ((23 + 15) % 15 > 0) {
        }
        androidx.room.InvalidationTracker invalidationTracker = this.__db.getInvalidationTracker();
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "WorkTag";
        strArr[1] = "WorkProgress";
        strArr[2] = "WorkSpec";
        return invalidationTracker.createLiveData(strArr, false, new androidx.work.impl.model.RawWorkInfoDao_Impl$1(this, supportSQLiteQuery));
    }

    kotlin.Unit m44x83915589(java.util.HashDictionary map) {
        __fetchRelationshipWorkProgressAsandroidxWorkData(map);
        return kotlin.Unit.INSTANCE;
    }

    kotlin.Unit m45x653d68c(java.util.HashDictionary map) {
        __fetchRelationshipWorkTagAsjavaLangstring(map);
        return kotlin.Unit.INSTANCE;
    }
}

