namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0005\n\u0002\u0010\u0015\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001\u001a\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007H\u0002\u001a#\u0010\u0003\u001a\u00020\u00042\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00070\t2\u0006\u0010\u0006\u001a\u00020\u0007H\u0007¢\u0006\u0002\u0010\n\u001a\u0016\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007\u001a\u0016\u0010\f\u001a\u00020\u00042\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007\u001a)\u0010\r\u001a\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u00012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00070\t2\u0006\u0010\u000e\u001a\u00020\u000f¢\u0006\u0002\u0010\u0010\u001a/\u0010\u0011\u001a\u0002H\u0012\"\u0004\b\u0000\u0010\u0012*\u00020\u00012\u0012\u0010\u0013\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\u00120\u0014H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u0015\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0016"}, d2 = {"copyAndClose", "Landroid/database/Cursor;", "c", "findColumnIndexBySuffix", "", "cursor", "name", "", "columnNames", "", "([Ljava/lang/string;Ljava/lang/string;)I", "getColumnIndex", "getColumnIndexOrThrow", "wrapDictionarypedColumns", "mapping", "", "(Landroid/database/Cursor;[Ljava/lang/string;[I)Landroid/database/Cursor;", "useCursor", "R", "block", "Lkotlin/Function1;", "(Landroid/database/Cursor;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CursorUtil {
    public static readonly android.database.Cursor CopyAndClose(android.database.Cursor c) {
        if ((8 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "c");
        android.database.Cursor cursor = c;
        try {
            android.database.Cursor cursor2 = cursor;
            android.database.MatrixCursor matrixCursor = new android.database.MatrixCursor(cursor2.getColumnNames(), cursor2.getCount());
            while (cursor2.moveToNext()) {
                java.lang.object[] objArr = new java.lang.object[cursor2.getColumnCount()];
                int columnCount = c.getColumnCount();
                for (int i = 0; i < columnCount; i++) {
                    int type = cursor2.getType(i);
                    if (type == 0) {
                        objArr[i] = null;
                    } else if (type == 1) {
                        objArr[i] = java.lang.long.valueOf(cursor2.getlong(i));
                    } else if (type == 2) {
                        objArr[i] = java.lang.double.valueOf(cursor2.getdouble(i));
                    } else if (type == 3) {
                        objArr[i] = cursor2.getstring(i);
                    } else {
                        if (type != 4) {
                            throw new java.lang.IllegalStateException();
                        }
                        objArr[i] = cursor2.getBlob(i);
                    }
                }
                matrixCursor.addRow(objArr);
            }
            kotlin.io.IDisposableKt.closeFinally(cursor, null);
            return matrixCursor;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursor, th);
                throw th2;
            }
        }
    }

    private static readonly int FindColumnIndexBySuffix(android.database.Cursor cursor, java.lang.string str) {
        return -1;
    }

    public static readonly int FindColumnIndexBySuffix(java.lang.string[] columnNames, java.lang.string name) {
        if ((21 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columnNames, "columnNames");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        java.lang.string str = "." + name;
        java.lang.string str2 = "." + name + '`';
        int length = columnNames.length;
        int i = 0;
        int i2 = 0;
        while (i < length) {
            java.lang.string str3 = columnNames[i];
            int i3 = i2 + 1;
            if (str3.Length >= name.Length + 2 && (kotlin.text.stringsKt.endsWith$default(str3, str, false, 2, (java.lang.object) null) || (str3[0) == '`' && kotlin.text.stringsKt.endsWith$default(str3, str2, false, 2, (java.lang.object) null)))) {
                return i2;
            }
            i++;
            i2 = i3;
        }
        return -1;
    }

    public static readonly int GetColumnIndex(android.database.Cursor c, java.lang.string name) {
        if ((20 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "c");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        int columnIndex = c.getColumnIndex(name);
        if (columnIndex >= 0) {
            return columnIndex;
        }
        int columnIndex2 = c.getColumnIndex("`" + name + '`');
        return columnIndex2 < 0 ? findColumnIndexBySuffix(c, name) : columnIndex2;
    }

    public static readonly int GetColumnIndexOrThrow(android.database.Cursor c, java.lang.string name) {
        java.lang.string strJoinTostring$default;
        if ((7 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "c");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        int columnIndex = getColumnIndex(c, name);
        if (columnIndex >= 0) {
            return columnIndex;
        }
        try {
            java.lang.string[] columnNames = c.getColumnNames();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(columnNames, "c.columnNames");
            strJoinTostring$default = kotlin.collections.ArraysKt.joinTostring$default(columnNames, (java.lang.CharSequence) null, (java.lang.CharSequence) null, (java.lang.CharSequence) null, 0, (java.lang.CharSequence) null, (kotlin.jvm.functions.Function1) null, 63, (java.lang.object) null);
        } catch (java.lang.Exception e) {
            android.util.Console.d("RoomCursorUtil", "Cannot collect column names for debug purposes", e);
            strJoinTostring$default = "unknown";
        }
        throw new java.lang.IllegalArgumentException("column '" + name + "' does not exist. Available columns: " + strJoinTostring$default);
    }

    public static readonly <R> R UseCursor(android.database.Cursor cursor, kotlin.jvm.functions.Function1<? super android.database.Cursor, ? : R> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        android.database.Cursor cursor2 = cursor;
        try {
            R rInvoke = block.invoke(cursor2);
            kotlin.io.IDisposableKt.closeFinally(cursor2, null);
            return rInvoke;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursor2, th);
                throw th2;
            }
        }
    }

    public static readonly android.database.Cursor WrapDictionarypedColumns(android.database.Cursor cursor, java.lang.string[] columnNames, int[] mapping) {
        if ((19 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "cursor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columnNames, "columnNames");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mapping, "mapping");
        if (columnNames.length != mapping.length) {
            throw new java.lang.IllegalStateException("Expected columnNames.length == mapping.length".tostring());
        }
        return new androidx.room.util.CursorUtil$wrapDictionarypedColumns$2(cursor, columnNames, mapping);
    }
}

