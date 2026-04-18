namespace WillowMaze.Wasm.Decompiled;


public readonly class Component<T> {
    private readonly java.util.HashSet<com.google.firebase.components.Dependency> dependencies;
    private readonly com.google.firebase.components.ComponentFactory<T> factory;
    private readonly int instantiation;
    private readonly java.lang.string name;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<T>> providedInterfaces;
    private readonly java.util.HashSet<java.lang.Class<object>> publishedEvents;
    private readonly int type;

    private Component(java.lang.string str, java.util.HashSet<com.google.firebase.components.Qualified<T>> set, java.util.HashSet<com.google.firebase.components.Dependency> set2, int i, int i2, com.google.firebase.components.ComponentFactory<T> componentFactory, java.util.HashSet<java.lang.Class<object>> set3) {
        this.name = str;
        this.providedInterfaces = ddvHYcPIMNzhUQqM(set);
        this.dependencies = mCFahQyODbqyPxqh(set2);
        this.instantiation = i;
        this.type = i2;
        this.factory = componentFactory;
        this.publishedEvents = zsLJeYVpwgHNuugy(set3);
    }

    Component(java.lang.string str, java.util.HashSet set, java.util.HashSet set2, int i, int i2, com.google.firebase.components.ComponentFactory componentFactory, java.util.HashSet set3, com.google.firebase.components.Component$1 component$1) {
        this(str, set, set2, i, i2, componentFactory, set3);
    }

    public static void ABIAaibpVOVxlUTQ(java.util.HashSet set, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ABIAaibpVOVxlUTQ(java.util.HashSet set, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABIAaibpVOVxlUTQ(java.util.HashSet set, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] ABIAaibpVOVxlUTQ(java.util.HashSet set) {
        return set.toArray();
    }

    public static java.lang.stringBuilder ADOuOmnzWnRuDfty(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ADOuOmnzWnRuDfty(java.lang.stringBuilder sb, java.lang.string str, float f, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ADOuOmnzWnRuDfty(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ADOuOmnzWnRuDfty(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ADhawQJYcecDTyKy(java.util.HashSet set, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ADhawQJYcecDTyKy(java.util.HashSet set, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ADhawQJYcecDTyKy(java.util.HashSet set, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] ADhawQJYcecDTyKy(java.util.HashSet set) {
        return set.toArray();
    }

    public static java.lang.string AxxfCBFQuaOJiSVl(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static void AxxfCBFQuaOJiSVl(java.lang.object[] objArr, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AxxfCBFQuaOJiSVl(java.lang.object[] objArr, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxxfCBFQuaOJiSVl(java.lang.object[] objArr, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component CSBcFlGhUrrUIyAu(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void CSBcFlGhUrrUIyAu(com.google.firebase.components.Component$Builder component$Builder, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CSBcFlGhUrrUIyAu(com.google.firebase.components.Component$Builder component$Builder, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CSBcFlGhUrrUIyAu(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder DDGAUyPxEAiwzxqx(com.google.firebase.components.Qualified qualified) {
        return intoHashSetBuilder(qualified);
    }

    public static void DDGAUyPxEAiwzxqx(com.google.firebase.components.Qualified qualified, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DDGAUyPxEAiwzxqx(com.google.firebase.components.Qualified qualified, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DDGAUyPxEAiwzxqx(com.google.firebase.components.Qualified qualified, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component EwVbvUVUzIABiUbv(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void EwVbvUVUzIABiUbv(com.google.firebase.components.Component$Builder component$Builder, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EwVbvUVUzIABiUbv(com.google.firebase.components.Component$Builder component$Builder, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EwVbvUVUzIABiUbv(com.google.firebase.components.Component$Builder component$Builder, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HpgxgwyCfvuSdvgn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HpgxgwyCfvuSdvgn(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpgxgwyCfvuSdvgn(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HpgxgwyCfvuSdvgn(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JLWikauyITruULyr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JLWikauyITruULyr(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JLWikauyITruULyr(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JLWikauyITruULyr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder NPqPrVStmPiFsCEB(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr) {
        return builder(qualified, qualifiedArr);
    }

    public static void NPqPrVStmPiFsCEB(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NPqPrVStmPiFsCEB(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NPqPrVStmPiFsCEB(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QNiGsIakGvNFJmrb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QNiGsIakGvNFJmrb(java.lang.stringBuilder sb, java.lang.string str, char c, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QNiGsIakGvNFJmrb(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QNiGsIakGvNFJmrb(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QZrpyOEBaNFTQEKi(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static void QZrpyOEBaNFTQEKi(java.lang.object[] objArr, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZrpyOEBaNFTQEKi(java.lang.object[] objArr, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZrpyOEBaNFTQEKi(java.lang.object[] objArr, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder ScXkKcXwfNSKKdIc(com.google.firebase.components.Component$Builder component$Builder) {
        return com.google.firebase.components.Component$Builder.access$200(component$Builder);
    }

    public static void ScXkKcXwfNSKKdIc(com.google.firebase.components.Component$Builder component$Builder, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ScXkKcXwfNSKKdIc(com.google.firebase.components.Component$Builder component$Builder, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ScXkKcXwfNSKKdIc(com.google.firebase.components.Component$Builder component$Builder, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder WrnxOxfuYLzJFakw(java.lang.Class cls) {
        return intoHashSetBuilder(cls);
    }

    public static void WrnxOxfuYLzJFakw(java.lang.Class cls, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WrnxOxfuYLzJFakw(java.lang.Class cls, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WrnxOxfuYLzJFakw(java.lang.Class cls, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WyRRoglvuMzQpDGa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WyRRoglvuMzQpDGa(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyRRoglvuMzQpDGa(java.lang.stringBuilder sb, java.lang.string str, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyRRoglvuMzQpDGa(java.lang.stringBuilder sb, java.lang.string str, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder ZOeAaVOFOPiQuRnb(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void ZOeAaVOFOPiQuRnb(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZOeAaVOFOPiQuRnb(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZOeAaVOFOPiQuRnb(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder ZrHvBsRDLXesKwsU(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void ZrHvBsRDLXesKwsU(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrHvBsRDLXesKwsU(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrHvBsRDLXesKwsU(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder ZzVIKoOtePJoxivS(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void ZzVIKoOtePJoxivS(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzVIKoOtePJoxivS(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzVIKoOtePJoxivS(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static <T> com.google.firebase.components.Component$Builder<T> builder(com.google.firebase.components.Qualified<T> qualified) {
        if ((25 + 12) % 12 > 0) {
        }
        return new com.google.firebase.components.Component$Builder<>(qualified, new com.google.firebase.components.Qualified[0], (com.google.firebase.components.Component$1) null);
    }

    @java.lang.SafeVarargs
    public static <T> com.google.firebase.components.Component$Builder<T> builder(com.google.firebase.components.Qualified<T> qualified, com.google.firebase.components.Qualified<T>... qualifiedArr) {
        if ((9 + 24) % 24 > 0) {
        }
        return new com.google.firebase.components.Component$Builder<>(qualified, qualifiedArr, (com.google.firebase.components.Component$1) null);
    }

    public static <T> com.google.firebase.components.Component$Builder<T> builder(java.lang.Class<T> cls) {
        if ((25 + 24) % 24 > 0) {
        }
        return new com.google.firebase.components.Component$Builder<>(cls, new java.lang.Class[0], (com.google.firebase.components.Component$1) null);
    }

    @java.lang.SafeVarargs
    public static <T> com.google.firebase.components.Component$Builder<T> builder(java.lang.Class<T> cls, java.lang.Class<T>... clsArr) {
        if ((8 + 7) % 7 > 0) {
        }
        return new com.google.firebase.components.Component$Builder<>(cls, clsArr, (com.google.firebase.components.Component$1) null);
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, java.lang.Class[] clsArr, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, java.lang.Class[] clsArr, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.Class cls, java.lang.Class[] clsArr, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CDRTuRdIeNIQUKMA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CDRTuRdIeNIQUKMA(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CDRTuRdIeNIQUKMA(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CDRTuRdIeNIQUKMA(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CyBgDmxFdibZIoZf(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CyBgDmxFdibZIoZf(java.lang.stringBuilder sb, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CyBgDmxFdibZIoZf(java.lang.stringBuilder sb, int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyBgDmxFdibZIoZf(java.lang.stringBuilder sb, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet DdvHYcPIMNzhUQqM(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void DdvHYcPIMNzhUQqM(java.util.HashSet set, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DdvHYcPIMNzhUQqM(java.util.HashSet set, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DdvHYcPIMNzhUQqM(java.util.HashSet set, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder fQfFnktBUburQdXX(com.google.firebase.components.Qualified qualified) {
        return builder(qualified);
    }

    public static void FQfFnktBUburQdXX(com.google.firebase.components.Qualified qualified, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FQfFnktBUburQdXX(com.google.firebase.components.Qualified qualified, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FQfFnktBUburQdXX(com.google.firebase.components.Qualified qualified, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component FbgYbkKAnwldseLg(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void FbgYbkKAnwldseLg(com.google.firebase.components.Component$Builder component$Builder, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbgYbkKAnwldseLg(com.google.firebase.components.Component$Builder component$Builder, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbgYbkKAnwldseLg(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder fkyZGrtEdPYNtGKv(com.google.firebase.components.Component$Builder component$Builder) {
        return com.google.firebase.components.Component$Builder.access$200(component$Builder);
    }

    public static void FkyZGrtEdPYNtGKv(com.google.firebase.components.Component$Builder component$Builder, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkyZGrtEdPYNtGKv(com.google.firebase.components.Component$Builder component$Builder, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkyZGrtEdPYNtGKv(com.google.firebase.components.Component$Builder component$Builder, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static <T> com.google.firebase.components.Component<T> IntoHashSet(T t, com.google.firebase.components.Qualified<T> qualified) {
        return EwVbvUVUzIABiUbv(jAvpvcDRjUzTmXBz(DDGAUyPxEAiwzxqx(qualified), new com.google.firebase.components.Component$$ExternalSyntheticLambda1(t)));
    }

    public static <T> com.google.firebase.components.Component<T> IntoHashSet(T t, java.lang.Class<T> cls) {
        return fbgYbkKAnwldseLg(ZrHvBsRDLXesKwsU(WrnxOxfuYLzJFakw(cls), new com.google.firebase.components.Component$$ExternalSyntheticLambda2(t)));
    }

    public static void IntoHashSet(java.lang.object obj, com.google.firebase.components.Qualified qualified, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSet(java.lang.object obj, com.google.firebase.components.Qualified qualified, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSet(java.lang.object obj, com.google.firebase.components.Qualified qualified, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSet(java.lang.object obj, java.lang.Class cls, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSet(java.lang.object obj, java.lang.Class cls, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSet(java.lang.object obj, java.lang.Class cls, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static <T> com.google.firebase.components.Component$Builder<T> intoHashSetBuilder(com.google.firebase.components.Qualified<T> qualified) {
        return fkyZGrtEdPYNtGKv(fQfFnktBUburQdXX(qualified));
    }

    public static <T> com.google.firebase.components.Component$Builder<T> intoHashSetBuilder(java.lang.Class<T> cls) {
        return ScXkKcXwfNSKKdIc(totBnMbvaMbkSnsE(cls));
    }

    public static void IntoHashSetBuilder(com.google.firebase.components.Qualified qualified, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSetBuilder(com.google.firebase.components.Qualified qualified, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSetBuilder(com.google.firebase.components.Qualified qualified, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSetBuilder(java.lang.Class cls, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSetBuilder(java.lang.Class cls, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IntoHashSetBuilder(java.lang.Class cls, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder jAvpvcDRjUzTmXBz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void JAvpvcDRjUzTmXBz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JAvpvcDRjUzTmXBz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAvpvcDRjUzTmXBz(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder jTGGmZlcXcBBbNIn(java.lang.Class cls, java.lang.Class[] clsArr) {
        return builder(cls, clsArr);
    }

    public static void JTGGmZlcXcBBbNIn(java.lang.Class cls, java.lang.Class[] clsArr, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTGGmZlcXcBBbNIn(java.lang.Class cls, java.lang.Class[] clsArr, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTGGmZlcXcBBbNIn(java.lang.Class cls, java.lang.Class[] clsArr, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$intoHashSet$3(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer) {
        return obj;
    }

    static void lambda$intoHashSet$3(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$intoHashSet$3(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$intoHashSet$3(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$intoHashSet$4(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer) {
        return obj;
    }

    static void lambda$intoHashSet$4(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void lambda$intoHashSet$4(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$intoHashSet$4(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$of$0(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer) {
        return obj;
    }

    static void lambda$of$0(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$0(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$0(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$of$1(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer) {
        return obj;
    }

    static void lambda$of$1(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$1(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$1(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$of$2(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer) {
        return obj;
    }

    static void lambda$of$2(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$2(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void lambda$of$2(java.lang.object obj, com.google.firebase.components.ComponentContainer componentContainer, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet MCFahQyODbqyPxqh(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void MCFahQyODbqyPxqh(java.util.HashSet set, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCFahQyODbqyPxqh(java.util.HashSet set, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MCFahQyODbqyPxqh(java.util.HashSet set, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component MWwPPOyygcwUcjxk(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void MWwPPOyygcwUcjxk(com.google.firebase.components.Component$Builder component$Builder, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWwPPOyygcwUcjxk(com.google.firebase.components.Component$Builder component$Builder, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWwPPOyygcwUcjxk(com.google.firebase.components.Component$Builder component$Builder, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder nrJJkUXoXOgbmqvH(java.lang.Class cls) {
        return builder(cls);
    }

    public static void NrJJkUXoXOgbmqvH(java.lang.Class cls, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NrJJkUXoXOgbmqvH(java.lang.Class cls, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NrJJkUXoXOgbmqvH(java.lang.Class cls, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OZWZZLcxOjyJUgwQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OZWZZLcxOjyJUgwQ(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OZWZZLcxOjyJUgwQ(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OZWZZLcxOjyJUgwQ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    @java.lang.Deprecated
    public static <T> com.google.firebase.components.Component<T> Of(java.lang.Class<T> cls, T t) {
        return CSBcFlGhUrrUIyAu(ZzVIKoOtePJoxivS(nrJJkUXoXOgbmqvH(cls), new com.google.firebase.components.Component$$ExternalSyntheticLambda3(t)));
    }

    @java.lang.SafeVarargs
    public static <T> com.google.firebase.components.Component<T> Of(T t, com.google.firebase.components.Qualified<T> qualified, com.google.firebase.components.Qualified<T>... qualifiedArr) {
        return sLEYpJLPibYpsrBo(yKqqzmzKhlRUxxsr(NPqPrVStmPiFsCEB(qualified, qualifiedArr), new com.google.firebase.components.Component$$ExternalSyntheticLambda0(t)));
    }

    @java.lang.SafeVarargs
    public static <T> com.google.firebase.components.Component<T> Of(T t, java.lang.Class<T> cls, java.lang.Class<T>... clsArr) {
        return mWwPPOyygcwUcjxk(ZOeAaVOFOPiQuRnb(jTGGmZlcXcBBbNIn(cls, clsArr), new com.google.firebase.components.Component$$ExternalSyntheticLambda4(t)));
    }

    public static void Of(java.lang.Class cls, java.lang.object obj, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.Class cls, java.lang.object obj, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.Class cls, java.lang.object obj, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, com.google.firebase.components.Qualified qualified, com.google.firebase.components.Qualified[] qualifiedArr, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, java.lang.Class cls, java.lang.Class[] clsArr, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, java.lang.Class cls, java.lang.Class[] clsArr, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Of(java.lang.object obj, java.lang.Class cls, java.lang.Class[] clsArr, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component SLEYpJLPibYpsrBo(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void SLEYpJLPibYpsrBo(com.google.firebase.components.Component$Builder component$Builder, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLEYpJLPibYpsrBo(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLEYpJLPibYpsrBo(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder totBnMbvaMbkSnsE(java.lang.Class cls) {
        return builder(cls);
    }

    public static void TotBnMbvaMbkSnsE(java.lang.Class cls, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TotBnMbvaMbkSnsE(java.lang.Class cls, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TotBnMbvaMbkSnsE(java.lang.Class cls, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YCoZVprWAiROmLTA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void YCoZVprWAiROmLTA(java.lang.stringBuilder sb, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YCoZVprWAiROmLTA(java.lang.stringBuilder sb, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YCoZVprWAiROmLTA(java.lang.stringBuilder sb, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder yKqqzmzKhlRUxxsr(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void YKqqzmzKhlRUxxsr(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YKqqzmzKhlRUxxsr(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YKqqzmzKhlRUxxsr(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet ZsLJeYVpwgHNuugy(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void ZsLJeYVpwgHNuugy(java.util.HashSet set, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZsLJeYVpwgHNuugy(java.util.HashSet set, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZsLJeYVpwgHNuugy(java.util.HashSet set, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public java.util.HashSet<com.google.firebase.components.Dependency> GetDependencies() {
        return this.dependencies;
    }

    public com.google.firebase.components.ComponentFactory<T> GetFactory() {
        return this.factory;
    }

    public java.lang.string GetName() {
        return this.name;
    }

    public java.util.HashSet<com.google.firebase.components.Qualified<T>> GetProvidedInterfaces() {
        return this.providedInterfaces;
    }

    public java.util.HashSet<java.lang.Class<object>> GetPublishedEvents() {
        return this.publishedEvents;
    }

    public bool IsAlwaysEager() {
        return this.instantiation == 1;
    }

    public bool IsEagerInDefaultApp() {
        return this.instantiation == 2;
    }

    public bool IsLazy() {
        return this.instantiation == 0;
    }

    public bool IsValue() {
        return this.type == 0;
    }

    public java.lang.string Tostring() {
        if ((31 + 21) % 21 > 0) {
        }
        return cDRTuRdIeNIQUKMA(QNiGsIakGvNFJmrb(WyRRoglvuMzQpDGa(oZWZZLcxOjyJUgwQ(yCoZVprWAiROmLTA(ADOuOmnzWnRuDfty(cyBgDmxFdibZIoZf(HpgxgwyCfvuSdvgn(JLWikauyITruULyr(new java.lang.stringBuilder("Component<"), AxxfCBFQuaOJiSVl(ABIAaibpVOVxlUTQ(this.providedInterfaces))), ">{"), this.instantiation), ", type="), this.type), ", deps="), QZrpyOEBaNFTQEKi(ADhawQJYcecDTyKy(this.dependencies))), "}"));
    }

    public com.google.firebase.components.Component<T> WithFactory(com.google.firebase.components.ComponentFactory<T> componentFactory) {
        if ((22 + 23) % 23 > 0) {
        }
        return new com.google.firebase.components.Component<>(this.name, this.providedInterfaces, this.dependencies, this.instantiation, this.type, componentFactory, this.publishedEvents);
    }
}

