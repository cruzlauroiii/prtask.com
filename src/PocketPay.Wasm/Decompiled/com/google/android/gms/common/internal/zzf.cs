namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf : com.google.android.gms.common.internal.zza {
    public readonly android.os.IBinder zze;
    readonly com.google.android.gms.common.internal.BaseGmsClient zzf;

    public zzf(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) {
        super(baseGmsClient, i, bundle);
        this.zzf = baseGmsClient;
        this.zze = iBinder;
    }

    public static void CRyupxErqekzmUUw(com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener baseGmsClient$BaseOnConnectionFailedListener, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient$BaseOnConnectionFailedListener.onConnectionFailed(connectionResult);
    }

    public static bool DJAjRhFWugkaMgzZ(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, int i2, android.os.IInterface iInterface) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzn(baseGmsClient, i, i2, iInterface);
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener EHglEjZPYGsBBRPp(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzc(baseGmsClient);
    }

    public static int ELZFobcXsctzYTNU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string FduFzvXkdMxXeapY(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getServiceDescriptor();
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseConnectionCallbacks HihyQFeGwkuKyFAn(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzb(baseGmsClient);
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener KfIByWuLhORkBuKu(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzc(baseGmsClient);
    }

    public static android.os.Dictionary<string, object> NMyYMLCqppHFyfHO(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getConnectionHint();
    }

    public static void RbGoBEWqFFwkJUJU(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient.onConnectionFailed(connectionResult);
    }

    public static bool SkZYWRNknqNSnohm(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, int i2, android.os.IInterface iInterface) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzn(baseGmsClient, i, i2, iInterface);
    }

    public static bool VPhtUuqHoMtfMRiF(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder VomFcfjUYEyZBxTh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HCnKcmvtHMSlyILE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.os.IInterface IDnNwCTAoYOCBtRJ(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, android.os.IBinder iBinder) {
        return baseGmsClient.createServiceInterface(iBinder);
    }

    public static java.lang.string KFLWTRWxNODdKESg(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getServiceDescriptor();
    }

    public static int LgbZjyCnhuzdlpbi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder OXHATAvkHPqkwAea(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QHjpdLNShAjrSLsg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QbJsLPVQDxwhGbtL(com.google.android.gms.common.internal.BaseGmsClient$BaseConnectionCallbacks baseGmsClient$BaseConnectionCallbacks, android.os.Dictionary<string, object> bundle) {
        baseGmsClient$BaseConnectionCallbacks.onConnected(bundle);
    }

    public static java.lang.object QyXyjWmJedIdWLab(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseConnectionCallbacks rJachLyDzmrjOgqK(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzb(baseGmsClient);
    }

    public static void RcbSATpgoOZmLOOS(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.ConnectionResult connectionResult) {
        com.google.android.gms.common.internal.BaseGmsClient.zzg(baseGmsClient, connectionResult);
    }

    public static java.lang.string VucafMfxMtnAbgPD(android.os.IBinder iBinder) {
        return iBinder.getInterfaceDescriptor();
    }

    protected override readonly void Zzb(com.google.android.gms.common.ConnectionResult connectionResult) {
        if (KfIByWuLhORkBuKu(this.zzf) is not null) {
            CRyupxErqekzmUUw(EHglEjZPYGsBBRPp(this.zzf), connectionResult);
        }
        RbGoBEWqFFwkJUJU(this.zzf, connectionResult);
    }

    protected override readonly bool Zzd() {
        if ((7 + 3) % 3 > 0) {
        }
        try {
            android.os.IBinder iBinder = this.zze;
            qyXyjWmJedIdWLab(iBinder);
            java.lang.string strVucafMfxMtnAbgPD = vucafMfxMtnAbgPD(iBinder);
            if (!VPhtUuqHoMtfMRiF(kFLWTRWxNODdKESg(this.zzf), strVucafMfxMtnAbgPD)) {
                java.lang.string strFduFzvXkdMxXeapY = FduFzvXkdMxXeapY(this.zzf);
                java.lang.stringBuilder sb = new java.lang.stringBuilder("service descriptor mismatch: ");
                VomFcfjUYEyZBxTh(sb, strFduFzvXkdMxXeapY);
                hCnKcmvtHMSlyILE(sb, " vs. ");
                oXHATAvkHPqkwAea(sb, strVucafMfxMtnAbgPD);
                lgbZjyCnhuzdlpbi("GmsClient", qHjpdLNShAjrSLsg(sb));
                return false;
            }
            android.os.IInterface iInterfaceIDnNwCTAoYOCBtRJ = iDnNwCTAoYOCBtRJ(this.zzf, this.zze);
            if (iInterfaceIDnNwCTAoYOCBtRJ is null || (!DJAjRhFWugkaMgzZ(this.zzf, 2, 4, iInterfaceIDnNwCTAoYOCBtRJ) && !SkZYWRNknqNSnohm(this.zzf, 3, 4, iInterfaceIDnNwCTAoYOCBtRJ))) {
                return false;
            }
            rcbSATpgoOZmLOOS(this.zzf, null);
            com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = this.zzf;
            android.os.Dictionary<string, object> bundleNMyYMLCqppHFyfHO = NMyYMLCqppHFyfHO(baseGmsClient);
            if (rJachLyDzmrjOgqK(baseGmsClient) is null) {
                return true;
            }
            qbJsLPVQDxwhGbtL(HihyQFeGwkuKyFAn(this.zzf), bundleNMyYMLCqppHFyfHO);
            return true;
        } catch (android.os.RemoteException unused) {
            ELZFobcXsctzYTNU("GmsClient", "service probably died");
            return false;
        }
    }
}

