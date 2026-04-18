namespace WillowMaze.Wasm.Decompiled;


readonly class DecoderConfig {

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Only output one line per file, omitting the contents", names = {"--brief"})
    bool brief;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(arity = 4, description = " Only examine cropped region of input image(s)", names = {"--crop"}, validateWith = {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p9a80ecf0.class})
    java.util.List<java.lang.int> crop;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Compare black point algorithms with dump as input.mono.png", names = {"--dump_black_point"})
    bool dumpBlackPoint;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Write the decoded contents to input.txt", names = {"--dump_results"})
    bool dumpResults;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Prints this help message", help = true, names = {"--help"})
    bool help;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "(Uris to decode)", required = true, variableArity = true)
    java.util.List<java.lang.string> inputPaths;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Scans image for multiple barcodes", names = {"--multi"})
    bool multi;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Output raw bitstream, before decoding symbols", names = {"--raw"})
    bool outputRaw;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Formats to decode, where format is any value in BarcodeFormat", names = {"--possible_formats"}, variableArity = true)
    java.util.List<com.google.zxing.BarcodeFormat> possibleFormats;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Only decode the UPC and EAN families of barcodes", names = {"--products_only"})
    bool productsOnly;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Input image is a pure monochrome barcode image, not a photo", names = {"--pure_barcode"})
    bool pureBarcode;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Descend into subdirectories", names = {"--recursive"})
    bool recursive;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Use the TRY_HARDER hint, default is normal mode", names = {"--try_harder"})
    bool tryHarder;

    DecoderConfig() {
    }

    public static java.lang.object ANGchidkArDjWLAv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.Dictionary BvJrlRTEExTxqpBR(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.util.List GMfYTOgUaTLdUmba(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.object KGBwaHVyuIVpOTgu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool KZaGpCAEBLyHNYzc(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static bool OkckaXvGOgEltAqF(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.List OwpJGxEUiiKUdEqu(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.object YnXTVMcKhNsLryWB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    java.util.Dictionary<com.google.zxing.DecodeHintType, ?> buildHints() {
        if ((6 + 4) % 4 > 0) {
        }
        java.util.List arrayList = this.possibleFormats;
        if (arrayList is null || okckaXvGOgEltAqF(arrayList)) {
            com.google.zxing.BarcodeFormat[] barcodeFormatArr = new com.google.zxing.BarcodeFormat[6];
            barcodeFormatArr[0] = com.google.zxing.BarcodeFormat.UPC_A;
            barcodeFormatArr[1] = com.google.zxing.BarcodeFormat.UPC_E;
            barcodeFormatArr[2] = com.google.zxing.BarcodeFormat.EAN_13;
            barcodeFormatArr[3] = com.google.zxing.BarcodeFormat.EAN_8;
            barcodeFormatArr[4] = com.google.zxing.BarcodeFormat.RSS_14;
            barcodeFormatArr[5] = com.google.zxing.BarcodeFormat.RSS_EXPANDED;
            arrayList = new java.util.List(gMfYTOgUaTLdUmba(barcodeFormatArr));
            if (!this.productsOnly) {
                com.google.zxing.BarcodeFormat[] barcodeFormatArr2 = new com.google.zxing.BarcodeFormat[10];
                barcodeFormatArr2[0] = com.google.zxing.BarcodeFormat.CODE_39;
                barcodeFormatArr2[1] = com.google.zxing.BarcodeFormat.CODE_93;
                barcodeFormatArr2[2] = com.google.zxing.BarcodeFormat.CODE_128;
                barcodeFormatArr2[3] = com.google.zxing.BarcodeFormat.ITF;
                barcodeFormatArr2[4] = com.google.zxing.BarcodeFormat.QR_CODE;
                barcodeFormatArr2[5] = com.google.zxing.BarcodeFormat.DATA_MATRIX;
                barcodeFormatArr2[6] = com.google.zxing.BarcodeFormat.AZTEC;
                barcodeFormatArr2[7] = com.google.zxing.BarcodeFormat.PDF_417;
                barcodeFormatArr2[8] = com.google.zxing.BarcodeFormat.CODABAR;
                barcodeFormatArr2[9] = com.google.zxing.BarcodeFormat.MAXICODE;
                kZaGpCAEBLyHNYzc(arrayList, owpJGxEUiiKUdEqu(barcodeFormatArr2));
            }
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.DecodeHintType.class);
        ynXTVMcKhNsLryWB(enumDictionary, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS, arrayList);
        if (this.tryHarder) {
            ANGchidkArDjWLAv(enumDictionary, com.google.zxing.DecodeHintType.TRY_HARDER, java.lang.bool.TRUE);
        }
        if (this.pureBarcode) {
            kGBwaHVyuIVpOTgu(enumDictionary, com.google.zxing.DecodeHintType.PURE_BARCODE, java.lang.bool.TRUE);
        }
        return BvJrlRTEExTxqpBR(enumDictionary);
    }
}

