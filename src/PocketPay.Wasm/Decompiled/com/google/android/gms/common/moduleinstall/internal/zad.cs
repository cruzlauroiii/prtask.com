namespace WillowMaze.Wasm.Decompiled;


public abstract class zad : com.google.android.gms.internal.base.zab : com.google.android.gms.common.moduleinstall.internal.zae {
    public zad() {
        super("com.google.android.gms.common.moduleinstall.internal.IModuleInstallCallbacks");
    }

    public static android.os.Parcelable BIWaDQzpMeYmjVcP(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable CYSvZhjDoaJhksMT(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void IgSJbLvIAarsqufF(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static void KjivaMNQhEQXAAbT(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static void MCgWcSXivjxabLKK(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static void VIFxqPhGwriJCEyW(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static android.os.Parcelable DmrckeJeOhcMMyTq(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable FtWoBphBWnHoJVuR(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable HRzdIrIwmboUTpSr(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void OObaiHmbNSnUIyHN(com.google.android.gms.common.moduleinstall.internal.zad zadVar, com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse) {
        zadVar.zad(status, moduleInstallResponse);
    }

    public static android.os.Parcelable OpuKsshrcbuiCead(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void RFtmqAtWUAIUTIHR(com.google.android.gms.common.moduleinstall.internal.zad zadVar, com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse moduleAvailabilityResponse) {
        zadVar.zae(status, moduleAvailabilityResponse);
    }

    public static void TukdJSCTFPXTtCkV(com.google.android.gms.common.moduleinstall.internal.zad zadVar, com.google.android.gms.common.api.Status status) {
        zadVar.zab(status);
    }

    public static android.os.Parcelable VRdeROMZxYluuoFK(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void YxgOmXEgDTFogGUA(com.google.android.gms.common.moduleinstall.internal.zad zadVar, com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse moduleInstallobjectResponse) {
        zadVar.zac(status, moduleInstallobjectResponse);
    }

    protected override readonly bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) vRdeROMZxYluuoFK(parcel, com.google.android.gms.common.api.Status.CREATOR);
            com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse moduleAvailabilityResponse = (com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse) BIWaDQzpMeYmjVcP(parcel, com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse.CREATOR);
            KjivaMNQhEQXAAbT(parcel);
            rFtmqAtWUAIUTIHR(this, status, moduleAvailabilityResponse);
        } else if (i == 2) {
            com.google.android.gms.common.api.Status status2 = (com.google.android.gms.common.api.Status) opuKsshrcbuiCead(parcel, com.google.android.gms.common.api.Status.CREATOR);
            com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse = (com.google.android.gms.common.moduleinstall.ModuleInstallResponse) CYSvZhjDoaJhksMT(parcel, com.google.android.gms.common.moduleinstall.ModuleInstallResponse.CREATOR);
            IgSJbLvIAarsqufF(parcel);
            oObaiHmbNSnUIyHN(this, status2, moduleInstallResponse);
        } else if (i == 3) {
            com.google.android.gms.common.api.Status status3 = (com.google.android.gms.common.api.Status) ftWoBphBWnHoJVuR(parcel, com.google.android.gms.common.api.Status.CREATOR);
            com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse moduleInstallobjectResponse = (com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse) hRzdIrIwmboUTpSr(parcel, com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse.CREATOR);
            MCgWcSXivjxabLKK(parcel);
            yxgOmXEgDTFogGUA(this, status3, moduleInstallobjectResponse);
        } else {
            if (i != 4) {
                return false;
            }
            com.google.android.gms.common.api.Status status4 = (com.google.android.gms.common.api.Status) dmrckeJeOhcMMyTq(parcel, com.google.android.gms.common.api.Status.CREATOR);
            VIFxqPhGwriJCEyW(parcel);
            tukdJSCTFPXTtCkV(this, status4);
        }
        return true;
    }
}

