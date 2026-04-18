namespace WillowMaze.Wasm.Decompiled;

public class P2d7dd516 : P3948d67c
{
    private readonly p4d3cc87f F0b1bda14;
    private readonly p4d3cc87f F273263ff;
    private readonly p4d3cc87f F4c6d25ba;
    private readonly p4d3cc87f F6f839eb5;
    private readonly p4d3cc87f Feb0b39e7;

    private InetAddress ConnectToInetAddress(Proxy P0, pdfadebdd P1, p4d3cc87f P2)
    {
        // str: "address() as InetSocketAddress).address"
        // str: "null cannot be cast to non-null type java.net.InetSocketAddress"
        // call: pdfadebdd.host
        // call: Proxy.address
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Proxy$Type.ordinal
        // call: p4d3cc87f.lookup
        // call: CollectionsKt.first
        // call: NullPointerException.<init>
        // call: Proxy.type
        // call: InetSocketAddress.getAddress
        // field: p7ddcfee1.pd1efad72.p725d9197.p2d7dd516$p12c674ac.$EnumSwitchMapping$0
        // type: NullPointerException
        return default!;
    }

    public p15c2d85f Authenticate(p9405c3af P0, pd64ed3e9 P1)
    {
        // str: "06a7e99cbae1ce6d315e512e1be1641e3ba61edde8ae4fdb0acd26e79c40bfb494d0350d358248833a"
        // str: "auth.userName"
        // str: "Proxy-Authorization"
        // str: "auth.password"
        // str: "response"
        // str: "null cannot be cast to non-null type java.net.InetSocketAddress"
        // str: "Basic"
        // str: "proxy"
        // call: pdfadebdd.url
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pd64ed3e9.code
        // call: List<object>.iterator
        // call: pd64ed3e9.request
        // call: pdfadebdd.scheme
        // call: pdfadebdd.host
        // call: DecryptString.decryptString
        // call: StringsKt.equals
        // call: PasswordAuthentication.getUserName
        // call: NullPointerException.<init>
        // call: pb5f5623b.charset
        // call: Authenticator.requestPasswordAuthentication
        // call: InetSocketAddress.getPort
        // call: pdfadebdd.port
        // call: pb5f5623b.scheme
        // call: p15c2d85f$p2bd4a59b.header
        // call: string.<init>
        // call: PasswordAuthentication.getPassword
        // call: p15c2d85f$p2bd4a59b.build
        // field: java.net.Proxy.NO_PROXY
        // field: java.net.Authenticator$RequestorType.PROXY
        // field: p7ddcfee1.pd1efad72.p725d9197.p2d7dd516.feb0b39e7
        // field: java.net.Authenticator$RequestorType.SERVER
        // type: NullPointerException
        // type: string
        return default!;
    }

}
