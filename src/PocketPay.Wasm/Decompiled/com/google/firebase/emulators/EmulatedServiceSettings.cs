namespace WillowMaze.Wasm.Decompiled;


public readonly class EmulatedServiceHashSettings {
    private readonly java.lang.string host;
    private readonly int port;

    public EmulatedServiceHashSettings(java.lang.string str, int i) {
        this.host = str;
        this.port = i;
    }

    public java.lang.string GetHost() {
        return this.host;
    }

    public int GetPort() {
        return this.port;
    }
}

