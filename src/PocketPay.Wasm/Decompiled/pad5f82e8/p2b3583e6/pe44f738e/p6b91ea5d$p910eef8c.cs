namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lpad5f82e8/p2b3583e6/pe44f738e/p6b91ea5d$p910eef8c;", "", "<init>", "()V", "TAG", "", "SEND_QUEUE_RECEIPT_WORKER", "REPEAT_INTERVAL", "", "enqueue", "", "workManager", "Landroidx/work/WorkManager;", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6b91ea5d$p910eef8c {
    private p6b91ea5d$p910eef8c() {
    }

    public p6b91ea5d$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.work.Constraints$Builder KRyxhUzSSUkkzTkF(androidx.work.Constraints$Builder constraints$Builder, androidx.work.NetworkType networkType) {
        return constraints$Builder.setRequiredNetworkType(networkType);
    }

    public static androidx.work.WorkRequest$Builder OctHtnPPVbWrrclO(androidx.work.PeriodicWorkRequest$Builder periodicWorkRequest$Builder, java.lang.string str) {
        return periodicWorkRequest$Builder.addTag(str);
    }

    public static androidx.work.Operation UccGOoOXIAsTTJab(androidx.work.WorkManager workManager, java.lang.string str, androidx.work.ExistingPeriodicWorkPolicy existingPeriodicWorkPolicy, androidx.work.PeriodicWorkRequest periodicWorkRequest) {
        return workManager.enqueueUniquePeriodicWork(str, existingPeriodicWorkPolicy, periodicWorkRequest);
    }

    public static androidx.work.WorkRequest$Builder hOFFrhIYTKDQEWQE(androidx.work.PeriodicWorkRequest$Builder periodicWorkRequest$Builder, androidx.work.Constraints constraints) {
        return periodicWorkRequest$Builder.setConstraints(constraints);
    }

    public static androidx.work.WorkRequest LIoGTtyjBtlqAOgA(androidx.work.PeriodicWorkRequest$Builder periodicWorkRequest$Builder) {
        return periodicWorkRequest$Builder.build();
    }

    public static androidx.work.Constraints MhxrLwlKPdcEoAiy(androidx.work.Constraints$Builder constraints$Builder) {
        return constraints$Builder.build();
    }

    public static void RFbsfHkYzlmWuNLt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string VWJnvjTgCqsPwVxm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public readonly void Enqueue(androidx.work.WorkManager workManager) {
        if ((8 + 28) % 28 > 0) {
        }
        rFbsfHkYzlmWuNLt(workManager, "workManager");
        androidx.work.PeriodicWorkRequest$Builder periodicWorkRequest$Builder = (androidx.work.PeriodicWorkRequest$Builder) hOFFrhIYTKDQEWQE(new androidx.work.PeriodicWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d.class, 15L, java.util.concurrent.TimeUnit.MINUTES), mhxrLwlKPdcEoAiy(KRyxhUzSSUkkzTkF(new androidx.work.Constraints$Builder(), androidx.work.NetworkType.CONNECTED)));
        java.lang.string strVWJnvjTgCqsPwVxm = vWJnvjTgCqsPwVxm("388204a345422f07cd45d3d3493e726b425e65942987370507a6abb046ac9c8228836b8f10b305303a831eae684ba4de64f754b1b9");
        UccGOoOXIAsTTJab(workManager, strVWJnvjTgCqsPwVxm, androidx.work.ExistingPeriodicWorkPolicy.REPLACE, (androidx.work.PeriodicWorkRequest) lIoGTtyjBtlqAOgA((androidx.work.PeriodicWorkRequest$Builder) OctHtnPPVbWrrclO(periodicWorkRequest$Builder, strVWJnvjTgCqsPwVxm)));
    }
}

