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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGatewayFlowQosRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例ID，目前我们支持的网关实例类型有，<br>专线网关实例ID，形如，<code>dcg-ltjahce6</code>；<br>Nat网关实例ID，形如，<code>nat-ltjahce6</code>；<br>VPN网关实例ID，形如，<code>vpn-ltjahce6</code>。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>流控带宽值。取值大于0，表示限流到指定的Mbps；取值等于0，表示完全限流；取值为-1，不限流。</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// <p>限流的云服务器内网IP。</p><p>参数格式：10.0.0.2</p>
        /// </summary>
        [JsonProperty("IpAddresses")]
        public string[] IpAddresses{ get; set; }

        /// <summary>
        /// <p>限流方向，取值为In代表入向，Out代表出向。当前仅标准型Nat实例网关流控带宽方向可设置入向限流。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArraySimple(map, prefix + "IpAddresses.", this.IpAddresses);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

