using IMS.DataAccess.Interface;

namespace IMS.DataAccess
{
    public class InventoriesModel
    {
        public DateTime TxDate { get; set; }
        public string InventoryName { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string OrderId { get; set; } = string.Empty;
        public string ProductionNumber { get; set; } = string.Empty;
    }

    public class InventoryReportRepository : IInventoryReportRepository
    {

        private List<InventoriesModel> _inventories;

        public InventoryReportRepository()
        {
            _inventories = new List<InventoriesModel>()
            {
               new() { TxDate = new DateTime(2026, 1, 1), InventoryName = "Cement", Quantity = 105m, OrderId = "ORD-1001", ProductionNumber = "PRD-5001" },
    new() { TxDate = new DateTime(2026, 1, 2), InventoryName = "Steel", Quantity = 110m, OrderId = "ORD-1002", ProductionNumber = "PRD-5002" },
    new() { TxDate = new DateTime(2026, 1, 3), InventoryName = "Sand", Quantity = 115m, OrderId = "ORD-1003", ProductionNumber = "PRD-5003" },
    new() { TxDate = new DateTime(2026, 1, 4), InventoryName = "Gravel", Quantity = 120m, OrderId = "ORD-1004", ProductionNumber = "PRD-5004" },
    new() { TxDate = new DateTime(2026, 1, 5), InventoryName = "Bricks", Quantity = 125m, OrderId = "ORD-1005", ProductionNumber = "PRD-5005" },
    new() { TxDate = new DateTime(2026, 1, 6), InventoryName = "Fly Ash", Quantity = 130m, OrderId = "ORD-1006", ProductionNumber = "PRD-5006" },
    new() { TxDate = new DateTime(2026, 1, 7), InventoryName = "Bitumen", Quantity = 135m, OrderId = "ORD-1007", ProductionNumber = "PRD-5007" },
    new() { TxDate = new DateTime(2026, 1, 8), InventoryName = "Aggregate", Quantity = 140m, OrderId = "ORD-1008", ProductionNumber = "PRD-5008" },
    new() { TxDate = new DateTime(2026, 1, 9), InventoryName = "Cement", Quantity = 145m, OrderId = "ORD-1009", ProductionNumber = "PRD-5009" },
    new() { TxDate = new DateTime(2026, 1, 10), InventoryName = "Steel", Quantity = 150m, OrderId = "ORD-1010", ProductionNumber = "PRD-5010" },
    new() { TxDate = new DateTime(2026, 1, 11), InventoryName = "Sand", Quantity = 155m, OrderId = "ORD-1011", ProductionNumber = "PRD-5011" },
    new() { TxDate = new DateTime(2026, 1, 12), InventoryName = "Gravel", Quantity = 160m, OrderId = "ORD-1012", ProductionNumber = "PRD-5012" },
    new() { TxDate = new DateTime(2026, 1, 13), InventoryName = "Bricks", Quantity = 165m, OrderId = "ORD-1013", ProductionNumber = "PRD-5013" },
    new() { TxDate = new DateTime(2026, 1, 14), InventoryName = "Fly Ash", Quantity = 170m, OrderId = "ORD-1014", ProductionNumber = "PRD-5014" },
    new() { TxDate = new DateTime(2026, 1, 15), InventoryName = "Bitumen", Quantity = 175m, OrderId = "ORD-1015", ProductionNumber = "PRD-5015" },
    new() { TxDate = new DateTime(2026, 1, 16), InventoryName = "Aggregate", Quantity = 180m, OrderId = "ORD-1016", ProductionNumber = "PRD-5016" },
    new() { TxDate = new DateTime(2026, 1, 17), InventoryName = "Cement", Quantity = 185m, OrderId = "ORD-1017", ProductionNumber = "PRD-5017" },
    new() { TxDate = new DateTime(2026, 1, 18), InventoryName = "Steel", Quantity = 190m, OrderId = "ORD-1018", ProductionNumber = "PRD-5018" },
    new() { TxDate = new DateTime(2026, 1, 19), InventoryName = "Sand", Quantity = 195m, OrderId = "ORD-1019", ProductionNumber = "PRD-5019" },
    new() { TxDate = new DateTime(2026, 1, 20), InventoryName = "Gravel", Quantity = 200m, OrderId = "ORD-1020", ProductionNumber = "PRD-5020" },
    new() { TxDate = new DateTime(2026, 1, 21), InventoryName = "Bricks", Quantity = 205m, OrderId = "ORD-1021", ProductionNumber = "PRD-5021" },
    new() { TxDate = new DateTime(2026, 1, 22), InventoryName = "Fly Ash", Quantity = 210m, OrderId = "ORD-1022", ProductionNumber = "PRD-5022" },
    new() { TxDate = new DateTime(2026, 1, 23), InventoryName = "Bitumen", Quantity = 215m, OrderId = "ORD-1023", ProductionNumber = "PRD-5023" },
    new() { TxDate = new DateTime(2026, 1, 24), InventoryName = "Aggregate", Quantity = 220m, OrderId = "ORD-1024", ProductionNumber = "PRD-5024" },
    new() { TxDate = new DateTime(2026, 1, 25), InventoryName = "Cement", Quantity = 225m, OrderId = "ORD-1025", ProductionNumber = "PRD-5025" },
    new() { TxDate = new DateTime(2026, 1, 26), InventoryName = "Steel", Quantity = 230m, OrderId = "ORD-1026", ProductionNumber = "PRD-5026" },
    new() { TxDate = new DateTime(2026, 1, 27), InventoryName = "Sand", Quantity = 235m, OrderId = "ORD-1027", ProductionNumber = "PRD-5027" },
    new() { TxDate = new DateTime(2026, 1, 28), InventoryName = "Gravel", Quantity = 240m, OrderId = "ORD-1028", ProductionNumber = "PRD-5028" },
    new() { TxDate = new DateTime(2026, 2, 1), InventoryName = "Bricks", Quantity = 245m, OrderId = "ORD-1029", ProductionNumber = "PRD-5029" },
    new() { TxDate = new DateTime(2026, 2, 2), InventoryName = "Fly Ash", Quantity = 250m, OrderId = "ORD-1030", ProductionNumber = "PRD-5030" },
    new() { TxDate = new DateTime(2026, 2, 3), InventoryName = "Bitumen", Quantity = 255m, OrderId = "ORD-1031", ProductionNumber = "PRD-5031" },
    new() { TxDate = new DateTime(2026, 2, 4), InventoryName = "Aggregate", Quantity = 260m, OrderId = "ORD-1032", ProductionNumber = "PRD-5032" },
    new() { TxDate = new DateTime(2026, 2, 5), InventoryName = "Cement", Quantity = 265m, OrderId = "ORD-1033", ProductionNumber = "PRD-5033" },
    new() { TxDate = new DateTime(2026, 2, 6), InventoryName = "Steel", Quantity = 270m, OrderId = "ORD-1034", ProductionNumber = "PRD-5034" },
    new() { TxDate = new DateTime(2026, 2, 7), InventoryName = "Sand", Quantity = 275m, OrderId = "ORD-1035", ProductionNumber = "PRD-5035" },
    new() { TxDate = new DateTime(2026, 2, 8), InventoryName = "Gravel", Quantity = 280m, OrderId = "ORD-1036", ProductionNumber = "PRD-5036" },
    new() { TxDate = new DateTime(2026, 2, 9), InventoryName = "Bricks", Quantity = 285m, OrderId = "ORD-1037", ProductionNumber = "PRD-5037" },
    new() { TxDate = new DateTime(2026, 2, 10), InventoryName = "Fly Ash", Quantity = 290m, OrderId = "ORD-1038", ProductionNumber = "PRD-5038" },
    new() { TxDate = new DateTime(2026, 2, 11), InventoryName = "Bitumen", Quantity = 295m, OrderId = "ORD-1039", ProductionNumber = "PRD-5039" },
    new() { TxDate = new DateTime(2026, 2, 12), InventoryName = "Aggregate", Quantity = 300m, OrderId = "ORD-1040", ProductionNumber = "PRD-5040" },
    new() { TxDate = new DateTime(2026, 2, 13), InventoryName = "Cement", Quantity = 305m, OrderId = "ORD-1041", ProductionNumber = "PRD-5041" },
    new() { TxDate = new DateTime(2026, 2, 14), InventoryName = "Steel", Quantity = 310m, OrderId = "ORD-1042", ProductionNumber = "PRD-5042" },
    new() { TxDate = new DateTime(2026, 2, 15), InventoryName = "Sand", Quantity = 315m, OrderId = "ORD-1043", ProductionNumber = "PRD-5043" },
    new() { TxDate = new DateTime(2026, 2, 16), InventoryName = "Gravel", Quantity = 320m, OrderId = "ORD-1044", ProductionNumber = "PRD-5044" },
    new() { TxDate = new DateTime(2026, 2, 17), InventoryName = "Bricks", Quantity = 325m, OrderId = "ORD-1045", ProductionNumber = "PRD-5045" },
    new() { TxDate = new DateTime(2026, 2, 18), InventoryName = "Fly Ash", Quantity = 330m, OrderId = "ORD-1046", ProductionNumber = "PRD-5046" },
    new() { TxDate = new DateTime(2026, 2, 19), InventoryName = "Bitumen", Quantity = 335m, OrderId = "ORD-1047", ProductionNumber = "PRD-5047" },
    new() { TxDate = new DateTime(2026, 2, 20), InventoryName = "Aggregate", Quantity = 340m, OrderId = "ORD-1048", ProductionNumber = "PRD-5048" },
    new() { TxDate = new DateTime(2026, 2, 21), InventoryName = "Cement", Quantity = 345m, OrderId = "ORD-1049", ProductionNumber = "PRD-5049" },
    new() { TxDate = new DateTime(2026, 2, 22), InventoryName = "Steel", Quantity = 350m, OrderId = "ORD-1050", ProductionNumber = "PRD-5050" },
    new() { TxDate = new DateTime(2026, 2, 23), InventoryName = "Sand", Quantity = 355m, OrderId = "ORD-1001", ProductionNumber = "PRD-5051" },
    new() { TxDate = new DateTime(2026, 2, 24), InventoryName = "Gravel", Quantity = 360m, OrderId = "ORD-1002", ProductionNumber = "PRD-5052" },
    new() { TxDate = new DateTime(2026, 2, 25), InventoryName = "Bricks", Quantity = 365m, OrderId = "ORD-1003", ProductionNumber = "PRD-5053" },
    new() { TxDate = new DateTime(2026, 2, 26), InventoryName = "Fly Ash", Quantity = 370m, OrderId = "ORD-1004", ProductionNumber = "PRD-5054" },
    new() { TxDate = new DateTime(2026, 2, 27), InventoryName = "Bitumen", Quantity = 375m, OrderId = "ORD-1005", ProductionNumber = "PRD-5055" },
    new() { TxDate = new DateTime(2026, 2, 28), InventoryName = "Aggregate", Quantity = 380m, OrderId = "ORD-1006", ProductionNumber = "PRD-5056" },
    new() { TxDate = new DateTime(2026, 3, 1), InventoryName = "Cement", Quantity = 385m, OrderId = "ORD-1007", ProductionNumber = "PRD-5057" },
    new() { TxDate = new DateTime(2026, 3, 2), InventoryName = "Steel", Quantity = 390m, OrderId = "ORD-1008", ProductionNumber = "PRD-5058" },
    new() { TxDate = new DateTime(2026, 3, 3), InventoryName = "Sand", Quantity = 395m, OrderId = "ORD-1009", ProductionNumber = "PRD-5059" },
    new() { TxDate = new DateTime(2026, 3, 4), InventoryName = "Gravel", Quantity = 400m, OrderId = "ORD-1010", ProductionNumber = "PRD-5060" },
    new() { TxDate = new DateTime(2026, 3, 5), InventoryName = "Bricks", Quantity = 405m, OrderId = "ORD-1011", ProductionNumber = "PRD-5061" },
    new() { TxDate = new DateTime(2026, 3, 6), InventoryName = "Fly Ash", Quantity = 410m, OrderId = "ORD-1012", ProductionNumber = "PRD-5062" },
    new() { TxDate = new DateTime(2026, 3, 7), InventoryName = "Bitumen", Quantity = 415m, OrderId = "ORD-1013", ProductionNumber = "PRD-5063" },
    new() { TxDate = new DateTime(2026, 3, 8), InventoryName = "Aggregate", Quantity = 420m, OrderId = "ORD-1014", ProductionNumber = "PRD-5064" },
    new() { TxDate = new DateTime(2026, 3, 9), InventoryName = "Cement", Quantity = 425m, OrderId = "ORD-1015", ProductionNumber = "PRD-5065" },
    new() { TxDate = new DateTime(2026, 3, 10), InventoryName = "Steel", Quantity = 430m, OrderId = "ORD-1016", ProductionNumber = "PRD-5066" },
    new() { TxDate = new DateTime(2026, 3, 11), InventoryName = "Sand", Quantity = 435m, OrderId = "ORD-1017", ProductionNumber = "PRD-5067" },
    new() { TxDate = new DateTime(2026, 3, 12), InventoryName = "Gravel", Quantity = 440m, OrderId = "ORD-1018", ProductionNumber = "PRD-5068" },
    new() { TxDate = new DateTime(2026, 3, 13), InventoryName = "Bricks", Quantity = 445m, OrderId = "ORD-1019", ProductionNumber = "PRD-5069" },
    new() { TxDate = new DateTime(2026, 3, 14), InventoryName = "Fly Ash", Quantity = 450m, OrderId = "ORD-1020", ProductionNumber = "PRD-5070" },
    new() { TxDate = new DateTime(2026, 3, 15), InventoryName = "Bitumen", Quantity = 455m, OrderId = "ORD-1021", ProductionNumber = "PRD-5071" },
    new() { TxDate = new DateTime(2026, 3, 16), InventoryName = "Aggregate", Quantity = 460m, OrderId = "ORD-1022", ProductionNumber = "PRD-5072" },
    new() { TxDate = new DateTime(2026, 3, 17), InventoryName = "Cement", Quantity = 465m, OrderId = "ORD-1023", ProductionNumber = "PRD-5073" },
    new() { TxDate = new DateTime(2026, 3, 18), InventoryName = "Steel", Quantity = 470m, OrderId = "ORD-1024", ProductionNumber = "PRD-5074" },
    new() { TxDate = new DateTime(2026, 3, 19), InventoryName = "Sand", Quantity = 475m, OrderId = "ORD-1025", ProductionNumber = "PRD-5075" },
    new() { TxDate = new DateTime(2026, 3, 20), InventoryName = "Gravel", Quantity = 480m, OrderId = "ORD-1026", ProductionNumber = "PRD-5076" },
    new() { TxDate = new DateTime(2026, 3, 21), InventoryName = "Bricks", Quantity = 485m, OrderId = "ORD-1027", ProductionNumber = "PRD-5077" },
    new() { TxDate = new DateTime(2026, 3, 22), InventoryName = "Fly Ash", Quantity = 490m, OrderId = "ORD-1028", ProductionNumber = "PRD-5078" },
    new() { TxDate = new DateTime(2026, 3, 23), InventoryName = "Bitumen", Quantity = 495m, OrderId = "ORD-1029", ProductionNumber = "PRD-5079" },
    new() { TxDate = new DateTime(2026, 3, 24), InventoryName = "Aggregate", Quantity = 500m, OrderId = "ORD-1030", ProductionNumber = "PRD-5080" },
    new() { TxDate = new DateTime(2026, 3, 25), InventoryName = "Cement", Quantity = 505m, OrderId = "ORD-1031", ProductionNumber = "PRD-5081" },
    new() { TxDate = new DateTime(2026, 3, 26), InventoryName = "Steel", Quantity = 510m, OrderId = "ORD-1032", ProductionNumber = "PRD-5082" },
    new() { TxDate = new DateTime(2026, 3, 27), InventoryName = "Sand", Quantity = 515m, OrderId = "ORD-1033", ProductionNumber = "PRD-5083" },
    new() { TxDate = new DateTime(2026, 3, 28), InventoryName = "Gravel", Quantity = 520m, OrderId = "ORD-1034", ProductionNumber = "PRD-5084" },
    new() { TxDate = new DateTime(2026, 4, 1), InventoryName = "Bricks", Quantity = 525m, OrderId = "ORD-1035", ProductionNumber = "PRD-5085" },
    new() { TxDate = new DateTime(2026, 4, 2), InventoryName = "Fly Ash", Quantity = 530m, OrderId = "ORD-1036", ProductionNumber = "PRD-5086" },
    new() { TxDate = new DateTime(2026, 4, 3), InventoryName = "Bitumen", Quantity = 535m, OrderId = "ORD-1037", ProductionNumber = "PRD-5087" },
    new() { TxDate = new DateTime(2026, 4, 4), InventoryName = "Aggregate", Quantity = 540m, OrderId = "ORD-1038", ProductionNumber = "PRD-5088" },
    new() { TxDate = new DateTime(2026, 4, 5), InventoryName = "Cement", Quantity = 545m, OrderId = "ORD-1039", ProductionNumber = "PRD-5089" },
    new() { TxDate = new DateTime(2026, 4, 6), InventoryName = "Steel", Quantity = 550m, OrderId = "ORD-1040", ProductionNumber = "PRD-5090" },
    new() { TxDate = new DateTime(2026, 4, 7), InventoryName = "Sand", Quantity = 555m, OrderId = "ORD-1041", ProductionNumber = "PRD-5091" },
    new() { TxDate = new DateTime(2026, 4, 8), InventoryName = "Gravel", Quantity = 560m, OrderId = "ORD-1042", ProductionNumber = "PRD-5092" },
    new() { TxDate = new DateTime(2026, 4, 9), InventoryName = "Bricks", Quantity = 565m, OrderId = "ORD-1043", ProductionNumber = "PRD-5093" },
    new() { TxDate = new DateTime(2026, 4, 10), InventoryName = "Fly Ash", Quantity = 570m, OrderId = "ORD-1044", ProductionNumber = "PRD-5094" },
    new() { TxDate = new DateTime(2026, 4, 11), InventoryName = "Bitumen", Quantity = 575m, OrderId = "ORD-1045", ProductionNumber = "PRD-5095" },
    new() { TxDate = new DateTime(2026, 4, 12), InventoryName = "Aggregate", Quantity = 580m, OrderId = "ORD-1046", ProductionNumber = "PRD-5096" },
    new() { TxDate = new DateTime(2026, 4, 13), InventoryName = "Cement", Quantity = 585m, OrderId = "ORD-1047", ProductionNumber = "PRD-5097" },
    new() { TxDate = new DateTime(2026, 4, 14), InventoryName = "Steel", Quantity = 590m, OrderId = "ORD-1048", ProductionNumber = "PRD-5098" },
    new() { TxDate = new DateTime(2026, 4, 15), InventoryName = "Sand", Quantity = 595m, OrderId = "ORD-1049", ProductionNumber = "PRD-5099" },
    new() { TxDate = new DateTime(2026, 4, 16), InventoryName = "Gravel", Quantity = 600m, OrderId = "ORD-1050", ProductionNumber = "PRD-5100" }
            };
        }


        public Task<List<InventoriesModel>> Filter(
            string? inventoryName = null,
            DateTime? fromDate = null,
            DateTime? toDate = null,
            string? orderId = null)
        {
            var query = _inventories.AsQueryable();

            if (!string.IsNullOrWhiteSpace(inventoryName))
            {
                query = query.Where(x =>
                    x.InventoryName.Equals(
                        inventoryName,
                        StringComparison.OrdinalIgnoreCase));
            }

            if (fromDate.HasValue)
            {
                query = query.Where(x => x.TxDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                query = query.Where(x => x.TxDate <= toDate.Value);
            }

            if (!string.IsNullOrWhiteSpace(orderId))
            {
                query = query.Where(x =>
                    x.OrderId.Equals(
                        orderId,
                        StringComparison.OrdinalIgnoreCase));
            }

            return Task.FromResult(query
                .OrderByDescending(x => x.TxDate)
                .ToList());
        }
    }
}
