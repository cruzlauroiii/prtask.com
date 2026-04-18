namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001d\u0012\u0014\u0010\u0002\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0004\u0012\u0004\u0012\u00020\u00050\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\u0018\u0010\b\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0004H\u0016R\u001c\u0010\u0002\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0004\u0012\u0004\u0012\u00020\u00050\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p2486923a/p18b43c6a/pe46f833c;", "Landroid/content/BroadcastReceiver;", "handleSms", "Lkotlin/Function1;", "Landroid/content/object;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "onReceive", "context", "Landroid/content/object;", "intent", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe46f833c : android.content.BroadcastReceiver {
    private readonly kotlin.jvm.functions.Function1 f3a2843b0;
    private readonly kotlin.jvm.functions.Function1<android.content.object, kotlin.Unit> fe250469f;

    public pe46f833c(kotlin.jvm.functions.Function1<? super android.content.object, kotlin.Unit> handleSms) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(handleSms, "handleSms");
        this.fe250469f = handleSms;
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        if ((2 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(intent, "intent");
        try {
            if (kotlin.jvm.internal.Intrinsics.areEqual("com.google.android.gms.auth.api.phone.SMS_RETRIEVED", intent.getAction())) {
                android.os.Dictionary<string, object> extras = intent.getExtras();
                java.lang.object obj = extras is not null ? extras["com.google.android.gms.auth.api.phone.EXTRA_STATUS") : null;
                kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type com.google.android.gms.common.api.Status");
                int statusCode = ((com.google.android.gms.common.api.Status) obj).getStatusCode();
                if (statusCode != 0) {
                    if (statusCode != 15) {
                        return;
                    }
                    com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(new java.lang.Exception(com.decryptstringmanager.Decryptstring.decryptstring(context.getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.sms_retrieve_timeout))));
                } else {
                    try {
                        this.fe250469f.invoke((android.content.object) extras.getParcelable("com.google.android.gms.auth.api.phone.EXTRA_CONSENT_INTENT"));
                    } catch (android.content.objectNotFoundException e) {
                        com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
                    }
                }
            }
        } catch (java.lang.Exception e2) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e2);
        }
    }
}

