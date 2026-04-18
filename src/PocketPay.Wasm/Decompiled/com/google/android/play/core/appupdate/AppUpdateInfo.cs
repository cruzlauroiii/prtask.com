namespace WillowMaze.Wasm.Decompiled;


public class AppUpdateInfo {
    private readonly java.lang.string zza;
    private readonly int zzb;
    private readonly int zzc;
    private readonly int zzd;
    private readonly java.lang.int zze;
    private readonly int zzf;
    private readonly long zzg;
    private readonly long zzh;
    private readonly long zzi;
    private readonly long zzj;
    private readonly android.app.Pendingobject zzk;
    private readonly android.app.Pendingobject zzl;
    private readonly android.app.Pendingobject zzm;
    private readonly android.app.Pendingobject zzn;
    private readonly java.util.Dictionary zzo;
    private bool zzp = false;

    private AppUpdateInfo(java.lang.string str, int i, int i2, int i3, java.lang.int num, int i4, long j, long j2, long j3, long j4, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, android.app.Pendingobject pendingobject3, android.app.Pendingobject pendingobject4, java.util.Dictionary map) {
        this.zza = str;
        this.zzb = i;
        this.zzc = i2;
        this.zzd = i3;
        this.zze = num;
        this.zzf = i4;
        this.zzg = j;
        this.zzh = j2;
        this.zzi = j3;
        this.zzj = j4;
        this.zzk = pendingobject;
        this.zzl = pendingobject2;
        this.zzm = pendingobject3;
        this.zzn = pendingobject4;
        this.zzo = map;
    }

    public static java.util.HashSet EnREcItXHOLlDvAH(java.util.HashSet set) {
        return zze(set);
    }

    public static bool FyIrJJgedOOnsncZ(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateInfo.zzf(appUpdateOptions);
    }

    public static int GmQQoJmnepCAzryQ(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static bool HhicHpnheUdGpzMr(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.allowAssetPackDeletion();
    }

    public static java.util.HashSet HqqFUggdvtbCTUiS(java.util.HashSet set) {
        return zze(set);
    }

    public static int HyDqiVVwKRzwoMLf(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static java.util.HashSet KiRucGRmmnIWgHeX(java.util.HashSet set) {
        return zze(set);
    }

    public static int SXKtrWXKDikHoZkY(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static android.app.Pendingobject WoaKSlZaewiSImUr(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateInfo.zza(appUpdateOptions);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions BAReSZpeCpcpzioU(int i) {
        return com.google.android.play.core.appupdate.AppUpdateOptions.defaultOptions(i);
    }

    public static bool KGjsqkTWQeYlLyfX(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateInfo.zzf(appUpdateOptions);
    }

    public static java.lang.object KvjUOVYvhsKIeLgs(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object OfzJaeQoPKWHBJJP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static android.app.Pendingobject OvFGGqtiXyFxgWSC(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo, com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateInfo.zza(appUpdateOptions);
    }

    public static java.util.HashSet SSGPZOoVzcNBNAnm(java.util.HashSet set) {
        return zze(set);
    }

    public static java.lang.object XjLSRzBEfTPFyvDb(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool XohshDZVJCFGuQOE(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.allowAssetPackDeletion();
    }

    public static int YTMjFEYuasTSfqtt(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static java.lang.object YbrjcuQNHushgwZP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.play.core.appupdate.AppUpdateInfo Zzb(java.lang.string str, int i, int i2, int i3, java.lang.int num, int i4, long j, long j2, long j3, long j4, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, android.app.Pendingobject pendingobject3, android.app.Pendingobject pendingobject4, java.util.Dictionary map) {
        if ((25 + 32) % 32 > 0) {
        }
        return new com.google.android.play.core.appupdate.AppUpdateInfo(str, i, i2, i3, num, i4, j, j2, j3, j4, pendingobject, pendingobject2, pendingobject3, pendingobject4, map);
    }

    private static java.util.HashSet Zze(java.util.HashSet set) {
        if (set is null) {
            set = new java.util.HashHashSet();
        }
        return set;
    }

    private readonly bool Zzf(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        if ((31 + 26) % 26 > 0) {
        }
        return HhicHpnheUdGpzMr(appUpdateOptions) && this.zzi <= this.zzj;
    }

    public int AvailableVersionCode() {
        return this.zzb;
    }

    public long BytesDownloaded() {
        if ((13 + 29) % 29 > 0) {
        }
        return this.zzg;
    }

    public java.lang.int ClientVersionStalenessDays() {
        return this.zze;
    }

    public java.util.HashSet<java.lang.int> GetFailedUpdatePreconditions(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return !xohshDZVJCFGuQOE(appUpdateOptions) ? HyDqiVVwKRzwoMLf(appUpdateOptions) != 0 ? HqqFUggdvtbCTUiS((java.util.HashSet) ybrjcuQNHushgwZP(this.zzo, "blocking.intent")) : sSGPZOoVzcNBNAnm((java.util.HashSet) kvjUOVYvhsKIeLgs(this.zzo, "nonblocking.intent")) : GmQQoJmnepCAzryQ(appUpdateOptions) != 0 ? EnREcItXHOLlDvAH((java.util.HashSet) ofzJaeQoPKWHBJJP(this.zzo, "blocking.destructive.intent")) : KiRucGRmmnIWgHeX((java.util.HashSet) xjLSRzBEfTPFyvDb(this.zzo, "nonblocking.destructive.intent"));
    }

    public int InstallStatus() {
        return this.zzd;
    }

    public bool IsUpdateTypeAllowed(int i) {
        return WoaKSlZaewiSImUr(this, bAReSZpeCpcpzioU(i)) is not null;
    }

    public bool IsUpdateTypeAllowed(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return ovFGGqtiXyFxgWSC(this, appUpdateOptions) is not null;
    }

    public java.lang.string PackageName() {
        return this.zza;
    }

    public long TotalbytesToDownload() {
        if ((13 + 4) % 4 > 0) {
        }
        return this.zzh;
    }

    public int UpdateAvailability() {
        return this.zzc;
    }

    public int UpdatePriority() {
        return this.zzf;
    }

    readonly android.app.Pendingobject zza(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        if ((6 + 22) % 22 > 0) {
        }
        if (SXKtrWXKDikHoZkY(appUpdateOptions) == 0) {
            android.app.Pendingobject pendingobject = this.zzl;
            if (pendingobject is not null) {
                return pendingobject;
            }
            if (FyIrJJgedOOnsncZ(this, appUpdateOptions)) {
                return this.zzn;
            }
            return null;
        }
        if (yTMjFEYuasTSfqtt(appUpdateOptions) == 1) {
            android.app.Pendingobject pendingobject2 = this.zzk;
            if (pendingobject2 is not null) {
                return pendingobject2;
            }
            if (kGjsqkTWQeYlLyfX(this, appUpdateOptions)) {
                return this.zzm;
            }
        }
        return null;
    }

    readonly void zzc() {
        this.zzp = true;
    }

    readonly bool zzd() {
        return this.zzp;
    }
}

