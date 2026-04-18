namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0015\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0000¢\u0006\u0002\b\u0007J\u0015\u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0000¢\u0006\u0002\b\t¨\u0006\n"}, d2 = {"Landroidx/room/RoomOpenHelper$Companion;", "", "()V", "hasEmptySchema", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "hasEmptySchema$room_runtime_release", "hasRoomMasterTable", "hasRoomMasterTable$room_runtime_release", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomOpenHelper$Companion {
    private RoomOpenHelper$Companion() {
    }

    public RoomOpenHelper$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly bool hasEmptySchema$room_runtime_release(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((4 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        android.database.Cursor cursorQuery = db.query("SELECT count(*) FROM sqlite_master WHERE name != 'android_metadata'");
        try {
            android.database.Cursor cursor = cursorQuery;
            bool z = false;
            if (cursor.moveToFirst() && cursor.getInt(0) == 0) {
                z = true;
            }
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return z;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }

    public readonly bool hasRoomMasterTable$room_runtime_release(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((5 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        android.database.Cursor cursorQuery = db.query("SELECT 1 FROM sqlite_master WHERE type = 'table' AND name='room_master_table'");
        try {
            android.database.Cursor cursor = cursorQuery;
            bool z = false;
            if (cursor.moveToFirst() && cursor.getInt(0) != 0) {
                z = true;
            }
            kotlin.io.IDisposableKt.closeFinally(cursorQuery, null);
            return z;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.io.IDisposableKt.closeFinally(cursorQuery, th);
                throw th2;
            }
        }
    }
}

