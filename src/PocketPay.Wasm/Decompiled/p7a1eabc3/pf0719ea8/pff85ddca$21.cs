namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$21 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.util.List val$commoditiesDbEntity;

    pff85ddca$21(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.util.List list) {
        this.this$0 = pff85ddcaVar;
        this.val$commoditiesDbEntity = list;
    }

    public static androidx.room.RoomDatabase BDAnmspQYsiiOjYT(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static androidx.room.EntityInsertionAdapter EALDbGjUGyvaeeHi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m429f062d(pff85ddcaVar);
    }

    public static void FiUoxRoNrEUBiUaw(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void ObQKKxOJSiWbOyKb(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.IEnumerable iterable) {
        entityInsertionAdapter.insert(iterable);
    }

    public static androidx.room.RoomDatabase OdvrziXibSeNOuSN(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static kotlin.Unit YjwgsSdsnPmdNQIY(p7a1eabc3.pf0719ea8.pff85ddca$21 pff85ddca_21) {
        return pff85ddca_21.call2();
    }

    public static void BOppRdEBXNcknUuu(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase HcNuHRJckSoAoFVo(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void MqNTpoptXInpUFzm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase PTisJtOPYtkgQiOC(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void PwJtDUEHRZBhneTm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return YjwgsSdsnPmdNQIY(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((2 + 11) % 11 > 0) {
        }
        FiUoxRoNrEUBiUaw(BDAnmspQYsiiOjYT(this.this$0));
        try {
            ObQKKxOJSiWbOyKb(EALDbGjUGyvaeeHi(this.this$0), this.val$commoditiesDbEntity);
            mqNTpoptXInpUFzm(OdvrziXibSeNOuSN(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            bOppRdEBXNcknUuu(hcNuHRJckSoAoFVo(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            pwJtDUEHRZBhneTm(pTisJtOPYtkgQiOC(this.this$0));
            throw th;
        }
    }
}

