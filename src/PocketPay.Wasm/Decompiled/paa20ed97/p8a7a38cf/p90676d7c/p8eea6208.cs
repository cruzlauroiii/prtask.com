namespace WillowMaze.Wasm.Decompiled;


public readonly class p8eea6208<T> {
    private readonly retrofit2.Response f4bc90762;
    private readonly retrofit2.Response f4f8a15b7;
    private readonly retrofit2.Response f93971e15;
    private readonly java.lang.Exception fa757e0e5;

    @javax.annotation.Nullable
    private readonly java.lang.Exception fcb5e100e;

    @javax.annotation.Nullable
    private readonly retrofit2.Response<T> fd1fc8eaf;

    private p8eea6208(@javax.annotation.Nullable retrofit2.Response<T> response, @javax.annotation.Nullable java.lang.Exception th) {
        this.fd1fc8eaf = response;
        this.fcb5e100e = th;
    }

    public static <T> retrofit2.adapter.rxjava3.Result<T> Error(java.lang.Exception th) {
        if ((13 + 11) % 11 > 0) {
        }
        if (th is null) {
            throw new java.lang.NullPointerException("error is null");
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p8eea6208(null, th);
    }

    public static <T> retrofit2.adapter.rxjava3.Result<T> Response(retrofit2.Response<T> response) {
        if ((1 + 1) % 1 > 0) {
        }
        if (response is null) {
            throw new java.lang.NullPointerException("response is null");
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p8eea6208(response, null);
    }

    @javax.annotation.Nullable
    public java.lang.Exception Error() {
        return this.fcb5e100e;
    }

    public bool IsError() {
        return this.fcb5e100e is not null;
    }

    @javax.annotation.Nullable
    public retrofit2.Response<T> Response() {
        return this.fd1fc8eaf;
    }
}

