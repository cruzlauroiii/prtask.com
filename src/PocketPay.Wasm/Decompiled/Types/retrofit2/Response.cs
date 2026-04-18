namespace WillowMaze.Wasm.Decompiled;

public class Response
{
    private readonly object F010cb34e;
    private readonly pd64ed3e9 F1cefc750;
    private readonly pd64ed3e9 F51767d15;
    private readonly pd64ed3e9 F7fc1d3de;
    private readonly object F8101e116;
    private readonly object F841a2d68;
    private readonly p42c567ea F87119001;
    private readonly p42c567ea Fac67ca95;
    private readonly object Faf00bae1;
    private readonly p42c567ea Fb7ecd278;
    private readonly pd64ed3e9 Fbf3695cc;
    private readonly pd64ed3e9 Fc348aa61;
    private readonly p42c567ea Fdc26dd6c;
    private readonly p42c567ea Fe7089c00;

    public static Response Error(int P0, p42c567ea P1)
    {
        // str: "body == null"
        // str: "http://localhost/"
        // str: "Response.error()"
        // str: "code < 400: "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: p42c567ea.contentType
        // call: Response.error
        // call: p15c2d85f$p2bd4a59b.build
        // call: Objects.requireNonNull
        // call: StringBuilder.append
        // call: pd64ed3e9$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: pd64ed3e9$p2bd4a59b.body
        // call: p42c567ea.contentLength
        // call: pd64ed3e9$p2bd4a59b.message
        // call: IllegalArgumentException.<init>
        // call: pd64ed3e9$p2bd4a59b.request
        // call: p15c2d85f$p2bd4a59b.url
        // call: pd64ed3e9$p2bd4a59b.code
        // call: pf83fabfe$p16890fbe.<init>
        // call: p15c2d85f$p2bd4a59b.<init>
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // type: pf83fabfe$p16890fbe
        // type: StringBuilder
        // type: p15c2d85f$p2bd4a59b
        // type: IllegalArgumentException
        // type: pd64ed3e9$p2bd4a59b
        return default!;
    }

    public static Response Error(p42c567ea P0, pd64ed3e9 P1)
    {
        // str: "body == null"
        // str: "rawResponse should not be successful response"
        // str: "rawResponse == null"
        // call: Objects.requireNonNull
        // call: pd64ed3e9.isSuccessful
        // call: IllegalArgumentException.<init>
        // call: Response.<init>
        // type: Response
        // type: IllegalArgumentException
        return default!;
    }

    public static Response Success(int P0, object P1)
    {
        // str: "http://localhost/"
        // str: "code < 200 or >= 300: "
        // str: "Response.success()"
        // call: p15c2d85f$p2bd4a59b.url
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: StringBuilder.<init>
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pd64ed3e9$p2bd4a59b.build
        // call: p15c2d85f$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.request
        // call: p15c2d85f$p2bd4a59b.<init>
        // call: Response.success
        // call: IllegalArgumentException.<init>
        // call: pd64ed3e9$p2bd4a59b.code
        // call: pd64ed3e9$p2bd4a59b.message
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // type: pd64ed3e9$p2bd4a59b
        // type: p15c2d85f$p2bd4a59b
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    public static Response Success(object P0)
    {
        // str: "OK"
        // str: "http://localhost/"
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: pd64ed3e9$p2bd4a59b.build
        // call: p15c2d85f$p2bd4a59b.<init>
        // call: p15c2d85f$p2bd4a59b.build
        // call: Response.success
        // call: pd64ed3e9$p2bd4a59b.message
        // call: p15c2d85f$p2bd4a59b.url
        // call: pd64ed3e9$p2bd4a59b.code
        // call: pd64ed3e9$p2bd4a59b.request
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // type: pd64ed3e9$p2bd4a59b
        // type: p15c2d85f$p2bd4a59b
        return default!;
    }

    public static Response Success(object P0, p883d7615 P1)
    {
        // str: "OK"
        // str: "http://localhost/"
        // str: "headers == null"
        // call: Objects.requireNonNull
        // call: pd64ed3e9$p2bd4a59b.request
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: p15c2d85f$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.headers
        // call: p15c2d85f$p2bd4a59b.url
        // call: pd64ed3e9$p2bd4a59b.code
        // call: p15c2d85f$p2bd4a59b.<init>
        // call: Response.success
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: pd64ed3e9$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.message
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // type: p15c2d85f$p2bd4a59b
        // type: pd64ed3e9$p2bd4a59b
        return default!;
    }

    public static Response Success(object P0, pd64ed3e9 P1)
    {
        // str: "rawResponse == null"
        // str: "rawResponse must be successful response"
        // call: Objects.requireNonNull
        // call: Response.<init>
        // call: IllegalArgumentException.<init>
        // call: pd64ed3e9.isSuccessful
        // type: IllegalArgumentException
        // type: Response
        return default!;
    }

    public object Body()
    {
        // field: retrofit2.Response.f841a2d68
        return default!;
    }

    public int Code()
    {
        // call: pd64ed3e9.code
        // field: retrofit2.Response.fc348aa61
        return 0;
    }

    public p42c567ea ErrorBody()
    {
        // field: retrofit2.Response.fdc26dd6c
        return default!;
    }

    public p883d7615 Headers()
    {
        // call: pd64ed3e9.headers
        // field: retrofit2.Response.fc348aa61
        return default!;
    }

    public bool IsSuccessful()
    {
        // call: pd64ed3e9.isSuccessful
        // field: retrofit2.Response.fc348aa61
        return false;
    }

    public string Message()
    {
        // call: pd64ed3e9.message
        // field: retrofit2.Response.fc348aa61
        return string.Empty;
    }

    public pd64ed3e9 Raw()
    {
        // field: retrofit2.Response.fc348aa61
        return default!;
    }

    public string ToString()
    {
        // call: pd64ed3e9.toString
        // field: retrofit2.Response.fc348aa61
        return string.Empty;
    }

}
