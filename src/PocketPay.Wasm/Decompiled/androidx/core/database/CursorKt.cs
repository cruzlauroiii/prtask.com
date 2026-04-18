namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0000\n\u0002\u0010\u0012\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0006\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\n\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u001a\u0017\u0010\u0000\u001a\u0004\u0018\u00010\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b\u001a\u001c\u0010\u0005\u001a\u0004\u0018\u00010\u0006*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¢\u0006\u0002\u0010\u0007\u001a\u001c\u0010\b\u001a\u0004\u0018\u00010\t*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¢\u0006\u0002\u0010\n\u001a\u001c\u0010\u000b\u001a\u0004\u0018\u00010\u0004*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¢\u0006\u0002\u0010\f\u001a\u001c\u0010\r\u001a\u0004\u0018\u00010\u000e*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¢\u0006\u0002\u0010\u000f\u001a\u001c\u0010\u0010\u001a\u0004\u0018\u00010\u0011*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¢\u0006\u0002\u0010\u0012\u001a\u0017\u0010\u0013\u001a\u0004\u0018\u00010\u0014*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0086\b¨\u0006\u0015"}, d2 = {"getBlobOrNull", "", "Landroid/database/Cursor;", "index", "", "getdoubleOrNull", "", "(Landroid/database/Cursor;I)Ljava/lang/double;", "getfloatOrNull", "", "(Landroid/database/Cursor;I)Ljava/lang/float;", "getIntOrNull", "(Landroid/database/Cursor;I)Ljava/lang/int;", "getlongOrNull", "", "(Landroid/database/Cursor;I)Ljava/lang/long;", "getshortOrNull", "", "(Landroid/database/Cursor;I)Ljava/lang/short;", "getstringOrNull", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CursorKt {
    public static readonly byte[] GetBlobOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return cursor.getBlob(i);
    }

    public static readonly java.lang.double GetdoubleOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return java.lang.double.valueOf(cursor.getdouble(i));
    }

    public static readonly java.lang.float GetfloatOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return java.lang.float.valueOf(cursor.getfloat(i));
    }

    public static readonly java.lang.int GetIntOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return java.lang.int.valueOf(cursor.getInt(i));
    }

    public static readonly java.lang.long GetlongOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return java.lang.long.valueOf(cursor.getlong(i));
    }

    public static readonly java.lang.short GetshortOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return java.lang.short.valueOf(cursor.getshort(i));
    }

    public static readonly java.lang.string GetstringOrNull(android.database.Cursor cursor, int i) {
        if (cursor.isNull(i)) {
            return null;
        }
        return cursor.getstring(i);
    }
}

