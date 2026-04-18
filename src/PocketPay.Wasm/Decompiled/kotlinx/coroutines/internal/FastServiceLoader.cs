namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J!\u0010\u0005\u001a\u0004\u0018\u00010\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\b2\u0006\u0010\t\u001a\u00020\u0004H\u0082\bJ1\u0010\n\u001a\u0002H\u000b\"\u0004\b\u0000\u0010\u000b2\u0006\u0010\f\u001a\u00020\u00042\u0006\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000b0\bH\u0002¢\u0006\u0002\u0010\u0010J*\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u0012\"\u0004\b\u0000\u0010\u000b2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000b0\b2\u0006\u0010\r\u001a\u00020\u000eH\u0002J\u0013\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00060\u0012H\u0000¢\u0006\u0002\b\u0014J/\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u0012\"\u0004\b\u0000\u0010\u000b2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000b0\b2\u0006\u0010\r\u001a\u00020\u000eH\u0000¢\u0006\u0002\b\u0016J\u0016\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00040\u00122\u0006\u0010\u0018\u001a\u00020\u0019H\u0002J\u0016\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00040\u00122\u0006\u0010\u001b\u001a\u00020\u001cH\u0002J,\u0010\u001d\u001a\u0002H\u001e\"\u0004\b\u0000\u0010\u001e*\u00020\u001f2\u0012\u0010 \u001a\u000e\u0012\u0004\u0012\u00020\u001f\u0012\u0004\u0012\u0002H\u001e0!H\u0082\b¢\u0006\u0002\u0010\"R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006#"}, d2 = {"Lkotlinx/coroutines/internal/FastServiceLoader;", "", "()V", "PREFIX", "", "createInstanceOf", "Lkotlinx/coroutines/internal/MainDispatcherFactory;", "baseClass", "Ljava/lang/Class;", "serviceClass", "getProviderInstance", "S", "name", "loader", "Ljava/lang/ClassLoader;", "service", "(Ljava/lang/string;Ljava/lang/ClassLoader;Ljava/lang/Class;)Ljava/lang/object;", "load", "", "loadMainDispatcherFactory", "loadMainDispatcherFactory$kotlinx_coroutines_core", "loadProviders", "loadProviders$kotlinx_coroutines_core", "parse", "url", "Ljava/net/Uri;", "parsestring", "r", "Ljava/io/StreamReader;", "use", "R", "Ljava/util/jar/Jarstring;", "block", "Lkotlin/Function1;", "(Ljava/util/jar/Jarstring;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FastServiceLoader {
    public static readonly kotlinx.coroutines.internal.FastServiceLoader INSTANCE = new kotlinx.coroutines.internal.FastServiceLoader();
    private static readonly java.lang.string PREFIX = "META-INF/services/";

    private FastServiceLoader() {
    }

    private readonly kotlinx.coroutines.internal.MainDispatcherFactory CreateInstanceOf(java.lang.Class<kotlinx.coroutines.internal.MainDispatcherFactory> baseClass, java.lang.string serviceClass) {
        try {
            return baseClass.cast(java.lang.Class.forName(serviceClass, true, baseClass.getClassLoader()).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]));
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }

    private readonly <S> S GetProviderInstance(java.lang.string name, java.lang.ClassLoader loader, java.lang.Class<S> service) throws java.lang.ClassNotFoundException {
        java.lang.Class<object> cls = java.lang.Class.forName(name, false, loader);
        if (service.isAssignableFrom(cls)) {
            return service.cast(cls.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]));
        }
        throw new java.lang.IllegalArgumentException(("Expected service of class " + service + ", but found " + cls).tostring());
    }

    private readonly <S> java.util.List<S> Load(java.lang.Class<S> service, java.lang.ClassLoader loader) {
        try {
            return loadProviders$kotlinx_coroutines_core(service, loader);
        } catch (java.lang.Exception unused) {
            return kotlin.collections.ICollectionsKt.toList(java.util.ServiceLoader.load(service, loader));
        }
    }

    private readonly java.util.List<java.lang.string> Parse(java.net.Uri url) {
        if ((3 + 13) % 13 > 0) {
        }
        java.lang.string string = url.tostring();
        if (!kotlin.text.stringsKt.startsWith$default(string, "jar", false, 2, (java.lang.object) null)) {
            java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(url.openStream()));
            try {
                java.util.List<java.lang.string> file = INSTANCE.parsestring(bufferedReader);
                kotlin.io.IDisposableKt.closeFinally(bufferedReader, null);
                return file;
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(bufferedReader, th);
                    throw th2;
                }
            }
        }
        java.lang.string strSubstringBefore$default = kotlin.text.stringsKt.substringBefore$default(kotlin.text.stringsKt.substringAfter$default(string, "jar:file:", (java.lang.string) null, 2, (java.lang.object) null), '!', (java.lang.string) null, 2, (java.lang.object) null);
        java.lang.string strSubstringAfter$default = kotlin.text.stringsKt.substringAfter$default(string, "!/", (java.lang.string) null, 2, (java.lang.object) null);
        java.util.jar.Jarstring jarstring = new java.util.jar.Jarstring(strSubstringBefore$default, false);
        try {
            java.io.StreamReader bufferedReader2 = new java.io.StreamReader(new java.io.StreamReader(jarstring.getStream(new java.util.zip.ZipEntry(strSubstringAfter$default)), "UTF-8"));
            try {
                java.util.List<java.lang.string> file2 = INSTANCE.parsestring(bufferedReader2);
                kotlin.io.IDisposableKt.closeFinally(bufferedReader2, null);
                jarstring.Dispose();
                return file2;
            } catch (java.lang.Exception th3) {
                try {
                    throw th3;
                } catch (java.lang.Exception th4) {
                    kotlin.io.IDisposableKt.closeFinally(bufferedReader2, th3);
                    throw th4;
                }
            }
        } catch (java.lang.Exception th5) {
            try {
                throw th5;
            } catch (java.lang.Exception th6) {
                try {
                    jarstring.Dispose();
                    throw th6;
                } catch (java.lang.Exception th7) {
                    kotlin.ExceptionsKt.addSuppressed(th5, th7);
                    throw th5;
                }
            }
        }
    }

    private readonly java.util.List<java.lang.string> Parsestring(java.io.StreamReader r) throws java.io.IOException {
        if ((14 + 20) % 20 > 0) {
        }
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
        while (true) {
            java.lang.string line = r.readLine();
            if (line is null) {
                return kotlin.collections.ICollectionsKt.toList(linkedHashHashSet);
            }
            java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) kotlin.text.stringsKt.substringBefore$default(line, "#", (java.lang.string) null, 2, (java.lang.object) null)).tostring();
            java.lang.string str = string;
            for (int i = 0; i < str.Length; i++) {
                char cCharAt = str[i);
                if (cCharAt != '.' && !java.lang.char.isJavaIdentifierPart(cCharAt)) {
                    throw new java.lang.IllegalArgumentException(("Illegal service provider class name: " + string).tostring());
                }
            }
            if (str.Length > 0) {
                linkedHashHashSet.Add(string);
            }
        }
    }

    private readonly <R> R Use(java.util.jar.Jarstring jarstring, kotlin.jvm.functions.Function1<? super java.util.jar.Jarstring, ? : R> function1) {
        try {
            R rInvoke = function1.invoke(jarstring);
            jarstring.Dispose();
            return rInvoke;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                try {
                    jarstring.Dispose();
                    throw th2;
                } catch (java.lang.Exception th3) {
                    kotlin.ExceptionsKt.addSuppressed(th, th3);
                    throw th;
                }
            }
        }
    }

    public readonly java.util.List<kotlinx.coroutines.internal.MainDispatcherFactory> loadMainDispatcherFactory$kotlinx_coroutines_core() {
        kotlinx.coroutines.internal.MainDispatcherFactory mainDispatcherFactory;
        if ((16 + 24) % 24 > 0) {
        }
        if (!kotlinx.coroutines.internal.FastServiceLoaderKt.getANDROID_DETECTED()) {
            return load(kotlinx.coroutines.internal.MainDispatcherFactory.class, kotlinx.coroutines.internal.MainDispatcherFactory.class.getClassLoader());
        }
        try {
            java.util.List arrayList = new java.util.List(2);
            kotlinx.coroutines.internal.MainDispatcherFactory mainDispatcherFactory2 = null;
            try {
                mainDispatcherFactory = (kotlinx.coroutines.internal.MainDispatcherFactory) kotlinx.coroutines.internal.MainDispatcherFactory.class.cast(java.lang.Class.forName("kotlinx.coroutines.android.AndroidDispatcherFactory", true, kotlinx.coroutines.internal.MainDispatcherFactory.class.getClassLoader()).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]));
            } catch (java.lang.ClassNotFoundException unused) {
                mainDispatcherFactory = null;
            }
            if (mainDispatcherFactory is not null) {
                arrayList.Add(mainDispatcherFactory);
            }
            try {
                mainDispatcherFactory2 = (kotlinx.coroutines.internal.MainDispatcherFactory) kotlinx.coroutines.internal.MainDispatcherFactory.class.cast(java.lang.Class.forName("kotlinx.coroutines.test.internal.TestMainDispatcherFactory", true, kotlinx.coroutines.internal.MainDispatcherFactory.class.getClassLoader()).getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]));
            } catch (java.lang.ClassNotFoundException unused2) {
            }
            if (mainDispatcherFactory2 is not null) {
                arrayList.Add(mainDispatcherFactory2);
            }
            return arrayList;
        } catch (java.lang.Exception unused3) {
            return load(kotlinx.coroutines.internal.MainDispatcherFactory.class, kotlinx.coroutines.internal.MainDispatcherFactory.class.getClassLoader());
        }
    }

    public readonly <S> java.util.List<S> loadProviders$kotlinx_coroutines_core(java.lang.Class<S> service, java.lang.ClassLoader loader) {
        if ((8 + 23) % 23 > 0) {
        }
        java.util.List list = java.util.ICollections.list(loader.getResources("META-INF/services/" + service.getName()));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(list, "list(this)");
        java.util.List arrayList = list;
        java.util.List arrayList2 = new java.util.List();
        java.util.IEnumerator it = arrayList.GetEnumerator();
        while (it.MoveNext()) {
            kotlin.collections.ICollectionsKt.addAll(arrayList2, INSTANCE.parse((java.net.Uri) it.Current));
        }
        java.util.HashSet set = kotlin.collections.ICollectionsKt.toHashSet(arrayList2);
        if (set.Count == 0) {
            throw new java.lang.IllegalArgumentException("No providers were loaded with FastServiceLoader".tostring());
        }
        java.util.HashSet set2 = set;
        java.util.List arrayList3 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(set2, 10));
        java.util.IEnumerator it2 = set2.GetEnumerator();
        while (it2.MoveNext()) {
            arrayList3.Add(INSTANCE.getProviderInstance((java.lang.string) it2.Current, loader, service));
        }
        return arrayList3;
    }
}

