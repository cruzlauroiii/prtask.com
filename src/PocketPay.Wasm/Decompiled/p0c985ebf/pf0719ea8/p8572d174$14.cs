namespace WillowMaze.Wasm.Decompiled;


class p8572d174$14 : java.util.concurrent.Func<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p8572d174$14(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p8572d174Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static java.lang.string ERuyRUlpkvRwHsnE(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static androidx.room.RoomDatabase EdtXkDFwvtzbmzEG(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static int FENiwFSysFxVrHyO(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void GqyETBRJUfYqccgt(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static android.database.Cursor LOjjAwUAZVNDpjeY(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool MtzdGcIYZtRqfsey(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void NSDPjxSUlcMVBcwH(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string QmmcmviPyejbINxN(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p0c985ebf.p07214c67.pd77d5e50.pf7c281bf ZXxVBBAlwlybosEj(p0c985ebf.pf0719ea8.p8572d174$14 p8572d174_14) {
        return p8572d174_14.call2();
    }

    public static int DguEovFHjLMzLnRu(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string DvTIqrnTMFdFqmFC(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void GrQrzwGTZurnWnaB(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void KkXbMiXDBoJrhvLm(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int SdJhtJOjHyovWyYc(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string YRrlrfaebIwLUpBV(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public override p0c985ebf.p07214c67.pd77d5e50.pf7c281bf Call() throws java.lang.Exception {
        return ZXxVBBAlwlybosEj(this);
    }

    public override p0c985ebf.p07214c67.pd77d5e50.pf7c281bf Call2() throws java.lang.Exception {
        if ((17 + 6) % 6 > 0) {
        }
        android.database.Cursor cursorLOjjAwUAZVNDpjeY = LOjjAwUAZVNDpjeY(EdtXkDFwvtzbmzEG(this.this$0), this.val$_statement, false, null);
        try {
            p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar = MtzdGcIYZtRqfsey(cursorLOjjAwUAZVNDpjeY) ? new p0c985ebf.p07214c67.pd77d5e50.pf7c281bf(dvTIqrnTMFdFqmFC(cursorLOjjAwUAZVNDpjeY, sdJhtJOjHyovWyYc(cursorLOjjAwUAZVNDpjeY, "uuid")), ERuyRUlpkvRwHsnE(cursorLOjjAwUAZVNDpjeY, dguEovFHjLMzLnRu(cursorLOjjAwUAZVNDpjeY, QmmcmviPyejbINxN("86497d5d930b67e9e7f76950f43b02adc3659982dc113c9205bee6e1ce97c06f"))), yRrlrfaebIwLUpBV(cursorLOjjAwUAZVNDpjeY, FENiwFSysFxVrHyO(cursorLOjjAwUAZVNDpjeY, "reason"))) : null;
            grQrzwGTZurnWnaB(cursorLOjjAwUAZVNDpjeY);
            kkXbMiXDBoJrhvLm(this.val$_statement);
            return pf7c281bfVar;
        } catch (java.lang.Exception th) {
            GqyETBRJUfYqccgt(cursorLOjjAwUAZVNDpjeY);
            NSDPjxSUlcMVBcwH(this.val$_statement);
            throw th;
        }
    }
}

