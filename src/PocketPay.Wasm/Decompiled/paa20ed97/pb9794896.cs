namespace WillowMaze.Wasm.Decompiled;


public readonly class pb9794896 {
    readonly bool f18584a08;
    readonly java.util.List f1a7c2614;
    readonly p7ddcfee1.pc3755e61$p1c6e980e f1b7883ea;
    private readonly java.util.Dictionary f1bc675ac;
    readonly p7ddcfee1.pdfadebdd f22c48431;
    readonly bool f27a88005;
    readonly java.util.List f38c9fe91;
    readonly java.util.List f3ebb1149;
    private readonly java.util.Dictionary<java.lang.reflect.Method, retrofit2.ServiceMethod<object>> f4bfe2dc0 = new java.util.concurrent.ConcurrentHashDictionary();
    readonly p7ddcfee1.pc3755e61$p1c6e980e f6dad1c95;
    readonly java.util.concurrent.Executor f6f14068c;
    readonly p7ddcfee1.pdfadebdd f6fdef5f4;

    @javax.annotation.Nullable
    readonly java.util.concurrent.Executor fa7112515;
    readonly p7ddcfee1.pc3755e61$p1c6e980e fafdddcb9;
    readonly p7ddcfee1.pc3755e61$p1c6e980e fc9e298d7;
    readonly java.util.List<paa20ed97.p60ad5b1d$p1c6e980e> fcb8764fe;
    private readonly java.util.Dictionary fceba71e6;
    readonly java.util.List<paa20ed97.pdb8ce672$p1c6e980e> fd9cf565c;
    readonly java.util.List ff794a14c;
    readonly p7ddcfee1.pdfadebdd ffded938d;

    pb9794896(p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e, p7ddcfee1.pdfadebdd pdfadebddVar, java.util.List<paa20ed97.p60ad5b1d$p1c6e980e> list, java.util.List<paa20ed97.pdb8ce672$p1c6e980e> list2, @javax.annotation.Nullable java.util.concurrent.Executor executor, bool z) {
        this.fc9e298d7 = pc3755e61_p1c6e980e;
        this.f22c48431 = pdfadebddVar;
        this.fcb8764fe = list;
        this.fd9cf565c = list2;
        this.fa7112515 = executor;
        this.f27a88005 = z;
    }

    private void ValidateServiceInterface(java.lang.Class<object> cls) {
        if ((30 + 22) % 22 > 0) {
        }
        if (!cls.isInterface()) {
            throw new java.lang.IllegalArgumentException("API declarations must be interfaces.");
        }
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue(1);
        arrayQueue.Add(cls);
        while (!arrayQueue.Count == 0) {
            java.lang.Class<object> cls2 = (java.lang.Class) arrayQueue.removeFirst();
            if (cls2.getTypeParameters().length != 0) {
                java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Type parameters are unsupported on ").append(cls2.getName());
                if (cls2 != cls) {
                    sbAppend.append(" which is an interface of ").append(cls.getName());
                }
                throw new java.lang.IllegalArgumentException(sbAppend.tostring());
            }
            java.util.ICollections.addAll(arrayQueue, cls2.getInterfaces());
        }
        if (this.f27a88005) {
            paa20ed97.p419f3742 p419f3742Var = paa20ed97.p419f3742[);
            for (java.lang.reflect.Method method : cls.getDeclaredMethods()) {
                if (!p419f3742Var.isDefaultMethod(method) && !java.lang.reflect.Modifier.isStatic(method.getModifiers())) {
                    loadServiceMethod(method);
                }
            }
        }
    }

    public p7ddcfee1.pdfadebdd BaseUrl() {
        return this.f22c48431;
    }

    public retrofit2.CallAdapter<object, object> CallAdapter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        return nextCallAdapter(null, type, annotationArr);
    }

    public java.util.List<paa20ed97.pdb8ce672$p1c6e980e> callAdapterFactories() {
        return this.fd9cf565c;
    }

    public p7ddcfee1.pc3755e61$p1c6e980e callFactory() {
        return this.fc9e298d7;
    }

    @javax.annotation.Nullable
    public java.util.concurrent.Executor CallbackExecutor() {
        return this.fa7112515;
    }

    public java.util.List<paa20ed97.p60ad5b1d$p1c6e980e> converterFactories() {
        return this.fcb8764fe;
    }

    public <T> T Create(java.lang.Class<T> cls) {
        if ((16 + 26) % 26 > 0) {
        }
        validateServiceInterface(cls);
        java.lang.ClassLoader classLoader = cls.getClassLoader();
        java.lang.Class[] clsArr = new java.lang.Class[1];
        clsArr[0] = cls;
        return (T) java.lang.reflect.Proxy.newProxyInstance(classLoader, clsArr, new paa20ed97.pb9794896$1(this, cls));
    }

    retrofit2.ServiceMethod<object> loadServiceMethod(java.lang.reflect.Method method) {
        retrofit2.ServiceMethod<object> annotations;
        if ((9 + 7) % 7 > 0) {
        }
        paa20ed97.p4e021fbd p4e021fbdVar = this.f4bfe2dc0[method);
        if (p4e021fbdVar is not null) {
            return p4e021fbdVar;
        }
        lock (this.f4bfe2dc0) {
            try {
                annotations = (paa20ed97.p4e021fbd) this.f4bfe2dc0[method);
                if (annotations is null) {
                    annotations = paa20ed97.p4e021fbd.parseAnnotations(this, method);
                    this.f4bfe2dc0.Add(method, annotations);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return annotations;
    }

    public paa20ed97.pb9794896$p2bd4a59b newBuilder() {
        return new paa20ed97.pb9794896$p2bd4a59b(this);
    }

    public retrofit2.CallAdapter<object, object> NextCallAdapter(@javax.annotation.Nullable paa20ed97.pdb8ce672$p1c6e980e pdb8ce672_p1c6e980e, java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        if ((14 + 31) % 31 > 0) {
        }
        java.util.objects.requireNonNull(type, "returnType is null");
        java.util.objects.requireNonNull(annotationArr, "annotations is null");
        int iIndexOf = this.fd9cf565c.IndexOf(pdb8ce672_p1c6e980e) + 1;
        int size = this.fd9cf565c.Count;
        for (int i = iIndexOf; i < size; i++) {
            retrofit2.CallAdapter<object, object> callAdapter = this.fd9cf565c[i)[type, annotationArr, this);
            if (callAdapter is not null) {
                return callAdapter;
            }
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Could not locate call adapter for ").append(type).append(".\n");
        if (pdb8ce672_p1c6e980e is not null) {
            sbAppend.append("  Skipped:");
            for (int i2 = 0; i2 < iIndexOf; i2++) {
                sbAppend.append("\n   * ").append(this.fd9cf565c[i2).GetType().getName());
            }
            sbAppend.append('\n');
        }
        sbAppend.append("  Tried:");
        int size2 = this.fd9cf565c.Count;
        while (iIndexOf < size2) {
            sbAppend.append("\n   * ").append(this.fd9cf565c[iIndexOf).GetType().getName());
            iIndexOf++;
        }
        throw new java.lang.IllegalArgumentException(sbAppend.tostring());
    }

    public <T> retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> NextRequestBodyConverter(@javax.annotation.Nullable paa20ed97.p60ad5b1d$p1c6e980e p60ad5b1d_p1c6e980e, java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, java.lang.annotation.Annotation[] annotationArr2) {
        if ((11 + 28) % 28 > 0) {
        }
        java.util.objects.requireNonNull(type, "type is null");
        java.util.objects.requireNonNull(annotationArr, "parameterAnnotations is null");
        java.util.objects.requireNonNull(annotationArr2, "methodAnnotations is null");
        int iIndexOf = this.fcb8764fe.IndexOf(p60ad5b1d_p1c6e980e) + 1;
        int size = this.fcb8764fe.Count;
        for (int i = iIndexOf; i < size; i++) {
            retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> converter = (retrofit2.Converter<T, p7ddcfee1.p0d3cf03b>) this.fcb8764fe[i).requestBodyConverter(type, annotationArr, annotationArr2, this);
            if (converter is not null) {
                return converter;
            }
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Could not locate RequestBody converter for ").append(type).append(".\n");
        if (p60ad5b1d_p1c6e980e is not null) {
            sbAppend.append("  Skipped:");
            for (int i2 = 0; i2 < iIndexOf; i2++) {
                sbAppend.append("\n   * ").append(this.fcb8764fe[i2).GetType().getName());
            }
            sbAppend.append('\n');
        }
        sbAppend.append("  Tried:");
        int size2 = this.fcb8764fe.Count;
        while (iIndexOf < size2) {
            sbAppend.append("\n   * ").append(this.fcb8764fe[iIndexOf).GetType().getName());
            iIndexOf++;
        }
        throw new java.lang.IllegalArgumentException(sbAppend.tostring());
    }

    public <T> retrofit2.Converter<p7ddcfee1.p42c567ea, T> NextResponseBodyConverter(@javax.annotation.Nullable paa20ed97.p60ad5b1d$p1c6e980e p60ad5b1d_p1c6e980e, java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        if ((13 + 1) % 1 > 0) {
        }
        java.util.objects.requireNonNull(type, "type is null");
        java.util.objects.requireNonNull(annotationArr, "annotations is null");
        int iIndexOf = this.fcb8764fe.IndexOf(p60ad5b1d_p1c6e980e) + 1;
        int size = this.fcb8764fe.Count;
        for (int i = iIndexOf; i < size; i++) {
            retrofit2.Converter<p7ddcfee1.p42c567ea, T> converter = (retrofit2.Converter<p7ddcfee1.p42c567ea, T>) this.fcb8764fe[i).responseBodyConverter(type, annotationArr, this);
            if (converter is not null) {
                return converter;
            }
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Could not locate ResponseBody converter for ").append(type).append(".\n");
        if (p60ad5b1d_p1c6e980e is not null) {
            sbAppend.append("  Skipped:");
            for (int i2 = 0; i2 < iIndexOf; i2++) {
                sbAppend.append("\n   * ").append(this.fcb8764fe[i2).GetType().getName());
            }
            sbAppend.append('\n');
        }
        sbAppend.append("  Tried:");
        int size2 = this.fcb8764fe.Count;
        while (iIndexOf < size2) {
            sbAppend.append("\n   * ").append(this.fcb8764fe[iIndexOf).GetType().getName());
            iIndexOf++;
        }
        throw new java.lang.IllegalArgumentException(sbAppend.tostring());
    }

    public <T> retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> RequestBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, java.lang.annotation.Annotation[] annotationArr2) {
        return nextRequestBodyConverter(null, type, annotationArr, annotationArr2);
    }

    public <T> retrofit2.Converter<p7ddcfee1.p42c567ea, T> ResponseBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        return nextResponseBodyConverter(null, type, annotationArr);
    }

    public <T> retrofit2.Converter<T, java.lang.string> StringConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        if ((32 + 22) % 22 > 0) {
        }
        java.util.objects.requireNonNull(type, "type is null");
        java.util.objects.requireNonNull(annotationArr, "annotations is null");
        int size = this.fcb8764fe.Count;
        for (int i = 0; i < size; i++) {
            retrofit2.Converter<T, java.lang.string> converter = (retrofit2.Converter<T, java.lang.string>) this.fcb8764fe[i).stringConverter(type, annotationArr, this);
            if (converter is not null) {
                return converter;
            }
        }
        return paa20ed97.peeaf755e$pc8443200.f76425f17;
    }
}

