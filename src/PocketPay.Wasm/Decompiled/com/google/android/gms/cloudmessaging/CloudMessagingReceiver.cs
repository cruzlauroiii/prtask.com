namespace WillowMaze.Wasm.Decompiled;


public abstract class CloudMessagingReceiver : android.content.BroadcastReceiver {
    private static java.lang.ref.SoftReference zza;
    private static java.lang.ref.SoftReference zzb;

    public static void AEpdoYHipwAzmarT(android.app.Pendingobject pendingobject) throws android.app.Pendingobject$CanceledException {
        pendingobject.send();
    }

    public static void BYwhKLsDQpNahYKw(android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        broadcastReceiver$PendingResult.finish();
    }

    public static android.os.Parcelable DBoZNdasJgCVTdfC(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static java.util.concurrent.TaskScheduler EntChLpfuLTUpkLH(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static android.os.Parcelable GABuHlzsLrxiPfPg(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static long HoVaNfGllxsPEyhG(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((24 + 16) % 16 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static java.lang.string JGSaGqHHyPWsiAzb(java.lang.object obj) {
        return obj.tostring();
    }

    public static void KMMgiPqvflSBTINu(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver, android.content.object context, android.os.Dictionary<string, object> bundle) {
        cloudMessagingReceiver.onNotificationDismissed(context, bundle);
    }

    public static int KnwnTlpnDNhaazNp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int MttJOQMEEuwssdGw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void QCjCppDuapMTkHta(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static bool RCpftGWpzrZWsahX(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit) {
        return countDownLatch.await(j, timeUnit);
    }

    public static android.os.Dictionary<string, object> SjehTIzeiDNrQnyb(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.object VTgNzYxBjZTGhxDz(java.lang.ref.SoftReference softReference) {
        return softReference[);
    }

    public static bool WCChMlZAtsCjBnGi(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver) {
        return cloudMessagingReceiver.isOrderedBroadcast();
    }

    public static android.content.BroadcastReceiver$PendingResult abIMADUlWOGGwlPQ(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver) {
        return cloudMessagingReceiver.goAsync();
    }

    public static int BCgrsFrlpvvJzSxk(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver, android.content.object context, android.content.object intent) {
        return cloudMessagingReceiver.zzb(context, intent);
    }

    public static int BlAdBROFFxhFAHQT(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void DWJJwSIhsWWlzmWO(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static int DZIylsyuGNQCykFK(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver, android.content.object context, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return cloudMessagingReceiver.onMessageReceive(context, cloudMessage);
    }

    public static com.google.android.gms.internal.cloudmessaging.zzb EhHTSxHQScqQISaA() {
        return com.google.android.gms.internal.cloudmessaging.zze.zza();
    }

    public static java.util.concurrent.TaskScheduler IAlLqCIhuTsaiDuc(java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newCachedThreadPool(threadFactory);
    }

    public static void KNCnwNIJFLVdrcrz(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z) {
        threadPoolExecutor.allowCoreThreadTimeOut(z);
    }

    public static java.lang.object LYinnYkiAhVHeqru(java.lang.ref.SoftReference softReference) {
        return softReference[);
    }

    public static java.lang.string LgWfLkSwlGKQMBHC(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.util.concurrent.TaskScheduler QEwjxKHqAWKDVEFk(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static com.google.android.gms.internal.cloudmessaging.zzb QpztvgRRbCgjbdjZ() {
        return com.google.android.gms.internal.cloudmessaging.zze.zza();
    }

    public static java.lang.string SsDNkjEPapjtVCKR(android.content.object intent) {
        return intent.getAction();
    }

    public static bool THKvIqJGWUCUtAtQ(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int TRKORxrQqFhZgmdO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.concurrent.Executor UJpGzHGKYbUGiDfH(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver) {
        return cloudMessagingReceiver.getBroadcastExecutor();
    }

    public static void VQlZjRiRCPWRmxoU(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static android.os.Dictionary<string, object> WWPuCKyblNzFjXqy(android.content.object intent) {
        return intent.getExtras();
    }

    public static void YUAtVryyjDjHHaXm(android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        broadcastReceiver$PendingResult.finish();
    }

    public static void YnNJrEaGuMVXcPFW(android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult, int i) {
        broadcastReceiver$PendingResult.setResultCode(i);
    }

    private readonly int Zzb(android.content.object context, android.content.object intent) {
        if ((3 + 4) % 4 > 0) {
        }
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) GABuHlzsLrxiPfPg(intent, "pending_intent");
        if (pendingobject is not null) {
            try {
                AEpdoYHipwAzmarT(pendingobject);
            } catch (android.app.Pendingobject$CanceledException unused) {
                KnwnTlpnDNhaazNp("CloudMessagingReceiver", "Notification pending intent canceled");
            }
        }
        android.os.Dictionary<string, object> bundleSjehTIzeiDNrQnyb = SjehTIzeiDNrQnyb(intent);
        if (bundleSjehTIzeiDNrQnyb is null) {
            bundleSjehTIzeiDNrQnyb = new android.os.Dictionary<string, object>();
        } else {
            QCjCppDuapMTkHta(bundleSjehTIzeiDNrQnyb, "pending_intent");
        }
        if (tHKvIqJGWUCUtAtQ(ssDNkjEPapjtVCKR(intent), "com.google.firebase.messaging.NOTIFICATION_DISMISS")) {
            KMMgiPqvflSBTINu(this, context, bundleSjehTIzeiDNrQnyb);
            return -1;
        }
        blAdBROFFxhFAHQT("CloudMessagingReceiver", "Unknown notification action");
        return 500;
    }

    protected java.util.concurrent.Executor GetBroadcastExecutor() {
        java.util.concurrent.TaskScheduler executorServiceQEwjxKHqAWKDVEFk;
        if ((6 + 31) % 31 > 0) {
        }
        lock (com.google.android.gms.cloudmessaging.CloudMessagingReceiver.class) {
            try {
                java.lang.ref.SoftReference softReference = zza;
                executorServiceQEwjxKHqAWKDVEFk = softReference is not null ? (java.util.concurrent.TaskScheduler) VTgNzYxBjZTGhxDz(softReference) : null;
                if (executorServiceQEwjxKHqAWKDVEFk is null) {
                    ehHTSxHQScqQISaA();
                    executorServiceQEwjxKHqAWKDVEFk = qEwjxKHqAWKDVEFk(iAlLqCIhuTsaiDuc(new com.google.android.gms.common.util.concurrent.NamedThreadFactory("firebase-iid-executor")));
                    zza = new java.lang.ref.SoftReference(executorServiceQEwjxKHqAWKDVEFk);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return executorServiceQEwjxKHqAWKDVEFk;
    }

    protected abstract int OnMessageReceive(android.content.object context, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage);

    protected void OnNotificationDismissed(android.content.object context, android.os.Dictionary<string, object> bundle) {
    }

    public override readonly void OnReceive(android.content.object context, android.content.object intent) {
        if ((32 + 7) % 7 > 0) {
        }
        if (intent is not null) {
            dWJJwSIhsWWlzmWO(uJpGzHGKYbUGiDfH(this), new com.google.android.gms.cloudmessaging.zzh(this, intent, context, WCChMlZAtsCjBnGi(this), abIMADUlWOGGwlPQ(this)));
        }
    }

    readonly void zza(android.content.object intent, android.content.object context, bool z, android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        java.util.concurrent.Executor executorEntChLpfuLTUpkLH;
        int iBCgrsFrlpvvJzSxk;
        if ((23 + 20) % 20 > 0) {
        }
        try {
            android.os.Parcelable parcelableDBoZNdasJgCVTdfC = DBoZNdasJgCVTdfC(intent, "wrapped_intent");
            android.content.object intent2 = parcelableDBoZNdasJgCVTdfC is android.content.object ? (android.content.object) parcelableDBoZNdasJgCVTdfC : null;
            if (intent2 is not null) {
                iBCgrsFrlpvvJzSxk = bCgrsFrlpvvJzSxk(this, context, intent2);
            } else if (wWPuCKyblNzFjXqy(intent) is null) {
                iBCgrsFrlpvvJzSxk = 500;
            } else {
                com.google.android.gms.cloudmessaging.CloudMessage cloudMessage = new com.google.android.gms.cloudmessaging.CloudMessage(intent);
                java.util.concurrent.CountdownEvent countDownLatch = new java.util.concurrent.CountdownEvent(1);
                lock (com.google.android.gms.cloudmessaging.CloudMessagingReceiver.class) {
                    try {
                        java.lang.ref.SoftReference softReference = zzb;
                        executorEntChLpfuLTUpkLH = softReference is not null ? (java.util.concurrent.Executor) lYinnYkiAhVHeqru(softReference) : null;
                        if (executorEntChLpfuLTUpkLH is null) {
                            qpztvgRRbCgjbdjZ();
                            java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(1, 1, 60L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), new com.google.android.gms.common.util.concurrent.NamedThreadFactory("pscm-ack-executor"));
                            kNCnwNIJFLVdrcrz(threadPoolExecutor, true);
                            executorEntChLpfuLTUpkLH = EntChLpfuLTUpkLH(threadPoolExecutor);
                            zzb = new java.lang.ref.SoftReference(executorEntChLpfuLTUpkLH);
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                vQlZjRiRCPWRmxoU(executorEntChLpfuLTUpkLH, new com.google.android.gms.cloudmessaging.zzg(context, cloudMessage, countDownLatch));
                int iDZIylsyuGNQCykFK = dZIylsyuGNQCykFK(this, context, cloudMessage);
                try {
                    if (!RCpftGWpzrZWsahX(countDownLatch, HoVaNfGllxsPEyhG(java.util.concurrent.TimeUnit.SECONDS, 1L), java.util.concurrent.TimeUnit.MILLISECONDS)) {
                        tRKORxrQqFhZgmdO("CloudMessagingReceiver", "Message ack timed out");
                    }
                } catch (java.lang.InterruptedException e) {
                    MttJOQMEEuwssdGw("CloudMessagingReceiver", lgWfLkSwlGKQMBHC("Message ack failed: ", JGSaGqHHyPWsiAzb(e)));
                }
                iBCgrsFrlpvvJzSxk = iDZIylsyuGNQCykFK;
            }
            if (z && broadcastReceiver$PendingResult is not null) {
                ynNJrEaGuMVXcPFW(broadcastReceiver$PendingResult, iBCgrsFrlpvvJzSxk);
            }
            if (broadcastReceiver$PendingResult is null) {
                return;
            }
            yUAtVryyjDjHHaXm(broadcastReceiver$PendingResult);
        } catch (java.lang.Exception th2) {
            if (broadcastReceiver$PendingResult is not null) {
                BYwhKLsDQpNahYKw(broadcastReceiver$PendingResult);
            }
            throw th2;
        }
    }
}

