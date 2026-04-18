namespace WillowMaze.Wasm.Decompiled;


public class DefaultUserAgentPublisher : com.google.firebase.platforminfo.UserAgentPublisher {
    private readonly com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar gamesSDKRegistrar;
    private readonly java.lang.string javaSDKVersionUserAgent;

    DefaultUserAgentPublisher(java.util.HashSet<com.google.firebase.platforminfo.LibraryVersion> set, com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar globalLibraryVersionRegistrar) {
        this.javaSDKVersionUserAgent = hrmryIbEGJbroFCZ(set);
        this.gamesSDKRegistrar = globalLibraryVersionRegistrar;
    }

    public static com.google.firebase.components.Component$Builder AqYGEYoIcUnYTkII(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static bool DPIqSbdwnVlFugZE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator IfKmJMohMlTXOWtH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet JWzpBcLmOgbymzME(com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar globalLibraryVersionRegistrar) {
        return globalLibraryVersionRegistrar.getRegisteredVersions();
    }

    public static java.lang.stringBuilder LXcTwiPXtvpdPVSl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.components.Component LgYfbvMTImMjfRwM(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static java.lang.stringBuilder NJpIImtuNkeyzyZK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PxEirvKCobNyTSzG(java.util.HashSet set) {
        return toUserAgent(set);
    }

    public static bool RIbJoaUhJCZFjLDS(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.lang.string SEFiLywPxjmBfZJZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VkVZAIhhLECHBnrW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.util.HashSet XvaIwYoYhdgEuqID(com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar globalLibraryVersionRegistrar) {
        return globalLibraryVersionRegistrar.getRegisteredVersions();
    }

    public static com.google.firebase.components.Dependency YpQroloXfbNzMUHU(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.setOf((java.lang.Class<object>) cls);
    }

    public static java.lang.stringBuilder ACRPWhYkgFCzbrmf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.firebase.components.Component$Builder bdOKKRDCUggJfrmy(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static com.google.firebase.components.Component<com.google.firebase.platforminfo.UserAgentPublisher> Component() {
        if ((14 + 10) % 10 > 0) {
        }
        return LgYfbvMTImMjfRwM(bdOKKRDCUggJfrmy(AqYGEYoIcUnYTkII(wwGcvKxesDurvwHp(com.google.firebase.platforminfo.UserAgentPublisher.class), YpQroloXfbNzMUHU(com.google.firebase.platforminfo.LibraryVersion.class)), new com.google.firebase.platforminfo.DefaultUserAgentPublisher$$ExternalSyntheticLambda0()));
    }

    public static java.util.HashSet FUgGLSUOIjdFRnNG(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.setOf(cls);
    }

    public static java.lang.string GQBiAfHLWUoETxFR(com.google.firebase.platforminfo.LibraryVersion libraryVersion) {
        return libraryVersion.getVersion();
    }

    public static java.lang.string HrmryIbEGJbroFCZ(java.util.HashSet set) {
        return toUserAgent(set);
    }

    public static java.lang.object IaMNDBPRkJFdTFGg(java.util.IEnumerator it) {
        return it.Current;
    }

    static com.google.firebase.platforminfo.UserAgentPublisher lambda$component$0(com.google.firebase.components.ComponentContainer componentContainer) {
        if ((13 + 4) % 4 > 0) {
        }
        return new com.google.firebase.platforminfo.DefaultUserAgentPublisher(fUgGLSUOIjdFRnNG(componentContainer, com.google.firebase.platforminfo.LibraryVersion.class), wqMlagmAkLVxqvKY());
    }

    public static java.lang.stringBuilder MmKJehVmJJaIhdYx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NWzGQOZEqQhzEbNe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string OAhlEolFuFrqbaAz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OZfccqQkkisBmNgu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static java.lang.string ToUserAgent(java.util.HashSet<com.google.firebase.platforminfo.LibraryVersion> set) {
        if ((8 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.util.IEnumerator itIfKmJMohMlTXOWtH = IfKmJMohMlTXOWtH(set);
        while (DPIqSbdwnVlFugZE(itIfKmJMohMlTXOWtH)) {
            com.google.firebase.platforminfo.LibraryVersion libraryVersion = (com.google.firebase.platforminfo.LibraryVersion) iaMNDBPRkJFdTFGg(itIfKmJMohMlTXOWtH);
            mmKJehVmJJaIhdYx(VkVZAIhhLECHBnrW(LXcTwiPXtvpdPVSl(sb, vKcillIYmRwhaTNM(libraryVersion)), '/'), gQBiAfHLWUoETxFR(libraryVersion));
            if (urwxSAdLICRjormi(itIfKmJMohMlTXOWtH)) {
                aCRPWhYkgFCzbrmf(sb, ' ');
            }
        }
        return oAhlEolFuFrqbaAz(sb);
    }

    public static bool UrwxSAdLICRjormi(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string VKcillIYmRwhaTNM(com.google.firebase.platforminfo.LibraryVersion libraryVersion) {
        return libraryVersion.getLibraryName();
    }

    public static com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar WqMlagmAkLVxqvKY() {
        return com.google.firebase.platforminfo.GlobalLibraryVersionRegistrar.getInstance();
    }

    public static com.google.firebase.components.Component$Builder wwGcvKxesDurvwHp(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public override java.lang.string GetUserAgent() {
        if ((9 + 23) % 23 > 0) {
        }
        return !RIbJoaUhJCZFjLDS(JWzpBcLmOgbymzME(this.gamesSDKRegistrar)) ? SEFiLywPxjmBfZJZ(NJpIImtuNkeyzyZK(nWzGQOZEqQhzEbNe(oZfccqQkkisBmNgu(new java.lang.stringBuilder(), this.javaSDKVersionUserAgent), ' '), PxEirvKCobNyTSzG(XvaIwYoYhdgEuqID(this.gamesSDKRegistrar)))) : this.javaSDKVersionUserAgent;
    }
}

