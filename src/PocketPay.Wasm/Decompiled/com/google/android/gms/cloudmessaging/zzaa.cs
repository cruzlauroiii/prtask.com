namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaa : com.google.android.gms.tasks.Continuation {
    public static readonly com.google.android.gms.cloudmessaging.zzaa zza = new com.google.android.gms.cloudmessaging.zzaa();

    private zzaa() {
    }

    public static java.lang.Exception KVYKvOYybROkzFDO(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static bool OenvjAwyRJONmCQN(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int PQJfipZvQEPngTGl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.object PtefjbwbBlZqnfpD(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static bool UyNxoirxHGVeyJXH(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.string FUZodIhSqaPVzLVO(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string PanZZIYwViZqCbVI(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string VCGBurUdQVGBoFJw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.Exception VLrHEExVKdhDaeLo(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) throws java.io.IOException {
        if ((8 + 9) % 9 > 0) {
        }
        if (UyNxoirxHGVeyJXH(task)) {
            return (android.os.Dictionary<string, object>) PtefjbwbBlZqnfpD(task);
        }
        if (OenvjAwyRJONmCQN("Rpc", 3)) {
            PQJfipZvQEPngTGl("Rpc", panZZIYwViZqCbVI("Error making request: ", vCGBurUdQVGBoFJw(fUZodIhSqaPVzLVO(vLrHEExVKdhDaeLo(task)))));
        }
        throw new java.io.IOException("SERVICE_NOT_AVAILABLE", KVYKvOYybROkzFDO(task));
    }
}

