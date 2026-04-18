namespace WillowMaze.Wasm.Decompiled;

public class P24a07cca
{
    private p9405c3af F059541b1;
    private readonly p4f9a1811 F09d7ec30;
    private int F0f99335f;
    private int F18172478;
    private p9405c3af F1cdaa4c1;
    private int F1f5fc048;
    private int F2f2030ff;
    private int F3b540465;
    private readonly pdd7bf230 F3d71dd86;
    private readonly p6d310f89 F3e6fd650;
    private p1e56fe02$p6ff9dd0d F402f58f6;
    private readonly pdd7bf230 F43ee895f;
    private p1e56fe02$p6ff9dd0d F4d63ff13;
    private int F537e339d;
    private readonly p6d310f89 F53b9e967;
    private p9405c3af F54b0b71f;
    private readonly p6d310f89 F5bb192d9;
    private int F67c5e83a;
    private int F6aeea3dd;
    private int F6b5e6e7e;
    private readonly p4f9a1811 F79606237;
    private readonly p6d310f89 F861b3d1b;
    private readonly pdd7bf230 F884d9804;
    private p1e56fe02 F8ea2c51e;
    private readonly pdd7bf230 F90006675;
    private readonly pe5e1ca24 F99874bde;
    private p1e56fe02 Fa6e1fbb2;
    private int Fa90941d5;
    private int Fb2ab433d;
    private p9405c3af Fbab9cc3a;
    private readonly p4f9a1811 Fbf584b38;
    private readonly pdd7bf230 Fc2b2b116;
    private p1e56fe02 Fc46fb630;
    private p1e56fe02$p6ff9dd0d Fc641be2d;
    private readonly pe5e1ca24 Fc75164e7;
    private readonly p4f9a1811 Fd0d628df;
    private int Ff651868a;

    private pc2c7dd60 FindConnection(int P0, int P1, int P2, int P3, bool P4)
    {
        // str: "Check failed."
        // str: "Canceled"
        // call: p4f9a1811.connectionAcquired
        // call: p1e56fe02$p6ff9dd0d.next
        // call: pe5e1ca24.put
        // call: p6d310f89.acquireConnectionNoEvents
        // call: p6d310f89.setConnectionToCancel
        // call: pc2c7dd60.connect
        // call: pc2c7dd60.getNoNewExchanges
        // call: pc2c7dd60.route
        // call: p9405c3af.address
        // call: pdd7bf230.url
        // call: p24a07cca.sameHostAndPort
        // call: p6d310f89.releaseConnectionNoEvents$okhttp
        // call: p6d310f89.isCanceled
        // call: pe5e1ca24.callAcquirePooledConnection
        // call: p23e8a4b4.closeQuietly
        // call: p4f9a1811.connectionReleased
        // call: Intrinsics.checkNotNull
        // call: p6d310f89.getClient
        // call: object.toString
        // call: pc2c7dd60.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f99874bde
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f53b9e967
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f884d9804
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f4d63ff13
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.fa90941d5
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f8ea2c51e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1f5fc048
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1cdaa4c1
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f0f99335f
        // type: pc2c7dd60
        // type: IllegalStateException
        // type: IOException
        // type: p1e56fe02
        return default!;
    }

    private pc2c7dd60 FindHealthyConnection(int P0, int P1, int P2, int P3, bool P4, bool P5)
    {
        // str: "exhausted all routes"
        // call: p24a07cca.findConnection
        // call: pc2c7dd60.noNewExchanges$okhttp
        // call: p1e56fe02$p6ff9dd0d.hasNext
        // call: p1e56fe02.hasNext
        // call: pc2c7dd60.isHealthy
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f8ea2c51e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1cdaa4c1
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f4d63ff13
        // type: IOException
        return default!;
    }

    private p9405c3af RetryRoute()
    {
        // call: pc2c7dd60.route
        // call: p9405c3af.address
        // call: pdd7bf230.url
        // call: p24a07cca.getAddress$okhttp
        // call: p23e8a4b4.canReuseConnectionFor
        // call: p6d310f89.getConnection
        // call: pc2c7dd60.getRouteFailureCount$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f53b9e967
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f0f99335f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.fa90941d5
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1f5fc048
        return default!;
    }

    public p6eed9b4c Find(p1cda7fcc P0, pf1d5187f P1)
    {
        // str: "GET"
        // str: "client"
        // str: "chain"
        // call: Intrinsics.checkNotNullParameter
        // call: pf1d5187f.getConnectTimeoutMillis$okhttp
        // call: pf1d5187f.getReadTimeoutMillis$okhttp
        // call: pf1d5187f.getWriteTimeoutMillis$okhttp
        // call: p1cda7fcc.pingIntervalMillis
        // call: p1cda7fcc.retryOnConnectionFailure
        // call: pf1d5187f.getRequest$okhttp
        // call: p15c2d85f.method
        // call: Intrinsics.areEqual
        // call: p0a57af34.getLastConnectException
        // call: p0a57af34.<init>
        // call: p24a07cca.findHealthyConnection
        // call: pc2c7dd60.newCodec$okhttp
        // call: p24a07cca.trackFailure
        // type: p0a57af34
        return default!;
    }

    public pdd7bf230 GetAddress$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f884d9804
        return default!;
    }

    public bool RetryAfterFailure()
    {
        // call: p24a07cca.retryRoute
        // call: p1e56fe02$p6ff9dd0d.hasNext
        // call: p1e56fe02.hasNext
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1cdaa4c1
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1f5fc048
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f0f99335f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.fa90941d5
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f8ea2c51e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f4d63ff13
        return false;
    }

    public bool SameHostAndPort(pdfadebdd P0)
    {
        // str: "url"
        // call: pdfadebdd.port
        // call: pdd7bf230.url
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        // call: pdfadebdd.host
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f884d9804
        return false;
    }

    public void TrackFailure(IOException P0)
    {
        // str: "e"
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f0f99335f
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1f5fc048
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78.f0279985c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.fa90941d5
        // field: p7ddcfee1.pd1efad72.p4717d53e.p24a07cca.f1cdaa4c1
    }

}
