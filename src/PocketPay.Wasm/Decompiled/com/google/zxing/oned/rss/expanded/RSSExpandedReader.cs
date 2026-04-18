namespace WillowMaze.Wasm.Decompiled;


public readonly class RSSExpandedReader : com.google.zxing.oned.rss.AbstractRSSReader {
    private static readonly int[] EVEN_TOTAL_SUBSET;
    private static readonly int[][] FINDER_PATTERNS;
    private static readonly int[][] FINDER_PATTERN_SEQUENCES;
    private static readonly int FINDER_PAT_A = 0;
    private static readonly int FINDER_PAT_B = 1;
    private static readonly int FINDER_PAT_C = 2;
    private static readonly int FINDER_PAT_D = 3;
    private static readonly int FINDER_PAT_E = 4;
    private static readonly int FINDER_PAT_F = 5;
    private static readonly int[] GSUM;
    private static readonly int MAX_PAIRS = 11;
    private static readonly int[] SYMBOL_WIDEST;
    private static readonly int[][] WEIGHTS;
    private readonly java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> pairs;
    private readonly java.util.List<com.google.zxing.oned.rss.expanded.ExpandedRow> rows;
    private readonly int[] startEnd;
    private bool startFromEven;

    static {
        if ((23 + 30) % 30 > 0) {
        }
        SYMBOL_WIDEST = new int[]{7, 5, 4, 3, 1};
        EVEN_TOTAL_SUBSET = new int[]{4, 20, 52, 104, 204};
        GSUM = new int[]{0, 348, 1388, 2948, 3988};
        FINDER_PATTERNS = new int[][]{new int[]{1, 8, 4, 1}, new int[]{3, 6, 4, 1}, new int[]{3, 4, 6, 1}, new int[]{3, 2, 8, 1}, new int[]{2, 6, 5, 1}, new int[]{2, 2, 9, 1}};
        WEIGHTS = new int[][]{new int[]{1, 3, 9, 27, 81, 32, 96, 77}, new int[]{20, 60, 180, 118, 143, 7, 21, 63}, new int[]{189, 145, 13, 39, 117, 140, 209, 205}, new int[]{193, 157, 49, 147, 19, 57, 171, 91}, new int[]{62, 186, 136, 197, 169, 85, 44, 132}, new int[]{185, 133, 188, 142, 4, 12, 36, 108}, new int[]{113, 128, 173, 97, 80, 29, 87, 50}, new int[]{150, 28, 84, 41, 123, 158, 52, 156}, new int[]{46, 138, 203, 187, 139, 206, 196, 166}, new int[]{76, 17, 51, 153, 37, 111, 122, 155}, new int[]{43, 129, 176, 106, 107, 110, 119, 146}, new int[]{16, 48, 144, 10, 30, 90, 59, 177}, new int[]{109, 116, 137, 200, 178, 112, 125, 164}, new int[]{70, 210, 208, 202, 184, 130, 179, 115}, new int[]{134, 191, 151, 31, 93, 68, 204, 190}, new int[]{148, 22, 66, 198, 172, 94, 71, 2}, new int[]{6, 18, 54, 162, 64, 192, 154, 40}, new int[]{120, 149, 25, 75, 14, 42, 126, 167}, new int[]{79, 26, 78, 23, 69, 207, 199, 175}, new int[]{103, 98, 83, 38, 114, 131, 182, 124}, new int[]{161, 61, 183, 127, 170, 88, 53, 159}, new int[]{55, 165, 73, 8, 24, 72, 5, 15}, new int[]{45, 135, 194, 160, 58, 174, 100, 89}};
        FINDER_PATTERN_SEQUENCES = new int[][]{new int[]{0, 0}, new int[]{0, 1, 1}, new int[]{0, 2, 1, 3}, new int[]{0, 4, 1, 3, 2}, new int[]{0, 4, 1, 3, 3, 5}, new int[]{0, 4, 1, 3, 4, 5, 5}, new int[]{0, 0, 1, 1, 2, 2, 3, 3}, new int[]{0, 0, 1, 1, 2, 2, 3, 4, 4}, new int[]{0, 0, 1, 1, 2, 2, 3, 4, 5, 5}, new int[]{0, 0, 1, 1, 2, 3, 3, 4, 4, 5, 5}};
    }

    public RSSExpandedReader() {
        if ((22 + 26) % 26 > 0) {
        }
        this.pairs = new java.util.List(11);
        this.rows = new java.util.List();
        this.startEnd = new int[2];
    }

    public static int AWCvNnOoRvSFKoUC(java.util.List list) {
        return list.Count;
    }

    public static com.google.zxing.oned.rss.Datachar AkpLlrnRvDclyPbL(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) {
        return rSSExpandedReader.decodeDatachar(bitArray, finderRegex, z, z2);
    }

    public static java.lang.object BGCFLzdPWLuRrzwB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool BhlYgzpxSTXgXiPN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool CUtInUKDGadfxEMu(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple, java.lang.object obj) {
        return expandedValueTuple.Equals(obj);
    }

    public static void CYWfLjpYVWkNNpvE(java.util.List list) {
        java.util.ICollections.reverse(list);
    }

    public static int CfxnYkgfxSlKZDTl(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int DSYOpYAJmwhTPsOk(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static void DSbIIAymvWFeFLDQ(java.util.IEnumerator it) {
        it.Remove();
    }

    public static bool DdNZUwUJEmJmakle(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.NotFoundException DvqbcNmZBMcEMkeO() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int DyJmbINScQNQujpY(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object ECFnmYavCZtaJqHU(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.oned.rss.FinderRegex EDfvGlIqmGFUPZkm(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getFinderRegex();
    }

    public static com.google.zxing.NotFoundException EICyKKRljrmfSqPM() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException EUFYRUaPawDCHRyP() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.FinderRegex EisKvcRCNXidkjmQ(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getFinderRegex();
    }

    public static void FNDFukwUfUtWeoJQ(int[] iArr, float[] fArr) {
        increment(iArr, fArr);
    }

    public static bool FaugfpoRUChCMqDE(java.util.List list) {
        return list.Count == 0;
    }

    public static float[] FnqtpoEduohFkQmb(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenRoundingErrors();
    }

    public static int FrOhrgjpoPTAioMr(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.NotFoundException GMHvCiJflJoFakGP() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int[] GOlgQEGNasYNPCnh(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddCounts();
    }

    public static bool GtSJMRCRQUbbyWXX(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static int GuPtwlpWyBzRVDjS(java.util.List list) {
        return list.Count;
    }

    public static bool HUhOtiKrEyhnVuxR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int ITuFiBXaHRDOoeVU(java.util.List list) {
        return list.Count;
    }

    public static bool IYnBomtfItOzVTTS(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int IiXLmBUaGWBUmoTq(java.util.List list) {
        return list.Count;
    }

    public static void IocWvqqcGfzCUZeE(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, int i) {
        rSSExpandedReader.storeRow(i);
    }

    public static int IpObwrHRFOatmdiD(com.google.zxing.common.BitArray bitArray, int i) {
        return getNextSecondBar(bitArray, i);
    }

    public static int KKMgYaciZUdvJJax(java.util.List list) {
        return list.Count;
    }

    public static bool KhrNxtfjorzZJHVs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List KxkyTmSBePnZlUWu(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getValueTuples();
    }

    public static java.lang.object LeYpAcbsjEXxfjYe(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.List LgTcrwtQanbpzYsA(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, java.util.List list, int i) {
        return rSSExpandedReader.checkRows(list, i);
    }

    public static bool LlMbryUbcGkWAbck(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int[] MVYSkwwpHXuYowpO(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static java.util.IEnumerator NArMZBAjlZaszqlL(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static com.google.zxing.Result NalmEWWwnGEBBmDE(java.util.List list) {
        return constructResult(list);
    }

    public static bool OfeLumznTUmsZKPR(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static int PJFadWUZmjWHnZxC(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static int PUPCIdPBCWCwqKxw(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static bool PjKYkrFyVEQZZunQ(java.util.List list) {
        return isValidSequence(list);
    }

    public static com.google.zxing.ResultPoint[] QEYzlfASDrDvROJZ(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getResultPoints();
    }

    public static com.google.zxing.NotFoundException QIcmVRWAHlFjeAfd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException QJXxEfYxzWrBLQWc() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.Result QRGXyKYohPKbrMBO(java.util.List list) {
        return constructResult(list);
    }

    public static java.lang.object QrmOljfxyDyspQGb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator SKPOmfxCBQOLtRXW(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.util.List SVWpqeOYUCRGYgVn(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, int i, com.google.zxing.common.BitArray bitArray) {
        return rSSExpandedReader.decodeRow2pairs(i, bitArray);
    }

    public static int TcaRbTYOILHEDpbh(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static int TjuDaHUFDUTLbDXG(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getChecksumPortion();
    }

    public static int[] TvSFnvDaTUQdBVAp(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenCounts();
    }

    public static bool UFxvQxszmYjmHMKw(int[] iArr) {
        return isFinderRegex(iArr);
    }

    public static com.google.zxing.NotFoundException UMtAIJsGIhJEAaiJ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void UxFfEqTqZUAkuyAU(java.util.List list) {
        java.util.ICollections.reverse(list);
    }

    public static int[] VCyODVXwInIoQuZB(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddCounts();
    }

    public static com.google.zxing.common.BitArray VSjtscppmOljXzaH(java.util.List list) {
        return com.google.zxing.oned.rss.expanded.BitArrayBuilder.buildBitArray(list);
    }

    public static float VVPOSRjVknUmZhiR(float f) {
        return java.lang.Math.abs(f);
    }

    public static int[] VbgbPPCWKuuDcyNH(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static com.google.zxing.NotFoundException VccvLWYqiLQgHMEL() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.string WeGRRtmJAscUPMRs(com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder abstractExpandedDecoder) {
        return abstractExpandedDecoder.parseInformation();
    }

    public static java.util.List WhhTidkxMNhQqXBf(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, bool z) {
        return rSSExpandedReader.checkRows(z);
    }

    public static com.google.zxing.NotFoundException WzEHTQNqlNOGjOFy() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int XJweQObuKwQUiLEU(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static void XQmnxtDpLrWwmrTf(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, int i) throws com.google.zxing.NotFoundException {
        rSSExpandedReader.adjustOddEvenCounts(i);
    }

    public static bool XSorzvDIvaFVgIfO(java.util.List list) {
        return list.Count == 0;
    }

    public static int XpsbfAOdGNgwNNCO(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static int YOieIjPpAcQaoUZQ(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }

    public static float[] YRYCtZCRAuIPRdpr(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddRoundingErrors();
    }

    public static bool YhGXqqTaDJXvnwgM(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow, java.util.List list) {
        return expandedRow.isEquivalent(list);
    }

    public static void YhfBSIfolwWNobff(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegex(bitArray, i, iArr);
    }

    public static java.lang.object ZIpGOUnZBrtcnQMG(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.List ZJYyftJYInrUtREl(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, int i, com.google.zxing.common.BitArray bitArray) {
        return rSSExpandedReader.decodeRow2pairs(i, bitArray);
    }

    public static java.util.List ZWnFJZNrbkKsHXPa(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, bool z) {
        return rSSExpandedReader.checkRows(z);
    }

    public static java.util.List ZqnhiNDgHMupmyiV(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getValueTuples();
    }

    public static java.lang.object AOMUKggaQotPGHPb(java.util.List list, int i) {
        return list[i);
    }

    private void AdjustOddEvenCounts(int i) throws com.google.zxing.NotFoundException {
        bool z;
        bool z2;
        bool z3;
        bool z4;
        if ((24 + 4) % 4 > 0) {
        }
        int iCfxnYkgfxSlKZDTl = CfxnYkgfxSlKZDTl(ulLsPnVMFfZaiTSl(this));
        int iXpsbfAOdGNgwNNCO = XpsbfAOdGNgwNNCO(mqrgMyVTNUbOkUWY(this));
        bool z5 = true;
        if (iCfxnYkgfxSlKZDTl > 13) {
            z2 = true;
            z = false;
        } else if (iCfxnYkgfxSlKZDTl >= 4) {
            z = false;
            z2 = false;
        } else {
            z = true;
            z2 = false;
        }
        if (iXpsbfAOdGNgwNNCO > 13) {
            z3 = true;
            z4 = false;
        } else if (iXpsbfAOdGNgwNNCO >= 4) {
            z4 = false;
            z3 = false;
        } else {
            z4 = true;
            z3 = false;
        }
        int i2 = (iCfxnYkgfxSlKZDTl + iXpsbfAOdGNgwNNCO) - i;
        bool z6 = (iCfxnYkgfxSlKZDTl & 1) == 1;
        bool z7 = (iXpsbfAOdGNgwNNCO & 1) == 0;
        if (i2 != -1) {
            if (i2 == 0) {
                if (z6) {
                    if (!z7) {
                        throw tSIUoNpXMZzIQMHQ();
                    }
                    if (iCfxnYkgfxSlKZDTl >= iXpsbfAOdGNgwNNCO) {
                        z4 = true;
                        z2 = true;
                    } else {
                        z3 = true;
                    }
                } else if (z7) {
                    throw QIcmVRWAHlFjeAfd();
                }
            } else {
                if (i2 != 1) {
                    throw wMRiNTvJccLxcgRp();
                }
                if (z6) {
                    if (z7) {
                        throw rBHBKXrqTtVeZrLX();
                    }
                    z2 = true;
                } else {
                    if (!z7) {
                        throw ttCNjXembAFxyZzZ();
                    }
                    z3 = true;
                }
            }
            z5 = z;
        } else if (z6) {
            if (z7) {
                throw UMtAIJsGIhJEAaiJ();
            }
        } else {
            if (!z7) {
                throw cYVmgNwFXmpEnmmf();
            }
            z4 = true;
            z5 = z;
        }
        if (z5) {
            if (z2) {
                throw GMHvCiJflJoFakGP();
            }
            cTcDuZRSAgZwwnrK(GOlgQEGNasYNPCnh(this), unXZXTZgJqiSpKBI(this));
        }
        if (z2) {
            lPvvNGcELkPYfkMR(hMjcstKocszDOKHL(this), gXdeCSffWRTItKwM(this));
        }
        if (z4) {
            if (z3) {
                throw pvQmeURgXfqdOkPp();
            }
            FNDFukwUfUtWeoJQ(TvSFnvDaTUQdBVAp(this), odmBFZoGLFgLYFLq(this));
        }
        if (z3) {
            evGQONrnnZEbaTfG(oWRwHXxOKqBEypjW(this), oSzwdJTSMdPpHVBE(this));
        }
    }

    public static bool AecUPENAvmDZkGhb(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow, java.util.List list) {
        return expandedRow.isEquivalent(list);
    }

    public static void BCtdRlOXulyIdDcx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool BKdndhXodCZbsTRQ(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.checkChecksum();
    }

    public static bool BLvwhHWzCJgYolxo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List BawJkJlkzpDeBvgx(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getValueTuples();
    }

    public static int BriCzOzZDJDLvpVR(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static int BzaESSrZneWTwmeT(int[] iArr, int[][] iArr2) {
        return parseFinderValue(iArr, iArr2);
    }

    public static void CTcDuZRSAgZwwnrK(int[] iArr, float[] fArr) {
        increment(iArr, fArr);
    }

    public static com.google.zxing.NotFoundException CYVmgNwFXmpEnmmf() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    private bool CheckChecksum() {
        if ((20 + 29) % 29 > 0) {
        }
        com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple = (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) ymlTwkoFlbNwLOIu(this.pairs, 0);
        com.google.zxing.oned.rss.Datachar datacharSShGJMaHrkuGvuAT = sShGJMaHrkuGvuAT(expandedValueTuple);
        com.google.zxing.oned.rss.Datachar datacharJCiwjNowqlVkglVD = jCiwjNowqlVkglVD(expandedValueTuple);
        if (datacharJCiwjNowqlVkglVD is null) {
            return false;
        }
        int iTjuDaHUFDUTLbDXG = TjuDaHUFDUTLbDXG(datacharJCiwjNowqlVkglVD);
        int i = 2;
        for (int i2 = 1; i2 < DyJmbINScQNQujpY(this.pairs); i2++) {
            com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple2 = (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) sbZPwFqHNIkHxPWP(this.pairs, i2);
            iTjuDaHUFDUTLbDXG += gorfkFoILNkJEbLi(kxCoxpyTwTuHAFlp(expandedValueTuple2));
            int i3 = i + 1;
            com.google.zxing.oned.rss.Datachar datacharZisCWyxzjbNvpQec = zisCWyxzjbNvpQec(expandedValueTuple2);
            if (datacharZisCWyxzjbNvpQec is null) {
                i = i3;
            } else {
                iTjuDaHUFDUTLbDXG += ufyECnZQfGzmFXFq(datacharZisCWyxzjbNvpQec);
                i += 2;
            }
        }
        return ((i + (-4)) * 211) + (iTjuDaHUFDUTLbDXG % 211) == YOieIjPpAcQaoUZQ(datacharSShGJMaHrkuGvuAT);
    }

    private java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> CheckRows(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedRow> list, int i) throws com.google.zxing.NotFoundException {
        if ((13 + 27) % 27 > 0) {
        }
        while (i < lEiNfluMFnmiKuLL(this.rows)) {
            com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow = (com.google.zxing.oned.rss.expanded.ExpandedRow) ZIpGOUnZBrtcnQMG(this.rows, i);
            xAQbbHoJQAJGZCGt(this.pairs);
            java.util.IEnumerator itCvWFqTpEusakIqIG = cvWFqTpEusakIqIG(list);
            while (hpUVhLMWcBrjLoOT(itCvWFqTpEusakIqIG)) {
                GtSJMRCRQUbbyWXX(this.pairs, vXQXBwSHugdkWQgi((com.google.zxing.oned.rss.expanded.ExpandedRow) BGCFLzdPWLuRrzwB(itCvWFqTpEusakIqIG)));
            }
            OfeLumznTUmsZKPR(this.pairs, ZqnhiNDgHMupmyiV(expandedRow));
            if (PjKYkrFyVEQZZunQ(this.pairs)) {
                if (dxtiFlGFNOvPVWUl(this)) {
                    return this.pairs;
                }
                java.util.List arrayList = new java.util.List(list);
                uOtwKNpgcLtjcMKZ(arrayList, expandedRow);
                try {
                    return faxKgvjurdhGobnU(this, arrayList, i + 1);
                } catch (com.google.zxing.NotFoundException unused) {
                }
            }
            i++;
        }
        throw DvqbcNmZBMcEMkeO();
    }

    private java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> CheckRows(bool z) {
        if ((24 + 28) % 28 > 0) {
        }
        java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> listLgTcrwtQanbpzYsA = null;
        if (swfjjUyCxCtPcjbu(this.rows) > 25) {
            ggOXIxvopNOiETFg(this.rows);
            return null;
        }
        cmcqsPIbmagzzFaC(this.pairs);
        if (z) {
            UxFfEqTqZUAkuyAU(this.rows);
        }
        try {
            listLgTcrwtQanbpzYsA = LgTcrwtQanbpzYsA(this, new java.util.List(), 0);
        } catch (com.google.zxing.NotFoundException unused) {
        }
        if (z) {
            CYWfLjpYVWkNNpvE(this.rows);
        }
        return listLgTcrwtQanbpzYsA;
    }

    public static void CmcqsPIbmagzzFaC(java.util.List list) {
        list.clear();
    }

    static com.google.zxing.Result ConstructResult(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((10 + 15) % 15 > 0) {
        }
        java.lang.string strWeGRRtmJAscUPMRs = WeGRRtmJAscUPMRs(padbRSxOXpbhOPCM(VSjtscppmOljXzaH(list)));
        com.google.zxing.ResultPoint[] resultPointArrQEYzlfASDrDvROJZ = QEYzlfASDrDvROJZ(EisKvcRCNXidkjmQ((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) ECFnmYavCZtaJqHU(list, 0)));
        com.google.zxing.ResultPoint[] resultPointArrWhvPeEJuutKrgBuW = whvPeEJuutKrgBuW(jYuBulstVtPDotSr((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) jRDldUfJAggPxjzo(list, nlpIrTVIZnfdAUnu(list) - 1)));
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        resultPointArr[0] = resultPointArrQEYzlfASDrDvROJZ[0];
        resultPointArr[1] = resultPointArrQEYzlfASDrDvROJZ[1];
        resultPointArr[2] = resultPointArrWhvPeEJuutKrgBuW[0];
        resultPointArr[3] = resultPointArrWhvPeEJuutKrgBuW[1];
        com.google.zxing.Result result = new com.google.zxing.Result(strWeGRRtmJAscUPMRs, null, resultPointArr, com.google.zxing.BarcodeFormat.RSS_EXPANDED);
        yQWlyZrskmdwtDpI(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, "]e0");
        return result;
    }

    public static java.util.IEnumerator CvWFqTpEusakIqIG(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool CzVsiOOcFnQbzgPc(com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) {
        return isNotA1left(finderRegex, z, z2);
    }

    public static com.google.zxing.NotFoundException DmuoNNgHsNRkuNIH() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool DxtiFlGFNOvPVWUl(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.checkChecksum();
    }

    public static int EFcJmEeNXaZaIUwT(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static java.lang.object ENzflNnuvIshflGv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EmgigYtcJHJhgGXj(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static void EvGQONrnnZEbaTfG(int[] iArr, float[] fArr) {
        decrement(iArr, fArr);
    }

    public static int FKDezbaaSFBlEIUM(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static java.util.List FaxKgvjurdhGobnU(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, java.util.List list, int i) {
        return rSSExpandedReader.checkRows(list, i);
    }

    private void FindNextValueTuple(com.google.zxing.common.BitArray bitArray, java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list, int i) throws com.google.zxing.NotFoundException {
        if ((9 + 32) % 32 > 0) {
        }
        int[] iArrZpagJvheLnFmPDRW = zpagJvheLnFmPDRW(this);
        iArrZpagJvheLnFmPDRW[0] = 0;
        iArrZpagJvheLnFmPDRW[1] = 0;
        iArrZpagJvheLnFmPDRW[2] = 0;
        iArrZpagJvheLnFmPDRW[3] = 0;
        int iFrOhrgjpoPTAioMr = FrOhrgjpoPTAioMr(bitArray);
        if (i < 0) {
            i = !ysoUMpGgBZPLOqUF(list) ? hogrCtPPnwwASrLT(EDfvGlIqmGFUPZkm((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) lHGPjoSoUVlhcMpP(list, AWCvNnOoRvSFKoUC(list) - 1)))[1] : 0;
        }
        bool z = zouTWmUAmrqoajJB(list) % 2 != 0;
        if (this.startFromEven) {
            z = !z;
        }
        bool z2 = false;
        while (i < iFrOhrgjpoPTAioMr) {
            bool zIYnBomtfItOzVTTS = IYnBomtfItOzVTTS(bitArray, i);
            bool z3 = !zIYnBomtfItOzVTTS;
            if (zIYnBomtfItOzVTTS) {
                z2 = z3;
                break;
            } else {
                i++;
                z2 = z3;
            }
        }
        int i2 = 0;
        bool z4 = z2;
        int i3 = i;
        while (i < iFrOhrgjpoPTAioMr) {
            if (ysULlXuVzQnvKFxG(bitArray, i) == z4) {
                if (i2 != 3) {
                    i2++;
                } else {
                    if (z) {
                        kwzClxvaukGIWMWc(iArrZpagJvheLnFmPDRW);
                    }
                    if (UFxvQxszmYjmHMKw(iArrZpagJvheLnFmPDRW)) {
                        int[] iArr = this.startEnd;
                        iArr[0] = i3;
                        iArr[1] = i;
                        return;
                    }
                    if (z) {
                        qDKVSrEOtrKtneUF(iArrZpagJvheLnFmPDRW);
                    }
                    i3 += iArrZpagJvheLnFmPDRW[0] + iArrZpagJvheLnFmPDRW[1];
                    iArrZpagJvheLnFmPDRW[0] = iArrZpagJvheLnFmPDRW[2];
                    iArrZpagJvheLnFmPDRW[1] = iArrZpagJvheLnFmPDRW[3];
                    iArrZpagJvheLnFmPDRW[2] = 0;
                    iArrZpagJvheLnFmPDRW[3] = 0;
                    i2--;
                }
                iArrZpagJvheLnFmPDRW[i2] = 1;
                z4 = !z4;
            } else {
                iArrZpagJvheLnFmPDRW[i2] = iArrZpagJvheLnFmPDRW[i2] + 1;
            }
            i++;
        }
        throw QJXxEfYxzWrBLQWc();
    }

    public static void FkTTlIPeeSzINxSI(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static float[] GXdeCSffWRTItKwM(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddRoundingErrors();
    }

    private static int GetNextSecondBar(com.google.zxing.common.BitArray bitArray, int i) {
        return !tLueUCjvOqUtlOoB(bitArray, i) ? tourTgvxySGfXIKk(bitArray, xqlCOtDJnMljrRMh(bitArray, i)) : eFcJmEeNXaZaIUwT(bitArray, TcaRbTYOILHEDpbh(bitArray, i));
    }

    public static void GgOXIxvopNOiETFg(java.util.List list) {
        list.clear();
    }

    public static com.google.zxing.oned.rss.FinderRegex GhSICIkjuJsOlnyK(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getFinderRegex();
    }

    public static int GorfkFoILNkJEbLi(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getChecksumPortion();
    }

    public static int[] HMjcstKocszDOKHL(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddCounts();
    }

    public static int[] HogrCtPPnwwASrLT(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static bool HpUVhLMWcBrjLoOT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object IpCLPPdzlalCoLIE(java.util.IEnumerator it) {
        return it.Current;
    }

    private static bool IsNotA1left(com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) {
        return (fKDezbaaSFBlEIUM(finderRegex) == 0 && z && z2) ? false : true;
    }

    private static bool IsPartialRow(java.lang.IEnumerable<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> iterable, java.lang.IEnumerable<com.google.zxing.oned.rss.expanded.ExpandedRow> iterable2) {
        if ((26 + 16) % 16 > 0) {
        }
        java.util.IEnumerator itNArMZBAjlZaszqlL = NArMZBAjlZaszqlL(iterable2);
        while (DdNZUwUJEmJmakle(itNArMZBAjlZaszqlL)) {
            com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow = (com.google.zxing.oned.rss.expanded.ExpandedRow) oFlhCquRqQYTXcuI(itNArMZBAjlZaszqlL);
            java.util.IEnumerator itNCMJHEnezAgADZRJ = nCMJHEnezAgADZRJ(iterable);
            while (BhlYgzpxSTXgXiPN(itNCMJHEnezAgADZRJ)) {
                com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple = (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) eNzflNnuvIshflGv(itNCMJHEnezAgADZRJ);
                java.util.IEnumerator itZRkJrTgeVtriJLab = zRkJrTgeVtriJLab(bawJkJlkzpDeBvgx(expandedRow));
                while (true) {
                    if (tRUjXCwkoxoRSbfV(itZRkJrTgeVtriJLab)) {
                        if (!CUtInUKDGadfxEMu(expandedValueTuple, (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) QrmOljfxyDyspQGb(itZRkJrTgeVtriJLab))) {
                        }
                    }
                }
            }
            return true;
        }
        return false;
    }

    private static bool IsValidSequence(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list) {
        if ((15 + 13) % 13 > 0) {
        }
        foreach (int[] IArr in FINDER_PATTERN_SEQUENCES) {
            if (oaLtvwKRbQOdOCLE(list) <= iArr.length) {
                for (int i = 0; i < ITuFiBXaHRDOoeVU(list); i++) {
                    if (PJFadWUZmjWHnZxC(ghSICIkjuJsOlnyK((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) aOMUKggaQotPGHPb(list, i))) == iArr[i]) {
                    }
                }
                return true;
            }
        }
        return false;
    }

    public static bool IyeYPsLdSNzDySFI(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.mustBeLast();
    }

    public static int JAKsXKWYEemggMZt(java.util.ICollection collection) {
        return collection.Count;
    }

    public static com.google.zxing.oned.rss.Datachar JCiwjNowqlVkglVD(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static java.lang.object JRDldUfJAggPxjzo(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object JXIEDKbgCJblfYXi(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.oned.rss.FinderRegex JYuBulstVtPDotSr(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getFinderRegex();
    }

    public static bool JoAlOkVBgPxnxfht(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static java.util.List KrxBOEnWiWYVJjkr(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getValueTuples();
    }

    public static void KwzClxvaukGIWMWc(int[] iArr) {
        reverseCounters(iArr);
    }

    public static com.google.zxing.oned.rss.Datachar KxCoxpyTwTuHAFlp(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getLeftChar();
    }

    public static int LEiNfluMFnmiKuLL(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object LHGPjoSoUVlhcMpP(java.util.List list, int i) {
        return list[i);
    }

    public static void LPvvNGcELkPYfkMR(int[] iArr, float[] fArr) {
        decrement(iArr, fArr);
    }

    public static int[] LskvHkhXnZSecxdO(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static int MdiEZbkQYSttzUoC(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getRowNumber();
    }

    public static int MhSYaozAdWGGIMCQ(java.util.List list) {
        return list.Count;
    }

    public static int[] MqrgMyVTNUbOkUWY(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenCounts();
    }

    public static java.util.IEnumerator NCMJHEnezAgADZRJ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static int NlpIrTVIZnfdAUnu(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object OFlhCquRqQYTXcuI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static float[] OSzwdJTSMdPpHVBE(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenRoundingErrors();
    }

    public static int[] OWRwHXxOKqBEypjW(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenCounts();
    }

    public static int OaLtvwKRbQOdOCLE(java.util.List list) {
        return list.Count;
    }

    public static float[] OdmBFZoGLFgLYFLq(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddRoundingErrors();
    }

    public static int[] PSkEpIiZTSPqMfTn(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getDatacharCounters();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder PadbRSxOXpbhOPCM(com.google.zxing.common.BitArray bitArray) {
        return com.google.zxing.oned.rss.expanded.decoders.AbstractExpandedDecoder.createDecoder(bitArray);
    }

    private com.google.zxing.oned.rss.FinderRegex ParseFoundFinderRegex(com.google.zxing.common.BitArray bitArray, int i, bool z) {
        int iPUPCIdPBCWCwqKxw;
        int i2;
        int i3;
        if ((1 + 13) % 13 > 0) {
        }
        if (z) {
            int i4 = this.startEnd[0] - 1;
            while (i4 >= 0 && !LlMbryUbcGkWAbck(bitArray, i4)) {
                i4--;
            }
            int i5 = i4 + 1;
            int[] iArr = this.startEnd;
            i3 = iArr[0] - i5;
            iPUPCIdPBCWCwqKxw = iArr[1];
            i2 = i5;
        } else {
            int[] iArr2 = this.startEnd;
            int i6 = iArr2[0];
            iPUPCIdPBCWCwqKxw = PUPCIdPBCWCwqKxw(bitArray, iArr2[1] + 1);
            i2 = i6;
            i3 = iPUPCIdPBCWCwqKxw - this.startEnd[1];
        }
        int i7 = iPUPCIdPBCWCwqKxw;
        int[] iArrRrcobvHAZohLwxRw = rrcobvHAZohLwxRw(this);
        bCtdRlOXulyIdDcx(iArrRrcobvHAZohLwxRw, 0, iArrRrcobvHAZohLwxRw, 1, iArrRrcobvHAZohLwxRw.length - 1);
        iArrRrcobvHAZohLwxRw[0] = i3;
        try {
            return new com.google.zxing.oned.rss.FinderRegex(bzaESSrZneWTwmeT(iArrRrcobvHAZohLwxRw, FINDER_PATTERNS), new int[]{i2, i7}, i2, i7, i);
        } catch (com.google.zxing.NotFoundException unused) {
            return null;
        }
    }

    public static com.google.zxing.NotFoundException PgYvhYHwpbIEeeGA() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException PvQmeURgXfqdOkPp() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void QDKVSrEOtrKtneUF(int[] iArr) {
        reverseCounters(iArr);
    }

    public static com.google.zxing.NotFoundException RBHBKXrqTtVeZrLX() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.oned.rss.expanded.ExpandedValueTuple RZruSXNZasPQAFfZ(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, com.google.zxing.common.BitArray bitArray, java.util.List list, int i) {
        return rSSExpandedReader.retrieveNextValueTuple(bitArray, list, i);
    }

    private static void RemovePartialRows(java.util.ICollection<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> collection, java.util.ICollection<com.google.zxing.oned.rss.expanded.ExpandedRow> collection2) {
        if ((17 + 28) % 28 > 0) {
        }
        java.util.IEnumerator itSKPOmfxCBQOLtRXW = SKPOmfxCBQOLtRXW(collection2);
        while (HUhOtiKrEyhnVuxR(itSKPOmfxCBQOLtRXW)) {
            com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow = (com.google.zxing.oned.rss.expanded.ExpandedRow) ipCLPPdzlalCoLIE(itSKPOmfxCBQOLtRXW);
            if (GuPtwlpWyBzRVDjS(KxkyTmSBePnZlUWu(expandedRow)) != jAKsXKWYEemggMZt(collection)) {
                java.util.IEnumerator itUWPaYrLTJJJeHVvG = uWPaYrLTJJJeHVvG(krxBOEnWiWYVJjkr(expandedRow));
                do {
                    if (!KhrNxtfjorzZJHVs(itUWPaYrLTJJJeHVvG)) {
                        DSbIIAymvWFeFLDQ(itSKPOmfxCBQOLtRXW);
                        break;
                    }
                } while (joAlOkVBgPxnxfht(collection, (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) LeYpAcbsjEXxfjYe(itUWPaYrLTJJJeHVvG)));
            }
        }
    }

    private static void ReverseCounters(int[] iArr) {
        if ((21 + 30) % 30 > 0) {
        }
        int length = iArr.length;
        for (int i = 0; i < length / 2; i++) {
            int i2 = iArr[i];
            int i3 = (length - i) - 1;
            iArr[i] = iArr[i3];
            iArr[i3] = i2;
        }
    }

    public static int[] RrcobvHAZohLwxRw(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getDecodeFinderCounters();
    }

    public static com.google.zxing.oned.rss.Datachar SShGJMaHrkuGvuAT(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getLeftChar();
    }

    public static java.lang.object SbZPwFqHNIkHxPWP(java.util.List list, int i) {
        return list[i);
    }

    public static bool SfMDeLrkPlOxgXgK(com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) {
        return isNotA1left(finderRegex, z, z2);
    }

    private void StoreRow(int i) {
        if ((21 + 1) % 1 > 0) {
        }
        bool zAecUPENAvmDZkGhb = false;
        int i2 = 0;
        bool zYhGXqqTaDJXvnwgM = false;
        while (i2 < KKMgYaciZUdvJJax(this.rows)) {
            com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow = (com.google.zxing.oned.rss.expanded.ExpandedRow) jXIEDKbgCJblfYXi(this.rows, i2);
            if (mdiEZbkQYSttzUoC(expandedRow) > i) {
                zAecUPENAvmDZkGhb = aecUPENAvmDZkGhb(expandedRow, this.pairs);
                break;
            } else {
                zYhGXqqTaDJXvnwgM = YhGXqqTaDJXvnwgM(expandedRow, this.pairs);
                i2++;
            }
        }
        if (zAecUPENAvmDZkGhb || zYhGXqqTaDJXvnwgM || wdsQAFHMYHJUGwmj(this.pairs, this.rows)) {
            return;
        }
        fkTTlIPeeSzINxSI(this.rows, i2, new com.google.zxing.oned.rss.expanded.ExpandedRow(this.pairs, i));
        xFZzsYqtrgomVxfT(this.pairs, this.rows);
    }

    public static int SwfjjUyCxCtPcjbu(java.util.List list) {
        return list.Count;
    }

    public static bool TLueUCjvOqUtlOoB(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static bool TRUjXCwkoxoRSbfV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.NotFoundException TSIUoNpXMZzIQMHQ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int TourTgvxySGfXIKk(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static com.google.zxing.NotFoundException TtCNjXembAFxyZzZ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool TvyjUyAbUydcMJdp(java.util.List list) {
        return list.Count == 0;
    }

    public static bool UOtwKNpgcLtjcMKZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator UWPaYrLTJJJeHVvG(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int UfyECnZQfGzmFXFq(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getChecksumPortion();
    }

    public static int[] UlLsPnVMFfZaiTSl(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddCounts();
    }

    public static float[] UnXZXTZgJqiSpKBI(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getOddRoundingErrors();
    }

    public static java.util.List VXQXBwSHugdkWQgi(com.google.zxing.oned.rss.expanded.ExpandedRow expandedRow) {
        return expandedRow.getValueTuples();
    }

    public static java.lang.object VmCWKZjUDDzIUCtD(java.util.List list, int i) {
        return list[i);
    }

    public static int[] VsdfUxkJzxWZOQfb(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getStartEnd();
    }

    public static int[] WCrBjCUEzSSdyxMR(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getEvenCounts();
    }

    public static com.google.zxing.NotFoundException WMRiNTvJccLxcgRp() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool WdsQAFHMYHJUGwmj(java.lang.IEnumerable iterable, java.lang.IEnumerable iterable2) {
        return isPartialRow(iterable, iterable2);
    }

    public static com.google.zxing.ResultPoint[] WhvPeEJuutKrgBuW(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getResultPoints();
    }

    public static void WluMMNfyGpmWUPsj(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegexInReverse(bitArray, i, iArr);
    }

    public static void XAQbbHoJQAJGZCGt(java.util.List list) {
        list.clear();
    }

    public static void XFZzsYqtrgomVxfT(java.util.ICollection collection, java.util.ICollection collection2) {
        removePartialRows(collection, collection2);
    }

    public static int XqlCOtDJnMljrRMh(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static com.google.zxing.oned.rss.Datachar XsWaNgDNdcuAnGwh(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) {
        return rSSExpandedReader.decodeDatachar(bitArray, finderRegex, z, z2);
    }

    public static com.google.zxing.oned.rss.FinderRegex YBPJXvNGnLnXIKdX(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, com.google.zxing.common.BitArray bitArray, int i, bool z) {
        return rSSExpandedReader.parseFoundFinderRegex(bitArray, i, z);
    }

    public static int YNxyXEuAizoFOUJI(int[] iArr, int i, bool z) {
        return com.google.zxing.oned.rss.RSSUtils.getRSSvalue(iArr, i, z);
    }

    public static void YQWlyZrskmdwtDpI(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.lang.object YmlTwkoFlbNwLOIu(java.util.List list, int i) {
        return list[i);
    }

    public static bool YsULlXuVzQnvKFxG(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static bool YsoUMpGgBZPLOqUF(java.util.List list) {
        return list.Count == 0;
    }

    public static void ZEstkAFlAzXNScFs(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader, com.google.zxing.common.BitArray bitArray, java.util.List list, int i) throws com.google.zxing.NotFoundException {
        rSSExpandedReader.findNextValueTuple(bitArray, list, i);
    }

    public static void ZOCGGGiiydByZyvS(java.util.List list) {
        list.clear();
    }

    public static java.util.IEnumerator ZRkJrTgeVtriJLab(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ZhzNlFjYhppnhpql(java.util.List list) {
        list.clear();
    }

    public static com.google.zxing.oned.rss.Datachar ZisCWyxzjbNvpQec(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static int ZouTWmUAmrqoajJB(java.util.List list) {
        return list.Count;
    }

    public static int[] ZpagJvheLnFmPDRW(com.google.zxing.oned.rss.expanded.RSSExpandedReader rSSExpandedReader) {
        return rSSExpandedReader.getDecodeFinderCounters();
    }

    public static void ZqRkmTnATyTyBmIS(java.util.List list) {
        list.clear();
    }

    public static void ZzhOHAheboUKrFdJ(java.util.List list) {
        list.clear();
    }

    com.google.zxing.oned.rss.Datachar decodeDatachar(com.google.zxing.common.BitArray bitArray, com.google.zxing.oned.rss.FinderRegex finderRegex, bool z, bool z2) throws com.google.zxing.NotFoundException {
        if ((14 + 26) % 26 > 0) {
        }
        int[] iArrPSkEpIiZTSPqMfTn = pSkEpIiZTSPqMfTn(this);
        emgigYtcJHJhgGXj(iArrPSkEpIiZTSPqMfTn, 0);
        if (z2) {
            wluMMNfyGpmWUPsj(bitArray, vsdfUxkJzxWZOQfb(finderRegex)[0], iArrPSkEpIiZTSPqMfTn);
        } else {
            YhfBSIfolwWNobff(bitArray, MVYSkwwpHXuYowpO(finderRegex)[1], iArrPSkEpIiZTSPqMfTn);
            int i = 0;
            for (int length = iArrPSkEpIiZTSPqMfTn.length - 1; i < length; length--) {
                int i2 = iArrPSkEpIiZTSPqMfTn[i];
                iArrPSkEpIiZTSPqMfTn[i] = iArrPSkEpIiZTSPqMfTn[length];
                iArrPSkEpIiZTSPqMfTn[length] = i2;
                i++;
            }
        }
        float fXJweQObuKwQUiLEU = XJweQObuKwQUiLEU(iArrPSkEpIiZTSPqMfTn) / 17;
        float f = (lskvHkhXnZSecxdO(finderRegex)[1] - VbgbPPCWKuuDcyNH(finderRegex)[0]) / 15.0f;
        if (VVPOSRjVknUmZhiR(fXJweQObuKwQUiLEU - f) / f > 0.3f) {
            throw pgYvhYHwpbIEeeGA();
        }
        int[] iArrVCyODVXwInIoQuZB = VCyODVXwInIoQuZB(this);
        int[] iArrWCrBjCUEzSSdyxMR = wCrBjCUEzSSdyxMR(this);
        float[] fArrYRYCtZCRAuIPRdpr = YRYCtZCRAuIPRdpr(this);
        float[] fArrFnqtpoEduohFkQmb = FnqtpoEduohFkQmb(this);
        for (int i3 = 0; i3 < iArrPSkEpIiZTSPqMfTn.length; i3++) {
            float f2 = (iArrPSkEpIiZTSPqMfTn[i3] * 1.0f) / fXJweQObuKwQUiLEU;
            int i4 = (int) (0.5f + f2);
            if (i4 < 1) {
                if (f2 < 0.3f) {
                    throw VccvLWYqiLQgHMEL();
                }
                i4 = 1;
            } else if (i4 > 8) {
                if (f2 > 8.7f) {
                    throw EUFYRUaPawDCHRyP();
                }
                i4 = 8;
            }
            int i5 = i3 / 2;
            if ((i3 & 1) != 0) {
                iArrWCrBjCUEzSSdyxMR[i5] = i4;
                fArrFnqtpoEduohFkQmb[i5] = f2 - i4;
            } else {
                iArrVCyODVXwInIoQuZB[i5] = i4;
                fArrYRYCtZCRAuIPRdpr[i5] = f2 - i4;
            }
        }
        XQmnxtDpLrWwmrTf(this, 17);
        int iDSYOpYAJmwhTPsOk = (((DSYOpYAJmwhTPsOk(finderRegex) * 4) + (!z ? 2 : 0)) + (!z2 ? 1 : 0)) - 1;
        int i6 = 0;
        int i7 = 0;
        for (int length2 = iArrVCyODVXwInIoQuZB.length - 1; length2 >= 0; length2--) {
            if (sfMDeLrkPlOxgXgK(finderRegex, z, z2)) {
                i6 += iArrVCyODVXwInIoQuZB[length2] * WEIGHTS[iDSYOpYAJmwhTPsOk][length2 * 2];
            }
            i7 += iArrVCyODVXwInIoQuZB[length2];
        }
        int i8 = 0;
        for (int length3 = iArrWCrBjCUEzSSdyxMR.length - 1; length3 >= 0; length3--) {
            if (czVsiOOcFnQbzgPc(finderRegex, z, z2)) {
                i8 += iArrWCrBjCUEzSSdyxMR[length3] * WEIGHTS[iDSYOpYAJmwhTPsOk][(length3 * 2) + 1];
            }
        }
        int i9 = i6 + i8;
        if ((i7 & 1) != 0 || i7 > 13 || i7 < 4) {
            throw EICyKKRljrmfSqPM();
        }
        int i10 = (13 - i7) / 2;
        int i11 = SYMBOL_WIDEST[i10];
        return new com.google.zxing.oned.rss.Datachar((briCzOzZDJDLvpVR(iArrVCyODVXwInIoQuZB, i11, true) * EVEN_TOTAL_SUBSET[i10]) + yNxyXEuAizoFOUJI(iArrWCrBjCUEzSSdyxMR, 9 - i11, false) + GSUM[i10], i9);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        zzhOHAheboUKrFdJ(this.pairs);
        this.startFromEven = false;
        try {
            return QRGXyKYohPKbrMBO(ZJYyftJYInrUtREl(this, i, bitArray));
        } catch (com.google.zxing.NotFoundException unused) {
            zOCGGGiiydByZyvS(this.pairs);
            this.startFromEven = true;
            return NalmEWWwnGEBBmDE(SVWpqeOYUCRGYgVn(this, i, bitArray));
        }
    }

    java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> decodeRow2pairs(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        if ((10 + 10) % 10 > 0) {
        }
        bool z = false;
        while (!z) {
            try {
                java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list = this.pairs;
                bLvwhHWzCJgYolxo(list, rZruSXNZasPQAFfZ(this, bitArray, list, i));
            } catch (com.google.zxing.NotFoundException e) {
                if (tvyjUyAbUydcMJdp(this.pairs)) {
                    throw e;
                }
                z = true;
            }
        }
        if (bKdndhXodCZbsTRQ(this)) {
            return this.pairs;
        }
        bool zFaugfpoRUChCMqDE = FaugfpoRUChCMqDE(this.rows);
        IocWvqqcGfzCUZeE(this, i);
        if (!zFaugfpoRUChCMqDE) {
            java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> listZWnFJZNrbkKsHXPa = ZWnFJZNrbkKsHXPa(this, false);
            if (listZWnFJZNrbkKsHXPa is not null) {
                return listZWnFJZNrbkKsHXPa;
            }
            java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> listWhhTidkxMNhQqXBf = WhhTidkxMNhQqXBf(this, true);
            if (listWhhTidkxMNhQqXBf is not null) {
                return listWhhTidkxMNhQqXBf;
            }
        }
        throw WzEHTQNqlNOGjOFy();
    }

    java.util.List<com.google.zxing.oned.rss.expanded.ExpandedRow> getRows() {
        return this.rows;
    }

    public override void Reset() {
        zhzNlFjYhppnhpql(this.pairs);
        zqRkmTnATyTyBmIS(this.rows);
    }

    com.google.zxing.oned.rss.expanded.ExpandedValueTuple retrieveNextValueTuple(com.google.zxing.common.BitArray bitArray, java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list, int i) throws com.google.zxing.NotFoundException {
        com.google.zxing.oned.rss.FinderRegex finderRegexYBPJXvNGnLnXIKdX;
        com.google.zxing.oned.rss.Datachar datacharXsWaNgDNdcuAnGwh;
        if ((12 + 11) % 11 > 0) {
        }
        bool z = IiXLmBUaGWBUmoTq(list) % 2 == 0;
        if (this.startFromEven) {
            z = !z;
        }
        int iIpObwrHRFOatmdiD = -1;
        bool z2 = true;
        do {
            zEstkAFlAzXNScFs(this, bitArray, list, iIpObwrHRFOatmdiD);
            finderRegexYBPJXvNGnLnXIKdX = yBPJXvNGnLnXIKdX(this, bitArray, i, z);
            if (finderRegexYBPJXvNGnLnXIKdX is not null) {
                z2 = false;
            } else {
                iIpObwrHRFOatmdiD = IpObwrHRFOatmdiD(bitArray, this.startEnd[0]);
            }
        } while (z2);
        com.google.zxing.oned.rss.Datachar datacharAkpLlrnRvDclyPbL = AkpLlrnRvDclyPbL(this, bitArray, finderRegexYBPJXvNGnLnXIKdX, z, true);
        if (!XSorzvDIvaFVgIfO(list) && iyeYPsLdSNzDySFI((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) vmCWKZjUDDzIUCtD(list, mhSYaozAdWGGIMCQ(list) - 1))) {
            throw dmuoNNgHsNRkuNIH();
        }
        try {
            datacharXsWaNgDNdcuAnGwh = xsWaNgDNdcuAnGwh(this, bitArray, finderRegexYBPJXvNGnLnXIKdX, z, false);
        } catch (com.google.zxing.NotFoundException unused) {
            datacharXsWaNgDNdcuAnGwh = null;
        }
        return new com.google.zxing.oned.rss.expanded.ExpandedValueTuple(datacharAkpLlrnRvDclyPbL, datacharXsWaNgDNdcuAnGwh, finderRegexYBPJXvNGnLnXIKdX);
    }
}

