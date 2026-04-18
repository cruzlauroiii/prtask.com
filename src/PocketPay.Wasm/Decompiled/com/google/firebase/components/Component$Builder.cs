namespace WillowMaze.Wasm.Decompiled;


public class Component$Builder<T> {
    private readonly java.util.HashSet<com.google.firebase.components.Dependency> dependencies;
    private com.google.firebase.components.ComponentFactory<T> factory;
    private int instantiation;
    private java.lang.string name;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<T>> providedInterfaces;
    private readonly java.util.HashSet<java.lang.Class<object>> publishedEvents;
    private int type;

    @java.lang.SafeVarargs
    private Component$Builder(com.google.firebase.components.Qualified<T> qualified, com.google.firebase.components.Qualified<T>... qualifiedArr) {
        if ((3 + 24) % 24 > 0) {
        }
        this.name = null;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        this.providedInterfaces = hashHashSet;
        this.dependencies = new java.util.HashHashSet();
        this.instantiation = 0;
        this.type = 0;
        this.publishedEvents = new java.util.HashHashSet();
        zUrqwERBuathTOSA(qualified, "Null interface");
        weKPphigTeZqflyn(hashHashSet, qualified);
        for (com.google.firebase.components.Qualified<T> qualified2 : qualifiedArr) {
            fkyHwcCtHkNuqbdr(qualified2, "Null interface");
        }
        BCogTXycDgkyQzCe(this.providedInterfaces, qualifiedArr);
    }

    Component$Builder(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, com.google.firebase.components.Component$1 component$1) {
        this(qualified, qualifiedArr);
    }

    @java.lang.SafeVarargs
    private Component$Builder(java.lang.Class<T> cls, java.lang.Class<T>... clsArr) {
        if ((20 + 30) % 30 > 0) {
        }
        this.name = null;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        this.providedInterfaces = hashHashSet;
        this.dependencies = new java.util.HashHashSet();
        this.instantiation = 0;
        this.type = 0;
        this.publishedEvents = new java.util.HashHashSet();
        LyXqjHvigusKYgjo(cls, "Null interface");
        xkFJZfXsIgYpRaGS(hashHashSet, zXOPXyjnRJOzEQKm(cls));
        for (java.lang.Class<T> cls2 : clsArr) {
            syKRIsuDgIMECGXz(cls2, "Null interface");
            aOaKdvkfCFRYXdgw(this.providedInterfaces, ssRGSRJCoAOFuXEd(cls2));
        }
    }

    Component$Builder(java.lang.Class cls, java.lang.Class[] clsArr, com.google.firebase.components.Component$1 component$1) {
        this(cls, clsArr);
    }

    public static void BCogTXycDgkyQzCe(java.util.ICollection collection, java.lang.object[] objArr, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BCogTXycDgkyQzCe(java.util.ICollection collection, java.lang.object[] objArr, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BCogTXycDgkyQzCe(java.util.ICollection collection, java.lang.object[] objArr, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BCogTXycDgkyQzCe(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static com.google.firebase.components.Qualified DyNPDXehwdjijDwr(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void DyNPDXehwdjijDwr(com.google.firebase.components.Dependency dependency, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DyNPDXehwdjijDwr(com.google.firebase.components.Dependency dependency, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyNPDXehwdjijDwr(com.google.firebase.components.Dependency dependency, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EcgQmhmpqfvsDpGV(bool z, java.lang.string str) {
        com.google.firebase.components.Preconditions.checkState(z, str);
    }

    public static void EcgQmhmpqfvsDpGV(bool z, java.lang.string str, char c, float f, java.lang.string str2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EcgQmhmpqfvsDpGV(bool z, java.lang.string str, java.lang.string str2, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EcgQmhmpqfvsDpGV(bool z, java.lang.string str, bool z2, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LyXqjHvigusKYgjo(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void LyXqjHvigusKYgjo(java.lang.object obj, java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LyXqjHvigusKYgjo(java.lang.object obj, java.lang.string str, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LyXqjHvigusKYgjo(java.lang.object obj, java.lang.string str, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OmWXeBWYJlbayptB(java.util.HashSet set, java.lang.object obj, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OmWXeBWYJlbayptB(java.util.HashSet set, java.lang.object obj, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmWXeBWYJlbayptB(java.util.HashSet set, java.lang.object obj, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OmWXeBWYJlbayptB(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.firebase.components.Component$Builder RsFMBLfWgYCUyIkq(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.intoHashSet();
    }

    public static void RsFMBLfWgYCUyIkq(com.google.firebase.components.Component$Builder component$Builder, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RsFMBLfWgYCUyIkq(com.google.firebase.components.Component$Builder component$Builder, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RsFMBLfWgYCUyIkq(com.google.firebase.components.Component$Builder component$Builder, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SWuFxygPUBQcidWC(java.util.HashSet set, java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SWuFxygPUBQcidWC(java.util.HashSet set, java.lang.object obj, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SWuFxygPUBQcidWC(java.util.HashSet set, java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SWuFxygPUBQcidWC(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.components.Component$Builder TLLSHVpCaYNHhLJd(com.google.firebase.components.Component$Builder component$Builder, int i) {
        return component$Builder.setInstantiation(i);
    }

    public static void TLLSHVpCaYNHhLJd(com.google.firebase.components.Component$Builder component$Builder, int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLLSHVpCaYNHhLJd(com.google.firebase.components.Component$Builder component$Builder, int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TLLSHVpCaYNHhLJd(com.google.firebase.components.Component$Builder component$Builder, int i, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AOaKdvkfCFRYXdgw(java.util.HashSet set, java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AOaKdvkfCFRYXdgw(java.util.HashSet set, java.lang.object obj, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AOaKdvkfCFRYXdgw(java.util.HashSet set, java.lang.object obj, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AOaKdvkfCFRYXdgw(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    static com.google.firebase.components.Component$Builder access$200(com.google.firebase.components.Component$Builder component$Builder) {
        return RsFMBLfWgYCUyIkq(component$Builder);
    }

    static void access$200(com.google.firebase.components.Component$Builder component$Builder, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.components.Component$Builder component$Builder, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EYPOJoqJfsizAIIb(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void EYPOJoqJfsizAIIb(java.lang.object obj, java.lang.string str, byte b, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EYPOJoqJfsizAIIb(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EYPOJoqJfsizAIIb(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FkyHwcCtHkNuqbdr(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void FkyHwcCtHkNuqbdr(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FkyHwcCtHkNuqbdr(java.lang.object obj, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FkyHwcCtHkNuqbdr(java.lang.object obj, java.lang.string str, short s, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.components.Component$Builder<T> intoHashSet() {
        this.type = 1;
        return this;
    }

    private void IntoHashSet(byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void IntoHashSet(float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IntoHashSet(short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JwrpwBhKNFxvDHan(java.util.HashSet set, java.lang.object obj, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwrpwBhKNFxvDHan(java.util.HashSet set, java.lang.object obj, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwrpwBhKNFxvDHan(java.util.HashSet set, java.lang.object obj, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JwrpwBhKNFxvDHan(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void OomaJhqZzAGjSsus(bool z, java.lang.string str) {
        com.google.firebase.components.Preconditions.checkState(z, str);
    }

    public static void OomaJhqZzAGjSsus(bool z, java.lang.string str, float f, short s, bool z2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OomaJhqZzAGjSsus(bool z, java.lang.string str, java.lang.string str2, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OomaJhqZzAGjSsus(bool z, java.lang.string str, java.lang.string str2, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCowEvTGYrudGFIq(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Qualified qualified) {
        component$Builder.validateInterface(qualified);
    }

    public static void RCowEvTGYrudGFIq(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Qualified qualified, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCowEvTGYrudGFIq(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Qualified qualified, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RCowEvTGYrudGFIq(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Qualified qualified, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.components.Component$Builder<T> setInstantiation(int i) {
        if ((2 + 19) % 19 > 0) {
        }
        oomaJhqZzAGjSsus(this.instantiation == 0, "Instantiation type has already been set.");
        this.instantiation = i;
        return this;
    }

    private void SetInstantiation(int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    private void SetInstantiation(int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetInstantiation(int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified SsRGSRJCoAOFuXEd(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void SsRGSRJCoAOFuXEd(java.lang.Class cls, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SsRGSRJCoAOFuXEd(java.lang.Class cls, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SsRGSRJCoAOFuXEd(java.lang.Class cls, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SyKRIsuDgIMECGXz(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void SyKRIsuDgIMECGXz(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SyKRIsuDgIMECGXz(java.lang.object obj, java.lang.string str, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SyKRIsuDgIMECGXz(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TzqeqcVJaneIeOHO(bool z, java.lang.string str) {
        com.google.firebase.components.Preconditions.checkArgument(z, str);
    }

    public static void TzqeqcVJaneIeOHO(bool z, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TzqeqcVJaneIeOHO(bool z, java.lang.string str, java.lang.string str2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TzqeqcVJaneIeOHO(bool z, java.lang.string str, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UKiaOJpxhSrYfTHM(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void UKiaOJpxhSrYfTHM(java.lang.object obj, java.lang.string str, byte b, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UKiaOJpxhSrYfTHM(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UKiaOJpxhSrYfTHM(java.lang.object obj, java.lang.string str, bool z, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ValidateInterface(com.google.firebase.components.Qualified<object> qualified) {
        tzqeqcVJaneIeOHO(!OmWXeBWYJlbayptB(this.providedInterfaces, qualified), "Components are not allowed to depend on interfaces they themselves provide.");
    }

    private void ValidateInterface(com.google.firebase.components.Qualified qualified, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ValidateInterface(com.google.firebase.components.Qualified qualified, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ValidateInterface(com.google.firebase.components.Qualified qualified, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WeKPphigTeZqflyn(java.util.HashSet set, java.lang.object obj, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WeKPphigTeZqflyn(java.util.HashSet set, java.lang.object obj, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WeKPphigTeZqflyn(java.util.HashSet set, java.lang.object obj, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WeKPphigTeZqflyn(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.components.Component$Builder xiQloJZeXIpNWVpn(com.google.firebase.components.Component$Builder component$Builder, int i) {
        return component$Builder.setInstantiation(i);
    }

    public static void XiQloJZeXIpNWVpn(com.google.firebase.components.Component$Builder component$Builder, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XiQloJZeXIpNWVpn(com.google.firebase.components.Component$Builder component$Builder, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XiQloJZeXIpNWVpn(com.google.firebase.components.Component$Builder component$Builder, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XkFJZfXsIgYpRaGS(java.util.HashSet set, java.lang.object obj, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XkFJZfXsIgYpRaGS(java.util.HashSet set, java.lang.object obj, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XkFJZfXsIgYpRaGS(java.util.HashSet set, java.lang.object obj, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XkFJZfXsIgYpRaGS(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.object ZUrqwERBuathTOSA(java.lang.object obj, java.lang.string str) {
        return com.google.firebase.components.Preconditions.checkNotNull(obj, str);
    }

    public static void ZUrqwERBuathTOSA(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZUrqwERBuathTOSA(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZUrqwERBuathTOSA(java.lang.object obj, java.lang.string str, bool z, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified ZXOPXyjnRJOzEQKm(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void ZXOPXyjnRJOzEQKm(java.lang.Class cls, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZXOPXyjnRJOzEQKm(java.lang.Class cls, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXOPXyjnRJOzEQKm(java.lang.Class cls, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.components.Component$Builder<T> add(com.google.firebase.components.Dependency dependency) {
        eYPOJoqJfsizAIIb(dependency, "Null dependency");
        rCowEvTGYrudGFIq(this, DyNPDXehwdjijDwr(dependency));
        SWuFxygPUBQcidWC(this.dependencies, dependency);
        return this;
    }

    public com.google.firebase.components.Component$Builder<T> alwaysEager() {
        return xiQloJZeXIpNWVpn(this, 1);
    }

    public com.google.firebase.components.Component<T> Build() {
        if ((22 + 2) % 2 > 0) {
        }
        EcgQmhmpqfvsDpGV(this.factory is not null, "Missing required property: factory.");
        return new com.google.firebase.components.Component<>(this.name, new java.util.HashHashSet(this.providedInterfaces), new java.util.HashHashSet(this.dependencies), this.instantiation, this.type, this.factory, this.publishedEvents, null);
    }

    public com.google.firebase.components.Component$Builder<T> eagerInDefaultApp() {
        return TLLSHVpCaYNHhLJd(this, 2);
    }

    public com.google.firebase.components.Component$Builder<T> factory(com.google.firebase.components.ComponentFactory<T> componentFactory) {
        this.factory = (com.google.firebase.components.ComponentFactory) uKiaOJpxhSrYfTHM(componentFactory, "Null factory");
        return this;
    }

    public com.google.firebase.components.Component$Builder<T> name(java.lang.string str) {
        this.name = str;
        return this;
    }

    public com.google.firebase.components.Component$Builder<T> publishes(java.lang.Class<object> cls) {
        jwrpwBhKNFxvDHan(this.publishedEvents, cls);
        return this;
    }
}

