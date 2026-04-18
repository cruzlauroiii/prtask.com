namespace WillowMaze.Wasm.Decompiled;


public readonly class MultiFormatReader : com.google.zxing.Reader {
    private static readonly com.google.zxing.Reader[] EMPTY_READER_ARRAY = new com.google.zxing.Reader[0];
    private java.util.Dictionary<com.google.zxing.DecodeHintType, ?> hints;
    private com.google.zxing.Reader[] readers;

    public static bool AhvSbGPvPbKYTnuO(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool BfJAlXJTWpKEfher(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool DMejfJesKRYTRQmn(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool FrLpsnZfzZcyNnil(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool GnOUkhDxpKfCufGs(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool HbrpLoGdJEgEWVcT(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool HoWQuvotKAYhpydG(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool LgcDchJUieutgqPy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool MTtGAIqKyqKhUrtz(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool QMNrsfnnCRRvSilt(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.NotFoundException REkMBnVTJmGCISgz() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool RlZOgviZcgKswVkb(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static com.google.zxing.Result SXGfjMitBnUeXRvk(com.google.zxing.Reader reader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return reader.decode(binaryBitmap, map);
    }

    public static com.google.zxing.common.BitMatrix UERPfCqpYTyisRMH(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static bool UcrjjDGWZsZNeJAk(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static java.lang.object VFAcViJyDiYPrARD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void VGustLmPAMmmusOh(com.google.zxing.Reader reader) {
        reader.reset();
    }

    public static com.google.zxing.Result VeTrgnncWaPNlwlC(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decodeInternal(binaryBitmap);
    }

    public static java.lang.object[] WICLyQzxTrGOQpsE(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static com.google.zxing.Result WVMHrTknDHMLoPvc(com.google.zxing.Reader reader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return reader.decode(binaryBitmap, map);
    }

    public static bool XaPBnKNPuhrrpCdE(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool YQGquzqRYxoAcXHZ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void ZTGLrWTeQpzMnBLp(com.google.zxing.common.BitMatrix bitMatrix) {
        bitMatrix.flip();
    }

    public static bool ZYoxahKpZxsbOXhB(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool ACRiXgIvCBmATtuh(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool AUWHLwzJKOlHIixQ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool AcFCyGBjiUKPXUHK(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool AtqaTNsCnmkbSADi(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool BHbkLOHnieEiMpDC(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    private com.google.zxing.Result DecodeInternal(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        if ((30 + 30) % 30 > 0) {
        }
        com.google.zxing.Reader[] readerArr = this.readers;
        if (readerArr is not null) {
            for (com.google.zxing.Reader reader : readerArr) {
                try {
                    return SXGfjMitBnUeXRvk(reader, binaryBitmap, this.hints);
                } catch (com.google.zxing.ReaderException unused) {
                }
            }
            java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map = this.hints;
            if (map is not null && HoWQuvotKAYhpydG(map, com.google.zxing.DecodeHintType.ALSO_INVERTED)) {
                ZTGLrWTeQpzMnBLp(UERPfCqpYTyisRMH(binaryBitmap));
                for (com.google.zxing.Reader reader2 : this.readers) {
                    try {
                        return WVMHrTknDHMLoPvc(reader2, binaryBitmap, this.hints);
                    } catch (com.google.zxing.ReaderException unused2) {
                    }
                }
            }
        }
        throw REkMBnVTJmGCISgz();
    }

    public static void DgRBKRxwhqZFWJIf(com.google.zxing.MultiFormatReader multiFormatReader, java.util.Dictionary map) {
        multiFormatReader.setHints(map);
    }

    public static bool DnTPnFlojAabspkq(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool DoyFhnUldRmEFqAo(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool GTUFoAzcDbzUebGF(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool HKoUFQaTFwCiTBkj(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static void KExkqyTPJAzUqJCT(com.google.zxing.MultiFormatReader multiFormatReader, java.util.Dictionary map) {
        multiFormatReader.setHints(map);
    }

    public static bool KVIBwEztYQJJbbZV(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool MZIEmvZdNRFAPlPu(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static void RMJIVLcirteBwQHX(com.google.zxing.MultiFormatReader multiFormatReader, java.util.Dictionary map) {
        multiFormatReader.setHints(map);
    }

    public static bool SHOhAmZtArrJLPpi(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool SPWYVhTlmEAhchpa(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool SubflpgqxgrdCCiJ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static com.google.zxing.Result UfOolazbcRuULZQG(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decodeInternal(binaryBitmap);
    }

    public static bool WDQynLzJCEnwqMHw(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.Result WZmjIVRqwRBbDxEU(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decodeInternal(binaryBitmap);
    }

    public static bool WhpuqSuYAyeUDjIJ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool YITurdrBYkUVpTGJ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool YqhMItJCAZSshAGu(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        dgRBKRxwhqZFWJIf(this, null);
        return wZmjIVRqwRBbDxEU(this, binaryBitmap);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        rMJIVLcirteBwQHX(this, map);
        return VeTrgnncWaPNlwlC(this, binaryBitmap);
    }

    public com.google.zxing.Result DecodeWithState(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        if (this.readers is null) {
            kExkqyTPJAzUqJCT(this, null);
        }
        return ufOolazbcRuULZQG(this, binaryBitmap);
    }

    public override void Reset() {
        if ((1 + 22) % 22 > 0) {
        }
        com.google.zxing.Reader[] readerArr = this.readers;
        if (readerArr is null) {
            return;
        }
        for (com.google.zxing.Reader reader : readerArr) {
            VGustLmPAMmmusOh(reader);
        }
    }

    public void SetHints(java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        if ((18 + 8) % 8 > 0) {
        }
        this.hints = map;
        bool z = true;
        bool z2 = map is not null && whpuqSuYAyeUDjIJ(map, com.google.zxing.DecodeHintType.TRY_HARDER);
        java.util.ICollection collection = map is not null ? (java.util.ICollection) VFAcViJyDiYPrARD(map, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS) : null;
        java.util.List arrayList = new java.util.List();
        if (collection is not null) {
            if (!gTUFoAzcDbzUebGF(collection, com.google.zxing.BarcodeFormat.UPC_A) && !hKoUFQaTFwCiTBkj(collection, com.google.zxing.BarcodeFormat.UPC_E) && !aCRiXgIvCBmATtuh(collection, com.google.zxing.BarcodeFormat.EAN_13) && !doyFhnUldRmEFqAo(collection, com.google.zxing.BarcodeFormat.EAN_8) && !atqaTNsCnmkbSADi(collection, com.google.zxing.BarcodeFormat.CODABAR) && !aUWHLwzJKOlHIixQ(collection, com.google.zxing.BarcodeFormat.CODE_39) && !GnOUkhDxpKfCufGs(collection, com.google.zxing.BarcodeFormat.CODE_93) && !MTtGAIqKyqKhUrtz(collection, com.google.zxing.BarcodeFormat.CODE_128) && !sHOhAmZtArrJLPpi(collection, com.google.zxing.BarcodeFormat.ITF) && !sPWYVhTlmEAhchpa(collection, com.google.zxing.BarcodeFormat.RSS_14) && !mZIEmvZdNRFAPlPu(collection, com.google.zxing.BarcodeFormat.RSS_EXPANDED)) {
                z = false;
            }
            if (z && !z2) {
                BfJAlXJTWpKEfher(arrayList, new com.google.zxing.oned.MultiFormatOneDReader(map));
            }
            if (subflpgqxgrdCCiJ(collection, com.google.zxing.BarcodeFormat.QR_CODE)) {
                bHbkLOHnieEiMpDC(arrayList, new com.google.zxing.qrcode.QRCodeReader());
            }
            if (UcrjjDGWZsZNeJAk(collection, com.google.zxing.BarcodeFormat.DATA_MATRIX)) {
                YQGquzqRYxoAcXHZ(arrayList, new com.google.zxing.datamatrix.DataMatrixReader());
            }
            if (DMejfJesKRYTRQmn(collection, com.google.zxing.BarcodeFormat.AZTEC)) {
                acFCyGBjiUKPXUHK(arrayList, new com.google.zxing.aztec.AztecReader());
            }
            if (RlZOgviZcgKswVkb(collection, com.google.zxing.BarcodeFormat.PDF_417)) {
                wDQynLzJCEnwqMHw(arrayList, new com.google.zxing.pdf417.PDF417Reader());
            }
            if (LgcDchJUieutgqPy(collection, com.google.zxing.BarcodeFormat.MAXICODE)) {
                yqhMItJCAZSshAGu(arrayList, new com.google.zxing.maxicode.MaxiCodeReader());
            }
            if (z && z2) {
                yITurdrBYkUVpTGJ(arrayList, new com.google.zxing.oned.MultiFormatOneDReader(map));
            }
        }
        if (FrLpsnZfzZcyNnil(arrayList)) {
            if (!z2) {
                XaPBnKNPuhrrpCdE(arrayList, new com.google.zxing.oned.MultiFormatOneDReader(map));
            }
            AhvSbGPvPbKYTnuO(arrayList, new com.google.zxing.qrcode.QRCodeReader());
            QMNrsfnnCRRvSilt(arrayList, new com.google.zxing.datamatrix.DataMatrixReader());
            dnTPnFlojAabspkq(arrayList, new com.google.zxing.aztec.AztecReader());
            ZYoxahKpZxsbOXhB(arrayList, new com.google.zxing.pdf417.PDF417Reader());
            HbrpLoGdJEgEWVcT(arrayList, new com.google.zxing.maxicode.MaxiCodeReader());
            if (z2) {
                kVIBwEztYQJJbbZV(arrayList, new com.google.zxing.oned.MultiFormatOneDReader(map));
            }
        }
        this.readers = (com.google.zxing.Reader[]) WICLyQzxTrGOQpsE(arrayList, EMPTY_READER_ARRAY);
    }
}

