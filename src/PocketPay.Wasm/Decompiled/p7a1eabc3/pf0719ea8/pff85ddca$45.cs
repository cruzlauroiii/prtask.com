namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$45 : java.util.concurrent.Func<java.util.List<pad5f82e8.p07214c67.pd77d5e50.peaf39066>> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$45(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static int EwhNdTCZMcMSMjfg(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string FLmiWTUJKuyEivuI(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static androidx.room.RoomDatabase FNrADAcWLFDNyQQg(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static int IqzquTfRvYUsBEgL(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string IrgVNvgHAmGrKQRn(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void MEXKdKVVfgPNxVjY(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int OwbRYrLyCKrNIXEN(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static bool VTStznqUswbxiqON(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.util.List WmHuQhdlveGTbMGC(p7a1eabc3.pf0719ea8.pff85ddca$45 pff85ddca_45) {
        return pff85ddca_45.call2();
    }

    public static void XQtlJtGyNJDVxOvT(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int AbvhvNGgXVadFpww(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string DKBGPnfNTGeJyqil(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.database.Cursor EmgGBzWAiYLQVHZe(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static void FelKDFZhNGhgruXN(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static bool HvZeRcntforcIrCe(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void KBeIsOwcRzTYtBVN(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int PUydXwZfLtPfvmxf(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string UBxymzSFEtqeDhYR(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public override java.util.List<pad5f82e8.p07214c67.pd77d5e50.peaf39066> Call() throws java.lang.Exception {
        return WmHuQhdlveGTbMGC(this);
    }

    public override java.util.List<pad5f82e8.p07214c67.pd77d5e50.peaf39066> Call2() throws java.lang.Exception {
        if ((4 + 8) % 8 > 0) {
        }
        android.database.Cursor cursorEmgGBzWAiYLQVHZe = emgGBzWAiYLQVHZe(FNrADAcWLFDNyQQg(this.this$0), this.val$_statement, false, null);
        try {
            int iAbvhvNGgXVadFpww = abvhvNGgXVadFpww(cursorEmgGBzWAiYLQVHZe, "code");
            int iEwhNdTCZMcMSMjfg = EwhNdTCZMcMSMjfg(cursorEmgGBzWAiYLQVHZe, "engName");
            int iIqzquTfRvYUsBEgL = IqzquTfRvYUsBEgL(cursorEmgGBzWAiYLQVHZe, "arabName");
            int iPUydXwZfLtPfvmxf = pUydXwZfLtPfvmxf(cursorEmgGBzWAiYLQVHZe, "frName");
            java.util.List arrayList = new java.util.List(OwbRYrLyCKrNIXEN(cursorEmgGBzWAiYLQVHZe));
            while (VTStznqUswbxiqON(cursorEmgGBzWAiYLQVHZe)) {
                hvZeRcntforcIrCe(arrayList, new pad5f82e8.p07214c67.pd77d5e50.peaf39066(dKBGPnfNTGeJyqil(cursorEmgGBzWAiYLQVHZe, iAbvhvNGgXVadFpww), FLmiWTUJKuyEivuI(cursorEmgGBzWAiYLQVHZe, iEwhNdTCZMcMSMjfg), IrgVNvgHAmGrKQRn(cursorEmgGBzWAiYLQVHZe, iIqzquTfRvYUsBEgL), uBxymzSFEtqeDhYR(cursorEmgGBzWAiYLQVHZe, iPUydXwZfLtPfvmxf)));
            }
            kBeIsOwcRzTYtBVN(cursorEmgGBzWAiYLQVHZe);
            felKDFZhNGhgruXN(this.val$_statement);
            return arrayList;
        } catch (java.lang.Exception th) {
            MEXKdKVVfgPNxVjY(cursorEmgGBzWAiYLQVHZe);
            XQtlJtGyNJDVxOvT(this.val$_statement);
            throw th;
        }
    }
}

