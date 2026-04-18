namespace WillowMaze.Wasm.Decompiled;


readonly class FieldParser {
    private static readonly java.util.Dictionary<java.lang.string, com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength> FOUR_DIGIT_DATA_LENGTH;
    private static readonly java.util.Dictionary<java.lang.string, com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength> THREE_DIGIT_DATA_LENGTH;
    private static readonly java.util.Dictionary<java.lang.string, com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength> THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH;
    private static readonly java.util.Dictionary<java.lang.string, com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength> TWO_DIGIT_DATA_LENGTH;

    static {
        if ((30 + 25) % 25 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        TWO_DIGIT_DATA_LENGTH = map;
        CZknxfUMPUyCftbi(map, "00", DghqGJRLDjOxdpJU(18));
        PbDlDDcxDbMCokVh(map, "01", MiqkZACBUHIOVZPr(14));
        RksaqoRSMAgepHvD(map, "02", jLvXMPzEyTZCJGIF(14));
        EbWiUmIUyEfvopqr(map, "10", tNoGYIXfBpbVOfMt(20));
        mjrlbQgWRgPfrNyi(map, "11", WFLnvvBDnFvMiLXK(6));
        uqXiIleaZXCKNrmt(map, "12", rgJSUyZmpEtmezlK(6));
        bjynzXAYutbDTRKn(map, "13", CZYvPuZvjRDIstKw(6));
        PlQBOZYbSUnPUUpO(map, "15", BHkEnYkKfglRFSgL(6));
        uNfEtVYTOmpkHSmB(map, "17", KcKAYbIPIBrGfaUT(6));
        acBTfVdEiFDsLVvO(map, "20", VMRUgVBIiqOwwqHV(2));
        omsDAOfDVIjZqEdi(map, "21", yYyVFTsGoBDcxftT(20));
        GbQfSNfbxRSoVeFq(map, "22", UEEGjkOuqaYxxUVW(29));
        GVWOtgQazQGquDdV(map, "30", lDIFMjUhBYxzVnYG(8));
        DYOEuGrtzPmuDYqb(map, "37", QxwPJQXRqUYWNlWK(8));
        for (int i = 90; i <= 99; i++) {
            DgsWtMADjAZkZMoa(TWO_DIGIT_DATA_LENGTH, ImsXFjgdasrmcAjc(i), EhamxmBdHlCSLUmJ(30));
        }
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        THREE_DIGIT_DATA_LENGTH = map2;
        aMMepjfBnVlSgYFP(map2, "240", iVyHVGdAdbKYUazW(30));
        DUYLVWIDQfvbLHVn(map2, "241", LIvbmtXkIFWWYpva(30));
        bNueRCVRgvnolLZw(map2, "242", AmRaHkpbarcSlClY(6));
        itzJVSSulWgihNKa(map2, "250", xCJHOnJRNNdCnKUm(30));
        chABSDNJoIMyMgUZ(map2, "251", rvidUzkCqezcvgOl(30));
        gHZVtgjqlovUGAar(map2, "253", NmDmFNrBbnMLXhNV(17));
        BlMfBlARXaRNbKPp(map2, "254", hfoddMMUnyXRchjt(20));
        QbeABRTnmtbuOmTJ(map2, "400", BlpJMgkKOHtmLKJU(30));
        crPgpYSFHNjTyxJX(map2, "401", gSMVIqOOHwbGPCsE(30));
        sLApTftcAzPtXtQS(map2, "402", cxPetGiXZJwtJHam(17));
        sdkvTieSQsIYofHU(map2, "403", oEggIqjvBbOcdCIO(30));
        EPcdaWQCqbxNhiTy(map2, "410", VEwtPBtBNhaWzmyS(13));
        eQnjMUBwnAkmYcJN(map2, "411", oSlqpOaGkpXxyGSP(13));
        qhJoXZMeEidpjptV(map2, "412", EpsqdXIqXQznPtAD(13));
        mazvqOPNkIFpYPVN(map2, "413", ZIKqRHUxDSjBbUQn(13));
        uepmlZRcfZUVdGjI(map2, "414", DNnvhDhjjKILHpEo(13));
        xxaXRTanJaHSdyjs(map2, "420", zGkhKqEGZteUvjDa(20));
        dDadTfCVnYZrZtSn(map2, "421", FWtUccSjpfgGvriX(15));
        sCRUKSinUlIppYgS(map2, "422", ffLrSkIFMAzKBDWX(3));
        jvYZLRkmnurDzRVa(map2, "423", CJDOEciNQflLHLlg(15));
        JCgcIIRYUcpwhLWt(map2, "424", KAnotFwqvAtJpLbB(3));
        BUlUngYVhupTQtwH(map2, "425", SzNUTWgNsohRYJuJ(3));
        IjOhdVedSIbExcMa(map2, "426", rUjZyNWgrWMZDhfI(3));
        THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH = new java.util.HashDictionary();
        for (int i2 = 310; i2 <= 316; i2++) {
            qHGkRmhoZRXubsRb(THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, YTyLZCiCGMIIeAIp(i2), qGQiwHlUaCYElmDJ(6));
        }
        for (int i3 = 320; i3 <= 336; i3++) {
            OtMsqhQHXbGSrgYr(THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, WCrMqAuDhpIhpZSt(i3), hWUaXtjXKmdtOMgk(6));
        }
        for (int i4 = 340; i4 <= 357; i4++) {
            jQhTfwGzZZedyudR(THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, pBFNaQfOtKRYEdCg(i4), HPLNnHMcsuztyVgG(6));
        }
        for (int i5 = 360; i5 <= 369; i5++) {
            crSTlikNFGJajJCs(THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, OQVmyUuhdwliITGs(i5), PsBMQhZleqDbcCAs(6));
        }
        java.util.Dictionary<java.lang.string, com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength> map3 = THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH;
        hFyBBIMqHMcDIlOW(map3, "390", LOIIcVWYgSLaLSPc(15));
        zDFWQVcnWxVWGuBi(map3, "391", ZqFUfCFtGUXBQNuZ(18));
        BioLeMrMtTsfJCxL(map3, "392", vBKraLCcZvrWOmLv(15));
        LNXkgBWqaeXLPJab(map3, "393", PzLdfchsDbnbazBx(18));
        WVVJZxaYVKRvwuaQ(map3, "703", mMeTIRaguOdmnxVU(30));
        java.util.HashDictionary map4 = new java.util.HashDictionary();
        FOUR_DIGIT_DATA_LENGTH = map4;
        BbvwxoqQXCVSDEyz(map4, "7001", KUnnXFshZvYiLPPL(13));
        FUJwpZhCzNgePzbX(map4, "7002", mWzMBMFeYrQqvFLZ(30));
        iCKmcTOyPOgmIrPB(map4, "7003", QzfNgRtYZnozffvb(10));
        wNMiBXlvmhuFuQtq(map4, "8001", jAkvcnATxqLBbaNO(14));
        vbfeMWSEVpPiFLCY(map4, "8002", CTESMfSgRPzTpRVf(20));
        ajVilejodCMmIlzz(map4, "8003", bfOIduaYTPADVgFJ(30));
        rwbIoasTpzUjQqKs(map4, "8004", oJLWKUMTOMRYdkDa(30));
        xaOALvutqfoZTENO(map4, "8005", JcHTtlZeXVKFCDHv(6));
        VswCzTIcRZvhzWPh(map4, "8006", niQkZMfTkhGbQhnv(18));
        QmpFIeHoOOYOaxef(map4, "8007", iItoIhxejZiwYiPS(30));
        yWQCDvaMQyGVraFQ(map4, "8008", MduFzXeCDFnXGtPe(12));
        wauopWlibdtOPJJK(map4, "8018", BKZoLrhAQDBmfgUC(18));
        dDOVXGnbmYwXafaK(map4, "8020", XXrhJrYiMfHPagRF(25));
        GabFxPxOizDcvEyQ(map4, "8100", dRbxjfMtXLbUxhUD(6));
        DIBTSSAiKFUOflbo(map4, "8101", CaKAgMNyNFzjzRKC(10));
        mYETLqZtSOmvidQd(map4, "8102", QdUgXLoILOGyggrF(2));
        lDGqYSXiwCiVdHiU(map4, "8110", XRbodjtjFIzwMWut(70));
        JuhzYxhLaCFxCMkr(map4, "8200", kOIPRVPGrbQUFUTZ(70));
    }

    private FieldParser() {
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength AmRaHkpbarcSlClY(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static int AuHmESUIvHrCQPXM(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength BHkEnYkKfglRFSgL(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength BKZoLrhAQDBmfgUC(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object BUlUngYVhupTQtwH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BbvwxoqQXCVSDEyz(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BioLeMrMtTsfJCxL(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BlMfBlARXaRNbKPp(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength BlpJMgkKOHtmLKJU(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength CJDOEciNQflLHLlg(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.stringBuilder COaFQcVDcfGipIIp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength CTESMfSgRPzTpRVf(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength CZYvPuZvjRDIstKw(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object CZknxfUMPUyCftbi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength CaKAgMNyNFzjzRKC(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.stringBuilder CbKUaRihQmRoMGPo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object DIBTSSAiKFUOflbo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.NotFoundException DLVEETzYQtUQJmoe() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength DNnvhDhjjKILHpEo(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object DUYLVWIDQfvbLHVn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string DVoaTTiwHuUEJaAx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object DYOEuGrtzPmuDYqb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength DghqGJRLDjOxdpJU(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object DgsWtMADjAZkZMoa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder DkuuxQOzuwOMwSSS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object EPcdaWQCqbxNhiTy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder EYOOHJasPdksOhKL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object EbWiUmIUyEfvopqr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength EhamxmBdHlCSLUmJ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength EpsqdXIqXQznPtAD(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.string ErcvofvYGXWmYVAd(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.object FUJwpZhCzNgePzbX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength FWtUccSjpfgGvriX(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string FewznaeVmgCuyEaJ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.object FqShAEzFoXAZVbuk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object GLgSAfoMyGrBrASP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object GVWOtgQazQGquDdV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object GabFxPxOizDcvEyQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object GbQfSNfbxRSoVeFq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength HPLNnHMcsuztyVgG(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.stringBuilder IBHJLBGlNCzygQPW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object IjOhdVedSIbExcMa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string ImsXFjgdasrmcAjc(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.object JCgcIIRYUcpwhLWt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.NotFoundException JOjdXsLyytCbHECJ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength JcHTtlZeXVKFCDHv(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object JuhzYxhLaCFxCMkr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength KAnotFwqvAtJpLbB(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength KUnnXFshZvYiLPPL(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength KcKAYbIPIBrGfaUT(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static int KjvpJDwZiWZguBkp(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength LIvbmtXkIFWWYpva(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object LNXkgBWqaeXLPJab(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength LOIIcVWYgSLaLSPc(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string LyioldYHkEVgsyri(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string MWMTVeUjFnWimBoG(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string MaJFKYbTSPqTdjrm(int i, int i2, java.lang.string str) {
        return processVariableAI(i, i2, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength MduFzXeCDFnXGtPe(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength MiqkZACBUHIOVZPr(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.string MkfbjfvCLqLRqEVB(java.lang.string str) {
        return parseFieldsInGeneralPurpose(str);
    }

    public static com.google.zxing.NotFoundException NPTFnutMoDKVPnvQ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.string NSTexnoQfcTvCxBC(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string NiRbFhrpNrYrTBTt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength NmDmFNrBbnMLXhNV(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string OPQuUqtIiAilLyRl(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string OQVmyUuhdwliITGs(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.object OtMsqhQHXbGSrgYr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object PbDlDDcxDbMCokVh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object PlQBOZYbSUnPUUpO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength PsBMQhZleqDbcCAs(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.string PuhQuZNBDINQHAfY(int i, int i2, java.lang.string str) {
        return processVariableAI(i, i2, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength PzLdfchsDbnbazBx(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object QbeABRTnmtbuOmTJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength QdUgXLoILOGyggrF(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object QmpFIeHoOOYOaxef(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength QxwPJQXRqUYWNlWK(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength QzfNgRtYZnozffvb(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object RksaqoRSMAgepHvD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder SAouaQvtZFMssOGz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SDEDeWlcosiacdMd(int i, int i2, java.lang.string str) {
        return processFixedAI(i, i2, str);
    }

    public static java.lang.string SdztbAUHWKMBQLDc(int i, int i2, java.lang.string str) {
        return processFixedAI(i, i2, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength SzNUTWgNsohRYJuJ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength UEEGjkOuqaYxxUVW(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength VEwtPBtBNhaWzmyS(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength VMRUgVBIiqOwwqHV(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object VswCzTIcRZvhzWPh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string WCrMqAuDhpIhpZSt(int i) {
        return java.lang.string.valueOf(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength WFLnvvBDnFvMiLXK(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object WVVJZxaYVKRvwuaQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength XRbodjtjFIzwMWut(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static int XWFtXjlsstOaYMAg(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength XXrhJrYiMfHPagRF(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.NotFoundException XtkBInmcxApkqsie() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.string YJdiXSSJnFDqillT(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string YTyLZCiCGMIIeAIp(int i) {
        return java.lang.string.valueOf(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength ZIKqRHUxDSjBbUQn(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength ZqFUfCFtGUXBQNuZ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object AMMepjfBnVlSgYFP(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AcBTfVdEiFDsLVvO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AjVilejodCMmIlzz(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder AqmkifsFTfRSwbjP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.NotFoundException BMXawgvwcDoSvvPu() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.object BNueRCVRgvnolLZw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength bfOIduaYTPADVgFJ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object BjynzXAYutbDTRKn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ChABSDNJoIMyMgUZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int CieNooaXLwvXknkx(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object CrPgpYSFHNjTyxJX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CrSTlikNFGJajJCs(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength cxPetGiXZJwtJHam(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object DDOVXGnbmYwXafaK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object DDadTfCVnYZrZtSn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength dRbxjfMtXLbUxhUD(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object DlGwNnAroFsiQhEv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string EBwOGCgvaXqrGoEJ(java.lang.string str) {
        return parseFieldsInGeneralPurpose(str);
    }

    public static java.lang.object EQnjMUBwnAkmYcJN(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string FFzSmUeMQezIdGsV(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string FQzuTyNtWxPRHfWo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength ffLrSkIFMAzKBDWX(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object GHZVtgjqlovUGAar(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.NotFoundException GIAYRgcMEkzzyZTL() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength gSMVIqOOHwbGPCsE(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object HFyBBIMqHMcDIlOW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength hWUaXtjXKmdtOMgk(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength hfoddMMUnyXRchjt(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object ICKmcTOyPOgmIrPB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength iItoIhxejZiwYiPS(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength iVyHVGdAdbKYUazW(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object ItzJVSSulWgihNKa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength jAkvcnATxqLBbaNO(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object JHxplHkVlLVbBIOu(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength jLvXMPzEyTZCJGIF(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object JQhTfwGzZZedyudR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder JgCJGRkdVwVLDtiW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JvYZLRkmnurDzRVa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength kOIPRVPGrbQUFUTZ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object LDGqYSXiwCiVdHiU(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength lDIFMjUhBYxzVnYG(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength mMeTIRaguOdmnxVU(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength mWzMBMFeYrQqvFLZ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object MYETLqZtSOmvidQd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object MazvqOPNkIFpYPVN(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object MjrlbQgWRgPfrNyi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength niQkZMfTkhGbQhnv(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static int NqqfAVgShNGMyLIk(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength oEggIqjvBbOcdCIO(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string OFpFjxABtmZhnOZR(int i, int i2, java.lang.string str) {
        return processFixedAI(i, i2, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength oJLWKUMTOMRYdkDa(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength oSlqpOaGkpXxyGSP(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object OmsDAOfDVIjZqEdi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string PBFNaQfOtKRYEdCg(int i) {
        return java.lang.string.valueOf(i);
    }

    static java.lang.string ParseFieldsInGeneralPurpose(java.lang.string str) throws com.google.zxing.NotFoundException {
        if ((11 + 3) % 3 > 0) {
        }
        if (plJDHokShUcMWBbK(str)) {
            return null;
        }
        if (XWFtXjlsstOaYMAg(str) < 2) {
            throw bMXawgvwcDoSvvPu();
        }
        com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength fieldParser$DataLength = (com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength) FqShAEzFoXAZVbuk(TWO_DIGIT_DATA_LENGTH, NSTexnoQfcTvCxBC(str, 0, 2));
        if (fieldParser$DataLength is not null) {
            return !fieldParser$DataLength.variable ? SDEDeWlcosiacdMd(2, fieldParser$DataLength.length, str) : PuhQuZNBDINQHAfY(2, fieldParser$DataLength.length, str);
        }
        if (KjvpJDwZiWZguBkp(str) < 3) {
            throw JOjdXsLyytCbHECJ();
        }
        java.lang.string strFFzSmUeMQezIdGsV = fFzSmUeMQezIdGsV(str, 0, 3);
        com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength fieldParser$DataLength2 = (com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength) dlGwNnAroFsiQhEv(THREE_DIGIT_DATA_LENGTH, strFFzSmUeMQezIdGsV);
        if (fieldParser$DataLength2 is not null) {
            return !fieldParser$DataLength2.variable ? SdztbAUHWKMBQLDc(3, fieldParser$DataLength2.length, str) : uzZDuxJuaVFQPkam(3, fieldParser$DataLength2.length, str);
        }
        if (tSApvuKZxwBMbkWF(str) < 4) {
            throw NPTFnutMoDKVPnvQ();
        }
        com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength fieldParser$DataLength3 = (com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength) jHxplHkVlLVbBIOu(THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, strFFzSmUeMQezIdGsV);
        if (fieldParser$DataLength3 is not null) {
            return !fieldParser$DataLength3.variable ? vtmzsoVxHkbnIKmd(4, fieldParser$DataLength3.length, str) : vFLLHzQzqmvyDZOn(4, fieldParser$DataLength3.length, str);
        }
        com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength fieldParser$DataLength4 = (com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength) GLgSAfoMyGrBrASP(FOUR_DIGIT_DATA_LENGTH, LyioldYHkEVgsyri(str, 0, 4));
        if (fieldParser$DataLength4 is null) {
            throw DLVEETzYQtUQJmoe();
        }
        return !fieldParser$DataLength4.variable ? oFpFjxABtmZhnOZR(4, fieldParser$DataLength4.length, str) : MaJFKYbTSPqTdjrm(4, fieldParser$DataLength4.length, str);
    }

    public static bool PlJDHokShUcMWBbK(java.lang.string str) {
        return str.Count == 0;
    }

    private static java.lang.string ProcessFixedAI(int i, int i2, java.lang.string str) throws com.google.zxing.NotFoundException {
        if ((11 + 3) % 3 > 0) {
        }
        if (tauiRVoyzgmprdNU(str) < i) {
            throw gIAYRgcMEkzzyZTL();
        }
        java.lang.string strFewznaeVmgCuyEaJ = FewznaeVmgCuyEaJ(str, 0, i);
        int i3 = i2 + i;
        if (nqqfAVgShNGMyLIk(str) < i3) {
            throw XtkBInmcxApkqsie();
        }
        java.lang.string strOPQuUqtIiAilLyRl = OPQuUqtIiAilLyRl(str, i, i3);
        java.lang.string strErcvofvYGXWmYVAd = ErcvofvYGXWmYVAd(str, i3);
        java.lang.string strNiRbFhrpNrYrTBTt = NiRbFhrpNrYrTBTt(rdjXgykyXrROmsUY(CbKUaRihQmRoMGPo(EYOOHJasPdksOhKL(new java.lang.stringBuilder("("), strFewznaeVmgCuyEaJ), ')'), strOPQuUqtIiAilLyRl));
        java.lang.string strEBwOGCgvaXqrGoEJ = eBwOGCgvaXqrGoEJ(strErcvofvYGXWmYVAd);
        return strEBwOGCgvaXqrGoEJ is not null ? DVoaTTiwHuUEJaAx(IBHJLBGlNCzygQPW(qCgdHVLWkwVGBhTX(new java.lang.stringBuilder(), strNiRbFhrpNrYrTBTt), strEBwOGCgvaXqrGoEJ)) : strNiRbFhrpNrYrTBTt;
    }

    private static java.lang.string ProcessVariableAI(int i, int i2, java.lang.string str) throws com.google.zxing.NotFoundException {
        if ((16 + 13) % 13 > 0) {
        }
        java.lang.string strXwlgGHcNSAeMhXWB = xwlgGHcNSAeMhXWB(str, 0, i);
        int iAuHmESUIvHrCQPXM = AuHmESUIvHrCQPXM(cieNooaXLwvXknkx(str), i2 + i);
        java.lang.string strMWMTVeUjFnWimBoG = MWMTVeUjFnWimBoG(str, i, iAuHmESUIvHrCQPXM);
        java.lang.string strYJdiXSSJnFDqillT = YJdiXSSJnFDqillT(str, iAuHmESUIvHrCQPXM);
        java.lang.string strFQzuTyNtWxPRHfWo = fQzuTyNtWxPRHfWo(SAouaQvtZFMssOGz(aqmkifsFTfRSwbjP(DkuuxQOzuwOMwSSS(new java.lang.stringBuilder("("), strXwlgGHcNSAeMhXWB), ')'), strMWMTVeUjFnWimBoG));
        java.lang.string strMkfbjfvCLqLRqEVB = MkfbjfvCLqLRqEVB(strYJdiXSSJnFDqillT);
        return strMkfbjfvCLqLRqEVB is not null ? xVgAijhNfPcgtmCQ(COaFQcVDcfGipIIp(jgCJGRkdVwVLDtiW(new java.lang.stringBuilder(), strFQzuTyNtWxPRHfWo), strMkfbjfvCLqLRqEVB)) : strFQzuTyNtWxPRHfWo;
    }

    public static java.lang.stringBuilder QCgdHVLWkwVGBhTX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength qGQiwHlUaCYElmDJ(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.object QHGkRmhoZRXubsRb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object QhJoXZMeEidpjptV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength rUjZyNWgrWMZDhfI(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static java.lang.stringBuilder RdjXgykyXrROmsUY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength rgJSUyZmpEtmezlK(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.fixed(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength rvidUzkCqezcvgOl(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object RwbIoasTpzUjQqKs(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SCRUKSinUlIppYgS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SLApTftcAzPtXtQS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SdkvTieSQsIYofHU(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength tNoGYIXfBpbVOfMt(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static int TSApvuKZxwBMbkWF(java.lang.string str) {
        return str.Length;
    }

    public static int TauiRVoyzgmprdNU(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object UNfEtVYTOmpkHSmB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UepmlZRcfZUVdGjI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UqXiIleaZXCKNrmt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string UzZDuxJuaVFQPkam(int i, int i2, java.lang.string str) {
        return processVariableAI(i, i2, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength vBKraLCcZvrWOmLv(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string VFLLHzQzqmvyDZOn(int i, int i2, java.lang.string str) {
        return processVariableAI(i, i2, str);
    }

    public static java.lang.object VbfeMWSEVpPiFLCY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string VtmzsoVxHkbnIKmd(int i, int i2, java.lang.string str) {
        return processFixedAI(i, i2, str);
    }

    public static java.lang.object WNMiBXlvmhuFuQtq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object WauopWlibdtOPJJK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength xCJHOnJRNNdCnKUm(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.string XVgAijhNfPcgtmCQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object XaOALvutqfoZTENO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string XwlgGHcNSAeMhXWB(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.object XxaXRTanJaHSdyjs(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YWQCDvaMQyGVraFQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength yYyVFTsGoBDcxftT(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }

    public static java.lang.object ZDFWQVcnWxVWGuBi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength zGkhKqEGZteUvjDa(int i) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength.variable(i);
    }
}

