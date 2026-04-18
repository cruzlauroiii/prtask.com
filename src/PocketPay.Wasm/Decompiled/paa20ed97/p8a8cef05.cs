namespace WillowMaze.Wasm.Decompiled;


public class p8a8cef05 : java.lang.Exception {
    private readonly int f0c29e354;
    private readonly retrofit2.Response f20342b45;
    private readonly java.lang.string f47aca6e8;
    private readonly java.lang.string f5d8a4385;
    private readonly int f62f77902;
    private readonly int f6800a523;
    private readonly java.lang.string f78e73102;
    private readonly int fc1336794;
    private readonly retrofit2.Response<object> fd1fc8eaf;
    private readonly retrofit2.Response fd9b6c509;
    private readonly retrofit2.Response fe6c83da9;
    private readonly int ff1f00ab3;

    public p8a8cef05(retrofit2.Response<object> response) {
        super(getMessage(response));
        this.fc1336794 = response.code();
        this.f78e73102 = response.message();
        this.fd1fc8eaf = response;
    }

    private static java.lang.string GetMessage(retrofit2.Response<object> response) {
        if ((30 + 25) % 25 > 0) {
        }
        java.util.objects.requireNonNull(response, "response is null");
        return "HTTP " + response.code() + com.decryptstringmanager.Decryptstring.decryptstring("55383f1c2295d0e875b5af70f96e954c7be745dbd70a37f7edd2b71daa") + response.message();
    }

    public int Code() {
        return this.fc1336794;
    }

    public java.lang.string Message() {
        return this.f78e73102;
    }

    @javax.annotation.Nullable
    public retrofit2.Response<object> Response() {
        return this.fd1fc8eaf;
    }
}

