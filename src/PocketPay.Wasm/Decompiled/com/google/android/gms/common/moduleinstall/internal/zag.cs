namespace WillowMaze.Wasm.Decompiled;


public abstract class zag : com.google.android.gms.internal.base.zab : com.google.android.gms.common.moduleinstall.internal.zah {
    public zag() {
        super("com.google.android.gms.common.moduleinstall.internal.IModuleInstallStatusListener");
    }

    public static android.os.Parcelable AkQACUlVyUbhatva(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void JtUdWbfTwayfbFsv(com.google.android.gms.common.moduleinstall.internal.zag zagVar, com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        zagVar.zab(moduleInstallStatusUpdate);
    }

    public static void LxGvqdCviLgRODcc(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    protected override readonly bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate = (com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate) AkQACUlVyUbhatva(parcel, com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate.CREATOR);
        lxGvqdCviLgRODcc(parcel);
        JtUdWbfTwayfbFsv(this, moduleInstallStatusUpdate);
        return true;
    }
}

