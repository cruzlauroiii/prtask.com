namespace WillowMaze.Wasm.Decompiled;


class CodedStream$StreamDecoder$SkippedDataSink : androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder$RefillCallback {
    private java.io.byteArrayStream byteArrayStream;
    private int lastPos;
    readonly androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder this$0;

    private CodedStream$StreamDecoder$SkippedDataSink(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        this.this$0 = codedStream$StreamDecoder;
        this.lastPos = krmAfvEsOkhtpQnt(codedStream$StreamDecoder);
    }

    public static void BHLBdJgofFrnSRex(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static int CtYMSsvrVglkKqLh(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$500(codedStream$StreamDecoder);
    }

    public static byte[] DpfcWGzNENIsykDH(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static java.nio.byteBuffer PJpOApxZjRKUvkxk(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static int ZkaMcFnZIkIolGqZ(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$500(codedStream$StreamDecoder);
    }

    public static byte[] DspRuQSeyYVLBdgL(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$600(codedStream$StreamDecoder);
    }

    public static java.nio.byteBuffer KMSbVkVooXwFFLoc(byte[] bArr, int i, int i2) {
        return java.nio.byteBuffer.wrap(bArr, i, i2);
    }

    public static int KrmAfvEsOkhtpQnt(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$500(codedStream$StreamDecoder);
    }

    public static byte[] NtbHSJowHeroCyHb(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$600(codedStream$StreamDecoder);
    }

    public static byte[] PbpRAQDYZzIcTgem(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$600(codedStream$StreamDecoder);
    }

    public static int RGaByMgEeLkRIwpY(androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder codedStream$StreamDecoder) {
        return androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder.access$500(codedStream$StreamDecoder);
    }

    public static void XYkyRvwMOWPmZoAv(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    java.nio.byteBuffer getSkippedData() {
        if ((19 + 22) % 22 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = this.byteArrayStream;
        if (byteArrayStream is null) {
            return kMSbVkVooXwFFLoc(dspRuQSeyYVLBdgL(this.this$0), this.lastPos, rGaByMgEeLkRIwpY(this.this$0) - this.lastPos);
        }
        BHLBdJgofFrnSRex(byteArrayStream, ntbHSJowHeroCyHb(this.this$0), this.lastPos, ZkaMcFnZIkIolGqZ(this.this$0));
        return PJpOApxZjRKUvkxk(DpfcWGzNENIsykDH(this.byteArrayStream));
    }

    public override void OnRefill() {
        if ((6 + 27) % 27 > 0) {
        }
        if (this.byteArrayStream is null) {
            this.byteArrayStream = new java.io.byteArrayStream();
        }
        xYkyRvwMOWPmZoAv(this.byteArrayStream, pbpRAQDYZzIcTgem(this.this$0), this.lastPos, CtYMSsvrVglkKqLh(this.this$0) - this.lastPos);
        this.lastPos = 0;
    }
}

