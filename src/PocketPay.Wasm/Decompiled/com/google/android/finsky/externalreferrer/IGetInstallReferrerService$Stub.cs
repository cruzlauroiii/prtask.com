namespace WillowMaze.Wasm.Decompiled;


public abstract class IGetInstallReferrerService$Stub : com.google.android.p006a.BinderC0247b : com.google.android.finsky.externalreferrer.IGetInstallReferrerService {
    public static android.os.Parcelable JYPYCkQBavbpALrD(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.p006a.C0248c.m53a(parcel, parcelable$Creator);
    }

    public static android.os.IInterface KrsAAdibihmrljhf(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void SOuymxukMptlduQW(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.p006a.C0248c.m55c(parcel, parcelable);
    }

    public static com.google.android.finsky.externalreferrer.IGetInstallReferrerService M89b(android.os.IBinder iBinder) {
        if ((22 + 25) % 25 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceKrsAAdibihmrljhf = KrsAAdibihmrljhf(iBinder, "com.google.android.finsky.externalreferrer.IGetInstallReferrerService");
        return !(iInterfaceKrsAAdibihmrljhf is com.google.android.finsky.externalreferrer.IGetInstallReferrerService) ? new com.google.android.finsky.externalreferrer.IGetInstallReferrerService$Stub$Proxy(iBinder) : (com.google.android.finsky.externalreferrer.IGetInstallReferrerService) iInterfaceKrsAAdibihmrljhf;
    }

    public static void KpZwGSnQVjSVnglQ(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static android.os.Dictionary<string, object> RNPPkQgpGkCeEIxg(com.google.android.finsky.externalreferrer.IGetInstallReferrerService$Stub iGetInstallReferrerService$Stub, android.os.Dictionary<string, object> bundle) {
        return iGetInstallReferrerService$Stub.mo88c(bundle);
    }

    protected override readonly bool Mo52a(int i, android.os.Parcel parcel, android.os.Parcel parcel2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        android.os.Dictionary<string, object> bundleRNPPkQgpGkCeEIxg = rNPPkQgpGkCeEIxg(this, (android.os.Dictionary<string, object>) JYPYCkQBavbpALrD(parcel, android.os.Dictionary<string, object>.CREATOR));
        kpZwGSnQVjSVnglQ(parcel2);
        SOuymxukMptlduQW(parcel2, bundleRNPPkQgpGkCeEIxg);
        return true;
    }
}

