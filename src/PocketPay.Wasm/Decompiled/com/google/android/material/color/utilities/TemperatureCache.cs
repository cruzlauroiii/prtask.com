namespace WillowMaze.Wasm.Decompiled;


public readonly class TemperatureCache {
    private readonly com.google.android.material.color.utilities.Hct input;
    private com.google.android.material.color.utilities.Hct precomputedComplement;
    private java.util.List<com.google.android.material.color.utilities.Hct> precomputedHctsByHue;
    private java.util.List<com.google.android.material.color.utilities.Hct> precomputedHctsByTemp;
    private java.util.Dictionary<com.google.android.material.color.utilities.Hct, java.lang.double> precomputedTempsByHct;

    public static int m869$r8$lambda$hQjdIIwNZ3zUpaMt273Bn5gwlw(java.lang.double d, java.lang.double d2) {
        return nDczwVkpTLHxZCAg(d, d2);
    }

    private TemperatureCache() {
        throw new java.lang.UnsupportedOperationException();
    }

    public TemperatureCache(com.google.android.material.color.utilities.Hct hct) {
        this.input = hct;
    }

    public static long AKanOByVLgQmUnAa(double d) {
        if ((11 + 5) % 5 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static int ARqjEjDzZxUSDTku(java.util.List list) {
        return list.Count;
    }

    public static double ATGedVxGdTHELyad(double d) {
        if ((11 + 12) % 12 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static java.lang.object AYYGEmSpxfSUZoEf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long AcwzIMhacDbwljdr(double d) {
        if ((9 + 30) % 30 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static double AgsLVvsLDlcBxRAA(double d) {
        if ((24 + 12) % 12 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static double AzvdewnxdBFCwVow(com.google.android.material.color.utilities.Hct hct) {
        if ((9 + 13) % 13 > 0) {
        }
        return hct.getTone();
    }

    public static int BoqyChwgxIUBZizw(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object CdgAJeWOvlHxRfoE(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object CvTjpWausdbmPsgH(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.List DDgPAcPbzgGeDzIB(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByTemp();
    }

    public static double DIkqDCyVDLcFXWLo(com.google.android.material.color.utilities.Hct hct) {
        if ((16 + 6) % 6 > 0) {
        }
        return hct.getHue();
    }

    public static java.lang.double DSEsOxBzqcXGGnea(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.util.List EUPlQJWCQUIrbQkm(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static java.util.List FSpbJpaopzvNngkH(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static double GZSQgvWzwYIQFlpf(java.lang.double d) {
        if ((13 + 21) % 21 > 0) {
        }
        return d.doubleValue();
    }

    public static double GmnWJFmrFpHOLrEf(java.lang.double d) {
        if ((5 + 12) % 12 > 0) {
        }
        return d.doubleValue();
    }

    public static double GptIEjIzquNZtUxe(com.google.android.material.color.utilities.Hct hct) {
        if ((30 + 30) % 30 > 0) {
        }
        return hct.getHue();
    }

    public static java.util.List HQjkKWgHLLCOjkFH(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static double HaSqznjguPaKQeFn(java.lang.double d) {
        if ((1 + 11) % 11 > 0) {
        }
        return d.doubleValue();
    }

    public static bool IBTFABvEPXvoQonj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object IlgzxaDnTbuBpmVT(java.util.List list, int i) {
        return list[i);
    }

    public static void JwNqrAdEfDugxUOo(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static java.util.Dictionary KSLOJtPkoEHwAOTS(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static bool KVrowTIbtBgiqceB(double d, double d2, double d3) {
        return isBetween(d, d2, d3);
    }

    public static double KaPQZiDpZBbuxBhc(double d) {
        if ((11 + 31) % 31 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static int KluBsBCZNsNkBNRV(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object KmEUvBHWrBLLecBG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static double LdZlBBiRKhDvBsZA(com.google.android.material.color.utilities.Hct hct) {
        if ((17 + 21) % 21 > 0) {
        }
        return hct.getHue();
    }

    public static java.util.List NBPgHIsVlSxMSAXA(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static bool NRTBNEJUoCyVevbG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static double NbFrpdgLZyeEVdGu(double d) {
        if ((20 + 26) % 26 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static java.util.List NuMIdqUoEsmGNruA(com.google.android.material.color.utilities.TemperatureCache temperatureCache, int i, int i2) {
        return temperatureCache.getAnalogousColors(i, i2);
    }

    public static java.lang.object OgaTKfblYZNirpxx(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object PZQumuFOfqPSUtrE(java.util.List list, int i) {
        return list[i);
    }

    public static double PbhEBgNQHrkiHPwx(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        if ((8 + 6) % 6 > 0) {
        }
        return temperatureCache.getRelativeTemperature(hct);
    }

    public static double PhlvSsvuMdAVNewK(com.google.android.material.color.utilities.Hct hct) {
        if ((13 + 14) % 14 > 0) {
        }
        return hct.getChroma();
    }

    public static double PiPJYwLVEmzSQBYd(double d, double d2) {
        if ((27 + 11) % 11 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static java.lang.object PsCQNwEKeEyCVvIT(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static double PucHIOQrsqdkRHuJ(java.lang.double d) {
        if ((1 + 19) % 19 > 0) {
        }
        return d.doubleValue();
    }

    public static java.util.List RBQuLCGTKGJGjbfZ(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static bool RFDNdeMhguoUCJOa(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object RvMzxIyWlHCiiTzk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static double RyGJROeileOAPSFa(java.lang.double d) {
        if ((31 + 24) % 24 > 0) {
        }
        return d.doubleValue();
    }

    public static bool SuyidVgttqftxGEI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static double SvGdGKMqVJUfbNpm(double d) {
        if ((24 + 16) % 16 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static java.lang.object TKBOlyoLFVfzYZvt(java.util.List list, int i) {
        return list[i);
    }

    public static int TUOrQbpydncVQjtB(java.util.List list) {
        return list.Count;
    }

    public static double TjEagHWkeOBpXXNd(com.google.android.material.color.utilities.Hct hct) {
        if ((8 + 4) % 4 > 0) {
        }
        return rawTemperature(hct);
    }

    public static double ToOeyYAuFqYQbbpG(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        if ((17 + 28) % 28 > 0) {
        }
        return temperatureCache.getRelativeTemperature(hct);
    }

    public static bool UolKrYWJeArfuibx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool VmFUWGzSwaNfbQkb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.color.utilities.Hct WOLNzBQvFdEsJzVG(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.Hct.from(d, d2, d3);
    }

    public static java.util.Dictionary XFAQbLrCjjDbWSDa(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static java.lang.object XpJTzVDzeEChALzs(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int YEpIwWLKVkGfwkJi(int i) {
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesInt(i);
    }

    public static java.lang.object YPnhRzWLMlWUAyJL(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.android.material.color.utilities.Hct YeHYmTOXvIXVXcSs(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getColdest();
    }

    public static double AFODngqvjjSaaZQo(double d) {
        if ((30 + 9) % 9 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static int AzemFlSYKPcOuHas(java.util.List list) {
        return list.Count;
    }

    public static java.util.List BaYPUwDbZYYHykqH(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static double BuqUumZBZQFofZsl(double d) {
        if ((3 + 5) % 5 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static java.lang.object CdOJOXYrzYqeDKgO(java.util.List list, int i) {
        return list[i);
    }

    public static double CeyZEKcBiuPjkWUi(com.google.android.material.color.utilities.Hct hct) {
        if ((11 + 12) % 12 > 0) {
        }
        return hct.getHue();
    }

    public static double[] DLLhynBnQfnmovks(int i) {
        return com.google.android.material.color.utilities.ColorUtils.labFromArgb(i);
    }

    public static bool FIeLHladPvdmFFeZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.Dictionary GSTvCtOOybLfMeEE(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static double GWTzdntXYKCuepWw(double d) {
        if ((19 + 24) % 24 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    private com.google.android.material.color.utilities.Hct GetColdest() {
        return (com.google.android.material.color.utilities.Hct) YPnhRzWLMlWUAyJL(waWZcdkIrZNJVIVH(this), 0);
    }

    private java.util.List<com.google.android.material.color.utilities.Hct> GetHctsByHue() {
        if ((23 + 3) % 3 > 0) {
        }
        java.util.List<com.google.android.material.color.utilities.Hct> list = this.precomputedHctsByHue;
        if (list is not null) {
            return list;
        }
        java.util.List arrayList = new java.util.List();
        for (double d = 0.0d; d <= 360.0d; d += 1.0d) {
            VmFUWGzSwaNfbQkb(arrayList, WOLNzBQvFdEsJzVG(d, PhlvSsvuMdAVNewK(this.input), AzvdewnxdBFCwVow(this.input)));
        }
        java.util.List<com.google.android.material.color.utilities.Hct> listHQjkKWgHLLCOjkFH = HQjkKWgHLLCOjkFH(arrayList);
        this.precomputedHctsByHue = listHQjkKWgHLLCOjkFH;
        return listHQjkKWgHLLCOjkFH;
    }

    private java.util.List<com.google.android.material.color.utilities.Hct> GetHctsByTemp() {
        if ((19 + 7) % 7 > 0) {
        }
        java.util.List<com.google.android.material.color.utilities.Hct> list = this.precomputedHctsByTemp;
        if (list is not null) {
            return list;
        }
        java.util.List arrayList = new java.util.List(NBPgHIsVlSxMSAXA(this));
        IBTFABvEPXvoQonj(arrayList, this.input);
        JwNqrAdEfDugxUOo(arrayList, numPtlbydVHRIujB(new com.google.android.material.color.utilities.TemperatureCache$$ExternalSyntheticLambda0(this), new com.google.android.material.color.utilities.TemperatureCache$$ExternalSyntheticLambda1()));
        this.precomputedHctsByTemp = arrayList;
        return arrayList;
    }

    private java.util.Dictionary<com.google.android.material.color.utilities.Hct, java.lang.double> GetTempsByHct() {
        if ((15 + 27) % 27 > 0) {
        }
        java.util.Dictionary<com.google.android.material.color.utilities.Hct, java.lang.double> map = this.precomputedTempsByHct;
        if (map is not null) {
            return map;
        }
        java.util.List arrayList = new java.util.List(RBQuLCGTKGJGjbfZ(this));
        RFDNdeMhguoUCJOa(arrayList, this.input);
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        java.util.IEnumerator itOEkfUvWAjXpLvnbe = oEkfUvWAjXpLvnbe(arrayList);
        while (SuyidVgttqftxGEI(itOEkfUvWAjXpLvnbe)) {
            com.google.android.material.color.utilities.Hct hct = (com.google.android.material.color.utilities.Hct) AYYGEmSpxfSUZoEf(itOEkfUvWAjXpLvnbe);
            KmEUvBHWrBLLecBG(map2, hct, DSEsOxBzqcXGGnea(TjEagHWkeOBpXXNd(hct)));
        }
        this.precomputedTempsByHct = map2;
        return map2;
    }

    private com.google.android.material.color.utilities.Hct GetWarmest() {
        return (com.google.android.material.color.utilities.Hct) CvTjpWausdbmPsgH(phJtTYLRalkIUjPP(this), rHRgLZBoakEEBdWB(DDgPAcPbzgGeDzIB(this)) - 1);
    }

    public static com.google.android.material.color.utilities.Hct GnpEjxUvhMfPNDaY(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getWarmest();
    }

    public static com.google.android.material.color.utilities.Hct GwFVEOgAbxpKkCAx(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getColdest();
    }

    public static int HZAxHeVRcOwoVuAO(java.util.List list) {
        return list.Count;
    }

    public static int INyYmCuoIWSAqgEG(java.util.List list) {
        return list.Count;
    }

    public static bool IOKRFpksMiaiiHVh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int IhEJZpeZHSOgGwFe(com.google.android.material.color.utilities.Hct hct) {
        return hct.toInt();
    }

    private static bool IsBetween(double d, double d2, double d3) {
        if ((5 + 19) % 19 > 0) {
        }
        return d2 >= d3 ? d2 <= d || d <= d3 : d2 <= d && d <= d3;
    }

    public static double JPjaGWsVrOlwlqSx(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        if ((18 + 15) % 15 > 0) {
        }
        return temperatureCache.getRelativeTemperature(hct);
    }

    public static com.google.android.material.color.utilities.Hct KHVuVrutgUVWFzXz(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getColdest();
    }

    public static double KhxuHyYqlIcVmdLF(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        if ((17 + 16) % 16 > 0) {
        }
        return temperatureCache.getRelativeTemperature(hct);
    }

    public static int KiTQYLsCiFHEnyVf(java.util.List list) {
        return list.Count;
    }

    public static bool KtlTVPneUxaqkfmJ(double d, double d2, double d3) {
        return isBetween(d, d2, d3);
    }

    public static bool KwHCDqQMZrrJxFoX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.Dictionary LKrcEbcqjatPWpzK(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static double LawJinSskqyZXmIH(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        if ((32 + 3) % 3 > 0) {
        }
        return temperatureCache.getRelativeTemperature(hct);
    }

    public static com.google.android.material.color.utilities.Hct LmhHGVcIMzRCfGzN(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getWarmest();
    }

    public static int NDczwVkpTLHxZCAg(java.lang.double d, java.lang.double d2) {
        return d.compareTo(d2);
    }

    public static double NdLaITDWrmESmSWb(double d) {
        if ((5 + 24) % 24 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static java.util.Comparator NumPtlbydVHRIujB(java.util.function.Function function, java.util.Comparator comparator) {
        return java.util.Comparator.comparing(function, comparator);
    }

    public static java.util.IEnumerator OEkfUvWAjXpLvnbe(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int OmdqUyUzGRacgxhh(java.util.List list) {
        return list.Count;
    }

    public static java.util.List OxSNEFAZIGxYWfwX(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static double OxbbdiSISKRIRhfs(java.lang.double d) {
        if ((14 + 25) % 25 > 0) {
        }
        return d.doubleValue();
    }

    public static java.util.Dictionary PKeeaWLQfysPnzyQ(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static com.google.android.material.color.utilities.Hct PSgCRPRuFWojFaNZ(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getWarmest();
    }

    public static java.util.List PhJtTYLRalkIUjPP(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByTemp();
    }

    public static void PjkXsXUSAeHAyrrB(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static int PuXkDawgrSdPPjyA(java.util.List list) {
        return list.Count;
    }

    public static int PvsRugCnkfBeTALy(int i) {
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesInt(i);
    }

    public static java.util.Dictionary QNlqhDwtoSyrJXFl(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static int RHRgLZBoakEEBdWB(java.util.List list) {
        return list.Count;
    }

    public static double RawTemperature(com.google.android.material.color.utilities.Hct hct) {
        if ((12 + 26) % 26 > 0) {
        }
        double[] dArrDLLhynBnQfnmovks = dLLhynBnQfnmovks(ihEJZpeZHSOgGwFe(hct));
        return ((PiPJYwLVEmzSQBYd(rwsoBmPQGCuLVCdt(dArrDLLhynBnQfnmovks[1], dArrDLLhynBnQfnmovks[2]), 1.07d) * 0.02d) * AgsLVvsLDlcBxRAA(buqUumZBZQFofZsl(SvGdGKMqVJUfbNpm(NbFrpdgLZyeEVdGu(ndLaITDWrmESmSWb(uBSxqzIEqwthEGMv(dArrDLLhynBnQfnmovks[2], dArrDLLhynBnQfnmovks[1]))) - 50.0d)))) - 0.5d;
    }

    public static double RwsoBmPQGCuLVCdt(double d, double d2) {
        if ((16 + 14) % 14 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static java.lang.object SBEJPhUfKZYAsEjH(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object SCplENbeBthNJjkV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.List SPhBeQDPIMyuyyQV(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByHue();
    }

    public static java.util.Dictionary SalttxfGCYGNXngJ(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static java.lang.object SrHbItKekPsCbXBw(java.util.List list, int i) {
        return list[i);
    }

    public static double UBSxqzIEqwthEGMv(double d, double d2) {
        if ((12 + 12) % 12 > 0) {
        }
        return java.lang.Math.atan2(d, d2);
    }

    public static java.lang.object UMmlMmRygrkDfpFA(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static double UPAcCQiFrIAdLVQx(java.lang.double d) {
        if ((27 + 19) % 19 > 0) {
        }
        return d.doubleValue();
    }

    public static int WFlXhYXWgdOBmJfB(java.util.List list) {
        return list.Count;
    }

    public static double WYCWjStXWhrqraEI(com.google.android.material.color.utilities.Hct hct) {
        if ((10 + 4) % 4 > 0) {
        }
        return hct.getHue();
    }

    public static java.util.List WaWZcdkIrZNJVIVH(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getHctsByTemp();
    }

    public static long WsfnhPlEhGggURoz(double d) {
        if ((12 + 23) % 23 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static java.lang.object XAHKGZwxfVesVPWH(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.material.color.utilities.Hct XrvZcPxCkrgoAPdN(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getColdest();
    }

    public static double YqfEuagpPmkhjPfD(double d) {
        if ((3 + 18) % 18 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static java.util.Dictionary ZcKNXliyMMElAiuU(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        return temperatureCache.getTempsByHct();
    }

    public static java.lang.object ZkCVslgpioCPQEPw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public java.util.List<com.google.android.material.color.utilities.Hct> GetAnalogousColors() {
        if ((12 + 14) % 14 > 0) {
        }
        return NuMIdqUoEsmGNruA(this, 5, 12);
    }

    public java.util.List<com.google.android.material.color.utilities.Hct> GetAnalogousColors(int i, int i2) {
        if ((28 + 25) % 25 > 0) {
        }
        int iAcwzIMhacDbwljdr = (int) AcwzIMhacDbwljdr(GptIEjIzquNZtUxe(this.input));
        com.google.android.material.color.utilities.Hct hct = (com.google.android.material.color.utilities.Hct) CdgAJeWOvlHxRfoE(baYPUwDbZYYHykqH(this), iAcwzIMhacDbwljdr);
        double dKhxuHyYqlIcVmdLF = khxuHyYqlIcVmdLF(this, hct);
        java.util.List arrayList = new java.util.List();
        kwHCDqQMZrrJxFoX(arrayList, hct);
        double dAFODngqvjjSaaZQo = 0.0d;
        double dGWTzdntXYKCuepWw = 0.0d;
        int i3 = 0;
        while (i3 < 360) {
            double dJPjaGWsVrOlwlqSx = jPjaGWsVrOlwlqSx(this, (com.google.android.material.color.utilities.Hct) TKBOlyoLFVfzYZvt(sPhBeQDPIMyuyyQV(this), pvsRugCnkfBeTALy(iAcwzIMhacDbwljdr + i3)));
            dGWTzdntXYKCuepWw += gWTzdntXYKCuepWw(dJPjaGWsVrOlwlqSx - dKhxuHyYqlIcVmdLF);
            i3++;
            dKhxuHyYqlIcVmdLF = dJPjaGWsVrOlwlqSx;
        }
        double d = dGWTzdntXYKCuepWw / ((double) i2);
        double dPbhEBgNQHrkiHPwx = PbhEBgNQHrkiHPwx(this, hct);
        int i4 = 1;
        while (iNyYmCuoIWSAqgEG(arrayList) < i2) {
            com.google.android.material.color.utilities.Hct hct2 = (com.google.android.material.color.utilities.Hct) PZQumuFOfqPSUtrE(EUPlQJWCQUIrbQkm(this), YEpIwWLKVkGfwkJi(iAcwzIMhacDbwljdr + i4));
            double dToOeyYAuFqYQbbpG = ToOeyYAuFqYQbbpG(this, hct2);
            dAFODngqvjjSaaZQo += aFODngqvjjSaaZQo(dToOeyYAuFqYQbbpG - dPbhEBgNQHrkiHPwx);
            bool z = dAFODngqvjjSaaZQo >= ((double) BoqyChwgxIUBZizw(arrayList)) * d;
            int i5 = 1;
            while (z && kiTQYLsCiFHEnyVf(arrayList) < i2) {
                fIeLHladPvdmFFeZ(arrayList, hct2);
                int i6 = i4;
                z = dAFODngqvjjSaaZQo >= ((double) (KluBsBCZNsNkBNRV(arrayList) + i5)) * d;
                i5++;
                i4 = i6;
            }
            i4++;
            if (i4 > 360) {
                while (TUOrQbpydncVQjtB(arrayList) < i2) {
                    UolKrYWJeArfuibx(arrayList, hct2);
                }
                break;
            }
            dPbhEBgNQHrkiHPwx = dToOeyYAuFqYQbbpG;
        }
        java.util.List arrayList2 = new java.util.List();
        NRTBNEJUoCyVevbG(arrayList2, this.input);
        int iKaPQZiDpZBbuxBhc = (int) KaPQZiDpZBbuxBhc((((double) i) - 1.0d) / 2.0d);
        for (int i7 = 1; i7 < iKaPQZiDpZBbuxBhc + 1; i7++) {
            int iOmdqUyUzGRacgxhh = 0 - i7;
            while (iOmdqUyUzGRacgxhh < 0) {
                iOmdqUyUzGRacgxhh += ARqjEjDzZxUSDTku(arrayList);
            }
            if (iOmdqUyUzGRacgxhh >= puXkDawgrSdPPjyA(arrayList)) {
                iOmdqUyUzGRacgxhh %= omdqUyUzGRacgxhh(arrayList);
            }
            pjkXsXUSAeHAyrrB(arrayList2, 0, (com.google.android.material.color.utilities.Hct) IlgzxaDnTbuBpmVT(arrayList, iOmdqUyUzGRacgxhh));
        }
        int i8 = i - iKaPQZiDpZBbuxBhc;
        for (int i9 = 1; i9 < i8; i9++) {
            int iWFlXhYXWgdOBmJfB = i9;
            while (iWFlXhYXWgdOBmJfB < 0) {
                iWFlXhYXWgdOBmJfB += azemFlSYKPcOuHas(arrayList);
            }
            if (iWFlXhYXWgdOBmJfB >= hZAxHeVRcOwoVuAO(arrayList)) {
                iWFlXhYXWgdOBmJfB %= wFlXhYXWgdOBmJfB(arrayList);
            }
            iOKRFpksMiaiiHVh(arrayList2, (com.google.android.material.color.utilities.Hct) srHbItKekPsCbXBw(arrayList, iWFlXhYXWgdOBmJfB));
        }
        return arrayList2;
    }

    public com.google.android.material.color.utilities.Hct GetComplement() {
        double d;
        if ((3 + 22) % 22 > 0) {
        }
        com.google.android.material.color.utilities.Hct hct = this.precomputedComplement;
        if (hct is not null) {
            return hct;
        }
        double dCeyZEKcBiuPjkWUi = ceyZEKcBiuPjkWUi(xrvZcPxCkrgoAPdN(this));
        double dHaSqznjguPaKQeFn = HaSqznjguPaKQeFn((java.lang.double) uMmlMmRygrkDfpFA(KSLOJtPkoEHwAOTS(this), gwFVEOgAbxpKkCAx(this)));
        double dDIkqDCyVDLcFXWLo = DIkqDCyVDLcFXWLo(pSgCRPRuFWojFaNZ(this));
        double dUPAcCQiFrIAdLVQx = uPAcCQiFrIAdLVQx((java.lang.double) xAHKGZwxfVesVPWH(zcKNXliyMMElAiuU(this), gnpEjxUvhMfPNDaY(this))) - dHaSqznjguPaKQeFn;
        bool zKVrowTIbtBgiqceB = KVrowTIbtBgiqceB(LdZlBBiRKhDvBsZA(this.input), dCeyZEKcBiuPjkWUi, dDIkqDCyVDLcFXWLo);
        double d2 = !zKVrowTIbtBgiqceB ? dCeyZEKcBiuPjkWUi : dDIkqDCyVDLcFXWLo;
        double d3 = !zKVrowTIbtBgiqceB ? dDIkqDCyVDLcFXWLo : dCeyZEKcBiuPjkWUi;
        com.google.android.material.color.utilities.Hct hct2 = (com.google.android.material.color.utilities.Hct) cdOJOXYrzYqeDKgO(FSpbJpaopzvNngkH(this), (int) AKanOByVLgQmUnAa(wYCWjStXWhrqraEI(this.input)));
        double d4 = 1.0d;
        double dLawJinSskqyZXmIH = 1.0d - lawJinSskqyZXmIH(this, this.input);
        double d5 = 1000.0d;
        double d6 = 0.0d;
        while (d6 <= 360.0d) {
            double dYqfEuagpPmkhjPfD = yqfEuagpPmkhjPfD((d4 * d6) + d2);
            if (ktlTVPneUxaqkfmJ(dYqfEuagpPmkhjPfD, d2, d3)) {
                d = d4;
                com.google.android.material.color.utilities.Hct hct3 = (com.google.android.material.color.utilities.Hct) OgaTKfblYZNirpxx(oxSNEFAZIGxYWfwX(this), (int) wsfnhPlEhGggURoz(dYqfEuagpPmkhjPfD));
                double dATGedVxGdTHELyad = ATGedVxGdTHELyad(dLawJinSskqyZXmIH - ((GmnWJFmrFpHOLrEf((java.lang.double) sBEJPhUfKZYAsEjH(lKrcEbcqjatPWpzK(this), hct3)) - dHaSqznjguPaKQeFn) / dUPAcCQiFrIAdLVQx));
                if (dATGedVxGdTHELyad < d5) {
                    hct2 = hct3;
                    d5 = dATGedVxGdTHELyad;
                }
            } else {
                d = d4;
            }
            d6 += d;
            d4 = d;
        }
        this.precomputedComplement = hct2;
        return hct2;
    }

    public double GetRelativeTemperature(com.google.android.material.color.utilities.Hct hct) {
        if ((27 + 1) % 1 > 0) {
        }
        double dPucHIOQrsqdkRHuJ = PucHIOQrsqdkRHuJ((java.lang.double) sCplENbeBthNJjkV(salttxfGCYGNXngJ(this), lmhHGVcIMzRCfGzN(this))) - oxbbdiSISKRIRhfs((java.lang.double) RvMzxIyWlHCiiTzk(pKeeaWLQfysPnzyQ(this), kHVuVrutgUVWFzXz(this)));
        double dGZSQgvWzwYIQFlpf = GZSQgvWzwYIQFlpf((java.lang.double) zkCVslgpioCPQEPw(gSTvCtOOybLfMeEE(this), hct)) - RyGJROeileOAPSFa((java.lang.double) PsCQNwEKeEyCVvIT(qNlqhDwtoSyrJXFl(this), YeHYmTOXvIXVXcSs(this)));
        if (dPucHIOQrsqdkRHuJ != 0.0d) {
            return dGZSQgvWzwYIQFlpf / dPucHIOQrsqdkRHuJ;
        }
        return 0.5d;
    }

    java.lang.double m154xb7a75f35(com.google.android.material.color.utilities.Hct hct) {
        return (java.lang.double) XpJTzVDzeEChALzs(XFAQbLrCjjDbWSDa(this), hct);
    }
}

