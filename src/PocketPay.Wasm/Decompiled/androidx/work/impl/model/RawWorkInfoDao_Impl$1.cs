namespace WillowMaze.Wasm.Decompiled;


class RawWorkInfoDao_Impl$1 : java.util.concurrent.Func<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> {
    readonly androidx.work.impl.model.RawWorkInfoDao_Impl this$0;
    readonly androidx.sqlite.db.SupportSQLiteQuery val$query;

    RawWorkInfoDao_Impl$1(androidx.work.impl.model.RawWorkInfoDao_Impl rawWorkInfoDao_Impl, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        this.this$0 = rawWorkInfoDao_Impl;
        this.val$query = supportSQLiteQuery;
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> call() throws java.lang.Exception {
        return call2();
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> call2() throws java.lang.Exception {
        androidx.work.WorkInfo$State workInfo$StateIntToState;
        androidx.work.BackoffPolicy backoffPolicyIntToBackoffPolicy;
        int i;
        int i2;
        int i3;
        int i4;
        long j;
        int i5;
        int i6;
        int i7;
        int i8;
        androidx.work.NetworkType networkTypeIntToNetworkType;
        int i9;
        androidx.work.impl.utils.NetworkRequestCompat networkRequest$work_runtime_release;
        int i10;
        bool z;
        int i11;
        bool z2;
        int i12;
        bool z3;
        int i13;
        bool z4;
        long j2;
        int i14;
        java.util.HashSet<androidx.work.Constraints$ContentUriTrigger> setbyteArrayToHashSetOfTriggers;
        if ((23 + 19) % 19 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(androidx.work.impl.model.RawWorkInfoDao_Impl.access$000(this.this$0), this.val$query, true, null);
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
            java.util.HashDictionary map = new java.util.HashDictionary();
            int i15 = columnIndex13;
            java.util.HashDictionary map2 = new java.util.HashDictionary();
            while (cursorQuery.moveToNext()) {
                int i16 = columnIndex12;
                java.lang.string string = cursorQuery.getstring(columnIndex);
                if (!map.ContainsKey(string)) {
                    map.Add(string, new java.util.List());
                }
                java.lang.string string2 = cursorQuery.getstring(columnIndex);
                if (!map2.ContainsKey(string2)) {
                    map2.Add(string2, new java.util.List());
                }
                columnIndex12 = i16;
                columnIndex11 = columnIndex11;
            }
            int i17 = columnIndex11;
            int i18 = columnIndex12;
            int i19 = -1;
            cursorQuery.moveToPosition(-1);
            androidx.work.impl.model.RawWorkInfoDao_Impl.access$100(this.this$0, map);
            androidx.work.impl.model.RawWorkInfoDao_Impl.access$200(this.this$0, map2);
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string3 = columnIndex == i19 ? null : cursorQuery.getstring(columnIndex);
                if (columnIndex2 == i19) {
                    workInfo$StateIntToState = null;
                } else {
                    int i20 = cursorQuery.getInt(columnIndex2);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    workInfo$StateIntToState = androidx.work.impl.model.WorkTypeConverters.intToState(i20);
                }
                androidx.work.Data dataFrombyteArray = columnIndex3 == i19 ? null : androidx.work.Data.frombyteArray(cursorQuery.getBlob(columnIndex3));
                long j3 = columnIndex4 == i19 ? 0L : cursorQuery.getlong(columnIndex4);
                long j4 = columnIndex5 == i19 ? 0L : cursorQuery.getlong(columnIndex5);
                long j5 = columnIndex6 == i19 ? 0L : cursorQuery.getlong(columnIndex6);
                int i21 = columnIndex7 == i19 ? 0 : cursorQuery.getInt(columnIndex7);
                if (columnIndex8 == i19) {
                    backoffPolicyIntToBackoffPolicy = null;
                } else {
                    int i22 = cursorQuery.getInt(columnIndex8);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    backoffPolicyIntToBackoffPolicy = androidx.work.impl.model.WorkTypeConverters.intToBackoffPolicy(i22);
                }
                long j6 = columnIndex9 == i19 ? 0L : cursorQuery.getlong(columnIndex9);
                long j7 = columnIndex10 == i19 ? 0L : cursorQuery.getlong(columnIndex10);
                int i23 = i17;
                if (i23 == i19) {
                    i = i18;
                    i2 = 0;
                } else {
                    i = i18;
                    i2 = cursorQuery.getInt(i23);
                }
                if (i == i19) {
                    i3 = i15;
                    i4 = 0;
                } else {
                    int i24 = cursorQuery.getInt(i);
                    i3 = i15;
                    i4 = i24;
                }
                if (i3 == i19) {
                    i5 = columnIndex14;
                    j = 0;
                } else {
                    j = cursorQuery.getlong(i3);
                    i5 = columnIndex14;
                }
                if (i5 == i19) {
                    i6 = columnIndex15;
                    i7 = 0;
                } else {
                    int i25 = cursorQuery.getInt(i5);
                    i6 = columnIndex15;
                    i7 = i25;
                }
                if (i6 == i19) {
                    i8 = columnIndex16;
                    networkTypeIntToNetworkType = null;
                } else {
                    int i26 = cursorQuery.getInt(i6);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    i8 = columnIndex16;
                    networkTypeIntToNetworkType = androidx.work.impl.model.WorkTypeConverters.intToNetworkType(i26);
                }
                if (i8 == i19) {
                    i9 = columnIndex17;
                    networkRequest$work_runtime_release = null;
                } else {
                    byte[] blob = cursorQuery.getBlob(i8);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    i9 = columnIndex17;
                    networkRequest$work_runtime_release = androidx.work.impl.model.WorkTypeConverters.toNetworkRequest$work_runtime_release(blob);
                }
                if (i9 == i19) {
                    i10 = columnIndex18;
                    z = false;
                } else {
                    bool z5 = cursorQuery.getInt(i9) != 0;
                    i10 = columnIndex18;
                    z = z5;
                }
                if (i10 == i19) {
                    i11 = columnIndex19;
                    z2 = false;
                } else {
                    bool z6 = cursorQuery.getInt(i10) != 0;
                    i11 = columnIndex19;
                    z2 = z6;
                }
                if (i11 == i19) {
                    i12 = columnIndex20;
                    z3 = false;
                } else {
                    bool z7 = cursorQuery.getInt(i11) != 0;
                    i12 = columnIndex20;
                    z3 = z7;
                }
                if (i12 == i19) {
                    i13 = columnIndex21;
                    z4 = false;
                } else {
                    bool z8 = cursorQuery.getInt(i12) != 0;
                    i13 = columnIndex21;
                    z4 = z8;
                }
                if (i13 == i19) {
                    i14 = columnIndex22;
                    j2 = 0;
                } else {
                    j2 = cursorQuery.getlong(i13);
                    i14 = columnIndex22;
                }
                int i27 = columnIndex23;
                int i28 = i14;
                long j8 = i14 != i19 ? cursorQuery.getlong(i14) : 0L;
                if (i27 == i19) {
                    setbyteArrayToHashSetOfTriggers = null;
                } else {
                    byte[] blob2 = cursorQuery.getBlob(i27);
                    androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
                    setbyteArrayToHashSetOfTriggers = androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2);
                }
                java.util.HashDictionary map3 = map;
                arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j3, j4, j5, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j2, j8, setbyteArrayToHashSetOfTriggers), i21, backoffPolicyIntToBackoffPolicy, j6, j7, i2, i4, j, i7, (java.util.List) map[cursorQuery.getstring(columnIndex)), (java.util.List) map2[cursorQuery.getstring(columnIndex))));
                columnIndex23 = i27;
                columnIndex2 = columnIndex2;
                i18 = i;
                i15 = i3;
                columnIndex14 = i5;
                columnIndex15 = i6;
                columnIndex16 = i8;
                columnIndex17 = i9;
                columnIndex18 = i10;
                columnIndex19 = i11;
                columnIndex20 = i12;
                columnIndex21 = i13;
                columnIndex22 = i28;
                i17 = i23;
                map = map3;
                i19 = -1;
            }
            cursorQuery.Dispose();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            throw th;
        }
    }
}

