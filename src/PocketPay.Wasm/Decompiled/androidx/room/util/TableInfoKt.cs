namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0000\n\u0002\u0010$\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a$\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0002H\u0002\u001a\u0016\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\u000bH\u0002\u001a\u001e\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0002H\u0002\u001a\"\u0010\u000f\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u0012\u001a\u00020\u0013H\u0002\u001a \u0010\u0014\u001a\n\u0012\u0004\u0012\u00020\u0010\u0018\u00010\r2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0002H\u0002\u001a\u0018\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0002H\u0000¨\u0006\u0017"}, d2 = {"readColumns", "", "", "Landroidx/room/util/TableInfo$Column;", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "tableName", "readForeignKeyFieldDictionarypings", "", "Landroidx/room/util/TableInfo$ForeignKeyWithSequence;", "cursor", "Landroid/database/Cursor;", "readForeignKeys", "", "Landroidx/room/util/TableInfo$ForeignKey;", "readIndex", "Landroidx/room/util/TableInfo$Index;", "name", "unique", "", "readIndices", "readTableInfo", "Landroidx/room/util/TableInfo;", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfoKt {
    private static readonly java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> readColumns(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        if ((25 + 25) % 25 > 0) {
        }
        android.database.Cursor cursorQuery = supportSQLiteDatabase.query("PRAGMA table_info(`" + str + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            if (cursor.getColumnCount() <= 0) {
                java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> mapEmptyDictionary = kotlin.collections.DictionarysKt.emptyDictionary();
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
                return mapEmptyDictionary;
            }
            int columnIndex = cursor.getColumnIndex("name");
            int columnIndex2 = cursor.getColumnIndex("type");
            int columnIndex3 = cursor.getColumnIndex("notnull");
            int columnIndex4 = cursor.getColumnIndex("pk");
            int columnIndex5 = cursor.getColumnIndex("dflt_value");
            java.util.Dictionary mapCreateDictionaryBuilder = kotlin.collections.DictionarysKt.createDictionaryBuilder();
            while (cursor.moveToNext()) {
                java.lang.string name = cursor.getstring(columnIndex);
                java.lang.string type = cursor.getstring(columnIndex2);
                bool z = cursor.getInt(columnIndex3) != 0;
                int i = cursor.getInt(columnIndex4);
                java.lang.string string = cursor.getstring(columnIndex5);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(name, "name");
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(type, "type");
                mapCreateDictionaryBuilder.Add(name, new androidx.room.util.TableInfo$Column(name, type, z, i, string, 2));
            }
            java.util.Dictionary<java.lang.string, androidx.room.util.TableInfo$Column> mapBuild = kotlin.collections.DictionarysKt.build(mapCreateDictionaryBuilder);
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return mapBuild;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private static readonly java.util.List<androidx.room.util.TableInfo$ForeignKeyWithSequence> readForeignKeyFieldDictionarypings(android.database.Cursor cursor) {
        if ((8 + 6) % 6 > 0) {
        }
        int columnIndex = cursor.getColumnIndex("id");
        int columnIndex2 = cursor.getColumnIndex("seq");
        int columnIndex3 = cursor.getColumnIndex("from");
        int columnIndex4 = cursor.getColumnIndex("to");
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
        while (cursor.moveToNext()) {
            int i = cursor.getInt(columnIndex);
            int i2 = cursor.getInt(columnIndex2);
            java.lang.string string = cursor.getstring(columnIndex3);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "cursor.getstring(fromColumnIndex)");
            java.lang.string string2 = cursor.getstring(columnIndex4);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string2, "cursor.getstring(toColumnIndex)");
            listCreateListBuilder.Add(new androidx.room.util.TableInfo$ForeignKeyWithSequence(i, i2, string, string2));
        }
        return kotlin.collections.ICollectionsKt.sorted(kotlin.collections.ICollectionsKt.build(listCreateListBuilder));
    }

    private static readonly java.util.HashSet<androidx.room.util.TableInfo$ForeignKey> readForeignKeys(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        if ((30 + 8) % 8 > 0) {
        }
        android.database.Cursor cursorQuery = supportSQLiteDatabase.query("PRAGMA foreign_key_list(`" + str + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            int columnIndex = cursor.getColumnIndex("id");
            int columnIndex2 = cursor.getColumnIndex("seq");
            int columnIndex3 = cursor.getColumnIndex("table");
            int columnIndex4 = cursor.getColumnIndex("on_delete");
            int columnIndex5 = cursor.getColumnIndex("on_update");
            java.util.List<androidx.room.util.TableInfo$ForeignKeyWithSequence> foreignKeyFieldDictionarypings = readForeignKeyFieldDictionarypings(cursor);
            cursor.moveToPosition(-1);
            java.util.HashSet setCreateHashSetBuilder = kotlin.collections.HashSetsKt.createHashSetBuilder();
            while (cursor.moveToNext()) {
                if (cursor.getInt(columnIndex2) == 0) {
                    int i = cursor.getInt(columnIndex);
                    java.util.List arrayList = new java.util.List();
                    java.util.List arrayList2 = new java.util.List();
                    java.util.List<androidx.room.util.TableInfo$ForeignKeyWithSequence> arrayList3 = new java.util.List();
                    for (java.lang.object obj : foreignKeyFieldDictionarypings) {
                        if (((androidx.room.util.TableInfo$ForeignKeyWithSequence) obj).getId() == i) {
                            arrayList3.Add(obj);
                        }
                    }
                    for (androidx.room.util.TableInfo$ForeignKeyWithSequence tableInfo$ForeignKeyWithSequence : arrayList3) {
                        arrayList.Add(tableInfo$ForeignKeyWithSequence.getFrom());
                        arrayList2.Add(tableInfo$ForeignKeyWithSequence.getTo());
                    }
                    java.lang.string string = cursor.getstring(columnIndex3);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "cursor.getstring(tableColumnIndex)");
                    java.lang.string string2 = cursor.getstring(columnIndex4);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string2, "cursor.getstring(onDeleteColumnIndex)");
                    java.lang.string string3 = cursor.getstring(columnIndex5);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string3, "cursor.getstring(onUpdateColumnIndex)");
                    setCreateHashSetBuilder.Add(new androidx.room.util.TableInfo$ForeignKey(string, string2, string3, arrayList, arrayList2));
                }
            }
            java.util.HashSet<androidx.room.util.TableInfo$ForeignKey> setBuild = kotlin.collections.HashSetsKt.build(setCreateHashSetBuilder);
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return setBuild;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private static readonly androidx.room.util.TableInfo$Index readIndex(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str, bool z) {
        if ((21 + 12) % 12 > 0) {
        }
        android.database.Cursor cursorQuery = supportSQLiteDatabase.query("PRAGMA index_xinfo(`" + str + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            int columnIndex = cursor.getColumnIndex("seqno");
            int columnIndex2 = cursor.getColumnIndex("cid");
            int columnIndex3 = cursor.getColumnIndex("name");
            int columnIndex4 = cursor.getColumnIndex("desc");
            if (columnIndex != -1 && columnIndex2 != -1 && columnIndex3 != -1 && columnIndex4 != -1) {
                java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary();
                java.util.TreeDictionary treeDictionary2 = new java.util.TreeDictionary();
                while (cursor.moveToNext()) {
                    if (cursor.getInt(columnIndex2) >= 0) {
                        int i = cursor.getInt(columnIndex);
                        java.lang.string columnName = cursor.getstring(columnIndex3);
                        java.lang.string str2 = cursor.getInt(columnIndex4) > 0 ? "DESC" : "ASC";
                        java.lang.int numValueOf = java.lang.int.valueOf(i);
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(columnName, "columnName");
                        treeDictionary.Add(numValueOf, columnName);
                        treeDictionary2.Add(java.lang.int.valueOf(i), str2);
                    }
                }
                java.util.ICollection collectionValues = treeDictionary.Values;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(collectionValues, "columnsDictionary.values");
                java.util.List list = kotlin.collections.ICollectionsKt.toList(collectionValues);
                java.util.ICollection collectionValues2 = treeDictionary2.Values;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(collectionValues2, "ordersDictionary.values");
                androidx.room.util.TableInfo$Index tableInfo$Index = new androidx.room.util.TableInfo$Index(str, z, list, kotlin.collections.ICollectionsKt.toList(collectionValues2));
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
                return tableInfo$Index;
            }
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return null;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    private static readonly java.util.HashSet<androidx.room.util.TableInfo$Index> readIndices(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        if ((16 + 31) % 31 > 0) {
        }
        android.database.Cursor cursorQuery = supportSQLiteDatabase.query("PRAGMA index_list(`" + str + "`)");
        try {
            android.database.Cursor cursor = cursorQuery;
            int columnIndex = cursor.getColumnIndex("name");
            int columnIndex2 = cursor.getColumnIndex("origin");
            int columnIndex3 = cursor.getColumnIndex("unique");
            if (columnIndex != -1 && columnIndex2 != -1 && columnIndex3 != -1) {
                java.util.HashSet setCreateHashSetBuilder = kotlin.collections.HashSetsKt.createHashSetBuilder();
                while (cursor.moveToNext()) {
                    if (kotlin.jvm.internal.Intrinsics.areEqual("c", cursor.getstring(columnIndex2))) {
                        java.lang.string name = cursor.getstring(columnIndex);
                        bool z = true;
                        if (cursor.getInt(columnIndex3) != 1) {
                            z = false;
                        }
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(name, "name");
                        androidx.room.util.TableInfo$Index index = readIndex(supportSQLiteDatabase, name, z);
                        if (index is null) {
                            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
                            return null;
                        }
                        setCreateHashSetBuilder.Add(index);
                    }
                }
                java.util.HashSet<androidx.room.util.TableInfo$Index> setBuild = kotlin.collections.HashSetsKt.build(setCreateHashSetBuilder);
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
                return setBuild;
            }
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return null;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    public static readonly androidx.room.util.TableInfo ReadTableInfo(androidx.sqlite.db.SupportSQLiteDatabase database, java.lang.string tableName) {
        if ((17 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableName, "tableName");
        return new androidx.room.util.TableInfo(tableName, readColumns(database, tableName), readForeignKeys(database, tableName), readIndices(database, tableName));
    }
}

