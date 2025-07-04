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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FirewallRule : AbstractModel
    {
        
        /// <summary>
        /// 协议，取值：TCP，UDP，ICMP，ALL，ICMPv6。
        /// 
        /// - 使用ICMP协议时，只支持CidrBlock，不支持使用Port、Ipv6CidrBlock参数；
        /// - 使用ICMPv6协议时，只支持Ipv6CidrBlock，不支持使用Port、Ipv6CidrBlock参数；
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口，取值：ALL，单独的端口，逗号分隔的离散端口，减号分隔的端口范围。注意：单独的端口与离散端口不能同时存在。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// IPv4网段或 IPv4地址(互斥)。
        /// 示例值：0.0.0.0/0。
        /// 
        /// 和Ipv6CidrBlock互斥，两者都不指定时，如果Protocol不是ICMPv6，则取默认值0.0.0.0/0。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// IPv6网段或IPv6地址(互斥)。
        /// 示例值：::/0。
        /// 
        /// 和CidrBlock互斥，两者都不指定时，如果Protocol是ICMPv6，则取默认值::/0。
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// 取值：ACCEPT（允许），DROP（拒绝）。默认为 ACCEPT。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 防火墙规则描述。
        /// </summary>
        [JsonProperty("FirewallRuleDescription")]
        public string FirewallRuleDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "FirewallRuleDescription", this.FirewallRuleDescription);
        }
    }
}

