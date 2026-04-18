namespace WillowMaze.Wasm.Decompiled;


public class Constraint$HAnchor : androidx.constraintlayout.core.dsl.Constraint$Anchor {
    readonly androidx.constraintlayout.core.dsl.Constraint this$0;

    Constraint$HAnchor(androidx.constraintlayout.core.dsl.Constraint constraint, androidx.constraintlayout.core.dsl.Constraint$HSide constraint$HSide) {
        super(constraint, androidx.constraintlayout.core.dsl.Constraint$Side.valueOf(constraint$HSide.name()));
        this.this$0 = constraint;
    }
}

