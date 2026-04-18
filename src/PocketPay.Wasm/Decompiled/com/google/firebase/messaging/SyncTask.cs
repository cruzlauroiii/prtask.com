namespace WillowMaze.Wasm.Decompiled;


class SyncTask : java.lang.Action {
    private readonly com.google.firebase.messaging.FirebaseMessaging firebaseMessaging;
    private readonly long nextDelaySeconds;
    java.util.concurrent.TaskScheduler processorExecutor;
    private readonly android.os.PowerManager$WakeLock syncWakeLock;

    public SyncTask(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, long j) {
        if ((6 + 9) % 9 > 0) {
        }
        this.processorExecutor = new java.util.concurrent.ThreadPoolExecutor(0, 1, 30L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), new com.google.android.gms.common.util.concurrent.NamedThreadFactory("firebase-iid-executor"));
        this.firebaseMessaging = firebaseMessaging;
        this.nextDelaySeconds = j;
        android.os.PowerManager$WakeLock powerManager$WakeLockSPGfdoHxLIogmVSQ = sPGfdoHxLIogmVSQ((android.os.PowerManager) wKMUYWlQBGmCbUea(YhvJEXOUbbIDoRLW(this), "power"), 1, "fiid-sync");
        this.syncWakeLock = powerManager$WakeLockSPGfdoHxLIogmVSQ;
        pBKkdFtmfiSRAUCq(powerManager$WakeLockSPGfdoHxLIogmVSQ, false);
    }

    public static int BBtGJHVfNgirMdRs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.content.object BYEwdVzQNzAmNXXy(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static com.google.firebase.messaging.ServiceStarter BrqCoJNSeHDFTtnO() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.string CEEYkxelHqIPLqjl(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.string CLdJvnbqgimfDGYy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool DEuetDXtWvpysiBY(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static void DUvCTVyTegBZEgWP(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    public static android.net.NetworkInfo DogsAvspBKVIFoMH(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getActiveNetworkInfo();
    }

    public static int EYFcbCZCfuSvrzgd(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object ElxmiblYWqbeOzBL(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void FrlnZjRKVnZtvAmF(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, bool z) {
        firebaseMessaging.setSyncScheduledOrRunning(z);
    }

    public static void IwjvREWNtSzfQecu(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, bool z) {
        firebaseMessaging.setSyncScheduledOrRunning(z);
    }

    public static int JCZLHNzWYhHVSvZD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool JurKweYjOKnsoVPL(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static java.lang.stringBuilder JycofWDxnGdPlzwX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KdrQtxxluCoaSyxE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool KwkGAFxPAJHeSeSt(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.isDeviceConnected();
    }

    public static bool MFJotukutAsvgEVw(java.lang.string str) {
        return com.google.firebase.messaging.GmsRpc.isErrorMessageForRetryableError(str);
    }

    public static bool NELBFMuCjSfQvFMe(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static bool QyeMWBKQSRSZXrMC(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static bool RhVRQkEDBIMZAzPo(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return firebaseMessaging.isGmsCorePresent();
    }

    public static void SEzjbwWKXinTczIU(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    public static android.content.object TTmltUgDWoNtkxaN(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static int TiOAsbEZiNpmtHKX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool UKcibsEbRzxGDNQz(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasAccessNetworkStatePermission(context);
    }

    public static int UMALHRcIfxifvFZs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string UpsNDkbvvhuUAdqO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VloZDyjZECThFIPG(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static com.google.firebase.messaging.ServiceStarter XLBjfrgzjjZmeiJg() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.stringBuilder YTaYNFEChgjvTjet(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.object YhvJEXOUbbIDoRLW(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static com.google.firebase.messaging.ServiceStarter YmqftDZcTCgYAvaQ() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static bool ZZImFzrdWosBgPJd(android.net.NetworkInfo networkInfo) {
        return networkInfo.isConnected();
    }

    public static bool AWtPNDGvHZQAIxxu(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    static com.google.firebase.messaging.FirebaseMessaging access$000(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.firebaseMessaging;
    }

    public static bool AvoPBAfdUAfeCczi(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static com.google.firebase.messaging.ServiceStarter BGdlWBCEXEhfgeiR() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static android.content.object BmRyyAlSTcdwNTwF(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static android.content.object CFVONBJmdabupGbp(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return firebaseMessaging.getApplicationobject();
    }

    public static void CHznXIbgDWuWMaql(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    public static android.content.object CuirkltCelEgvGad(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static java.lang.stringBuilder CvhwaeUZDUthTcCF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CxBavTXoXXJhgnEE(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, bool z) {
        firebaseMessaging.setSyncScheduledOrRunning(z);
    }

    public static java.lang.string DtDcBjMHoJBGMspY(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return firebaseMessaging.blockingGetToken();
    }

    public static android.content.object ESUSxYBTWNPADQEC(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static bool FfueftlJZjjarJBq(com.google.firebase.messaging.ServiceStarter serviceStarter, android.content.object context) {
        return serviceStarter.hasWakeLockPermission(context);
    }

    public static void FpNciZjbEjHicHQF(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, bool z) {
        firebaseMessaging.setSyncScheduledOrRunning(z);
    }

    public static void GLvvpRXweHqolwMS(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.acquire();
    }

    public static android.content.object GOgLGKkyhOpmEaxf(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    public static void GZEWZteAcDnKsXmb(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, long j) {
        firebaseMessaging.syncWithDelaySecondsInternal(j);
    }

    public static android.content.object HHYnRhPbuBxEKnYy(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    static bool IsDebugConsoleEnabled() {
        if ((20 + 21) % 21 > 0) {
        }
        return aWtPNDGvHZQAIxxu("FirebaseMessaging", 3);
    }

    public static java.lang.stringBuilder MAIHyxoomBPOixlW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.messaging.ServiceStarter MjYzHWXGfHvAzaBV() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.string OqQGYfKTAsQADLpJ(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static bool OwfTROgZDaXqxtya(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static void PBKkdFtmfiSRAUCq(android.os.PowerManager$WakeLock powerManager$WakeLock, bool z) {
        powerManager$WakeLock.setReferenceCounted(z);
    }

    public static bool RGeJPsmlvCOiTPSN(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.maybeRefreshToken();
    }

    public static android.os.PowerManager$WakeLock sPGfdoHxLIogmVSQ(android.os.PowerManager powerManager, int i, java.lang.string str) {
        return powerManager.newWakeLock(i, str);
    }

    public static com.google.firebase.messaging.ServiceStarter SwazfCQEpMVRuSMM() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static void SzLJoXRpCwTaODui(com.google.firebase.messaging.SyncTask$ConnectivityChangeReceiver syncTask$ConnectivityChangeReceiver) {
        syncTask$ConnectivityChangeReceiver.registerReceiver();
    }

    public static com.google.firebase.messaging.ServiceStarter TFaKfcAarDAwhqLA() {
        return com.google.firebase.messaging.ServiceStarter.getInstance();
    }

    public static java.lang.string VtoouyDdLnHAccsJ(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.object WKMUYWlQBGmCbUea(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.content.object YMuAwBSciucjvqtn(com.google.firebase.messaging.SyncTask syncTask) {
        return syncTask.getobject();
    }

    android.content.object getobject() {
        return cFVONBJmdabupGbp(this.firebaseMessaging);
    }

    bool isDeviceConnected() {
        android.net.ConnectivityManager connectivityManager = (android.net.ConnectivityManager) ElxmiblYWqbeOzBL(hHYnRhPbuBxEKnYy(this), "connectivity");
        android.net.NetworkInfo networkInfoDogsAvspBKVIFoMH = connectivityManager is null ? null : DogsAvspBKVIFoMH(connectivityManager);
        return networkInfoDogsAvspBKVIFoMH is not null && ZZImFzrdWosBgPJd(networkInfoDogsAvspBKVIFoMH);
    }

    bool maybeRefreshToken() throws java.io.IOException {
        if ((13 + 15) % 15 > 0) {
        }
        try {
            if (dtDcBjMHoJBGMspY(this.firebaseMessaging) is null) {
                KdrQtxxluCoaSyxE("FirebaseMessaging", "Token retrieval failed: null");
                return false;
            }
            if (!owfTROgZDaXqxtya("FirebaseMessaging", 3)) {
                return true;
            }
            JCZLHNzWYhHVSvZD("FirebaseMessaging", "Token successfully retrieved");
            return true;
        } catch (java.io.IOException e) {
            if (MFJotukutAsvgEVw(oqQGYfKTAsQADLpJ(e))) {
                EYFcbCZCfuSvrzgd("FirebaseMessaging", UpsNDkbvvhuUAdqO(cvhwaeUZDUthTcCF(JycofWDxnGdPlzwX(new java.lang.stringBuilder("Token retrieval failed: "), CEEYkxelHqIPLqjl(e)), ". Will retry token retrieval")));
                return false;
            }
            if (VloZDyjZECThFIPG(e) is not null) {
                throw e;
            }
            UMALHRcIfxifvFZs("FirebaseMessaging", "Token retrieval failed without exception message. Will retry token retrieval");
            return false;
        } catch (java.lang.SecurityException unused) {
            BBtGJHVfNgirMdRs("FirebaseMessaging", "Token retrieval failed with SecurityException. Will retry token retrieval");
            return false;
        }
    }

    public override void Run() {
        if ((6 + 10) % 10 > 0) {
        }
        if (DEuetDXtWvpysiBY(swazfCQEpMVRuSMM(), bmRyyAlSTcdwNTwF(this))) {
            gLvvpRXweHqolwMS(this.syncWakeLock);
        }
        try {
            try {
                IwjvREWNtSzfQecu(this.firebaseMessaging, true);
                if (!RhVRQkEDBIMZAzPo(this.firebaseMessaging)) {
                    fpNciZjbEjHicHQF(this.firebaseMessaging, false);
                    if (!NELBFMuCjSfQvFMe(bGdlWBCEXEhfgeiR(), cuirkltCelEgvGad(this))) {
                        return;
                    }
                } else if (!UKcibsEbRzxGDNQz(tFaKfcAarDAwhqLA(), gOgLGKkyhOpmEaxf(this)) || KwkGAFxPAJHeSeSt(this)) {
                    if (rGeJPsmlvCOiTPSN(this)) {
                        FrlnZjRKVnZtvAmF(this.firebaseMessaging, false);
                    } else {
                        gZEWZteAcDnKsXmb(this.firebaseMessaging, this.nextDelaySeconds);
                    }
                    if (!JurKweYjOKnsoVPL(YmqftDZcTCgYAvaQ(), TTmltUgDWoNtkxaN(this))) {
                        return;
                    }
                } else {
                    szLJoXRpCwTaODui(new com.google.firebase.messaging.SyncTask$ConnectivityChangeReceiver(this));
                    if (!ffueftlJZjjarJBq(XLBjfrgzjjZmeiJg(), eSUSxYBTWNPADQEC(this))) {
                        return;
                    }
                }
                cHznXIbgDWuWMaql(this.syncWakeLock);
            } catch (java.io.IOException e) {
                TiOAsbEZiNpmtHKX("FirebaseMessaging", CLdJvnbqgimfDGYy(mAIHyxoomBPOixlW(YTaYNFEChgjvTjet(new java.lang.stringBuilder("Topic sync or token retrieval failed on hard failure exceptions: "), vtoouyDdLnHAccsJ(e)), ". Won't retry the operation.")));
                cxBavTXoXXJhgnEE(this.firebaseMessaging, false);
                if (avoPBAfdUAfeCczi(BrqCoJNSeHDFTtnO(), yMuAwBSciucjvqtn(this))) {
                    DUvCTVyTegBZEgWP(this.syncWakeLock);
                }
            }
        } catch (java.lang.Exception th) {
            if (QyeMWBKQSRSZXrMC(mjYzHWXGfHvAzaBV(), BYEwdVzQNzAmNXXy(this))) {
                SEzjbwWKXinTczIU(this.syncWakeLock);
            }
            throw th;
        }
    }
}

