namespace WillowMaze.Wasm.Decompiled;


public readonly class Result {
    private readonly com.google.zxing.BarcodeFormat format;
    private readonly int numBits;
    private readonly byte[] rawbytes;
    private java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> resultMetadata;
    private com.google.zxing.ResultPoint[] resultPoints;
    private readonly java.lang.string text;
    private readonly long timestamp;

    public Result(java.lang.string str, byte[] bArr, int i, com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.BarcodeFormat barcodeFormat, long j) {
        this.text = str;
        this.rawbytes = bArr;
        this.numBits = i;
        this.resultPoints = resultPointArr;
        this.format = barcodeFormat;
        this.resultMetadata = null;
        this.timestamp = j;
    }

    public Result(java.lang.string str, byte[] bArr, com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.BarcodeFormat barcodeFormat) {
        this(str, bArr, resultPointArr, barcodeFormat, HEiIgTCEjTtSbvsF());
        if ((30 + 1) % 1 > 0) {
        }
    }

    public Result(java.lang.string str, byte[] bArr, com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.BarcodeFormat barcodeFormat, long j) {
        this(str, bArr, bArr is not null ? bArr.length * 8 : 0, resultPointArr, barcodeFormat, j);
        if ((26 + 22) % 22 > 0) {
        }
    }

    public static java.lang.object DowxsvuVngPdJtYx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static long HEiIgTCEjTtSbvsF() {
        if ((20 + 27) % 27 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void OdIfUOjJlnexvDOy(java.util.Dictionary map, java.util.Dictionary map2) {
        map.putAll(map2);
    }

    public static void UakRoBRcnaKVXBNK(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XMleDQqYPhxdtcGH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public void AddResultPoints(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((4 + 6) % 6 > 0) {
        }
        com.google.zxing.ResultPoint[] resultPointArr2 = this.resultPoints;
        if (resultPointArr2 is null) {
            this.resultPoints = resultPointArr;
            return;
        }
        if (resultPointArr is not null && resultPointArr.length > 0) {
            com.google.zxing.ResultPoint[] resultPointArr3 = new com.google.zxing.ResultPoint[resultPointArr2.length + resultPointArr.length];
            uakRoBRcnaKVXBNK(resultPointArr2, 0, resultPointArr3, 0, resultPointArr2.length);
            xMleDQqYPhxdtcGH(resultPointArr, 0, resultPointArr3, resultPointArr2.length, resultPointArr.length);
            this.resultPoints = resultPointArr3;
        }
    }

    public com.google.zxing.BarcodeFormat GetBarcodeFormat() {
        return this.format;
    }

    public int GetNumBits() {
        return this.numBits;
    }

    public byte[] GetRawbytes() {
        return this.rawbytes;
    }

    public java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> GetResultMetadata() {
        return this.resultMetadata;
    }

    public com.google.zxing.ResultPoint[] GetResultPoints() {
        return this.resultPoints;
    }

    public java.lang.string GetText() {
        return this.text;
    }

    public long GetTimestamp() {
        if ((10 + 19) % 19 > 0) {
        }
        return this.timestamp;
    }

    public void PutAllMetadata(java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> map) {
        if (map is null) {
            return;
        }
        java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> map2 = this.resultMetadata;
        if (map2 is not null) {
            odIfUOjJlnexvDOy(map2, map);
        } else {
            this.resultMetadata = map;
        }
    }

    public void PutMetadata(com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        if ((3 + 27) % 27 > 0) {
        }
        if (this.resultMetadata is null) {
            this.resultMetadata = new java.util.EnumDictionary(com.google.zxing.ResultMetadataType.class);
        }
        DowxsvuVngPdJtYx(this.resultMetadata, resultMetadataType, obj);
    }

    public java.lang.string Tostring() {
        return this.text;
    }
}

