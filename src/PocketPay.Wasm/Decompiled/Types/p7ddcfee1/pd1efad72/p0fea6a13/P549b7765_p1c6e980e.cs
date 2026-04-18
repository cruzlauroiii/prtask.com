namespace WillowMaze.Wasm.Decompiled;

public class P549b7765_p1c6e980e
{
    private string F019f17ad;
    private int F055e8540;
    private DateTime F09bcb72d;
    private readonly p15c2d85f F10573b87;
    private string F1872ade8;
    private long F18e1063d;
    private readonly long F23065318;
    private DateTime F255c7686;
    private long F2db04c32;
    private readonly long F2e5a4bc1;
    private readonly long F37b1e688;
    private readonly pd64ed3e9 F3bbf24b2;
    private DateTime F3da9cd45;
    private readonly p15c2d85f F3e54d669;
    private int F40c48310;
    private DateTime F45600599;
    private string F45a16c07;
    private string F46982c3f;
    private DateTime F56d4ce3a;
    private string F5c0e72cc;
    private readonly pd64ed3e9 F6453e8ca;
    private readonly long F66fb508a;
    private readonly p15c2d85f F6b4d73a0;
    private readonly p15c2d85f F6dd6dbf7;
    private readonly pd64ed3e9 F786a471b;
    private long F809719b3;
    private string F879d032d;
    private long F8d3b0c3c;
    private long F97eae8d7;
    private long F987b1d4c;
    private readonly pd64ed3e9 F9d83d7bd;
    private string F9d9140ba;
    private string Faf406009;
    private readonly p15c2d85f Fc98c19b8;
    private readonly long Fca2b7405;
    private long Fd54c23e3;
    private DateTime Fd9e2a7f7;
    private DateTime Fe0ad6ec0;
    private DateTime Ff11514b0;

    private long CacheResponseAge()
    {
        // call: Math.max
        // call: DateTime.getTime
        // call: TimeUnit.toMillis
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f97eae8d7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f2e5a4bc1
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f2db04c32
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f40c48310
        // field: java.util.concurrent.TimeUnit.SECONDS
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f255c7686
        return 0;
    }

    private p549b7765 ComputeCandidate()
    {
        // str: "Warning"
        // str: "If-Modified-Since"
        // str: "If-None-Match"
        // str: "110 HttpURLConnection \"Response is stale\""
        // str: "113 HttpURLConnection \"Heuristic expiration\""
        // call: p9499572d.maxAgeSeconds
        // call: p549b7765.<init>
        // call: TimeUnit.toMillis
        // call: p549b7765$p1c6e980e.hasConditions
        // call: pd64ed3e9.handshake
        // call: Math.min
        // call: p9499572d.noCache
        // call: p15c2d85f.cacheControl
        // call: p9499572d.maxStaleSeconds
        // call: p9499572d.minFreshSeconds
        // call: p883d7615$p2bd4a59b.build
        // call: p549b7765$p1c6e980e.isFreshnessLifetimeHeuristic
        // call: p15c2d85f.isHttps
        // call: p15c2d85f$p2bd4a59b.headers
        // call: p9499572d.mustRevalidate
        // call: pd64ed3e9$p2bd4a59b.addHeader
        // call: p15c2d85f.headers
        // call: pd64ed3e9.cacheControl
        // call: pd64ed3e9.newBuilder
        // call: p549b7765$p910eef8c.isCacheable
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f10573b87
        // field: java.util.concurrent.TimeUnit.SECONDS
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f6453e8ca
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f019f17ad
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765.f910eef8c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f56d4ce3a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f255c7686
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f1872ade8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f879d032d
        // type: p549b7765
        return default!;
    }

    private long ComputeFreshnessLifetime()
    {
        // call: long.longValue
        // call: p15c2d85f.url
        // call: p9499572d.maxAgeSeconds
        // call: long.valueOf
        // call: DateTime.getTime
        // call: pd64ed3e9.cacheControl
        // call: pd64ed3e9.request
        // call: TimeUnit.toMillis
        // call: pdfadebdd.query
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f56d4ce3a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f09bcb72d
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f6453e8ca
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f97eae8d7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f255c7686
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f2db04c32
        // field: java.util.concurrent.TimeUnit.SECONDS
        return 0;
    }

    private bool HasConditions(p15c2d85f P0)
    {
        // str: "If-Modified-Since"
        // str: "If-None-Match"
        // call: p15c2d85f.header
        return false;
    }

    private bool IsFreshnessLifetimeHeuristic()
    {
        // call: pd64ed3e9.cacheControl
        // call: Intrinsics.checkNotNull
        // call: p9499572d.maxAgeSeconds
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f6453e8ca
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f09bcb72d
        return false;
    }

    public p549b7765 Compute()
    {
        // call: p9499572d.onlyIfCached
        // call: p549b7765.<init>
        // call: p15c2d85f.cacheControl
        // call: p549b7765$p1c6e980e.computeCandidate
        // call: p549b7765.getNetworkRequest
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f10573b87
        // type: p549b7765
        return default!;
    }

    public p15c2d85f GetRequest$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.p549b7765$p1c6e980e.f10573b87
        return default!;
    }

}
