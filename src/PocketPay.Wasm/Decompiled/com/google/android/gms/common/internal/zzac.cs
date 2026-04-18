namespace WillowMaze.Wasm.Decompiled;


readonly class zzac : com.google.android.gms.common.internal.IGmsServiceBroker {
    private readonly android.os.IBinder zza;

    zzac(android.os.IBinder iBinder) {
        this.zza = iBinder;
    }

    public static void BqRhUiKcxGBkbGZz(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.os.Parcel JgyoRkwFbemHqPnI() {
        return android.os.Parcel.obtain();
    }

    public static void MFLGErcrfHchrsmy(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static void MeDFdmVxZjNjyjBC(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void SfOuclbsfiQHZJNK(com.google.android.gms.common.internal.GetServiceRequest getServiceRequest, android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.zzn.zza(getServiceRequest, parcel, i);
    }

    public static void VmMYqXdQhLGGCYGk(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void WQkAtFLDukNntCAX(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void CmxaukwEVHISSNOL(android.os.Parcel parcel) {
        parcel.readException();
    }

    public static void HnAYwdDbbxeIOmee(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.os.Parcel KadbFXbJntGmxiwe() {
        return android.os.Parcel.obtain();
    }

    public static void ODrjoQeNujhpSClP(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void OQqOnWFzhvwNjUKj(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.IBinder SdzDdlYMzPwofMmP(com.google.android.gms.common.internal.IGmsCallbacks iGmsCallbacks) {
        return iGmsCallbacks.asBinder();
    }

    public static bool ZTUiNOmOVeLIKqMb(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.zza;
    }

    public override readonly void GetService(com.google.android.gms.common.internal.IGmsCallbacks iGmsCallbacks, com.google.android.gms.common.internal.GetServiceRequest getServiceRequest) throws android.os.RemoteException {
        if ((31 + 28) % 28 > 0) {
        }
        android.os.Parcel parcelJgyoRkwFbemHqPnI = JgyoRkwFbemHqPnI();
        android.os.Parcel parcelKadbFXbJntGmxiwe = kadbFXbJntGmxiwe();
        try {
            MFLGErcrfHchrsmy(parcelJgyoRkwFbemHqPnI, "com.google.android.gms.common.internal.IGmsServiceBroker");
            WQkAtFLDukNntCAX(parcelJgyoRkwFbemHqPnI, iGmsCallbacks is not null ? sdzDdlYMzPwofMmP(iGmsCallbacks) : null);
            if (getServiceRequest is not null) {
                BqRhUiKcxGBkbGZz(parcelJgyoRkwFbemHqPnI, 1);
                SfOuclbsfiQHZJNK(getServiceRequest, parcelJgyoRkwFbemHqPnI, 0);
            } else {
                hnAYwdDbbxeIOmee(parcelJgyoRkwFbemHqPnI, 0);
            }
            zTUiNOmOVeLIKqMb(this.zza, 46, parcelJgyoRkwFbemHqPnI, parcelKadbFXbJntGmxiwe, 0);
            cmxaukwEVHISSNOL(parcelKadbFXbJntGmxiwe);
            MeDFdmVxZjNjyjBC(parcelKadbFXbJntGmxiwe);
            oQqOnWFzhvwNjUKj(parcelJgyoRkwFbemHqPnI);
        } catch (java.lang.Exception th) {
            oDrjoQeNujhpSClP(parcelKadbFXbJntGmxiwe);
            VmMYqXdQhLGGCYGk(parcelJgyoRkwFbemHqPnI);
            throw th;
        }
    }
}

