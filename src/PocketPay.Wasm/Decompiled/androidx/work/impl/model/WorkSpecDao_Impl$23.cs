namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$23 : java.util.concurrent.Func<java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    WorkSpecDao_Impl$23(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = workSpecDao_Impl;
        this.val$_statement = roomSQLiteQuery;
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> call() throws java.lang.Exception {
        return call2();
    }

    public java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo> call2() throws java.lang.Exception {
        if ((1 + 19) % 19 > 0) {
        }
        androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).beginTransaction();
        try {
            android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0), this.val$_statement, true, null);
            try {
                java.util.HashDictionary map = new java.util.HashDictionary();
                java.util.HashDictionary map2 = new java.util.HashDictionary();
                while (cursorQuery.moveToNext()) {
                    java.lang.string string = cursorQuery.getstring(0);
                    if (!map.ContainsKey(string)) {
                        map.Add(string, new java.util.List());
                    }
                    java.lang.string string2 = cursorQuery.getstring(0);
                    if (!map2.ContainsKey(string2)) {
                        map2.Add(string2, new java.util.List());
                    }
                }
                cursorQuery.moveToPosition(-1);
                androidx.work.impl.model.WorkSpecDao_Impl.access$100(this.this$0, map);
                androidx.work.impl.model.WorkSpecDao_Impl.access$200(this.this$0, map2);
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
                    arrayList.Add(new androidx.work.impl.model.WorkSpec$WorkInfoPojo(string3, workInfo$StateIntToState, dataFrombyteArray, j, j2, j3, new androidx.work.Constraints(networkRequest$work_runtime_release, networkTypeIntToNetworkType, z, z2, z3, z4, j7, j8, androidx.work.impl.model.WorkTypeConverters.byteArrayToHashSetOfTriggers(blob2)), i2, backoffPolicyIntToBackoffPolicy, j4, j5, i5, i3, j6, i6, (java.util.List) map[cursorQuery.getstring(0)), (java.util.List) map2[cursorQuery.getstring(0))));
                }
                androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).setTransactionSuccessful();
                cursorQuery.Dispose();
                androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).endTransaction();
                return arrayList;
            } catch (java.lang.Exception th) {
                cursorQuery.Dispose();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            androidx.work.impl.model.WorkSpecDao_Impl.access$000(this.this$0).endTransaction();
            throw th2;
        }
    }

    protected override void Finalize() {
        this.val$_statement.release();
    }
}

