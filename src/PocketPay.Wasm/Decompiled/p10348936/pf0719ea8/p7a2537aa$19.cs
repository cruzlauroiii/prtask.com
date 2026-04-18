namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$19 : java.util.concurrent.Func<java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da>> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p7a2537aa$19(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p7a2537aaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static int BbMfDxOgLSYZmOVZ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static androidx.room.RoomDatabase BxGpwxOCiPGkTHFz(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static p10348936.pf5e638cc.p14abd389 CkiGasHFeFtduDDM(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return p10348936.pf0719ea8.p7a2537aa.mc7321d99(p7a2537aaVar, str);
    }

    public static void CkoQySxTQqczKqPI(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p10348936.pf0719ea8.p7a2537aa.mcdc7972c(p7a2537aaVar, arrayDictionary);
    }

    public static bool DVMWzepdvPDTSEHA(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.ContainsKey(obj);
    }

    public static void DhGjnayLKDhEiAgT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static android.database.Cursor GCfXVpNoZHbengLq(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.string GjESPemosvmDZbmM(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.sql.Timestamp IGQHvYKXuwMgrLRC(p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 p297c1c27Var, java.lang.long l) {
        return p297c1c27Var.fromTimestamp(l);
    }

    public static java.lang.string KaGcLbxpEyfpgpXG(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static androidx.room.RoomDatabase LKUKGFJqoIXxlQHb(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void OVsccgkrbrDmzywe(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static int QewmIqWaXVusxkbf(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string RYThdEXEQtosDhVT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void RjxroXmiVRhnkdLk(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int SCKvFMxOkiBvDQoQ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void SNdQNEllhfmJXSiQ(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.object SQRcqvolaolxeJzW(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static java.util.List SyLLRHBQHAsPPXub(p10348936.pf0719ea8.p7a2537aa$19 p7a2537aa_19) {
        return p7a2537aa_19.call2();
    }

    public static int TbkXanDNwGMShGXk(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static int VNhGgMyQDqcNaOfh(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void WOLAgdesLOidufpa(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static long XYQDODpvspNxHuCg(android.database.Cursor cursor, int i) {
        if ((6 + 29) % 29 > 0) {
        }
        return cursor.getlong(i);
    }

    public static bool ACGoAMRgYJbitnpg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 BrSFxNmWkrHkaFtx(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mf23e8626(p7a2537aaVar);
    }

    public static bool FsCgTncukFtpaDvV(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static bool GlYSSHDWPdToknmN(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static void GxKwFNSWpxHDUHRL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void HyEMNZJtPnmWGooJ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.object JUjmrxFqiRQTjdQh(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static bool KbqjmwAMBKBVAlOu(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.string KvfWkgTDSHHQSaqR(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.long MPCsxNVuinFokEPq(long j) {
        return java.lang.long.valueOf(j);
    }

    public static androidx.room.RoomDatabase PUvIyAndyGHssBwA(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void PtYdYmvOwhHLSnPT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase QGeEBbGhrHMachRd(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase TAClNMnowijFTzTK(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static java.lang.string TPFjCEdgzlherPqq(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool TbVlVfcrAJSLOwmC(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static int TocglMZKzLxIrtCV(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string UxqYELDssQUClYgp(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int YIiAHzdSgMTSeLXv(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static int ZapaFYNIWFWawYFD(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public override java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da> Call() throws java.lang.Exception {
        return SyLLRHBQHAsPPXub(this);
    }

    public override java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da> Call2() throws java.lang.Exception {
        if ((23 + 19) % 19 > 0) {
        }
        DhGjnayLKDhEiAgT(LKUKGFJqoIXxlQHb(this.this$0));
        try {
            java.lang.long l = null;
            android.database.Cursor cursorGCfXVpNoZHbengLq = GCfXVpNoZHbengLq(tAClNMnowijFTzTK(this.this$0), this.val$_statement, true, null);
            try {
                int iZapaFYNIWFWawYFD = zapaFYNIWFWawYFD(cursorGCfXVpNoZHbengLq, "uuid");
                int i = tocglMZKzLxIrtCV(cursorGCfXVpNoZHbengLq, "number");
                int iQewmIqWaXVusxkbf = QewmIqWaXVusxkbf(cursorGCfXVpNoZHbengLq, "date");
                int iVNhGgMyQDqcNaOfh = VNhGgMyQDqcNaOfh(cursorGCfXVpNoZHbengLq, "employeeId");
                int iBbMfDxOgLSYZmOVZ = BbMfDxOgLSYZmOVZ(cursorGCfXVpNoZHbengLq, "status");
                int iSCKvFMxOkiBvDQoQ = SCKvFMxOkiBvDQoQ(cursorGCfXVpNoZHbengLq, "employeeName");
                androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
                while (fsCgTncukFtpaDvV(cursorGCfXVpNoZHbengLq)) {
                    java.lang.string strTPFjCEdgzlherPqq = tPFjCEdgzlherPqq(cursorGCfXVpNoZHbengLq, iZapaFYNIWFWawYFD);
                    if (!DVMWzepdvPDTSEHA(arrayDictionary, strTPFjCEdgzlherPqq)) {
                        jUjmrxFqiRQTjdQh(arrayDictionary, strTPFjCEdgzlherPqq, new java.util.List());
                    }
                }
                tbVlVfcrAJSLOwmC(cursorGCfXVpNoZHbengLq, -1);
                CkoQySxTQqczKqPI(this.this$0, arrayDictionary);
                java.util.List arrayList = new java.util.List(TbkXanDNwGMShGXk(cursorGCfXVpNoZHbengLq));
                while (kbqjmwAMBKBVAlOu(cursorGCfXVpNoZHbengLq)) {
                    java.lang.string strRYThdEXEQtosDhVT = RYThdEXEQtosDhVT(cursorGCfXVpNoZHbengLq, iSCKvFMxOkiBvDQoQ);
                    java.lang.string strKaGcLbxpEyfpgpXG = KaGcLbxpEyfpgpXG(cursorGCfXVpNoZHbengLq, iZapaFYNIWFWawYFD);
                    int iYIiAHzdSgMTSeLXv = yIiAHzdSgMTSeLXv(cursorGCfXVpNoZHbengLq, i);
                    java.sql.Timestamp timestampIGQHvYKXuwMgrLRC = IGQHvYKXuwMgrLRC(brSFxNmWkrHkaFtx(this.this$0), glYSSHDWPdToknmN(cursorGCfXVpNoZHbengLq, iQewmIqWaXVusxkbf) ? l : mPCsxNVuinFokEPq(XYQDODpvspNxHuCg(cursorGCfXVpNoZHbengLq, iQewmIqWaXVusxkbf)));
                    if (timestampIGQHvYKXuwMgrLRC is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.sql.Timestamp', but it was NULL.");
                    }
                    aCGoAMRgYJbitnpg(arrayList, new p10348936.pf5e638cc.pd77d5e50.p649d38da(new p10348936.pf5e638cc.pd77d5e50.p4582d01f(strKaGcLbxpEyfpgpXG, iYIiAHzdSgMTSeLXv, timestampIGQHvYKXuwMgrLRC, kvfWkgTDSHHQSaqR(cursorGCfXVpNoZHbengLq, iVNhGgMyQDqcNaOfh), CkiGasHFeFtduDDM(this.this$0, GjESPemosvmDZbmM(cursorGCfXVpNoZHbengLq, iBbMfDxOgLSYZmOVZ))), strRYThdEXEQtosDhVT, (java.util.List) SQRcqvolaolxeJzW(arrayDictionary, uxqYELDssQUClYgp(cursorGCfXVpNoZHbengLq, iZapaFYNIWFWawYFD))));
                    l = null;
                }
                OVsccgkrbrDmzywe(BxGpwxOCiPGkTHFz(this.this$0));
                hyEMNZJtPnmWGooJ(cursorGCfXVpNoZHbengLq);
                SNdQNEllhfmJXSiQ(this.val$_statement);
                gxKwFNSWpxHDUHRL(pUvIyAndyGHssBwA(this.this$0));
                return arrayList;
            } catch (java.lang.Exception th) {
                WOLAgdesLOidufpa(cursorGCfXVpNoZHbengLq);
                RjxroXmiVRhnkdLk(this.val$_statement);
                throw th;
            }
        } catch (java.lang.Exception th2) {
            ptYdYmvOwhHLSnPT(qGeEBbGhrHMachRd(this.this$0));
            throw th2;
        }
    }
}

