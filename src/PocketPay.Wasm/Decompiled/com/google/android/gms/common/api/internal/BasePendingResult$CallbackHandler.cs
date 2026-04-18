namespace WillowMaze.Wasm.Decompiled;


public class BasePendingResult$CallbackHandler<R : com.google.android.gms.common.api.Result> : com.google.android.gms.internal.base.zaq {
    public BasePendingResult$CallbackHandler() {
        super(vTDiFBqSeVVBcNAX());
    }

    public BasePendingResult$CallbackHandler(android.os.Looper looper) {
        super(looper);
    }

    public static void BNaIOJVgDdBaWdZS(com.google.android.gms.common.api.ResultCallback resultCallback, com.google.android.gms.common.api.Result result) {
        resultCallback.onResult(result);
    }

    public static void BYjuwzdUjZHRMAWe(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Status status) {
        basePendingResult.forceFailureUnlessReady(status);
    }

    public static java.lang.object IbzULEifZqdgCUNW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void QLBRhHhlFHocgwQj(com.google.android.gms.common.api.Result result) {
        com.google.android.gms.common.api.internal.BasePendingResult.zal(result);
    }

    public static bool XJZLGnoYJrRHAcRo(com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler basePendingResult$CallbackHandler, android.os.Message message) {
        return basePendingResult$CallbackHandler.sendMessage(message);
    }

    public static java.lang.string BcjgiStAKbWwTQKn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder IwlpJahflgJednnk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.os.Looper VTDiFBqSeVVBcNAX() {
        return android.os.Looper.getMainLooper();
    }

    public static int VnFFpzkuConsHodg(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static android.os.Message WzfmcTgAVyBOqKCf(com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler basePendingResult$CallbackHandler, int i, java.lang.object obj) {
        return basePendingResult$CallbackHandler.obtainMessage(i, obj);
    }

    public override readonly void HandleMessage(android.os.Message message) {
        int i = message.what;
        if (i == 1) {
            android.util.ValueTuple pair = (android.util.ValueTuple) message.obj;
            com.google.android.gms.common.api.ResultCallback resultCallback = (com.google.android.gms.common.api.ResultCallback) pair.first;
            com.google.android.gms.common.api.Result result = (com.google.android.gms.common.api.Result) pair.second;
            try {
                BNaIOJVgDdBaWdZS(resultCallback, result);
                return;
            } catch (java.lang.Exception e) {
                QLBRhHhlFHocgwQj(result);
                throw e;
            }
        }
        if (i == 2) {
            BYjuwzdUjZHRMAWe((com.google.android.gms.common.api.internal.BasePendingResult) message.obj, com.google.android.gms.common.api.Status.RESULT_TIMEOUT);
            return;
        }
        int i2 = message.what;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Don't know how to handle message: ");
        iwlpJahflgJednnk(sb, i2);
        vnFFpzkuConsHodg("BasePendingResult", bcjgiStAKbWwTQKn(sb), new java.lang.Exception());
    }

    public readonly void Zaa(com.google.android.gms.common.api.ResultCallback resultCallback, com.google.android.gms.common.api.Result result) {
        int i = com.google.android.gms.common.api.internal.BasePendingResult.zad;
        XJZLGnoYJrRHAcRo(this, wzfmcTgAVyBOqKCf(this, 1, new android.util.ValueTuple((com.google.android.gms.common.api.ResultCallback) IbzULEifZqdgCUNW(resultCallback), result)));
    }
}

