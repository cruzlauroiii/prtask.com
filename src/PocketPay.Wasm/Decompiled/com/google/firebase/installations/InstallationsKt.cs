namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u0006\"\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00028F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0007"}, d2 = {"installations", "Lcom/google/firebase/installations/FirebaseInstallations;", "Lcom/google/firebase/Firebase;", "getInstallations", "(Lcom/google/firebase/Firebase;)Lcom/google/firebase/installations/FirebaseInstallations;", "app", "Lcom/google/firebase/FirebaseApp;", "com.google.firebase-firebase-installations"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class InstallationsKt {
    public static void AmoRVMEFeszvwgqK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CULcnxFQmcdJznzS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.installations.FirebaseInstallations FrkheGECPQLiyBAN(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.installations.FirebaseInstallations.getInstance(firebaseApp);
    }

    public static void GFCnEOdLATMKlhnP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly com.google.firebase.installations.FirebaseInstallations GetInstallations(com.google.firebase.Firebase firebase) {
        gFCnEOdLATMKlhnP(firebase, "<this>");
        com.google.firebase.installations.FirebaseInstallations firebaseInstallationsMvmKvrhiFwDSZYua = mvmKvrhiFwDSZYua();
        nFOCwdFMgfTUWsGG(firebaseInstallationsMvmKvrhiFwDSZYua, "getInstance()");
        return firebaseInstallationsMvmKvrhiFwDSZYua;
    }

    public static void GytshvexZqrZJbdF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly com.google.firebase.installations.FirebaseInstallations Installations(com.google.firebase.Firebase firebase, com.google.firebase.FirebaseApp firebaseApp) {
        amoRVMEFeszvwgqK(firebase, "<this>");
        cULcnxFQmcdJznzS(firebaseApp, "app");
        com.google.firebase.installations.FirebaseInstallations firebaseInstallationsFrkheGECPQLiyBAN = frkheGECPQLiyBAN(firebaseApp);
        gytshvexZqrZJbdF(firebaseInstallationsFrkheGECPQLiyBAN, "getInstance(app)");
        return firebaseInstallationsFrkheGECPQLiyBAN;
    }

    public static com.google.firebase.installations.FirebaseInstallations MvmKvrhiFwDSZYua() {
        return com.google.firebase.installations.FirebaseInstallations.getInstance();
    }

    public static void NFOCwdFMgfTUWsGG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }
}

