namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$13 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly p10348936.pf5e638cc.pd77d5e50.p0ed7807b val$inventorizationPositionDbEntity;

    p7a2537aa$13(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar) {
        this.this$0 = p7a2537aaVar;
        this.val$inventorizationPositionDbEntity = p0ed7807bVar;
    }

    public static kotlin.Unit KmUBOYCzuUbmejzT(p10348936.pf0719ea8.p7a2537aa$13 p7a2537aa_13) {
        return p7a2537aa_13.call2();
    }

    public static void MAPPSIxfvyAGMRAO(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static void NDMCXpmleBRgBzBh(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase XNgNrBRvyJBtDDWW(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.EntityInsertionAdapter XdJrfBxIuXtIyYyB(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m0dc0a6ea(p7a2537aaVar);
    }

    public static void AoqygbTaloEWfwfW(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void EISOsXkojCzxHahl(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase PuslpBnrpFCXOMOV(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase VynCNjOpIVhOQJWD(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase WcSlJbdIsXxoEXYi(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void ZGNGYCfSHoRWtnWU(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return KmUBOYCzuUbmejzT(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((5 + 26) % 26 > 0) {
        }
        zGNGYCfSHoRWtnWU(wcSlJbdIsXxoEXYi(this.this$0));
        try {
            MAPPSIxfvyAGMRAO(XdJrfBxIuXtIyYyB(this.this$0), this.val$inventorizationPositionDbEntity);
            eISOsXkojCzxHahl(vynCNjOpIVhOQJWD(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            NDMCXpmleBRgBzBh(puslpBnrpFCXOMOV(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            aoqygbTaloEWfwfW(XNgNrBRvyJBtDDWW(this.this$0));
            throw th;
        }
    }
}

