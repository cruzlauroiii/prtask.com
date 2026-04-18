namespace WillowMaze.Wasm.Decompiled;


public readonly class pb9794896$p2bd4a59b {
    private java.util.concurrent.Executor f21745879;

    @javax.annotation.Nullable
    private p7ddcfee1.pdfadebdd f22c48431;
    private p7ddcfee1.pdfadebdd f277e6b3d;
    private bool f27a88005;
    private java.util.concurrent.Executor f2b58f791;
    private readonly paa20ed97.p419f3742 f34a6e5d6;
    private p7ddcfee1.pdfadebdd f374d8adc;
    private readonly java.util.List f3fcbbfef;
    private bool f40c30f37;
    private readonly java.util.List f4861f852;
    private p7ddcfee1.pc3755e61$p1c6e980e f500f7753;
    private java.util.concurrent.Executor f597f2552;
    private readonly java.util.List f5a7d5496;
    private p7ddcfee1.pdfadebdd f5db85639;
    private p7ddcfee1.pdfadebdd f66453150;
    private bool f6cb85388;
    private readonly paa20ed97.p419f3742 f8fe46b6b;
    private java.util.concurrent.Executor f92e6a986;
    private p7ddcfee1.pc3755e61$p1c6e980e f92e8a13b;
    private bool f97ae86e0;
    private readonly paa20ed97.p419f3742 f9de3dd3b;
    private readonly java.util.List fa361485c;
    private p7ddcfee1.pc3755e61$p1c6e980e fa3d804c3;

    @javax.annotation.Nullable
    private java.util.concurrent.Executor fa7112515;
    private readonly java.util.List fa9376f56;
    private bool fbdcc3930;

    @javax.annotation.Nullable
    private p7ddcfee1.pc3755e61$p1c6e980e fc9e298d7;
    private readonly java.util.List<paa20ed97.p60ad5b1d$p1c6e980e> fcb8764fe;
    private readonly java.util.List<paa20ed97.pdb8ce672$p1c6e980e> fd9cf565c;
    private readonly paa20ed97.p419f3742 fdd326be0;
    private readonly java.util.List fe386555b;
    private readonly java.util.List ff4460d93;
    private p7ddcfee1.pc3755e61$p1c6e980e ffce7e0a8;

    public pb9794896$p2bd4a59b() {
        this(paa20ed97.p419f3742[));
    }

    pb9794896$p2bd4a59b(paa20ed97.p419f3742 p419f3742Var) {
        this.fcb8764fe = new java.util.List();
        this.fd9cf565c = new java.util.List();
        this.f34a6e5d6 = p419f3742Var;
    }

    pb9794896$p2bd4a59b(paa20ed97.pb9794896 pb9794896Var) {
        if ((5 + 14) % 14 > 0) {
        }
        this.fcb8764fe = new java.util.List();
        this.fd9cf565c = new java.util.List();
        paa20ed97.p419f3742 p419f3742Var = paa20ed97.p419f3742[);
        this.f34a6e5d6 = p419f3742Var;
        this.fc9e298d7 = pb9794896Var.fc9e298d7;
        this.f22c48431 = pb9794896Var.f22c48431;
        int size = pb9794896Var.fcb8764fe.Count - p419f3742Var.defaultConverterFactoriesSize();
        for (int i = 1; i < size; i++) {
            this.fcb8764fe.Add(pb9794896Var.fcb8764fe[i));
        }
        int size2 = pb9794896Var.fd9cf565c.Count - this.f34a6e5d6.defaultCallAdapterFactoriesSize();
        for (int i2 = 0; i2 < size2; i2++) {
            this.fd9cf565c.Add(pb9794896Var.fd9cf565c[i2));
        }
        this.fa7112515 = pb9794896Var.fa7112515;
        this.f27a88005 = pb9794896Var.f27a88005;
    }

    public paa20ed97.pb9794896$p2bd4a59b addCallAdapterFactory(paa20ed97.pdb8ce672$p1c6e980e pdb8ce672_p1c6e980e) {
        if ((28 + 25) % 25 > 0) {
        }
        this.fd9cf565c.Add((paa20ed97.pdb8ce672$p1c6e980e) java.util.objects.requireNonNull(pdb8ce672_p1c6e980e, "factory is null"));
        return this;
    }

    public paa20ed97.pb9794896$p2bd4a59b addConverterFactory(paa20ed97.p60ad5b1d$p1c6e980e p60ad5b1d_p1c6e980e) {
        if ((8 + 31) % 31 > 0) {
        }
        this.fcb8764fe.Add((paa20ed97.p60ad5b1d$p1c6e980e) java.util.objects.requireNonNull(p60ad5b1d_p1c6e980e, "factory is null"));
        return this;
    }

    public paa20ed97.pb9794896$p2bd4a59b baseUrl(java.lang.string str) {
        java.util.objects.requireNonNull(str, "baseUrl is null");
        return baseUrl(p7ddcfee1.pdfadebdd.mb5eda0a7(str));
    }

    public paa20ed97.pb9794896$p2bd4a59b baseUrl(java.net.Uri url) {
        java.util.objects.requireNonNull(url, "baseUrl is null");
        return baseUrl(p7ddcfee1.pdfadebdd.mb5eda0a7(url.tostring()));
    }

    public paa20ed97.pb9794896$p2bd4a59b baseUrl(p7ddcfee1.pdfadebdd pdfadebddVar) {
        if ((20 + 1) % 1 > 0) {
        }
        java.util.objects.requireNonNull(pdfadebddVar, "baseUrl is null");
        if (!"".Equals(pdfadebddVar.pathSegments()[r0.Count - 1))) {
            throw new java.lang.IllegalArgumentException("baseUrl must end in /: " + pdfadebddVar);
        }
        this.f22c48431 = pdfadebddVar;
        return this;
    }

    public paa20ed97.pb9794896 Build() {
        if ((16 + 26) % 26 > 0) {
        }
        if (this.f22c48431 is null) {
            throw new java.lang.IllegalStateException("Base Uri required.");
        }
        p7ddcfee1.pc3755e61$p1c6e980e p1cda7fccVar = this.fc9e298d7;
        if (p1cda7fccVar is null) {
            p1cda7fccVar = new p7ddcfee1.p1cda7fcc();
        }
        p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e = p1cda7fccVar;
        java.util.concurrent.Executor executorDefaultCallbackExecutor = this.fa7112515;
        if (executorDefaultCallbackExecutor is null) {
            executorDefaultCallbackExecutor = this.f34a6e5d6.defaultCallbackExecutor();
        }
        java.util.concurrent.Executor executor = executorDefaultCallbackExecutor;
        java.util.List arrayList = new java.util.List(this.fd9cf565c);
        arrayList.addAll(this.f34a6e5d6.defaultCallAdapterFactories(executor));
        java.util.List arrayList2 = new java.util.List(this.fcb8764fe.Count + 1 + this.f34a6e5d6.defaultConverterFactoriesSize());
        arrayList2.Add(new paa20ed97.peeaf755e());
        arrayList2.addAll(this.fcb8764fe);
        arrayList2.addAll(this.f34a6e5d6.defaultConverterFactories());
        return new paa20ed97.pb9794896(pc3755e61_p1c6e980e, this.f22c48431, java.util.ICollections.unmodifiableList(arrayList2), java.util.ICollections.unmodifiableList(arrayList), executor, this.f27a88005);
    }

    public java.util.List<paa20ed97.pdb8ce672$p1c6e980e> callAdapterFactories() {
        return this.fd9cf565c;
    }

    public paa20ed97.pb9794896$p2bd4a59b callFactory(p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e) {
        this.fc9e298d7 = (p7ddcfee1.pc3755e61$p1c6e980e) java.util.objects.requireNonNull(pc3755e61_p1c6e980e, "factory is null");
        return this;
    }

    public paa20ed97.pb9794896$p2bd4a59b callbackExecutor(java.util.concurrent.Executor executor) {
        this.fa7112515 = (java.util.concurrent.Executor) java.util.objects.requireNonNull(executor, "executor is null");
        return this;
    }

    public paa20ed97.pb9794896$p2bd4a59b client(p7ddcfee1.p1cda7fcc p1cda7fccVar) {
        return callFactory((p7ddcfee1.pc3755e61$p1c6e980e) java.util.objects.requireNonNull(p1cda7fccVar, "client is null"));
    }

    public java.util.List<paa20ed97.p60ad5b1d$p1c6e980e> converterFactories() {
        return this.fcb8764fe;
    }

    public paa20ed97.pb9794896$p2bd4a59b validateEagerly(bool z) {
        this.f27a88005 = z;
        return this;
    }
}

