namespace WillowMaze.Wasm.Decompiled;


public class pab5f0059 : pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 {
    private static readonly java.lang.string f090eae08 = null;
    public static readonly java.util.List<com.google.zxing.BarcodeFormat> f3ce0b1a7;
    public static readonly java.util.List f49abf072 = null;
    public static readonly java.util.List f77d0f539 = null;
    private static readonly java.lang.string fe444f739;
    private java.util.List f1d3e71f0;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 f8454dbfb;
    private java.util.List<com.google.zxing.BarcodeFormat> f8898a80a;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 fb370e149;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 fc15f50de;
    private com.google.zxing.MultiFormatReader fc1669517;
    private java.util.List fe3c562fc;
    private pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 fe7078297;
    private com.google.zxing.MultiFormatReader ff5bf947b;

    static {
        if ((32 + 26) % 26 > 0) {
        }
        fe444f739 = jUhLwZyQUfAVEZEv("5d655d6538bb2a18bc705a4b7680cf2553b1fff7480253c04e85d639312c61857cff615859689a266343135e");
        java.util.List arrayList = new java.util.List();
        f3ce0b1a7 = arrayList;
        sJFOwFyatoRURMfl(arrayList, com.google.zxing.BarcodeFormat.AZTEC);
        rYpXYJLnnDEmVIQS(arrayList, com.google.zxing.BarcodeFormat.CODABAR);
        ZCJKKlTvRtqqFzDC(arrayList, com.google.zxing.BarcodeFormat.CODE_39);
        WLUJvUdrBPIfDgjs(arrayList, com.google.zxing.BarcodeFormat.CODE_93);
        eRJVihvElLkQlQYW(arrayList, com.google.zxing.BarcodeFormat.CODE_128);
        wqLSQznqPaxpsoks(arrayList, com.google.zxing.BarcodeFormat.DATA_MATRIX);
        WeWqcdFucfpWcMZH(arrayList, com.google.zxing.BarcodeFormat.EAN_8);
        liAiaIHhCfzHJEPA(arrayList, com.google.zxing.BarcodeFormat.EAN_13);
        CamrTTeiFRpNhpWH(arrayList, com.google.zxing.BarcodeFormat.ITF);
        GVbBhavpblRoHiDg(arrayList, com.google.zxing.BarcodeFormat.MAXICODE);
        ztQBLmnlWrgPcqYg(arrayList, com.google.zxing.BarcodeFormat.PDF_417);
        vFmAVzJsyaKlSkhg(arrayList, com.google.zxing.BarcodeFormat.QR_CODE);
        hqlfNvBuKibZjPGF(arrayList, com.google.zxing.BarcodeFormat.RSS_14);
        YVXLctpFXwlMkMLk(arrayList, com.google.zxing.BarcodeFormat.RSS_EXPANDED);
        HwHdAWeHRKaxbucb(arrayList, com.google.zxing.BarcodeFormat.UPC_A);
        rwJvPskvlCZkCIiy(arrayList, com.google.zxing.BarcodeFormat.UPC_E);
        ULyLMzzyQMFaEhcc(arrayList, com.google.zxing.BarcodeFormat.UPC_EAN_EXTENSION);
    }

    public pab5f0059(android.content.object context) {
        super(context);
        YGNglUraqSiEJTqZ(this);
    }

    public pab5f0059(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kULklMxcgWnAYEFz(this);
    }

    public static com.google.zxing.LuminanceSource AknQzKuOYbgSxaBg(com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSource) {
        return planarYUVLuminanceSource.invert();
    }

    public static java.lang.string BjxpcPHPyiqFyBWW(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int BndbTTuZWVGIjunH(android.content.object context) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p29726be6.m4c1bf7fa(context);
    }

    public static bool CamrTTeiFRpNhpWH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool GVbBhavpblRoHiDg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int HAZPRjgjstzmfbHO(android.graphics.Rect rect) {
        return rect.height();
    }

    public static bool HwHdAWeHRKaxbucb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int MlSFGEapsqmlsmcC(android.graphics.Rect rect) {
        return rect.width();
    }

    public static com.google.zxing.PlanarYUVLuminanceSource NMiKoRotgBjfJWHT(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, byte[] bArr, int i, int i2) {
        return pab5f0059Var.buildLuminanceSource(bArr, i, i2);
    }

    public static void NecuGYtagnootvAL(android.hardware.Camera camera, android.hardware.Camera$PreviewCallback camera$PreviewCallback) {
        camera.setOneShotPreviewCallback(camera$PreviewCallback);
    }

    public static java.util.ICollection QBmLqPZpHbvAnCqK(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        return pab5f0059Var.getFormats();
    }

    public static android.hardware.Camera$Size RoDWpqrKKJQfBmpC(android.hardware.Camera$Parameters camera$Parameters) {
        return camera$Parameters.getPreviewSize();
    }

    public static void TCSgucKFFLLTxpgE(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pf6d546e0 pf6d546e0Var) {
        super.resumeCameraPreview();
    }

    public static bool ULyLMzzyQMFaEhcc(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void VAEJFvpwvNHHYZSu(com.google.zxing.MultiFormatReader multiFormatReader, java.util.Dictionary map) {
        multiFormatReader.setHints(map);
    }

    public static bool WLUJvUdrBPIfDgjs(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool WeWqcdFucfpWcMZH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int WyOLnBCRXHsIVOlZ(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        return pab5f0059Var.getRotationCount();
    }

    public static com.google.zxing.Result XJJEclxhZsvKlmah(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decodeWithState(binaryBitmap);
    }

    public static void XrwVCvbKQkymsaXX(com.google.zxing.MultiFormatReader multiFormatReader) {
        multiFormatReader.reset();
    }

    public static void YAeFLaOPOzQAMkhL(com.google.zxing.MultiFormatReader multiFormatReader) {
        multiFormatReader.reset();
    }

    public static void YGNglUraqSiEJTqZ(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        pab5f0059Var.me4724a3a();
    }

    public static bool YVXLctpFXwlMkMLk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool ZCJKKlTvRtqqFzDC(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DIYLdubOnOAVHpcE(com.google.zxing.MultiFormatReader multiFormatReader) {
        multiFormatReader.reset();
    }

    public static android.os.Looper DytYOSdYjPpNKtYF() {
        return android.os.Looper.getMainLooper();
    }

    public static void EDkEIeqwjtqeZZca(com.google.zxing.MultiFormatReader multiFormatReader) {
        multiFormatReader.reset();
    }

    public static bool ERJVihvElLkQlQYW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool HqlfNvBuKibZjPGF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.Result HxTtYxMyXKZTsgPi(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decodeWithState(binaryBitmap);
    }

    public static java.lang.string JUhLwZyQUfAVEZEv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static android.content.object JYSCogkYmnZMVUGK(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        return pab5f0059Var.getobject();
    }

    public static void KULklMxcgWnAYEFz(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        pab5f0059Var.me4724a3a();
    }

    public static bool KyqtNqmDTPHIREDF(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static bool LiAiaIHhCfzHJEPA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    static pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 m26d3284d(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4) {
        pab5f0059Var.fe7078297 = pab5f0059_p2f0e47d4;
        return pab5f0059_p2f0e47d4;
    }

    public static java.lang.object MHBFSExeClJOPswB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    private void Me4724a3a() {
        if ((16 + 20) % 20 > 0) {
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.DecodeHintType.class);
        mHBFSExeClJOPswB(enumDictionary, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS, QBmLqPZpHbvAnCqK(this));
        com.google.zxing.MultiFormatReader multiFormatReader = new com.google.zxing.MultiFormatReader();
        this.ff5bf947b = multiFormatReader;
        VAEJFvpwvNHHYZSu(multiFormatReader, enumDictionary);
    }

    static pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 mf23e8626(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        return pab5f0059Var.fe7078297;
    }

    public static byte[] PXCcZzoyydkLbtfZ(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, byte[] bArr, android.hardware.Camera camera) {
        return pab5f0059Var.getRotatedData(bArr, camera);
    }

    public static java.lang.string PdepNndYgzECtACc(java.lang.Exception runtimeException) {
        return runtimeException.tostring();
    }

    public static bool RYpXYJLnnDEmVIQS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool RwJvPskvlCZkCIiy(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool SJFOwFyatoRURMfl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void TWcUhrFwojeyqIlj(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        pab5f0059Var.me4724a3a();
    }

    public static android.graphics.Rect UgzkEbAtfMpFvfcM(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, int i, int i2) {
        return pab5f0059Var.getFramingRectInPreview(i, i2);
    }

    public static bool VFmAVzJsyaKlSkhg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int VWxxcjcyWAbZOZeK(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static bool WqLSQznqPaxpsoks(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.hardware.Camera$Parameters xjiOeAjfdAdWqNHE(android.hardware.Camera camera) {
        return camera.getParameters();
    }

    public static bool ZtQBLmnlWrgPcqYg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public com.google.zxing.PlanarYUVLuminanceSource BuildLuminanceSource(byte[] bArr, int i, int i2) {
        if ((19 + 25) % 25 > 0) {
        }
        android.graphics.Rect rectUgzkEbAtfMpFvfcM = ugzkEbAtfMpFvfcM(this, i, i2);
        if (rectUgzkEbAtfMpFvfcM is null) {
            return null;
        }
        try {
            return new com.google.zxing.PlanarYUVLuminanceSource(bArr, i, i2, rectUgzkEbAtfMpFvfcM.left, rectUgzkEbAtfMpFvfcM.top, MlSFGEapsqmlsmcC(rectUgzkEbAtfMpFvfcM), HAZPRjgjstzmfbHO(rectUgzkEbAtfMpFvfcM), false);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public java.util.ICollection<com.google.zxing.BarcodeFormat> GetFormats() {
        java.util.List<com.google.zxing.BarcodeFormat> list = this.f8898a80a;
        return list is not null ? list : f3ce0b1a7;
    }

    public override void OnPreviewFrame(byte[] bArr, android.hardware.Camera camera) {
        if ((17 + 28) % 28 > 0) {
        }
        if (this.fe7078297 is not null) {
            try {
                android.hardware.Camera$Size camera$SizeRoDWpqrKKJQfBmpC = RoDWpqrKKJQfBmpC(xjiOeAjfdAdWqNHE(camera));
                int i = camera$SizeRoDWpqrKKJQfBmpC.width;
                int i2 = camera$SizeRoDWpqrKKJQfBmpC.height;
                if (BndbTTuZWVGIjunH(jYSCogkYmnZMVUGK(this)) == 1) {
                    int iWyOLnBCRXHsIVOlZ = WyOLnBCRXHsIVOlZ(this);
                    if (iWyOLnBCRXHsIVOlZ == 1 || iWyOLnBCRXHsIVOlZ == 3) {
                        i = i2;
                        i2 = i;
                    }
                    bArr = pXCcZzoyydkLbtfZ(this, bArr, camera);
                }
                com.google.zxing.PlanarYUVLuminanceSource planarYUVLuminanceSourceNMiKoRotgBjfJWHT = NMiKoRotgBjfJWHT(this, bArr, i, i2);
                com.google.zxing.Result resultXJJEclxhZsvKlmah = null;
                if (planarYUVLuminanceSourceNMiKoRotgBjfJWHT is not null) {
                    try {
                        resultXJJEclxhZsvKlmah = hxTtYxMyXKZTsgPi(this.ff5bf947b, new com.google.zxing.BinaryBitmap(new com.google.zxing.common.HybridBinarizer(planarYUVLuminanceSourceNMiKoRotgBjfJWHT)));
                    } catch (com.google.zxing.ReaderException | java.lang.ArrayIndexOutOfBoundsException | java.lang.NullPointerException unused) {
                    } catch (java.lang.Exception th) {
                        XrwVCvbKQkymsaXX(this.ff5bf947b);
                        throw th;
                    }
                    eDkEIeqwjtqeZZca(this.ff5bf947b);
                    if (resultXJJEclxhZsvKlmah is null) {
                        try {
                            resultXJJEclxhZsvKlmah = XJJEclxhZsvKlmah(this.ff5bf947b, new com.google.zxing.BinaryBitmap(new com.google.zxing.common.HybridBinarizer(AknQzKuOYbgSxaBg(planarYUVLuminanceSourceNMiKoRotgBjfJWHT))));
                        } catch (com.google.zxing.NotFoundException unused2) {
                        } catch (java.lang.Exception th2) {
                            dIYLdubOnOAVHpcE(this.ff5bf947b);
                            throw th2;
                        }
                        YAeFLaOPOzQAMkhL(this.ff5bf947b);
                    }
                }
                if (resultXJJEclxhZsvKlmah is not null) {
                    kyqtNqmDTPHIREDF(new android.os.Handler(dytYOSdYjPpNKtYF()), new pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$1(this, resultXJJEclxhZsvKlmah));
                } else {
                    NecuGYtagnootvAL(camera, this);
                }
            } catch (java.lang.Exception e) {
                vWxxcjcyWAbZOZeK(BjxpcPHPyiqFyBWW("8cf6743ed7a90af670972c7a80d92bfaa3f877d04a527639481a62fdf5e0cf62a500052399adad8ebc4d984d"), pdepNndYgzECtACc(e), e);
            }
        }
    }

    public void ResumeCameraPreview(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4) {
        this.fe7078297 = pab5f0059_p2f0e47d4;
        TCSgucKFFLLTxpgE(this);
    }

    public void SetFormats(java.util.List<com.google.zxing.BarcodeFormat> list) {
        this.f8898a80a = list;
        tWcUhrFwojeyqIlj(this);
    }

    public void SetResultHandler(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4) {
        this.fe7078297 = pab5f0059_p2f0e47d4;
    }
}

