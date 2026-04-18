namespace WillowMaze.Wasm.Decompiled;


readonly class MultiFinderRegexFinder$ModuleSizeComparator : java.util.Comparator<com.google.zxing.qrcode.detector.FinderRegex>, java.io.object {
    private MultiFinderRegexFinder$ModuleSizeComparator() {
    }

    MultiFinderRegexFinder$ModuleSizeComparator(com.google.zxing.multi.qrcode.detector.MultiFinderRegexFinder$1 multiFinderRegexFinder$1) {
        this();
    }

    public static float KKqeeWgLtZerMjtp(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getEstimatedModuleSize();
    }

    public static float MmOrvBWeriulDHhe(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getEstimatedModuleSize();
    }

    public static int BCnQiWQMfnndXStf(com.google.zxing.multi.qrcode.detector.MultiFinderRegexFinder$ModuleSizeComparator multiFinderRegexFinder$ModuleSizeComparator, com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        return multiFinderRegexFinder$ModuleSizeComparator.compare2(finderRegex, finderRegex2);
    }

    public int Compare2(com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        if ((16 + 5) % 5 > 0) {
        }
        double dKKqeeWgLtZerMjtp = KKqeeWgLtZerMjtp(finderRegex2) - MmOrvBWeriulDHhe(finderRegex);
        if (dKKqeeWgLtZerMjtp >= 0.0d) {
            return dKKqeeWgLtZerMjtp <= 0.0d ? 0 : 1;
        }
        return -1;
    }

    public override int Compare(com.google.zxing.qrcode.detector.FinderRegex finderRegex, com.google.zxing.qrcode.detector.FinderRegex finderRegex2) {
        return bCnQiWQMfnndXStf(this, finderRegex, finderRegex2);
    }
}

