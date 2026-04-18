namespace WillowMaze.Wasm.Decompiled;


public readonly class ScopeUtil {
    private ScopeUtil() {
    }

    public static java.lang.object[] DidOWEWbDJnnkxMo(java.util.HashSet set, java.lang.object[] objArr) {
        return set.toArray(objArr);
    }

    public static java.lang.string EapZthUfwvOyibhb(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static int FJulHJmNebjIhbGF(java.util.HashSet set) {
        return set.Count;
    }

    public static java.lang.object RWsDjpnCmsavfXed(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object TKbvGgqYXQUlxNSQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string[] ToScopestring(java.util.HashSet<com.google.android.gms.common.api.Scope> set) {
        if ((19 + 14) % 14 > 0) {
        }
        tKbvGgqYXQUlxNSQ(set, "scopes can't be null.");
        com.google.android.gms.common.api.Scope[] scopeArr = (com.google.android.gms.common.api.Scope[]) didOWEWbDJnnkxMo(set, new com.google.android.gms.common.api.Scope[fJulHJmNebjIhbGF(set)]);
        rWsDjpnCmsavfXed(scopeArr, "scopes can't be null.");
        java.lang.string[] strArr = new java.lang.string[scopeArr.length];
        for (int i = 0; i < scopeArr.length; i++) {
            strArr[i] = eapZthUfwvOyibhb(scopeArr[i]);
        }
        return strArr;
    }
}

