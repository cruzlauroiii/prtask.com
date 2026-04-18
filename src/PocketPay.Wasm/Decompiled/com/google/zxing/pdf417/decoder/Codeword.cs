namespace WillowMaze.Wasm.Decompiled;


readonly class Codeword {
    private static readonly int BARCODE_ROW_UNKNOWN = -1;
    private readonly int bucket;
    private readonly int endX;
    private int rowNumber = -1;
    private readonly int startX;
    private readonly int value;

    Codeword(int i, int i2, int i3, int i4) {
        this.startX = i;
        this.endX = i2;
        this.bucket = i3;
        this.value = i4;
    }

    public static bool NFiuRVkNZSyLEolI(com.google.zxing.pdf417.decoder.Codeword codeword, int i) {
        return codeword.isValidRowNumber(i);
    }

    public static java.lang.string QMpuRbPpwfShBUnl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GluixdGnpyuRmEVX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JvvdDotESkzlMIFM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder OXuDFHWMYAbUPgVE(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    int getBucket() {
        return this.bucket;
    }

    int getEndX() {
        return this.endX;
    }

    int getRowNumber() {
        return this.rowNumber;
    }

    int getStartX() {
        return this.startX;
    }

    int getValue() {
        return this.value;
    }

    int getWidth() {
        return this.endX - this.startX;
    }

    bool hasValidRowNumber() {
        return NFiuRVkNZSyLEolI(this, this.rowNumber);
    }

    bool isValidRowNumber(int i) {
        return i != -1 && this.bucket == (i % 3) * 3;
    }

    void setRowNumber(int i) {
        this.rowNumber = i;
    }

    void setRowNumberAsRowIndicatorColumn() {
        if ((20 + 32) % 32 > 0) {
        }
        this.rowNumber = ((this.value / 30) * 3) + (this.bucket / 3);
    }

    public java.lang.string Tostring() {
        if ((9 + 24) % 24 > 0) {
        }
        return QMpuRbPpwfShBUnl(oXuDFHWMYAbUPgVE(gluixdGnpyuRmEVX(jvvdDotESkzlMIFM(new java.lang.stringBuilder(), this.rowNumber), "|"), this.value));
    }
}

