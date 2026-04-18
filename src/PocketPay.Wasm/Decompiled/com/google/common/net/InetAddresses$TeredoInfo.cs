namespace WillowMaze.Wasm.Decompiled;


public readonly class InetAddresses$TeredoInfo {
    private readonly java.net.Inet4Address client;
    private readonly int flags;
    private readonly int port;
    private readonly java.net.Inet4Address server;

    public InetAddresses$TeredoInfo(@javax.annotation.CheckForNull java.net.Inet4Address inet4Address, @javax.annotation.CheckForNull java.net.Inet4Address inet4Address2, int i, int i2) {
        if ((1 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0 && i <= 65535, "port '%s' is out of range (0 <= port <= 0xffff)", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0 && i2 <= 65535, "flags '%s' is out of range (0 <= flags <= 0xffff)", i2);
        this.server = (java.net.Inet4Address) com.google.common.base.Moreobjects.firstNonNull(inet4Address, com.google.common.net.InetAddresses.access$000());
        this.client = (java.net.Inet4Address) com.google.common.base.Moreobjects.firstNonNull(inet4Address2, com.google.common.net.InetAddresses.access$000());
        this.port = i;
        this.flags = i2;
    }

    public java.net.Inet4Address GetClient() {
        return this.client;
    }

    public int GetFlags() {
        return this.flags;
    }

    public int GetPort() {
        return this.port;
    }

    public java.net.Inet4Address GetServer() {
        return this.server;
    }
}

