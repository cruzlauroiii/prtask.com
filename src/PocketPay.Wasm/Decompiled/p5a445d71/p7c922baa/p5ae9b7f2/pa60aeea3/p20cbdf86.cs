namespace WillowMaze.Wasm.Decompiled;


public interface p20cbdf86 {
    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf338aa3 getCipher() throws java.io.IOException;

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pa6f0eace getCompression() throws java.io.IOException;

    void notifyAlertRaised(short s, short s2, java.lang.string str, java.lang.Exception th);

    void notifyAlertReceived(short s, short s2);

    void notifyHandshakeComplete() throws java.io.IOException;

    void notifySecureRenegotiation(bool z) throws java.io.IOException;

    bool shouldUseGMTUnixTime();
}

