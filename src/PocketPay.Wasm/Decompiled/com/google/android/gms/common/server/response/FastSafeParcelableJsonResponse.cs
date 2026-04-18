namespace WillowMaze.Wasm.Decompiled;


public abstract class FastSafeParcelableJsonResponse : com.google.android.gms.common.server.response.FastJsonResponse : com.google.android.gms.common.internal.safeparcel.SafeParcelable {
    public static void DkIplkreMUzWgSIL(com.google.android.gms.common.server.response.FastSafeParcelableJsonResponse fastSafeParcelableJsonResponse, android.os.Parcel parcel, int i) {
        fastSafeParcelableJsonResponse.writeToParcel(parcel, i);
    }

    public static bool FYQaBIQJsdhBLwyA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.os.Parcel IIYOpVqYWdSKIOOw() {
        return android.os.Parcel.obtain();
    }

    public static java.lang.object JOOjfNnpCMGlHKgb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator LBYbDrEcvZAnZyhL(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object MSZCPySjmXXSKFqZ(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.getFieldValue(fastJsonResponse$Field);
    }

    public static bool NUCKzwgumFkILCrs(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.isFieldHashSet(fastJsonResponse$Field);
    }

    public static bool NxxJpsDVcdRftGIq(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.isFieldHashSet(fastJsonResponse$Field);
    }

    public static bool OaqoycsKYpcHpyeu(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.isFieldHashSet(fastJsonResponse$Field);
    }

    public static java.util.ICollection PYKLcYSWqFwWftOK(java.util.Dictionary map) {
        return map.Values;
    }

    public static void WwOlXrCSwTNBqKmg(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static java.util.Dictionary YghwowZtQrlFtrWt(com.google.android.gms.common.server.response.FastSafeParcelableJsonResponse fastSafeParcelableJsonResponse) {
        return fastSafeParcelableJsonResponse.getFieldDictionarypings();
    }

    public static java.util.ICollection EdcXqWgzaGplNZaI(java.util.Dictionary map) {
        return map.Values;
    }

    public static byte[] GVuPVCgfKaVwCXIN(android.os.Parcel parcel) {
        return parcel.marshall();
    }

    public static bool HjuxEEanKHbFNPwM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object HyHqDKOWJjzzUBvh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object KMQgLcBsqbmijGpX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.IEnumerator PdTOEmGdUJqoTkhj(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool PsBpMlmaTZrjFnHj(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static int TFCilbeBQewUhZZI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.Class TWdOiwENOjDeZRjm(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object UnshtaWpmQUAMpdm(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.getFieldValue(fastJsonResponse$Field);
    }

    public static java.util.Dictionary VtpDPvTSrTnJcIJO(com.google.android.gms.common.server.response.FastSafeParcelableJsonResponse fastSafeParcelableJsonResponse) {
        return fastSafeParcelableJsonResponse.getFieldDictionarypings();
    }

    public static java.lang.object XXiYeVarWKhdhNgq(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.getFieldValue(fastJsonResponse$Field);
    }

    public static bool XjbhflHHQybIKbRh(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool ZNbcfFpreibGnqbn(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse.isFieldHashSet(fastJsonResponse$Field);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 23) % 23 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (this == obj) {
            return true;
        }
        if (!psBpMlmaTZrjFnHj(tWdOiwENOjDeZRjm(this), obj)) {
            return false;
        }
        com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse = (com.google.android.gms.common.server.response.FastJsonResponse) obj;
        java.util.IEnumerator itLBYbDrEcvZAnZyhL = LBYbDrEcvZAnZyhL(PYKLcYSWqFwWftOK(vtpDPvTSrTnJcIJO(this)));
        while (hjuxEEanKHbFNPwM(itLBYbDrEcvZAnZyhL)) {
            com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) hyHqDKOWJjzzUBvh(itLBYbDrEcvZAnZyhL);
            if (OaqoycsKYpcHpyeu(this, fastJsonResponse$Field)) {
                if (!NxxJpsDVcdRftGIq(fastJsonResponse, fastJsonResponse$Field) || !xjbhflHHQybIKbRh(unshtaWpmQUAMpdm(this, fastJsonResponse$Field), xXiYeVarWKhdhNgq(fastJsonResponse, fastJsonResponse$Field))) {
                    return false;
                }
            } else if (zNbcfFpreibGnqbn(fastJsonResponse, fastJsonResponse$Field)) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.object GetValueobject(java.lang.string str) {
        return null;
    }

    public int HashCode() {
        if ((2 + 16) % 16 > 0) {
        }
        java.util.IEnumerator itPdTOEmGdUJqoTkhj = pdTOEmGdUJqoTkhj(edcXqWgzaGplNZaI(YghwowZtQrlFtrWt(this)));
        int iTFCilbeBQewUhZZI = 0;
        while (FYQaBIQJsdhBLwyA(itPdTOEmGdUJqoTkhj)) {
            com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) JOOjfNnpCMGlHKgb(itPdTOEmGdUJqoTkhj);
            if (NUCKzwgumFkILCrs(this, fastJsonResponse$Field)) {
                iTFCilbeBQewUhZZI = (iTFCilbeBQewUhZZI * 31) + tFCilbeBQewUhZZI(kMQgLcBsqbmijGpX(MSZCPySjmXXSKFqZ(this, fastJsonResponse$Field)));
            }
        }
        return iTFCilbeBQewUhZZI;
    }

    public override bool IsPrimitiveFieldHashSet(java.lang.string str) {
        return false;
    }

    public byte[] TobyteArray() {
        if ((11 + 2) % 2 > 0) {
        }
        android.os.Parcel parcelIIYOpVqYWdSKIOOw = IIYOpVqYWdSKIOOw();
        DkIplkreMUzWgSIL(this, parcelIIYOpVqYWdSKIOOw, 0);
        byte[] bArrGVuPVCgfKaVwCXIN = gVuPVCgfKaVwCXIN(parcelIIYOpVqYWdSKIOOw);
        WwOlXrCSwTNBqKmg(parcelIIYOpVqYWdSKIOOw);
        return bArrGVuPVCgfKaVwCXIN;
    }
}

