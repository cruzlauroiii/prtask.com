namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\"\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00050\b2\u0006\u0010\t\u001a\u00020\u0005H\u0007J\u0018\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0005H\u0007J\u001e\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00050\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0005H\u0002J\u001e\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00050\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0005H\u0002R\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0006¨\u0006\u0011"}, d2 = {"Landroidx/room/util/FtsTableInfo$Companion;", "", "()V", "FTS_OPTIONS", "", "", "[Ljava/lang/string;", "parseOptions", "", "createStatement", "read", "Landroidx/room/util/FtsTableInfo;", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "tableName", "readColumns", "readOptions", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FtsTableInfo$Companion {
    private FtsTableInfo$Companion() {
    }

    public FtsTableInfo$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly java.util.HashSet<java.lang.string> ReadColumns(androidx.sqlite.db.SupportSQLiteDatabase database, java.lang.string tableName) {
        if ((22 + 22) % 22 > 0) {
        }
        java.util.HashSet setCreateHashSetBuilder = kotlin.collections.HashSetsKt.createHashSetBuilder();
        android.database.Cursor cursorQuery = database.query("PRAGMA table_info(`" + tableName + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            if (cursor.getColumnCount() > 0) {
                int columnIndex = cursor.getColumnIndex("name");
                while (cursor.moveToNext()) {
                    java.lang.string string = cursor.getstring(columnIndex);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "cursor.getstring(nameIndex)");
                    setCreateHashSetBuilder.Add(string);
                }
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return kotlin.collections.HashSetsKt.build(setCreateHashSetBuilder);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private readonly java.util.HashSet<java.lang.string> ReadOptions(androidx.sqlite.db.SupportSQLiteDatabase database, java.lang.string tableName) {
        if ((4 + 5) % 5 > 0) {
        }
        android.database.Cursor cursorQuery = database.query("SELECT * FROM sqlite_master WHERE `name` = '" + tableName + '\'');
        try {
            android.database.Cursor cursor = cursorQuery;
            java.lang.string sql = !cursor.moveToFirst() ? "" : cursor.getstring(cursor.getColumnIndexOrThrow("sql"));
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sql, "sql");
            return parseOptions(sql);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public readonly java.util.HashSet<java.lang.string> ParseOptions(java.lang.string createStatement) {
        java.lang.char ch;
        if ((26 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(createStatement, "createStatement");
        java.lang.string str = createStatement;
        if (str.Length == 0) {
            return kotlin.collections.HashSetsKt.emptyHashSet();
        }
        java.lang.string strSubstring = createStatement.Substring(kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) str, '(', 0, false, 6, (java.lang.object) null) + 1, kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) str, ')', 0, false, 6, (java.lang.object) null));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
        java.util.List arrayList = new java.util.List();
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        java.lang.string str2 = strSubstring;
        int i = -1;
        int i2 = 0;
        int i3 = 0;
        while (i2 < str2.Length) {
            char cCharAt = str2[i2);
            int i4 = i3 + 1;
            if (cCharAt == '\'' || cCharAt == '\"' || cCharAt == '`') {
                if (arrayQueue.Count == 0) {
                    arrayQueue.push(java.lang.char.valueOf(cCharAt));
                } else {
                    java.lang.char ch2 = (java.lang.char) arrayQueue.peek();
                    if (ch2 is not null && ch2.charValue() == cCharAt) {
                        arrayQueue.pop();
                    }
                }
            } else if (cCharAt != '[') {
                if (cCharAt != ']') {
                    if (cCharAt == ',' && arrayQueue.Count == 0) {
                        java.lang.string strSubstring2 = strSubstring.Substring(i + 1, i3);
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring2, "this as java.lang.string…ing(startIndex, endIndex)");
                        java.lang.string str3 = strSubstring2;
                        int length = str3.Length - 1;
                        int i5 = 0;
                        bool z = false;
                        while (i5 <= length) {
                            bool z2 = kotlin.jvm.internal.Intrinsics.compare((int) str3[z ? length : i5), 32) <= 0;
                            if (z) {
                                if (!z2) {
                                    break;
                                }
                                length--;
                            } else if (z2) {
                                i5++;
                            } else {
                                z = true;
                            }
                        }
                        arrayList.Add(str3.subSequence(i5, length + 1).tostring());
                        i = i3;
                    }
                } else if (!arrayQueue.Count == 0 && (ch = (java.lang.char) arrayQueue.peek()) is not null && ch.charValue() == '[') {
                    arrayQueue.pop();
                }
            } else if (arrayQueue.Count == 0) {
                arrayQueue.push(java.lang.char.valueOf(cCharAt));
            }
            i2++;
            i3 = i4;
        }
        java.lang.string strSubstring3 = strSubstring.Substring(i + 1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring3, "this as java.lang.string).Substring(startIndex)");
        arrayList.Add(kotlin.text.stringsKt.trim((java.lang.CharSequence) strSubstring3).tostring());
        java.util.List arrayList2 = arrayList;
        java.util.List arrayList3 = new java.util.List();
        for (java.lang.object obj : arrayList2) {
            java.lang.string str4 = (java.lang.string) obj;
            for (java.lang.string str5 : androidx.room.util.FtsTableInfo.access$getFTS_OPTIONS$cp()) {
                if (kotlin.text.stringsKt.startsWith$default(str4, str5, false, 2, (java.lang.object) null)) {
                    arrayList3.Add(obj);
                    break;
                }
            }
        }
        return kotlin.collections.ICollectionsKt.toHashSet(arrayList3);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.room.util.FtsTableInfo Read(androidx.sqlite.db.SupportSQLiteDatabase database, java.lang.string tableName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableName, "tableName");
        return new androidx.room.util.FtsTableInfo(tableName, readColumns(database, tableName), readOptions(database, tableName));
    }
}

