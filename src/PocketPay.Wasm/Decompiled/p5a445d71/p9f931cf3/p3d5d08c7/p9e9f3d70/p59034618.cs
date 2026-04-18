namespace WillowMaze.Wasm.Decompiled;


public class p59034618 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f010e4eb0;
    private p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d f873fa8ba;

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) {
        return this.f010e4eb0.getMatches(p0c3cd33eVar);
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.pdacfecb5.p9b30b946)) {
            throw new java.lang.IllegalArgumentException(pb2c690d6Var.tostring());
        }
        this.f010e4eb0 = new p5a445d71.p9f931cf3.p05c7e247.p1df1fd2d(((p5a445d71.p9f931cf3.pdacfecb5.p9b30b946) pb2c690d6Var).getICollection());
    }
}

