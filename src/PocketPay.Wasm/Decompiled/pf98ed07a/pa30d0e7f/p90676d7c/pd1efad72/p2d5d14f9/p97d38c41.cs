namespace WillowMaze.Wasm.Decompiled;


public readonly class p97d38c41 : io.reactivex.rxjava3.operators.QueueSubscription<java.lang.object> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41 f76425f17;

    static {
        if ((25 + 29) % 29 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41 p97d38c41Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41(NGuoXYczyLtaHFZD("f1df3c70ad0cde40489219b14d1d43235e605c334476e96c5a44e1a511af37880d31a9e9"), 0);
        f76425f17 = p97d38c41Var;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41[]{p97d38c41Var};
    }

    private p97d38c41(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object APBbBjlzpDGMwMgt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41[] p97d38c41VarArr) {
        return p97d38c41VarArr.clone();
    }

    public static void ICdqGuXJBLiFESmS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void InIoUDUyPdJIxcQi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.string NGuoXYczyLtaHFZD(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void RsdGLFsiEaTCHZbA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.Enum VicbFKnKmvQxwcIE(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void Complete(org.reactivestreams.Subscriber<object> subscriber) {
        RsdGLFsiEaTCHZbA(subscriber, f76425f17);
        ICdqGuXJBLiFESmS(subscriber);
    }

    public static void Error(java.lang.Exception th, org.reactivestreams.Subscriber<object> subscriber) {
        oPqwlUQQQYLXKvVU(subscriber, f76425f17);
        InIoUDUyPdJIxcQi(subscriber, th);
    }

    public static bool JyPsEFhCemxOPRNi(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void OPqwlUQQQYLXKvVU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41 ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41) VicbFKnKmvQxwcIE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41[]) APBbBjlzpDGMwMgt($VALUES);
    }

    public void Cancel() {
    }

    public void Clear() {
    }

    public bool IsEmpty() {
        return true;
    }

    public bool Offer(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public bool Offer(java.lang.object obj, java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public java.lang.object Poll() {
        return null;
    }

    public void Request(long j) {
        jyPsEFhCemxOPRNi(j);
    }

    public int RequestFusion(int i) {
        return i & 2;
    }

    public override java.lang.string Tostring() {
        return "EmptySubscription";
    }
}

