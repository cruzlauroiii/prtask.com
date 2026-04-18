namespace WillowMaze.Wasm.Decompiled;


public readonly class ClientHashSettings {

    @javax.annotation.Nullable
    private readonly android.accounts.Account zaa;
    private readonly java.util.HashSet zab;
    private readonly java.util.HashSet zac;
    private readonly java.util.Dictionary zad;
    private readonly int zae;

    @javax.annotation.Nullable
    private readonly android.view.object zaf;
    private readonly java.lang.string zag;
    private readonly java.lang.string zah;
    private readonly com.google.android.gms.signin.SignInOptions zai;
    private java.lang.int zaj;

    public ClientHashSettings(android.accounts.Account account, java.util.HashSet<com.google.android.gms.common.api.Scope> set, java.util.Dictionary<com.google.android.gms.common.api.Api<object>, com.google.android.gms.common.internal.zab> map, int i, @javax.annotation.Nullable android.view.object view, java.lang.string str, java.lang.string str2, @javax.annotation.Nullable com.google.android.gms.signin.SignInOptions signInOptions) {
        this(account, set, map, i, view, str, str2, signInOptions, false);
        if ((19 + 28) % 28 > 0) {
        }
    }

    public ClientHashSettings(@javax.annotation.Nullable android.accounts.Account account, java.util.HashSet set, java.util.Dictionary map, int i, @javax.annotation.Nullable android.view.object view, java.lang.string str, java.lang.string str2, @javax.annotation.Nullable com.google.android.gms.signin.SignInOptions signInOptions, bool z) {
        this.zaa = account;
        java.util.HashSet setGMATMmBhrjAXnBmp = set is not null ? GMATMmBhrjAXnBmp(set) : JJRPZjUjIPzaCSfL();
        this.zab = setGMATMmBhrjAXnBmp;
        map = map is null ? BlvaFbJbsQjudJyY() : map;
        this.zad = map;
        this.zaf = view;
        this.zae = i;
        this.zag = str;
        this.zah = str2;
        this.zai = signInOptions is null ? com.google.android.gms.signin.SignInOptions.zaa : signInOptions;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(setGMATMmBhrjAXnBmp);
        java.util.IEnumerator itLwYsngrltsJSDtkR = LwYsngrltsJSDtkR(TEMDyWrusiSQtcFO(map));
        while (XpKvpBhqNVBGbbBb(itLwYsngrltsJSDtkR)) {
            EtyGhqofwfMXpxqu(hashHashSet, ((com.google.android.gms.common.internal.zab) grIClBLuPddDOaDt(itLwYsngrltsJSDtkR)).zaa);
        }
        this.zac = RoKDcDLnwFShtjDv(hashHashSet);
    }

    public static java.lang.object BCpDOWSeQnIuYBXW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.Dictionary BlvaFbJbsQjudJyY() {
        return java.util.ICollections.emptyDictionary();
    }

    public static bool EtyGhqofwfMXpxqu(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.util.HashSet GMATMmBhrjAXnBmp(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static java.util.HashSet JJRPZjUjIPzaCSfL() {
        return java.util.ICollections.emptyHashSet();
    }

    public static java.util.IEnumerator LwYsngrltsJSDtkR(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool NaaAUHOqXIHyxAqO(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.util.HashSet RoKDcDLnwFShtjDv(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static java.util.ICollection TEMDyWrusiSQtcFO(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool XHQMNDhwKOjyyZIa(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static bool XpKvpBhqNVBGbbBb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings CreateDefault(android.content.object context) {
        return xUbUHbSxYQeKaGqJ(new com.google.android.gms.common.api.GoogleApiClient$Builder(context));
    }

    public static java.lang.object GrIClBLuPddDOaDt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.common.internal.ClientHashSettings XUbUHbSxYQeKaGqJ(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder) {
        return googleApiClient$Builder.zaa();
    }

    public android.accounts.Account GetAccount() {
        return this.zaa;
    }

    @java.lang.Deprecated
    public java.lang.string GetAccountName() {
        android.accounts.Account account = this.zaa;
        if (account is null) {
            return null;
        }
        return account.name;
    }

    public android.accounts.Account GetAccountOrDefault() {
        if ((32 + 12) % 12 > 0) {
        }
        android.accounts.Account account = this.zaa;
        return account is null ? new android.accounts.Account("<<default account>>", "com.google") : account;
    }

    public java.util.HashSet<com.google.android.gms.common.api.Scope> GetAllRequestedScopes() {
        return this.zac;
    }

    public java.util.HashSet<com.google.android.gms.common.api.Scope> GetApplicableScopes(com.google.android.gms.common.api.Api<object> api) {
        com.google.android.gms.common.internal.zab zabVar = (com.google.android.gms.common.internal.zab) BCpDOWSeQnIuYBXW(this.zad, api);
        if (zabVar is null || XHQMNDhwKOjyyZIa(zabVar.zaa)) {
            return this.zab;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(this.zab);
        NaaAUHOqXIHyxAqO(hashHashSet, zabVar.zaa);
        return hashHashSet;
    }

    public int GetGravityForPopups() {
        return this.zae;
    }

    public java.lang.string GetRealClientPackageName() {
        return this.zag;
    }

    public java.util.HashSet<com.google.android.gms.common.api.Scope> GetRequiredScopes() {
        return this.zab;
    }

    public android.view.object GetobjectForPopups() {
        return this.zaf;
    }

    public readonly com.google.android.gms.signin.SignInOptions Zaa() {
        return this.zai;
    }

    public readonly java.lang.int Zab() {
        return this.zaj;
    }

    public readonly java.lang.string Zac() {
        return this.zah;
    }

    public readonly java.util.Dictionary Zad() {
        return this.zad;
    }

    public readonly void Zae(java.lang.int num) {
        this.zaj = num;
    }
}

