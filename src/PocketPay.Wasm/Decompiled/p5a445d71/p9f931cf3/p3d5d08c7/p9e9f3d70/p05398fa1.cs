namespace WillowMaze.Wasm.Decompiled;


public class p05398fa1 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f010e4eb0;
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f3e415d71;
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f78e21bf6;
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f965ff61c;
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d ff0d9d603;

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) {
        return this.f010e4eb0.getMatches(p0c3cd33eVar);
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.pdacfecb5.p9b30b946)) {
            throw new java.lang.IllegalArgumentException("Initialization parameters must be an instance of " + p5a445d71.p9f931cf3.pdacfecb5.p9b30b946.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("377cf0ca31ff2f84e15acc83196b93cf154bf1211c627b076bd098ef00"));
        }
        this.f010e4eb0 = new p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d(((p5a445d71.p9f931cf3.pdacfecb5.p9b30b946) pb2c690d6Var).getICollection());
    }
}

