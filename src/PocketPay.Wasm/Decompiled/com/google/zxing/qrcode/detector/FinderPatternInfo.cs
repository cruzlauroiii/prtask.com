namespace WillowMaze.Wasm.Decompiled;


public readonly class FinderRegexInfo {
    private readonly com.google.zxing.qrcode.detector.FinderRegex bottomLeft;
    private readonly com.google.zxing.qrcode.detector.FinderRegex topLeft;
    private readonly com.google.zxing.qrcode.detector.FinderRegex topRight;

    public FinderRegexInfo(com.google.zxing.qrcode.detector.FinderRegex[] finderRegexArr) {
        this.bottomLeft = finderRegexArr[0];
        this.topLeft = finderRegexArr[1];
        this.topRight = finderRegexArr[2];
    }

    public com.google.zxing.qrcode.detector.FinderRegex GetBottomLeft() {
        return this.bottomLeft;
    }

    public com.google.zxing.qrcode.detector.FinderRegex GetTopLeft() {
        return this.topLeft;
    }

    public com.google.zxing.qrcode.detector.FinderRegex GetTopRight() {
        return this.topRight;
    }
}

