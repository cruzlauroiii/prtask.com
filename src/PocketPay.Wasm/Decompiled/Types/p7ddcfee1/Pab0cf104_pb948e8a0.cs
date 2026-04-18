namespace WillowMaze.Wasm.Decompiled;

public class Pab0cf104_pb948e8a0
{
    public static pab0cf104$pb948e8a0$p910eef8c F07db26b5;
    private static string F1f687d48;
    private static string F54234ca4;
    private static string F78fb672b;
    public static pab0cf104$pb948e8a0$p910eef8c F910eef8c;
    private static string Fae34e508;
    private static string Fb242611d;
    private static string Fd6736cc9;
    private readonly string F04d6eb26;
    private readonly p7559811a F098d52c0;
    private readonly p888a77f5 F1fe838f3;
    private readonly long F2c4eb8e8;
    private readonly long F2db04c32;
    private readonly p888a77f5 F2efeac14;
    private readonly int F45f050f4;
    private readonly p883d7615 F48fe2c78;
    private readonly pdfadebdd F4a8fe059;
    private readonly string F4c6c684e;
    private readonly pdfadebdd F572d4e42;
    private readonly p883d7615 F67be67ce;
    private readonly p883d7615 F6afffcd5;
    private readonly string F78e73102;
    private readonly p888a77f5 F7ee700ce;
    private readonly p888a77f5 F81788ba0;
    private readonly long F862dc219;
    private readonly long F87bef6aa;
    private readonly long F97eae8d7;
    private readonly p883d7615 F98896b40;
    private readonly string Fa39c7837;
    private readonly p7559811a Fb62ddf50;
    private readonly p883d7615 Fb8d20eab;
    private readonly pdfadebdd Fb9238d2d;
    private readonly long Fbd62a3f0;
    private readonly string Fbe22de08;
    private readonly p883d7615 Fbe4d2085;
    private readonly int Fc1336794;
    private readonly string Fc40d3ce2;
    private readonly p883d7615 Fc7d646f4;
    private readonly string Fd4bb01be;
    private readonly long Fd9861f36;
    private readonly long Fdc61cc62;
    private readonly p883d7615 Fe357a26f;
    private readonly p888a77f5 Fe3ce5433;
    private readonly p883d7615 Fe70f9e66;
    private readonly long Ff848e811;

    private bool M06b2503f()
    {
        // str: "https"
        // call: Intrinsics.areEqual
        // call: pdfadebdd.scheme
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f572d4e42
        return false;
    }

    private void M69866536(p08d84bc6 P0, List<object> P1)
    {
        // str: "bytes"
        // call: IOException.<init>
        // call: CertificateEncodingException.getMessage
        // call: List<object>.size
        // call: p08d84bc6.writeDecimalLong
        // call: p08d84bc6.writeByte
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Certificate.getEncoded
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p58efa9e8$p910eef8c.m527a6c53
        // call: p58efa9e8.base64
        // call: p08d84bc6.writeUtf8
        // field: p38cb8f46.p58efa9e8.f910eef8c
        // type: IOException
    }

    private List<object> Mde437ff1(pcc81e3f6 P0)
    {
        // str: "X.509"
        // call: CertificateFactory.getInstance
        // call: List<object>.<init>
        // call: pcc81e3f6.readUtf8LineStrict
        // call: p7e62bc34.<init>
        // call: p58efa9e8$p910eef8c.decodeBase64
        // call: Intrinsics.checkNotNull
        // call: p7e62bc34.write
        // call: p7e62bc34.inputStream
        // call: CertificateFactory.generateCertificate
        // call: List<object>.add
        // call: pab0cf104$p910eef8c.readInt$okhttp
        // call: CertificateException.getMessage
        // call: IOException.<init>
        // call: CollectionsKt.emptyList
        // field: p38cb8f46.p58efa9e8.f910eef8c
        // field: p7ddcfee1.pab0cf104.f910eef8c
        // type: List<object>
        // type: p7e62bc34
        // type: IOException
        return default!;
    }

    public bool Matches(p15c2d85f P0, pd64ed3e9 P1)
    {
        // str: "response"
        // str: "request"
        // call: p15c2d85f.url
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        // call: p15c2d85f.method
        // call: pab0cf104$p910eef8c.varyMatches
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f572d4e42
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fa39c7837
        // field: p7ddcfee1.pab0cf104.f910eef8c
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f67be67ce
        return false;
    }

    public pd64ed3e9 Response(pa7af2095$pd4e2713d P0)
    {
        // str: "snapshot"
        // str: "Content-Length"
        // str: "1a88ccc6aef21a176a17b8e80902ff8e74bfaffb13023ea748a86804120358de9c007efb8df1c238"
        // call: pd64ed3e9$p2bd4a59b.handshake
        // call: p15c2d85f$p2bd4a59b.headers
        // call: Intrinsics.checkNotNullParameter
        // call: pd64ed3e9$p2bd4a59b.request
        // call: p15c2d85f$p2bd4a59b.build
        // call: p15c2d85f$p2bd4a59b.url
        // call: pd64ed3e9$p2bd4a59b.code
        // call: pd64ed3e9$p2bd4a59b.<init>
        // call: p15c2d85f$p2bd4a59b.method
        // call: pab0cf104$p450c4800.<init>
        // call: pd64ed3e9$p2bd4a59b.sentRequestAtMillis
        // call: p15c2d85f$p2bd4a59b.<init>
        // call: pd64ed3e9$p2bd4a59b.build
        // call: DecryptString.decryptString
        // call: pd64ed3e9$p2bd4a59b.receivedResponseAtMillis
        // call: p883d7615.get
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: pd64ed3e9$p2bd4a59b.body
        // call: pd64ed3e9$p2bd4a59b.message
        // call: pd64ed3e9$p2bd4a59b.headers
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f67be67ce
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fb62ddf50
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fe70f9e66
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fa39c7837
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f572d4e42
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f97eae8d7
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f81788ba0
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f2db04c32
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f78e73102
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fc1336794
        // type: p15c2d85f$p2bd4a59b
        // type: pd64ed3e9$p2bd4a59b
        // type: pab0cf104$p450c4800
        return default!;
    }

    public void WriteTo(pa7af2095$p344a7f42 P0)
    {
        // str: ": "
        // str: "editor"
        // call: CloseableKt.closeFinally
        // call: p883d7615.name
        // call: p08d84bc6.writeUtf8
        // call: p883d7615.value
        // call: p08d84bc6.writeByte
        // call: p61386e8f.<init>
        // call: p61386e8f.toString
        // call: p883d7615.size
        // call: p08d84bc6.writeDecimalLong
        // call: pab0cf104$pb948e8a0.m06b2503f
        // call: Intrinsics.checkNotNull
        // call: p7559811a.cipherSuite
        // call: p4e56d02a.javaName
        // call: p7559811a.peerCertificates
        // call: pab0cf104$pb948e8a0.m69866536
        // call: p7559811a.localCertificates
        // call: p7559811a.tlsVersion
        // call: p20455456.javaName
        // call: p0af9afa4.m7f2db423
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f67be67ce
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f81788ba0
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fc1336794
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f78e73102
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fe70f9e66
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fae34e508
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f2db04c32
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fd6736cc9
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f97eae8d7
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fb62ddf50
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pab0cf104$pb948e8a0.f572d4e42
        // field: p7ddcfee1.pab0cf104$pb948e8a0.fa39c7837
        // type: p61386e8f
    }

}
