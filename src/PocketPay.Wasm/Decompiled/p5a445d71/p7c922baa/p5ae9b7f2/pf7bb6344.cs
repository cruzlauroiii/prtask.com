namespace WillowMaze.Wasm.Decompiled;


public class pf7bb6344 {
    private int f13669496;
    private int f5177790a;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f83e06301;
    private java.security.SecureRandom f8827f9d2;
    private int f9068db08;
    private int fb162a2f9;
    private int fe46057f5;

    public pf7bb6344(java.security.SecureRandom secureRandom, int i) {
        this.f7ddf32e1 = secureRandom;
        this.f5177790a = i;
    }

    public java.security.SecureRandom GetRandom() {
        return this.f7ddf32e1;
    }

    public int GetStrength() {
        return this.f5177790a;
    }
}

