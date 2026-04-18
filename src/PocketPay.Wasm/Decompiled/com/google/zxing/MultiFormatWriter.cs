namespace WillowMaze.Wasm.Decompiled;


public readonly class MultiFormatWriter : com.google.zxing.Writer {
    public static int HeKbIcGogEvqLwbe(com.google.zxing.BarcodeFormat barcodeFormat) {
        return barcodeFormat.ordinal();
    }

    public static java.lang.string OgXCeqZAnZHImweN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.common.BitMatrix RJMKwGmXTerGRvsq(com.google.zxing.MultiFormatWriter multiFormatWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return multiFormatWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static com.google.zxing.common.BitMatrix FcKVLETIywWHblvZ(com.google.zxing.Writer writer, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return writer.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.stringBuilder PVUDnwtIMxxxWVcw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) throws com.google.zxing.WriterException {
        if ((2 + 12) % 12 > 0) {
        }
        return RJMKwGmXTerGRvsq(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) throws com.google.zxing.WriterException {
        com.google.zxing.Writer qRCodeWriter;
        if ((20 + 31) % 31 > 0) {
        }
        switch (com.google.zxing.MultiFormatWriter$1.$SwitchDictionary$com$google$zxing$BarcodeFormat[HeKbIcGogEvqLwbe(barcodeFormat)]) {
            case 1:
                qRCodeWriter = new com.google.zxing.oned.EAN8Writer();
                break;
            case 2:
                qRCodeWriter = new com.google.zxing.oned.UPCEWriter();
                break;
            case 3:
                qRCodeWriter = new com.google.zxing.oned.EAN13Writer();
                break;
            case 4:
                qRCodeWriter = new com.google.zxing.oned.UPCAWriter();
                break;
            case 5:
                qRCodeWriter = new com.google.zxing.qrcode.QRCodeWriter();
                break;
            case 6:
                qRCodeWriter = new com.google.zxing.oned.Code39Writer();
                break;
            case 7:
                qRCodeWriter = new com.google.zxing.oned.Code93Writer();
                break;
            case 8:
                qRCodeWriter = new com.google.zxing.oned.Code128Writer();
                break;
            case 9:
                qRCodeWriter = new com.google.zxing.oned.ITFWriter();
                break;
            case 10:
                qRCodeWriter = new com.google.zxing.pdf417.PDF417Writer();
                break;
            case 11:
                qRCodeWriter = new com.google.zxing.oned.CodaBarWriter();
                break;
            case 12:
                qRCodeWriter = new com.google.zxing.datamatrix.DataMatrixWriter();
                break;
            case 13:
                qRCodeWriter = new com.google.zxing.aztec.AztecWriter();
                break;
            default:
                throw new java.lang.IllegalArgumentException(OgXCeqZAnZHImweN(pVUDnwtIMxxxWVcw(new java.lang.stringBuilder("No encoder available for format "), barcodeFormat)));
        }
        return fcKVLETIywWHblvZ(qRCodeWriter, str, barcodeFormat, i, i2, map);
    }
}

