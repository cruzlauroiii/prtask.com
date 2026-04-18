namespace WillowMaze.Wasm.Decompiled;

public class Pc2c7dd60 : P2d68e184$p0c951aa4, Pc2cc7082
{
    private static int F03c8bffe;
    private static int F11f6ca2c;
    public static long F14da7fd8;
    public static pc2c7dd60$p910eef8c F1a63bb1b;
    private static string F50445feb;
    public static pc2c7dd60$p910eef8c F67902280;
    public static long F69b379a0;
    private static string F6d367104;
    public static pc2c7dd60$p910eef8c F910eef8c;
    public static pc2c7dd60$p910eef8c F92aef518;
    public static long F9573411a;
    public static long Fa2a21732;
    private int F01f3b538;
    private bool F0543ce99;
    private int F0d8f2499;
    private int F0ddbee1d;
    private int F0f99335f;
    private Socket F1388492f;
    private p2d68e184 F15f54d8c;
    private Socket F1639f777;
    private bool F1f51ecec;
    private readonly p9405c3af F25dfe2ed;
    private int F26392cf6;
    private bool F30ea4479;
    private pcc81e3f6 F36cd38f4;
    private Socket F390f8142;
    private p08d84bc6 F3b701436;
    private bool F3bc2d630;
    private int F3e4e9684;
    private p7559811a F428766ff;
    private int F45886695;
    private Socket F61f25293;
    private readonly List<object> F71b1b67f;
    private p888a77f5 F81788ba0;
    private long F84d27b21;
    private int F8af6fe8d;
    private p2d68e184 F8d800815;
    private long F919f9822;
    private readonly pe5e1ca24 F92db4171;
    private bool F95475eb2;
    private readonly pe5e1ca24 F99874bde;
    private readonly pe5e1ca24 F9aa6c604;
    private readonly p9405c3af F9c46408a;
    private int Fa0b65a58;
    private Socket Fa50d1458;
    private pcc81e3f6 Fa76cf4a4;
    private p08d84bc6 Fa7d5ab76;
    private int Fa8c751a2;
    private int Fb16715b6;
    private readonly pe5e1ca24 Fb17350e4;
    private Socket Fb336b78b;
    private p2d68e184 Fb543e5e3;
    private p7559811a Fb62ddf50;
    private p08d84bc6 Fb9319152;
    private Socket Fbdfc39df;
    private bool Fc47a3925;
    private p888a77f5 Fc86e631a;
    private Socket Fd70d9a38;
    private long Fda2bfd22;
    private p08d84bc6 Feeeb9b16;
    private int Ff1af8b47;
    private readonly List<object> Ff2bb91e8;
    private int Ff30994c5;
    private int Ff3f653c2;
    private p08d84bc6 Ff6e04117;
    private bool Ff871a820;
    private int Ffa584c55;
    private int Fff37afed;

    public static p7559811a Access$getHandshake$p(pc2c7dd60 P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        return default!;
    }

    public static void Access$setSocket$p(pc2c7dd60 P0, Socket P1)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
    }

    private bool CertificateSupportHost(pdfadebdd P0, p7559811a P1)
    {
        // call: pc10505ac.verify
        // call: List<object>.get
        // call: p7559811a.peerCertificates
        // call: ICollection<object>.isEmpty
        // call: pdfadebdd.host
        // field: p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
        return false;
    }

    private void ConnectSocket(int P0, int P1, pc3755e61 P2, p4f9a1811 P3)
    {
        // str: "Failed to connect to "
        // str: "93b556c44590b1cf7901f680dfdb39836923501f299d15cf02c5c352faffc38964086d5b2c8e5ac50fd605f0cef7b6b90..."
        // call: pdd7bf230.socketFactory
        // call: Intrinsics.areEqual
        // call: Proxy$Type.ordinal
        // call: p9405c3af.socketAddress
        // call: p9405c3af.proxy
        // call: IOException.<init>
        // call: Socket.<init>
        // call: SocketFactory.createSocket
        // call: ConnectException.initCause
        // call: p9405c3af.address
        // call: Intrinsics.stringPlus
        // call: ConnectException.<init>
        // call: Proxy.type
        // call: DecryptString.decryptString
        // call: p4f9a1811.connectStart
        // call: NullPointerException.getMessage
        // call: Socket.setSoTimeout
        // call: p419f3742$p910eef8c.get
        // call: p419f3742.connectSocket
        // call: p0af9afa4.m36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p12c674ac.$EnumSwitchMapping$0
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // type: IOException
        // type: ConnectException
        // type: Socket
    }

    private void ConnectTls(p85246d20 P0)
    {
        // str: "Hostname "
        // str: "null cannot be cast to non-null type javax.net.ssl.SSLSocket"
        // str: "\n              |Hostname "
        // str: "sslSocketSession"
        // str: " not verified:\n              |    certificate: "
        // str: "\n              |    DN: "
        // str: "\n              |    subjectAltNames: "
        // str: "\n              "
        // str: " not verified (no certificates)"
        // call: p23e8a4b4.closeQuietly
        // call: p419f3742$p910eef8c.get
        // call: p419f3742.afterHandshake
        // call: pdd7bf230.sslSocketFactory
        // call: p9405c3af.address
        // call: NullPointerException.<init>
        // call: Intrinsics.checkNotNull
        // call: pdd7bf230.url
        // call: pdfadebdd.host
        // call: pdfadebdd.port
        // call: SSLSocketFactory.createSocket
        // call: p85246d20.configureSecureSocket
        // call: p43967033.supportsTlsExtensions
        // call: pdd7bf230.protocols
        // call: p419f3742.configureTlsExtensions
        // call: SSLSocket.startHandshake
        // call: SSLSocket.getSession
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p7559811a$p910eef8c.get
        // call: pdd7bf230.hostnameVerifier
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.p7559811a.f910eef8c
        // field: p7ddcfee1.pd299aac3.f910eef8c
        // field: p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // field: p7ddcfee1.p888a77f5.f910eef8c
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f81788ba0
        // type: NullPointerException
        // type: SSLPeerUnverifiedException
        // type: StringBuilder
        // type: p7559811a
        // type: pc2c7dd60$p81691516$1
        // type: pc2c7dd60$p81691516$2
    }

    private void ConnectTunnel(int P0, int P1, int P2, pc3755e61 P3, p4f9a1811 P4)
    {
        // call: p23e8a4b4.closeQuietly
        // call: p9405c3af.socketAddress
        // call: pc2c7dd60.connectSocket
        // call: p15c2d85f.url
        // call: pc2c7dd60.createTunnel
        // call: p9405c3af.proxy
        // call: pc2c7dd60.createTunnelRequest
        // call: p4f9a1811.connectEnd
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
    }

    private p15c2d85f CreateTunnel(int P0, int P1, p15c2d85f P2, pdfadebdd P3)
    {
        // str: "close"
        // str: "CONNECT "
        // str: "TLS tunnel buffered too many bytes!"
        // str: "Unexpected response code for CONNECT: "
        // str: "Failed to authenticate with proxy"
        // str: "Connection"
        // str: " HTTP/1.1"
        // call: pd64ed3e9$p2bd4a59b.request
        // call: IOException.<init>
        // call: p2bfb7a6c.skipConnectBody
        // call: p08d84bc6.getBuffer
        // call: Intrinsics.checkNotNull
        // call: pd64ed3e9$p2bd4a59b.build
        // call: pd64ed3e9.m28ab1449
        // call: pc85a251c.timeout
        // call: pd64ed3e9.code
        // call: p08d84bc6.timeout
        // call: p7e62bc34.exhausted
        // call: pcc81e3f6.getBuffer
        // call: StringBuilder.append
        // call: p3948d67c.authenticate
        // call: StringsKt.equals
        // call: StringBuilder.toString
        // call: p15c2d85f.headers
        // call: pdd7bf230.proxyAuthenticator
        // call: p2bfb7a6c.finishRequest
        // call: pcc81e3f6.timeout
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // type: IOException
        // type: p2bfb7a6c
        // type: StringBuilder
        return default!;
    }

    private p15c2d85f CreateTunnelRequest()
    {
        // str: "Host"
        // str: "CONNECT"
        // str: "2c3d348973d859aa8d03d4750831bcb7d71b3172e0809b7965d849aa8686e1908ff16c139de6"
        // str: "Proxy-Authenticate"
        // str: "OkHttp-Preemptive"
        // str: "a36629de06e8f369b1aa17d6a7049452239847cddbaaffd6a2bcc8c402fabd022af50458b4c2eac1c0"
        // str: "Proxy-Connection"
        // str: "Keep-Alive"
        // str: "Preemptive Authenticate"
        // call: pd64ed3e9$p2bd4a59b.message
        // call: p15c2d85f$p2bd4a59b.header
        // call: p9405c3af.address
        // call: pd64ed3e9$p2bd4a59b.protocol
        // call: pd64ed3e9$p2bd4a59b.code
        // call: p15c2d85f$p2bd4a59b.build
        // call: pd64ed3e9$p2bd4a59b.receivedResponseAtMillis
        // call: pdd7bf230.url
        // call: p15c2d85f$p2bd4a59b.<init>
        // call: pd64ed3e9$p2bd4a59b.header
        // call: p23e8a4b4.toHostHeader
        // call: p3948d67c.authenticate
        // call: p15c2d85f$p2bd4a59b.url
        // call: pdd7bf230.proxyAuthenticator
        // call: p15c2d85f$p2bd4a59b.method
        // call: pd64ed3e9$p2bd4a59b.request
        // call: pd64ed3e9$p2bd4a59b.body
        // call: pd64ed3e9$p2bd4a59b.sentRequestAtMillis
        // call: pd64ed3e9$p2bd4a59b.build
        // call: DecryptString.decryptString
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fafc9db28
        // type: pd64ed3e9$p2bd4a59b
        // type: p15c2d85f$p2bd4a59b
        return default!;
    }

    private void EstablishProtocol(p85246d20 P0, int P1, pc3755e61 P2, p4f9a1811 P3)
    {
        // call: p4f9a1811.secureConnectStart
        // call: pc2c7dd60.startHttp2
        // call: p9405c3af.address
        // call: List<object>.contains
        // call: pdd7bf230.sslSocketFactory
        // call: p4f9a1811.secureConnectEnd
        // call: pdd7bf230.protocols
        // call: pc2c7dd60.connectTls
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.p888a77f5.fd1ea3abb
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f81788ba0
        // field: p7ddcfee1.p888a77f5.f5f1f9932
        // field: p7ddcfee1.p888a77f5.ffcc32a7a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
    }

    private bool RouteMatchesAny(List<object> P0)
    {
        // call: p9405c3af.proxy
        // call: IEnumerable<object>.iterator
        // call: Proxy.type
        // call: ICollection<object>.isEmpty
        // call: p9405c3af.socketAddress
        // call: Intrinsics.areEqual
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // field: java.net.Proxy$Type.DIRECT
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        return false;
    }

    private void StartHttp2(int P0)
    {
        // call: Intrinsics.checkNotNull
        // call: pf4f70727.getMaxConcurrentStreams
        // call: p9405c3af.address
        // call: pdfadebdd.host
        // call: p2d68e184$p2bd4a59b.build
        // call: p2d68e184$p2bd4a59b.pingIntervalMillis
        // call: p2d68e184$p2bd4a59b.listener
        // call: p2d68e184$p2bd4a59b.socket
        // call: Socket.setSoTimeout
        // call: pdd7bf230.url
        // call: p2d68e184.start$default
        // call: p2d68e184$p910eef8c.getDEFAULT_SETTINGS
        // call: p2d68e184$p2bd4a59b.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ffa584c55
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        // field: p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f76425f17
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // type: p2d68e184$p2bd4a59b
    }

    private bool SupportsUrl(pdfadebdd P0)
    {
        // str: " MUST hold lock on "
        // str: "Thread "
        // call: pc2c7dd60.certificateSupportHost
        // call: Thread.getName
        // call: Thread.holdsLock
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNull
        // call: AssertionError.<init>
        // call: pdfadebdd.port
        // call: Thread.currentThread
        // call: Intrinsics.areEqual
        // call: StringBuilder.<init>
        // call: pdfadebdd.host
        // call: p9405c3af.address
        // call: pdd7bf230.url
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f3bc2d630
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        // type: AssertionError
        // type: StringBuilder
        return false;
    }

    public void Cancel()
    {
        // call: p23e8a4b4.closeQuietly
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
    }

    public void Connect(int P0, int P1, int P2, int P3, bool P4, pc3755e61 P5, p4f9a1811 P6)
    {
        // str: "Too many tunnel connections attempted: 21"
        // str: "CLEARTEXT communication to "
        // str: "call"
        // str: "H2_PRIOR_KNOWLEDGE cannot be used with HTTPS"
        // str: "eventListener"
        // str: "already connected"
        // str: " not permitted by network security policy"
        // str: "CLEARTEXT communication not enabled for client"
        // call: p9405c3af.proxy
        // call: List<object>.contains
        // call: StringBuilder.append
        // call: p9405c3af.address
        // call: pc2c7dd60.connectTunnel
        // call: p0a57af34.<init>
        // call: p85246d20.<init>
        // call: p419f3742$p910eef8c.get
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // call: UnknownServiceException.<init>
        // call: p9405c3af.requiresTunnel
        // call: p0a57af34.addConnectException
        // call: pdd7bf230.url
        // call: p4f9a1811.connectFailed
        // call: IllegalStateException.<init>
        // call: System.nanoTime
        // call: p23e8a4b4.closeQuietly
        // call: pdfadebdd.host
        // call: p85246d20.connectionFailed
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.p888a77f5.ffcc32a7a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f81788ba0
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fda2bfd22
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ffa584c55
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.p43967033.f947e023d
        // type: p0a57af34
        // type: StringBuilder
        // type: UnknownServiceException
        // type: p85246d20
        // type: IllegalStateException
        // type: ProtocolException
    }

    public void ConnectFailed$okhttp(p1cda7fcc P0, p9405c3af P1, IOException P2)
    {
        // str: "failure"
        // str: "failedRoute"
        // str: "client"
        // call: Intrinsics.checkNotNullParameter
        // call: p1cda7fcc.getRouteDatabase
        // call: pe81f325d.failed
        // call: pdd7bf230.url
        // call: pdfadebdd.uri
        // call: p9405c3af.proxy
        // call: pdd7bf230.proxySelector
        // call: ProxySelector.connectFailed
        // call: Proxy.type
        // call: Proxy.address
        // call: p9405c3af.address
        // field: java.net.Proxy$Type.DIRECT
    }

    public List<object> GetCalls()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff2bb91e8
        return default!;
    }

    public pe5e1ca24 GetConnectionPool()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f99874bde
        return default!;
    }

    public long GetIdleAtNs$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fda2bfd22
        return 0;
    }

    public bool GetNoNewExchanges()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f1f51ecec
        return false;
    }

    public int GetRouteFailureCount$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fff37afed
        return 0;
    }

    public p7559811a Handshake()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        return default!;
    }

    public void IncrementSuccessCount$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f0d8f2499
    }

    public bool IsEligible$okhttp(pdd7bf230 P0, List<object> P1)
    {
        // str: " MUST hold lock on "
        // str: "address"
        // str: "Thread "
        // call: Thread.holdsLock
        // call: pdfadebdd.host
        // call: pc2c7dd60.route
        // call: pdd7bf230.url
        // call: p9405c3af.address
        // call: pdd7bf230.hostnameVerifier
        // call: pdd7bf230.certificatePinner
        // call: Intrinsics.checkNotNull
        // call: pc2c7dd60.handshake
        // call: p7559811a.peerCertificates
        // call: pd299aac3.check
        // call: pc2c7dd60.routeMatchesAny
        // call: pdd7bf230.equalsNonHost$okhttp
        // call: StringBuilder.append
        // call: List<object>.size
        // call: Thread.currentThread
        // call: Thread.getName
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Intrinsics.areEqual
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff2bb91e8
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        // field: p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f1f51ecec
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ffa584c55
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // type: AssertionError
        // type: StringBuilder
        return false;
    }

    public bool IsHealthy(bool P0)
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // call: Socket.isOutputShutdown
        // call: StringBuilder.<init>
        // call: AssertionError.<init>
        // call: pc2c7dd60.getIdleAtNs$okhttp
        // call: StringBuilder.append
        // call: p23e8a4b4.isHealthy
        // call: System.nanoTime
        // call: Socket.isClosed
        // call: Thread.currentThread
        // call: Intrinsics.checkNotNull
        // call: Socket.isInputShutdown
        // call: Thread.getName
        // call: p2d68e184.isHealthy
        // call: StringBuilder.toString
        // call: Thread.holdsLock
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f390f8142
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // type: StringBuilder
        // type: AssertionError
        return false;
    }

    public bool IsMultiplexed$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        return false;
    }

    public p6eed9b4c NewCodec$okhttp(p1cda7fcc P0, pf1d5187f P1)
    {
        // str: "client"
        // str: "chain"
        // call: Intrinsics.checkNotNullParameter
        // call: p2bfb7a6c.<init>
        // call: Intrinsics.checkNotNull
        // call: pf1d5187f.readTimeoutMillis
        // call: pf1d5187f.getWriteTimeoutMillis$okhttp
        // call: pc85a251c.timeout
        // call: p08d84bc6.timeout
        // call: p900e8231.<init>
        // call: pcc81e3f6.timeout
        // call: Socket.setSoTimeout
        // call: pf1d5187f.getReadTimeoutMillis$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: java.util.concurrent.TimeUnit.MILLISECONDS
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb543e5e3
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // type: p2bfb7a6c
        // type: p900e8231
        return default!;
    }

    public p3ee6e472$p21b3cb64 NewWebSocketStreams$okhttp(p992374d8 P0)
    {
        // str: "exchange"
        // call: pc2c7dd60.noNewExchanges$okhttp
        // call: pc2c7dd60$p8e9eb110$1.<init>
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullParameter
        // call: Socket.setSoTimeout
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ff6e04117
        // type: pc2c7dd60$p8e9eb110$1
        return default!;
    }

    public void NoCoalescedConnections$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f3bc2d630
    }

    public void NoNewExchanges$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f1f51ecec
    }

    public void OnSettings(p2d68e184 P0, pf4f70727 P1)
    {
        // str: "connection"
        // str: "settings"
        // call: Intrinsics.checkNotNullParameter
        // call: pf4f70727.getMaxConcurrentStreams
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.ffa584c55
    }

    public void OnStream(p87a6e6e6 P0)
    {
        // str: "stream"
        // call: Intrinsics.checkNotNullParameter
        // call: p87a6e6e6.close
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
    }

    public p888a77f5 Protocol()
    {
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f81788ba0
        return default!;
    }

    public p9405c3af Route()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        return default!;
    }

    public void SetIdleAtNs$okhttp(long P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fda2bfd22
    }

    public void SetNoNewExchanges(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f1f51ecec
    }

    public void SetRouteFailureCount$okhttp(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fff37afed
    }

    public Socket Socket()
    {
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f61f25293
        return default!;
    }

    public string ToString()
    {
        // str: " hostAddress="
        // str: " protocol="
        // str: "08cf4ed7854189c673ccf35da5df5c08f609057dca9717deee66aee7ef543047"
        // str: ", proxy="
        // str: "Connection{"
        // str: " cipherSuite="
        // call: StringBuilder.append
        // call: pdd7bf230.url
        // call: DecryptString.decryptString
        // call: pdfadebdd.host
        // call: p9405c3af.address
        // call: pdfadebdd.port
        // call: p9405c3af.socketAddress
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p9405c3af.proxy
        // call: p7559811a.cipherSuite
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f81788ba0
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fb62ddf50
        // type: StringBuilder
        return string.Empty;
    }

    public void TrackFailure$okhttp(p6d310f89 P0, IOException P1)
    {
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: p6d310f89.isCanceled
        // call: pc2c7dd60.isMultiplexed$okhttp
        // call: p6d310f89.getClient
        // call: pc2c7dd60.connectFailed$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78.f0279985c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f0f99335f
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f1f51ecec
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.fff37afed
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f0d8f2499
        // field: p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f9c46408a
    }

}
