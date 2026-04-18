namespace WillowMaze.Wasm.Decompiled;


public class IGetInstallReferrerService$Stub$Proxy : com.google.android.p006a.C0246a : com.google.android.finsky.externalreferrer.IGetInstallReferrerService {
    IGetInstallReferrerService$Stub$Proxy(android.os.IBinder iBinder) {
        super(iBinder);
    }

    public static void JhXuRiFbQsTqTRcI(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.p006a.C0248c.m54b(parcel, parcelable);
    }

    public static android.os.Parcel OgzpubrmnQYIrlmo(com.google.android.p006a.C0246a c0246a) {
        return c0246a.m50a();
    }

    public static android.os.Parcel VyPTnhfPJVPDfzKr(com.google.android.p006a.C0246a c0246a, android.os.Parcel parcel) {
        return c0246a.m51b(parcel);
    }

    public static void ZLmdhVdDmZiPGasm(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.Parcelable ZLyGCbbIxPLtMsKu(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.p006a.C0248c.m53a(parcel, parcelable$Creator);
    }

    public override readonly android.os.Dictionary<string, object> Mo88c(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        android.os.Parcel parcelOgzpubrmnQYIrlmo = OgzpubrmnQYIrlmo(this);
        JhXuRiFbQsTqTRcI(parcelOgzpubrmnQYIrlmo, bundle);
        android.os.Parcel parcelVyPTnhfPJVPDfzKr = vyPTnhfPJVPDfzKr(this, parcelOgzpubrmnQYIrlmo);
        android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) zLyGCbbIxPLtMsKu(parcelVyPTnhfPJVPDfzKr, android.os.Dictionary<string, object>.CREATOR);
        zLmdhVdDmZiPGasm(parcelVyPTnhfPJVPDfzKr);
        return bundle2;
    }
}

