namespace WillowMaze.Wasm.Decompiled;


class pea6979f9$5 : java.util.concurrent.Func<java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a>> {
    readonly pe0212e54.pf0719ea8.pea6979f9 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pea6979f9$5(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pea6979f9Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static bool BzBCVJAXGGsFUpJr(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static void DPWLalVYvccbQqio(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int EolnobvnqdxGIxHd(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int IqZFeUhfKqQzJNRC(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static java.lang.string JukNAXlByEZXWeXv(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int MAidhRKbatnHRolC(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool MqLApgNqdXrafCjs(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static androidx.room.RoomDatabase OykyplFjJPqPaFFn(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static int PHqPVJGxbdTrUinL(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void ZZyKMEofHjwHOKuj(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void ACauxpxllIuQRNVZ(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.util.List BzTUUdmPMaYXqDmf(pe0212e54.pf0719ea8.pea6979f9$5 pea6979f9_5) {
        return pea6979f9_5.call2();
    }

    public static java.lang.string CeqnLlqCjTmiNWIM(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool CtGkHfbozEHKxLlf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool DEgJeGuEpNAZfJPX(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static android.database.Cursor FoMWLZUHJdoaWacg(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.string JSZBmrhhmcMUHVsk(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void NzpUtdoSbxrUMJFl(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string UPzTIoUxPURakpbS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string YkHSpwsmWDTslcGd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public override java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> Call() throws java.lang.Exception {
        return bzTUUdmPMaYXqDmf(this);
    }

    public override java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> Call2() throws java.lang.Exception {
        if ((1 + 18) % 18 > 0) {
        }
        android.database.Cursor cursorFoMWLZUHJdoaWacg = foMWLZUHJdoaWacg(OykyplFjJPqPaFFn(this.this$0), this.val$_statement, false, null);
        try {
            int iPHqPVJGxbdTrUinL = PHqPVJGxbdTrUinL(cursorFoMWLZUHJdoaWacg, ykHSpwsmWDTslcGd("3395ce796b793506ae20a09b26119b20f123516051f7ddf868d3f42e616e"));
            int iEolnobvnqdxGIxHd = EolnobvnqdxGIxHd(cursorFoMWLZUHJdoaWacg, jSZBmrhhmcMUHVsk("334ddfe210bc6761f2af8e85d2248357242d1b033ae68aa62673153166abc366"));
            int iMAidhRKbatnHRolC = MAidhRKbatnHRolC(cursorFoMWLZUHJdoaWacg, "address");
            java.util.List arrayList = new java.util.List(IqZFeUhfKqQzJNRC(cursorFoMWLZUHJdoaWacg));
            while (MqLApgNqdXrafCjs(cursorFoMWLZUHJdoaWacg)) {
                ctGkHfbozEHKxLlf(arrayList, new pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a(uPzTIoUxPURakpbS(cursorFoMWLZUHJdoaWacg, iPHqPVJGxbdTrUinL), dEgJeGuEpNAZfJPX(cursorFoMWLZUHJdoaWacg, iEolnobvnqdxGIxHd) ? null : ceqnLlqCjTmiNWIM(cursorFoMWLZUHJdoaWacg, iEolnobvnqdxGIxHd), BzBCVJAXGGsFUpJr(cursorFoMWLZUHJdoaWacg, iMAidhRKbatnHRolC) ? null : JukNAXlByEZXWeXv(cursorFoMWLZUHJdoaWacg, iMAidhRKbatnHRolC)));
            }
            ZZyKMEofHjwHOKuj(cursorFoMWLZUHJdoaWacg);
            aCauxpxllIuQRNVZ(this.val$_statement);
            return arrayList;
        } catch (java.lang.Exception th) {
            DPWLalVYvccbQqio(cursorFoMWLZUHJdoaWacg);
            nzpUtdoSbxrUMJFl(this.val$_statement);
            throw th;
        }
    }
}

