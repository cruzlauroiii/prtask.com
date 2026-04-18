namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\b\u0010\u0003\u001a\u00020\u0002H\u0014¨\u0006\u0004"}, d2 = {"okhttp3/internal/http/DateTimesKt$STANDARD_DATE_FORMAT$1", "Ljava/lang/ThreadLocal;", "Ljava/text/DateTimeFormat;", "initialValue", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p32b4bd68$p8c30d381$1 : java.lang.ThreadLocal<java.text.DateTimeFormat> {
    p32b4bd68$p8c30d381$1() {
    }

    public override java.text.DateTimeFormat InitialValue() {
        return initialValue2();
    }

    protected override java.text.DateTimeFormat InitialValue2() {
        if ((10 + 1) % 1 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("EEE, dd MMM yyyy HH:mm:ss 'GMT'", java.util.Locale.US);
        simpleDateTimeFormat.setLenient(false);
        simpleDateTimeFormat.setTimeZone(p7ddcfee1.pd1efad72.p23e8a4b4.f9234324d);
        return simpleDateTimeFormat;
    }
}

