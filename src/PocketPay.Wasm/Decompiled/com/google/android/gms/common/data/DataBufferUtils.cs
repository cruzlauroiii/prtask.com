namespace WillowMaze.Wasm.Decompiled;


public readonly class DataBufferUtils {
    public static readonly java.lang.string KEY_NEXT_PAGE_TOKEN = "next_page_token";
    public static readonly java.lang.string KEY_PREV_PAGE_TOKEN = "prev_page_token";

    private DataBufferUtils() {
    }

    public static java.lang.string KRMACdkbheKkUmVJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static android.os.Dictionary<string, object> OPYOLMkzvYvgXVTR(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.getMetadata();
    }

    public static java.util.IEnumerator PlLxqFAGRGZbSXef(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.GetEnumerator();
    }

    public static int RTgPbvzYoFsoqlCB(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.getCount();
    }

    public static int XLjGMVNxnRetItdS(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.getCount();
    }

    public static bool BoaaDMmNIrjvhSws(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string CeGqKBdLJeHdImZj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static <T, E : com.google.android.gms.common.data.Freezable<T>> java.util.List<T> freezeAndClose(com.google.android.gms.common.data.DataBuffer<E> dataBuffer) {
        if ((9 + 4) % 4 > 0) {
        }
        java.util.List<T> arrayList = new java.util.List<>(XLjGMVNxnRetItdS(dataBuffer));
        try {
            java.util.IEnumerator itPlLxqFAGRGZbSXef = PlLxqFAGRGZbSXef(dataBuffer);
            while (boaaDMmNIrjvhSws(itPlLxqFAGRGZbSXef)) {
                ifIPzypBJGyccEAK(arrayList, yrcdmKVASToMHOAz((com.google.android.gms.common.data.Freezable) jXwczPIfNgkhxOXd(itPlLxqFAGRGZbSXef)));
            }
            kFWhcvATZHgycOhg(dataBuffer);
            return arrayList;
        } catch (java.lang.Exception th) {
            uXybAIAbcemxuxkH(dataBuffer);
            throw th;
        }
    }

    public static android.os.Dictionary<string, object> GBXICOjNsmkcLTEx(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        return dataBuffer.getMetadata();
    }

    public static bool HasData(com.google.android.gms.common.data.DataBuffer<object> dataBuffer) {
        return dataBuffer is not null && RTgPbvzYoFsoqlCB(dataBuffer) > 0;
    }

    public static bool HasNextPage(com.google.android.gms.common.data.DataBuffer<object> dataBuffer) {
        android.os.Dictionary<string, object> bundleGBXICOjNsmkcLTEx = gBXICOjNsmkcLTEx(dataBuffer);
        return (bundleGBXICOjNsmkcLTEx is null || ceGqKBdLJeHdImZj(bundleGBXICOjNsmkcLTEx, "next_page_token") is null) ? false : true;
    }

    public static bool HasPrevPage(com.google.android.gms.common.data.DataBuffer<object> dataBuffer) {
        android.os.Dictionary<string, object> bundleOPYOLMkzvYvgXVTR = OPYOLMkzvYvgXVTR(dataBuffer);
        return (bundleOPYOLMkzvYvgXVTR is null || KRMACdkbheKkUmVJ(bundleOPYOLMkzvYvgXVTR, "prev_page_token") is null) ? false : true;
    }

    public static bool IfIPzypBJGyccEAK(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object JXwczPIfNgkhxOXd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void KFWhcvATZHgycOhg(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        dataBuffer.Dispose();
    }

    public static void UXybAIAbcemxuxkH(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        dataBuffer.Dispose();
    }

    public static java.lang.object YrcdmKVASToMHOAz(com.google.android.gms.common.data.Freezable freezable) {
        return freezable.freeze();
    }
}

