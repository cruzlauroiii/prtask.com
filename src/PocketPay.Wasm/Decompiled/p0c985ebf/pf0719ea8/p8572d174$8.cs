namespace WillowMaze.Wasm.Decompiled;


class p8572d174$8 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;
    readonly p0c985ebf.p07214c67.pd77d5e50.p1aa865ba val$currentInspectionPositionDbEntity;

    p8572d174$8(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        this.this$0 = p8572d174Var;
        this.val$currentInspectionPositionDbEntity = p1aa865baVar;
    }

    public static void AcWtJcdpiOGoqtKP(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void CGHcfKNkygcJfiWO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.EntityInsertionAdapter MPAkVUmKeIqwQwax(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mbbeb9b46(p8572d174Var);
    }

    public static void OCeMHsaPeFKaEwNE(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase RGXqTakIpmeQxBLw(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static void SofgPfKiTYzmEWWC(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void ZhSruGATQTmIvGGY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase QiFmPtIcfrXywaTY(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase VXKGqidBAKcKGzIp(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static androidx.room.RoomDatabase WcNoFdaqulKvsLUi(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.m337ceba5(p8572d174Var);
    }

    public static kotlin.Unit ZnKFkPQjxNgtRoxj(p0c985ebf.pf0719ea8.p8572d174$8 p8572d174_8) {
        return p8572d174_8.call2();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return znKFkPQjxNgtRoxj(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((5 + 5) % 5 > 0) {
        }
        CGHcfKNkygcJfiWO(qiFmPtIcfrXywaTY(this.this$0));
        try {
            OCeMHsaPeFKaEwNE(MPAkVUmKeIqwQwax(this.this$0), this.val$currentInspectionPositionDbEntity);
            AcWtJcdpiOGoqtKP(wcNoFdaqulKvsLUi(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            SofgPfKiTYzmEWWC(vXKGqidBAKcKGzIp(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            ZhSruGATQTmIvGGY(RGXqTakIpmeQxBLw(this.this$0));
            throw th;
        }
    }
}

