namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u0006\"\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00028F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0007"}, d2 = {"installations", "Lcom/google/firebase/installations/FirebaseInstallations;", "Lcom/google/firebase/ktx/Firebase;", "getInstallations", "(Lcom/google/firebase/ktx/Firebase;)Lcom/google/firebase/installations/FirebaseInstallations;", "app", "Lcom/google/firebase/FirebaseApp;", "com.google.firebase-firebase-installations"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class InstallationsKt {
    public static void FqFLzgPaEiAuXsuA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.installations.FirebaseInstallations IYRmhfwMlWaHZRol() {
        return com.google.firebase.installations.FirebaseInstallations.getInstance();
    }

    public static void AiLjeccJGBzVKvYK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.installations.FirebaseInstallations GetInstallations(com.google.firebase.ktx.Firebase firebase) {
        jnwgzSBcQcJprIBd(firebase, "<this>");
        com.google.firebase.installations.FirebaseInstallations firebaseInstallationsIYRmhfwMlWaHZRol = IYRmhfwMlWaHZRol();
        qIySIKNxfuLLesTl(firebaseInstallationsIYRmhfwMlWaHZRol, "getInstance()");
        return firebaseInstallationsIYRmhfwMlWaHZRol;
    }

    public static readonly com.google.firebase.installations.FirebaseInstallations Installations(com.google.firebase.ktx.Firebase firebase, com.google.firebase.FirebaseApp firebaseApp) {
        FqFLzgPaEiAuXsuA(firebase, "<this>");
        uyfRvnuzdWsIwmKs(firebaseApp, "app");
        com.google.firebase.installations.FirebaseInstallations firebaseInstallationsShiSoreljpmRthUA = shiSoreljpmRthUA(firebaseApp);
        aiLjeccJGBzVKvYK(firebaseInstallationsShiSoreljpmRthUA, "getInstance(app)");
        return firebaseInstallationsShiSoreljpmRthUA;
    }

    public static void JnwgzSBcQcJprIBd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QIySIKNxfuLLesTl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.installations.FirebaseInstallations ShiSoreljpmRthUA(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.installations.FirebaseInstallations.getInstance(firebaseApp);
    }

    public static void UyfRvnuzdWsIwmKs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

