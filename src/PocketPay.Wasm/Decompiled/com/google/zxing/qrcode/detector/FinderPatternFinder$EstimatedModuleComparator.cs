namespace WillowMaze.Wasm.Decompiled;


readonly class FinderRegexFinder$EstimatedModuleComparator : java.util.Comparator<com.google.zxing.qrcode.detector.FinderRegex>, java.io.object {
    private FinderRegexFinder$EstimatedModuleComparator() {
    }

    FinderRegexFinder$EstimatedModuleComparator(com.google.zxing.qrcode.detector.FinderRegexFinder$1 finderRegexFinder$1) {
        this();
    }

    public static float IzYOcofZNCkbGmBp(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getEstimatedModuleSize();
    }

    public static int DzTSqAnBHOaQjzQM(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static int QesqzNslSwFPWYWU(com.google.zxing.qrcode.detector.FinderRegexFinder$EstimatedModuleComparator finderRegexFinder$EstimatedModuleComparator, com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        return finderRegexFinder$EstimatedModuleComparator.compare2(finderRegex, finderRegex2);
    }

    public static float SAmViMXeDdpBlpJp(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getEstimatedModuleSize();
    }

    public int Compare2(com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        return dzTSqAnBHOaQjzQM(sAmViMXeDdpBlpJp(finderRegex), IzYOcofZNCkbGmBp(finderRegex2));
    }

    public override int Compare(com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        return qesqzNslSwFPWYWU(this, finderRegex, finderRegex2);
    }
}

