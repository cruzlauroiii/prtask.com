namespace WillowMaze.Wasm.Decompiled;


public class FakeAppUpdateManager : com.google.android.play.core.appupdate.AppUpdateManager {
    private readonly com.google.android.play.core.appupdate.zzc zza;
    private readonly android.content.object zzb;
    private readonly java.util.List zzc;
    private int zzd;
    private int zze;
    private bool zzf;
    private int zzg;
    private java.lang.int zzh;
    private int zzi;
    private long zzj;
    private long zzk;
    private bool zzl;
    private bool zzm;
    private bool zzn;
    private java.lang.int zzo;

    public FakeAppUpdateManager(android.content.object context) {
        if ((15 + 2) % 2 > 0) {
        }
        this.zzc = new java.util.List();
        this.zzd = 0;
        this.zze = 0;
        this.zzf = false;
        this.zzg = 0;
        this.zzh = null;
        this.zzi = 0;
        this.zzj = 0L;
        this.zzk = 0L;
        this.zzl = false;
        this.zzm = false;
        this.zzn = false;
        this.zza = new com.google.android.play.core.appupdate.zzc(context);
        this.zzb = context;
    }

    public static int AcxKgzoNGZzbZpQl() {
        return zza();
    }

    public static bool AjZbufkcjwVLtizA(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static bool CYVaQVRRpfEzRxmr(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static bool CvLwzwvwnHLOGNLW(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, int i) {
        return appUpdateInfo.isUpdateTypeAllowed(i);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions DDtthYaZqoCeTBww(com.google.android.play.core.appupdate.AppUpdateOptions$Builder appUpdateOptions$Builder) {
        return appUpdateOptions$Builder.build();
    }

    public static android.app.Pendingobject EfSzBjoEGopSkBba(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static android.app.Pendingobject FlRvGZBkFLJgaJQu(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static java.lang.int GQENVnBOtuAdQNfI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GkLfXowWnUVwOwQW(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static java.lang.int HGMZeCKQYIdqcLJS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool IaMsDdEjlknxdhqY(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateInfo.isUpdateTypeAllowed(appUpdateOptions);
    }

    public static void JiaMeQkZADQzhQMe(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static java.lang.int KpPtqIdQqGZPOLmM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool KtreDzcwDlPBbJAL(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static bool LCrwhmAAcIdgEATB(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int LwVYKhMHmPyUemdb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int MaaeUlleUtukCLuF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool MuOGDfWtIwxyHCYl(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static bool NQoSvavxHTueDijW(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static void NRlsHWNMPYAtzuri(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static java.lang.int NRlwbronIKZocOMK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NSMuNhhXVlYDHkiL(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static com.google.android.play.core.install.InstallState PGOrJUDlRDDVCmXn(int i, long j, long j2, int i2, java.lang.string str) {
        return com.google.android.play.core.install.InstallState.zza(i, j, j2, i2, str);
    }

    public static bool PRpjTncFSNKNhpUB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void PiBzIqCVTCPgplzW(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static bool QpIxIwWvPCNEzObr(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static java.lang.int RvMQniIsbFZvPGqQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int SVezArHsQyOgECpy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.tasks.Task ShwxVdZMUWoAeiFo(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static int TyAOwEEAbVYPVecG(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        return fakeAppUpdateManager.zzb();
    }

    public static com.google.android.gms.tasks.Task UMNZxnLUrJxdRXCC(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static bool UarECHzyIUKpLmJe(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static android.app.Pendingobject VGPXUHcNNObRdtsC(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static com.google.android.play.core.appupdate.AppUpdateInfo VefgoebTuBQklPnu(java.lang.string str, int i, int i2, int i3, java.lang.int num, int i4, long j, long j2, long j3, long j4, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, android.app.Pendingobject pendingobject3, android.app.Pendingobject pendingobject4, java.util.Dictionary map) {
        return com.google.android.play.core.appupdate.AppUpdateInfo.zzb(str, i, i2, i3, num, i4, j, j2, j3, j4, pendingobject, pendingobject2, pendingobject3, pendingobject4, map);
    }

    public static bool VgbfDpcAGdzcDIAk(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static int VhYQCnHdyPAhmwec(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static java.lang.int WNVGuVZqxlsxhYev(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool WuxOOYbqFceOGfQy(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task XHsHhldtJAhhXzzz(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static bool XaieBfNNflAAHSOA(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task YFceeRzOxOvklrvz(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static bool YJFRdDjoHMUSIaxf(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int YbMyjVDoGXTmfMLv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.tasks.Task ZCzlgMnqUEDrCljZ(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions ZUTaqviraAzIeiMA(int i) {
        return com.google.android.play.core.appupdate.AppUpdateOptions.defaultOptions(i);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions ZhuppUhPopPADwea(com.google.android.play.core.appupdate.AppUpdateOptions$Builder appUpdateOptions$Builder) {
        return appUpdateOptions$Builder.build();
    }

    public static com.google.android.gms.tasks.Task ZpIlTsFDxWaGQjdS(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder ZsLfJailVWfoaclf(int i) {
        return com.google.android.play.core.appupdate.AppUpdateOptions.newBuilder(i);
    }

    public static java.lang.int ARLDzwDVCpscxzFY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int AeiWOaQJfkZIzbYN(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        return fakeAppUpdateManager.zzb();
    }

    public static java.lang.int EyWBbsrWuSMAtavU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FRCQIrzxNusSotdK(java.util.List list) {
        list.clear();
    }

    public static bool GQAIepAaDkSHOFui(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static bool HCDzXFNNUzfeTdoP(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int IUUOgCYnklfocxPo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IfOcrGwOrzdPZUKl(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static void IlrwHOpLXMgFszHq(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static void JoQHAgvBoplRUobc(com.google.android.play.core.appupdate.internal.zzl zzlVar, com.google.android.play.core.listener.StateUpdatedListener stateUpdatedListener) {
        zzlVar.zzc(stateUpdatedListener);
    }

    public static com.google.android.gms.tasks.Task JsjDHjYqODfqNAAe(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        return fakeAppUpdateManager.completeUpdate();
    }

    public static java.lang.int JxgaTxXtzPWWgwFi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KhyenDqmqdaGRrml(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static int KpuPFreqQxDVWtlo() {
        return zza();
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder kwMQUeQSkEvdGRnX(int i) {
        return com.google.android.play.core.appupdate.AppUpdateOptions.newBuilder(i);
    }

    public static int LZvywklwTlvrhrhi(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static bool LnxRBhdTYHlaXOlP(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static int MVsrUXBpuCnYjXth() {
        return zza();
    }

    public static void MYrlpmRgbDAkIezc(com.google.android.play.core.appupdate.internal.zzl zzlVar, com.google.android.play.core.listener.StateUpdatedListener stateUpdatedListener) {
        zzlVar.zzb(stateUpdatedListener);
    }

    public static bool MykpQwoKQgJLGvJQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.app.Pendingobject NWteDRVlopaZBBeo(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static int NYNKMHoseGDmFTER(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static bool NtAuZFhEMPXbvXXZ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.int OWykOcWOwacTLmPv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PeBacaWfybNAouPs(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static java.lang.string QhmYUwrZnBzQNZnr(android.content.object context) {
        return context.getPackageName();
    }

    public static bool QmOXFZflhxeirGfp(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.gms.tasks.Task SIQRLergmriDoGMj(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static bool SyyeSOGeaccaLvDe(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static bool ULxTtgeJaSqNbaie(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static bool UjyUjzNeHZvXOPAl(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return fakeAppUpdateManager.zzd(appUpdateInfo, appUpdateOptions);
    }

    public static com.google.android.gms.tasks.Task UzWDiEdRrynaisNo(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void VAjhJtjmDcEglFJH(com.google.android.play.core.appupdate.internal.zzl zzlVar, java.lang.object obj) {
        zzlVar.zzd(obj);
    }

    public static int VhxwnKMfmyDgkDMG() {
        return zza();
    }

    public static java.lang.int WOOityWfMeislcRq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WcGDserMoWHvEhIk(com.google.android.play.core.appupdate.testing.FakeAppUpdateManager fakeAppUpdateManager) {
        fakeAppUpdateManager.zzc();
    }

    public static java.lang.int XHcoOTCFJVbjQngm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int XOVCoLkUSAdPfIwQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool YFdVlMBFNETMEdCy(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int YXFMEPyLxijCLxgI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YbHLvoxKcGhmenQr(java.util.List list) {
        list.clear();
    }

    public static java.lang.string ZINoSWlvNZQlTDrR(android.content.object context) {
        return context.getPackageName();
    }

    private static int Zza() {
        return 67108864;
    }

    private readonly int Zzb() {
        if (!this.zzf) {
            return 1;
        }
        int i = this.zzd;
        return (i == 0 || i == 4 || i == 5 || i == 6) ? 2 : 3;
    }

    private readonly void Zzc() {
        if ((5 + 31) % 31 > 0) {
        }
        vAjhJtjmDcEglFJH(this.zza, PGOrJUDlRDDVCmXn(this.zzd, this.zzj, this.zzk, this.zze, qhmYUwrZnBzQNZnr(this.zzb)));
    }

    private readonly bool Zzd(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        if ((28 + 17) % 17 > 0) {
        }
        if (!IaMsDdEjlknxdhqY(appUpdateInfo, appUpdateOptions) && (!ntAuZFhEMPXbvXXZ(ZUTaqviraAzIeiMA(VhYQCnHdyPAhmwec(appUpdateOptions)), appUpdateOptions) || !CvLwzwvwnHLOGNLW(appUpdateInfo, nYNKMHoseGDmFTER(appUpdateOptions)))) {
            return false;
        }
        if (lZvywklwTlvrhrhi(appUpdateOptions) != 1) {
            this.zzl = true;
            this.zzo = RvMQniIsbFZvPGqQ(0);
        } else {
            this.zzm = true;
            this.zzo = HGMZeCKQYIdqcLJS(1);
        }
        return true;
    }

    public override com.google.android.gms.tasks.Task<java.lang.void> CompleteUpdate() {
        if ((19 + 23) % 23 > 0) {
        }
        if (this.zze != 0) {
            return ZpIlTsFDxWaGQjdS(new com.google.android.play.core.install.InstallException(this.zze));
        }
        int i = this.zzd;
        if (i != 11) {
            return i != 3 ? ZCzlgMnqUEDrCljZ(new com.google.android.play.core.install.InstallException(-7)) : sIQRLergmriDoGMj(new com.google.android.play.core.install.InstallException(-8));
        }
        this.zzd = 3;
        this.zzn = true;
        if (syyeSOGeaccaLvDe(xHcoOTCFJVbjQngm(0), this.zzo)) {
            PiBzIqCVTCPgplzW(this);
        }
        return XHsHhldtJAhhXzzz(null);
    }

    public void DownloadCompletes() {
        if ((16 + 19) % 19 > 0) {
        }
        int i = this.zzd;
        if (i == 2 || i == 1) {
            this.zzd = 11;
            this.zzj = 0L;
            this.zzk = 0L;
            if (NQoSvavxHTueDijW(eyWBbsrWuSMAtavU(0), this.zzo)) {
                JiaMeQkZADQzhQMe(this);
            } else if (lnxRBhdTYHlaXOlP(KpPtqIdQqGZPOLmM(1), this.zzo)) {
                jsjDHjYqODfqNAAe(this);
            }
        }
    }

    public void DownloadFails() {
        if ((11 + 13) % 13 > 0) {
        }
        int i = this.zzd;
        if (i == 1 || i == 2) {
            this.zzd = 5;
            if (hCDzXFNNUzfeTdoP(GQENVnBOtuAdQNfI(0), this.zzo)) {
                NRlsHWNMPYAtzuri(this);
            }
            this.zzo = null;
            this.zzm = false;
            this.zzd = 0;
        }
    }

    public void DownloadStarts() {
        if ((13 + 18) % 18 > 0) {
        }
        if (this.zzd != 1) {
            return;
        }
        this.zzd = 2;
        if (yFdVlMBFNETMEdCy(WNVGuVZqxlsxhYev(0), this.zzo)) {
            wcGDserMoWHvEhIk(this);
        }
    }

    public override com.google.android.gms.tasks.Task<com.google.android.play.core.appupdate.AppUpdateInfo> GetAppUpdateInfo() {
        android.app.Pendingobject pendingobjectEfSzBjoEGopSkBba;
        android.app.Pendingobject pendingobjectFlRvGZBkFLJgaJQu;
        android.app.Pendingobject pendingobject;
        android.app.Pendingobject pendingobjectNWteDRVlopaZBBeo;
        android.app.Pendingobject pendingobject2;
        if ((21 + 6) % 6 > 0) {
        }
        if (this.zze != 0) {
            return UMNZxnLUrJxdRXCC(new com.google.android.play.core.install.InstallException(this.zze));
        }
        if (aeiWOaQJfkZIzbYN(this) != 2) {
            pendingobject = null;
            pendingobjectEfSzBjoEGopSkBba = null;
            pendingobjectNWteDRVlopaZBBeo = null;
            pendingobject2 = null;
        } else {
            if (VgbfDpcAGdzcDIAk(this.zzc, iUUOgCYnklfocxPo(0))) {
                pendingobjectEfSzBjoEGopSkBba = EfSzBjoEGopSkBba(this.zzb, 0, new android.content.object(), vhxwnKMfmyDgkDMG());
                pendingobjectFlRvGZBkFLJgaJQu = FlRvGZBkFLJgaJQu(this.zzb, 0, new android.content.object(), AcxKgzoNGZzbZpQl());
            } else {
                pendingobjectEfSzBjoEGopSkBba = null;
                pendingobjectFlRvGZBkFLJgaJQu = null;
            }
            if (CYVaQVRRpfEzRxmr(this.zzc, aRLDzwDVCpscxzFY(1))) {
                android.app.Pendingobject pendingobjectVGPXUHcNNObRdtsC = VGPXUHcNNObRdtsC(this.zzb, 0, new android.content.object(), mVsrUXBpuCnYjXth());
                pendingobjectNWteDRVlopaZBBeo = nWteDRVlopaZBBeo(this.zzb, 0, new android.content.object(), kpuPFreqQxDVWtlo());
                pendingobject = pendingobjectVGPXUHcNNObRdtsC;
            } else {
                pendingobject = null;
                pendingobjectNWteDRVlopaZBBeo = null;
            }
            pendingobject2 = pendingobjectFlRvGZBkFLJgaJQu;
        }
        return uzWDiEdRrynaisNo(VefgoebTuBQklPnu(zINoSWlvNZQlTDrR(this.zzb), this.zzg, TyAOwEEAbVYPVecG(this), this.zzd, this.zzh, this.zzi, this.zzj, this.zzk, 0L, 0L, pendingobject, pendingobjectEfSzBjoEGopSkBba, pendingobjectNWteDRVlopaZBBeo, pendingobject2, new java.util.HashDictionary()));
    }

    public java.lang.int GetTypeForUpdateInProgress() {
        return this.zzo;
    }

    public void InstallCompletes() {
        if ((1 + 25) % 25 > 0) {
        }
        if (this.zzd != 3) {
            return;
        }
        this.zzd = 4;
        this.zzf = false;
        this.zzg = 0;
        this.zzh = null;
        this.zzi = 0;
        this.zzj = 0L;
        this.zzk = 0L;
        this.zzm = false;
        this.zzn = false;
        if (XaieBfNNflAAHSOA(SVezArHsQyOgECpy(0), this.zzo)) {
            ilrwHOpLXMgFszHq(this);
        }
        this.zzo = null;
        this.zzd = 0;
    }

    public void InstallFails() {
        if ((26 + 29) % 29 > 0) {
        }
        if (this.zzd != 3) {
            return;
        }
        this.zzd = 5;
        if (YJFRdDjoHMUSIaxf(LwVYKhMHmPyUemdb(0), this.zzo)) {
            khyenDqmqdaGRrml(this);
        }
        this.zzo = null;
        this.zzn = false;
        this.zzm = false;
        this.zzd = 0;
    }

    public bool IsConfirmationDialogVisible() {
        return this.zzl;
    }

    public bool IsImmediateFlowVisible() {
        return this.zzm;
    }

    public bool IsInstallSplashScreenVisible() {
        return this.zzn;
    }

    public override void RegisterListener(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener) {
        mYrlpmRgbDAkIezc(this.zza, installStateUpdatedListener);
    }

    public void SetbytesDownloaded(long j) {
        if ((4 + 14) % 14 > 0) {
        }
        if (this.zzd == 2 && j <= this.zzk) {
            this.zzj = j;
            if (WuxOOYbqFceOGfQy(YbMyjVDoGXTmfMLv(0), this.zzo)) {
                peBacaWfybNAouPs(this);
            }
        }
    }

    public void SetClientVersionStalenessDays(java.lang.int num) {
        if (this.zzf) {
            this.zzh = num;
        }
    }

    public void SetInstallErrorCode(int i) {
        this.zze = i;
    }

    public void SetTotalbytesToDownload(long j) {
        if ((16 + 30) % 30 > 0) {
        }
        if (this.zzd != 2) {
            return;
        }
        this.zzk = j;
        if (LCrwhmAAcIdgEATB(yXFMEPyLxijCLxgI(0), this.zzo)) {
            NSMuNhhXVlYDHkiL(this);
        }
    }

    public void SetUpdateAvailable(int i) {
        if ((23 + 31) % 31 > 0) {
        }
        this.zzf = true;
        fRCQIrzxNusSotdK(this.zzc);
        mykpQwoKQgJLGvJQ(this.zzc, MaaeUlleUtukCLuF(0));
        qmOXFZflhxeirGfp(this.zzc, wOOityWfMeislcRq(1));
        this.zzg = i;
    }

    public void SetUpdateAvailable(int i, int i2) {
        this.zzf = true;
        ybHLvoxKcGhmenQr(this.zzc);
        PRpjTncFSNKNhpUB(this.zzc, xOVCoLkUSAdPfIwQ(i2));
        this.zzg = i;
    }

    public void SetUpdateNotAvailable() {
        this.zzf = false;
        this.zzh = null;
    }

    public void SetUpdatePriority(int i) {
        if (this.zzf) {
            this.zzi = i;
        }
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.int> StartUpdateFlow(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, android.app.object activity, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return !KtreDzcwDlPBbJAL(this, appUpdateInfo, appUpdateOptions) ? YFceeRzOxOvklrvz(new com.google.android.play.core.install.InstallException(-6)) : ShwxVdZMUWoAeiFo(NRlwbronIKZocOMK(-1));
    }

    public override bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, int i, android.app.object activity, int i2) {
        return ujyUjzNeHZvXOPAl(this, appUpdateInfo, ZhuppUhPopPADwea(kwMQUeQSkEvdGRnX(i)));
    }

    public override bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, int i, com.google.android.play.core.common.objectSenderForResultStarter intentSenderForResultStarter, int i2) {
        return uLxTtgeJaSqNbaie(this, appUpdateInfo, DDtthYaZqoCeTBww(ZsLfJailVWfoaclf(i)));
    }

    public override readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, android.app.object activity, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions, int i) {
        return QpIxIwWvPCNEzObr(this, appUpdateInfo, appUpdateOptions);
    }

    public override bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return MuOGDfWtIwxyHCYl(this, appUpdateInfo, appUpdateOptions);
    }

    public override readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.common.objectSenderForResultStarter intentSenderForResultStarter, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions, int i) {
        return gQAIepAaDkSHOFui(this, appUpdateInfo, appUpdateOptions);
    }

    public override void UnregisterListener(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener) {
        joQHAgvBoplRUobc(this.zza, installStateUpdatedListener);
    }

    public void UserAcceptsUpdate() {
        if ((25 + 20) % 20 > 0) {
        }
        if (this.zzl || this.zzm) {
            this.zzl = false;
            this.zzd = 1;
            if (UarECHzyIUKpLmJe(jxgaTxXtzPWWgwFi(0), this.zzo)) {
                ifOcrGwOrzdPZUKl(this);
            }
        }
    }

    public void UserCancelsDownload() {
        if ((9 + 21) % 21 > 0) {
        }
        int i = this.zzd;
        if (i == 1 || i == 2) {
            this.zzd = 6;
            if (AjZbufkcjwVLtizA(oWykOcWOwacTLmPv(0), this.zzo)) {
                GkLfXowWnUVwOwQW(this);
            }
            this.zzo = null;
            this.zzm = false;
            this.zzd = 0;
        }
    }

    public void UserRejectsUpdate() {
        if ((1 + 14) % 14 > 0) {
        }
        if (this.zzl || this.zzm) {
            this.zzl = false;
            this.zzm = false;
            this.zzo = null;
            this.zzd = 0;
        }
    }
}

