namespace WillowMaze.Wasm.Decompiled;


class ResultReceiver$MyAction : java.lang.Action {
    readonly int mResultCode;
    readonly android.os.Dictionary<string, object> mResultData;
    readonly android.support.v4.os.ResultReceiver this$0;

    ResultReceiver$MyAction(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        this.this$0 = resultReceiver;
        this.mResultCode = i;
        this.mResultData = bundle;
    }

    public static void HetpfSvtpMmYtmVq(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.onReceiveResult(i, bundle);
    }

    public static void HetpfSvtpMmYtmVq(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HetpfSvtpMmYtmVq(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HetpfSvtpMmYtmVq(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((22 + 19) % 19 > 0) {
        }
        HetpfSvtpMmYtmVq(this.this$0, this.mResultCode, this.mResultData);
    }
}

