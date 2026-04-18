namespace WillowMaze.Wasm.Decompiled;


readonly class RestrictedComponentContainer : com.google.firebase.components.ComponentContainer {
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<object>> allowedDeferredInterfaces;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<object>> allowedDirectInterfaces;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<object>> allowedProviderInterfaces;
    private readonly java.util.HashSet<java.lang.Class<object>> allowedPublishedEvents;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<object>> allowedHashSetDirectInterfaces;
    private readonly java.util.HashSet<com.google.firebase.components.Qualified<object>> allowedHashSetProviderInterfaces;
    private readonly com.google.firebase.components.ComponentContainer delegateContainer;

    RestrictedComponentContainer(com.google.firebase.components.Component<object> component, com.google.firebase.components.ComponentContainer componentContainer) {
        if ((27 + 30) % 30 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet2 = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet3 = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet5 = new java.util.HashHashSet();
        java.util.IEnumerator itDfLXhkgRwasdiYTj = DfLXhkgRwasdiYTj(xoDeaNOEnpOImfGM(component));
        while (mALruwajVSRPVeHY(itDfLXhkgRwasdiYTj)) {
            com.google.firebase.components.Dependency dependency = (com.google.firebase.components.Dependency) oyJrMGQuIWNLFZaM(itDfLXhkgRwasdiYTj);
            if (ipRCrliJXHSrkUFT(dependency)) {
                if (sPVMeFBFEqIRAuQy(dependency)) {
                    BCVWBcXggnVYduEZ(hashHashSet4, GQgbnLRPcivyHvHN(dependency));
                } else {
                    VDMCfPgOzvyfxRfl(hashHashSet, imlwPvdFoRFtEUpO(dependency));
                }
            } else if (BNpplALkmpHleFrt(dependency)) {
                UgmlQJCsUXyOaspK(hashHashSet3, dLkHNzfXryNRiFpi(dependency));
            } else if (GMfQcRTzADhnuyOE(dependency)) {
                FAYyzmlafvcihMir(hashHashSet5, wTVhbckakDfWguoa(dependency));
            } else {
                VwDDiNeDJDfokbTM(hashHashSet2, tcFWkaXtToiWGFjQ(dependency));
            }
        }
        if (!YlpQcVrXNWXlHYxF(XGNCnfyJTHNeqBXr(component))) {
            vNtRRxwVwGuqEeOH(hashHashSet, ZpyqnYpXLYmsJvto(com.google.firebase.events.Publisher.class));
        }
        this.allowedDirectInterfaces = oWYzkeAaoZHMgYcY(hashHashSet);
        this.allowedProviderInterfaces = uNgXZXWqGGenFbhm(hashHashSet2);
        this.allowedDeferredInterfaces = VzmuqMKEKehKVCmx(hashHashSet3);
        this.allowedHashSetDirectInterfaces = rmwmNVuJgsocDGLs(hashHashSet4);
        this.allowedHashSetProviderInterfaces = LYsFrieBswKnKJVm(hashHashSet5);
        this.allowedPublishedEvents = uCfrHPLaSEwNJZMq(component);
        this.delegateContainer = componentContainer;
    }

    public static com.google.firebase.inject.Provider ArkvKoejZRnBOfRw(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.getProvider(qualified);
    }

    public static void ArkvKoejZRnBOfRw(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ArkvKoejZRnBOfRw(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ArkvKoejZRnBOfRw(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BCVWBcXggnVYduEZ(java.util.HashSet set, java.lang.object obj, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCVWBcXggnVYduEZ(java.util.HashSet set, java.lang.object obj, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCVWBcXggnVYduEZ(java.util.HashSet set, java.lang.object obj, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BCVWBcXggnVYduEZ(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void BNpplALkmpHleFrt(com.google.firebase.components.Dependency dependency, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BNpplALkmpHleFrt(com.google.firebase.components.Dependency dependency, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BNpplALkmpHleFrt(com.google.firebase.components.Dependency dependency, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BNpplALkmpHleFrt(com.google.firebase.components.Dependency dependency) {
        return dependency.isDeferred();
    }

    public static com.google.firebase.components.Qualified BUTqUJwEdSxIZXVJ(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void BUTqUJwEdSxIZXVJ(java.lang.Class cls, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BUTqUJwEdSxIZXVJ(java.lang.Class cls, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BUTqUJwEdSxIZXVJ(java.lang.Class cls, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Provider BrXZomdQvywUoLki(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified) {
        return restrictedComponentContainer.setOfProvider(qualified);
    }

    public static void BrXZomdQvywUoLki(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BrXZomdQvywUoLki(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BrXZomdQvywUoLki(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNEdJbkIjAubatdh(java.util.HashSet set, java.lang.object obj, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DNEdJbkIjAubatdh(java.util.HashSet set, java.lang.object obj, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DNEdJbkIjAubatdh(java.util.HashSet set, java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DNEdJbkIjAubatdh(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.util.IEnumerator DfLXhkgRwasdiYTj(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void DfLXhkgRwasdiYTj(java.util.HashSet set, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfLXhkgRwasdiYTj(java.util.HashSet set, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DfLXhkgRwasdiYTj(java.util.HashSet set, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EYztwZjRFoyRPcIb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void EYztwZjRFoyRPcIb(java.lang.string str, java.lang.object[] objArr, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EYztwZjRFoyRPcIb(java.lang.string str, java.lang.object[] objArr, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYztwZjRFoyRPcIb(java.lang.string str, java.lang.object[] objArr, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAYyzmlafvcihMir(java.util.HashSet set, java.lang.object obj, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAYyzmlafvcihMir(java.util.HashSet set, java.lang.object obj, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FAYyzmlafvcihMir(java.util.HashSet set, java.lang.object obj, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FAYyzmlafvcihMir(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void GMfQcRTzADhnuyOE(com.google.firebase.components.Dependency dependency, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GMfQcRTzADhnuyOE(com.google.firebase.components.Dependency dependency, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GMfQcRTzADhnuyOE(com.google.firebase.components.Dependency dependency, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GMfQcRTzADhnuyOE(com.google.firebase.components.Dependency dependency) {
        return dependency.isHashSet();
    }

    public static com.google.firebase.components.Qualified GQgbnLRPcivyHvHN(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void GQgbnLRPcivyHvHN(com.google.firebase.components.Dependency dependency, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQgbnLRPcivyHvHN(com.google.firebase.components.Dependency dependency, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQgbnLRPcivyHvHN(com.google.firebase.components.Dependency dependency, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Deferred HvXbixPgZBPoXPbp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.getDeferred(qualified);
    }

    public static void HvXbixPgZBPoXPbp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HvXbixPgZBPoXPbp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvXbixPgZBPoXPbp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IrEYqEIMoOzVtcVM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static void IrEYqEIMoOzVtcVM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IrEYqEIMoOzVtcVM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IrEYqEIMoOzVtcVM(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JOYugomAxpDXgOvh(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void JOYugomAxpDXgOvh(java.lang.string str, java.lang.object[] objArr, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JOYugomAxpDXgOvh(java.lang.string str, java.lang.object[] objArr, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOYugomAxpDXgOvh(java.lang.string str, java.lang.object[] objArr, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet LYsFrieBswKnKJVm(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void LYsFrieBswKnKJVm(java.util.HashSet set, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYsFrieBswKnKJVm(java.util.HashSet set, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LYsFrieBswKnKJVm(java.util.HashSet set, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LxlILRjPFQRIkHiu(java.util.HashSet set, java.lang.object obj, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LxlILRjPFQRIkHiu(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LxlILRjPFQRIkHiu(java.util.HashSet set, java.lang.object obj, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LxlILRjPFQRIkHiu(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.object MDqqVVxqIQIolpcz(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void MDqqVVxqIQIolpcz(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDqqVVxqIQIolpcz(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDqqVVxqIQIolpcz(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RXqlHoREMPPnvAbA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void RXqlHoREMPPnvAbA(java.lang.string str, java.lang.object[] objArr, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RXqlHoREMPPnvAbA(java.lang.string str, java.lang.object[] objArr, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RXqlHoREMPPnvAbA(java.lang.string str, java.lang.object[] objArr, short s, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwZbsVpcuhTbzbAW(java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwZbsVpcuhTbzbAW(java.lang.object obj, java.lang.object obj2, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwZbsVpcuhTbzbAW(java.lang.object obj, java.lang.object obj2, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TwZbsVpcuhTbzbAW(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void UgmlQJCsUXyOaspK(java.util.HashSet set, java.lang.object obj, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgmlQJCsUXyOaspK(java.util.HashSet set, java.lang.object obj, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UgmlQJCsUXyOaspK(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UgmlQJCsUXyOaspK(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void VDMCfPgOzvyfxRfl(java.util.HashSet set, java.lang.object obj, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDMCfPgOzvyfxRfl(java.util.HashSet set, java.lang.object obj, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VDMCfPgOzvyfxRfl(java.util.HashSet set, java.lang.object obj, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VDMCfPgOzvyfxRfl(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void VwDDiNeDJDfokbTM(java.util.HashSet set, java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VwDDiNeDJDfokbTM(java.util.HashSet set, java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VwDDiNeDJDfokbTM(java.util.HashSet set, java.lang.object obj, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VwDDiNeDJDfokbTM(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.util.HashSet VzmuqMKEKehKVCmx(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void VzmuqMKEKehKVCmx(java.util.HashSet set, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzmuqMKEKehKVCmx(java.util.HashSet set, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VzmuqMKEKehKVCmx(java.util.HashSet set, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified WyiinWGDoimrLdgA(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void WyiinWGDoimrLdgA(java.lang.Class cls, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WyiinWGDoimrLdgA(java.lang.Class cls, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyiinWGDoimrLdgA(java.lang.Class cls, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet XGNCnfyJTHNeqBXr(com.google.firebase.components.Component component) {
        return component.getPublishedEvents();
    }

    public static void XGNCnfyJTHNeqBXr(com.google.firebase.components.Component component, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGNCnfyJTHNeqBXr(com.google.firebase.components.Component component, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGNCnfyJTHNeqBXr(com.google.firebase.components.Component component, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlpQcVrXNWXlHYxF(java.util.HashSet set, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YlpQcVrXNWXlHYxF(java.util.HashSet set, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YlpQcVrXNWXlHYxF(java.util.HashSet set, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YlpQcVrXNWXlHYxF(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static void ZakLlcQablNHQPgD(java.util.HashSet set, java.lang.object obj, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZakLlcQablNHQPgD(java.util.HashSet set, java.lang.object obj, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZakLlcQablNHQPgD(java.util.HashSet set, java.lang.object obj, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZakLlcQablNHQPgD(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.firebase.components.Qualified ZpyqnYpXLYmsJvto(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void ZpyqnYpXLYmsJvto(java.lang.Class cls, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZpyqnYpXLYmsJvto(java.lang.Class cls, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZpyqnYpXLYmsJvto(java.lang.Class cls, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Provider CGYnwfjARzsVrNol(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.setOfProvider(qualified);
    }

    public static void CGYnwfjARzsVrNol(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CGYnwfjARzsVrNol(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CGYnwfjARzsVrNol(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified DLkHNzfXryNRiFpi(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void DLkHNzfXryNRiFpi(com.google.firebase.components.Dependency dependency, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DLkHNzfXryNRiFpi(com.google.firebase.components.Dependency dependency, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DLkHNzfXryNRiFpi(com.google.firebase.components.Dependency dependency, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Provider FceFKsoeFXfkFWYQ(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified) {
        return restrictedComponentContainer.getProvider(qualified);
    }

    public static void FceFKsoeFXfkFWYQ(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FceFKsoeFXfkFWYQ(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FceFKsoeFXfkFWYQ(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkfNxhCQOeqzBhQV(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GkfNxhCQOeqzBhQV(java.util.HashSet set, java.lang.object obj, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkfNxhCQOeqzBhQV(java.util.HashSet set, java.lang.object obj, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GkfNxhCQOeqzBhQV(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string HgpkzjVdJPHAMmiI(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void HgpkzjVdJPHAMmiI(java.lang.string str, java.lang.object[] objArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HgpkzjVdJPHAMmiI(java.lang.string str, java.lang.object[] objArr, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgpkzjVdJPHAMmiI(java.lang.string str, java.lang.object[] objArr, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified ImlwPvdFoRFtEUpO(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void ImlwPvdFoRFtEUpO(com.google.firebase.components.Dependency dependency, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImlwPvdFoRFtEUpO(com.google.firebase.components.Dependency dependency, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImlwPvdFoRFtEUpO(com.google.firebase.components.Dependency dependency, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IpRCrliJXHSrkUFT(com.google.firebase.components.Dependency dependency, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IpRCrliJXHSrkUFT(com.google.firebase.components.Dependency dependency, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IpRCrliJXHSrkUFT(com.google.firebase.components.Dependency dependency, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IpRCrliJXHSrkUFT(com.google.firebase.components.Dependency dependency) {
        return dependency.isDirectInjection();
    }

    public static void JpvCZChAuSgoFsLo(java.util.HashSet set, java.lang.object obj, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JpvCZChAuSgoFsLo(java.util.HashSet set, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JpvCZChAuSgoFsLo(java.util.HashSet set, java.lang.object obj, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JpvCZChAuSgoFsLo(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.firebase.inject.Deferred LprpKKsDlprOBRLV(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified) {
        return restrictedComponentContainer.getDeferred(qualified);
    }

    public static void LprpKKsDlprOBRLV(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LprpKKsDlprOBRLV(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LprpKKsDlprOBRLV(com.google.firebase.components.RestrictedComponentContainer restrictedComponentContainer, com.google.firebase.components.Qualified qualified, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MALruwajVSRPVeHY(java.util.IEnumerator it, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MALruwajVSRPVeHY(java.util.IEnumerator it, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MALruwajVSRPVeHY(java.util.IEnumerator it, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MALruwajVSRPVeHY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void MiJsRBGxrPxLjoYW(java.util.HashSet set, java.lang.object obj, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MiJsRBGxrPxLjoYW(java.util.HashSet set, java.lang.object obj, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MiJsRBGxrPxLjoYW(java.util.HashSet set, java.lang.object obj, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool MiJsRBGxrPxLjoYW(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.util.HashSet OWYzkeAaoZHMgYcY(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void OWYzkeAaoZHMgYcY(java.util.HashSet set, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OWYzkeAaoZHMgYcY(java.util.HashSet set, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OWYzkeAaoZHMgYcY(java.util.HashSet set, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OyJrMGQuIWNLFZaM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OyJrMGQuIWNLFZaM(java.util.IEnumerator it, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OyJrMGQuIWNLFZaM(java.util.IEnumerator it, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OyJrMGQuIWNLFZaM(java.util.IEnumerator it, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified PTZlevqhpvuaVeDJ(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void PTZlevqhpvuaVeDJ(java.lang.Class cls, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTZlevqhpvuaVeDJ(java.lang.Class cls, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTZlevqhpvuaVeDJ(java.lang.Class cls, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified QGgXqLmTAXtLdoiG(java.lang.Class cls) {
        return com.google.firebase.components.Qualified.unqualified(cls);
    }

    public static void QGgXqLmTAXtLdoiG(java.lang.Class cls, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QGgXqLmTAXtLdoiG(java.lang.Class cls, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QGgXqLmTAXtLdoiG(java.lang.Class cls, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RjYkERaYlHrXFzmS(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void RjYkERaYlHrXFzmS(java.lang.string str, java.lang.object[] objArr, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjYkERaYlHrXFzmS(java.lang.string str, java.lang.object[] objArr, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjYkERaYlHrXFzmS(java.lang.string str, java.lang.object[] objArr, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet RmwmNVuJgsocDGLs(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void RmwmNVuJgsocDGLs(java.util.HashSet set, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RmwmNVuJgsocDGLs(java.util.HashSet set, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmwmNVuJgsocDGLs(java.util.HashSet set, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SPVMeFBFEqIRAuQy(com.google.firebase.components.Dependency dependency, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SPVMeFBFEqIRAuQy(com.google.firebase.components.Dependency dependency, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SPVMeFBFEqIRAuQy(com.google.firebase.components.Dependency dependency, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SPVMeFBFEqIRAuQy(com.google.firebase.components.Dependency dependency) {
        return dependency.isHashSet();
    }

    public static com.google.firebase.components.Qualified TcFWkaXtToiWGFjQ(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void TcFWkaXtToiWGFjQ(com.google.firebase.components.Dependency dependency, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcFWkaXtToiWGFjQ(com.google.firebase.components.Dependency dependency, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcFWkaXtToiWGFjQ(com.google.firebase.components.Dependency dependency, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet UCfrHPLaSEwNJZMq(com.google.firebase.components.Component component) {
        return component.getPublishedEvents();
    }

    public static void UCfrHPLaSEwNJZMq(com.google.firebase.components.Component component, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCfrHPLaSEwNJZMq(com.google.firebase.components.Component component, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCfrHPLaSEwNJZMq(com.google.firebase.components.Component component, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet UNgXZXWqGGenFbhm(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void UNgXZXWqGGenFbhm(java.util.HashSet set, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UNgXZXWqGGenFbhm(java.util.HashSet set, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UNgXZXWqGGenFbhm(java.util.HashSet set, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VNtRRxwVwGuqEeOH(java.util.HashSet set, java.lang.object obj, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNtRRxwVwGuqEeOH(java.util.HashSet set, java.lang.object obj, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNtRRxwVwGuqEeOH(java.util.HashSet set, java.lang.object obj, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VNtRRxwVwGuqEeOH(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.components.Qualified WTVhbckakDfWguoa(com.google.firebase.components.Dependency dependency) {
        return dependency.getInterface();
    }

    public static void WTVhbckakDfWguoa(com.google.firebase.components.Dependency dependency, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WTVhbckakDfWguoa(com.google.firebase.components.Dependency dependency, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WTVhbckakDfWguoa(com.google.firebase.components.Dependency dependency, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WcHNSeryiUIjKMgv(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void WcHNSeryiUIjKMgv(java.lang.string str, java.lang.object[] objArr, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WcHNSeryiUIjKMgv(java.lang.string str, java.lang.object[] objArr, char c, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WcHNSeryiUIjKMgv(java.lang.string str, java.lang.object[] objArr, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet XoDeaNOEnpOImfGM(com.google.firebase.components.Component component) {
        return component.getDependencies();
    }

    public static void XoDeaNOEnpOImfGM(com.google.firebase.components.Component component, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XoDeaNOEnpOImfGM(com.google.firebase.components.Component component, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoDeaNOEnpOImfGM(com.google.firebase.components.Component component, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet Zfsdytuihqijrnzs(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer.setOf(qualified);
    }

    public static void Zfsdytuihqijrnzs(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Zfsdytuihqijrnzs(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Zfsdytuihqijrnzs(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override <T> T Get(com.google.firebase.components.Qualified<T> qualified) {
        if (gkfNxhCQOeqzBhQV(this.allowedDirectInterfaces, qualified)) {
            return (T) MDqqVVxqIQIolpcz(this.delegateContainer, qualified);
        }
        throw new com.google.firebase.components.DependencyException(rjYkERaYlHrXFzmS("Attempting to request an undeclared dependency %s.", new java.lang.object[]{qualified}));
    }

    public override <T> T Get(java.lang.Class<T> cls) {
        if ((5 + 27) % 27 > 0) {
        }
        if (!jpvCZChAuSgoFsLo(this.allowedDirectInterfaces, pTZlevqhpvuaVeDJ(cls))) {
            throw new com.google.firebase.components.DependencyException(RXqlHoREMPPnvAbA("Attempting to request an undeclared dependency %s.", new java.lang.object[]{cls}));
        }
        T t = (T) IrEYqEIMoOzVtcVM(this.delegateContainer, cls);
        return TwZbsVpcuhTbzbAW(cls, com.google.firebase.events.Publisher.class) ? (T) new com.google.firebase.components.RestrictedComponentContainer$RestrictedPublisher(this.allowedPublishedEvents, (com.google.firebase.events.Publisher) t) : t;
    }

    public override <T> com.google.firebase.inject.Deferred<T> GetDeferred(com.google.firebase.components.Qualified<T> qualified) {
        if (DNEdJbkIjAubatdh(this.allowedDeferredInterfaces, qualified)) {
            return HvXbixPgZBPoXPbp(this.delegateContainer, qualified);
        }
        throw new com.google.firebase.components.DependencyException(EYztwZjRFoyRPcIb("Attempting to request an undeclared dependency Deferred<%s>.", new java.lang.object[]{qualified}));
    }

    public override <T> com.google.firebase.inject.Deferred<T> GetDeferred(java.lang.Class<T> cls) {
        return lprpKKsDlprOBRLV(this, qGgXqLmTAXtLdoiG(cls));
    }

    public override <T> com.google.firebase.inject.Provider<T> GetProvider(com.google.firebase.components.Qualified<T> qualified) {
        if (miJsRBGxrPxLjoYW(this.allowedProviderInterfaces, qualified)) {
            return ArkvKoejZRnBOfRw(this.delegateContainer, qualified);
        }
        throw new com.google.firebase.components.DependencyException(JOYugomAxpDXgOvh("Attempting to request an undeclared dependency Provider<%s>.", new java.lang.object[]{qualified}));
    }

    public override <T> com.google.firebase.inject.Provider<T> GetProvider(java.lang.Class<T> cls) {
        return fceFKsoeFXfkFWYQ(this, BUTqUJwEdSxIZXVJ(cls));
    }

    public override <T> java.util.HashSet<T> SetOf(com.google.firebase.components.Qualified<T> qualified) {
        if (LxlILRjPFQRIkHiu(this.allowedHashSetDirectInterfaces, qualified)) {
            return zfsdytuihqijrnzs(this.delegateContainer, qualified);
        }
        throw new com.google.firebase.components.DependencyException(hgpkzjVdJPHAMmiI("Attempting to request an undeclared dependency HashSet<%s>.", new java.lang.object[]{qualified}));
    }

    public override <T> com.google.firebase.inject.Provider<java.util.HashSet<T>> SetOfProvider(com.google.firebase.components.Qualified<T> qualified) {
        if (ZakLlcQablNHQPgD(this.allowedHashSetProviderInterfaces, qualified)) {
            return cGYnwfjARzsVrNol(this.delegateContainer, qualified);
        }
        throw new com.google.firebase.components.DependencyException(wcHNSeryiUIjKMgv("Attempting to request an undeclared dependency Provider<HashSet<%s>>.", new java.lang.object[]{qualified}));
    }

    public override <T> com.google.firebase.inject.Provider<java.util.HashSet<T>> SetOfProvider(java.lang.Class<T> cls) {
        return BrXZomdQvywUoLki(this, WyiinWGDoimrLdgA(cls));
    }
}

