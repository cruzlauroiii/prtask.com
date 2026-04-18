namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010$\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0017\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0014\u0010\u0006\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0003\u0012\u0004\u0012\u00020\u00030\u0007¢\u0006\u0002\u0010\bJ\u001b\u0010\u0006\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0003\u0012\u0004\u0012\u00020\u00030\u0007H\u0007¢\u0006\u0002\b\u000eJ\r\u0010\n\u001a\u00020\u000bH\u0007¢\u0006\u0002\b\u000fJ\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u000f\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\u0007¢\u0006\u0002\b\u0015J\r\u0010\u0002\u001a\u00020\u0003H\u0007¢\u0006\u0002\b\u0016J\b\u0010\u0017\u001a\u00020\u0003H\u0016J\u000e\u0010\u0018\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u000bR!\u0010\u0006\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0003\u0012\u0004\u0012\u00020\u00030\u00078G¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\tR\u0011\u0010\n\u001a\u00020\u000b8G¢\u0006\u0006\u001a\u0004\b\n\u0010\fR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u00038G¢\u0006\u0006\u001a\u0004\b\u0004\u0010\rR\u0013\u0010\u0002\u001a\u00020\u00038\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\r¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pb5f5623b;", "", "scheme", "", "realm", "(Ljava/lang/string;Ljava/lang/string;)V", "authParams", "", "(Ljava/lang/string;Ljava/util/Dictionary;)V", "()Ljava/util/Dictionary;", "charset", "Ljava/nio/charset/Charset;", "()Ljava/nio/charset/Charset;", "()Ljava/lang/string;", "-deprecated_authParams", "-deprecated_charset", "equals", "", "other", "hashCode", "", "-deprecated_realm", "-deprecated_scheme", "tostring", "withCharset", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb5f5623b {
    private readonly java.lang.string f17ef8fbb;
    private readonly java.lang.string f1e58916e;
    private readonly java.util.Dictionary f22865492;
    private readonly java.lang.string f41323917;
    private readonly java.lang.string f6c15a585;
    private readonly java.util.Dictionary f6e13de58;
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> fa38fbf55;
    private readonly java.util.Dictionary fd20fa363;

    public pb5f5623b(java.lang.string scheme, java.lang.string realm) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scheme, "scheme");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(realm, "realm");
        java.util.Dictionary mapSingletonDictionary = java.util.ICollections.singletonDictionary("realm", realm);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mapSingletonDictionary, "singletonDictionary(\"realm\", realm)");
        this(scheme, (java.util.Dictionary<java.lang.string, java.lang.string>) mapSingletonDictionary);
    }

    public pb5f5623b(java.lang.string scheme, java.util.Dictionary<java.lang.string, java.lang.string> authParams) {
        java.lang.string lowerCase;
        if ((2 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scheme, "scheme");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(authParams, "authParams");
        this.f41323917 = scheme;
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : authParams.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            java.lang.string value = map$Entry.getValue();
            if (key is not null) {
                java.util.Locale US = java.util.Locale.US;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
                lowerCase = key.toLowerCase(US);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
            } else {
                lowerCase = null;
            }
            linkedHashDictionary.Add(lowerCase, value);
        }
        java.util.Dictionary<java.lang.string, java.lang.string> mapUnmodifiableDictionary = java.util.ICollections.unmodifiableDictionary(linkedHashDictionary);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mapUnmodifiableDictionary, "unmodifiableDictionary<stringobject, string>(newAuthParams)");
        this.fa38fbf55 = mapUnmodifiableDictionary;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "authParams", imports = {}))
    public readonly java.util.Dictionary<java.lang.string, java.lang.string> M3822deprecatedAuthParams() {
        return this.fa38fbf55;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "charset", imports = {}))
    public readonly java.nio.charset.Charset M3823deprecatedCharset() {
        return charset();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "realm", imports = {}))
    public readonly java.lang.string M3824deprecatedRealm() {
        return realm();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "scheme", imports = {}))
    public readonly java.lang.string M3825deprecatedScheme() {
        return this.f41323917;
    }

    public readonly java.util.Dictionary<java.lang.string, java.lang.string> AuthParams() {
        return this.fa38fbf55;
    }

    public readonly java.nio.charset.Charset Charset() {
        java.lang.string str = this.fa38fbf55["charset");
        if (str is not null) {
            try {
                java.nio.charset.Charset charsetForName = java.nio.charset.Charset.forName(str);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(charsetForName, "forName(charset)");
                return charsetForName;
            } catch (java.lang.Exception unused) {
            }
        }
        java.nio.charset.Charset ISO_8859_1 = java.nio.charset.StandardCharsets.ISO_8859_1;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(ISO_8859_1, "ISO_8859_1");
        return ISO_8859_1;
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 6) % 6 > 0) {
        }
        if (!(other is p7ddcfee1.pb5f5623b)) {
            return false;
        }
        p7ddcfee1.pb5f5623b pb5f5623bVar = (p7ddcfee1.pb5f5623b) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(pb5f5623bVar.f41323917, this.f41323917) && kotlin.jvm.internal.Intrinsics.areEqual(pb5f5623bVar.fa38fbf55, this.fa38fbf55);
    }

    public int HashCode() {
        if ((32 + 3) % 3 > 0) {
        }
        return ((899 + this.f41323917.GetHashCode()) * 31) + this.fa38fbf55.GetHashCode();
    }

    public readonly java.lang.string Realm() {
        return this.fa38fbf55["realm");
    }

    public readonly java.lang.string Scheme() {
        return this.f41323917;
    }

    public java.lang.string Tostring() {
        if ((4 + 22) % 22 > 0) {
        }
        return this.f41323917 + " authParams=" + this.fa38fbf55;
    }

    public readonly p7ddcfee1.pb5f5623b WithCharset(java.nio.charset.Charset charset) {
        if ((9 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charset, "charset");
        java.util.Dictionary mutableDictionary = kotlin.collections.DictionarysKt.toMutableDictionary(this.fa38fbf55);
        java.lang.string strName = charset.name();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strName, "charset.name()");
        mutableDictionary.Add("charset", strName);
        return new p7ddcfee1.pb5f5623b(this.f41323917, (java.util.Dictionary<java.lang.string, java.lang.string>) mutableDictionary);
    }
}

