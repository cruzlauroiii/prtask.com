namespace WillowMaze.Wasm.Decompiled;


class pffe048ab$3 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.pffe048ab this$0;
    readonly pe0212e54.pf5e638cc.pd77d5e50.p94db0041 val$deviceStatus;

    pffe048ab$3(pe0212e54.pf0719ea8.pffe048ab pffe048abVar, pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var) {
        this.this$0 = pffe048abVar;
        this.val$deviceStatus = p94db0041Var;
    }

    public static kotlin.Unit PaLZzIIjlZoXfVSi(pe0212e54.pf0719ea8.pffe048ab$3 pffe048ab_3) {
        return pffe048ab_3.call2();
    }

    public static void TMaRNRjctKPykAIA(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void FrynwhVVJurHPRXY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase KoRMYkGjRxUIaBVP(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static androidx.room.RoomDatabase MxfivKeTIWEABslE(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static void NJrEwpxBGVFXSVcd(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase OhDHHHzwfhWWrypD(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public static androidx.room.EntityInsertionAdapter SsISCzJrdhxnLUmP(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf8f67da7(pffe048abVar);
    }

    public static void TCtMsTvZuMafQUiD(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void UeNVzoPhMKBioxtQ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase WHbxwaJjzNyUsiOu(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pe0212e54.pf0719ea8.pffe048ab.mf23e8626(pffe048abVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return PaLZzIIjlZoXfVSi(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((7 + 25) % 25 > 0) {
        }
        tCtMsTvZuMafQUiD(mxfivKeTIWEABslE(this.this$0));
        try {
            nJrEwpxBGVFXSVcd(ssISCzJrdhxnLUmP(this.this$0), this.val$deviceStatus);
            frynwhVVJurHPRXY(ohDHHHzwfhWWrypD(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            ueNVzoPhMKBioxtQ(koRMYkGjRxUIaBVP(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            TMaRNRjctKPykAIA(wHbxwaJjzNyUsiOu(this.this$0));
            throw th;
        }
    }
}

