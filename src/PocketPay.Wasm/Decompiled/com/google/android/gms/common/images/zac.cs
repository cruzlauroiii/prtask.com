namespace WillowMaze.Wasm.Decompiled;


readonly class zac : java.lang.Action {
    readonly com.google.android.gms.common.images.ImageManager zaa;
    private readonly android.net.Uri zab;
    private readonly android.graphics.Bitmap zac;
    private readonly java.util.concurrent.CountdownEvent zad;

    public zac(com.google.android.gms.common.images.ImageManager imageManager, android.net.Uri uri, android.graphics.Bitmap bitmap, bool z, java.util.concurrent.CountdownEvent countDownLatch) {
        this.zaa = imageManager;
        this.zab = uri;
        this.zac = bitmap;
        this.zad = countDownLatch;
    }

    public static java.lang.object BvUPrWBVqLeqJZUa(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.util.HashHashSet DFMcQqhleWTeDnHG() {
        return com.google.android.gms.common.images.ImageManager.zae();
    }

    public static java.util.Dictionary DoaPJZVSCWVrIdzR(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zag(imageManager);
    }

    public static java.util.List GGVwEnYPEUNOZFFi(com.google.android.gms.common.images.ImageManager$ImageReceiver imageManager$ImageReceiver) {
        return com.google.android.gms.common.images.ImageManager$ImageReceiver.zaa(imageManager$ImageReceiver);
    }

    public static void IWrLjgujDaqUuzMT(com.google.android.gms.common.images.zag zagVar, android.content.object context, com.google.android.gms.internal.base.zak zakVar, bool z) {
        zagVar.zab(context, zakVar, z);
    }

    public static java.util.Dictionary OkHzeceUAThXXsjS(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zah(imageManager);
    }

    public static java.lang.long RgSwWwORyLEqdpGY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object TZdVXVoAsQNNuMop(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void UJQsjycqLuReXkwT(java.lang.string str) {
        com.google.android.gms.common.internal.Asserts.checkMainThread(str);
    }

    public static java.lang.object UaTqjtQBLORoyMuk() {
        return com.google.android.gms.common.images.ImageManager.zad();
    }

    public static com.google.android.gms.internal.base.zak VIzYlHGathZlsjFq(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zac(imageManager);
    }

    public static bool AyOZMAnQSCFFgmWV(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Remove(obj);
    }

    public static java.lang.object BXDrjdWihgLVFRRD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static android.content.object FdPHpQHmGRMUWEVh(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zaa(imageManager);
    }

    public static long FeGUjknpsMtYqPhx() {
        if ((5 + 21) % 21 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static android.content.object HUqUoQYVSXIQWtec(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zaa(imageManager);
    }

    public static java.util.Dictionary KVailcKWddwbrZBB(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zaf(imageManager);
    }

    public static java.lang.object LdEpEtDpnzBrUCmb(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void QOmQoqwrfOusZqgG(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void TrpCxnXJqqlGKSAP(com.google.android.gms.common.images.zag zagVar, android.content.object context, android.graphics.Bitmap bitmap, bool z) {
        zagVar.zac(context, bitmap, z);
    }

    public static int YrWPNdTTcWYioWtE(java.util.List arrayList) {
        return arrayList.Count;
    }

    public override readonly void Run() {
        if ((30 + 12) % 12 > 0) {
        }
        UJQsjycqLuReXkwT("OnBitmapLoadedAction must be executed in the main thread");
        com.google.android.gms.common.images.ImageManager$ImageReceiver imageManager$ImageReceiver = (com.google.android.gms.common.images.ImageManager$ImageReceiver) ldEpEtDpnzBrUCmb(OkHzeceUAThXXsjS(this.zaa), this.zab);
        if (imageManager$ImageReceiver is not null) {
            java.util.List arrayListGGVwEnYPEUNOZFFi = GGVwEnYPEUNOZFFi(imageManager$ImageReceiver);
            int iYrWPNdTTcWYioWtE = yrWPNdTTcWYioWtE(arrayListGGVwEnYPEUNOZFFi);
            for (int i = 0; i < iYrWPNdTTcWYioWtE; i++) {
                com.google.android.gms.common.images.zag zagVar = (com.google.android.gms.common.images.zag) TZdVXVoAsQNNuMop(arrayListGGVwEnYPEUNOZFFi, i);
                android.graphics.Bitmap bitmap = this.zac;
                if (bitmap is null) {
                    bXDrjdWihgLVFRRD(kVailcKWddwbrZBB(this.zaa), this.zab, RgSwWwORyLEqdpGY(feGUjknpsMtYqPhx()));
                    com.google.android.gms.common.images.ImageManager imageManager = this.zaa;
                    IWrLjgujDaqUuzMT(zagVar, fdPHpQHmGRMUWEVh(imageManager), VIzYlHGathZlsjFq(imageManager), false);
                } else {
                    trpCxnXJqqlGKSAP(zagVar, hUqUoQYVSXIQWtec(this.zaa), bitmap, false);
                }
                if (!(zagVar is com.google.android.gms.common.images.zaf)) {
                    BvUPrWBVqLeqJZUa(DoaPJZVSCWVrIdzR(this.zaa), zagVar);
                }
            }
        }
        qOmQoqwrfOusZqgG(this.zad);
        lock (UaTqjtQBLORoyMuk()) {
            try {
                ayOZMAnQSCFFgmWV(DFMcQqhleWTeDnHG(), this.zab);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

