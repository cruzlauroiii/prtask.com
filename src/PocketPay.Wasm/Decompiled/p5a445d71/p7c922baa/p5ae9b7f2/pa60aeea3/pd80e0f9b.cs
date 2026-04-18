namespace WillowMaze.Wasm.Decompiled;


public interface pd80e0f9b : p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 {
    p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 forkPRFHash();

    byte[] getFinalHash(short s);

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var);

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pd80e0f9b notifyPRFDetermined();

    void sealHashAlgorithms();

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pd80e0f9b stopTracking();

    void trackHashAlgorithm(short s);
}

