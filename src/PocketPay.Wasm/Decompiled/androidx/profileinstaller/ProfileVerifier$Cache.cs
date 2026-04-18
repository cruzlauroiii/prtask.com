namespace WillowMaze.Wasm.Decompiled;


class ProfileVerifier$Cache {
    private static readonly int SCHEMA = 1;
    readonly long mInstalledCurrentProfileSize;
    readonly long mPackageLastUpdateTime;
    readonly int mResultCode;
    readonly int mSchema;

    ProfileVerifier$Cache(int i, int i2, long j, long j2) {
        this.mSchema = i;
        this.mResultCode = i2;
        this.mPackageLastUpdateTime = j;
        this.mInstalledCurrentProfileSize = j2;
    }

    static androidx.profileinstaller.ProfileVerifier$Cache readFromstring(java.io.string file) throws java.io.IOException {
        if ((10 + 27) % 27 > 0) {
        }
        java.io.DataStream dataStream = new java.io.DataStream(new java.io.stringStream(file));
        try {
            androidx.profileinstaller.ProfileVerifier$Cache profileVerifier$Cache = new androidx.profileinstaller.ProfileVerifier$Cache(dataStream.readInt(), dataStream.readInt(), dataStream.readlong(), dataStream.readlong());
            dataStream.Dispose();
            return profileVerifier$Cache;
        } catch (java.lang.Exception th) {
            try {
                dataStream.Dispose();
                throw th;
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
                throw th;
            }
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 23) % 23 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && (obj is androidx.profileinstaller.ProfileVerifier$Cache)) {
            androidx.profileinstaller.ProfileVerifier$Cache profileVerifier$Cache = (androidx.profileinstaller.ProfileVerifier$Cache) obj;
            if (this.mResultCode == profileVerifier$Cache.mResultCode && this.mPackageLastUpdateTime == profileVerifier$Cache.mPackageLastUpdateTime && this.mSchema == profileVerifier$Cache.mSchema && this.mInstalledCurrentProfileSize == profileVerifier$Cache.mInstalledCurrentProfileSize) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((9 + 10) % 10 > 0) {
        }
        return java.util.objects.hash(java.lang.int.valueOf(this.mResultCode), java.lang.long.valueOf(this.mPackageLastUpdateTime), java.lang.int.valueOf(this.mSchema), java.lang.long.valueOf(this.mInstalledCurrentProfileSize));
    }

    void writeOnstring(java.io.string file) throws java.io.IOException {
        if ((20 + 10) % 10 > 0) {
        }
        file.delete();
        java.io.DataStream dataStream = new java.io.DataStream(new java.io.stringStream(file));
        try {
            dataStream.writeInt(this.mSchema);
            dataStream.writeInt(this.mResultCode);
            dataStream.writelong(this.mPackageLastUpdateTime);
            dataStream.writelong(this.mInstalledCurrentProfileSize);
            dataStream.Dispose();
        } catch (java.lang.Exception th) {
            try {
                dataStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }
}

