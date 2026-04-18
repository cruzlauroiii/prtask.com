namespace WillowMaze.Wasm.Decompiled;


class pea6979f9$4 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.pea6979f9 this$0;

    pea6979f9$4(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        this.this$0 = pea6979f9Var;
    }

    public static int BVRXfPRXzFIDfAPY(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void BmWyJrhUTNDUorlX(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement EJTOGRTEfWwzMuju(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.m337ceba5(pea6979f9Var);
    }

    public static kotlin.Unit GsVVcExrgWCqTHgA(pe0212e54.pf0719ea8.pea6979f9$4 pea6979f9_4) {
        return pea6979f9_4.call2();
    }

    public static androidx.room.RoomDatabase LlyygtkTsgkJyByO(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static void LtmOGXmAFgiaybJn(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase TrYRTRwGamSRampT(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static androidx.room.RoomDatabase BFbaGiMZquQOBSHg(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static androidx.room.SharedSQLiteStatement HbLFdOoXyulKFHkv(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.m337ceba5(pea6979f9Var);
    }

    public static void HhjlcUEptSvyPfNk(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement IfXYtKiwAvqCzotK(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.m337ceba5(pea6979f9Var);
    }

    public static void JNXjaqYgLjbgPSsC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void QWzcmJlMZypWsdDw(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase VanaACHjgEqutjCV(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static void WatqDcDOQEKhBhjK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement XeYiLxWCghyCaopW(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return GsVVcExrgWCqTHgA(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((26 + 1) % 1 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementXeYiLxWCghyCaopW = xeYiLxWCghyCaopW(hbLFdOoXyulKFHkv(this.this$0));
        try {
            LtmOGXmAFgiaybJn(vanaACHjgEqutjCV(this.this$0));
            try {
                BVRXfPRXzFIDfAPY(supportSQLiteStatementXeYiLxWCghyCaopW);
                jNXjaqYgLjbgPSsC(LlyygtkTsgkJyByO(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                BmWyJrhUTNDUorlX(bFbaGiMZquQOBSHg(this.this$0));
                qWzcmJlMZypWsdDw(ifXYtKiwAvqCzotK(this.this$0), supportSQLiteStatementXeYiLxWCghyCaopW);
                return unit;
            } catch (java.lang.Exception th) {
                watqDcDOQEKhBhjK(TrYRTRwGamSRampT(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            hhjlcUEptSvyPfNk(EJTOGRTEfWwzMuju(this.this$0), supportSQLiteStatementXeYiLxWCghyCaopW);
            throw th2;
        }
    }
}

