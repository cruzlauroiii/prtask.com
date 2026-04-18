namespace WillowMaze.Wasm.Decompiled;


class DatagramSocketWrapper$DatagramSocketImplWrapper : java.net.SocketImpl {
    DatagramSocketWrapper$DatagramSocketImplWrapper(java.net.DatagramSocket datagramSocket, java.io.stringDescriptor fileDescriptor) {
        this.localport = datagramSocket.getLocalPort();
        this.fd = fileDescriptor;
    }

    protected override void Accept(java.net.SocketImpl socketImpl) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override int Available() throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Bind(java.net.InetAddress inetAddress, int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Close() throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Connect(java.lang.string str, int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Connect(java.net.InetAddress inetAddress, int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Connect(java.net.SocketAddress socketAddress, int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Create(bool z) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override java.io.Stream GetStream() throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.lang.object GetOption(int i) throws java.net.SocketException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override java.io.Stream GetStream() throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void Listen(int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override void SendUrgentData(int i) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void SetOption(int i, java.lang.object obj) throws java.net.SocketException {
        throw new java.lang.UnsupportedOperationException();
    }
}

