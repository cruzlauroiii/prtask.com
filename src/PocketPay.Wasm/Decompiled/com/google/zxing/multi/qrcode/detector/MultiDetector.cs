namespace WillowMaze.Wasm.Decompiled;


public readonly class MultiDetector : com.google.zxing.qrcode.detector.Detector {
    private static readonly com.google.zxing.common.DetectorResult[] EMPTY_DETECTOR_RESULTS = new com.google.zxing.common.DetectorResult[0];

    public MultiDetector(com.google.zxing.common.BitMatrix bitMatrix) {
        super(bitMatrix);
    }

    public static java.lang.object DCfgJhIEVQlQgMgI(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.zxing.common.BitMatrix EFiLkoeSgMuagAdM(com.google.zxing.multi.qrcode.detector.MultiDetector multiDetector) {
        return multiDetector.getImage();
    }

    public static com.google.zxing.common.DetectorResult GlmvBVSVEieCmYOE(com.google.zxing.multi.qrcode.detector.MultiDetector multiDetector, com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) {
        return multiDetector.processFinderRegexInfo(finderRegexInfo);
    }

    public static java.lang.object[] RVCgVROprJEOTvTb(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static com.google.zxing.NotFoundException NuuVeACVTgpCvsoB() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool PhtQmPaTJoEMaZpe(java.util.List list) {
        return list.Count == 0;
    }

    public static bool SstmowdrCOARvyJP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.qrcode.detector.FinderRegexInfo[] TDXmJjHMNqquQAlG(com.google.zxing.multi.qrcode.detector.MultiFinderRegexFinder multiFinderRegexFinder, java.util.Dictionary map) {
        return multiFinderRegexFinder.findMulti(map);
    }

    public com.google.zxing.common.DetectorResult[] DetectMulti(java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((3 + 1) % 1 > 0) {
        }
        com.google.zxing.qrcode.detector.FinderRegexInfo[] finderRegexInfoArrTDXmJjHMNqquQAlG = tDXmJjHMNqquQAlG(new com.google.zxing.multi.qrcode.detector.MultiFinderRegexFinder(EFiLkoeSgMuagAdM(this), map is not null ? (com.google.zxing.ResultPointCallback) DCfgJhIEVQlQgMgI(map, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK) : null), map);
        if (finderRegexInfoArrTDXmJjHMNqquQAlG.length == 0) {
            throw nuuVeACVTgpCvsoB();
        }
        java.util.List arrayList = new java.util.List();
        for (com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo : finderRegexInfoArrTDXmJjHMNqquQAlG) {
            try {
                sstmowdrCOARvyJP(arrayList, GlmvBVSVEieCmYOE(this, finderRegexInfo));
            } catch (com.google.zxing.ReaderException unused) {
            }
        }
        return !phtQmPaTJoEMaZpe(arrayList) ? (com.google.zxing.common.DetectorResult[]) RVCgVROprJEOTvTb(arrayList, EMPTY_DETECTOR_RESULTS) : EMPTY_DETECTOR_RESULTS;
    }
}

