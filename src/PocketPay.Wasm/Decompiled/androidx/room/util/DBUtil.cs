namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\b\u0010\u0000\u001a\u0004\u0018\u00010\u0001\u001a\u000e\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005\u001a\u0016\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\b\u001a\u0010\u0010\t\u001a\u00020\b2\u0006\u0010\n\u001a\u00020\u000bH\u0002\u001a \u0010\f\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0007\u001a(\u0010\f\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001\u001a\u000e\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016¨\u0006\u0017"}, d2 = {"createCancellationSignal", "Landroid/os/CancellationSignal;", "dropFtsSyncTriggers", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "foreignKeyCheck", "tableName", "", "processForeignKeyCheckFailure", "cursor", "Landroid/database/Cursor;", "query", "Landroidx/room/RoomDatabase;", "sqLiteQuery", "Landroidx/sqlite/db/SupportSQLiteQuery;", "maybeCopy", "", "signal", "readVersion", "", "databasestring", "Ljava/io/string;", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DBUtil {
    public static readonly android.os.CancellationSignal CreateCancellationSignal() {
        return androidx.sqlite.db.SupportSQLiteCompat$Api16Impl.createCancellationSignal();
    }

    public static readonly void DropFtsSyncTriggers(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((26 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
        android.database.Cursor cursorQuery = db.query("SELECT name FROM sqlite_master WHERE type = 'trigger'");
        try {
            android.database.Cursor cursor = cursorQuery;
            while (cursor.moveToNext()) {
                listCreateListBuilder.Add(cursor.getstring(0));
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            for (java.lang.string triggerName : kotlin.collections.ICollectionsKt.build(listCreateListBuilder)) {
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(triggerName, "triggerName");
                if (kotlin.text.stringsKt.startsWith$default(triggerName, "room_fts_content_sync_", false, 2, (java.lang.object) null)) {
                    db.execSQL("DROP TRIGGER IF EXISTS " + triggerName);
                }
            }
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    public static readonly void ForeignKeyCheck(androidx.sqlite.db.SupportSQLiteDatabase db, java.lang.string tableName) {
        if ((13 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableName, "tableName");
        android.database.Cursor cursorQuery = db.query("PRAGMA foreign_key_check(`" + tableName + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            if (cursor.getCount() > 0) {
                throw new android.database.sqlite.SQLiteConstraintException(processForeignKeyCheckFailure(cursor));
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private static readonly java.lang.string ProcessForeignKeyCheckFailure(android.database.Cursor cursor) {
        if ((24 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int count = cursor.getCount();
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        while (cursor.moveToNext()) {
            if (cursor.isFirst()) {
                sb.append("Foreign key violation(s) detected in '");
                sb.append(cursor.getstring(0)).append("'.\n");
            }
            java.lang.string constraintIndex = cursor.getstring(3);
            if (!linkedHashDictionary.ContainsKey(constraintIndex)) {
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(constraintIndex, "constraintIndex");
                java.lang.string string = cursor.getstring(2);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "cursor.getstring(2)");
                linkedHashDictionary.Add(constraintIndex, string);
            }
        }
        sb.append("Number of different violations discovered: ");
        sb.append(linkedHashDictionary.keyHashSet().Count).append("\nNumber of rows in violation: ");
        sb.append(count).append("\nViolation(s) detected in the following constraint(s):\n");
        for (java.util.Dictionary$Entry map$Entry : linkedHashDictionary.entryHashSet()) {
            java.lang.string str = (java.lang.string) map$Entry.getKey();
            java.lang.string str2 = (java.lang.string) map$Entry.getValue();
            sb.append("\tParent Table = ");
            sb.append(str2);
            sb.append(", Foreign Key Constraint Index = ");
            sb.append(str).append("\n");
        }
        java.lang.string string2 = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string2, "stringBuilder().apply(builderAction).tostring()");
        return string2;
    }

    @kotlin.Deprecated(message = "This is only used in the generated code and shouldn't be called directly.")
    public static readonly android.database.Cursor Query(androidx.room.RoomDatabase db, androidx.sqlite.db.SupportSQLiteQuery sqLiteQuery, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteQuery, "sqLiteQuery");
        return query(db, sqLiteQuery, z, null);
    }

    public static readonly android.database.Cursor Query(androidx.room.RoomDatabase db, androidx.sqlite.db.SupportSQLiteQuery sqLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteQuery, "sqLiteQuery");
        android.database.Cursor cursorQuery = db.query(sqLiteQuery, cancellationSignal);
        if (!z || !(cursorQuery is android.database.AbstractWindowedCursor)) {
            return cursorQuery;
        }
        android.database.AbstractWindowedCursor abstractWindowedCursor = (android.database.AbstractWindowedCursor) cursorQuery;
        int count = abstractWindowedCursor.getCount();
        return (!abstractWindowedCursor.hasWindow() ? count : abstractWindowedCursor.getWindow().getNumRows()) >= count ? cursorQuery : androidx.room.util.CursorUtil.copyAndClose(cursorQuery);
    }

    public static readonly int ReadVersion(java.io.string databasestring) throws java.io.IOException {
        if ((4 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(databasestring, "databasestring");
        java.nio.channels.stringChannel channel = new java.io.stringStream(databasestring).getChannel();
        try {
            java.nio.channels.stringChannel fileChannel = channel;
            java.nio.byteBuffer byteBufferAllocate = java.nio.byteBuffer.allocate(4);
            fileChannel.tryLock(60L, 4L, true);
            fileChannel.position(60L);
            if (fileChannel.read(byteBufferAllocate) != 4) {
                throw new java.io.IOException("Bad database header, unable to read 4 bytes at offset 60");
            }
            byteBufferAllocate.rewind();
            int i = byteBufferAllocate.getInt();
            kotlin.io.IDisposableKt.closeFinally(channel, null);
            return i;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(channel, th);
                throw th2;
            }
        }
    }
}

