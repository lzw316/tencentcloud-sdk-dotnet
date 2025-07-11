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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPSECOptionsSpecification : AbstractModel
    {
        
        /// <summary>
        /// PFS：可选值：'NULL', 'DH-GROUP1', 'DH-GROUP2', 'DH-GROUP5', 'DH-GROUP14', 'DH-GROUP24'，默认为NULL
        /// </summary>
        [JsonProperty("PfsDhGroup")]
        public string PfsDhGroup{ get; set; }

        /// <summary>
        /// IPsec SA lifetime(KB)：单位KB，取值范围：2560-604800
        /// </summary>
        [JsonProperty("IPSECSaLifetimeTraffic")]
        public ulong? IPSECSaLifetimeTraffic{ get; set; }

        /// <summary>
        /// 加密算法，可选值：'3DES-CBC', 'AES-CBC-128', 'AES-CBC-192', 'AES-CBC-256', 'DES-CBC', 'NULL'， 默认为AES-CBC-128
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// 认证算法：可选值：'MD5', 'SHA1'，默认为
        /// </summary>
        [JsonProperty("IntegrityAlgorith")]
        public string IntegrityAlgorith{ get; set; }

        /// <summary>
        /// IPsec SA lifetime(s)：单位秒，取值范围：180-604800
        /// </summary>
        [JsonProperty("IPSECSaLifetimeSeconds")]
        public ulong? IPSECSaLifetimeSeconds{ get; set; }

        /// <summary>
        /// 安全协议，默认为ESP
        /// </summary>
        [JsonProperty("SecurityProto")]
        public string SecurityProto{ get; set; }

        /// <summary>
        /// 报文封装模式:默认为Tunnel
        /// </summary>
        [JsonProperty("EncapMode")]
        public string EncapMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PfsDhGroup", this.PfsDhGroup);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeTraffic", this.IPSECSaLifetimeTraffic);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamSimple(map, prefix + "IntegrityAlgorith", this.IntegrityAlgorith);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeSeconds", this.IPSECSaLifetimeSeconds);
            this.SetParamSimple(map, prefix + "SecurityProto", this.SecurityProto);
            this.SetParamSimple(map, prefix + "EncapMode", this.EncapMode);
        }
    }
}

