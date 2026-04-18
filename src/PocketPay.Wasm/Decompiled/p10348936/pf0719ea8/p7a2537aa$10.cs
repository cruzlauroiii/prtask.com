namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$10 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly p10348936.pf5e638cc.pd77d5e50.p4582d01f val$inventorizationDbEntity;

    p7a2537aa$10(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        this.this$0 = p7a2537aaVar;
        this.val$inventorizationDbEntity = p4582d01fVar;
    }

    public static void CLPExOmqdWoHysGT(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void EOHyEJdXMgWbhMwH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void FONuffrKzHlEoAvv(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.EntityInsertionAdapter INOfoWBwvlZocMjj(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m89082e03(p7a2537aaVar);
    }

    public static kotlin.Unit RjHtCQDpBicpJNRV(p10348936.pf0719ea8.p7a2537aa$10 p7a2537aa_10) {
        return p7a2537aa_10.call2();
    }

    public static void TsmSllkdQYCWzlaI(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase PmgWPaEBPYsOVsOH(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase RRqomuoKQGqzIrsD(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase RmMJCAUugqXKlyTY(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase VHHkCneIWfmPZMDo(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void YonebSqcJKdymkbc(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return RjHtCQDpBicpJNRV(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((22 + 1) % 1 > 0) {
        }
        EOHyEJdXMgWbhMwH(pmgWPaEBPYsOVsOH(this.this$0));
        try {
            yonebSqcJKdymkbc(INOfoWBwvlZocMjj(this.this$0), this.val$inventorizationDbEntity);
            TsmSllkdQYCWzlaI(vHHkCneIWfmPZMDo(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            CLPExOmqdWoHysGT(rmMJCAUugqXKlyTY(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            FONuffrKzHlEoAvv(rRqomuoKQGqzIrsD(this.this$0));
            throw th;
        }
    }
}

