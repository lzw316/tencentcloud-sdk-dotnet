/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VatInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// <p>行号</p>
        /// </summary>
        [JsonProperty("LineNo")]
        public string LineNo{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>规格</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>单位</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>数量</p>
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// <p>单价</p>
        /// </summary>
        [JsonProperty("UnitPrice")]
        public string UnitPrice{ get; set; }

        /// <summary>
        /// <p>不含税金额</p>
        /// </summary>
        [JsonProperty("AmountWithoutTax")]
        public string AmountWithoutTax{ get; set; }

        /// <summary>
        /// <p>税率</p>
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// <p>税额</p>
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// <p>税收分类编码</p>
        /// </summary>
        [JsonProperty("TaxClassifyCode")]
        public string TaxClassifyCode{ get; set; }

        /// <summary>
        /// <p>运输工具类型</p>
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// <p>运输工具牌号</p>
        /// </summary>
        [JsonProperty("VehicleBrand")]
        public string VehicleBrand{ get; set; }

        /// <summary>
        /// <p>起始地</p>
        /// </summary>
        [JsonProperty("DeparturePlace")]
        public string DeparturePlace{ get; set; }

        /// <summary>
        /// <p>到达地</p>
        /// </summary>
        [JsonProperty("ArrivalPlace")]
        public string ArrivalPlace{ get; set; }

        /// <summary>
        /// <p>运输货物名称</p>
        /// </summary>
        [JsonProperty("TransportItemsName")]
        public string TransportItemsName{ get; set; }

        /// <summary>
        /// <p>建筑服务发生地</p>
        /// </summary>
        [JsonProperty("ConstructionPlace")]
        public string ConstructionPlace{ get; set; }

        /// <summary>
        /// <p>建筑项目名称</p>
        /// </summary>
        [JsonProperty("ConstructionName")]
        public string ConstructionName{ get; set; }

        /// <summary>
        /// <p>原始税率</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalTaxRate")]
        public string OriginalTaxRate{ get; set; }

        /// <summary>
        /// <p>原始税额</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalTaxAmount")]
        public string OriginalTaxAmount{ get; set; }

        /// <summary>
        /// <p>零税率标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZeroTaxRateMark")]
        public string ZeroTaxRateMark{ get; set; }

        /// <summary>
        /// <p>含税单价</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxIncludedUnitPrice")]
        public string TaxIncludedUnitPrice{ get; set; }

        /// <summary>
        /// <p>含税金额</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxIncludedAmount")]
        public float? TaxIncludedAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LineNo", this.LineNo);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "TaxClassifyCode", this.TaxClassifyCode);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "VehicleBrand", this.VehicleBrand);
            this.SetParamSimple(map, prefix + "DeparturePlace", this.DeparturePlace);
            this.SetParamSimple(map, prefix + "ArrivalPlace", this.ArrivalPlace);
            this.SetParamSimple(map, prefix + "TransportItemsName", this.TransportItemsName);
            this.SetParamSimple(map, prefix + "ConstructionPlace", this.ConstructionPlace);
            this.SetParamSimple(map, prefix + "ConstructionName", this.ConstructionName);
            this.SetParamSimple(map, prefix + "OriginalTaxRate", this.OriginalTaxRate);
            this.SetParamSimple(map, prefix + "OriginalTaxAmount", this.OriginalTaxAmount);
            this.SetParamSimple(map, prefix + "ZeroTaxRateMark", this.ZeroTaxRateMark);
            this.SetParamSimple(map, prefix + "TaxIncludedUnitPrice", this.TaxIncludedUnitPrice);
            this.SetParamSimple(map, prefix + "TaxIncludedAmount", this.TaxIncludedAmount);
        }
    }
}

