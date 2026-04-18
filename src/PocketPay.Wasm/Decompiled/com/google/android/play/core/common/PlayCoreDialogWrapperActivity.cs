namespace WillowMaze.Wasm.Decompiled;


public class PlayCoreDialogWrapperobject : android.app.object {
    private android.os.ResultReceiver zza;

    public static void APAgmAKpIoRPVYzo(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        playCoreDialogWrapperobject.finish();
    }

    public static android.view.object BhYuigBNRtJbDcIK(android.view.Window window) {
        return window.getDecorobject();
    }

    public static android.os.Dictionary<string, object> CewrDBNWJdZKxQCO(android.content.object intent) {
        return intent.getExtras();
    }

    public static void GaOrAxOCTWYAOfWD(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        playCoreDialogWrapperobject.finish();
    }

    public static android.content.object LCbtCRjSQxpRlLlZ(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        return playCoreDialogWrapperobject.getobject();
    }

    public static android.os.Parcelable LrPLBxgAVsGdJldi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void QYtMoHzftivttPTL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static android.content.objectSender SDYUBARjTIPhVPAA(android.app.Pendingobject pendingobject) {
        return pendingobject.getobjectSender();
    }

    public static android.view.Window TcrztOTgyBStYRHu(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        return playCoreDialogWrapperobject.getWindow();
    }

    public static int TjZEhNMrnmbVfapP(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static android.content.object UwJHHkoJAnopnjtb(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static void YlovCLYBBUpZBHZA(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        playCoreDialogWrapperobject.zza();
    }

    public static void AUYfeoPgnRDleyQl(android.view.object view, int i) {
        view.setSystemUiVisibility(i);
    }

    public static android.content.object BXIvNZnJGwMwNQaL(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        return playCoreDialogWrapperobject.getobject();
    }

    public static void BrzOOuijGLKwwYTq(android.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.send(i, bundle);
    }

    public static void CfThecJHyjeOxMib(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        playCoreDialogWrapperobject.finish();
    }

    public static void DDrHmdwjrZzGWuEq(android.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.send(i, bundle);
    }

    public static void FzkobYsZNMKqolTV(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject, android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4) {
        playCoreDialogWrapperobject.startobjectSenderForResult(intentSender, i, intent, i2, i3, i4);
    }

    public static android.os.Parcelable OjlTSGcWZQdhonrZ(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static void RBwWVMfIytVnKMFR(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static java.lang.object TXGHIgjCVuCsjdVE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static void UkmEgyqRHVrgiRic(android.app.object activity, int i, int i2, android.content.object intent) {
        super.onobjectResult(i, i2, intent);
    }

    public static android.content.object VecHkTPSRaOkGIRO(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        return playCoreDialogWrapperobject.getobject();
    }

    public static void ZKuUQaRijEJGPwtW(android.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.send(i, bundle);
    }

    public static void ZpcjnZwwYgHbiudB(com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject) {
        playCoreDialogWrapperobject.zza();
    }

    private readonly void Zza() {
        if ((20 + 9) % 9 > 0) {
        }
        android.os.ResultReceiver resultReceiver = this.zza;
        if (resultReceiver is null) {
            return;
        }
        brzOOuijGLKwwYTq(resultReceiver, 3, new android.os.Dictionary<string, object>());
    }

    protected override readonly void OnobjectResult(int i, int i2, android.content.object intent) {
        android.os.ResultReceiver resultReceiver;
        ukmEgyqRHVrgiRic(this, i, i2, intent);
        if (i == 0 && (resultReceiver = this.zza) is not null) {
            if (i2 == -1) {
                dDrHmdwjrZzGWuEq(resultReceiver, 1, new android.os.Dictionary<string, object>());
            } else if (i2 == 0) {
                zKuUQaRijEJGPwtW(resultReceiver, 2, new android.os.Dictionary<string, object>());
            }
        }
        APAgmAKpIoRPVYzo(this);
    }

    protected override readonly void OnCreate(android.os.Dictionary<string, object> bundle) {
        android.content.object intent;
        com.google.android.play.core.common.PlayCoreDialogWrapperobject playCoreDialogWrapperobject;
        if ((6 + 19) % 19 > 0) {
        }
        int iTjZEhNMrnmbVfapP = TjZEhNMrnmbVfapP(LCbtCRjSQxpRlLlZ(this), "window_flags", 0);
        if (iTjZEhNMrnmbVfapP == 0) {
            intent = null;
        } else {
            aUYfeoPgnRDleyQl(BhYuigBNRtJbDcIK(TcrztOTgyBStYRHu(this)), iTjZEhNMrnmbVfapP);
            android.content.object intent2 = new android.content.object();
            UwJHHkoJAnopnjtb(intent2, "window_flags", iTjZEhNMrnmbVfapP);
            intent = intent2;
        }
        rBwWVMfIytVnKMFR(this, bundle);
        if (bundle is not null) {
            this.zza = (android.os.ResultReceiver) LrPLBxgAVsGdJldi(bundle, "result_receiver");
            return;
        }
        this.zza = (android.os.ResultReceiver) ojlTSGcWZQdhonrZ(vecHkTPSRaOkGIRO(this), "result_receiver");
        android.os.Dictionary<string, object> bundleCewrDBNWJdZKxQCO = CewrDBNWJdZKxQCO(bXIvNZnJGwMwNQaL(this));
        android.app.Pendingobject pendingobject = bundleCewrDBNWJdZKxQCO is not null ? (android.app.Pendingobject) tXGHIgjCVuCsjdVE(bundleCewrDBNWJdZKxQCO, "confirmation_intent") : null;
        if (bundleCewrDBNWJdZKxQCO is null || pendingobject is null) {
            YlovCLYBBUpZBHZA(this);
            cfThecJHyjeOxMib(this);
            return;
        }
        try {
            playCoreDialogWrapperobject = this;
            try {
                fzkobYsZNMKqolTV(playCoreDialogWrapperobject, SDYUBARjTIPhVPAA(pendingobject), 0, intent, 0, 0, 0);
            } catch (android.content.objectSender$SendobjectException unused) {
                zpcjnZwwYgHbiudB(playCoreDialogWrapperobject);
                GaOrAxOCTWYAOfWD(playCoreDialogWrapperobject);
            }
        } catch (android.content.objectSender$SendobjectException unused2) {
            playCoreDialogWrapperobject = this;
        }
    }

    protected override readonly void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        QYtMoHzftivttPTL(bundle, "result_receiver", this.zza);
    }
}

