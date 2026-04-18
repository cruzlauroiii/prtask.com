namespace WillowMaze.Wasm.Decompiled;

public interface P51821801
{
    object ClearCommodities(object P0);
    object ClearCommodityGroups(object P0);
    object ClearMeasures(object P0);
    object ClearTaxes(object P0);
    object DeleteCommodities(string P0, object P1);
    object DeleteCommodity(string P0, object P1);
    object DeleteCommodityByParentId(string P0, object P1);
    object DeleteCommodityGroup(string P0, object P1);
    object DeleteCommodityGroups(string P0, object P1);
    object DeleteGroupById(string P0, object P1);
    object GetCommodities(string P0, object P1);
    object GetCommoditiesByParentId(string P0, string P1, object P2);
    object GetCommoditiesByQuery(string P0, string P1, object P2);
    object GetCommodityById(string P0, object P1);
    object GetCommodityGroupById(string P0, object P1);
    object GetCommodityGroups(string P0, object P1);
    object GetCommodityGroupsByParentId(string P0, string P1, object P2);
    object GetGroupTree(string P0, object P1);
    object GetMeasureByCode(string P0, object P1);
    object GetMeasures(object P0);
    object GetTaxByCode(string P0, object P1);
    object GetTaxes(object P0);
    object InsertCommodities(List<object> P0, object P1);
    object InsertCommodity(p821c9e21 P0, object P1);
    object InsertCommodityGroup(pdf878ad9 P0, object P1);
    object InsertCommodityGroups(List<object> P0, object P1);
    object InsertMeasures(List<object> P0, object P1);
    object InsertTaxes(List<object> P0, object P1);
    object ReplaceCommoditiesQuantity(List<object> P0, object P1);
    object ReplaceCommodityQuantity(string P0, decimal P1, object P2);
    object ReplaceMeasures(List<object> P0, object P1);
    object ReplaceTaxes(List<object> P0, object P1);
    object SaveCommodities(List<object> P0, object P1);
    object SaveCommodityGroups(List<object> P0, object P1);
    object UpdateCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantityAndPrice(List<object> P0, object P1);
    object UpdateCommodityQuantity(string P0, decimal P1, object P2);
    object UpdateCommodityQuantityAndPrice(string P0, decimal P1, decimal P2, decimal P3, object P4);
}
