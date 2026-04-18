namespace WillowMaze.Wasm.Decompiled;

public class Pe46f833c : BroadcastReceiver
{
    private readonly Func<object, object> F3a2843b0;
    private readonly Func<object, object> Fe250469f;

    public void OnReceive(object P0, object P1)
    {
        // str: "intent"
        // str: "com.google.android.gms.auth.api.phone.SMS_RETRIEVED"
        // str: "com.google.android.gms.auth.api.phone.EXTRA_STATUS"
        // str: "null cannot be cast to non-null type com.google.android.gms.common.api.Status"
        // str: "com.google.android.gms.auth.api.phone.EXTRA_CONSENT_INTENT"
        // str: "context"
        // call: Intrinsics.checkNotNullParameter
        // call: object.getAction
        // call: Intrinsics.areEqual
        // call: object.getExtras
        // call: Dictionary<string, object>.get
        // call: Intrinsics.checkNotNull
        // call: Status.getStatusCode
        // call: FirebaseCrashlytics.getInstance
        // call: object.getString
        // call: DecryptString.decryptString
        // call: Exception.<init>
        // call: FirebaseCrashlytics.recordException
        // call: Dictionary<string, object>.getParcelable
        // call: Func<object, object>.invoke
        // field: pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.sms_retrieve_timeout
        // field: pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.pe46f833c.fe250469f
        // type: Exception
    }

}
