namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$15 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;
    readonly java.lang.string val$deviceId;

    p9442da0d$15(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        this.this$0 = p9442da0dVar;
        this.val$deviceId = str;
    }

    public static void BSDRXEdcutylyrKX(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static androidx.room.SharedSQLiteStatement ITFzAwAEJTkluGuD(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mebdbf394(p9442da0dVar);
    }

    public static void NjzbipwQdTnQjNYZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void PaWZhUbaANynGByW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase SYcBtXgvPdfzVZxJ(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement ScruBhLWElxyePWj(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mebdbf394(p9442da0dVar);
    }

    public static void WaJYPizURKBygQBO(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement YDzOpkwrxWHkOieH(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase ZATSoDseUYvniqqv(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static int CLlJMjjjOjbKPatx(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void CXlzPTMjCavcxndk(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase GlKKFpuTPlhTyCzY(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void MLmOKVnbRnYdKgOq(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void MmLbYHhWyUGbaRen(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase OHkcMnkGghsByigQ(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.SharedSQLiteStatement YlelhJewNzhgpYAI(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mebdbf394(p9442da0dVar);
    }

    public static kotlin.Unit ZLApYITosSzBpXaO(pe0212e54.pf0719ea8.p9442da0d$15 p9442da0d_15) {
        return p9442da0d_15.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return zLApYITosSzBpXaO(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((28 + 9) % 9 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementYDzOpkwrxWHkOieH = YDzOpkwrxWHkOieH(ITFzAwAEJTkluGuD(this.this$0));
        BSDRXEdcutylyrKX(supportSQLiteStatementYDzOpkwrxWHkOieH, 1, this.val$deviceId);
        try {
            mmLbYHhWyUGbaRen(oHkcMnkGghsByigQ(this.this$0));
            try {
                cLlJMjjjOjbKPatx(supportSQLiteStatementYDzOpkwrxWHkOieH);
                NjzbipwQdTnQjNYZ(SYcBtXgvPdfzVZxJ(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                mLmOKVnbRnYdKgOq(glKKFpuTPlhTyCzY(this.this$0));
                WaJYPizURKBygQBO(ScruBhLWElxyePWj(this.this$0), supportSQLiteStatementYDzOpkwrxWHkOieH);
                return unit;
            } catch (java.lang.Exception th) {
                PaWZhUbaANynGByW(ZATSoDseUYvniqqv(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            cXlzPTMjCavcxndk(ylelhJewNzhgpYAI(this.this$0), supportSQLiteStatementYDzOpkwrxWHkOieH);
            throw th2;
        }
    }
}

