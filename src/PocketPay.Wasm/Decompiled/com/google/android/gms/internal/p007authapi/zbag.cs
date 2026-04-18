namespace WillowMaze.Wasm.Decompiled;


public readonly class zbag : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.internal.p007authapi.zbap zba;
    public readonly com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest zbb;

    public zbag(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest getPhoneNumberHintobjectRequest) {
        this.zba = zbapVar;
        this.zbb = getPhoneNumberHintobjectRequest;
    }

    public static void ZLvmCyvGFITVyNKY(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest getPhoneNumberHintobjectRequest, com.google.android.gms.internal.p007authapi.zbaq zbaqVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zbapVar.zba(getPhoneNumberHintobjectRequest, zbaqVar, taskCompletionSource);
    }

    public static void ZLvmCyvGFITVyNKY(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest getPhoneNumberHintobjectRequest, com.google.android.gms.internal.p007authapi.zbaq zbaqVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZLvmCyvGFITVyNKY(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest getPhoneNumberHintobjectRequest, com.google.android.gms.internal.p007authapi.zbaq zbaqVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZLvmCyvGFITVyNKY(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest getPhoneNumberHintobjectRequest, com.google.android.gms.internal.p007authapi.zbaq zbaqVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        ZLvmCyvGFITVyNKY(this.zba, this.zbb, (com.google.android.gms.internal.p007authapi.zbaq) obj, (com.google.android.gms.tasks.TaskCompletionSource) obj2);
    }
}

