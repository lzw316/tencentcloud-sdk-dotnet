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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefundCloudOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 用户Id，长度不小于5位，仅支持字母和数字的组合
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 退款订单号，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合
        /// </summary>
        [JsonProperty("RefundId")]
        public string RefundId{ get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// 当该字段为空或者为0时，系统会默认使用订单当实付金额作为退款金额
        /// </summary>
        [JsonProperty("TotalRefundAmt")]
        public long? TotalRefundAmt{ get; set; }

        /// <summary>
        /// 商品订单，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 平台应收金额，单位：分
        /// </summary>
        [JsonProperty("PlatformRefundAmt")]
        public long? PlatformRefundAmt{ get; set; }

        /// <summary>
        /// 结算应收金额，单位：分
        /// </summary>
        [JsonProperty("MchRefundAmt")]
        public long? MchRefundAmt{ get; set; }

        /// <summary>
        /// 支持多个子订单批量退款单个子订单退款支持传SubOutTradeNo
        /// 也支持传SubOrderRefundList，都传的时候以SubOrderRefundList为准。
        /// 如果传了子单退款细节，外部不需要再传退款金额，平台应退，商户应退金额
        /// </summary>
        [JsonProperty("SubOrderRefundList")]
        public CloudSubOrderRefund[] SubOrderRefundList{ get; set; }

        /// <summary>
        /// 渠道订单号，当出现重复支付时，可以将重复支付订单的渠道订单号传入，以进行退款（注意：目前该重复支付订单的渠道订单号仅能通过米大师内部获取），更多重复支付订单退款说明，请参考[重复支付订单退款说明](https://dev.tke.midas.qq.com/juxin-doc-next/apidocs/receive-order/Refund.html#%E9%87%8D%E5%A4%8D%E6%94%AF%E4%BB%98%E8%AE%A2%E5%8D%95%E9%80%80%E6%AC%BE%E8%AF%B4%E6%98%8E)
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        [JsonProperty("RefundNotifyUrl")]
        public string RefundNotifyUrl{ get; set; }

        /// <summary>
        /// 透传字段，退款成功回调透传给应用，用于开发者透传自定义内容
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 渠道扩展退款促销列表，可将各个渠道的退款促销信息放于该列表
        /// </summary>
        [JsonProperty("ExternalRefundPromptGroupList")]
        public string ExternalRefundPromptGroupList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "RefundId", this.RefundId);
            this.SetParamSimple(map, prefix + "TotalRefundAmt", this.TotalRefundAmt);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "PlatformRefundAmt", this.PlatformRefundAmt);
            this.SetParamSimple(map, prefix + "MchRefundAmt", this.MchRefundAmt);
            this.SetParamArrayObj(map, prefix + "SubOrderRefundList.", this.SubOrderRefundList);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "RefundNotifyUrl", this.RefundNotifyUrl);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "ExternalRefundPromptGroupList", this.ExternalRefundPromptGroupList);
        }
    }
}

