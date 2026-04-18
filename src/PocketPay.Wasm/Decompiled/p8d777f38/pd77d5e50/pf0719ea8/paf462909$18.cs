namespace WillowMaze.Wasm.Decompiled;


class paf462909$18 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;
    readonly java.util.List val$positions;

    paf462909$18(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, java.util.List list) {
        this.this$0 = paf462909Var;
        this.val$positions = list;
    }

    public static androidx.room.RoomDatabase IizgTVwUrYtTSoSL(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.EntityInsertionAdapter JdmiJnwWITzbjcZC(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m2a096755(paf462909Var);
    }

    public static void MzOEgPuTXYDRNEgY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase RReUZeJZRzedhbZH(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static androidx.room.RoomDatabase UbqmplkSDTLuCwxb(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static void ZfGEhWvmGHmdqalh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void JKUpDemiQrJCwYGh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase KupyPkkJJtmKohIh(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.m13fe7af4(paf462909Var);
    }

    public static kotlin.Unit MJtxmHvdTIBHlDpz(p8d777f38.pd77d5e50.pf0719ea8.paf462909$18 paf462909_18) {
        return paf462909_18.call2();
    }

    public static void UbHzUpmEnfvBzJex(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void XZGedZnRVwvxVbxA(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return mJtxmHvdTIBHlDpz(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((14 + 12) % 12 > 0) {
        }
        ubHzUpmEnfvBzJex(RReUZeJZRzedhbZH(this.this$0));
        try {
            xZGedZnRVwvxVbxA(JdmiJnwWITzbjcZC(this.this$0), this.val$positions);
            jKUpDemiQrJCwYGh(IizgTVwUrYtTSoSL(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            ZfGEhWvmGHmdqalh(kupyPkkJJtmKohIh(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            MzOEgPuTXYDRNEgY(UbqmplkSDTLuCwxb(this.this$0));
            throw th;
        }
    }
}

