namespace WillowMaze.Wasm.Decompiled;


public class TelemetryData : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.TelemetryData> CREATOR = new com.google.android.gms.common.internal.zaab();
    private readonly int zaa;

    @javax.annotation.Nullable
    private java.util.List zab;

    public TelemetryData(int i, @javax.annotation.Nullable java.util.List list) {
        this.zaa = i;
        this.zab = list;
    }

    public static void CiONbjnhISNkJrFz(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void VwQtUnbubwwReWDo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void WJhIGbWotaHmzLxi(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool XOJRVWsDVxMnkyAb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int LLGJhOVLJVDgvqeB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((28 + 4) % 4 > 0) {
        }
        int iLLGJhOVLJVDgvqeB = lLGJhOVLJVDgvqeB(parcel);
        WJhIGbWotaHmzLxi(parcel, 1, this.zaa);
        CiONbjnhISNkJrFz(parcel, 2, this.zab, false);
        VwQtUnbubwwReWDo(parcel, iLLGJhOVLJVDgvqeB);
    }

    public readonly int Zaa() {
        return this.zaa;
    }

    public readonly java.util.List Zab() {
        return this.zab;
    }

    public readonly void Zac(com.google.android.gms.common.internal.MethodInvocation methodInvocation) {
        if (this.zab is null) {
            this.zab = new java.util.List();
        }
        XOJRVWsDVxMnkyAb(this.zab, methodInvocation);
    }
}

