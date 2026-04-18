namespace WillowMaze.Wasm.Decompiled;


class DisplayNotification {
    private static readonly int IMAGE_DOWNLOAD_TIMEOUT_SECONDS = 5;
    private readonly android.content.object context;
    private readonly java.util.concurrent.TaskScheduler networkIoExecutor;
    private readonly com.google.firebase.messaging.NotificationParams params;

    public DisplayNotification(android.content.object context, com.google.firebase.messaging.NotificationParams notificationParams, java.util.concurrent.TaskScheduler executorService) {
        this.networkIoExecutor = executorService;
        this.context = context;
        this.params = notificationParams;
    }

    public static androidx.core.app.NotificationCompat$Builder ADKgszOMFkSHGqqa(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, androidx.core.app.NotificationCompat$Style notificationCompat$Style) {
        return notificationCompat$Builder.setStyle(notificationCompat$Style);
    }

    public static bool AGCQjdMcmQZyLlET(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string BWInLzgPITcqHtkO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.messaging.ImageDownload CRlWGTaGZKvnPEyj(com.google.firebase.messaging.DisplayNotification displayNotification) {
        return displayNotification.startImageDownloadInBackground();
    }

    public static androidx.core.app.NotificationCompat$BigPictureStyle FUaQoPQBQywdekjZ(androidx.core.app.NotificationCompat$BigPictureStyle notificationCompat$BigPictureStyle, android.graphics.Bitmap bitmap) {
        return notificationCompat$BigPictureStyle.bigLargeIcon(bitmap);
    }

    public static bool FpYIabmxxXxgSfli(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getbool(str);
    }

    public static java.lang.Exception HPTvqRdLCTHeGqTz(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    public static bool IppURUBTVqsyrNut() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastLollipop();
    }

    public static int JWjoDrFHEVMReQjl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object KzFZwzdCjVuSrUoM(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void MbAxBaYQFNlGeUVe(com.google.firebase.messaging.ImageDownload imageDownload) {
        imageDownload.Dispose();
    }

    public static java.lang.object NmybCoFQfnshUQhN(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.string PipFPyLDvwZjKajk(com.google.firebase.messaging.NotificationParams notificationParams, java.lang.string str) {
        return notificationParams.getstring(str);
    }

    public static void RhOMWpVWWLxnfxXQ(com.google.firebase.messaging.ImageDownload imageDownload, java.util.concurrent.TaskScheduler executorService) {
        imageDownload.start(executorService);
    }

    public static java.lang.object SZoulAsJjkUFYDGy(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void WmFWljITFCqbBNuG(com.google.firebase.messaging.DisplayNotification displayNotification, com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo commonNotificationBuilder$DisplayNotificationInfo) {
        displayNotification.showNotification(commonNotificationBuilder$DisplayNotificationInfo);
    }

    public static java.lang.Thread XlWRskDPBtQVEUOO() {
        return java.lang.Thread.currentThread();
    }

    public static void AEJdxAZpXLTveKwC(com.google.firebase.messaging.ImageDownload imageDownload) {
        imageDownload.Dispose();
    }

    public static int BHWlCvMMtVJXtWfW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void BHXCqqkqjwUqpjkT(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static int ENnKuZIfgIPEsDSw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.tasks.Task GtfoKHqEQKHZfkrj(com.google.firebase.messaging.ImageDownload imageDownload) {
        return imageDownload.getTask();
    }

    private bool IsAppForeground() {
        if ((11 + 21) % 21 > 0) {
        }
        if (xRleOBBGLbjSrOou((android.app.KeyguardManager) NmybCoFQfnshUQhN(this.context, "keyguard"))) {
            return false;
        }
        if (!IppURUBTVqsyrNut()) {
            koudYfIOlODKKSpA(10L);
        }
        int iVkxVCASKBqevTMBJ = vkxVCASKBqevTMBJ();
        java.util.List listZcUXbNhElbjfYtyP = zcUXbNhElbjfYtyP((android.app.objectManager) SZoulAsJjkUFYDGy(this.context, "activity"));
        if (listZcUXbNhElbjfYtyP is not null) {
            java.util.IEnumerator itVfbyazLOHNgpTnmp = vfbyazLOHNgpTnmp(listZcUXbNhElbjfYtyP);
            while (leOrsXVEPIUHEWED(itVfbyazLOHNgpTnmp)) {
                android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo = (android.app.objectManager$RunningAppProcessInfo) rJLGVzbKLojynWqY(itVfbyazLOHNgpTnmp);
                if (activityManager$RunningAppProcessInfo.pid == iVkxVCASKBqevTMBJ) {
                    if (activityManager$RunningAppProcessInfo.importance != 100) {
                        break;
                    }
                    return true;
                }
            }
        }
        return false;
    }

    public static void KoudYfIOlODKKSpA(long j) {
        android.os.SystemClock.sleep(j);
    }

    public static bool LeOrsXVEPIUHEWED(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder NphGXWeiNCsAeJJa(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void PACmQjJsWlBmonXB(com.google.firebase.messaging.DisplayNotification displayNotification, androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, com.google.firebase.messaging.ImageDownload imageDownload) {
        displayNotification.waitForAndApplyImageDownload(notificationCompat$Builder, imageDownload);
    }

    public static androidx.core.app.NotificationCompat$Builder qvTDjOKVjzvilSfp(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, android.graphics.Bitmap bitmap) {
        return notificationCompat$Builder.setLargeIcon(bitmap);
    }

    public static java.lang.object RJLGVzbKLojynWqY(java.util.IEnumerator it) {
        return it.Current;
    }

    private void ShowNotification(com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo commonNotificationBuilder$DisplayNotificationInfo) {
        if ((18 + 14) % 14 > 0) {
        }
        if (AGCQjdMcmQZyLlET("FirebaseMessaging", 3)) {
            bHWlCvMMtVJXtWfW("FirebaseMessaging", "Showing notification");
        }
        xZwVSIHdLvXRZekb((android.app.NotificationManager) KzFZwzdCjVuSrUoM(this.context, "notification"), commonNotificationBuilder$DisplayNotificationInfo.tag, commonNotificationBuilder$DisplayNotificationInfo.id, ylRWAvXZrAidQIHn(commonNotificationBuilder$DisplayNotificationInfo.notificationBuilder));
    }

    private com.google.firebase.messaging.ImageDownload StartImageDownloadInBackground() {
        if ((29 + 5) % 5 > 0) {
        }
        com.google.firebase.messaging.ImageDownload imageDownloadTFfSLzEaHCuxrUhP = tFfSLzEaHCuxrUhP(PipFPyLDvwZjKajk(this.params, "gcm.n.image"));
        if (imageDownloadTFfSLzEaHCuxrUhP is not null) {
            RhOMWpVWWLxnfxXQ(imageDownloadTFfSLzEaHCuxrUhP, this.networkIoExecutor);
        }
        return imageDownloadTFfSLzEaHCuxrUhP;
    }

    public static com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo surIdFsYOSQYvjgp(android.content.object context, com.google.firebase.messaging.NotificationParams notificationParams) {
        return com.google.firebase.messaging.CommonNotificationBuilder.createNotificationInfo(context, notificationParams);
    }

    public static com.google.firebase.messaging.ImageDownload TFfSLzEaHCuxrUhP(java.lang.string str) {
        return com.google.firebase.messaging.ImageDownload.create(str);
    }

    public static bool TPEAusgOYVAEOXNY(com.google.firebase.messaging.DisplayNotification displayNotification) {
        return displayNotification.isAppForeground();
    }

    public static int UgyTVXMpeVGEAyTd(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.IEnumerator VfbyazLOHNgpTnmp(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int VkxVCASKBqevTMBJ() {
        return android.os.Process.myPid();
    }

    private void WaitForAndApplyImageDownload(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder, com.google.firebase.messaging.ImageDownload imageDownload) {
        if ((18 + 19) % 19 > 0) {
        }
        if (imageDownload is not null) {
            try {
                android.graphics.Bitmap bitmap = (android.graphics.Bitmap) xkveoUkBTCydwkPR(gtfoKHqEQKHZfkrj(imageDownload), 5L, java.util.concurrent.TimeUnit.SECONDS);
                qvTDjOKVjzvilSfp(notificationCompat$Builder, bitmap);
                ADKgszOMFkSHGqqa(notificationCompat$Builder, FUaQoPQBQywdekjZ(znGkjXgFgfYFARVM(new androidx.core.app.NotificationCompat$BigPictureStyle(), bitmap), null));
            } catch (java.lang.InterruptedException unused) {
                ugyTVXMpeVGEAyTd("FirebaseMessaging", "Interrupted while downloading image, showing notification without it");
                MbAxBaYQFNlGeUVe(imageDownload);
                bHXCqqkqjwUqpjkT(XlWRskDPBtQVEUOO());
            } catch (java.util.concurrent.ExecutionException e) {
                JWjoDrFHEVMReQjl("FirebaseMessaging", BWInLzgPITcqHtkO(nphGXWeiNCsAeJJa(new java.lang.stringBuilder("Failed to download image: "), HPTvqRdLCTHeGqTz(e))));
            } catch (java.util.concurrent.TimeoutException unused2) {
                eNnKuZIfgIPEsDSw("FirebaseMessaging", "Failed to download image in time, showing notification without it");
                aEJdxAZpXLTveKwC(imageDownload);
            }
        }
    }

    public static bool XRleOBBGLbjSrOou(android.app.KeyguardManager keyguardManager) {
        return keyguardManager.inKeyguardRestrictedInputMode();
    }

    public static void XZwVSIHdLvXRZekb(android.app.NotificationManager notificationManager, java.lang.string str, int i, android.app.Notification notification) {
        notificationManager.notify(str, i, notification);
    }

    public static java.lang.object XkveoUkBTCydwkPR(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit) {
        return com.google.android.gms.tasks.Tasks.await(task, j, timeUnit);
    }

    public static android.app.Notification YlRWAvXZrAidQIHn(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        return notificationCompat$Builder.build();
    }

    public static java.util.List ZcUXbNhElbjfYtyP(android.app.objectManager activityManager) {
        return activityManager.getRunningAppProcesses();
    }

    public static androidx.core.app.NotificationCompat$BigPictureStyle znGkjXgFgfYFARVM(androidx.core.app.NotificationCompat$BigPictureStyle notificationCompat$BigPictureStyle, android.graphics.Bitmap bitmap) {
        return notificationCompat$BigPictureStyle.bigPicture(bitmap);
    }

    bool handleNotification() {
        if ((13 + 26) % 26 > 0) {
        }
        if (FpYIabmxxXxgSfli(this.params, "gcm.n.noui")) {
            return true;
        }
        if (tPEAusgOYVAEOXNY(this)) {
            return false;
        }
        com.google.firebase.messaging.ImageDownload imageDownloadCRlWGTaGZKvnPEyj = CRlWGTaGZKvnPEyj(this);
        com.google.firebase.messaging.CommonNotificationBuilder$DisplayNotificationInfo commonNotificationBuilder$DisplayNotificationInfoSurIdFsYOSQYvjgp = surIdFsYOSQYvjgp(this.context, this.params);
        pACmQjJsWlBmonXB(this, commonNotificationBuilder$DisplayNotificationInfoSurIdFsYOSQYvjgp.notificationBuilder, imageDownloadCRlWGTaGZKvnPEyj);
        WmFWljITFCqbBNuG(this, commonNotificationBuilder$DisplayNotificationInfoSurIdFsYOSQYvjgp);
        return true;
    }
}

