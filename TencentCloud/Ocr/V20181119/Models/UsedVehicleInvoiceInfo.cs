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

    public class UsedVehicleInvoiceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>所属税局</p>
        /// </summary>
        [JsonProperty("TaxBureau")]
        public string TaxBureau{ get; set; }

        /// <summary>
        /// <p>买方单位/个人</p>
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// <p>买方单位代码/身份证号码</p>
        /// </summary>
        [JsonProperty("BuyerNo")]
        public string BuyerNo{ get; set; }

        /// <summary>
        /// <p>买方单位/个人地址</p>
        /// </summary>
        [JsonProperty("BuyerAddress")]
        public string BuyerAddress{ get; set; }

        /// <summary>
        /// <p>买方单位电话</p>
        /// </summary>
        [JsonProperty("BuyerTel")]
        public string BuyerTel{ get; set; }

        /// <summary>
        /// <p>卖方单位/个人</p>
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// <p>卖方单位代码/身份证号码</p>
        /// </summary>
        [JsonProperty("SellerNo")]
        public string SellerNo{ get; set; }

        /// <summary>
        /// <p>卖方单位/个人地址</p>
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// <p>卖方单位电话</p>
        /// </summary>
        [JsonProperty("SellerTel")]
        public string SellerTel{ get; set; }

        /// <summary>
        /// <p>车牌照号</p>
        /// </summary>
        [JsonProperty("VehicleLicenseNo")]
        public string VehicleLicenseNo{ get; set; }

        /// <summary>
        /// <p>登记证号</p>
        /// </summary>
        [JsonProperty("RegisterNo")]
        public string RegisterNo{ get; set; }

        /// <summary>
        /// <p>车架号/车辆识别代码</p>
        /// </summary>
        [JsonProperty("VehicleIdentifyNo")]
        public string VehicleIdentifyNo{ get; set; }

        /// <summary>
        /// <p>转入地车辆管理所名称</p>
        /// </summary>
        [JsonProperty("ManagementOffice")]
        public string ManagementOffice{ get; set; }

        /// <summary>
        /// <p>车价合计</p>
        /// </summary>
        [JsonProperty("VehicleTotalPrice")]
        public string VehicleTotalPrice{ get; set; }

        /// <summary>
        /// <p>经营、拍卖单位</p>
        /// </summary>
        [JsonProperty("Auctioneer")]
        public string Auctioneer{ get; set; }

        /// <summary>
        /// <p>经营、拍卖单位地址</p>
        /// </summary>
        [JsonProperty("AuctioneerAddress")]
        public string AuctioneerAddress{ get; set; }

        /// <summary>
        /// <p>经营、拍卖单位纳税人识别号</p>
        /// </summary>
        [JsonProperty("AuctioneerTaxpayerNum")]
        public string AuctioneerTaxpayerNum{ get; set; }

        /// <summary>
        /// <p>经营、拍卖单位开户银行、账号</p>
        /// </summary>
        [JsonProperty("AuctioneerBankAccount")]
        public string AuctioneerBankAccount{ get; set; }

        /// <summary>
        /// <p>经营、拍卖单位电话</p>
        /// </summary>
        [JsonProperty("AuctioneerTel")]
        public string AuctioneerTel{ get; set; }

        /// <summary>
        /// <p>二手车市场</p>
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// <p>二手车市场纳税人识别号</p>
        /// </summary>
        [JsonProperty("MarketTaxpayerNum")]
        public string MarketTaxpayerNum{ get; set; }

        /// <summary>
        /// <p>二手车市场地址</p>
        /// </summary>
        [JsonProperty("MarketAddress")]
        public string MarketAddress{ get; set; }

        /// <summary>
        /// <p>二手车市场开户银行账号</p>
        /// </summary>
        [JsonProperty("MarketBankAccount")]
        public string MarketBankAccount{ get; set; }

        /// <summary>
        /// <p>二手车市场电话</p>
        /// </summary>
        [JsonProperty("MarketTel")]
        public string MarketTel{ get; set; }

        /// <summary>
        /// <p>车价合计中文大写</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VehicleTotalPriceCN")]
        public string VehicleTotalPriceCN{ get; set; }

        /// <summary>
        /// <p>发票风险等级</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvoiceRiskLevel")]
        public string InvoiceRiskLevel{ get; set; }

        /// <summary>
        /// <p>车辆类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CarType")]
        public string CarType{ get; set; }

        /// <summary>
        /// <p>厂牌型号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlateModel")]
        public string PlateModel{ get; set; }

        /// <summary>
        /// <p>作废人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbandonerName")]
        public string AbandonerName{ get; set; }

        /// <summary>
        /// <p>作废日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbandonDate")]
        public string AbandonDate{ get; set; }

        /// <summary>
        /// <p>开票方类型：1 经营单位，2 拍卖单位，03 二手车市场。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IssuerType")]
        public string IssuerType{ get; set; }

        /// <summary>
        /// <p>开票方纳税人识别号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IssuerTaxCode")]
        public string IssuerTaxCode{ get; set; }

        /// <summary>
        /// <p>自行编码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomCode")]
        public string CustomCode{ get; set; }

        /// <summary>
        /// <p>商品编码</p>
        /// </summary>
        [JsonProperty("TaxClassifyCode")]
        public string TaxClassifyCode{ get; set; }

        /// <summary>
        /// <p>零税率标识：空：非零税率，0：出口零税，1：免税，2：不征税，3 普通零税率</p>
        /// </summary>
        [JsonProperty("ZeroTaxRateMark")]
        public string ZeroTaxRateMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaxBureau", this.TaxBureau);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerNo", this.BuyerNo);
            this.SetParamSimple(map, prefix + "BuyerAddress", this.BuyerAddress);
            this.SetParamSimple(map, prefix + "BuyerTel", this.BuyerTel);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerNo", this.SellerNo);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerTel", this.SellerTel);
            this.SetParamSimple(map, prefix + "VehicleLicenseNo", this.VehicleLicenseNo);
            this.SetParamSimple(map, prefix + "RegisterNo", this.RegisterNo);
            this.SetParamSimple(map, prefix + "VehicleIdentifyNo", this.VehicleIdentifyNo);
            this.SetParamSimple(map, prefix + "ManagementOffice", this.ManagementOffice);
            this.SetParamSimple(map, prefix + "VehicleTotalPrice", this.VehicleTotalPrice);
            this.SetParamSimple(map, prefix + "Auctioneer", this.Auctioneer);
            this.SetParamSimple(map, prefix + "AuctioneerAddress", this.AuctioneerAddress);
            this.SetParamSimple(map, prefix + "AuctioneerTaxpayerNum", this.AuctioneerTaxpayerNum);
            this.SetParamSimple(map, prefix + "AuctioneerBankAccount", this.AuctioneerBankAccount);
            this.SetParamSimple(map, prefix + "AuctioneerTel", this.AuctioneerTel);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "MarketTaxpayerNum", this.MarketTaxpayerNum);
            this.SetParamSimple(map, prefix + "MarketAddress", this.MarketAddress);
            this.SetParamSimple(map, prefix + "MarketBankAccount", this.MarketBankAccount);
            this.SetParamSimple(map, prefix + "MarketTel", this.MarketTel);
            this.SetParamSimple(map, prefix + "VehicleTotalPriceCN", this.VehicleTotalPriceCN);
            this.SetParamSimple(map, prefix + "InvoiceRiskLevel", this.InvoiceRiskLevel);
            this.SetParamSimple(map, prefix + "CarType", this.CarType);
            this.SetParamSimple(map, prefix + "PlateModel", this.PlateModel);
            this.SetParamSimple(map, prefix + "AbandonerName", this.AbandonerName);
            this.SetParamSimple(map, prefix + "AbandonDate", this.AbandonDate);
            this.SetParamSimple(map, prefix + "IssuerType", this.IssuerType);
            this.SetParamSimple(map, prefix + "IssuerTaxCode", this.IssuerTaxCode);
            this.SetParamSimple(map, prefix + "CustomCode", this.CustomCode);
            this.SetParamSimple(map, prefix + "TaxClassifyCode", this.TaxClassifyCode);
            this.SetParamSimple(map, prefix + "ZeroTaxRateMark", this.ZeroTaxRateMark);
        }
    }
}

