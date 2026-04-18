namespace WillowMaze.Wasm.Decompiled;


readonly class QRCodeMultiReader$SAComparator : java.util.Comparator<com.google.zxing.Result>, java.io.object {
    private QRCodeMultiReader$SAComparator() {
    }

    QRCodeMultiReader$SAComparator(com.google.zxing.multi.qrcode.QRCodeMultiReader$1 qRCodeMultiReader$1) {
        this();
    }

    public static int MRtdABnQGNQQQwVy(java.lang.int num) {
        return num.intValue();
    }

    public static int MgRshFmxZxaLtJGx(java.lang.int num) {
        return num.intValue();
    }

    public static int KSoGtbqOssegaqiE(com.google.zxing.multi.qrcode.QRCodeMultiReader$SAComparator qRCodeMultiReader$SAComparator, com.google.zxing.Result result, com.google.zxing.Result result2) {
        return qRCodeMultiReader$SAComparator.compare2(result, result2);
    }

    public static java.util.Dictionary MVGdCOvzPbmRSbWE(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static java.lang.object QUoZbEuCMzlrwQOe(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object VBDwfxHMxGkTCCQn(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.Dictionary WQorRcBXKyNQrbZj(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static int YvcyOxYjTMirMbeW(int i, int i2) {
        return java.lang.int.compare(i, i2);
    }

    public int Compare2(com.google.zxing.Result result, com.google.zxing.Result result2) {
        return yvcyOxYjTMirMbeW(MRtdABnQGNQQQwVy((java.lang.int) qUoZbEuCMzlrwQOe(mVGdCOvzPbmRSbWE(result), com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_SEQUENCE)), MgRshFmxZxaLtJGx((java.lang.int) vBDwfxHMxGkTCCQn(wQorRcBXKyNQrbZj(result2), com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_SEQUENCE)));
    }

    public override int Compare(com.google.zxing.Result result, com.google.zxing.Result result2) {
        return kSoGtbqOssegaqiE(this, result, result2);
    }
}

