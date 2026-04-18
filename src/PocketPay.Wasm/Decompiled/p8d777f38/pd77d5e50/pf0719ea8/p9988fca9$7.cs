namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$7 : java.util.concurrent.Func<pad5f82e8.p07214c67.pd77d5e50.p985d1fa1> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p9988fca9$7(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p9988fca9Var;
        this.val$_statement = roomSQLiteQuery;
    }

    public static int ADOvBXEMsSRaSqVo(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static int DBRVbeVvAAoeBWjd(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static void EQiqMlLEyCEimSfy(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 JFtjFmCbxiSjanxs(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf23e8626(p9988fca9Var);
    }

    public static void MFgeKitlUmrKlviD(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int PIErvQQhHQDzvrWv(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static bool RcjSIigMFggIbFIw(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static void SFkXVBHCRnzVeHlO(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static android.database.Cursor ShwrNkrkuIZcFYUY(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static bool UMPINiAXYirOAHIq(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static double UhwYnqhGNZTCvSen(android.database.Cursor cursor, int i) {
        if ((17 + 30) % 30 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.math.decimal VyhBfoZhuYmfLocR(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static androidx.room.RoomDatabase WbOGmVLXvpFQVQST(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static int ASACfRuMPXzBVGKg(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static java.lang.string AgATsdyqAVBFByLx(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.double FAgNXqzCAgOFOAIO(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void GHgybCZSOjJOyZGK(androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        roomSQLiteQuery.release();
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 LVqLYgeKfmQGBosh(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$7 p9988fca9_7) {
        return p9988fca9_7.call2();
    }

    public static int POqEpneXVLLoBOyU(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string RDuSXBEtuwCeMvzA(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool TUEUzxVXxVehxffb(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static int UKsZZTMzlhnncHLB(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public static java.lang.string XWFQetzHrSlkaptC(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int ZJigdclKqqAzjShM(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursor, str);
    }

    public override pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 Call() throws java.lang.Exception {
        return lVqLYgeKfmQGBosh(this);
    }

    public override pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 Call2() throws java.lang.Exception {
        if ((4 + 15) % 15 > 0) {
        }
        pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var = null;
        java.lang.double dFAgNXqzCAgOFOAIO = null;
        android.database.Cursor cursorShwrNkrkuIZcFYUY = ShwrNkrkuIZcFYUY(WbOGmVLXvpFQVQST(this.this$0), this.val$_statement, false, null);
        try {
            int iDBRVbeVvAAoeBWjd = DBRVbeVvAAoeBWjd(cursorShwrNkrkuIZcFYUY, "deviceId");
            int iADOvBXEMsSRaSqVo = ADOvBXEMsSRaSqVo(cursorShwrNkrkuIZcFYUY, agATsdyqAVBFByLx("7ec0389f8dc99527f9bb24dd6f694b4cbd13128975dd3f8943712ae37a76527b"));
            int iZJigdclKqqAzjShM = zJigdclKqqAzjShM(cursorShwrNkrkuIZcFYUY, "price");
            int iUKsZZTMzlhnncHLB = uKsZZTMzlhnncHLB(cursorShwrNkrkuIZcFYUY, "boardingShown");
            int iPOqEpneXVLLoBOyU = pOqEpneXVLLoBOyU(cursorShwrNkrkuIZcFYUY, "isEnabled");
            if (tUEUzxVXxVehxffb(cursorShwrNkrkuIZcFYUY)) {
                java.lang.string strRDuSXBEtuwCeMvzA = rDuSXBEtuwCeMvzA(cursorShwrNkrkuIZcFYUY, iDBRVbeVvAAoeBWjd);
                java.lang.string strXWFQetzHrSlkaptC = RcjSIigMFggIbFIw(cursorShwrNkrkuIZcFYUY, iADOvBXEMsSRaSqVo) ? null : xWFQetzHrSlkaptC(cursorShwrNkrkuIZcFYUY, iADOvBXEMsSRaSqVo);
                if (!UMPINiAXYirOAHIq(cursorShwrNkrkuIZcFYUY, iZJigdclKqqAzjShM)) {
                    dFAgNXqzCAgOFOAIO = fAgNXqzCAgOFOAIO(UhwYnqhGNZTCvSen(cursorShwrNkrkuIZcFYUY, iZJigdclKqqAzjShM));
                }
                p985d1fa1Var = new pad5f82e8.p07214c67.pd77d5e50.p985d1fa1(strRDuSXBEtuwCeMvzA, strXWFQetzHrSlkaptC, VyhBfoZhuYmfLocR(JFtjFmCbxiSjanxs(this.this$0), dFAgNXqzCAgOFOAIO), aSACfRuMPXzBVGKg(cursorShwrNkrkuIZcFYUY, iUKsZZTMzlhnncHLB) != 0, PIErvQQhHQDzvrWv(cursorShwrNkrkuIZcFYUY, iPOqEpneXVLLoBOyU) != 0);
            }
            MFgeKitlUmrKlviD(cursorShwrNkrkuIZcFYUY);
            SFkXVBHCRnzVeHlO(this.val$_statement);
            return p985d1fa1Var;
        } catch (java.lang.Exception th) {
            EQiqMlLEyCEimSfy(cursorShwrNkrkuIZcFYUY);
            gHgybCZSOjJOyZGK(this.val$_statement);
            throw th;
        }
    }
}

