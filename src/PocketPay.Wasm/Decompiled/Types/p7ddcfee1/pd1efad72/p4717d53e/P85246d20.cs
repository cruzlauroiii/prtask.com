namespace WillowMaze.Wasm.Decompiled;

public class P85246d20
{
    private int F1621e14a;
    private readonly List<object> F31127bc9;
    private readonly List<object> F44bd872b;
    private bool F50b743d0;
    private bool F6871b39b;
    private readonly List<object> F8feac9e4;
    private bool F967624d2;
    private bool Fa4ac337c;
    private int Fae386cd1;
    private bool Fcac82cf3;
    private bool Fd05d0df8;
    private bool Feda86059;
    private readonly List<object> Ff5ff97ac;
    private bool Ff863dddf;

    private bool IsFallbackPossible(SSLSocket P0)
    {
        // call: List<object>.get
        // call: List<object>.size
        // call: p43967033.isCompatible
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.f44bd872b
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.f1621e14a
        return false;
    }

    public p43967033 ConfigureSecureSocket(SSLSocket P0)
    {
        // str: ", modes="
        // str: ", supported protocols="
        // str: "sslSocket"
        // str: "toString(this)"
        // str: "Unable to find acceptable protocols. isFallback="
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNull
        // call: p85246d20.isFallbackPossible
        // call: UnknownServiceException.<init>
        // call: p43967033.isCompatible
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: SSLSocket.getEnabledProtocols
        // call: List<object>.size
        // call: Arrays.toString
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p43967033.apply$okhttp
        // call: List<object>.get
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.ff863dddf
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.fa4ac337c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.f1621e14a
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.f44bd872b
        // type: StringBuilder
        // type: UnknownServiceException
        return default!;
    }

    public bool ConnectionFailed(IOException P0)
    {
        // str: "e"
        // call: IOException.getCause
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.fa4ac337c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p85246d20.ff863dddf
        return false;
    }

}
