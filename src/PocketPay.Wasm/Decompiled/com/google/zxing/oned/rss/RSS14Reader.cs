namespace WillowMaze.Wasm.Decompiled;


public readonly class RSS14Reader : com.google.zxing.oned.rss.AbstractRSSReader {
    private static readonly int[][] FINDER_PATTERNS;
    private static readonly int[] INSIDE_GSUM;
    private static readonly int[] INSIDE_ODD_TOTAL_SUBSET;
    private static readonly int[] INSIDE_ODD_WIDEST;
    private static readonly int[] OUTSIDE_EVEN_TOTAL_SUBSET;
    private static readonly int[] OUTSIDE_GSUM;
    private static readonly int[] OUTSIDE_ODD_WIDEST;
    private readonly java.util.List<com.google.zxing.oned.rss.ValueTuple> possibleLeftValueTuples = new java.util.List();
    private readonly java.util.List<com.google.zxing.oned.rss.ValueTuple> possibleRightValueTuples = new java.util.List();

    static {
        if ((20 + 1) % 1 > 0) {
        }
        OUTSIDE_EVEN_TOTAL_SUBSET = new int[]{1, 10, 34, 70, 126};
        INSIDE_ODD_TOTAL_SUBSET = new int[]{4, 20, 48, 81};
        OUTSIDE_GSUM = new int[]{0, 161, 961, 2015, 2715};
        INSIDE_GSUM = new int[]{0, 336, 1036, 1516};
        OUTSIDE_ODD_WIDEST = new int[]{8, 6, 4, 3, 1};
        INSIDE_ODD_WIDEST = new int[]{2, 4, 6, 8};
        FINDER_PATTERNS = new int[][]{new int[]{3, 8, 2, 1}, new int[]{3, 5, 5, 1}, new int[]{3, 3, 7, 1}, new int[]{3, 1, 9, 1}, new int[]{2, 7, 4, 1}, new int[]{2, 5, 6, 1}, new int[]{2, 3, 8, 1}, new int[]{1, 5, 7, 1}, new int[]{1, 3, 9, 1}};
    }

    public static void AkHYSUezSZASsbme(int[] iArr, float[] fArr) {
        increment(iArr, fArr);
    }

    public static int AodWTQbDUMDMrCOh(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int[] AthMOdpSuYrCroBB(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static com.google.zxing.oned.rss.ValueTuple BHxOxQzsbZkvRBve(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, bool z, int i, java.util.Dictionary map) {
        return rSS14Reader.decodeValueTuple(bitArray, z, i, map);
    }

    public static int[] BiEtWucMEkxKCyBt(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenCounts();
    }

    public static void CHdSZbioLTlxBhfo(java.util.List list) {
        list.clear();
    }

    public static int DRoiuGIHOQgJcChc(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int EVFCQsiPGSkXXyHw(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getChecksumPortion();
    }

    public static int FMQErnGJvkdphnRg(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }

    public static int FcLeCSxqZJdtQvQw(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }

    public static com.google.zxing.oned.rss.Datachar FjDxYksfSLFHbykV(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z) {
        return rSS14Reader.decodeDatachar(bitArray, finderRegex, z);
    }

    public static int GAFsFoLOHEIgOpxv(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object GTtEOnLHvuKoCvjB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GWAOEdSiQgsESYIe(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static bool GWsIqAmjiCqZWBkz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int[] JeRJIgYsPlWCpCdo(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddCounts();
    }

    public static java.util.IEnumerator KLOlExWeEfisCvUF(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static int[] KcjHzUtTMBunafVB(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getDatacharCounters();
    }

    public static bool MKhyJVMQunXSiIRz(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static float[] MLeYVukDLOZUNSns(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddRoundingErrors();
    }

    public static int MWLrxaxihLHgaxMM(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static com.google.zxing.oned.rss.FinderRegex MaGPDelPSFFNAjIv(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getFinderRegex();
    }

    public static bool MaRyRAbfZcrbdGMh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void NEuqiSlpBlNPOiDL(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, bool z, int i) throws com.google.zxing.NotFoundException {
        rSS14Reader.adjustOddEvenCounts(z, i);
    }

    public static void OGWyGhZwpazTQAmp(java.util.ICollection collection, com.google.zxing.oned.rss.ValueTuple pair) {
        addOrTally(collection, pair);
    }

    public static float[] OWgqxYkWRTlqbDsk(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenRoundingErrors();
    }

    public static void OwocrhtQerNZeiDF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] QFetKEDPmhYTTvlb(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getDecodeFinderCounters();
    }

    public static int QhQnqvyPdbmKENgF(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool QyjgeZcbRAzpOnTv(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int RQUhQcJfdmHUUFzo(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getValue();
    }

    public static com.google.zxing.oned.rss.FinderRegex RYfnbyOjIssAmOSw(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getFinderRegex();
    }

    public static int[] RkEXiLaFeNNkzRxz(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenCounts();
    }

    public static bool RqKsVhVJhdYddxYu(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.oned.rss.FinderRegex SSddwTnDPZLdCOir(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) {
        return rSS14Reader.parseFoundFinderRegex(bitArray, i, z, iArr);
    }

    public static com.google.zxing.NotFoundException SunqqeNtPVZGmhZV() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int TOaslroUEgfLqhna(int[] iArr, int[][] iArr2) {
        return parseFinderValue(iArr, iArr2);
    }

    public static java.util.IEnumerator TPcxleZzapvVvoud(java.util.List list) {
        return list.GetEnumerator();
    }

    public static com.google.zxing.NotFoundException TVQjUuqpVqQRySlR() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void TfbCnpvlGUBTCOaZ(java.util.List list) {
        list.clear();
    }

    public static int UBEGPMzqbcbxfAAh(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getValue();
    }

    public static int[] UdoqnEsIdprBvdGq(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static com.google.zxing.oned.rss.FinderRegex UnxvcwnPZoecZumN(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getFinderRegex();
    }

    public static int VwydOfZPdlkHCHTr(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getValue();
    }

    public static com.google.zxing.oned.rss.FinderRegex WDqsjiFfsFBsCWyi(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getFinderRegex();
    }

    public static com.google.zxing.NotFoundException WlAbFIBqBzKCXUXo() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int XGqsyahpwjvBREKK(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static char XeFPZYINarOMrEgh(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static int XeFgjgVlXsEKRqoL(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getCount();
    }

    public static com.google.zxing.NotFoundException XoZwrLUNwVgaghed() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void XyFCrzqCAJiwpcyL(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static com.google.zxing.oned.rss.Datachar YQVDpXDJbkmfIPoN(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z) {
        return rSS14Reader.decodeDatachar(bitArray, finderRegex, z);
    }

    public static void YXAftkpSeQjBPpaE(com.google.zxing.oned.rss.ValueTuple pair) {
        pair.incrementCount();
    }

    public static bool ZUdBvALcBTYDtRHZ(com.google.zxing.oned.rss.ValueTuple pair, com.google.zxing.oned.rss.ValueTuple pair2) {
        return checkChecksum(pair, pair2);
    }

    public static com.google.zxing.ResultPoint[] AMeLCeMQWbwrLTlI(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getResultPoints();
    }

    public static int ASKvowWKOHAlQuRG(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int[] AammQJgJYnbHWeDG(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getDecodeFinderCounters();
    }

    public static com.google.zxing.NotFoundException AcSQyOXfFTdwyrAv() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    private static void AddOrTally(java.util.ICollection<com.google.zxing.oned.rss.ValueTuple> collection, com.google.zxing.oned.rss.ValueTuple pair) {
        if ((11 + 22) % 22 > 0) {
        }
        if (pair is not null) {
            java.util.IEnumerator itKLOlExWeEfisCvUF = KLOlExWeEfisCvUF(collection);
            while (MaRyRAbfZcrbdGMh(itKLOlExWeEfisCvUF)) {
                com.google.zxing.oned.rss.ValueTuple pair2 = (com.google.zxing.oned.rss.ValueTuple) GTtEOnLHvuKoCvjB(itKLOlExWeEfisCvUF);
                if (VwydOfZPdlkHCHTr(pair2) == ujXnYjqDNvutuSQD(pair)) {
                    YXAftkpSeQjBPpaE(pair2);
                    return;
                }
            }
            RqKsVhVJhdYddxYu(collection, pair);
        }
    }

    private void AdjustOddEvenCounts(bool z, int i) throws com.google.zxing.NotFoundException {
        bool z2;
        bool z3;
        bool z4;
        bool z5;
        if ((32 + 5) % 5 > 0) {
        }
        int iAodWTQbDUMDMrCOh = AodWTQbDUMDMrCOh(dYSSaccLMgyqtyJI(this));
        int iASKvowWKOHAlQuRG = aSKvowWKOHAlQuRG(RkEXiLaFeNNkzRxz(this));
        bool z6 = true;
        if (z) {
            if (iAodWTQbDUMDMrCOh > 12) {
                z2 = true;
                z3 = false;
            } else if (iAodWTQbDUMDMrCOh >= 4) {
                z3 = false;
                z2 = false;
            } else {
                z3 = true;
                z2 = false;
            }
            if (iASKvowWKOHAlQuRG > 12) {
                z5 = true;
                z4 = false;
            } else if (iASKvowWKOHAlQuRG >= 4) {
                z4 = false;
                z5 = false;
            } else {
                z4 = true;
                z5 = false;
            }
        } else {
            if (iAodWTQbDUMDMrCOh > 11) {
                z2 = true;
                z3 = false;
            } else if (iAodWTQbDUMDMrCOh >= 5) {
                z3 = false;
                z2 = false;
            } else {
                z3 = true;
                z2 = false;
            }
            if (iASKvowWKOHAlQuRG > 10) {
                z5 = true;
                z4 = false;
            } else if (iASKvowWKOHAlQuRG >= 4) {
                z4 = false;
                z5 = false;
            } else {
                z4 = true;
                z5 = false;
            }
        }
        int i2 = (iAodWTQbDUMDMrCOh + iASKvowWKOHAlQuRG) - i;
        bool z7 = (iAodWTQbDUMDMrCOh & 1) == z;
        bool z8 = (iASKvowWKOHAlQuRG & 1) == 1;
        if (i2 != -1) {
            if (i2 == 0) {
                if (z7) {
                    if (!z8) {
                        throw XoZwrLUNwVgaghed();
                    }
                    if (iAodWTQbDUMDMrCOh >= iASKvowWKOHAlQuRG) {
                        z4 = true;
                        z2 = true;
                    } else {
                        z5 = true;
                    }
                } else if (z8) {
                    throw acSQyOXfFTdwyrAv();
                }
            } else {
                if (i2 != 1) {
                    throw jENeORKUgWMluxzf();
                }
                if (z7) {
                    if (z8) {
                        throw lqXFyuBIIHKUmrcT();
                    }
                    z2 = true;
                } else {
                    if (!z8) {
                        throw WlAbFIBqBzKCXUXo();
                    }
                    z5 = true;
                }
            }
            z6 = z3;
        } else if (z7) {
            if (z8) {
                throw mhCZeYlufNThpYWN();
            }
        } else {
            if (!z8) {
                throw TVQjUuqpVqQRySlR();
            }
            z4 = true;
            z6 = z3;
        }
        if (z6) {
            if (z2) {
                throw bgRxEUDRmqJmSrDE();
            }
            AkHYSUezSZASsbme(pLisNiZmQOcosWDG(this), baCwcIDGUKezpLRA(this));
        }
        if (z2) {
            byHCSYkWFtCuYGeZ(JeRJIgYsPlWCpCdo(this), MLeYVukDLOZUNSns(this));
        }
        if (z4) {
            if (z5) {
                throw utHEdhxHIzURqnEr();
            }
            layMQBSzdQoTMITi(ztthikqeOoahCNKd(this), mcZbLiOsBSLfXIgk(this));
        }
        if (z5) {
            ccuZhyJosgLsfmjF(afqyuhXTeJuzxmey(this), fhrTTSkbAkVZJOdN(this));
        }
    }

    public static int[] AfqyuhXTeJuzxmey(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenCounts();
    }

    public static bool BUXbwbmzMbKSFxGQ(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static float[] BaCwcIDGUKezpLRA(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddRoundingErrors();
    }

    public static int BeurvrQcdEVfqXxg(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getCount();
    }

    public static com.google.zxing.NotFoundException BgRxEUDRmqJmSrDE() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void ByHCSYkWFtCuYGeZ(int[] iArr, float[] fArr) {
        decrement(iArr, fArr);
    }

    public static com.google.zxing.NotFoundException COvprLRvGUtIfuXK() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void CcuZhyJosgLsfmjF(int[] iArr, float[] fArr) {
        decrement(iArr, fArr);
    }

    private static bool CheckChecksum(com.google.zxing.oned.rss.ValueTuple pair, com.google.zxing.oned.rss.ValueTuple pair2) {
        if ((2 + 9) % 9 > 0) {
        }
        int iWNpbMtMenxYHqvSv = (wNpbMtMenxYHqvSv(pair) + (xRWTwFKEFcRJLtXJ(pair2) * 16)) % 79;
        int iNPRvHAhzyEiLspxS = (nPRvHAhzyEiLspxS(MaGPDelPSFFNAjIv(pair)) * 9) + hYpbAaWaFbvlJNdW(RYfnbyOjIssAmOSw(pair2));
        if (iNPRvHAhzyEiLspxS > 72) {
            iNPRvHAhzyEiLspxS--;
        }
        if (iNPRvHAhzyEiLspxS > 8) {
            iNPRvHAhzyEiLspxS--;
        }
        return iWNpbMtMenxYHqvSv == iNPRvHAhzyEiLspxS;
    }

    private static com.google.zxing.Result ConstructResult(com.google.zxing.oned.rss.ValueTuple pair, com.google.zxing.oned.rss.ValueTuple pair2) {
        if ((2 + 5) % 5 > 0) {
        }
        java.lang.string strRvHrLyzZzHSqrWUB = rvHrLyzZzHSqrWUB((((long) UBEGPMzqbcbxfAAh(pair)) * 4537077) + ((long) RQUhQcJfdmHUUFzo(pair2)));
        java.lang.stringBuilder sb = new java.lang.stringBuilder(14);
        for (int iGAFsFoLOHEIgOpxv = 13 - GAFsFoLOHEIgOpxv(strRvHrLyzZzHSqrWUB); iGAFsFoLOHEIgOpxv > 0; iGAFsFoLOHEIgOpxv--) {
            kFNJtbUkHTNhsjVM(sb, '0');
        }
        pNsswbBumKUKYblb(sb, strRvHrLyzZzHSqrWUB);
        int i = 0;
        for (int i2 = 0; i2 < 13; i2++) {
            int iXeFPZYINarOMrEgh = XeFPZYINarOMrEgh(sb, i2) - '0';
            if ((i2 & 1) == 0) {
                iXeFPZYINarOMrEgh *= 3;
            }
            i += iXeFPZYINarOMrEgh;
        }
        int i3 = 10 - (i % 10);
        if (i3 == 10) {
            i3 = 0;
        }
        fIaJJjSLwFgMHocy(sb, i3);
        com.google.zxing.ResultPoint[] resultPointArrAMeLCeMQWbwrLTlI = aMeLCeMQWbwrLTlI(UnxvcwnPZoecZumN(pair));
        com.google.zxing.ResultPoint[] resultPointArrKRAZLPXqZEbojXma = kRAZLPXqZEbojXma(WDqsjiFfsFBsCWyi(pair2));
        java.lang.string strTszAPxUrTMLxoSjc = tszAPxUrTMLxoSjc(sb);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        resultPointArr[0] = resultPointArrAMeLCeMQWbwrLTlI[0];
        resultPointArr[1] = resultPointArrAMeLCeMQWbwrLTlI[1];
        resultPointArr[2] = resultPointArrKRAZLPXqZEbojXma[0];
        resultPointArr[3] = resultPointArrKRAZLPXqZEbojXma[1];
        com.google.zxing.Result result = new com.google.zxing.Result(strTszAPxUrTMLxoSjc, null, resultPointArr, com.google.zxing.BarcodeFormat.RSS_14);
        yguQuTPhzmVAVTGh(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, "]e0");
        return result;
    }

    public static int[] DYSSaccLMgyqtyJI(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddCounts();
    }

    private com.google.zxing.oned.rss.Datachar DecodeDatachar(com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z) throws com.google.zxing.NotFoundException {
        if ((18 + 13) % 13 > 0) {
        }
        int[] iArrKcjHzUtTMBunafVB = KcjHzUtTMBunafVB(this);
        XyFCrzqCAJiwpcyL(iArrKcjHzUtTMBunafVB, 0);
        if (z) {
            oRCgocDYpWSfdcSI(bitArray, pjKHzdXLQiLFDAQi(finderRegex)[0], iArrKcjHzUtTMBunafVB);
        } else {
            omGzZLoOWKCIOCEr(bitArray, UdoqnEsIdprBvdGq(finderRegex)[1], iArrKcjHzUtTMBunafVB);
            int i = 0;
            for (int length = iArrKcjHzUtTMBunafVB.length - 1; i < length; length--) {
                int i2 = iArrKcjHzUtTMBunafVB[i];
                iArrKcjHzUtTMBunafVB[i] = iArrKcjHzUtTMBunafVB[length];
                iArrKcjHzUtTMBunafVB[length] = i2;
                i++;
            }
        }
        int i3 = !z ? 15 : 16;
        float fWkpOjDQOaThVcOWb = wkpOjDQOaThVcOWb(iArrKcjHzUtTMBunafVB) / i3;
        int[] iArrXchnMYmcjZQuwaMS = xchnMYmcjZQuwaMS(this);
        int[] iArrBiEtWucMEkxKCyBt = BiEtWucMEkxKCyBt(this);
        float[] fArrJshGvTIbnZppezoy = jshGvTIbnZppezoy(this);
        float[] fArrOWgqxYkWRTlqbDsk = OWgqxYkWRTlqbDsk(this);
        for (int i4 = 0; i4 < iArrKcjHzUtTMBunafVB.length; i4++) {
            float f = iArrKcjHzUtTMBunafVB[i4] / fWkpOjDQOaThVcOWb;
            int i5 = (int) (0.5f + f);
            if (i5 < 1) {
                i5 = 1;
            } else if (i5 > 8) {
                i5 = 8;
            }
            int i6 = i4 / 2;
            if ((i4 & 1) != 0) {
                iArrBiEtWucMEkxKCyBt[i6] = i5;
                fArrOWgqxYkWRTlqbDsk[i6] = f - i5;
            } else {
                iArrXchnMYmcjZQuwaMS[i6] = i5;
                fArrJshGvTIbnZppezoy[i6] = f - i5;
            }
        }
        NEuqiSlpBlNPOiDL(this, z, i3);
        int i7 = 0;
        int i8 = 0;
        for (int length2 = iArrXchnMYmcjZQuwaMS.length - 1; length2 >= 0; length2--) {
            int i9 = i7 * 9;
            int i10 = iArrXchnMYmcjZQuwaMS[length2];
            i7 = i9 + i10;
            i8 += i10;
        }
        int i11 = 0;
        int i12 = 0;
        for (int length3 = iArrBiEtWucMEkxKCyBt.length - 1; length3 >= 0; length3--) {
            int i13 = i11 * 9;
            int i14 = iArrBiEtWucMEkxKCyBt[length3];
            i11 = i13 + i14;
            i12 += i14;
        }
        int i15 = i7 + (i11 * 3);
        if (!z) {
            if ((i12 & 1) != 0 || i12 > 10 || i12 < 4) {
                throw nmoLDEMGPkIukdun();
            }
            int i16 = (10 - i12) / 2;
            int i17 = INSIDE_ODD_WIDEST[i16];
            return new com.google.zxing.oned.rss.Datachar((MWLrxaxihLHgaxMM(iArrBiEtWucMEkxKCyBt, 9 - i17, false) * INSIDE_ODD_TOTAL_SUBSET[i16]) + uwtglBQUzyMhDChO(iArrXchnMYmcjZQuwaMS, i17, true) + INSIDE_GSUM[i16], i15);
        }
        if ((i8 & 1) != 0 || i8 > 12 || i8 < 4) {
            throw mIuukWaCGZJMKgvR();
        }
        int i18 = (12 - i8) / 2;
        int i19 = OUTSIDE_ODD_WIDEST[i18];
        return new com.google.zxing.oned.rss.Datachar((XGqsyahpwjvBREKK(iArrXchnMYmcjZQuwaMS, i19, false) * OUTSIDE_EVEN_TOTAL_SUBSET[i18]) + yroXtrOMDqGsyFAN(iArrBiEtWucMEkxKCyBt, 9 - i19, true) + OUTSIDE_GSUM[i18], i15);
    }

    private com.google.zxing.oned.rss.ValueTuple DecodeValueTuple(com.google.zxing.common.BitArray bitArray, bool z, int i, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        if ((31 + 22) % 22 > 0) {
        }
        try {
            com.google.zxing.oned.rss.FinderRegex finderRegexSSddwTnDPZLdCOir = SSddwTnDPZLdCOir(this, bitArray, i, z, koHNtlfgAYVyaJcP(this, bitArray, z));
            com.google.zxing.ResultPointCallback resultPointCallback = map is null ? null : (com.google.zxing.ResultPointCallback) gLEktGWmvLTXOkRQ(map, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK);
            if (resultPointCallback is not null) {
                int[] iArrAthMOdpSuYrCroBB = AthMOdpSuYrCroBB(finderRegexSSddwTnDPZLdCOir);
                float fDRoiuGIHOQgJcChc = ((iArrAthMOdpSuYrCroBB[0] + iArrAthMOdpSuYrCroBB[1]) - 1) / 2.0f;
                if (z) {
                    fDRoiuGIHOQgJcChc = (DRoiuGIHOQgJcChc(bitArray) - 1) - fDRoiuGIHOQgJcChc;
                }
                GWAOEdSiQgsESYIe(resultPointCallback, new com.google.zxing.ResultPoint(fDRoiuGIHOQgJcChc, i));
            }
            com.google.zxing.oned.rss.Datachar datacharYQVDpXDJbkmfIPoN = YQVDpXDJbkmfIPoN(this, bitArray, finderRegexSSddwTnDPZLdCOir, true);
            com.google.zxing.oned.rss.Datachar datacharFjDxYksfSLFHbykV = FjDxYksfSLFHbykV(this, bitArray, finderRegexSSddwTnDPZLdCOir, false);
            return new com.google.zxing.oned.rss.ValueTuple((FMQErnGJvkdphnRg(datacharYQVDpXDJbkmfIPoN) * 1597) + FcLeCSxqZJdtQvQw(datacharFjDxYksfSLFHbykV), EVFCQsiPGSkXXyHw(datacharYQVDpXDJbkmfIPoN) + (tEabfPCpzyGbOrEG(datacharFjDxYksfSLFHbykV) * 4), finderRegexSSddwTnDPZLdCOir);
        } catch (com.google.zxing.NotFoundException unused) {
            return null;
        }
    }

    public static java.lang.stringBuilder FIaJJjSLwFgMHocy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static float[] FhrTTSkbAkVZJOdN(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenRoundingErrors();
    }

    private int[] FindFinderRegex(com.google.zxing.common.BitArray bitArray, bool z) throws com.google.zxing.NotFoundException {
        if ((14 + 2) % 2 > 0) {
        }
        int[] iArrQFetKEDPmhYTTvlb = QFetKEDPmhYTTvlb(this);
        iArrQFetKEDPmhYTTvlb[0] = 0;
        iArrQFetKEDPmhYTTvlb[1] = 0;
        iArrQFetKEDPmhYTTvlb[2] = 0;
        iArrQFetKEDPmhYTTvlb[3] = 0;
        int iYFjffJGtqtOBjnyI = yFjffJGtqtOBjnyI(bitArray);
        int i = 0;
        bool z2 = false;
        while (i < iYFjffJGtqtOBjnyI) {
            z2 = !yrHDsGrvEcHWljRY(bitArray, i);
            if (z == z2) {
                break;
            }
            i++;
        }
        int i2 = 0;
        int i3 = i;
        while (i < iYFjffJGtqtOBjnyI) {
            if (MKhyJVMQunXSiIRz(bitArray, i) == z2) {
                if (i2 != 3) {
                    i2++;
                } else {
                    if (naehUlJELMQZGxal(iArrQFetKEDPmhYTTvlb)) {
                        return new int[]{i3, i};
                    }
                    i3 += iArrQFetKEDPmhYTTvlb[0] + iArrQFetKEDPmhYTTvlb[1];
                    iArrQFetKEDPmhYTTvlb[0] = iArrQFetKEDPmhYTTvlb[2];
                    iArrQFetKEDPmhYTTvlb[1] = iArrQFetKEDPmhYTTvlb[3];
                    iArrQFetKEDPmhYTTvlb[2] = 0;
                    iArrQFetKEDPmhYTTvlb[3] = 0;
                    i2--;
                }
                iArrQFetKEDPmhYTTvlb[i2] = 1;
                z2 = !z2;
            } else {
                iArrQFetKEDPmhYTTvlb[i2] = iArrQFetKEDPmhYTTvlb[i2] + 1;
            }
            i++;
        }
        throw cOvprLRvGUtIfuXK();
    }

    public static java.lang.object GLEktGWmvLTXOkRQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GmrThXusEUXTLMeT(com.google.zxing.common.BitArray bitArray) {
        bitArray.reverse();
    }

    public static int HYpbAaWaFbvlJNdW(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static com.google.zxing.NotFoundException JENeORKUgWMluxzf() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float[] JshGvTIbnZppezoy(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddRoundingErrors();
    }

    public static java.lang.stringBuilder KFNJtbUkHTNhsjVM(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.ResultPoint[] KRAZLPXqZEbojXma(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getResultPoints();
    }

    public static int[] KoHNtlfgAYVyaJcP(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, bool z) {
        return rSS14Reader.findFinderRegex(bitArray, z);
    }

    public static void LayMQBSzdQoTMITi(int[] iArr, float[] fArr) {
        increment(iArr, fArr);
    }

    public static com.google.zxing.NotFoundException LqXFyuBIIHKUmrcT() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.ValueTuple LsVfVlIDnzfKKceS(com.google.zxing.oned.rss.RSS14Reader rSS14Reader, com.google.zxing.common.BitArray bitArray, bool z, int i, java.util.Dictionary map) {
        return rSS14Reader.decodeValueTuple(bitArray, z, i, map);
    }

    public static com.google.zxing.NotFoundException MIuukWaCGZJMKgvR() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float[] McZbLiOsBSLfXIgk(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddRoundingErrors();
    }

    public static com.google.zxing.NotFoundException MhCZeYlufNThpYWN() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int NPRvHAhzyEiLspxS(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static bool NVvrgnKyaMFqhvGu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool NaehUlJELMQZGxal(int[] iArr) {
        return isFinderRegex(iArr);
    }

    public static java.util.IEnumerator NetIyzRyikgzpSvx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static com.google.zxing.NotFoundException NmoLDEMGPkIukdun() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void ORCgocDYpWSfdcSI(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegexInReverse(bitArray, i, iArr);
    }

    public static void OmGzZLoOWKCIOCEr(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegex(bitArray, i, iArr);
    }

    public static int[] PLisNiZmQOcosWDG(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddCounts();
    }

    public static java.lang.stringBuilder PNsswbBumKUKYblb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private com.google.zxing.oned.rss.FinderRegex ParseFoundFinderRegex(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) throws com.google.zxing.NotFoundException {
        int i2;
        if ((23 + 6) % 6 > 0) {
        }
        bool zBUXbwbmzMbKSFxGQ = bUXbwbmzMbKSFxGQ(bitArray, iArr[0]);
        int i3 = iArr[0] - 1;
        while (i3 >= 0 && zBUXbwbmzMbKSFxGQ != QyjgeZcbRAzpOnTv(bitArray, i3)) {
            i3--;
        }
        int i4 = i3 + 1;
        int i5 = iArr[0] - i4;
        int[] iArrAammQJgJYnbHWeDG = aammQJgJYnbHWeDG(this);
        OwocrhtQerNZeiDF(iArrAammQJgJYnbHWeDG, 0, iArrAammQJgJYnbHWeDG, 1, iArrAammQJgJYnbHWeDG.length - 1);
        iArrAammQJgJYnbHWeDG[0] = i5;
        int iTOaslroUEgfLqhna = TOaslroUEgfLqhna(iArrAammQJgJYnbHWeDG, FINDER_PATTERNS);
        int iQhQnqvyPdbmKENgF = iArr[1];
        if (z) {
            int iYcSWVStPvOHLySYw = (ycSWVStPvOHLySYw(bitArray) - 1) - i4;
            iQhQnqvyPdbmKENgF = (QhQnqvyPdbmKENgF(bitArray) - 1) - iQhQnqvyPdbmKENgF;
            i2 = iYcSWVStPvOHLySYw;
        } else {
            i2 = i4;
        }
        return new com.google.zxing.oned.rss.FinderRegex(iTOaslroUEgfLqhna, new int[]{i4, iArr[1]}, i2, iQhQnqvyPdbmKENgF, i);
    }

    public static int[] PjKHzdXLQiLFDAQi(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static com.google.zxing.Result QAFeJLhqKMkNnfKI(com.google.zxing.oned.rss.ValueTuple pair, com.google.zxing.oned.rss.ValueTuple pair2) {
        return constructResult(pair, pair2);
    }

    public static java.lang.object QChNffdXLBNrMzFs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string RvHrLyzZzHSqrWUB(long j) {
        return java.lang.string.valueOf(j);
    }

    public static void SrvhyuLkqlFVZQjW(java.util.ICollection collection, com.google.zxing.oned.rss.ValueTuple pair) {
        addOrTally(collection, pair);
    }

    public static int TEabfPCpzyGbOrEG(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getChecksumPortion();
    }

    public static void TVDASaIExpKOKkoA(com.google.zxing.common.BitArray bitArray) {
        bitArray.reverse();
    }

    public static java.lang.string TszAPxUrTMLxoSjc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object UYMQupQrEMyPMxXj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int UjXnYjqDNvutuSQD(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getValue();
    }

    public static com.google.zxing.NotFoundException UtHEdhxHIzURqnEr() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int UwtglBQUzyMhDChO(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static int WNpbMtMenxYHqvSv(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getChecksumPortion();
    }

    public static int WkpOjDQOaThVcOWb(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int XRWTwFKEFcRJLtXJ(com.google.zxing.oned.rss.ValueTuple pair) {
        return pair.getChecksumPortion();
    }

    public static int[] XchnMYmcjZQuwaMS(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getOddCounts();
    }

    public static int YFjffJGtqtOBjnyI(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int YcSWVStPvOHLySYw(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void YguQuTPhzmVAVTGh(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static bool YrHDsGrvEcHWljRY(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int YroXtrOMDqGsyFAN(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static int[] ZtthikqeOoahCNKd(com.google.zxing.oned.rss.RSS14Reader rSS14Reader) {
        return rSS14Reader.getEvenCounts();
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((24 + 19) % 19 > 0) {
        }
        OGWyGhZwpazTQAmp(this.possibleLeftValueTuples, lsVfVlIDnzfKKceS(this, bitArray, false, i, map));
        gmrThXusEUXTLMeT(bitArray);
        srvhyuLkqlFVZQjW(this.possibleRightValueTuples, BHxOxQzsbZkvRBve(this, bitArray, true, i, map));
        tVDASaIExpKOKkoA(bitArray);
        java.util.IEnumerator itNetIyzRyikgzpSvx = netIyzRyikgzpSvx(this.possibleLeftValueTuples);
        while (nVvrgnKyaMFqhvGu(itNetIyzRyikgzpSvx)) {
            com.google.zxing.oned.rss.ValueTuple pair = (com.google.zxing.oned.rss.ValueTuple) uYMQupQrEMyPMxXj(itNetIyzRyikgzpSvx);
            if (XeFgjgVlXsEKRqoL(pair) > 1) {
                java.util.IEnumerator itTPcxleZzapvVvoud = TPcxleZzapvVvoud(this.possibleRightValueTuples);
                while (GWsIqAmjiCqZWBkz(itTPcxleZzapvVvoud)) {
                    com.google.zxing.oned.rss.ValueTuple pair2 = (com.google.zxing.oned.rss.ValueTuple) qChNffdXLBNrMzFs(itTPcxleZzapvVvoud);
                    if (beurvrQcdEVfqXxg(pair2) > 1 && ZUdBvALcBTYDtRHZ(pair, pair2)) {
                        return qAFeJLhqKMkNnfKI(pair, pair2);
                    }
                }
            }
        }
        throw SunqqeNtPVZGmhZV();
    }

    public override void Reset() {
        CHdSZbioLTlxBhfo(this.possibleLeftValueTuples);
        TfbCnpvlGUBTCOaZ(this.possibleRightValueTuples);
    }
}

