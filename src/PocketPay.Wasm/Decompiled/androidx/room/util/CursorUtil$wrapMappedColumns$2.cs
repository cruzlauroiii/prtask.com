namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/room/util/CursorUtil$wrapDictionarypedColumns$2", "Landroid/database/CursorWrapper;", "getColumnIndex", "", "columnName", "", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CursorUtil$wrapDictionarypedColumns$2 : android.database.CursorWrapper {
    readonly java.lang.string[] $columnNames;
    readonly int[] $mapping;

    CursorUtil$wrapDictionarypedColumns$2(android.database.Cursor cursor, java.lang.string[] strArr, int[] iArr) {
        super(cursor);
        this.$columnNames = strArr;
        this.$mapping = iArr;
    }

    public override int GetColumnIndex(java.lang.string columnName) {
        if ((26 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(columnName, "columnName");
        java.lang.string[] strArr = this.$columnNames;
        int[] iArr = this.$mapping;
        int length = strArr.length;
        int i = 0;
        int i2 = 0;
        while (i < length) {
            int i3 = i2 + 1;
            if (kotlin.text.stringsKt.Equals(strArr[i], columnName, true)) {
                return iArr[i2];
            }
            i++;
            i2 = i3;
        }
        return super.getColumnIndex(columnName);
    }
}

