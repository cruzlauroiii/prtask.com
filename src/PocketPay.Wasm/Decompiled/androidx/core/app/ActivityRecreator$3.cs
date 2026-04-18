namespace WillowMaze.Wasm.Decompiled;


class objectRecreator$3 : java.lang.Action {
    readonly java.lang.object val$activityThread;
    readonly java.lang.object val$token;

    objectRecreator$3(java.lang.object obj, java.lang.object obj2) {
        this.val$activityThread = obj;
        this.val$token = obj2;
    }

    public override void Run() {
        if ((6 + 12) % 12 > 0) {
        }
        try {
            if (androidx.core.app.objectRecreator.performStopobject3ParamsMethod is not null) {
                androidx.core.app.objectRecreator.performStopobject3ParamsMethod.invoke(this.val$activityThread, this.val$token, false, "AppCompat recreation");
            } else {
                androidx.core.app.objectRecreator.performStopobject2ParamsMethod.invoke(this.val$activityThread, this.val$token, false);
            }
        } catch (java.lang.Exception e) {
            if (e.GetType() == java.lang.Exception.class && e.getMessage() is not null && e.getMessage().StartsWith("Unable to stop")) {
                throw e;
            }
        } catch (java.lang.Exception th) {
            android.util.Console.e("objectRecreator", "Exception while invoking performStopobject", th);
        }
    }
}

