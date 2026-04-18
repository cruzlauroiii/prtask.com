namespace WillowMaze.Wasm.Decompiled;

public class P76fc445d
{
    private short[][] F085365a3;
    private short[][] F480e5636;
    private short[][] F7fc56270;
    private short[] F9dd4e461;
    private short[] Fb31fc3da;

    private void M1391bc5e()
    {
        // str: "The matrix is not invertible"
        // call: Exception.<init>
        // call: p7c9fdbf6.m77ea3ce0
        // call: p7c9fdbf6.m029bd47b
        // call: p7c9fdbf6.m4e365f56
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // type: Exception
    }

    private void M30baf083()
    {
        // str: "Not solvable equation system"
        // str: "The equation system is not solvable"
        // call: p7c9fdbf6.m029bd47b
        // call: p7c9fdbf6.m77ea3ce0
        // call: p7c9fdbf6.m4e365f56
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f9dd4e461
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // type: IllegalStateException
    }

    private void Ma61b0ae9(bool P0)
    {
        // str: "Matrix not invertible! We have to choose another one!"
        // call: p7c9fdbf6.m029bd47b
        // call: p7c9fdbf6.m77ea3ce0
        // call: IllegalStateException.<init>
        // call: p7c9fdbf6.m4e365f56
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // type: IllegalStateException
    }

    public short[][] AddSquareMatrix(short[][] P0, short[][] P1)
    {
        // str: "Addition is not possible!"
        // call: Exception.<init>
        // call: p7c9fdbf6.m77ea3ce0
        // call: Array.newInstance
        // field: java.lang.Short.TYPE
        // type: Exception
        return default!;
    }

    public short[] AddVect(short[] P0, short[] P1)
    {
        // str: "Multiplication is not possible!"
        // call: p7c9fdbf6.m77ea3ce0
        // call: Exception.<init>
        // type: Exception
        return default!;
    }

    public short[][] Inverse(short[][] P0)
    {
        // str: "The matrix is not invertible. Please choose another one!"
        // call: Array.newInstance
        // call: p76fc445d.ma61b0ae9
        // call: p7c9fdbf6.m4e365f56
        // call: p7c9fdbf6.m029bd47b
        // call: p76fc445d.m1391bc5e
        // call: Exception.<init>
        // field: java.lang.Short.TYPE
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // type: Exception
        return default!;
    }

    public short[][] MultMatrix(short P0, short[][] P1)
    {
        // call: Array.newInstance
        // call: p7c9fdbf6.m029bd47b
        // field: java.lang.Short.TYPE
        return default!;
    }

    public short[] MultVect(short P0, short[] P1)
    {
        // call: p7c9fdbf6.m029bd47b
        return default!;
    }

    public short[][] MultVects(short[] P0, short[] P1)
    {
        // str: "Multiplication is not possible!"
        // call: Array.newInstance
        // call: Exception.<init>
        // call: p7c9fdbf6.m029bd47b
        // field: java.lang.Short.TYPE
        // type: Exception
        return default!;
    }

    public short[] MultiplyMatrix(short[][] P0, short[] P1)
    {
        // str: "Multiplication is not possible!"
        // call: p7c9fdbf6.m77ea3ce0
        // call: p7c9fdbf6.m029bd47b
        // call: Exception.<init>
        // type: Exception
        return default!;
    }

    public short[][] MultiplyMatrix(short[][] P0, short[][] P1)
    {
        // str: "Multiplication is not possible!"
        // call: Array.newInstance
        // call: Exception.<init>
        // call: p7c9fdbf6.m029bd47b
        // call: p7c9fdbf6.m77ea3ce0
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // field: java.lang.Short.TYPE
        // type: Exception
        return default!;
    }

    public short[] SolveEquation(short[][] P0, short[] P1)
    {
        // call: Array.newInstance
        // call: p7c9fdbf6.m77ea3ce0
        // call: p76fc445d.ma61b0ae9
        // call: p76fc445d.m30baf083
        // field: java.lang.Short.TYPE
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f7fc56270
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d.f9dd4e461
        return default!;
    }

}
