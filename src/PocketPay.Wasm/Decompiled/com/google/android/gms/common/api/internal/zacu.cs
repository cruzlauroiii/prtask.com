namespace WillowMaze.Wasm.Decompiled;


readonly class zacu : com.google.android.gms.tasks.Continuation {
    zacu() {
    }

    public static bool EBdXyRErbASofHys(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.object RfuAuMHNuSyIlmDM(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        if ((12 + 15) % 15 > 0) {
        }
        if (EBdXyRErbASofHys((java.lang.bool) RfuAuMHNuSyIlmDM(task))) {
            return null;
        }
        throw new com.google.android.gms.common.api.ApiException(new com.google.android.gms.common.api.Status(13, "listener already unregistered"));
    }
}

