namespace WillowMaze.Wasm.Decompiled;


class pea6979f9$3 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.pea6979f9 this$0;
    readonly java.util.List val$shops;

    pea6979f9$3(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var, java.util.List list) {
        this.this$0 = pea6979f9Var;
        this.val$shops = list;
    }

    public static androidx.room.RoomDatabase CfvGfqJfNlaqaipE(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static void FPLyjzrvuBSStiuY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void IKjEHyJbHctdFtPr(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void InYsxcClFhVOTKvE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase OGcIJXdkHjShCbZn(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static androidx.room.EntityInsertionAdapter RRCgWhFbXTLlJPXT(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf8f67da7(pea6979f9Var);
    }

    public static void IoJEgLTmiLAqTWXU(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static kotlin.Unit LFYvQRJbvWioZVaG(pe0212e54.pf0719ea8.pea6979f9$3 pea6979f9_3) {
        return pea6979f9_3.call2();
    }

    public static void WYSbQwQEXkmFLKLl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase YjGyfwQvrgNofeKT(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public static androidx.room.RoomDatabase YyNPmAPhFZfVnrQH(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pe0212e54.pf0719ea8.pea6979f9.mf23e8626(pea6979f9Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return lFYvQRJbvWioZVaG(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((3 + 24) % 24 > 0) {
        }
        InYsxcClFhVOTKvE(yyNPmAPhFZfVnrQH(this.this$0));
        try {
            ioJEgLTmiLAqTWXU(RRCgWhFbXTLlJPXT(this.this$0), this.val$shops);
            IKjEHyJbHctdFtPr(CfvGfqJfNlaqaipE(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            FPLyjzrvuBSStiuY(OGcIJXdkHjShCbZn(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            wYSbQwQEXkmFLKLl(yjGyfwQvrgNofeKT(this.this$0));
            throw th;
        }
    }
}

