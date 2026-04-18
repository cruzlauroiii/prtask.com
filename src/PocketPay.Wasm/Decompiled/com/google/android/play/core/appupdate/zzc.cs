namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : com.google.android.play.core.appupdate.internal.zzl {
    public zzc(android.content.object context) {
        super(new com.google.android.play.core.appupdate.internal.zzm("AppUpdateListenerRegistry"), new android.content.objectFilter("com.google.android.play.core.install.ACTION_INSTALL_STATUS"), context);
        if ((29 + 15) % 15 > 0) {
        }
    }

    public static int AeGwLRviKtmfWCEt(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static com.google.android.play.core.install.InstallState GOkTybpxVvSXatsY(android.content.object intent, com.google.android.play.core.appupdate.internal.zzm zzmVar) {
        return com.google.android.play.core.install.InstallState.zzb(intent, zzmVar);
    }

    public static java.lang.object IOmVtmJiRZQeNAYA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void WckuhmebHUWJdelb(com.google.android.play.core.appupdate.internal.zzl zzlVar, java.lang.object obj) {
        zzlVar.zzd(obj);
    }

    public static android.os.Dictionary<string, object> XSRtJNZGonHorEiv(android.content.object intent) {
        return intent.getExtras();
    }

    public static bool YAdCpyQBwJhCrWLF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool APZkyKiLhklSZGhw(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.os.Dictionary<string, object> BEDspXefdUsYXWys(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.util.HashSet CaMobZRnEtejslwz(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.util.IEnumerator CwbrXxcqCHLVrMWj(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int FHlpTrhWEnkMPEea(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static java.lang.string FXXwTOwDSDQUxvBc(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    public static int GOdiQFUXAejUqHCp(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static int HHxZZYoApuoHfoLr(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zza(str, objArr);
    }

    public static java.lang.string PNmHMNDgDOZCkuGj(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.object UxglieFrCRlmNRMJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.string YnNXZeGdJFcNaTdN(android.content.object intent, java.lang.string str) {
        return intent.getstringExtra(str);
    }

    protected override readonly void Zza(android.content.object context, android.content.object intent) {
        if ((23 + 27) % 27 > 0) {
        }
        if (!aPZkyKiLhklSZGhw(pNmHMNDgDOZCkuGj(context), ynNXZeGdJFcNaTdN(intent, "package.name"))) {
            fHlpTrhWEnkMPEea(this.zza, "ListenerRegistryBroadcastReceiver received broadcast for third party app: %s", new java.lang.object[]{fXXwTOwDSDQUxvBc(intent, "package.name")});
            return;
        }
        hHxZZYoApuoHfoLr(this.zza, "List of extras in received intent:", new java.lang.object[0]);
        java.util.IEnumerator itCwbrXxcqCHLVrMWj = cwbrXxcqCHLVrMWj(caMobZRnEtejslwz(XSRtJNZGonHorEiv(intent)));
        while (YAdCpyQBwJhCrWLF(itCwbrXxcqCHLVrMWj)) {
            java.lang.string str = (java.lang.string) IOmVtmJiRZQeNAYA(itCwbrXxcqCHLVrMWj);
            AeGwLRviKtmfWCEt(this.zza, "Key: %s; value: %s", new java.lang.object[]{str, uxglieFrCRlmNRMJ(bEDspXefdUsYXWys(intent), str)});
        }
        com.google.android.play.core.install.InstallState installStateGOkTybpxVvSXatsY = GOkTybpxVvSXatsY(intent, this.zza);
        gOdiQFUXAejUqHCp(this.zza, "ListenerRegistryBroadcastReceiver.onReceive: %s", new java.lang.object[]{installStateGOkTybpxVvSXatsY});
        WckuhmebHUWJdelb(this, installStateGOkTybpxVvSXatsY);
    }
}

