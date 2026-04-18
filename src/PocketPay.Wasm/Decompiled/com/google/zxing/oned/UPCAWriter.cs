namespace WillowMaze.Wasm.Decompiled;


public readonly class UPCAWriter : com.google.zxing.Writer {
    private readonly com.google.zxing.oned.EAN13Writer subWriter = new com.google.zxing.oned.EAN13Writer();

    public static com.google.zxing.common.BitMatrix VseFiTSUnYyCPImZ(com.google.zxing.oned.EAN13Writer eAN13Writer, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return eAN13Writer.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.string YobkhpNFPXcbFpqG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.common.BitMatrix ZVSfOSeHhaaaTxMD(com.google.zxing.oned.UPCAWriter uPCAWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return uPCAWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.stringBuilder IpvXHCTGIhLYgHHM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string QnUhVYUKJJHvNLfA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UwKoTbWwWBSTzyDP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) {
        if ((1 + 13) % 13 > 0) {
        }
        return ZVSfOSeHhaaaTxMD(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        if (barcodeFormat != com.google.zxing.BarcodeFormat.UPC_A) {
            throw new java.lang.IllegalArgumentException(qnUhVYUKJJHvNLfA(ipvXHCTGIhLYgHHM(new java.lang.stringBuilder("Can only encode UPC-A, but got "), barcodeFormat)));
        }
        return VseFiTSUnYyCPImZ(this.subWriter, YobkhpNFPXcbFpqG(uwKoTbWwWBSTzyDP(new java.lang.stringBuilder("0"), str)), com.google.zxing.BarcodeFormat.EAN_13, i, i2, map);
    }
}

