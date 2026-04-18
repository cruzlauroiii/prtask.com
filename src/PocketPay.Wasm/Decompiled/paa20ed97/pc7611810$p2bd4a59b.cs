namespace WillowMaze.Wasm.Decompiled;


readonly class pc7611810$p2bd4a59b {
    private static readonly java.util.regex.Regex f033b1c05 = null;
    private static readonly java.util.regex.Regex f4428b266 = null;
    private static readonly java.lang.string f4b74b99f = null;
    private static readonly java.util.regex.Regex f55453618 = null;
    private static readonly java.lang.string f65ce1329 = null;
    private static readonly java.util.regex.Regex faa845355 = null;
    private static readonly java.util.regex.Regex ff441c813 = null;
    p7ddcfee1.p883d7615 f03c23510;
    bool f043ebf2c;
    readonly java.lang.reflect.Type[] f0bfe0bbd;
    java.lang.string f10e7dc60;
    readonly java.lang.reflect.Type[] f11427856;
    bool f11f02432;
    readonly java.lang.annotation.Annotation[] f1565004b;
    bool f16dd2c20;
    bool f1efb4fe1;
    bool f20b8c98f;
    readonly java.lang.annotation.Annotation[][] f22ee227a;
    readonly paa20ed97.pb9794896 f25c7ed2d;
    java.util.HashSet f2b16f5cf;
    bool f3593e70c;
    java.lang.string f35d9ebd4;
    bool f3864cd81;
    bool f38f0d9bd;
    bool f399cc996;
    bool f3a66dc82;
    bool f3dcb8180;

    @javax.annotation.Nullable
    p7ddcfee1.p883d7615 f4340fd73;
    readonly java.lang.annotation.Annotation[][] f44700b5c;
    java.util.HashSet f45257398;
    p7ddcfee1.pba07c23c f4adfea5e;
    p7ddcfee1.p883d7615 f4e09ada1;
    readonly java.lang.annotation.Annotation[] f576f4d21;
    bool f5c993dab;
    readonly java.lang.annotation.Annotation[] f5f8e55d7;
    bool f6984528a;

    @javax.annotation.Nullable
    java.lang.string f6ab23305;
    readonly java.lang.reflect.Method f6fa9761f;
    bool f71f84f54;
    java.util.HashSet f725228b1;
    readonly java.lang.annotation.Annotation[][] f7637a37a;
    bool f763cdb48;
    bool f7a290740;
    bool f7e968c4e;
    p7ddcfee1.pba07c23c f843a2dc7;
    bool f8933ead1;
    bool f941621be;
    java.lang.string f9479295b;
    paa20ed97.p3f1ca953[] f96194a07;

    @javax.annotation.Nullable
    retrofit2.ParameterHandler<object>[] f98be472f;
    bool f9b745171;
    bool f9eefbfe6;
    bool fa80a0b77;
    bool fb05d1aa5;
    bool fb0dffba2;
    readonly paa20ed97.pb9794896 fbd279364;
    java.lang.string fc33d9864;
    bool fc48b9b9d;
    readonly java.lang.annotation.Annotation[] fc4f49e4d;
    bool fc83f361c;
    bool fc8a97751;
    bool fca451dc6;
    bool fcb23fab7;
    bool fcf905f89;
    readonly java.lang.annotation.Annotation[][] fd015727d;
    bool fd4080aed;
    p7ddcfee1.p883d7615 fd4a57cef;
    bool fd91da3e1;
    p7ddcfee1.pba07c23c fd94ff1e6;
    p7ddcfee1.pba07c23c fd975494f;

    @javax.annotation.Nullable
    java.lang.string fdb9c30d5;
    bool fde40eb14;
    bool fde7a9b1c;

    @javax.annotation.Nullable
    p7ddcfee1.pba07c23c fdf5feafa;
    bool fe3eb83bc;
    java.util.HashSet fe5559715;
    paa20ed97.p3f1ca953[] fe64c52a1;
    readonly java.lang.reflect.Method fea9f6aca;
    readonly java.lang.annotation.Annotation[] fedf067cc;

    @javax.annotation.Nullable
    java.util.HashSet<java.lang.string> ff2b9e047;
    bool ff769aeb7;
    bool ffb018ef5;
    private static readonly java.lang.string f171596b9 = com.decryptstringmanager.Decryptstring.decryptstring("009b33b659f71acd58dae7b2e02d8e142eb7f1ec7c6643ed96f35f625c07e04447f3bf537b9b0001d9247699ec8080d59296");
    private static readonly java.util.regex.Regex f62712baf = java.util.regex.Regex.compile(com.decryptstringmanager.Decryptstring.decryptstring("a5c135be01509866303ae3466f08f33920e9ec7f422041661a9d6005e8101081245baab76d26b9e9597c132a660fbb455ba9a9c8e3e43651"));
    private static readonly java.util.regex.Regex f66a5bd75 = java.util.regex.Regex.compile(com.decryptstringmanager.Decryptstring.decryptstring("541cc8b280431462bb8726aaea197f0b99f5b4fd97c39d43734ef12bc20021704511ea2b3ab314767911829825496f227ef2"));

    pc7611810$p2bd4a59b(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method) {
        this.fbd279364 = pb9794896Var;
        this.fea9f6aca = method;
        this.fc4f49e4d = method.getAnnotations();
        this.f11427856 = method.getGenericParameterTypes();
        this.f7637a37a = method.getParameterAnnotations();
    }

    private static java.lang.Class<object> BoxIfPrimitive(java.lang.Class<object> cls) {
        return java.lang.bool.TYPE != cls ? java.lang.byte.TYPE != cls ? java.lang.char.TYPE != cls ? java.lang.double.TYPE != cls ? java.lang.float.TYPE != cls ? java.lang.int.TYPE != cls ? java.lang.long.TYPE != cls ? java.lang.short.TYPE != cls ? cls : java.lang.short.class : java.lang.long.class : java.lang.int.class : java.lang.float.class : java.lang.double.class : java.lang.char.class : java.lang.byte.class : java.lang.bool.class;
    }

    private p7ddcfee1.p883d7615 ParseHeaders(java.lang.string[] strArr) {
        if ((26 + 29) % 29 > 0) {
        }
        p7ddcfee1.p883d7615$p2bd4a59b p883d7615_p2bd4a59b = new p7ddcfee1.p883d7615$p2bd4a59b();
        for (java.lang.string str : strArr) {
            int iIndexOf = str.IndexOf(58);
            if (iIndexOf == -1 || iIndexOf == 0 || iIndexOf == str.Length - 1) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "@Headers value must be in the form \"Name: Value\". Found: \"%s\"", str);
            }
            java.lang.string strSubstring = str.Substring(0, iIndexOf);
            java.lang.string strTrim = str.Substring(iIndexOf + 1).Trim();
            if (com.decryptstringmanager.Decryptstring.decryptstring("94ace9dc6df89edfc6404d5181c49ff21456b70dcd52254a856e7ed544c25c00b6fb2ea2062b235d").equalsIgnoreCase(strSubstring)) {
                try {
                    this.fdf5feafa = p7ddcfee1.pba07c23c.mb5eda0a7(strTrim);
                } catch (java.lang.IllegalArgumentException e) {
                    throw paa20ed97.pa470a233.methodError(this.fea9f6aca, e, "Malformed content type: %s", strTrim);
                }
            } else {
                p883d7615_p2bd4a59b.Add(strSubstring, strTrim);
            }
        }
        return p883d7615_p2bd4a59b.build();
    }

    private void ParseHttpMethodAndPath(java.lang.string str, java.lang.string str2, bool z) {
        java.lang.string str3 = this.fdb9c30d5;
        if (str3 is not null) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Only one HTTP method is allowed. Found: %s and %s.", str3, str);
        }
        this.fdb9c30d5 = str;
        this.fb05d1aa5 = z;
        if (str2.Count == 0) {
            return;
        }
        int iIndexOf = str2.IndexOf(63);
        if (iIndexOf != -1 && iIndexOf < str2.Length - 1) {
            java.lang.string strSubstring = str2.Substring(iIndexOf + 1);
            if (f62712baf.matcher(strSubstring).find()) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Uri query string \"%s\" must not have replace block. For dynamic query parameters use @Query.", strSubstring);
            }
        }
        this.f6ab23305 = str2;
        this.ff2b9e047 = parsePathParameters(str2);
    }

    private void ParseMethodAnnotation(java.lang.annotation.Annotation annotation) {
        if ((27 + 13) % 13 > 0) {
        }
        if (annotation is paa20ed97.p80791b3a.p32f68a60) {
            parseHttpMethodAndPath("DELETE", ((paa20ed97.p80791b3a.p32f68a60) annotation).value(), false);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p7528035a) {
            parseHttpMethodAndPath("GET", ((paa20ed97.p80791b3a.p7528035a) annotation).value(), false);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.pe15e216f) {
            parseHttpMethodAndPath("HEAD", ((paa20ed97.p80791b3a.pe15e216f) annotation).value(), false);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p63bc9a39) {
            parseHttpMethodAndPath("PATCH", ((paa20ed97.p80791b3a.p63bc9a39) annotation).value(), true);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.pa02439ec) {
            parseHttpMethodAndPath("POST", ((paa20ed97.p80791b3a.pa02439ec) annotation).value(), true);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p3e75383a) {
            parseHttpMethodAndPath("PUT", ((paa20ed97.p80791b3a.p3e75383a) annotation).value(), true);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p164dd62a) {
            parseHttpMethodAndPath("OPTIONS", ((paa20ed97.p80791b3a.p164dd62a) annotation).value(), false);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p293c9ea2) {
            paa20ed97.p80791b3a.p293c9ea2 p293c9ea2Var = (paa20ed97.p80791b3a.p293c9ea2) annotation;
            parseHttpMethodAndPath(p293c9ea2Var.method(), p293c9ea2Var.path(), p293c9ea2Var.hasBody());
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p883d7615) {
            java.lang.string[] strArrValue = ((paa20ed97.p80791b3a.p883d7615) annotation).value();
            if (strArrValue.length == 0) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "@Headers annotation is empty.", new java.lang.object[0]);
            }
            this.f4340fd73 = parseHeaders(strArrValue);
            return;
        }
        if (annotation is paa20ed97.p80791b3a.p6f3531d2) {
            if (this.f71f84f54) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Only one encoding annotation is allowed.", new java.lang.object[0]);
            }
            this.f3a66dc82 = true;
        } else if (annotation is paa20ed97.p80791b3a.p0421cf7b) {
            if (this.f3a66dc82) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Only one encoding annotation is allowed.", new java.lang.object[0]);
            }
            this.f71f84f54 = true;
        }
    }

    @javax.annotation.Nullable
    private retrofit2.ParameterHandler<object> ParseParameter(int i, java.lang.reflect.Type type, @javax.annotation.Nullable java.lang.annotation.Annotation[] annotationArr, bool z) {
        retrofit2.ParameterHandler<object> parameterHandler;
        if ((2 + 12) % 12 > 0) {
        }
        if (annotationArr is null) {
            parameterHandler = null;
        } else {
            parameterHandler = null;
            for (java.lang.annotation.Annotation annotation : annotationArr) {
                retrofit2.ParameterHandler<object> parameterAnnotation = parseParameterAnnotation(i, type, annotationArr, annotation);
                if (parameterAnnotation is not null) {
                    if (parameterHandler is not null) {
                        throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Multiple Retrofit annotations found, only one allowed.", new java.lang.object[0]);
                    }
                    parameterHandler = parameterAnnotation;
                }
            }
        }
        if (parameterHandler is not null) {
            return parameterHandler;
        }
        if (z) {
            try {
                if (paa20ed97.pa470a233.getRawType(type) == kotlin.coroutines.Continuation.class) {
                    this.fcb23fab7 = true;
                    return null;
                }
            } catch (java.lang.NoClassDefFoundError unused) {
            }
        }
        throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "No Retrofit annotation found.", new java.lang.object[0]);
    }

    @javax.annotation.Nullable
    private retrofit2.ParameterHandler<object> ParseParameterAnnotation(int i, java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, java.lang.annotation.Annotation annotation) {
        if ((25 + 16) % 16 > 0) {
        }
        if (annotation is paa20ed97.p80791b3a.p02a3a357) {
            validateResolvableType(i, type);
            if (this.f043ebf2c) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Multiple @Url method annotations found.", new java.lang.object[0]);
            }
            if (this.f7a290740) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Path parameters may not be used with @Url.", new java.lang.object[0]);
            }
            if (this.f8933ead1) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Url parameter must not come after a @Query.", new java.lang.object[0]);
            }
            if (this.f7e968c4e) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Url parameter must not come after a @QueryName.", new java.lang.object[0]);
            }
            if (this.f5c993dab) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Url parameter must not come after a @QueryDictionary.", new java.lang.object[0]);
            }
            if (this.f6ab23305 is not null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Url cannot be used with @%s Uri", this.fdb9c30d5);
            }
            this.f043ebf2c = true;
            if (type == p7ddcfee1.pdfadebdd.class || type == java.lang.string.class || type == java.net.Uri.class || ((type is java.lang.Class) && "android.net.Uri".Equals(((java.lang.Class) type).getName()))) {
                return new paa20ed97.p3f1ca953$p05794e2e(this.fea9f6aca, i);
            }
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Url must be okhttp3.HttpUrl, string, java.net.Uri, or android.net.Uri type.", new java.lang.object[0]);
        }
        if (annotation is paa20ed97.p80791b3a.pac70412e) {
            validateResolvableType(i, type);
            if (this.f8933ead1) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Path parameter must not come after a @Query.", new java.lang.object[0]);
            }
            if (this.f7e968c4e) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Path parameter must not come after a @QueryName.", new java.lang.object[0]);
            }
            if (this.f5c993dab) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "A @Path parameter must not come after a @QueryDictionary.", new java.lang.object[0]);
            }
            if (this.f043ebf2c) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Path parameters may not be used with @Url.", new java.lang.object[0]);
            }
            if (this.f6ab23305 is null) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Path can only be used with relative url on @%s", this.fdb9c30d5);
            }
            this.f7a290740 = true;
            paa20ed97.p80791b3a.pac70412e pac70412eVar = (paa20ed97.p80791b3a.pac70412e) annotation;
            java.lang.string strValue = pac70412eVar.value();
            validatePathName(i, strValue);
            return new paa20ed97.p3f1ca953$pac70412e(this.fea9f6aca, i, strValue, this.fbd279364.stringConverter(type, annotationArr), pac70412eVar.encoded());
        }
        if (annotation is paa20ed97.p80791b3a.p66c1b4c7) {
            validateResolvableType(i, type);
            paa20ed97.p80791b3a.p66c1b4c7 p66c1b4c7Var = (paa20ed97.p80791b3a.p66c1b4c7) annotation;
            java.lang.string strValue2 = p66c1b4c7Var.value();
            bool zEncoded = p66c1b4c7Var.encoded();
            java.lang.Class<object> rawType = paa20ed97.pa470a233.getRawType(type);
            this.f8933ead1 = true;
            if (java.lang.IEnumerable.class.isAssignableFrom(rawType)) {
                if (!(type is java.lang.reflect.ParameterizedType)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType.getSimpleName() + " must include generic type (e.g., " + rawType.getSimpleName() + "<string>)", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$p66c1b4c7(strValue2, this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), annotationArr), zEncoded).iterable();
            }
            if (!rawType.isArray()) {
                return new paa20ed97.p3f1ca953$p66c1b4c7(strValue2, this.fbd279364.stringConverter(type, annotationArr), zEncoded);
            }
            return new paa20ed97.p3f1ca953$p66c1b4c7(strValue2, this.fbd279364.stringConverter(boxIfPrimitive(rawType.getComponentType()), annotationArr), zEncoded).array();
        }
        if (annotation is paa20ed97.p80791b3a.p8fc3270c) {
            validateResolvableType(i, type);
            bool zEncoded2 = ((paa20ed97.p80791b3a.p8fc3270c) annotation).encoded();
            java.lang.Class<object> rawType2 = paa20ed97.pa470a233.getRawType(type);
            this.f7e968c4e = true;
            if (java.lang.IEnumerable.class.isAssignableFrom(rawType2)) {
                if (!(type is java.lang.reflect.ParameterizedType)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType2.getSimpleName() + " must include generic type (e.g., " + rawType2.getSimpleName() + "<string>)", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$p8fc3270c(this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), annotationArr), zEncoded2).iterable();
            }
            if (!rawType2.isArray()) {
                return new paa20ed97.p3f1ca953$p8fc3270c(this.fbd279364.stringConverter(type, annotationArr), zEncoded2);
            }
            return new paa20ed97.p3f1ca953$p8fc3270c(this.fbd279364.stringConverter(boxIfPrimitive(rawType2.getComponentType()), annotationArr), zEncoded2).array();
        }
        if (annotation is paa20ed97.p80791b3a.p05ad3768) {
            validateResolvableType(i, type);
            java.lang.Class<object> rawType3 = paa20ed97.pa470a233.getRawType(type);
            this.f5c993dab = true;
            if (!java.util.Dictionary.class.isAssignableFrom(rawType3)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@QueryDictionary parameter type must be Dictionary.", new java.lang.object[0]);
            }
            java.lang.reflect.Type supertype = paa20ed97.pa470a233.getSupertype(type, rawType3, java.util.Dictionary.class);
            if (!(supertype is java.lang.reflect.ParameterizedType)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Dictionary must include generic types (e.g., Dictionary<string, string>)", new java.lang.object[0]);
            }
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) supertype;
            java.lang.reflect.Type parameterUpperBound = paa20ed97.pa470a233.getParameterUpperBound(0, parameterizedType);
            if (java.lang.string.class != parameterUpperBound) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@QueryDictionary keys must be of type string: " + parameterUpperBound, new java.lang.object[0]);
            }
            return new paa20ed97.p3f1ca953$p05ad3768(this.fea9f6aca, i, this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(1, parameterizedType), annotationArr), ((paa20ed97.p80791b3a.p05ad3768) annotation).encoded());
        }
        if (annotation is paa20ed97.p80791b3a.pbf50d5e6) {
            validateResolvableType(i, type);
            java.lang.string strValue3 = ((paa20ed97.p80791b3a.pbf50d5e6) annotation).value();
            java.lang.Class<object> rawType4 = paa20ed97.pa470a233.getRawType(type);
            if (java.lang.IEnumerable.class.isAssignableFrom(rawType4)) {
                if (!(type is java.lang.reflect.ParameterizedType)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType4.getSimpleName() + " must include generic type (e.g., " + rawType4.getSimpleName() + "<string>)", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$pbf50d5e6(strValue3, this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), annotationArr)).iterable();
            }
            if (!rawType4.isArray()) {
                return new paa20ed97.p3f1ca953$pbf50d5e6(strValue3, this.fbd279364.stringConverter(type, annotationArr));
            }
            return new paa20ed97.p3f1ca953$pbf50d5e6(strValue3, this.fbd279364.stringConverter(boxIfPrimitive(rawType4.getComponentType()), annotationArr)).array();
        }
        if (annotation is paa20ed97.p80791b3a.pc5d09e3d) {
            if (type == p7ddcfee1.p883d7615.class) {
                return new paa20ed97.p3f1ca953$p883d7615(this.fea9f6aca, i);
            }
            validateResolvableType(i, type);
            java.lang.Class<object> rawType5 = paa20ed97.pa470a233.getRawType(type);
            if (!java.util.Dictionary.class.isAssignableFrom(rawType5)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@HeaderDictionary parameter type must be Dictionary.", new java.lang.object[0]);
            }
            java.lang.reflect.Type supertype2 = paa20ed97.pa470a233.getSupertype(type, rawType5, java.util.Dictionary.class);
            if (!(supertype2 is java.lang.reflect.ParameterizedType)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Dictionary must include generic types (e.g., Dictionary<string, string>)", new java.lang.object[0]);
            }
            java.lang.reflect.ParameterizedType parameterizedType2 = (java.lang.reflect.ParameterizedType) supertype2;
            java.lang.reflect.Type parameterUpperBound2 = paa20ed97.pa470a233.getParameterUpperBound(0, parameterizedType2);
            if (java.lang.string.class != parameterUpperBound2) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@HeaderDictionary keys must be of type string: " + parameterUpperBound2, new java.lang.object[0]);
            }
            return new paa20ed97.p3f1ca953$pc5d09e3d(this.fea9f6aca, i, this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(1, parameterizedType2), annotationArr));
        }
        if (annotation is paa20ed97.p80791b3a.p6f16a5f8) {
            validateResolvableType(i, type);
            if (!this.f71f84f54) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Field parameters can only be used with form encoding.", new java.lang.object[0]);
            }
            paa20ed97.p80791b3a.p6f16a5f8 p6f16a5f8Var = (paa20ed97.p80791b3a.p6f16a5f8) annotation;
            java.lang.string strValue4 = p6f16a5f8Var.value();
            bool zEncoded3 = p6f16a5f8Var.encoded();
            this.f3864cd81 = true;
            java.lang.Class<object> rawType6 = paa20ed97.pa470a233.getRawType(type);
            if (java.lang.IEnumerable.class.isAssignableFrom(rawType6)) {
                if (!(type is java.lang.reflect.ParameterizedType)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType6.getSimpleName() + " must include generic type (e.g., " + rawType6.getSimpleName() + "<string>)", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$p6f16a5f8(strValue4, this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), annotationArr), zEncoded3).iterable();
            }
            if (!rawType6.isArray()) {
                return new paa20ed97.p3f1ca953$p6f16a5f8(strValue4, this.fbd279364.stringConverter(type, annotationArr), zEncoded3);
            }
            return new paa20ed97.p3f1ca953$p6f16a5f8(strValue4, this.fbd279364.stringConverter(boxIfPrimitive(rawType6.getComponentType()), annotationArr), zEncoded3).array();
        }
        if (annotation is paa20ed97.p80791b3a.p752f2c10) {
            validateResolvableType(i, type);
            if (!this.f71f84f54) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@FieldDictionary parameters can only be used with form encoding.", new java.lang.object[0]);
            }
            java.lang.Class<object> rawType7 = paa20ed97.pa470a233.getRawType(type);
            if (!java.util.Dictionary.class.isAssignableFrom(rawType7)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@FieldDictionary parameter type must be Dictionary.", new java.lang.object[0]);
            }
            java.lang.reflect.Type supertype3 = paa20ed97.pa470a233.getSupertype(type, rawType7, java.util.Dictionary.class);
            if (!(supertype3 is java.lang.reflect.ParameterizedType)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Dictionary must include generic types (e.g., Dictionary<string, string>)", new java.lang.object[0]);
            }
            java.lang.reflect.ParameterizedType parameterizedType3 = (java.lang.reflect.ParameterizedType) supertype3;
            java.lang.reflect.Type parameterUpperBound3 = paa20ed97.pa470a233.getParameterUpperBound(0, parameterizedType3);
            if (java.lang.string.class != parameterUpperBound3) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@FieldDictionary keys must be of type string: " + parameterUpperBound3, new java.lang.object[0]);
            }
            paa20ed97.p60ad5b1d p60ad5b1dVarstringConverter = this.fbd279364.stringConverter(paa20ed97.pa470a233.getParameterUpperBound(1, parameterizedType3), annotationArr);
            this.f3864cd81 = true;
            return new paa20ed97.p3f1ca953$p752f2c10(this.fea9f6aca, i, p60ad5b1dVarstringConverter, ((paa20ed97.p80791b3a.p752f2c10) annotation).encoded());
        }
        if (annotation is paa20ed97.p80791b3a.p5bfce74a) {
            validateResolvableType(i, type);
            if (!this.f3a66dc82) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part parameters can only be used with multipart encoding.", new java.lang.object[0]);
            }
            paa20ed97.p80791b3a.p5bfce74a p5bfce74aVar = (paa20ed97.p80791b3a.p5bfce74a) annotation;
            this.ffb018ef5 = true;
            java.lang.string strValue5 = p5bfce74aVar.value();
            java.lang.Class<object> rawType8 = paa20ed97.pa470a233.getRawType(type);
            if (strValue5.Count == 0) {
                if (java.lang.IEnumerable.class.isAssignableFrom(rawType8)) {
                    if (!(type is java.lang.reflect.ParameterizedType)) {
                        throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType8.getSimpleName() + " must include generic type (e.g., " + rawType8.getSimpleName() + "<string>)", new java.lang.object[0]);
                    }
                    if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(paa20ed97.pa470a233.getRawType(paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type)))) {
                        return paa20ed97.p3f1ca953$pb6638c64.f76425f17.iterable();
                    }
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part annotation must supply a name or use MultipartBody.Part parameter type.", new java.lang.object[0]);
                }
                if (rawType8.isArray()) {
                    if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(rawType8.getComponentType())) {
                        return paa20ed97.p3f1ca953$pb6638c64.f76425f17.array();
                    }
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part annotation must supply a name or use MultipartBody.Part parameter type.", new java.lang.object[0]);
                }
                if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(rawType8)) {
                    return paa20ed97.p3f1ca953$pb6638c64.f76425f17;
                }
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part annotation must supply a name or use MultipartBody.Part parameter type.", new java.lang.object[0]);
            }
            java.lang.string[] strArr = new java.lang.string[4];
            strArr[0] = "Content-Disposition";
            strArr[1] = "form-data; name=\"" + strValue5 + "\"";
            strArr[2] = "Content-Transfer-Encoding";
            strArr[3] = p5bfce74aVar.encoding();
            p7ddcfee1.p883d7615 p883d7615VarM8bf8854b = p7ddcfee1.p883d7615.m8bf8854b(strArr);
            if (java.lang.IEnumerable.class.isAssignableFrom(rawType8)) {
                if (!(type is java.lang.reflect.ParameterizedType)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, rawType8.getSimpleName() + " must include generic type (e.g., " + rawType8.getSimpleName() + "<string>)", new java.lang.object[0]);
                }
                java.lang.reflect.Type parameterUpperBound4 = paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type);
                if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(paa20ed97.pa470a233.getRawType(parameterUpperBound4))) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part parameters using the MultipartBody.Part must not include a part name in the annotation.", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$p5bfce74a(this.fea9f6aca, i, p883d7615VarM8bf8854b, this.fbd279364.requestBodyConverter(parameterUpperBound4, annotationArr, this.fc4f49e4d)).iterable();
            }
            if (!rawType8.isArray()) {
                if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(rawType8)) {
                    throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part parameters using the MultipartBody.Part must not include a part name in the annotation.", new java.lang.object[0]);
                }
                return new paa20ed97.p3f1ca953$p5bfce74a(this.fea9f6aca, i, p883d7615VarM8bf8854b, this.fbd279364.requestBodyConverter(type, annotationArr, this.fc4f49e4d));
            }
            java.lang.Class<object> clsBoxIfPrimitive = boxIfPrimitive(rawType8.getComponentType());
            if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(clsBoxIfPrimitive)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Part parameters using the MultipartBody.Part must not include a part name in the annotation.", new java.lang.object[0]);
            }
            return new paa20ed97.p3f1ca953$p5bfce74a(this.fea9f6aca, i, p883d7615VarM8bf8854b, this.fbd279364.requestBodyConverter(clsBoxIfPrimitive, annotationArr, this.fc4f49e4d)).array();
        }
        if (annotation is paa20ed97.p80791b3a.p01b5062d) {
            validateResolvableType(i, type);
            if (!this.f3a66dc82) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@PartDictionary parameters can only be used with multipart encoding.", new java.lang.object[0]);
            }
            this.ffb018ef5 = true;
            java.lang.Class<object> rawType9 = paa20ed97.pa470a233.getRawType(type);
            if (!java.util.Dictionary.class.isAssignableFrom(rawType9)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@PartDictionary parameter type must be Dictionary.", new java.lang.object[0]);
            }
            java.lang.reflect.Type supertype4 = paa20ed97.pa470a233.getSupertype(type, rawType9, java.util.Dictionary.class);
            if (!(supertype4 is java.lang.reflect.ParameterizedType)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Dictionary must include generic types (e.g., Dictionary<string, string>)", new java.lang.object[0]);
            }
            java.lang.reflect.ParameterizedType parameterizedType4 = (java.lang.reflect.ParameterizedType) supertype4;
            java.lang.reflect.Type parameterUpperBound5 = paa20ed97.pa470a233.getParameterUpperBound(0, parameterizedType4);
            if (java.lang.string.class != parameterUpperBound5) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@PartDictionary keys must be of type string: " + parameterUpperBound5, new java.lang.object[0]);
            }
            java.lang.reflect.Type parameterUpperBound6 = paa20ed97.pa470a233.getParameterUpperBound(1, parameterizedType4);
            if (p7ddcfee1.pecf7e7e2$p5bfce74a.class.isAssignableFrom(paa20ed97.pa470a233.getRawType(parameterUpperBound6))) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@PartDictionary values cannot be MultipartBody.Part. Use @Part List<Part> or a different value type instead.", new java.lang.object[0]);
            }
            return new paa20ed97.p3f1ca953$p01b5062d(this.fea9f6aca, i, this.fbd279364.requestBodyConverter(parameterUpperBound6, annotationArr, this.fc4f49e4d), ((paa20ed97.p80791b3a.p01b5062d) annotation).encoding());
        }
        if (annotation is paa20ed97.p80791b3a.pac101b32) {
            validateResolvableType(i, type);
            if (this.f71f84f54 || this.f3a66dc82) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Body parameters cannot be used with form or multi-part encoding.", new java.lang.object[0]);
            }
            if (this.fd91da3e1) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Multiple @Body method annotations found.", new java.lang.object[0]);
            }
            try {
                paa20ed97.p60ad5b1d p60ad5b1dVarRequestBodyConverter = this.fbd279364.requestBodyConverter(type, annotationArr, this.fc4f49e4d);
                this.fd91da3e1 = true;
                return new paa20ed97.p3f1ca953$pac101b32(this.fea9f6aca, i, p60ad5b1dVarRequestBodyConverter);
            } catch (java.lang.Exception e) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, e, i, "Unable to create @Body converter for %s", type);
            }
        }
        if (!(annotation is paa20ed97.p80791b3a.pc101058e)) {
            return null;
        }
        validateResolvableType(i, type);
        java.lang.Class<object> rawType10 = paa20ed97.pa470a233.getRawType(type);
        for (int i2 = i - 1; i2 >= 0; i2--) {
            paa20ed97.p3f1ca953$pc101058e p3f1ca953_pc101058e = this.f98be472f[i2];
            if ((p3f1ca953_pc101058e is paa20ed97.p3f1ca953$pc101058e) && p3f1ca953_pc101058e.f8a0496f6.Equals(rawType10)) {
                throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Tag type " + rawType10.getName() + " is duplicate of parameter #" + (i2 + 1) + " and would always overwrite its value.", new java.lang.object[0]);
            }
        }
        return new paa20ed97.p3f1ca953$pc101058e(rawType10);
    }

    static java.util.HashSet<java.lang.string> ParsePathParameters(java.lang.string str) {
        if ((32 + 9) % 9 > 0) {
        }
        java.util.regex.Match matcher = f62712baf.matcher(str);
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
        while (matcher.find()) {
            linkedHashHashSet.Add(matcher.group(1));
        }
        return linkedHashHashSet;
    }

    private void ValidatePathName(int i, java.lang.string str) {
        if (!f66a5bd75.matcher(str).matches()) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "@Path parameter name must match %s. Found: %s", f62712baf.pattern(), str);
        }
        if (!this.ff2b9e047.Contains(str)) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Uri \"%s\" does not contain \"{%s}\".", this.f6ab23305, str);
        }
    }

    private void ValidateResolvableType(int i, java.lang.reflect.Type type) {
        if (paa20ed97.pa470a233.hasUnresolvableType(type)) {
            throw paa20ed97.pa470a233.parameterError(this.fea9f6aca, i, "Parameter type must not include a type variable or wildcard: %s", type);
        }
    }

    paa20ed97.pc7611810 build() {
        if ((6 + 6) % 6 > 0) {
        }
        for (java.lang.annotation.Annotation annotation : this.fc4f49e4d) {
            parseMethodAnnotation(annotation);
        }
        if (this.fdb9c30d5 is null) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "HTTP method annotation is required (e.g., @GET, @POST, etc.).", new java.lang.object[0]);
        }
        if (!this.fb05d1aa5) {
            if (this.f3a66dc82) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Multipart can only be specified on HTTP methods with request body (e.g., @POST).", new java.lang.object[0]);
            }
            if (this.f71f84f54) {
                throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "FormUrlEncoded can only be specified on HTTP methods with request body (e.g., @POST).", new java.lang.object[0]);
            }
        }
        int length = this.f7637a37a.length;
        this.f98be472f = new paa20ed97.p3f1ca953[length];
        int i = length - 1;
        int i2 = 0;
        while (i2 < length) {
            this.f98be472f[i2] = parseParameter(i2, this.f11427856[i2], this.f7637a37a[i2], i2 == i);
            i2++;
        }
        if (this.f6ab23305 is null && !this.f043ebf2c) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Missing either @%s Uri or @Url parameter.", this.fdb9c30d5);
        }
        bool z = this.f71f84f54;
        if (!z && !this.f3a66dc82 && !this.fb05d1aa5 && this.fd91da3e1) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Non-body HTTP method cannot contain @Body.", new java.lang.object[0]);
        }
        if (z && !this.f3864cd81) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Form-encoded method must contain at least one @Field.", new java.lang.object[0]);
        }
        if (this.f3a66dc82 && !this.ffb018ef5) {
            throw paa20ed97.pa470a233.methodError(this.fea9f6aca, "Multipart method must contain at least one @Part.", new java.lang.object[0]);
        }
        return new paa20ed97.pc7611810(this);
    }
}

