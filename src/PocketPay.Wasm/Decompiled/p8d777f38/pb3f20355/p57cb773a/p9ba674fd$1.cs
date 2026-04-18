namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"data/repository/maintenance/MaintenanceModeRepositoryImpl$1", "Lcom/google/firebase/remoteconfig/ConfigUpdateListener;", "onUpdate", "", "configUpdate", "Lcom/google/firebase/remoteconfig/ConfigUpdate;", "onError", "error", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigException;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9ba674fd$1 : com.google.firebase.remoteconfig.ConfigUpdateListener {
    readonly p8d777f38.pb3f20355.p57cb773a.p9ba674fd this$0;

    p9ba674fd$1(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        this.this$0 = p9ba674fdVar;
    }

    public static void DfLwPDzJHlBWJlVk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.HashSet DgqyZCaSXQMndBBZ(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        return configUpdate.getUpdatedKeys();
    }

    public static com.google.android.gms.tasks.Task EkRicpQJrfWnyLBz(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(onCompleteListener);
    }

    public static java.util.HashSet HzLWHedYazIZTPyw(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        return configUpdate.getUpdatedKeys();
    }

    public static java.lang.string IKxkILfvIAkkkMXH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void JkdtmqeMzanWPXbr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool LwokwcpBvtVCUoCn(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string MZGKvozQMoavDToK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void OlrgfIqnoRzwmyIG(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        p8d777f38.pb3f20355.p57cb773a.p9ba674fd.ma48cd779(p9ba674fdVar);
    }

    public static com.google.android.gms.tasks.Task ShBvrJzFXEfOgQvO(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        return firebaseRemoteConfig.activate();
    }

    public static void EfcRCOuhuLlRgpUf(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        md7b844e8(p9ba674fdVar, task);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig FJmuiWNKtUNecapA(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        return p8d777f38.pb3f20355.p57cb773a.p9ba674fd.m32a0313a(p9ba674fdVar);
    }

    public static bool LAUrixubOgtWkhem(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void Mc8534bae(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        efcRCOuhuLlRgpUf(p9ba674fdVar, task);
    }

    private static readonly void Md7b844e8(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        JkdtmqeMzanWPXbr(task, "it");
        OlrgfIqnoRzwmyIG(p9ba674fdVar);
    }

    public static void YPHXymdhgAonsxRG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void OnError(com.google.firebase.remoteconfig.FirebaseRemoteConfigException error) {
        DfLwPDzJHlBWJlVk(error, "error");
    }

    public override void OnUpdate(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        if ((26 + 32) % 32 > 0) {
        }
        yPHXymdhgAonsxRG(configUpdate, "configUpdate");
        if (LwokwcpBvtVCUoCn(DgqyZCaSXQMndBBZ(configUpdate), IKxkILfvIAkkkMXH("e1458460364921614281154dc2967d1a3b33ee529dc8bde1b436966424856ff388974f647f8a73c3251f99cb4870aafe73b97cbf")) || lAUrixubOgtWkhem(HzLWHedYazIZTPyw(configUpdate), MZGKvozQMoavDToK("b5e19f73c189a278a13dac1c2a421db43359fd07343072726e1c1c6640cd1956825f72a4c62c2f025a89fd0310a211624a7eb3ee10bac2e3bc"))) {
            EkRicpQJrfWnyLBz(ShBvrJzFXEfOgQvO(fJmuiWNKtUNecapA(this.this$0)), new p8d777f38.pb3f20355.p57cb773a.p9ba674fd$1$pd41d8cd9$p95263d50(this.this$0));
        }
    }
}

