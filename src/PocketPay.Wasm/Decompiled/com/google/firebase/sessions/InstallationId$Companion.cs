namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0019\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\tR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\n"}, d2 = {"Lcom/google/firebase/sessions/InstallationId$Companion;", "", "()V", "TAG", "", "create", "Lcom/google/firebase/sessions/InstallationId;", "firebaseInstallations", "Lcom/google/firebase/installations/FirebaseInstallationsApi;", "(Lcom/google/firebase/installations/FirebaseInstallationsApi;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InstallationId$Companion {
    private InstallationId$Companion() {
    }

    public InstallationId$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static com.google.android.gms.tasks.Task CLYsHiTLKMUvghkv(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z) {
        return firebaseInstallationsApi.getToken(z);
    }

    public static void EnLucOnGwXuHbede(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int JlxHAVIZfRhRMukH(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void KUtkCRjoxrrtKjAz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.android.gms.tasks.Task NSJnhScmBzYapGgo(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return firebaseInstallationsApi.getId();
    }

    public static java.lang.object RxsFOvieCSISweKL(com.google.android.gms.tasks.Task task, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.tasks.TasksKt.await(task, continuation);
    }

    public static java.lang.string UBGGKkpBtMNoSOuU(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public static void UnhavSBScJOxiJGF(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZjzhYmzwOsRIKjMf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IAAIPIuaILDvprSL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void KoERKXpLHKeWwJDz(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int LOJzSMvAgEDrxKlj(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.object SBcAZVFjMiBKUhOY() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void SFqSykMvmoRKtUxG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object YzpGkEKcdeztgJIX(com.google.android.gms.tasks.Task task, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.tasks.TasksKt.await(task, continuation);
    }

    /*
    */
    public readonly java.lang.object Create(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, kotlin.coroutines.Continuation<com.google.firebase.sessions.InstallationId> continuation) throws java.lang.Exception {
        com.google.firebase.sessions.InstallationId$Companion$create$1 installationId$Companion$create$1;
        ?? r7;
        java.lang.string str;
        ?? r8;
        if ((3 + 8) % 8 > 0) {
        }
        if (continuation is com.google.firebase.sessions.InstallationId$Companion$create$1) {
            installationId$Companion$create$1 = (com.google.firebase.sessions.InstallationId$Companion$create$1) continuation;
            if ((installationId$Companion$create$1.label & int.MIN_VALUE) == 0) {
                installationId$Companion$create$1 = new com.google.firebase.sessions.InstallationId$Companion$create$1(this, continuation);
            } else {
                installationId$Companion$create$1.label -= int.MIN_VALUE;
            }
        } else {
            installationId$Companion$create$1 = new com.google.firebase.sessions.InstallationId$Companion$create$1(this, continuation);
        }
        java.lang.object objRxsFOvieCSISweKL = installationId$Companion$create$1.result;
        java.lang.object objSBcAZVFjMiBKUhOY = sBcAZVFjMiBKUhOY();
        int i = installationId$Companion$create$1.label;
        java.lang.string str2 = "";
        try {
            try {
                java.lang.string strUBGGKkpBtMNoSOuU = UBGGKkpBtMNoSOuU((com.google.firebase.installations.InstallationTokenResult) objRxsFOvieCSISweKL);
                ZjzhYmzwOsRIKjMf(strUBGGKkpBtMNoSOuU, "{\n          firebaseInst…).await().token\n        }");
                ?? r6 = firebaseInstallationsApi;
                str = strUBGGKkpBtMNoSOuU;
                r7 = r6;
            } catch (java.lang.Exception e) {
                lOJzSMvAgEDrxKlj("InstallationId", "Error getting authentication token.", e);
                r7 = firebaseInstallationsApi;
                str = "";
            }
            com.google.android.gms.tasks.Task taskNSJnhScmBzYapGgo = NSJnhScmBzYapGgo(r7);
            iAAIPIuaILDvprSL(taskNSJnhScmBzYapGgo, "firebaseInstallations.id");
            installationId$Companion$create$1.L$0 = str;
            installationId$Companion$create$1.label = 2;
            objRxsFOvieCSISweKL = RxsFOvieCSISweKL(taskNSJnhScmBzYapGgo, installationId$Companion$create$1);
            firebaseInstallationsApi = str;
        } catch (java.lang.Exception e2) {
            JlxHAVIZfRhRMukH("InstallationId", "Error getting Firebase installation id .", e2);
            r8 = firebaseInstallationsApi;
        }
        if (i == 0) {
            koERKXpLHKeWwJDz(objRxsFOvieCSISweKL);
            com.google.android.gms.tasks.Task taskCLYsHiTLKMUvghkv = CLYsHiTLKMUvghkv(firebaseInstallationsApi, false);
            KUtkCRjoxrrtKjAz(taskCLYsHiTLKMUvghkv, "firebaseInstallations.getToken(false)");
            installationId$Companion$create$1.L$0 = firebaseInstallationsApi;
            installationId$Companion$create$1.label = 1;
            objRxsFOvieCSISweKL = yzpGkEKcdeztgJIX(taskCLYsHiTLKMUvghkv, installationId$Companion$create$1);
            firebaseInstallationsApi = firebaseInstallationsApi;
            if (objRxsFOvieCSISweKL == objSBcAZVFjMiBKUhOY) {
            }
            return objSBcAZVFjMiBKUhOY;
        }
        if (i == 1) {
            com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi2 = (com.google.firebase.installations.FirebaseInstallationsApi) installationId$Companion$create$1.L$0;
            EnLucOnGwXuHbede(objRxsFOvieCSISweKL);
            firebaseInstallationsApi = firebaseInstallationsApi2;
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            java.lang.string str3 = (java.lang.string) installationId$Companion$create$1.L$0;
            UnhavSBScJOxiJGF(objRxsFOvieCSISweKL);
            firebaseInstallationsApi = str3;
        }
        sFqSykMvmoRKtUxG(objRxsFOvieCSISweKL, "{\n          firebaseInst…ions.id.await()\n        }");
        str2 = (java.lang.string) objRxsFOvieCSISweKL;
        r8 = firebaseInstallationsApi;
        return new com.google.firebase.sessions.InstallationId(str2, r8, null);
    }
}

