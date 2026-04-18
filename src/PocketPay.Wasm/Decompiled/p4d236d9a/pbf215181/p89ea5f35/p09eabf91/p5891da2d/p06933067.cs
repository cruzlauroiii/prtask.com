namespace WillowMaze.Wasm.Decompiled;


public class p06933067 {
    private java.lang.int f16e3f28f;
    private java.lang.int f20583dcf;
    private java.lang.string f2af72f10;
    private java.lang.string f34eee2c8;
    private java.lang.int f401038e4;
    private java.net.Uri f44b7d352;
    private java.net.Uri f4cd4a1c3;
    private java.lang.string f697f022b;
    private java.lang.string f736fd70d;
    private java.lang.string f9c7e886c;
    private java.lang.string fa62f7e90;
    private java.lang.string fc58b9d45;
    private java.lang.string fd4769b02;
    private java.net.Uri ff2e4bb72;
    private java.lang.int ff2fa10fc;
    private java.lang.int ffca2747c;

    public p06933067() {
    }

    public p06933067(java.lang.string str, java.lang.int num) {
        this.f2af72f10 = str;
        this.f20583dcf = num;
    }

    public p06933067(java.lang.string str, java.lang.int num, java.lang.string str2, java.net.Uri url) {
        this(str, str2, url);
        this.f20583dcf = num;
    }

    public p06933067(java.lang.string str, java.lang.string str2, java.net.Uri url) {
        this.f2af72f10 = str;
        this.f44b7d352 = url;
        this.fc58b9d45 = str2;
    }

    public p06933067(java.lang.string str, java.net.Uri url) {
        this.f2af72f10 = str;
        this.f44b7d352 = url;
    }

    public java.lang.string GetLatestVersion() {
        return this.f2af72f10;
    }

    public java.lang.int GetLatestVersionCode() {
        return this.f20583dcf;
    }

    public java.lang.string GetReleaseNotes() {
        return this.fc58b9d45;
    }

    public java.net.Uri GetUrlToDownload() {
        return this.f44b7d352;
    }

    public void SetLatestVersion(java.lang.string str) {
        this.f2af72f10 = str;
    }

    public void SetLatestVersionCode(java.lang.int num) {
        this.f20583dcf = num;
    }

    public void SetReleaseNotes(java.lang.string str) {
        this.fc58b9d45 = str;
    }

    public void SetUrlToDownload(java.net.Uri url) {
        this.f44b7d352 = url;
    }
}

