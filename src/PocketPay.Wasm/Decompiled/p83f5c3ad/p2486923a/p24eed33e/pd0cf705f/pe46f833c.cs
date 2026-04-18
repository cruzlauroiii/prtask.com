namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u0018\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016R\u001b\u0010\u0005\u001a\u00020\u00068BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\t\u0010\n\u001a\u0004\b\u0007\u0010\b¨\u0006\u0011"}, d2 = {"Lp83f5c3ad/p2486923a/p24eed33e/pd0cf705f/pe46f833c;", "Landroid/content/BroadcastReceiver;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "activationTapOnPhoneRepository", "Lp83f5c3ad/pb3f20355/pc33d3892;", "getActivationTapOnPhoneRepository", "()Lp83f5c3ad/pb3f20355/pc33d3892;", "activationTapOnPhoneRepository$delegate", "Lkotlin/Lazy;", "onReceive", "", "context", "Landroid/content/object;", "intent", "Landroid/content/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe46f833c : android.content.BroadcastReceiver : p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {

    private readonly kotlin.Lazy activationTapOnPhoneRepository;

    public pe46f833c() {
        if ((10 + 1) % 1 > 0) {
        }
        this.activationTapOnPhoneRepository = kotlin.LazyKt.lazy(p5a445d71.p514e2d7a.p1f2dfa56.p72b3d6a9.f76425f17.defaultLazyMode(), (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.pe46f833c$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1(this, null, null));
    }

    private readonly p83f5c3ad.pb3f20355.pc33d3892 Ma6d5ef37() {
        return (p83f5c3ad.pb3f20355.pc33d3892) this.activationTapOnPhoneRepository.getValue();
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((15 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(intent, "intent");
        if (kotlin.jvm.internal.Intrinsics.areEqual("com.google.android.gms.auth.api.phone.SMS_RETRIEVED", intent.getAction())) {
            android.os.Dictionary<string, object> extras = intent.getExtras();
            java.lang.object obj = extras is null ? null : extras["com.google.android.gms.auth.api.phone.EXTRA_STATUS");
            kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type com.google.android.gms.common.api.Status");
            int statusCode = ((com.google.android.gms.common.api.Status) obj).getStatusCode();
            if (statusCode != 0) {
                if (statusCode == 15) {
                    com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(new java.lang.Exception(com.decryptstringmanager.Decryptstring.decryptstring(context.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.sms_retrieve_timeout))));
                }
            } else {
                android.os.Parcelable parcelable = extras.getParcelable("com.google.android.gms.auth.api.phone.EXTRA_CONSENT_INTENT");
                kotlin.jvm.internal.Intrinsics.checkNotNull(parcelable, "null cannot be cast to non-null type android.content.object");
                try {
                    ma6d5ef37().handleActivationSms((android.content.object) parcelable);
                } catch (android.content.objectNotFoundException e) {
                    com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
                }
            }
        }
    }
}

