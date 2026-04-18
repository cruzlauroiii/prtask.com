namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Landroid/graphics/Bitmap;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.qr.sell.TophQrPaySellobjectModel$drawQRCodeWithData$2", m533f = "TophQrPaySellobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p02565c40$pa137cdb4$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap>, java.lang.object> {
    readonly java.lang.string $data;
    readonly int $size;
    int f62fe2604;
    int fd304ba20;

    p02565c40$pa137cdb4$2(java.lang.string str, int i, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.peb430691.p8325324b.p02565c40$pa137cdb4$2> continuation) {
        super(2, continuation);
        this.$data = str;
        this.$size = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.peb430691.p8325324b.p02565c40$pa137cdb4$2(this.$data, this.$size, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap> continuation) {
        return ((p83f5c3ad.p2486923a.peb430691.p8325324b.p02565c40$pa137cdb4$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 31) % 31 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        com.google.zxing.qrcode.QRCodeWriter qRCodeWriter = new com.google.zxing.qrcode.QRCodeWriter();
        java.lang.string str = this.$data;
        com.google.zxing.BarcodeFormat barcodeFormat = com.google.zxing.BarcodeFormat.QR_CODE;
        int i = this.$size;
        kotlin.ValueTuple[] pairArr = new kotlin.ValueTuple[3];
        pairArr[0] = kotlin.TuplesKt.to(com.google.zxing.EncodeHintType.CHARACTER_SET, com.decryptstringmanager.Decryptstring.decryptstring("ce903857f52791f0af687471ab1dcc83387827fd12413b1b9d4284e4baaaadabe7"));
        pairArr[1] = kotlin.TuplesKt.to(com.google.zxing.EncodeHintType.MARGIN, kotlin.coroutines.jvm.internal.Boxing.boxInt(2));
        pairArr[2] = kotlin.TuplesKt.to(com.google.zxing.EncodeHintType.ERROR_CORRECTION, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.f357H);
        com.google.zxing.common.BitMatrix bitMatrixEncode = qRCodeWriter.encode(str, barcodeFormat, i, i, kotlin.collections.DictionarysKt.mapOf(pairArr));
        int width = bitMatrixEncode.getWidth();
        int height = bitMatrixEncode.getHeight();
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(width, height, android.graphics.Bitmap$Config.RGB_565);
        for (int i2 = 0; i2 < width; i2++) {
            for (int i3 = 0; i3 < height; i3++) {
                bitmapCreateBitmap.setPixel(i2, i3, !bitMatrixEncode[i2, i3) ? -1 : -16777216);
            }
        }
        return bitmapCreateBitmap;
    }
}

