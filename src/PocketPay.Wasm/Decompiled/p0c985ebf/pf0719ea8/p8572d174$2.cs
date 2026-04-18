namespace WillowMaze.Wasm.Decompiled;


class p8572d174$2 : androidx.room.EntityInsertionAdapter<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> {
    readonly p0c985ebf.pf0719ea8.p8572d174 this$0;

    p8572d174$2(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p8572d174Var;
    }

    public static java.math.decimal AkOCZGymgIOPKBmt(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getInitialQuantity();
    }

    public static java.lang.double BYFeUTaHTjSDdQdS(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static java.math.decimal BrblJXQtPZHpOGMu(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getQuantity();
    }

    public static void BzUqDPbBrcoadOVe(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.math.decimal DlvxKbKaNuMntNBr(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getPriceWithDiscount();
    }

    public static void EYVHPZrTwNuBCyWk(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 FYVgZsNfkzBoPmsl(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getType();
    }

    public static void GKSxdsCqhZhmnqqD(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.lang.string GNTZHUquDlRXbXIB(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getTax();
    }

    public static void GdeerSoCKWKSQriS(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static void IREjtwpqqxCKBBDy(p0c985ebf.pf0719ea8.p8572d174$2 p8572d174_2, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        p8572d174_2.bind2(supportSQLiteStatement, p1aa865baVar);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 IhEvPoQBeBgqdkxD(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static java.lang.string JYdqBexmoAlZSIAM(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getCommodityId();
    }

    public static double LEJuLfADHPjWNxBC(java.lang.double d) {
        if ((13 + 28) % 28 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.string MvlcLKcuICNiNCsA(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getInspectionUuid();
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 ONxWcVMuuquSFXQG(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static java.lang.string PNRadnwcZjpazmeJ(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf8f67da7(p8572d174Var, pa1fa2777Var);
    }

    public static void PQkwcCIgwQeYAcLb(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.lang.string PmEdZmNLlhjAIiPQ(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getTax();
    }

    public static java.lang.double PmfsRUdArRgxMLXB(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static java.lang.double RIcruLsypMUhNFmr(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static java.lang.string SBuBxTGdnrIuBQmW(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getCommodityId();
    }

    public static double SkqhEMPjhGKDNyLU(java.lang.double d) {
        if ((21 + 23) % 23 > 0) {
        }
        return d.doubleValue();
    }

    public static void TnzhfUdViuYaxNPG(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.math.decimal VJouxpxKfmGbwRNM(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getPurchasePrice();
    }

    public static void VqoFkaWdNyTgFUqo(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 WveMiWALfUAQjFbI(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static void XEJkcSIQAMJTcjgA(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void XphtYglpYYOOLCRL(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void YroahmMrpMlvHtvQ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static void YspJaSFGnuOorElu(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static int CivIjnRiqkgyJZOm(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getPrecision();
    }

    public static double CublEyORgprsvpWy(java.lang.double d) {
        if ((24 + 15) % 15 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.string DJXkWvZeiBmbwmGV(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getUuid();
    }

    public static void DjUfqmGfTKPGYOvN(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static void EYpFvGokmZzojlou(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static double GoSYGSMKvKPJDLBl(java.lang.double d) {
        if ((2 + 20) % 20 > 0) {
        }
        return d.doubleValue();
    }

    public static void IGGtStMxKNWSgBXe(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static java.math.decimal JIUXNHpitsEMVIrV(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getPrice();
    }

    public static void JkydpURdCozRIMKM(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static java.lang.string KCAKtIzLTqwOCXis(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getMeasure();
    }

    public static java.lang.double LDKlihHpyIrAUytS(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static void MyShIsYRSoMAQrYP(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.math.decimal OnaRjDteyXnaKXOi(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getTareVolume();
    }

    public static void PGxmZJFAznoaovBb(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void PajerLQNxvOUAawi(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static java.lang.string QLkXqXNiEYmSHnAJ(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getName();
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 QTOntxhGNPzoWMAa(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static java.lang.double RSLJjMEmoyqHhjcb(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static void SiongoHkQNNhGBKk(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.double TCzQFdkgiAkuQjHX(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.math.decimal bigDecimal) {
        return p35667ee1Var.bigDecimalTodouble(bigDecimal);
    }

    public static double TMVhXTqHXhLTwlgI(java.lang.double d) {
        if ((5 + 13) % 13 > 0) {
        }
        return d.doubleValue();
    }

    public static void URBLOoIgtwKhXGoO(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 URDRHrVcgCpZVRDS(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 UmWSHutthaVYVwZI(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p0c985ebf.pf0719ea8.p8572d174.mf23e8626(p8572d174Var);
    }

    public static void UnlxKhUlaGrVibEc(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void VViYsfyTbjLErvHK(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string VWzWLouJPrbMjETV(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getReceiptUuid();
    }

    public static void WIqLXzRnUeXChBcp(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void WkQQWIDBTnrSmKDh(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, double d) {
        supportSQLiteStatement.binddouble(i, d);
    }

    public static double WocbguKEKWSiMnJu(java.lang.double d) {
        if ((4 + 30) % 30 > 0) {
        }
        return d.doubleValue();
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 XIEpYAlnRkRBWhVf(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        return p1aa865baVar.getType();
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        IREjtwpqqxCKBBDy(this, supportSQLiteStatement, p1aa865baVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar) {
        if ((16 + 30) % 30 > 0) {
        }
        unlxKhUlaGrVibEc(supportSQLiteStatement, 1, dJXkWvZeiBmbwmGV(p1aa865baVar));
        siongoHkQNNhGBKk(supportSQLiteStatement, 2, MvlcLKcuICNiNCsA(p1aa865baVar));
        pGxmZJFAznoaovBb(supportSQLiteStatement, 3, vWzWLouJPrbMjETV(p1aa865baVar));
        java.lang.double dLDKlihHpyIrAUytS = lDKlihHpyIrAUytS(qTOntxhGNPzoWMAa(this.this$0), jIUXNHpitsEMVIrV(p1aa865baVar));
        if (dLDKlihHpyIrAUytS is not null) {
            YroahmMrpMlvHtvQ(supportSQLiteStatement, 4, SkqhEMPjhGKDNyLU(dLDKlihHpyIrAUytS));
        } else {
            TnzhfUdViuYaxNPG(supportSQLiteStatement, 4);
        }
        java.lang.double dBYFeUTaHTjSDdQdS = BYFeUTaHTjSDdQdS(uRDRHrVcgCpZVRDS(this.this$0), VJouxpxKfmGbwRNM(p1aa865baVar));
        if (dBYFeUTaHTjSDdQdS is not null) {
            pajerLQNxvOUAawi(supportSQLiteStatement, 5, tMVhXTqHXhLTwlgI(dBYFeUTaHTjSDdQdS));
        } else {
            PQkwcCIgwQeYAcLb(supportSQLiteStatement, 5);
        }
        VqoFkaWdNyTgFUqo(supportSQLiteStatement, 6, qLkXqXNiEYmSHnAJ(p1aa865baVar));
        vViYsfyTbjLErvHK(supportSQLiteStatement, 7, kCAKtIzLTqwOCXis(p1aa865baVar));
        iGGtStMxKNWSgBXe(supportSQLiteStatement, 8, civIjnRiqkgyJZOm(p1aa865baVar));
        java.lang.double dTCzQFdkgiAkuQjHX = tCzQFdkgiAkuQjHX(ONxWcVMuuquSFXQG(this.this$0), BrblJXQtPZHpOGMu(p1aa865baVar));
        if (dTCzQFdkgiAkuQjHX is not null) {
            wkQQWIDBTnrSmKDh(supportSQLiteStatement, 9, cublEyORgprsvpWy(dTCzQFdkgiAkuQjHX));
        } else {
            XphtYglpYYOOLCRL(supportSQLiteStatement, 9);
        }
        java.lang.double dRSLJjMEmoyqHhjcb = rSLJjMEmoyqHhjcb(IhEvPoQBeBgqdkxD(this.this$0), AkOCZGymgIOPKBmt(p1aa865baVar));
        if (dRSLJjMEmoyqHhjcb is not null) {
            GdeerSoCKWKSQriS(supportSQLiteStatement, 10, wocbguKEKWSiMnJu(dRSLJjMEmoyqHhjcb));
        } else {
            YspJaSFGnuOorElu(supportSQLiteStatement, 10);
        }
        if (PmEdZmNLlhjAIiPQ(p1aa865baVar) is not null) {
            BzUqDPbBrcoadOVe(supportSQLiteStatement, 11, GNTZHUquDlRXbXIB(p1aa865baVar));
        } else {
            GKSxdsCqhZhmnqqD(supportSQLiteStatement, 11);
        }
        if (SBuBxTGdnrIuBQmW(p1aa865baVar) is not null) {
            wIqLXzRnUeXChBcp(supportSQLiteStatement, 12, JYdqBexmoAlZSIAM(p1aa865baVar));
        } else {
            EYVHPZrTwNuBCyWk(supportSQLiteStatement, 12);
        }
        if (FYVgZsNfkzBoPmsl(p1aa865baVar) is not null) {
            myShIsYRSoMAQrYP(supportSQLiteStatement, 13, PNRadnwcZjpazmeJ(this.this$0, xIEpYAlnRkRBWhVf(p1aa865baVar)));
        } else {
            uRBLOoIgtwKhXGoO(supportSQLiteStatement, 13);
        }
        java.lang.double dRIcruLsypMUhNFmr = RIcruLsypMUhNFmr(umWSHutthaVYVwZI(this.this$0), onaRjDteyXnaKXOi(p1aa865baVar));
        if (dRIcruLsypMUhNFmr is not null) {
            djUfqmGfTKPGYOvN(supportSQLiteStatement, 14, LEJuLfADHPjWNxBC(dRIcruLsypMUhNFmr));
        } else {
            XEJkcSIQAMJTcjgA(supportSQLiteStatement, 14);
        }
        java.lang.double dPmfsRUdArRgxMLXB = PmfsRUdArRgxMLXB(WveMiWALfUAQjFbI(this.this$0), DlvxKbKaNuMntNBr(p1aa865baVar));
        if (dPmfsRUdArRgxMLXB is not null) {
            eYpFvGokmZzojlou(supportSQLiteStatement, 15, goSYGSMKvKPJDLBl(dPmfsRUdArRgxMLXB));
        } else {
            jkydpURdCozRIMKM(supportSQLiteStatement, 15);
        }
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `current_inspection_position` (`uuid`,`inspectionUuid`,`receiptUuid`,`price`,`purchasePrice`,`name`,`measure`,`precision`,`quantity`,`initialQuantity`,`tax`,`commodityId`,`type`,`tareVolume`,`priceWithDiscount`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}

