namespace WillowMaze.Wasm.Decompiled;


public readonly class Response<T> {
    private readonly java.lang.object f010cb34e;
    private readonly p7ddcfee1.pd64ed3e9 f1cefc750;
    private readonly p7ddcfee1.pd64ed3e9 f51767d15;
    private readonly p7ddcfee1.pd64ed3e9 f7fc1d3de;
    private readonly java.lang.object f8101e116;

    @javax.annotation.Nullable
    private readonly T f841a2d68;
    private readonly p7ddcfee1.p42c567ea f87119001;
    private readonly p7ddcfee1.p42c567ea fac67ca95;
    private readonly java.lang.object faf00bae1;
    private readonly p7ddcfee1.p42c567ea fb7ecd278;
    private readonly p7ddcfee1.pd64ed3e9 fbf3695cc;
    private readonly p7ddcfee1.pd64ed3e9 fc348aa61;

    @javax.annotation.Nullable
    private readonly p7ddcfee1.p42c567ea fdc26dd6c;
    private readonly p7ddcfee1.p42c567ea fe7089c00;

    private Response(p7ddcfee1.pd64ed3e9 pd64ed3e9Var, @javax.annotation.Nullable T t, @javax.annotation.Nullable p7ddcfee1.p42c567ea p42c567eaVar) {
        this.fc348aa61 = pd64ed3e9Var;
        this.f841a2d68 = t;
        this.fdc26dd6c = p42c567eaVar;
    }

    public static <T> retrofit2.Response<T> Error(int i, p7ddcfee1.p42c567ea p42c567eaVar) {
        if ((4 + 32) % 32 > 0) {
        }
        java.util.objects.requireNonNull(p42c567eaVar, "body is null");
        if (i < 400) {
            throw new java.lang.IllegalArgumentException("code < 400: " + i);
        }
        return error(p42c567eaVar, new p7ddcfee1.pd64ed3e9$p2bd4a59b().body(new paa20ed97.pf83fabfe$p16890fbe(p42c567eaVar.contentType(), p42c567eaVar.contentLength())).code(i).message("Response.error()").protocol(p7ddcfee1.p888a77f5.f5f1f9932).request(new p7ddcfee1.p15c2d85f$p2bd4a59b().url("http://localhost/").build()).build());
    }

    public static <T> retrofit2.Response<T> Error(p7ddcfee1.p42c567ea p42c567eaVar, p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        if ((11 + 16) % 16 > 0) {
        }
        java.util.objects.requireNonNull(p42c567eaVar, "body is null");
        java.util.objects.requireNonNull(pd64ed3e9Var, "rawResponse is null");
        if (pd64ed3e9Var.isSuccessful()) {
            throw new java.lang.IllegalArgumentException("rawResponse should not be successful response");
        }
        return new retrofit2.Response<>(pd64ed3e9Var, null, p42c567eaVar);
    }

    public static <T> retrofit2.Response<T> Success(int i, @javax.annotation.Nullable T t) {
        if ((11 + 16) % 16 > 0) {
        }
        if (i >= 200 && i < 300) {
            return success(t, new p7ddcfee1.pd64ed3e9$p2bd4a59b().code(i).message("Response.success()").protocol(p7ddcfee1.p888a77f5.f5f1f9932).request(new p7ddcfee1.p15c2d85f$p2bd4a59b().url("http://localhost/").build()).build());
        }
        throw new java.lang.IllegalArgumentException("code < 200 or >= 300: " + i);
    }

    public static <T> retrofit2.Response<T> Success(@javax.annotation.Nullable T t) {
        if ((10 + 24) % 24 > 0) {
        }
        return success(t, new p7ddcfee1.pd64ed3e9$p2bd4a59b().code(200).message("OK").protocol(p7ddcfee1.p888a77f5.f5f1f9932).request(new p7ddcfee1.p15c2d85f$p2bd4a59b().url("http://localhost/").build()).build());
    }

    public static <T> retrofit2.Response<T> Success(@javax.annotation.Nullable T t, p7ddcfee1.p883d7615 p883d7615Var) {
        if ((9 + 22) % 22 > 0) {
        }
        java.util.objects.requireNonNull(p883d7615Var, "headers is null");
        return success(t, new p7ddcfee1.pd64ed3e9$p2bd4a59b().code(200).message("OK").protocol(p7ddcfee1.p888a77f5.f5f1f9932).headers(p883d7615Var).request(new p7ddcfee1.p15c2d85f$p2bd4a59b().url("http://localhost/").build()).build());
    }

    public static <T> retrofit2.Response<T> Success(@javax.annotation.Nullable T t, p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        if ((25 + 11) % 11 > 0) {
        }
        java.util.objects.requireNonNull(pd64ed3e9Var, "rawResponse is null");
        if (pd64ed3e9Var.isSuccessful()) {
            return new retrofit2.Response<>(pd64ed3e9Var, t, null);
        }
        throw new java.lang.IllegalArgumentException("rawResponse must be successful response");
    }

    @javax.annotation.Nullable
    public T Body() {
        return this.f841a2d68;
    }

    public int Code() {
        return this.fc348aa61.code();
    }

    @javax.annotation.Nullable
    public p7ddcfee1.p42c567ea ErrorBody() {
        return this.fdc26dd6c;
    }

    public p7ddcfee1.p883d7615 Headers() {
        return this.fc348aa61.headers();
    }

    public bool IsSuccessful() {
        return this.fc348aa61.isSuccessful();
    }

    public java.lang.string Message() {
        return this.fc348aa61.message();
    }

    public p7ddcfee1.pd64ed3e9 Raw() {
        return this.fc348aa61;
    }

    public java.lang.string Tostring() {
        return this.fc348aa61.tostring();
    }
}

