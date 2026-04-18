namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$22 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.util.List val$commodityGroupsDbEntity;

    pff85ddca$22(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list) {
        this.this$0 = pff85ddcaVar;
        this.val$commodityGroupsDbEntity = list;
    }

    public static androidx.room.RoomDatabase BRyRArYLJLTOYUbZ(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void CtprHbOiCbHIxspA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase EmfQJKHOdAOVpjKj(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase RncmQeQPLwZDCeBU(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void XdemFIEiZLppjlkm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void DEmEOcmgOyqzStUd(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.EntityInsertionAdapter INWjYlDOpQVeLpjw(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m13fe7af4(pff85ddcaVar);
    }

    public static kotlin.Unit NZpEhpAUxkTWzWOO(p7a1eabc3.pf0719ea8.pff85ddca$22 pff85ddca_22) {
        return pff85ddca_22.call2();
    }

    public static void OIoimXlwrtMtnvXO(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static androidx.room.RoomDatabase QGTnzVaFlVnIqSwB(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void SxuaObzWOtKVEmwK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return nZpEhpAUxkTWzWOO(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((30 + 14) % 14 > 0) {
        }
        dEmEOcmgOyqzStUd(qGTnzVaFlVnIqSwB(this.this$0));
        try {
            oIoimXlwrtMtnvXO(iNWjYlDOpQVeLpjw(this.this$0), this.val$commodityGroupsDbEntity);
            CtprHbOiCbHIxspA(RncmQeQPLwZDCeBU(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            sxuaObzWOtKVEmwK(BRyRArYLJLTOYUbZ(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            XdemFIEiZLppjlkm(EmfQJKHOdAOVpjKj(this.this$0));
            throw th;
        }
    }
}

