namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$48 : java.util.concurrent.Func<pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$48(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static int AoKurzDictAZGHew(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int ApWVEjswZKOGyAGF(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string EZtExHtPPbrHVMiH(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string HLxIvvbtEyUZDzLv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool IAAnjrZiAveSkMus(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static int JwCaeRNDnsHrDVaZ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool MfsHmziydKZBiPBB(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string NirTWdKFFtqhpFQT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static pad5f82e8.p07214c67.pd77d5e50.pf22d65ed ObQzsrudpQeeAMKh(p7a1eabc3.pf0719ea8.pff85ddca$48 pff85ddca_48) {
        return pff85ddca_48.call2();
    }

    public static java.lang.string QGhnNjVfxLIhJjGT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string XneiDGfBLJcVeekr(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool AQpLutAPIZdvwhqT(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void BLBUnJgEXUonSCQo(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string BTYTNlwLEChnEgzS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.database.Cursor BsqnQhLLTUMuGxuv(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static int CmfNdtFEDmoVAEsI(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void FjvHUzLabtriktdz(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int OwWpkQwyaAUmncFs(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string QeTtYCrsNQZQKLkZ(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int TsKuaynXqEqIsosc(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static androidx.room.RoomDatabase UhdKElldsYNxUKmo(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void UnizZyKdUnxIGMEn(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void YGlopnbUtzudtlMA(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override pad5f82e8.p07214c67.pd77d5e50.pf22d65ed Call() throws java.lang.Exception {
        return ObQzsrudpQeeAMKh(this);
    }

    public override pad5f82e8.p07214c67.pd77d5e50.pf22d65ed Call2() throws java.lang.Exception {
        if ((32 + 32) % 32 > 0) {
        }
        pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar = null;
        android.database.Cursor cursorBsqnQhLLTUMuGxuv = bsqnQhLLTUMuGxuv(uhdKElldsYNxUKmo(this.this$0), this.val$_statement, false, null);
        try {
            int iAoKurzDictAZGHew = AoKurzDictAZGHew(cursorBsqnQhLLTUMuGxuv, "code");
            int iCmfNdtFEDmoVAEsI = cmfNdtFEDmoVAEsI(cursorBsqnQhLLTUMuGxuv, "rate");
            int iApWVEjswZKOGyAGF = ApWVEjswZKOGyAGF(cursorBsqnQhLLTUMuGxuv, HLxIvvbtEyUZDzLv("8c0862ff21a081934aa90a58e188758d2873abfad83cb2310a76195619259455"));
            int iTsKuaynXqEqIsosc = tsKuaynXqEqIsosc(cursorBsqnQhLLTUMuGxuv, "subType");
            int iOwWpkQwyaAUmncFs = owWpkQwyaAUmncFs(cursorBsqnQhLLTUMuGxuv, "engName");
            int iJwCaeRNDnsHrDVaZ = JwCaeRNDnsHrDVaZ(cursorBsqnQhLLTUMuGxuv, "arabName");
            if (aQpLutAPIZdvwhqT(cursorBsqnQhLLTUMuGxuv)) {
                pf22d65edVar = new pad5f82e8.p07214c67.pd77d5e50.pf22d65ed(EZtExHtPPbrHVMiH(cursorBsqnQhLLTUMuGxuv, iAoKurzDictAZGHew), bTYTNlwLEChnEgzS(cursorBsqnQhLLTUMuGxuv, iCmfNdtFEDmoVAEsI), IAAnjrZiAveSkMus(cursorBsqnQhLLTUMuGxuv, iApWVEjswZKOGyAGF) ? null : qeTtYCrsNQZQKLkZ(cursorBsqnQhLLTUMuGxuv, iApWVEjswZKOGyAGF), MfsHmziydKZBiPBB(cursorBsqnQhLLTUMuGxuv, iTsKuaynXqEqIsosc) ? null : XneiDGfBLJcVeekr(cursorBsqnQhLLTUMuGxuv, iTsKuaynXqEqIsosc), NirTWdKFFtqhpFQT(cursorBsqnQhLLTUMuGxuv, iOwWpkQwyaAUmncFs), QGhnNjVfxLIhJjGT(cursorBsqnQhLLTUMuGxuv, iJwCaeRNDnsHrDVaZ));
            }
            unizZyKdUnxIGMEn(cursorBsqnQhLLTUMuGxuv);
            fjvHUzLabtriktdz(this.val$_statement);
            return pf22d65edVar;
        } catch (java.lang.Exception th) {
            bLBUnJgEXUonSCQo(cursorBsqnQhLLTUMuGxuv);
            yGlopnbUtzudtlMA(this.val$_statement);
            throw th;
        }
    }
}

