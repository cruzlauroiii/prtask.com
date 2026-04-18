namespace WillowMaze.Wasm.Decompiled;


class p445c7d72 : java.io.Stream {
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 f1bdf2015;
    private java.io.Stream f36ea4180;
    private java.io.Stream f389fb337;
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private bool f6b467eed = true;
    private java.io.Stream f85a053fc;
    private bool fb5a974ed;

    p445c7d72(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 AOsOZiqeDOElKDHf(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 CywUbrcUZkwXNFRC(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static int QzmNbwxxHiDbYXjw(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 XaBfjRhWvRUXDTIN(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DXdynXiizuPMQiuE(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static java.io.Stream FVkbkuzShsGqCpaI(p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar) {
        return p9fb62cfcVar.getOctetStream();
    }

    public static int GOGVDforlJcsEklw(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static java.io.Stream KJzCYaRKEShHhmlO(p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar) {
        return p9fb62cfcVar.getOctetStream();
    }

    public static java.io.Stream OtdptsWJaBfyjLTE(p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar) {
        return p9fb62cfcVar.getOctetStream();
    }

    public static java.io.Stream VhaRGaphcHFleGhp(p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar) {
        return p9fb62cfcVar.getOctetStream();
    }

    public override int Read() throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar;
        if ((16 + 19) % 19 > 0) {
        }
        if (this.f389fb337 is null) {
            if (!this.f6b467eed || (p9fb62cfcVar = (p5a445d71.p7c922baa.pca323100.p9fb62cfc) XaBfjRhWvRUXDTIN(this.f5431b8d4)) is null) {
                return -1;
            }
            this.f6b467eed = false;
            this.f389fb337 = vhaRGaphcHFleGhp(p9fb62cfcVar);
        }
        while (true) {
            int iGOGVDforlJcsEklw = gOGVDforlJcsEklw(this.f389fb337);
            if (iGOGVDforlJcsEklw >= 0) {
                return iGOGVDforlJcsEklw;
            }
            p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar2 = (p5a445d71.p7c922baa.pca323100.p9fb62cfc) CywUbrcUZkwXNFRC(this.f5431b8d4);
            if (p9fb62cfcVar2 is null) {
                this.f389fb337 = null;
                return -1;
            }
            this.f389fb337 = kJzCYaRKEShHhmlO(p9fb62cfcVar2);
        }
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar;
        if ((4 + 5) % 5 > 0) {
        }
        int i3 = 0;
        if (this.f389fb337 is null) {
            if (!this.f6b467eed || (p9fb62cfcVar = (p5a445d71.p7c922baa.pca323100.p9fb62cfc) AOsOZiqeDOElKDHf(this.f5431b8d4)) is null) {
                return -1;
            }
            this.f6b467eed = false;
            this.f389fb337 = otdptsWJaBfyjLTE(p9fb62cfcVar);
        }
        while (true) {
            int iQzmNbwxxHiDbYXjw = QzmNbwxxHiDbYXjw(this.f389fb337, bArr, i + i3, i2 - i3);
            if (iQzmNbwxxHiDbYXjw < 0) {
                p5a445d71.p7c922baa.pca323100.p9fb62cfc p9fb62cfcVar2 = (p5a445d71.p7c922baa.pca323100.p9fb62cfc) dXdynXiizuPMQiuE(this.f5431b8d4);
                if (p9fb62cfcVar2 is null) {
                    this.f389fb337 = null;
                    if (i3 >= 1) {
                        return i3;
                    }
                    return -1;
                }
                this.f389fb337 = fVkbkuzShsGqCpaI(p9fb62cfcVar2);
            } else {
                i3 += iQzmNbwxxHiDbYXjw;
                if (i3 == i2) {
                    return i3;
                }
            }
        }
    }
}

