namespace WillowMaze.Wasm.Decompiled;


class ResultReceiver$MyResultReceiver : android.support.v4.os.IResultReceiver$Stub {
    readonly android.support.v4.os.ResultReceiver this$0;

    ResultReceiver$MyResultReceiver(android.support.v4.os.ResultReceiver resultReceiver) {
        this.this$0 = resultReceiver;
    }

    public static void ZlEFRTmMUBWxgNhZ(android.os.Handler handler, java.lang.Action runnable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZlEFRTmMUBWxgNhZ(android.os.Handler handler, java.lang.Action runnable, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZlEFRTmMUBWxgNhZ(android.os.Handler handler, java.lang.Action runnable, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZlEFRTmMUBWxgNhZ(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void HwuCPeFuhuDWLXdj(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.onReceiveResult(i, bundle);
    }

    public static void HwuCPeFuhuDWLXdj(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HwuCPeFuhuDWLXdj(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HwuCPeFuhuDWLXdj(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void Send(int i, android.os.Dictionary<string, object> bundle) {
        if ((16 + 19) % 19 > 0) {
        }
        if (this.this$0.mHandler is null) {
            hwuCPeFuhuDWLXdj(this.this$0, i, bundle);
        } else {
            ZlEFRTmMUBWxgNhZ(this.this$0.mHandler, new android.support.v4.os.ResultReceiver$MyAction(this.this$0, i, bundle));
        }
    }
}

