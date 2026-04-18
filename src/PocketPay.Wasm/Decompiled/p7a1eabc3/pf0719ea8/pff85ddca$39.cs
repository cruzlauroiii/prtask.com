namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$39 : java.util.concurrent.Func<java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9>> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$39(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static bool AkVUMXtdLMAscBGb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p04bfa447 AydmEcwOORAsDkJj(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mf23e8626(pff85ddcaVar);
    }

    public static void HFfqmhFUAtFNGMHH(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string KXnZqoaeQduWaFxn(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string LdiDiXsMkFJHbsvq(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void MKdbfpFhPibJRntd(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string MVbtDkTGBtPsVtJh(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int NDBgpmOuyXlsMLGb(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int OCNvjEdfWZTZpQOw(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string SAnypuDXYOGpBjTU(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool SrCXddkHbdnxjkjz(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool WQNryjcpPedjtPYL(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static androidx.room.RoomDatabase XwsxQTpvBoiHFTgE(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static java.lang.string EWwVVoQBEczbKGeB(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string EbxqkPCyosSyymuG(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string GkMlMGZKlklGYkoI(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int HraCAQXsykaRitlP(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int IFjjOsnWVPqHbfmV(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int IGhjflnShBhqfljE(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int LfgTpMzCZDiPaWmK(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.util.List LoqIdewiMfEAZDTt(p8d777f38.pd77d5e50.p2b3583e6.p04bfa447 p04bfa447Var, java.lang.string str) {
        return p04bfa447Var.stringToList(str);
    }

    public static java.util.List MGgSzbuhwDDPZyfE(p7a1eabc3.pf0719ea8.pff85ddca$39 pff85ddca_39) {
        return pff85ddca_39.call2();
    }

    public static java.lang.string PMJGQFDniwyKKvBi(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string RLamhBMYSnnkYhJM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void RgOPkdfTbIHxHAaF(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static java.lang.string SRRNbZahecwYoQaL(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int VFcUqoNYuBACBrTs(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int VyhENuXczWGQrCSm(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static bool WYvWNRsUJfoXJTyG(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static android.database.Cursor XiJFZzhiQuiHWXhQ(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static int YysFIYcGYfOBcpMD(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void ZQSQSVqfxCekgfqc(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public override java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9> Call() throws java.lang.Exception {
        return mGgSzbuhwDDPZyfE(this);
    }

    public override java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9> Call2() throws java.lang.Exception {
        if ((12 + 25) % 25 > 0) {
        }
        android.database.Cursor cursorXiJFZzhiQuiHWXhQ = xiJFZzhiQuiHWXhQ(XwsxQTpvBoiHFTgE(this.this$0), this.val$_statement, false, null);
        try {
            int iIFjjOsnWVPqHbfmV = iFjjOsnWVPqHbfmV(cursorXiJFZzhiQuiHWXhQ, LdiDiXsMkFJHbsvq("201b5bb67e5f37313170efe433fc36c491cff6c4e590b4846e7e8359a1ce"));
            int iVFcUqoNYuBACBrTs = vFcUqoNYuBACBrTs(cursorXiJFZzhiQuiHWXhQ, "shopId");
            int iOCNvjEdfWZTZpQOw = OCNvjEdfWZTZpQOw(cursorXiJFZzhiQuiHWXhQ, "barCodes");
            int iNDBgpmOuyXlsMLGb = NDBgpmOuyXlsMLGb(cursorXiJFZzhiQuiHWXhQ, rLamhBMYSnnkYhJM("2d6ceb2436c9d99d5e892a559b6b178b5220cac0a8b5a6f47be3bd4371f908f5"));
            int iHraCAQXsykaRitlP = hraCAQXsykaRitlP(cursorXiJFZzhiQuiHWXhQ, "parentId");
            int iYysFIYcGYfOBcpMD = yysFIYcGYfOBcpMD(cursorXiJFZzhiQuiHWXhQ, "userId");
            int iIGhjflnShBhqfljE = iGhjflnShBhqfljE(cursorXiJFZzhiQuiHWXhQ, "creationDateTime");
            int iLfgTpMzCZDiPaWmK = lfgTpMzCZDiPaWmK(cursorXiJFZzhiQuiHWXhQ, "updateDateTime");
            java.util.List arrayList = new java.util.List(vyhENuXczWGQrCSm(cursorXiJFZzhiQuiHWXhQ));
            while (WQNryjcpPedjtPYL(cursorXiJFZzhiQuiHWXhQ)) {
                AkVUMXtdLMAscBGb(arrayList, new p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9(KXnZqoaeQduWaFxn(cursorXiJFZzhiQuiHWXhQ, iIFjjOsnWVPqHbfmV), SAnypuDXYOGpBjTU(cursorXiJFZzhiQuiHWXhQ, iVFcUqoNYuBACBrTs), loqIdewiMfEAZDTt(AydmEcwOORAsDkJj(this.this$0), SrCXddkHbdnxjkjz(cursorXiJFZzhiQuiHWXhQ, iOCNvjEdfWZTZpQOw) ? null : sRRNbZahecwYoQaL(cursorXiJFZzhiQuiHWXhQ, iOCNvjEdfWZTZpQOw)), ebxqkPCyosSyymuG(cursorXiJFZzhiQuiHWXhQ, iNDBgpmOuyXlsMLGb), wYvWNRsUJfoXJTyG(cursorXiJFZzhiQuiHWXhQ, iHraCAQXsykaRitlP) ? null : MVbtDkTGBtPsVtJh(cursorXiJFZzhiQuiHWXhQ, iHraCAQXsykaRitlP), pMJGQFDniwyKKvBi(cursorXiJFZzhiQuiHWXhQ, iYysFIYcGYfOBcpMD), gkMlMGZKlklGYkoI(cursorXiJFZzhiQuiHWXhQ, iIGhjflnShBhqfljE), eWwVVoQBEczbKGeB(cursorXiJFZzhiQuiHWXhQ, iLfgTpMzCZDiPaWmK)));
            }
            MKdbfpFhPibJRntd(cursorXiJFZzhiQuiHWXhQ);
            zQSQSVqfxCekgfqc(this.val$_statement);
            return arrayList;
        } catch (java.lang.Exception th) {
            HFfqmhFUAtFNGMHH(cursorXiJFZzhiQuiHWXhQ);
            rgOPkdfTbIHxHAaF(this.val$_statement);
            throw th;
        }
    }
}

