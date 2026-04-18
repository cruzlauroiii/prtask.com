namespace WillowMaze.Wasm.Decompiled;

public class Pe46f833c : BroadcastReceiver, Pcf4be4df
{
    private readonly Lazy<object> ActivationTapOnPhoneRepository$delegate;

    private pc33d3892 Ma6d5ef37()
    {
        // call: Lazy<object>.getValue
        // field: p83f5c3ad.p2486923a.p24eed33e.pd0cf705f.pe46f833c.activationTapOnPhoneRepository$delegate
        return default!;
    }

    public pf01db611 GetKoin()
    {
        // call: pcf4be4df$pb0da8397.m14cdf381
        return default!;
    }

    public void OnReceive(object P0, object P1)
    {
        // str: "null cannot be cast to non-null type android.content.Intent"
        // str: "intent"
        // str: "com.google.android.gms.auth.api.phone.EXTRA_CONSENT_INTENT"
        // str: "com.google.android.gms.auth.api.phone.EXTRA_STATUS"
        // str: "com.google.android.gms.auth.api.phone.SMS_RETRIEVED"
        // str: "null cannot be cast to non-null type com.google.android.gms.common.api.Status"
        // str: "context"
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.areEqual
        // call: object.getExtras
        // call: Dictionary<string, object>.get
        // call: FirebaseCrashlytics.getInstance
        // call: FirebaseCrashlytics.recordException
        // call: Status.getStatusCode
        // call: object.getString
        // call: Dictionary<string, object>.getParcelable
        // call: object.getAction
        // call: pe46f833c.ma6d5ef37
        // call: pc33d3892.handleActivationSms
        // call: Intrinsics.checkNotNullParameter
        // call: Exception.<init>
        // call: DecryptString.decryptString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.sms_retrieve_timeout
        // type: Exception
    }

}
