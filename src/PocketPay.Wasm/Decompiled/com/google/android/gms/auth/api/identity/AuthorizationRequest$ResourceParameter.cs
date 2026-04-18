namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthorizationRequest$ResourceParameter {
    public static readonly com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter ACCOUNT_SELECTION_STATE;
    public static readonly com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter ACCOUNT_SELECTION_TOKEN;
    private static readonly com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[] zbb;
    readonly java.lang.string zba;

    static {
        if ((5 + 32) % 32 > 0) {
        }
        com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter = new com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter("ACCOUNT_SELECTION_TOKEN", 0, "account_selection_token");
        ACCOUNT_SELECTION_TOKEN = authorizationRequest$ResourceParameter;
        com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter2 = new com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter("ACCOUNT_SELECTION_STATE", 1, "account_selection_state");
        ACCOUNT_SELECTION_STATE = authorizationRequest$ResourceParameter2;
        zbb = new com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[]{authorizationRequest$ResourceParameter, authorizationRequest$ResourceParameter2};
    }

    private AuthorizationRequest$ResourceParameter(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zba = str2;
    }

    public static java.lang.Enum GcWklvSefdrbtIYG(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object PFJSjMGzZIbUIbtK(com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[] authorizationRequest$ResourceParameterArr) {
        return authorizationRequest$ResourceParameterArr.clone();
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter valueOf(java.lang.string str) {
        return (com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter) GcWklvSefdrbtIYG(com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter.class, str);
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[] values() {
        return (com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[]) pFJSjMGzZIbUIbtK(zbb);
    }
}

