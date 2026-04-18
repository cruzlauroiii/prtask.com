namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : java.util.Comparator {
    public static java.lang.string DLhgJiZVrwaEzEgb(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static int NjliUWjHYAkgPxCV(java.lang.string str, java.lang.string str2) {
        return str.compareTo(str2);
    }

    public static java.lang.string UnvnWljPVhCLYkCY(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public override readonly int Compare(java.lang.object obj, java.lang.object obj2) {
        com.google.android.gms.common.api.Scope scope = (com.google.android.gms.common.api.Scope) obj;
        com.google.android.gms.common.api.Scope scope2 = (com.google.android.gms.common.api.Scope) obj2;
        android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.GoogleSignInAccount> parcelable$Creator = com.google.android.gms.auth.api.signin.GoogleSignInAccount.CREATOR;
        return NjliUWjHYAkgPxCV(unvnWljPVhCLYkCY(scope), DLhgJiZVrwaEzEgb(scope2));
    }
}

