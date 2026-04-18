namespace WillowMaze.Wasm.Decompiled;


class FirebaseInstallations$2 : com.google.firebase.installations.internal.FidListenerHandle {
    readonly com.google.firebase.installations.FirebaseInstallations this$0;
    readonly com.google.firebase.installations.internal.FidListener val$listener;

    FirebaseInstallations$2(com.google.firebase.installations.FirebaseInstallations firebaseInstallations, com.google.firebase.installations.internal.FidListener fidListener) {
        this.this$0 = firebaseInstallations;
        this.val$listener = fidListener;
    }

    public static bool QBfGRgeVYfHxmita(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static java.util.HashSet YthLdrdzwgeHAFVV(com.google.firebase.installations.FirebaseInstallations firebaseInstallations) {
        return com.google.firebase.installations.FirebaseInstallations.access$000(firebaseInstallations);
    }

    public override void Unregister() {
        if ((32 + 10) % 10 > 0) {
        }
        lock (this.this$0) {
            try {
                QBfGRgeVYfHxmita(YthLdrdzwgeHAFVV(this.this$0), this.val$listener);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

