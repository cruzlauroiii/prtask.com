namespace WillowMaze.Wasm.Decompiled;


public readonly class Score {
    private static readonly int BLUE_500 = -12417548;
    private static readonly double CUTOFF_CHROMA = 5.0d;
    private static readonly double CUTOFF_EXCITED_PROPORTION = 0.01d;
    private static readonly int MAX_COLOR_COUNT = 4;
    private static readonly double TARGET_CHROMA = 48.0d;
    private static readonly double WEIGHT_CHROMA_ABOVE = 0.3d;
    private static readonly double WEIGHT_CHROMA_BELOW = 0.1d;
    private static readonly double WEIGHT_PROPORTION = 0.7d;

    private Score() {
    }

    public static java.util.IEnumerator AXKUtvtuyyORAvkN(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool AgZqjnYfxOBGCycm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static double CSOKTDRQiVvnuaXU(com.google.android.material.color.utilities.Hct hct) {
        if ((2 + 3) % 3 > 0) {
        }
        return hct.getChroma();
    }

    public static bool DBFsFUWiqFEPmmIG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator FslnnTwafIneUOBq(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int GwvpYwmhXpdzBJbk(int i) {
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesInt(i);
    }

    public static java.lang.object JWiGKxBZLqinFTvI(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.util.HashSet JXuxOlEtqnuiUBjn(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void KIDskRNesCjwcdWQ(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static java.lang.int KTfojRqgGefxsCAm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool LDVIxqRCWyuFJfAv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool LWTUNKxArPQDmevn(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List MPwWjNOXtvjWmBnO(java.util.Dictionary map, int i, int i2, bool z) {
        return score(map, i, i2, z);
    }

    public static java.lang.object NVXrgDmbeALQBLVQ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static int OIYcvKifjTZvRNzP(java.util.List list) {
        return list.Count;
    }

    public static java.lang.int OOVRwyjzXhqqPABC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OkTwqLtzAKCxwGnM(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.material.color.utilities.Hct QzAmvdYbJiphiVZd(int i) {
        return com.google.android.material.color.utilities.Hct.fromInt(i);
    }

    public static java.util.IEnumerator STueUScrBqsldDgA(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object TkrKFolNsubckVNV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object TqFOyYfykqzLIjit(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool UvPYqnphTaOZdRHe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object VNxTXksjhlAdLiOH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VOyWRPpvxhTxbGBJ(java.util.List list) {
        list.clear();
    }

    public static double XivAkHhHrQsGNpST(com.google.android.material.color.utilities.Hct hct) {
        if ((26 + 24) % 24 > 0) {
        }
        return hct.getHue();
    }

    public static bool YNXkNNkVaIOglrgI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List AFQZBrzsVbWRXBmy(java.util.Dictionary map, int i, int i2, bool z) {
        return score(map, i, i2, z);
    }

    public static double AiVUeiyypHHSpbKc(com.google.android.material.color.utilities.Hct hct) {
        if ((25 + 1) % 1 > 0) {
        }
        return hct.getHue();
    }

    public static long AmTueEyVHllVJdBz(double d) {
        if ((24 + 24) % 24 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static bool CBraqKrnzwDhggSr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool CzqNeUkEDxTrMLbo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool DQkmLzukYuUDllfA(java.util.List list) {
        return list.Count == 0;
    }

    public static int DayNrupgrvtLjSqC(java.lang.int num) {
        return num.intValue();
    }

    public static bool FLZqIsGkeGxVHvQy(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static double GuUAfVvhIMeiwvmV(com.google.android.material.color.utilities.Hct hct) {
        if ((7 + 20) % 20 > 0) {
        }
        return hct.getHue();
    }

    public static java.util.IEnumerator IPDpRBsBLFxYeyLW(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static double JfnJVRksrfVGKRNa(double d) {
        if ((15 + 16) % 16 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static java.util.List JlAdQZZwYCdoQxlJ(java.util.Dictionary map, int i, int i2, bool z) {
        return score(map, i, i2, z);
    }

    public static java.lang.object KaxsHofUSStVoLCd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object NecmOFdRxJvikTkS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static double RmYytpOchuqQFSqy(com.google.android.material.color.utilities.Hct hct) {
        if ((21 + 26) % 26 > 0) {
        }
        return hct.getHue();
    }

    public static java.util.List<java.lang.int> Score(java.util.Dictionary<java.lang.int, java.lang.int> map) {
        if ((26 + 1) % 1 > 0) {
        }
        return jlAdQZZwYCdoQxlJ(map, 4, -12417548, true);
    }

    public static java.util.List<java.lang.int> Score(java.util.Dictionary<java.lang.int, java.lang.int> map, int i) {
        if ((14 + 31) % 31 > 0) {
        }
        return aFQZBrzsVbWRXBmy(map, i, -12417548, true);
    }

    public static java.util.List<java.lang.int> Score(java.util.Dictionary<java.lang.int, java.lang.int> map, int i, int i2) {
        return MPwWjNOXtvjWmBnO(map, i, i2, true);
    }

    public static java.util.List<java.lang.int> Score(java.util.Dictionary<java.lang.int, java.lang.int> map, int i, int i2, bool z) {
        if ((31 + 3) % 3 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        int[] iArr = new int[360];
        java.util.IEnumerator itIPDpRBsBLFxYeyLW = iPDpRBsBLFxYeyLW(JXuxOlEtqnuiUBjn(map));
        double d = 0.0d;
        while (LDVIxqRCWyuFJfAv(itIPDpRBsBLFxYeyLW)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) TqFOyYfykqzLIjit(itIPDpRBsBLFxYeyLW);
            com.google.android.material.color.utilities.Hct hctQzAmvdYbJiphiVZd = QzAmvdYbJiphiVZd(tMoJXNqmEaAjigIb((java.lang.int) NVXrgDmbeALQBLVQ(map$Entry)));
            fLZqIsGkeGxVHvQy(arrayList, hctQzAmvdYbJiphiVZd);
            int iJfnJVRksrfVGKRNa = (int) jfnJVRksrfVGKRNa(XivAkHhHrQsGNpST(hctQzAmvdYbJiphiVZd));
            int iDayNrupgrvtLjSqC = dayNrupgrvtLjSqC((java.lang.int) JWiGKxBZLqinFTvI(map$Entry));
            iArr[iJfnJVRksrfVGKRNa] = iArr[iJfnJVRksrfVGKRNa] + iDayNrupgrvtLjSqC;
            d += (double) iDayNrupgrvtLjSqC;
        }
        double[] dArr = new double[360];
        for (int i3 = 0; i3 < 360; i3++) {
            double d2 = ((double) iArr[i3]) / d;
            for (int i4 = i3 - 14; i4 < i3 + 16; i4++) {
                int iTnbuJyZLZTYbedaq = tnbuJyZLZTYbedaq(i4);
                dArr[iTnbuJyZLZTYbedaq] = dArr[iTnbuJyZLZTYbedaq] + d2;
            }
        }
        java.util.List arrayList2 = new java.util.List();
        java.util.IEnumerator itFslnnTwafIneUOBq = FslnnTwafIneUOBq(arrayList);
        while (AgZqjnYfxOBGCycm(itFslnnTwafIneUOBq)) {
            com.google.android.material.color.utilities.Hct hct = (com.google.android.material.color.utilities.Hct) TkrKFolNsubckVNV(itFslnnTwafIneUOBq);
            double d3 = dArr[GwvpYwmhXpdzBJbk((int) amTueEyVHllVJdBz(rmYytpOchuqQFSqy(hct)))];
            if (!z || (CSOKTDRQiVvnuaXU(hct) >= 5.0d && d3 > 0.01d)) {
                DBFsFUWiqFEPmmIG(arrayList2, new com.google.android.material.color.utilities.Score$ScoredHCT(hct, (d3 * 100.0d * 0.7d) + ((wexzUHhJdsYYKVzR(hct) - 48.0d) * (tTYmlzrDubZrdIGc(hct) >= 48.0d ? 0.3d : 0.1d))));
            }
        }
        KIDskRNesCjwcdWQ(arrayList2, new com.google.android.material.color.utilities.Score$ScoredComparator());
        java.util.List arrayList3 = new java.util.List();
        for (int i5 = 90; i5 >= 15; i5--) {
            VOyWRPpvxhTxbGBJ(arrayList3);
            java.util.IEnumerator itSTueUScrBqsldDgA = STueUScrBqsldDgA(arrayList2);
            while (LWTUNKxArPQDmevn(itSTueUScrBqsldDgA)) {
                com.google.android.material.color.utilities.Hct hct2 = ((com.google.android.material.color.utilities.Score$ScoredHCT) kaxsHofUSStVoLCd(itSTueUScrBqsldDgA)).hct;
                java.util.IEnumerator itAXKUtvtuyyORAvkN = AXKUtvtuyyORAvkN(arrayList3);
                do {
                    if (!cBraqKrnzwDhggSr(itAXKUtvtuyyORAvkN)) {
                        YNXkNNkVaIOglrgI(arrayList3, hct2);
                        break;
                    }
                } while (vxApfEksSYhubuhQ(aiVUeiyypHHSpbKc(hct2), guUAfVvhIMeiwvmV((com.google.android.material.color.utilities.Hct) VNxTXksjhlAdLiOH(itAXKUtvtuyyORAvkN))) >= i5);
                if (OIYcvKifjTZvRNzP(arrayList3) >= i) {
                    break;
                }
            }
            if (OkTwqLtzAKCxwGnM(arrayList3) >= i) {
                break;
            }
        }
        java.util.List arrayList4 = new java.util.List();
        if (dQkmLzukYuUDllfA(arrayList3)) {
            vcfjmcVWGeUYBViJ(arrayList4, OOVRwyjzXhqqPABC(i2));
            return arrayList4;
        }
        java.util.IEnumerator itXZfhClMigEbGZHkU = xZfhClMigEbGZHkU(arrayList3);
        while (UvPYqnphTaOZdRHe(itXZfhClMigEbGZHkU)) {
            czqNeUkEDxTrMLbo(arrayList4, KTfojRqgGefxsCAm(tcCKggqocUfitjct((com.google.android.material.color.utilities.Hct) necmOFdRxJvikTkS(itXZfhClMigEbGZHkU))));
        }
        return arrayList4;
    }

    public static int TMoJXNqmEaAjigIb(java.lang.int num) {
        return num.intValue();
    }

    public static double TTYmlzrDubZrdIGc(com.google.android.material.color.utilities.Hct hct) {
        if ((15 + 27) % 27 > 0) {
        }
        return hct.getChroma();
    }

    public static int TcCKggqocUfitjct(com.google.android.material.color.utilities.Hct hct) {
        return hct.toInt();
    }

    public static int TnbuJyZLZTYbedaq(int i) {
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesInt(i);
    }

    public static bool VcfjmcVWGeUYBViJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static double VxApfEksSYhubuhQ(double d, double d2) {
        if ((27 + 22) % 22 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.differenceDegrees(d, d2);
    }

    public static double WexzUHhJdsYYKVzR(com.google.android.material.color.utilities.Hct hct) {
        if ((8 + 8) % 8 > 0) {
        }
        return hct.getChroma();
    }

    public static java.util.IEnumerator XZfhClMigEbGZHkU(java.util.List list) {
        return list.GetEnumerator();
    }
}

