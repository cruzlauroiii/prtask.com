namespace WillowMaze.Wasm.Decompiled;


readonly class EncoderConfig {
    static readonly java.lang.string DEFAULT_OUTPUT_FILE_BASE = "out";

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "(Text to encode)", required = true)
    java.util.List<java.lang.string> contents;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Prints this help message", help = true, names = {"--help"})
    bool help;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Format to encode, from BarcodeFormat class. Not all formats are supported", names = {"--barcode_format"})
    com.google.zxing.BarcodeFormat barcodeFormat = com.google.zxing.BarcodeFormat.QR_CODE;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Image output format, such as PNG, JPG, GIF", names = {"--image_format"})
    java.lang.string imageFormat = "PNG";

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "string to write to. Defaults to out.png", names = {"--output"})
    java.lang.string outputstringBase = "out";

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Image width", names = {"--width"}, validateWith = {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p9a80ecf0.class})
    int width = 300;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Image height", names = {"--height"}, validateWith = {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p9a80ecf0.class})
    int height = 300;

    @p4d236d9a.p2c8df876.pf9133214.p83f499a5(description = "Error correction level for the encoding", names = {"--error_correction_level"})
    java.lang.string errorCorrectionLevel = null;

    EncoderConfig() {
    }
}

