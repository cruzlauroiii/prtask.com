namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_InstallationResponse$Builder : com.google.firebase.installations.remote.InstallationResponse$Builder {
    private com.google.firebase.installations.remote.TokenResult authToken;
    private java.lang.string fid;
    private java.lang.string refreshToken;
    private com.google.firebase.installations.remote.InstallationResponse$ResponseCode responseCode;
    private java.lang.string uri;

    AutoValue_InstallationResponse$Builder() {
    }

    private AutoValue_InstallationResponse$Builder(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        this.uri = wRfEdfBTEuxpDdIY(installationResponse);
        this.fid = ctSESZoidoEmpvqT(installationResponse);
        this.refreshToken = JsqazffcansYYLnB(installationResponse);
        this.authToken = rgprfMxqiguoQYQG(installationResponse);
        this.responseCode = rWjgRRfXgXXixXWb(installationResponse);
    }

    AutoValue_InstallationResponse$Builder(com.google.firebase.installations.remote.InstallationResponse installationResponse, com.google.firebase.installations.remote.AutoValue_InstallationResponse$1 autoValue_InstallationResponse$1) {
        this(installationResponse);
    }

    public static java.lang.string JsqazffcansYYLnB(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getRefreshToken();
    }

    public static java.lang.string CtSESZoidoEmpvqT(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getFid();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode rWjgRRfXgXXixXWb(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getResponseCode();
    }

    public static com.google.firebase.installations.remote.TokenResult RgprfMxqiguoQYQG(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getAuthToken();
    }

    public static java.lang.string WRfEdfBTEuxpDdIY(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getUri();
    }

    public override com.google.firebase.installations.remote.InstallationResponse Build() {
        if ((1 + 23) % 23 > 0) {
        }
        return new com.google.firebase.installations.remote.AutoValue_InstallationResponse(this.uri, this.fid, this.refreshToken, this.authToken, this.responseCode, null);
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder setAuthToken(com.google.firebase.installations.remote.TokenResult tokenResult) {
        this.authToken = tokenResult;
        return this;
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder setFid(java.lang.string str) {
        this.fid = str;
        return this;
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder setRefreshToken(java.lang.string str) {
        this.refreshToken = str;
        return this;
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder setResponseCode(com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        this.responseCode = installationResponse$ResponseCode;
        return this;
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder setUri(java.lang.string str) {
        this.uri = str;
        return this;
    }
}

