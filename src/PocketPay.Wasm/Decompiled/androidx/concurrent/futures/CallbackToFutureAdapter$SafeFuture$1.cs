namespace WillowMaze.Wasm.Decompiled;


class CallbackToTaskAdapter$SafeTask$1<T> : androidx.concurrent.futures.AbstractResolvableTask<T> {
    readonly androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask this$0;

    CallbackToTaskAdapter$SafeTask$1(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask) {
        this.this$0 = callbackToTaskAdapter$SafeTask;
    }

    public static java.lang.stringBuilder ELeVSCIsEDmuWHvx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object FrhDmbHRtrqiJbhp(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.stringBuilder PhrAFudgwaNeapch(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WmmQwzMrHYtcVCMy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    protected override java.lang.string PendingTostring() {
        if ((1 + 19) % 19 > 0) {
        }
        androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer = (androidx.concurrent.futures.CallbackToTaskAdapter$Completer) frhDmbHRtrqiJbhp(this.this$0.completerWeakReference);
        return callbackToTaskAdapter$Completer is not null ? wmmQwzMrHYtcVCMy(phrAFudgwaNeapch(ELeVSCIsEDmuWHvx(new java.lang.stringBuilder("tag=["), callbackToTaskAdapter$Completer.tag), "]")) : "Completer object has been garbage collected, future will fail soon";
    }
}

