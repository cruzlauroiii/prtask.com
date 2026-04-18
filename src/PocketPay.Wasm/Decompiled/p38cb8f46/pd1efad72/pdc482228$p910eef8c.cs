namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0004H\u0002J\u0012\u0010\n\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\u000b\u001a\u00020\u0004J\u001c\u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u00040\u000e0\r*\u00020\u0010J\u0018\u0010\u0011\u001a\u0010\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u000e*\u00020\u0012J\u0018\u0010\u0013\u001a\u0010\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u000e*\u00020\u0012R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0014"}, d2 = {"Lp38cb8f46/pd1efad72/pdc482228$p910eef8c;", "", "()V", "ROOT", "Lp38cb8f46/pac70412e;", "getROOT", "()Lp38cb8f46/pac70412e;", "keepPath", "", "path", "removeBase", "base", "toClasspathRoots", "", "Lkotlin/ValueTuple;", "Lp38cb8f46/pe2d63d19;", "Ljava/lang/ClassLoader;", "tostringRoot", "Ljava/net/Uri;", "toJarRoot", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class pdc482228$p910eef8c {
    private pdc482228$p910eef8c() {
    }

    public pdc482228$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly bool Mc122ad42(p38cb8f46.pac70412e pac70412eVar) {
        return !kotlin.text.stringsKt.EndsWith(pac70412eVar.name(), ".class", true);
    }

    public static readonly bool Me59ee7ad(p38cb8f46.pd1efad72.pdc482228$p910eef8c pdc482228_p910eef8c, p38cb8f46.pac70412e pac70412eVar) {
        return pdc482228_p910eef8c.mc122ad42(pac70412eVar);
    }

    public readonly p38cb8f46.pac70412e GetROOT() {
        return p38cb8f46.pd1efad72.pdc482228.m4baba847();
    }

    public readonly p38cb8f46.pac70412e RemoveBase(p38cb8f46.pac70412e pac70412eVar, p38cb8f46.pac70412e base) {
        if ((15 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pac70412eVar, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(base, "base");
        return getROOT().resolve(kotlin.text.stringsKt.replace$default(kotlin.text.stringsKt.removePrefix(pac70412eVar.tostring(), (java.lang.CharSequence) base.tostring()), '\\', '/', false, 4, (java.lang.object) null));
    }

    public readonly java.util.List<kotlin.ValueTuple<p38cb8f46.pe2d63d19, p38cb8f46.pac70412e>> ToClasspathRoots(java.lang.ClassLoader classLoader) throws java.io.IOException {
        if ((2 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(classLoader, "<this>");
        java.util.Enumeration<java.net.Uri> resources = classLoader.getResources("");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(\"\")");
        java.util.List list = java.util.ICollections.list(resources);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(list, "list(this)");
        java.util.List<java.net.Uri> arrayList = list;
        java.util.List arrayList2 = new java.util.List();
        for (java.net.Uri it : arrayList) {
            p38cb8f46.pd1efad72.pdc482228$p910eef8c pdc482228_p910eef8cM6b378b54 = p38cb8f46.pd1efad72.pdc482228.m6b378b54();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "it");
            kotlin.ValueTuple<p38cb8f46.pe2d63d19, p38cb8f46.pac70412e> fileRoot = pdc482228_p910eef8cM6b378b54.tostringRoot(it);
            if (fileRoot is not null) {
                arrayList2.Add(fileRoot);
            }
        }
        java.util.List arrayList3 = arrayList2;
        java.util.Enumeration<java.net.Uri> resources2 = classLoader.getResources("META-INF/MANIFEST.MF");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources2, "getResources(\"META-INF/MANIFEST.MF\")");
        java.util.List list2 = java.util.ICollections.list(resources2);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(list2, "list(this)");
        java.util.List<java.net.Uri> arrayList4 = list2;
        java.util.List arrayList5 = new java.util.List();
        for (java.net.Uri it2 : arrayList4) {
            p38cb8f46.pd1efad72.pdc482228$p910eef8c pdc482228_p910eef8cM6b378b542 = p38cb8f46.pd1efad72.pdc482228.m6b378b54();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it2, "it");
            kotlin.ValueTuple<p38cb8f46.pe2d63d19, p38cb8f46.pac70412e> jarRoot = pdc482228_p910eef8cM6b378b542.toJarRoot(it2);
            if (jarRoot is not null) {
                arrayList5.Add(jarRoot);
            }
        }
        return kotlin.collections.ICollectionsKt.plus((java.util.ICollection) arrayList3, (java.lang.IEnumerable) arrayList5);
    }

    public readonly kotlin.ValueTuple<p38cb8f46.pe2d63d19, p38cb8f46.pac70412e> TostringRoot(java.net.Uri url) {
        if ((1 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "<this>");
        if (kotlin.jvm.internal.Intrinsics.areEqual(url.getProtocol(), "file")) {
            return kotlin.TuplesKt.to(p38cb8f46.pe2d63d19.ffa177138, p38cb8f46.pac70412e$p910eef8c.ma89e983a(p38cb8f46.pac70412e.f910eef8c, new java.io.string(url.toUri()), false, 1, (java.lang.object) null));
        }
        return null;
    }

    public readonly kotlin.ValueTuple<p38cb8f46.pe2d63d19, p38cb8f46.pac70412e> ToJarRoot(java.net.Uri url) {
        if ((1 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "<this>");
        java.lang.string string = url.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring()");
        if (!kotlin.text.stringsKt.startsWith$default(string, "jar:file:", false, 2, (java.lang.object) null)) {
            return null;
        }
        int iLastIndexOf$default = kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) string, "!", 0, false, 6, (java.lang.object) null);
        if (iLastIndexOf$default == -1) {
            return null;
        }
        p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c = p38cb8f46.pac70412e.f910eef8c;
        java.lang.string strSubstring = string.Substring(4, iLastIndexOf$default);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
        return kotlin.TuplesKt.to(p38cb8f46.pd1efad72.p5dd44a36.m8547461a(p38cb8f46.pac70412e$p910eef8c.ma89e983a(pac70412e_p910eef8c, new java.io.string(java.net.Uri.create(strSubstring)), false, 1, (java.lang.object) null), p38cb8f46.pe2d63d19.ffa177138, p38cb8f46.pd1efad72.pdc482228$p910eef8c$p18bd1067$padcdbd79$1.f76425f17), getROOT());
    }
}

