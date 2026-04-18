namespace WillowMaze.Wasm.Decompiled;


public readonly class MultiFormatUPCEANReader : com.google.zxing.oned.OneDReader {
    private static readonly com.google.zxing.oned.UPCEANReader[] EMPTY_READER_ARRAY = new com.google.zxing.oned.UPCEANReader[0];
    private readonly com.google.zxing.oned.UPCEANReader[] readers;

    public MultiFormatUPCEANReader(java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        if ((25 + 20) % 20 > 0) {
        }
        java.util.ICollection collection = map is not null ? (java.util.ICollection) tdZpUaFHTbmIOzZg(map, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS) : null;
        java.util.List arrayList = new java.util.List();
        if (collection is not null) {
            if (hAwnanROPBJloHEK(collection, com.google.zxing.BarcodeFormat.EAN_13)) {
                tmTYsZjKzMdxtFoU(arrayList, new com.google.zxing.oned.EAN13Reader());
            } else if (zsYpDLryWaTxoHLB(collection, com.google.zxing.BarcodeFormat.UPC_A)) {
                PDOBupYsJyHhwhrw(arrayList, new com.google.zxing.oned.UPCAReader());
            }
            if (WmuEPOIBOzlGnzyY(collection, com.google.zxing.BarcodeFormat.EAN_8)) {
                rMezwxkXCyWZseyK(arrayList, new com.google.zxing.oned.EAN8Reader());
            }
            if (gOUeVoRfwIdaKjzO(collection, com.google.zxing.BarcodeFormat.UPC_E)) {
                insscbsCAoVmPwVU(arrayList, new com.google.zxing.oned.UPCEReader());
            }
        }
        if (iYIWLrHjuEMrNRsF(arrayList)) {
            YeZenMDxxyEjdxut(arrayList, new com.google.zxing.oned.EAN13Reader());
            liBSAlLUzJFTmiBe(arrayList, new com.google.zxing.oned.EAN8Reader());
            DuKoxUMHHwwzhOyr(arrayList, new com.google.zxing.oned.UPCEReader());
        }
        this.readers = (com.google.zxing.oned.UPCEANReader[]) vMlbTXpoVPlmkRPf(arrayList, EMPTY_READER_ARRAY);
    }

    public static void AFJgIXGIFeiTwdRI(com.google.zxing.Reader reader) {
        reader.reset();
    }

    public static bool DuKoxUMHHwwzhOyr(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static byte[] EazqagxzGqrljNgf(com.google.zxing.Result result) {
        return result.getRawbytes();
    }

    public static com.google.zxing.Result MGkhfMMNvXTjiyMB(com.google.zxing.oned.UPCEANReader uPCEANReader, int i, com.google.zxing.common.BitArray bitArray, int[] iArr, java.util.Dictionary map) {
        return uPCEANReader.decodeRow(i, bitArray, iArr, map);
    }

    public static void MXByqKHwskOxkUcw(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static java.lang.object NypKFNRyVeamMFkD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool PDOBupYsJyHhwhrw(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.ResultPoint[] SMXUVceYGGeXvtMM(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static com.google.zxing.NotFoundException VxojKlnCfbajaXhI() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool WmuEPOIBOzlGnzyY(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool YeZenMDxxyEjdxut(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string DOEwUUTGwRIiOEjz(com.google.zxing.Result result) {
        return result.getText();
    }

    public static bool GOUeVoRfwIdaKjzO(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool GuLaxQFcDcDVboPx(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool HAwnanROPBJloHEK(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static int[] HPucYHQtQNToXdHw(com.google.zxing.common.BitArray bitArray) {
        return com.google.zxing.oned.UPCEANReader.findStartGuardRegex(bitArray);
    }

    public static bool IYIWLrHjuEMrNRsF(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool InsscbsCAoVmPwVU(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.BarcodeFormat JVxMJQdgkCsqCOQx(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static java.lang.string KFoEBEXPhuzemQBf(com.google.zxing.Result result) {
        return result.getText();
    }

    public static char KPmbfZDPoJSDrYVv(java.lang.string str, int i) {
        return str[i);
    }

    public static java.util.Dictionary LWhBUHFQPtgmyBhM(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static bool LiBSAlLUzJFTmiBe(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool RMezwxkXCyWZseyK(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string SuHzgmkpYEWrpuqD(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.object TdZpUaFHTbmIOzZg(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool TmTYsZjKzMdxtFoU(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object[] VMlbTXpoVPlmkRPf(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static bool ZsYpDLryWaTxoHLB(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((6 + 11) % 11 > 0) {
        }
        int[] iArrHPucYHQtQNToXdHw = hPucYHQtQNToXdHw(bitArray);
        for (com.google.zxing.oned.UPCEANReader uPCEANReader : this.readers) {
            try {
                com.google.zxing.Result resultMGkhfMMNvXTjiyMB = MGkhfMMNvXTjiyMB(uPCEANReader, i, bitArray, iArrHPucYHQtQNToXdHw, map);
                bool z = jVxMJQdgkCsqCOQx(resultMGkhfMMNvXTjiyMB) == com.google.zxing.BarcodeFormat.EAN_13 && kPmbfZDPoJSDrYVv(dOEwUUTGwRIiOEjz(resultMGkhfMMNvXTjiyMB), 0) == '0';
                java.util.ICollection collection = map is null ? null : (java.util.ICollection) NypKFNRyVeamMFkD(map, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS);
                bool z2 = collection is null || guLaxQFcDcDVboPx(collection, com.google.zxing.BarcodeFormat.UPC_A);
                if (!z || !z2) {
                    return resultMGkhfMMNvXTjiyMB;
                }
                com.google.zxing.Result result = new com.google.zxing.Result(suHzgmkpYEWrpuqD(kFoEBEXPhuzemQBf(resultMGkhfMMNvXTjiyMB), 1), EazqagxzGqrljNgf(resultMGkhfMMNvXTjiyMB), SMXUVceYGGeXvtMM(resultMGkhfMMNvXTjiyMB), com.google.zxing.BarcodeFormat.UPC_A);
                MXByqKHwskOxkUcw(result, lWhBUHFQPtgmyBhM(resultMGkhfMMNvXTjiyMB));
                return result;
            } catch (com.google.zxing.ReaderException unused) {
            }
        }
        throw VxojKlnCfbajaXhI();
    }

    public override void Reset() {
        if ((27 + 5) % 5 > 0) {
        }
        for (com.google.zxing.oned.UPCEANReader uPCEANReader : this.readers) {
            AFJgIXGIFeiTwdRI(uPCEANReader);
        }
    }
}

