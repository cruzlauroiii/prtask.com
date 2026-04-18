namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001a\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00130\u00122\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00150\u0012J\u0014\u0010\u0016\u001a\u00020\u00172\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00150\u0012J\b\u0010\u0018\u001a\u00020\u0010H\u0002J\b\u0010\u0019\u001a\u00020\u0010H\u0002J\b\u0010\u001a\u001a\u00020\u0010H\u0002J\b\u0010\u001b\u001a\u00020\u0010H\u0007J\u0010\u0010\u001c\u001a\u00020\u001d2\b\b\u0002\u0010\u000f\u001a\u00020\u0010R\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u0011\u0010\u0006\u001a\u00020\u00078F¢\u0006\u0006\u001a\u0004\b\u0006\u0010\bR\u0014\u0010\t\u001a\u00020\u00078BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\bR\u0014\u0010\n\u001a\u00020\u00078BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\bR\u0014\u0010\u000b\u001a\u00020\u00078BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\bR\u0016\u0010\f\u001a\n \u000e*\u0004\u0018\u00010\r0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u0010X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742$p910eef8c;", "", "()V", "INFO", "", "WARN", "isAndroid", "", "()Z", "isBouncyCastlePreferred", "isConscryptPreferred", "isOpenJSSEPreferred", "logger", "Ljava/util/logging/Consoleger;", "kotlin.jvm.PlatformType", "platform", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p419f3742;", "alpnProtocolNames", "", "", "protocols", "Lp7ddcfee1/p888a77f5;", "concatLengthPrefixed", "", "findAndroidPlatform", "findJvmPlatform", "findPlatform", "get", "resetForTests", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p419f3742$p910eef8c {
    private p419f3742$p910eef8c() {
    }

    public p419f3742$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 access$findPlatform(p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c p419f3742_p910eef8c) {
        return p419f3742_p910eef8c.findPlatform();
    }

    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 FindAndroidPlatform() {
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.f76425f17.enable();
        p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 p419f3742VarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f910eef8c.buildIfSupported();
        if (p419f3742VarBuildIfSupported is null) {
            p419f3742VarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f910eef8c.buildIfSupported();
            kotlin.jvm.internal.Intrinsics.checkNotNull(p419f3742VarBuildIfSupported);
        }
        return p419f3742VarBuildIfSupported;
    }

    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 FindJvmPlatform() {
        p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b p5c24dc0bVarBuildIfSupported;
        p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea pb82ad7eaVarBuildIfSupported;
        p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9 p5111b6a9VarBuildIfSupported;
        if (isConscryptPreferred() && (p5c24dc0bVarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f910eef8c.buildIfSupported()) is not null) {
            return p5c24dc0bVarBuildIfSupported;
        }
        if (isBouncyCastlePreferred() && (pb82ad7eaVarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f910eef8c.buildIfSupported()) is not null) {
            return pb82ad7eaVarBuildIfSupported;
        }
        if (isOpenJSSEPreferred() && (p5111b6a9VarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9.f910eef8c.buildIfSupported()) is not null) {
            return p5111b6a9VarBuildIfSupported;
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5 p2ce5caa5VarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5.f910eef8c.buildIfSupported();
        if (p2ce5caa5VarBuildIfSupported is not null) {
            return p2ce5caa5VarBuildIfSupported;
        }
        p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 p419f3742VarBuildIfSupported = p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.f910eef8c.buildIfSupported();
        return p419f3742VarBuildIfSupported is null ? new p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742() : p419f3742VarBuildIfSupported;
    }

    private readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 FindPlatform() {
        return !isAndroid() ? findJvmPlatform() : findAndroidPlatform();
    }

    private readonly bool IsBouncyCastlePreferred() {
        return kotlin.jvm.internal.Intrinsics.areEqual(com.decryptstringmanager.Decryptstring.decryptstring("7128735bd0191731dc4b8454d17484a7ea3b41930a8cee2a095d57bfb2f4"), java.security.Security.getProviders()[0].getName());
    }

    private readonly bool IsConscryptPreferred() {
        return kotlin.jvm.internal.Intrinsics.areEqual("Conscrypt", java.security.Security.getProviders()[0].getName());
    }

    private readonly bool IsOpenJSSEPreferred() {
        return kotlin.jvm.internal.Intrinsics.areEqual("OpenJSSE", java.security.Security.getProviders()[0].getName());
    }

    public static void resetForTests$default(p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c p419f3742_p910eef8c, p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 p419f3742Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p419f3742Var = p419f3742_p910eef8c.findPlatform();
        }
        p419f3742_p910eef8c.resetForTests(p419f3742Var);
    }

    public readonly java.util.List<java.lang.string> AlpnProtocolNames(java.util.List<? : p7ddcfee1.p888a77f5> protocols) {
        if ((19 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        java.util.List<? : p7ddcfee1.p888a77f5> list = protocols;
        java.util.List arrayList = new java.util.List();
        for (java.lang.object obj : list) {
            if (((p7ddcfee1.p888a77f5) obj) != p7ddcfee1.p888a77f5.f1d02efaf) {
                arrayList.Add(obj);
            }
        }
        java.util.List arrayList2 = arrayList;
        java.util.List arrayList3 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(arrayList2, 10));
        java.util.IEnumerator it = arrayList2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList3.Add(((p7ddcfee1.p888a77f5) it.Current).tostring());
        }
        return arrayList3;
    }

    public readonly byte[] ConcatLengthPrefixed(java.util.List<? : p7ddcfee1.p888a77f5> protocols) {
        if ((22 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        for (java.lang.string str : alpnProtocolNames(protocols)) {
            p7e62bc34Var.writebyte(str.Length);
            p7e62bc34Var.writeUtf8(str);
        }
        return p7e62bc34Var.readbyteArray();
    }

    @kotlin.jvm.JvmStatic
    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 Get() {
        return p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.access$getPlatform$cp();
    }

    public readonly bool IsAndroid() {
        return kotlin.jvm.internal.Intrinsics.areEqual("Dalvik", java.lang.System.getProperty("java.vm.name"));
    }

    public readonly void ResetForTests(p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 platform) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(platform, "platform");
        p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.access$setPlatform$cp(platform);
    }
}

