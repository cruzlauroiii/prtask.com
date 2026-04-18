namespace WillowMaze.Wasm.Decompiled;


public readonly class MultiFormatOneDReader : com.google.zxing.oned.OneDReader {
    private static readonly com.google.zxing.oned.OneDReader[] EMPTY_ONED_ARRAY = new com.google.zxing.oned.OneDReader[0];
    private readonly com.google.zxing.oned.OneDReader[] readers;

    public MultiFormatOneDReader(java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        if ((24 + 15) % 15 > 0) {
        }
        java.util.ICollection collection = map is not null ? (java.util.ICollection) VOfzIiYisNXdUGto(map, com.google.zxing.DecodeHintType.POSSIBLE_FORMATS) : null;
        bool z = (map is null || jvJuewYIoZkyGLGj(map, com.google.zxing.DecodeHintType.ASSUME_CODE_39_CHECK_DIGIT) is null) ? false : true;
        java.util.List arrayList = new java.util.List();
        if (collection is not null) {
            if (edCBmZhaIfBjRJer(collection, com.google.zxing.BarcodeFormat.EAN_13) || cyPXsobJgdUMHXma(collection, com.google.zxing.BarcodeFormat.UPC_A) || CoszZmaWebjknZFc(collection, com.google.zxing.BarcodeFormat.EAN_8) || dtkNRhuTkWCyEGtF(collection, com.google.zxing.BarcodeFormat.UPC_E)) {
                tgUuykqZhaspfGql(arrayList, new com.google.zxing.oned.MultiFormatUPCEANReader(map));
            }
            if (JamEJwdrSZXHnVUH(collection, com.google.zxing.BarcodeFormat.CODE_39)) {
                aZqiZbrSFFcxQVnb(arrayList, new com.google.zxing.oned.Code39Reader(z));
            }
            if (xFUovHBZFLyPSnyd(collection, com.google.zxing.BarcodeFormat.CODE_93)) {
                YTlMSskMWMlfNVdU(arrayList, new com.google.zxing.oned.Code93Reader());
            }
            if (etdtGYiEaVmMFODD(collection, com.google.zxing.BarcodeFormat.CODE_128)) {
                ZPKdoUyqmLDljIGA(arrayList, new com.google.zxing.oned.Code128Reader());
            }
            if (CdSjWFNCLBpigLca(collection, com.google.zxing.BarcodeFormat.ITF)) {
                IIXaZZXyuWUELgoc(arrayList, new com.google.zxing.oned.ITFReader());
            }
            if (msGbKIukDEdmDTGY(collection, com.google.zxing.BarcodeFormat.CODABAR)) {
                nghBPGuZmsnklkdX(arrayList, new com.google.zxing.oned.CodaBarReader());
            }
            if (mvafpODEUWLylWWk(collection, com.google.zxing.BarcodeFormat.RSS_14)) {
                PEyLYuWXZZEoRiYa(arrayList, new com.google.zxing.oned.rss.RSS14Reader());
            }
            if (IDUJPPjSgUdTzQwx(collection, com.google.zxing.BarcodeFormat.RSS_EXPANDED)) {
                MShycMphGVEiqdhw(arrayList, new com.google.zxing.oned.rss.expanded.RSSExpandedReader());
            }
        }
        if (YPfMfeRmbUJAwUpd(arrayList)) {
            TnUEtvIVORTiSybg(arrayList, new com.google.zxing.oned.MultiFormatUPCEANReader(map));
            RPSgZYbHdFimfwHh(arrayList, new com.google.zxing.oned.Code39Reader());
            IVRJfLtjYSzxXBzw(arrayList, new com.google.zxing.oned.CodaBarReader());
            vjZeGdqZvjxagcdy(arrayList, new com.google.zxing.oned.Code93Reader());
            qkiiwuaYUyDkJnYi(arrayList, new com.google.zxing.oned.Code128Reader());
            SEXauDnLyObhKFMT(arrayList, new com.google.zxing.oned.ITFReader());
            vIpFceyVNkrwOvqg(arrayList, new com.google.zxing.oned.rss.RSS14Reader());
            tvbzZjLEAukheLHa(arrayList, new com.google.zxing.oned.rss.expanded.RSSExpandedReader());
        }
        this.readers = (com.google.zxing.oned.OneDReader[]) JPDlUsmBqrwghodj(arrayList, EMPTY_ONED_ARRAY);
    }

    public static com.google.zxing.Result ASBrFZQQsXzDSxmT(com.google.zxing.oned.OneDReader oneDReader, int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary map) {
        return oneDReader.decodeRow(i, bitArray, map);
    }

    public static bool CdSjWFNCLBpigLca(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool CoszZmaWebjknZFc(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static void FRCIFWCofIYBdZkB(com.google.zxing.Reader reader) {
        reader.reset();
    }

    public static bool IDUJPPjSgUdTzQwx(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool IIXaZZXyuWUELgoc(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool IVRJfLtjYSzxXBzw(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object[] JPDlUsmBqrwghodj(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static bool JamEJwdrSZXHnVUH(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool MShycMphGVEiqdhw(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool PEyLYuWXZZEoRiYa(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool RPSgZYbHdFimfwHh(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool SEXauDnLyObhKFMT(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool TnUEtvIVORTiSybg(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object VOfzIiYisNXdUGto(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool YPfMfeRmbUJAwUpd(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool YTlMSskMWMlfNVdU(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool ZPKdoUyqmLDljIGA(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool AZqiZbrSFFcxQVnb(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool CyPXsobJgdUMHXma(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool DtkNRhuTkWCyEGtF(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool EdCBmZhaIfBjRJer(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool EtdtGYiEaVmMFODD(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static java.lang.object JvJuewYIoZkyGLGj(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool MsGbKIukDEdmDTGY(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool MvafpODEUWLylWWk(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static com.google.zxing.NotFoundException NJvLFiXQFxxSehWY() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool NghBPGuZmsnklkdX(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool QkiiwuaYUyDkJnYi(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool TgUuykqZhaspfGql(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool TvbzZjLEAukheLHa(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool VIpFceyVNkrwOvqg(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool VjZeGdqZvjxagcdy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool XFUovHBZFLyPSnyd(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((23 + 2) % 2 > 0) {
        }
        com.google.zxing.oned.OneDReader[] oneDReaderArr = this.readers;
        for (int i2 = 0; i2 < oneDReaderArr.length; i2++) {
            try {
                return ASBrFZQQsXzDSxmT(oneDReaderArr[i2], i, bitArray, map);
            } catch (com.google.zxing.ReaderException unused) {
            }
        }
        throw nJvLFiXQFxxSehWY();
    }

    public override void Reset() {
        if ((28 + 27) % 27 > 0) {
        }
        for (com.google.zxing.oned.OneDReader oneDReader : this.readers) {
            FRCIFWCofIYBdZkB(oneDReader);
        }
    }
}

