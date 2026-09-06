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

    public class VehicleInvoiceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>车辆类型</p>
        /// </summary>
        [JsonProperty("CarType")]
        public string CarType{ get; set; }

        /// <summary>
        /// <p>厂牌型号</p>
        /// </summary>
        [JsonProperty("PlateModel")]
        public string PlateModel{ get; set; }

        /// <summary>
        /// <p>产地</p>
        /// </summary>
        [JsonProperty("ProduceAddress")]
        public string ProduceAddress{ get; set; }

        /// <summary>
        /// <p>合格证号</p>
        /// </summary>
        [JsonProperty("CertificateNo")]
        public string CertificateNo{ get; set; }

        /// <summary>
        /// <p>进口证明书号</p>
        /// </summary>
        [JsonProperty("ImportNo")]
        public string ImportNo{ get; set; }

        /// <summary>
        /// <p>LSVCA2NP9HN0xxxxx</p>
        /// </summary>
        [JsonProperty("VinNo")]
        public string VinNo{ get; set; }

        /// <summary>
        /// <p>完税证书号</p>
        /// </summary>
        [JsonProperty("PayTaxesNo")]
        public string PayTaxesNo{ get; set; }

        /// <summary>
        /// <p>吨位</p>
        /// </summary>
        [JsonProperty("Tonnage")]
        public string Tonnage{ get; set; }

        /// <summary>
        /// <p>限乘人数</p>
        /// </summary>
        [JsonProperty("LimitCount")]
        public string LimitCount{ get; set; }

        /// <summary>
        /// <p>发动机号码</p>
        /// </summary>
        [JsonProperty("EngineNo")]
        public string EngineNo{ get; set; }

        /// <summary>
        /// <p>商检单号</p>
        /// </summary>
        [JsonProperty("BizCheckFormNo")]
        public string BizCheckFormNo{ get; set; }

        /// <summary>
        /// <p>主管税务机关代码</p>
        /// </summary>
        [JsonProperty("TaxtationOrgCode")]
        public string TaxtationOrgCode{ get; set; }

        /// <summary>
        /// <p>主管税务机关名称</p>
        /// </summary>
        [JsonProperty("TaxtationOrgName")]
        public string TaxtationOrgName{ get; set; }

        /// <summary>
        /// <p>税率</p>
        /// </summary>
        [JsonProperty("MotorTaxRate")]
        public string MotorTaxRate{ get; set; }

        /// <summary>
        /// <p>银行账号</p>
        /// </summary>
        [JsonProperty("MotorBankName")]
        public string MotorBankName{ get; set; }

        /// <summary>
        /// <p>开户行</p>
        /// </summary>
        [JsonProperty("MotorBankAccount")]
        public string MotorBankAccount{ get; set; }

        /// <summary>
        /// <p>销售地址</p>
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// <p>销售电话</p>
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// <p>购方身份证</p>
        /// </summary>
        [JsonProperty("BuyerNo")]
        public string BuyerNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CarType", this.CarType);
            this.SetParamSimple(map, prefix + "PlateModel", this.PlateModel);
            this.SetParamSimple(map, prefix + "ProduceAddress", this.ProduceAddress);
            this.SetParamSimple(map, prefix + "CertificateNo", this.CertificateNo);
            this.SetParamSimple(map, prefix + "ImportNo", this.ImportNo);
            this.SetParamSimple(map, prefix + "VinNo", this.VinNo);
            this.SetParamSimple(map, prefix + "PayTaxesNo", this.PayTaxesNo);
            this.SetParamSimple(map, prefix + "Tonnage", this.Tonnage);
            this.SetParamSimple(map, prefix + "LimitCount", this.LimitCount);
            this.SetParamSimple(map, prefix + "EngineNo", this.EngineNo);
            this.SetParamSimple(map, prefix + "BizCheckFormNo", this.BizCheckFormNo);
            this.SetParamSimple(map, prefix + "TaxtationOrgCode", this.TaxtationOrgCode);
            this.SetParamSimple(map, prefix + "TaxtationOrgName", this.TaxtationOrgName);
            this.SetParamSimple(map, prefix + "MotorTaxRate", this.MotorTaxRate);
            this.SetParamSimple(map, prefix + "MotorBankName", this.MotorBankName);
            this.SetParamSimple(map, prefix + "MotorBankAccount", this.MotorBankAccount);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "BuyerNo", this.BuyerNo);
        }
    }
}

