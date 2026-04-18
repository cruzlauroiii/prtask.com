namespace WillowMaze.Wasm.Decompiled;

public interface P4447a398
{
    object ClearCurrentInventorizationPositions(object P0);
    object ClearCurrentInventorizations(object P0);
    object CreateCurrentInventorization(p12e406c7 P0, object P1);
    object GetCurrentInventorization(object P0);
    object GetCurrentInventorizationPositions(object P0);
    object GetInventorizations(object P0);
    object GetLastInventorizationNumber(object P0);
    object InsertCurrentInventorizationPosition(p0ed7807b P0, object P1);
    object InsertInventorization(p4582d01f P0, object P1);
    object InsertInventorizationPositions(List<object> P0, object P1);
    object RemoveCurrentInventorizationPosition(string P0, object P1);
    object SaveInventorization(p4582d01f P0, List<object> P1, object P2);
    object UpdateCurrentInventorization(p14abd389 P0, object P1);
    object UpdateCurrentInventorizationPosition(p0ed7807b P0, object P1);
}
