namespace WillowMaze.Wasm.Decompiled;


public class BuildIdInfo {
    private readonly java.lang.string arch;
    private readonly java.lang.string buildId;
    private readonly java.lang.string libraryName;

    public BuildIdInfo(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        this.libraryName = str;
        this.arch = str2;
        this.buildId = str3;
    }

    public java.lang.string GetArch() {
        return this.arch;
    }

    public java.lang.string GetBuildId() {
        return this.buildId;
    }

    public java.lang.string GetLibraryName() {
        return this.libraryName;
    }
}

