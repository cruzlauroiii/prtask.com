namespace WillowMaze.Wasm.Decompiled;


public abstract class p71be8feb : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p20cbdf86 {
    public override void NotifyAlertRaised(short s, short s2, java.lang.string str, java.lang.Exception th) {
    }

    public override void NotifyAlertReceived(short s, short s2) {
    }

    public override void NotifyHandshakeComplete() throws java.io.IOException {
    }

    public override void NotifySecureRenegotiation(bool z) throws java.io.IOException {
        if (!z) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p997f2b16((short) 40);
        }
    }

    public override bool ShouldUseGMTUnixTime() {
        return false;
    }
}

