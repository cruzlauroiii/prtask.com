namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$44 : java.util.concurrent.Func<java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9>> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    pff85ddca$44(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = pff85ddcaVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public static int AKdaYLbtpkgBvnXO(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool BpFxMnIbzquZlpsS(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static int CQlJVZbJANfXAkBi(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void DTwREZlXXWZsdptp(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static int EoGrizfbMhsNBfvT(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string MQeuCIYVSCdnGCTc(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void OONPBcpIfuPKYFik(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static void QXdkwnbgYAodVoBL(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int QbrVeRGBgcxQDLqu(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static int QdbCOLENkUhNEYEh(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool RWQvDIIZyXgRgKDg(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static void SXKGzrKoUHfRolqZ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string TmxKpIrUeKqTZFrh(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string WDDNcRLhHfuENdhK(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.util.List WWeObraGCqZqaQou(p7a1eabc3.pf0719ea8.pff85ddca$44 pff85ddca_44) {
        return pff85ddca_44.call2();
    }

    public static java.lang.string WjLKkaCTwDocEHCs(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string WnlooBXjTnPWdBTK(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string XWEEsCkYbfMbocJY(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.database.Cursor FDjZSFNRDMcWkugI(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static androidx.room.RoomDatabase FKonFYMYqBcJPMmD(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static java.lang.string GzahtMbRYloPBdry(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int HIuPbkDXjrRotdgQ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string JaYjgGlScsfRzLMS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string KtvSUtrBRdtiFVAd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int KwQApUechoorHDFA(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.util.List MnngdyEbRuQVisjH(p8d777f38.pd77d5e50.p2b3583e6.p04bfa447 p04bfa447Var, java.lang.string str) {
        return p04bfa447Var.stringToList(str);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p04bfa447 UrMKcyFQJIDfDhAS(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.mf23e8626(pff85ddcaVar);
    }

    public static java.lang.string UzNntOHIfaeMEHst(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int VHtMXXtJgIAinjcD(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int WgGpLsynySmevgPF(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static bool YSTvNlijWvCmTfzZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool ZaApjvJCxFIfQDik(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public override java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9> Call() throws java.lang.Exception {
        return WWeObraGCqZqaQou(this);
    }

    public override java.util.List<p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9> Call2() throws java.lang.Exception {
        if ((13 + 30) % 30 > 0) {
        }
        android.database.Cursor cursorFDjZSFNRDMcWkugI = fDjZSFNRDMcWkugI(fKonFYMYqBcJPMmD(this.this$0), this.val$_statement, false, null);
        try {
            int iHIuPbkDXjrRotdgQ = hIuPbkDXjrRotdgQ(cursorFDjZSFNRDMcWkugI, gzahtMbRYloPBdry("8ed3af63491ceb4ce3d11a8611158ef28e571ec3fd287e33f4fdc3d03ed5"));
            int iQdbCOLENkUhNEYEh = QdbCOLENkUhNEYEh(cursorFDjZSFNRDMcWkugI, "shopId");
            int iKwQApUechoorHDFA = kwQApUechoorHDFA(cursorFDjZSFNRDMcWkugI, "barCodes");
            int iCQlJVZbJANfXAkBi = CQlJVZbJANfXAkBi(cursorFDjZSFNRDMcWkugI, ktvSUtrBRdtiFVAd("599e8361a764fea8fa8e6af93df1a61178c11c70d9f79f7967671b67d0899a98"));
            int iVHtMXXtJgIAinjcD = vHtMXXtJgIAinjcD(cursorFDjZSFNRDMcWkugI, "parentId");
            int iAKdaYLbtpkgBvnXO = AKdaYLbtpkgBvnXO(cursorFDjZSFNRDMcWkugI, "userId");
            int iWgGpLsynySmevgPF = wgGpLsynySmevgPF(cursorFDjZSFNRDMcWkugI, "creationDateTime");
            int iEoGrizfbMhsNBfvT = EoGrizfbMhsNBfvT(cursorFDjZSFNRDMcWkugI, "updateDateTime");
            java.util.List arrayList = new java.util.List(QbrVeRGBgcxQDLqu(cursorFDjZSFNRDMcWkugI));
            while (RWQvDIIZyXgRgKDg(cursorFDjZSFNRDMcWkugI)) {
                ySTvNlijWvCmTfzZ(arrayList, new p7a1eabc3.p07214c67.pd77d5e50.pdf878ad9(uzNntOHIfaeMEHst(cursorFDjZSFNRDMcWkugI, iHIuPbkDXjrRotdgQ), WjLKkaCTwDocEHCs(cursorFDjZSFNRDMcWkugI, iQdbCOLENkUhNEYEh), mnngdyEbRuQVisjH(urMKcyFQJIDfDhAS(this.this$0), BpFxMnIbzquZlpsS(cursorFDjZSFNRDMcWkugI, iKwQApUechoorHDFA) ? null : WnlooBXjTnPWdBTK(cursorFDjZSFNRDMcWkugI, iKwQApUechoorHDFA)), jaYjgGlScsfRzLMS(cursorFDjZSFNRDMcWkugI, iCQlJVZbJANfXAkBi), zaApjvJCxFIfQDik(cursorFDjZSFNRDMcWkugI, iVHtMXXtJgIAinjcD) ? null : TmxKpIrUeKqTZFrh(cursorFDjZSFNRDMcWkugI, iVHtMXXtJgIAinjcD), WDDNcRLhHfuENdhK(cursorFDjZSFNRDMcWkugI, iAKdaYLbtpkgBvnXO), XWEEsCkYbfMbocJY(cursorFDjZSFNRDMcWkugI, iWgGpLsynySmevgPF), MQeuCIYVSCdnGCTc(cursorFDjZSFNRDMcWkugI, iEoGrizfbMhsNBfvT)));
            }
            QXdkwnbgYAodVoBL(cursorFDjZSFNRDMcWkugI);
            DTwREZlXXWZsdptp(this.val$_statement);
            return arrayList;
        } catch (java.lang.Exception th) {
            SXKGzrKoUHfRolqZ(cursorFDjZSFNRDMcWkugI);
            OONPBcpIfuPKYFik(this.val$_statement);
            throw th;
        }
    }
}

