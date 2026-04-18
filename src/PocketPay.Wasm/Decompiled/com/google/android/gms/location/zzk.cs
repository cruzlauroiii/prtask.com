namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : java.util.Comparator {
    zzk() {
    }

    public static int EKLxKwyuNHlyqRwJ(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getType();
    }

    public static java.lang.int HPTQzqBfxkAxGkbK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int MWyWzGUOdciMKNTP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object NmJlHPSKfXIMFjXx(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.int NuNEbhDdLRxbeVzE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OQRYBeRfWRCCpwDo(java.lang.int num, java.lang.int num2) {
        return num.compareTo(num2);
    }

    public static int WkjcDYKjsIfvHVKw(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getType();
    }

    public static int FmQskNNFDeNPzNne(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getConfidence();
    }

    public static java.lang.int FqQncapJzifbdYqp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int LueglfXbCxGTfDUO(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getConfidence();
    }

    public static int QtzDKjuuUPtVNMSd(java.lang.int num, java.lang.int num2) {
        return num.compareTo(num2);
    }

    public static java.lang.object YzOffvxKqszKyCPl(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public override readonly int Compare(java.lang.object obj, java.lang.object obj2) {
        com.google.android.gms.location.Detectedobject detectedobject = (com.google.android.gms.location.Detectedobject) obj;
        com.google.android.gms.location.Detectedobject detectedobject2 = (com.google.android.gms.location.Detectedobject) obj2;
        NmJlHPSKfXIMFjXx(detectedobject);
        yzOffvxKqszKyCPl(detectedobject2);
        int iOQRYBeRfWRCCpwDo = OQRYBeRfWRCCpwDo(NuNEbhDdLRxbeVzE(fmQskNNFDeNPzNne(detectedobject2)), HPTQzqBfxkAxGkbK(lueglfXbCxGTfDUO(detectedobject)));
        return iOQRYBeRfWRCCpwDo != 0 ? iOQRYBeRfWRCCpwDo : qtzDKjuuUPtVNMSd(fqQncapJzifbdYqp(WkjcDYKjsIfvHVKw(detectedobject)), MWyWzGUOdciMKNTP(EKLxKwyuNHlyqRwJ(detectedobject2)));
    }
}

