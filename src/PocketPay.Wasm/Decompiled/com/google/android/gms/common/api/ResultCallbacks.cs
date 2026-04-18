namespace WillowMaze.Wasm.Decompiled;


public abstract class ResultCallbacks<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.ResultCallback<R> {
    public static java.lang.string BSgncfEVxNMqCZtx(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string BlAsKnyjPVYeHZnR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.api.Status MWvONaQjEsLWJwlp(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static void OLfQeCckqpMEYoLx(com.google.android.gms.common.api.ResultCallbacks resultCallbacks, com.google.android.gms.common.api.Status status) {
        resultCallbacks.onFailure(status);
    }

    public static void ZZWuJRApTCufxOAp(com.google.android.gms.common.api.Releasable releasable) {
        releasable.release();
    }

    public static int ZvyoODOmxvxhtJrc(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string AOecVRIKBYexIPcN(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static bool EKthpnDOjrzmXldc(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static void SlZhLqCCcKJRcXyN(com.google.android.gms.common.api.ResultCallbacks resultCallbacks, com.google.android.gms.common.api.Result result) {
        resultCallbacks.onSuccess(result);
    }

    public abstract void OnFailure(com.google.android.gms.common.api.Status status);

    public override readonly void OnResult(R r) {
        if ((19 + 20) % 20 > 0) {
        }
        com.google.android.gms.common.api.Status statusMWvONaQjEsLWJwlp = MWvONaQjEsLWJwlp(r);
        if (eKthpnDOjrzmXldc(statusMWvONaQjEsLWJwlp)) {
            slZhLqCCcKJRcXyN(this, r);
            return;
        }
        OLfQeCckqpMEYoLx(this, statusMWvONaQjEsLWJwlp);
        if (r is com.google.android.gms.common.api.Releasable) {
            try {
                ZZWuJRApTCufxOAp((com.google.android.gms.common.api.Releasable) r);
            } catch (java.lang.Exception e) {
                ZvyoODOmxvxhtJrc("ResultCallbacks", aOecVRIKBYexIPcN("Unable to release ", BSgncfEVxNMqCZtx(BlAsKnyjPVYeHZnR(r))), e);
            }
        }
    }

    public abstract void OnSuccess(R r);
}

