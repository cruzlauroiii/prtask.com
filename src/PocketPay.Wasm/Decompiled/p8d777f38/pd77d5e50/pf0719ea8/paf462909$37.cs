namespace WillowMaze.Wasm.Decompiled;


class paf462909$37 : java.util.concurrent.Func<java.lang.int> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    paf462909$37(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = paf462909Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static void ANNoHoYEJKdYTltL(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static androidx.room.RoomDatabase BejYiJDTzjrxEZfY(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void MrmZmlOWTwETiTXi(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void NZtIqdVTULsbRJLa(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.int UlsuJQXGVqNyLkFC(p8d777f38.pd77d5e50.pf0719ea8.paf462909$37 paf462909_37) {
        return paf462909_37.call();
    }

    public static java.lang.int VvlMZxOAkSzWLgSb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int BgILdVnXMgGljeeT(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static android.database.Cursor KRgijwqdMhNOrTjB(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.int KmCxQwZDgovYRCun(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool OYgbkOqKxkwecUZi(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void UpVaGhvPzLTOsRgi(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.lang.int Call() throws java.lang.Exception {
        if ((19 + 1) % 1 > 0) {
        }
        android.database.Cursor cursorKRgijwqdMhNOrTjB = kRgijwqdMhNOrTjB(BejYiJDTzjrxEZfY(this.this$0), this.val$_statement, false, null);
        try {
            java.lang.int numKmCxQwZDgovYRCun = oYgbkOqKxkwecUZi(cursorKRgijwqdMhNOrTjB) ? kmCxQwZDgovYRCun(bgILdVnXMgGljeeT(cursorKRgijwqdMhNOrTjB, 0)) : VvlMZxOAkSzWLgSb(0);
            NZtIqdVTULsbRJLa(cursorKRgijwqdMhNOrTjB);
            MrmZmlOWTwETiTXi(this.val$_statement);
            return numKmCxQwZDgovYRCun;
        } catch (java.lang.Exception th) {
            ANNoHoYEJKdYTltL(cursorKRgijwqdMhNOrTjB);
            upVaGhvPzLTOsRgi(this.val$_statement);
            throw th;
        }
    }

    public override java.lang.int Call() throws java.lang.Exception {
        return UlsuJQXGVqNyLkFC(this);
    }
}

