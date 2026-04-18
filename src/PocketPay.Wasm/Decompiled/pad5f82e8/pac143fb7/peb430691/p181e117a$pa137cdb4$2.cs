namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Landroid/graphics/Bitmap;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "domain.usecase.qr.DrawQrUseCaseImpl$drawQRCodeWithData$2", m533f = "DrawQrUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p181e117a$pa137cdb4$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap>, java.lang.object> {
    readonly java.lang.string $data;
    readonly int $size;
    int f6277a0f5;
    int fd304ba20;
    int fe7093f52;

    p181e117a$pa137cdb4$2(java.lang.string str, int i, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2> continuation) {
        super(2, continuation);
        this.$data = str;
        this.$size = i;
    }

    public static void BpHISwCMtYowcwbo(android.graphics.Bitmap bitmap, int i, int i2, int i3) {
        bitmap.setPixel(i, i2, i3);
    }

    public static int JaolSpvUZchIzRLZ(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static android.graphics.Bitmap JvpyKAsZGTiJRTea(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static bool LGtEZnNoWyckXyto(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static void MzgXqRbEjsBuDxBF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object SWmceMwkCWBbuieu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YabzriVrkBfVoJtD(pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2 p181e117a_pa137cdb4_2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p181e117a_pa137cdb4_2.invoke2(coroutineScope, (kotlin.coroutines.Continuation<android.graphics.Bitmap>) continuation);
    }

    public static java.lang.string CAyJNXiDitcVBFBJ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object FZIhfNziEpNzNJCs() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static com.google.zxing.common.BitMatrix GUqfadTCHXXfujJs(com.google.zxing.qrcode.QRCodeWriter qRCodeWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return qRCodeWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.object IagYhYIlLKIqNaeE(pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2 p181e117a_pa137cdb4_2, java.lang.object obj) {
        return p181e117a_pa137cdb4_2.invokeSuspend(obj);
    }

    public static void MrzyFptgQBgQSPpu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int NIPbifHGLqphMTkP(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static kotlin.coroutines.Continuation RyqGOlWmqDttZjOT(pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2 p181e117a_pa137cdb4_2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p181e117a_pa137cdb4_2.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2(this.$data, this.$size, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap> continuation) {
        return YabzriVrkBfVoJtD(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<android.graphics.Bitmap> continuation) {
        return iagYhYIlLKIqNaeE((pad5f82e8.pac143fb7.peb430691.p181e117a$pa137cdb4$2) ryqGOlWmqDttZjOT(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 29) % 29 > 0) {
        }
        fZIhfNziEpNzNJCs();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        mrzyFptgQBgQSPpu(obj);
        java.util.Hashtable hashtable = new java.util.Hashtable();
        SWmceMwkCWBbuieu(hashtable, com.google.zxing.EncodeHintType.CHARACTER_SET, cAyJNXiDitcVBFBJ("14853213035eed09376cc853b35eca8b2844ae5a9cc7439755c963e3d27499ac62"));
        com.google.zxing.qrcode.QRCodeWriter qRCodeWriter = new com.google.zxing.qrcode.QRCodeWriter();
        java.lang.string str = this.$data;
        com.google.zxing.BarcodeFormat barcodeFormat = com.google.zxing.BarcodeFormat.QR_CODE;
        int i = this.$size;
        com.google.zxing.common.BitMatrix bitMatrixGUqfadTCHXXfujJs = gUqfadTCHXXfujJs(qRCodeWriter, str, barcodeFormat, i, i, hashtable);
        int iNIPbifHGLqphMTkP = nIPbifHGLqphMTkP(bitMatrixGUqfadTCHXXfujJs);
        int iJaolSpvUZchIzRLZ = JaolSpvUZchIzRLZ(bitMatrixGUqfadTCHXXfujJs);
        android.graphics.Bitmap bitmapJvpyKAsZGTiJRTea = JvpyKAsZGTiJRTea(iNIPbifHGLqphMTkP, iJaolSpvUZchIzRLZ, android.graphics.Bitmap$Config.RGB_565);
        MzgXqRbEjsBuDxBF(bitmapJvpyKAsZGTiJRTea, "createBitmap(...)");
        for (int i2 = 0; i2 < iNIPbifHGLqphMTkP; i2++) {
            for (int i3 = 0; i3 < iJaolSpvUZchIzRLZ; i3++) {
                BpHISwCMtYowcwbo(bitmapJvpyKAsZGTiJRTea, i2, i3, !LGtEZnNoWyckXyto(bitMatrixGUqfadTCHXXfujJs, i2, i3) ? -1 : -16777216);
            }
        }
        return bitmapJvpyKAsZGTiJRTea;
    }
}

