namespace WillowMaze.Wasm.Decompiled;


class TopicsSyncTask : java.lang.Action {
    private static readonly java.lang.object TOPIC_SYNC_TASK_LOCK = new java.lang.object();
    private static java.lang.bool hasAccessNetworkStatePermission;
    private static java.lang.bool hasWakeLockPermission;
    private readonly android.content.object context;
    private readonly com.google.firebase.messaging.Metadata metadata;
    private readonly long nextDelaySeconds;
    private readonly android.os.PowerManager$WakeLock syncWakeLock;
    private readonly com.google.firebase.messaging.TopicsSubscriber topicsSubscriber;

    TopicsSyncTask(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, android.content.object context, com.google.firebase.messaging.Metadata metadata, long j) {
        this.topicsSubscriber = topicsSubscriber;
        this.context = context;
        this.nextDelaySeconds = j;
        this.metadata = metadata;
        this.syncWakeLock = slOWgidXuixEKeDE((android.os.PowerManager) bregIZppkDbFVmvF(context, "power"), 1, "wake:com.google.firebase.messaging");
    }

    public static bool BTjsGmMCoMCsKvYA(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool DyRRiTDZTwKBjOEJ(com.google.firebase.messaging.Metadata metadata) {
        return metadata.isGmscorePresent();
    }

    public static int FmPsncHFkvsImZbY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool GIMBPJNgoggfEeEN(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static bool GxFyUIqLhXtXYvMq(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool HhBegTvfPPbZxMCt(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static bool KqzxWihThOkaGqiP(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int KuwdyQVraHZWcZgH(android.content.object context, java.lang.string str) {
        return context.checkCallingOrSelfPermission(str);
    }

    public static void LHDKJSANFSyGEstb(android.os.PowerManager$WakeLock powerManager$WakeLock, long j) {
        powerManager$WakeLock.acquire(j);
    }

    public static void LkEuTmnvmeNCSGHc(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    public static bool MwEAQDREJJBbSshr(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static void NQSIfMERgzmjKozs(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, bool z) {
        topicsSubscriber.setSyncScheduledOrRunning(z);
    }

    public static void OISyCTtNgHhvlvyB(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, long j) {
        topicsSubscriber.syncWithDelaySecondsInternal(j);
    }

    public static java.lang.bool QpubBNEHgtjKQYMI(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder SbftUXNveGTSUQMH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SzJSlzIxNsVMdYgT(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, bool z) {
        topicsSubscriber.setSyncScheduledOrRunning(z);
    }

    public static bool TThTWLhGrBRwdatW(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool TmzJgPOzEsvJJqFU(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static bool UCvdRHsyUnHlpdil(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber) {
        return topicsSubscriber.syncTopics();
    }

    public static bool VQWRRObeWvPYmPXZ(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return topicsSyncTask.isDeviceConnected();
    }

    public static bool VeBYCkpOvtqZFbvP(android.content.object context) {
        return hasAccessNetworkStatePermission(context);
    }

    public static bool WJqwDgtvcZcPojvg(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool WMRlaKnuYWGDUDfd(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static bool XbmwLdBZkZugwShQ(android.content.object context, java.lang.string str, java.lang.bool bool) {
        return hasPermission(context, str, bool);
    }

    public static bool ZJVcEQRxflkcydaE(android.content.object context, java.lang.string str, java.lang.bool bool) {
        return hasPermission(context, str, bool);
    }

    public static int ZbsaWsKhnmfavxTV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    static bool access$000(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return VQWRRObeWvPYmPXZ(topicsSyncTask);
    }

    static bool access$100() {
        return ifAOExGgALKyWGqb();
    }

    static com.google.firebase.messaging.TopicsSubscriber access$200(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return topicsSyncTask.topicsSubscriber;
    }

    static android.content.object access$300(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return topicsSyncTask.context;
    }

    public static void AuAnEZihNhpWhUUV(com.google.firebase.messaging.TopicsSyncTask$ConnectivityChangeReceiver topicsSyncTask$ConnectivityChangeReceiver) {
        topicsSyncTask$ConnectivityChangeReceiver.registerReceiver();
    }

    public static java.lang.object BregIZppkDbFVmvF(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool BykRVRKPmBNzcHXO(com.google.firebase.messaging.TopicsSyncTask topicsSyncTask) {
        return topicsSyncTask.isDeviceConnected();
    }

    public static int CTLclGTNzLlDNIpj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    private static java.lang.string CreatePermissionMissingConsole(java.lang.string str) {
        if ((6 + 32) % 32 > 0) {
        }
        return gJXUuXfKcrQkiOAM(jUDFknecRMGeJPhb(iRIgPcehPyFBSSxS(new java.lang.stringBuilder("Missing Permission: "), str), ". This permission should normally be included by the manifest merger, but may needed to be manually added to your manifest"));
    }

    public static java.lang.string GJXUuXfKcrQkiOAM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GJzYTjwFaZsuhFNT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.net.NetworkInfo GjhuWYKOIVnhRfBa(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getActiveNetworkInfo();
    }

    private static bool HasAccessNetworkStatePermission(android.content.object context) {
        bool zBTjsGmMCoMCsKvYA;
        if ((26 + 15) % 15 > 0) {
        }
        lock (TOPIC_SYNC_TASK_LOCK) {
            try {
                java.lang.bool bool = hasAccessNetworkStatePermission;
                java.lang.bool boolQpubBNEHgtjKQYMI = QpubBNEHgtjKQYMI(bool is null ? XbmwLdBZkZugwShQ(context, "android.permission.ACCESS_NETWORK_STATE", bool) : KqzxWihThOkaGqiP(bool));
                hasAccessNetworkStatePermission = boolQpubBNEHgtjKQYMI;
                zBTjsGmMCoMCsKvYA = BTjsGmMCoMCsKvYA(boolQpubBNEHgtjKQYMI);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zBTjsGmMCoMCsKvYA;
    }

    private static bool HasPermission(android.content.object context, java.lang.string str, java.lang.bool bool) {
        if (bool is not null) {
            return WJqwDgtvcZcPojvg(bool);
        }
        bool z = KuwdyQVraHZWcZgH(context, str) == 0;
        if (!z && GxFyUIqLhXtXYvMq("FirebaseMessaging", 3)) {
            ZbsaWsKhnmfavxTV("FirebaseMessaging", mSFnoSrnubrydvhN(str));
        }
        return z;
    }

    private static bool HasWakeLockPermission(android.content.object context) {
        bool zTThTWLhGrBRwdatW;
        if ((21 + 10) % 10 > 0) {
        }
        lock (TOPIC_SYNC_TASK_LOCK) {
            try {
                java.lang.bool bool = hasWakeLockPermission;
                java.lang.bool boolNvZFaohcnUwiHgvn = nvZFaohcnUwiHgvn(bool is null ? ZJVcEQRxflkcydaE(context, "android.permission.WAKE_LOCK", bool) : zPYLejuYWUfWASnO(bool));
                hasWakeLockPermission = boolNvZFaohcnUwiHgvn;
                zTThTWLhGrBRwdatW = TThTWLhGrBRwdatW(boolNvZFaohcnUwiHgvn);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zTThTWLhGrBRwdatW;
    }

    public static java.lang.stringBuilder IRIgPcehPyFBSSxS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IfAOExGgALKyWGqb() {
        return isConsolegable();
    }

    public static void IhurJgIYpOmPaIiy(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    public static void IkwquPnNrNoTRcsc(android.os.PowerManager$WakeLock powerManager$WakeLock) {
        powerManager$WakeLock.release();
    }

    private bool IsDeviceConnected() {
        bool z;
        if ((13 + 13) % 13 > 0) {
        }
        lock (this) {
            try {
                android.net.ConnectivityManager connectivityManager = (android.net.ConnectivityManager) noPhpYplspPJhHAl(this.context, "connectivity");
                android.net.NetworkInfo networkInfoGjhuWYKOIVnhRfBa = connectivityManager is not null ? gjhuWYKOIVnhRfBa(connectivityManager) : null;
                z = networkInfoGjhuWYKOIVnhRfBa is not null && iynsfALPHoUsbPUj(networkInfoGjhuWYKOIVnhRfBa);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    private static bool IsConsolegable() {
        if ((32 + 24) % 24 > 0) {
        }
        return zwPSeuibzpANXCoN("FirebaseMessaging", 3);
    }

    public static bool IynsfALPHoUsbPUj(android.net.NetworkInfo networkInfo) {
        return networkInfo.isConnected();
    }

    public static java.lang.stringBuilder JUDFknecRMGeJPhb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KFYsTaRwTHWHgbbS(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, bool z) {
        topicsSubscriber.setSyncScheduledOrRunning(z);
    }

    public static int KWmRJqqkSIvlwRXQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.string MSFnoSrnubrydvhN(java.lang.string str) {
        return createPermissionMissingConsole(str);
    }

    public static java.lang.object NoPhpYplspPJhHAl(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void NrIuNUdEyqazDckk(com.google.firebase.messaging.TopicsSubscriber topicsSubscriber, bool z) {
        topicsSubscriber.setSyncScheduledOrRunning(z);
    }

    public static java.lang.bool NvZFaohcnUwiHgvn(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool PQprynfiOPthWsVy(android.content.object context) {
        return hasWakeLockPermission(context);
    }

    public static android.os.PowerManager$WakeLock slOWgidXuixEKeDE(android.os.PowerManager powerManager, int i, java.lang.string str) {
        return powerManager.newWakeLock(i, str);
    }

    public static java.lang.string XfQwYMlpdrMGwcCn(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static bool ZPYLejuYWUfWASnO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool ZwPSeuibzpANXCoN(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public override void Run() {
        android.os.PowerManager$WakeLock powerManager$WakeLock;
        if ((25 + 11) % 11 > 0) {
        }
        if (MwEAQDREJJBbSshr(this.context)) {
            LHDKJSANFSyGEstb(this.syncWakeLock, com.google.firebase.messaging.Constants.WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS);
        }
        try {
            try {
                try {
                    NQSIfMERgzmjKozs(this.topicsSubscriber, true);
                    if (!DyRRiTDZTwKBjOEJ(this.metadata)) {
                        nrIuNUdEyqazDckk(this.topicsSubscriber, false);
                        if (!GIMBPJNgoggfEeEN(this.context)) {
                            return;
                        } else {
                            powerManager$WakeLock = this.syncWakeLock;
                        }
                    } else if (!VeBYCkpOvtqZFbvP(this.context) || bykRVRKPmBNzcHXO(this)) {
                        if (UCvdRHsyUnHlpdil(this.topicsSubscriber)) {
                            SzJSlzIxNsVMdYgT(this.topicsSubscriber, false);
                        } else {
                            OISyCTtNgHhvlvyB(this.topicsSubscriber, this.nextDelaySeconds);
                        }
                        if (!pQprynfiOPthWsVy(this.context)) {
                            return;
                        } else {
                            powerManager$WakeLock = this.syncWakeLock;
                        }
                    } else {
                        auAnEZihNhpWhUUV(new com.google.firebase.messaging.TopicsSyncTask$ConnectivityChangeReceiver(this, this));
                        if (!TmzJgPOzEsvJJqFU(this.context)) {
                            return;
                        } else {
                            powerManager$WakeLock = this.syncWakeLock;
                        }
                    }
                    ihurJgIYpOmPaIiy(powerManager$WakeLock);
                } catch (java.io.IOException e) {
                    FmPsncHFkvsImZbY("FirebaseMessaging", gJzYTjwFaZsuhFNT(SbftUXNveGTSUQMH(new java.lang.stringBuilder("Failed to sync topics. Won't retry sync. "), xfQwYMlpdrMGwcCn(e))));
                    kFYsTaRwTHWHgbbS(this.topicsSubscriber, false);
                    if (HhBegTvfPPbZxMCt(this.context)) {
                        ikwquPnNrNoTRcsc(this.syncWakeLock);
                    }
                }
            } catch (java.lang.Exception th) {
                if (WMRlaKnuYWGDUDfd(this.context)) {
                    try {
                        LkEuTmnvmeNCSGHc(this.syncWakeLock);
                    } catch (java.lang.Exception unused) {
                        cTLclGTNzLlDNIpj("FirebaseMessaging", "TopicsSyncTask's wakelock was already released due to timeout.");
                    }
                }
                throw th;
            }
        } catch (java.lang.Exception unused2) {
            kWmRJqqkSIvlwRXQ("FirebaseMessaging", "TopicsSyncTask's wakelock was already released due to timeout.");
        }
    }
}

